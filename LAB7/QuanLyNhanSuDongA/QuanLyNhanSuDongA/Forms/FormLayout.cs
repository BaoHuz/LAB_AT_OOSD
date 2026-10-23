using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyNhanSuDongA.Forms
{
    internal static class FormLayout
    {
        public static void Apply(Form form)
        {
            form.SuspendLayout();
            var content = Arrange(form);
            form.AutoScroll = true;
            form.ClientSize = new Size(Math.Max(800, form.ClientSize.Width),
                Math.Min(content.PreferredSize.Height + 16, Screen.FromControl(form).WorkingArea.Height - 100));
            form.ResumeLayout(true);
        }

        private static TableLayoutPanel Arrange(Control container)
        {
            var controls = container.Controls.Cast<Control>().ToArray();
            var layout = new TableLayoutPanel
            {
                Name = "InputLayout", ColumnCount = 1, AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink, Dock = DockStyle.Top,
                Padding = new Padding(10), Margin = Padding.Empty, TabStop = false
            };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            var rows = new List<List<Control>>();
            foreach (var control in controls.OrderBy(c => c.Top))
            {
                if (rows.Count == 0 || control.Top - rows[rows.Count - 1][0].Top > 8)
                    rows.Add(new List<Control>());
                rows[rows.Count - 1].Add(control);
            }
            container.Controls.Clear();
            container.Controls.Add(layout);
            foreach (var sourceRow in rows)
            {
                var originalRow = sourceRow.OrderBy(c => c.Left).ToArray();
                var blocks = originalRow.Where(c => c is TabControl || c is GroupBox || c is DataGridView).ToArray();
                var editors = originalRow.Except(blocks).Where(c => !(c is Label)).ToArray();
                var labels = originalRow.OfType<Label>().ToList();
                for (int offset = 0; offset < editors.Length; offset += 4)
                {
                    var fields = editors.Skip(offset).Take(4).ToArray();
                    var row = new TableLayoutPanel
                    {
                        ColumnCount = fields.Length, RowCount = 2, AutoSize = true,
                        Dock = DockStyle.Top, Margin = new Padding(0, 0, 0, 8), TabStop = false
                    };
                    row.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    row.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    for (int i = 0; i < fields.Length; i++)
                    {
                        row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / fields.Length));
                        var editor = fields[i];
                        var label = labels.Where(l => l.Left <= editor.Left).OrderByDescending(l => l.Left).FirstOrDefault();
                        if (label != null)
                        {
                            labels.Remove(label);
                            label.AutoSize = true;
                            label.Dock = DockStyle.None;
                            label.Margin = new Padding(4, 2, 8, 5);
                            row.Controls.Add(label, i, 0);
                        }
                        editor.Dock = DockStyle.Fill;
                        editor.Margin = new Padding(4, 0, 8, 4);
                        editor.MinimumSize = new Size(0, editor.PreferredSize.Height);
                        var button = editor as Button;
                        if (button != null)
                        {
                            button.AutoSize = true;
                            button.Padding = new Padding(10, 3, 10, 3);
                            button.Anchor = AnchorStyles.Right;
                            button.Dock = DockStyle.None;
                        }
                        row.Controls.Add(editor, i, 1);
                    }
                    AddRow(layout, row);
                }
                foreach (var block in blocks)
                {
                    var tabs = block as TabControl;
                    if (tabs != null)
                    {
                        int height = 0;
                        foreach (TabPage page in tabs.TabPages)
                        {
                            var pageLayout = Arrange(page);
                            page.AutoScroll = true;
                            height = Math.Max(height, pageLayout.PreferredSize.Height);
                        }
                        tabs.Height = height + tabs.ItemSize.Height + 16;
                    }
                    var group = block as GroupBox;
                    if (group != null)
                    {
                        var groupLayout = Arrange(group);
                        group.Height = groupLayout.PreferredSize.Height + group.Font.Height + 12;
                    }
                    var grid = block as DataGridView;
                    if (grid != null)
                    {
                        grid.Height = Math.Max(180, grid.Height);
                        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    }
                    block.Dock = DockStyle.Top;
                    block.Margin = new Padding(0, 0, 0, 8);
                    AddRow(layout, block);
                }
            }
            layout.PerformLayout();
            return layout;
        }

        private static void AddRow(TableLayoutPanel layout, Control control)
        {
            int index = layout.RowCount++;
            layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            layout.Controls.Add(control, 0, index);
        }
    }
}
