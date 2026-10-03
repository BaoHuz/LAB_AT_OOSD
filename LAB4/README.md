# THÔNG TIN BÁO CÁO THỰC HÀNH LAB 4

- **Họ và tên:** Nguyễn Hữu Bảo
- **Mã số sinh viên (MSSV):** 1250080016
- **Lớp:** 12_ĐH_CNPM1
- **Tên bài thực hành:** LAB 4 - Phân Tích & Thiết Kế Hệ Thống / Chuyển Đổi Mô Hình UML Sang CSDL
- **Tên Repository GitHub:** `LAB_AT_OOSD`

---

## 1. MÔI TRƯỜNG VÀ PHIÊN BẢN CÔNG CỤ (ENVIRONMENT / VERSIONS)

- **Hệ điều hành:** Windows 10 / Windows 11 (64-bit)
- **IDE / Environment:** Visual Studio 2022 (Community / Professional)
- **Framework:** .NET Framework 4.7.2 (WinForms C#)
- **Hệ quản trị CSDL:** Microsoft SQL Server 2019 / 2022 (SQL Server Management Studio - SSMS)
- **Công cụ vẽ sơ đồ UML:** Draw.io / PlantUML
- **Quản lý mã nguồn:** Git & GitHub

---

## 2. NỘI DUNG ĐÃ THỰC HIỆN

Thư mục `LAB4` bao gồm 02 bài tập chính:

### 📄 Bài 1 (`Bai1_SoDo`)
* **Mục tiêu:** Chuyển đổi sơ đồ Lớp (Class Diagram) hệ thống Quản lý Nhân viên Kinh doanh & Đơn hàng sang CSDL quan hệ chuẩn 3NF.
* **Các nội dung đã hoàn thành:**
  1. Phân tích các quy tắc chuyển đổi:
     - Kế thừa 2 tầng (`NHAN_VIEN` → `NV_KINH_DOANH` → `NV_KD_LAU_NAM` / `NV_KD_TAP_SU`).
     - Mối quan hệ tự tham chiếu 1-N (Hướng dẫn).
     - Lớp liên kết (Association Class) `THUONG_LUONG` biểu diễn quan hệ N-N có thuộc tính `HoaHong`.
     - Quan hệ 1-N giữa `NHAN_VIEN` và `QUA_TRINH_TANG_LUONG`.
  2. Đánh giá tính toàn vẹn và mức chuẩn hóa CSDL (Đạt chuẩn 3NF).
  3. Viết đầy đủ Script SQL DDL (`QuanLyNhanVienKD_DB`) với các ràng buộc khóa chính, khóa ngoại, CHECK, UNIQUE.
  4. Xây dựng bộ sơ đồ: Relational Model, Class Diagram, Sequence Diagram, State Machine Diagram, Activity Diagram.

### 💻 Bài 2 (`Bai2_LAB_shopping`)
* **Mục tiêu:** Xây dựng tài liệu Phân tích & Thiết kế hệ thống cùng phần mềm Prototype WinForms C# cho Cửa hàng Online "e-SHOPPING".
* **Các nội dung đã hoàn thành:**
  1. **Phân tích System Boundaries:** Phân định rõ biên giới nội bộ e-SHOPPING và 3 dịch vụ ngoài (`Product System`, `Payment Gateway`, `Email Service`).
  2. **Mô hình UML:** Xây dựng Sơ đồ Use Case Tổng quan, Sơ đồ Use Case Chi tiết cho `UC01` (Duyệt & Xem Chi Tiết SP) và `UC05` (Đặt Hàng & Thanh Toán), Class Diagram, Sequence Diagram, State Machine Diagram, Activity Diagram.
  3. **Thiết kế CSDL SQL Server:** Bảng `KhachHang`, `NhomSanPham`, `SanPham`, `DonHang`, `ChiTietDonHang` với tính năng Masking số thẻ bảo mật (`**** **** **** 1234`).
  4. **Hiện thực C# WinForms Prototype (Kiến trúc 3 Tầng):**
     - **Tầng Data:** `Db.cs` quản lý SQL Connection và Execute Transaction.
     - **Tầng Services/Adapters:** `OrderService.cs` (tính phí CPN/CPN trong ngày, miễn phí giao), `ProductAdapter.cs`, `PaymentAdapter.cs` (kiểm tra định dạng thẻ VISA, Master, Amex, CSV), `EmailAdapter.cs`, `AccountService.cs`.
     - **Tầng UI:** `frmMain` (điều hướng MDI), `frmDanhSachSanPham` (chọn nhóm, giỏ hàng, nút Xem chi tiết SP), `frmChiTietSanPham` (popup thông tin kỹ thuật), `frmThanhToan`, `frmDangNhap`, `frmDangKy`.
  5. **Kiểm thử:** Xây dựng Ma trận truy vết yêu cầu (Traceability Matrix) và Kịch bản kiểm thử (Test Cases).

---

## 3. KẾT QUẢ ĐẠT ĐƯỢC

1. Script SQL thực thi 100% thành công trên SQL Server, không lỗi cú pháp hay ràng buộc khóa.
2. Ứng dụng C# WinForms khởi chạy ổn định, chuyển đổi mượt mà giữa các MDI Child Forms.
3. Chức năng tính phí giao hàng tự động cập nhật đúng theo loại phiếu đặt và trị giá hóa đơn.
4. Ghi nhận đơn hàng an toàn tuyệt đối nhờ cơ chế **SQL Transaction** (Rollback khi gặp lỗi kết nối hoặc thẻ không hợp lệ).
5. Giao diện đầy đủ, bao gồm nút **"Xem chi tiết SP"** hiển thị popup đúng thông số kỹ thuật sản phẩm.

---

## 4. LỖI GẶP PHẢI VÀ CÁCH KHẮC PHỤC

| STT | Lỗi gặp phải (Issue) | Nguyên nhân (Root Cause) | Cách khắc phục (Fix) |
|---|---|---|---|
| **1** | Bấm menu "Danh sách sản phẩm" trên `frmMain` nhưng giao diện không phản hồi/không bật thêm cửa sổ. | Do logic chống mở trùng Form MDI chỉ thực hiện `Activate()` lại Form đang mở. Trên Form `frmDanhSachSanPham` ban đầu bị thiếu nút **"Xem chi tiết SP"**. | Bổ sung control `btnXemChiTiet` vào file `frmDanhSachSanPham.Designer.cs` và gắn sự kiện `Click` gọi `frmChiTietSanPham.ShowDialog()`. |
| **2** | Thẻ Amex nhập 15 số nhưng hệ thống báo lỗi không thanh toán được. | `PaymentAdapter.cs` kiểm tra sai quy tắc độ dài số thẻ và mã CSV cho dòng thẻ American Express. | Cập nhật lại điều kiện validate trong `PaymentAdapter.cs`: Thẻ Amex chấp nhận số thẻ 15 chữ số và mã CSV 4 chữ số. |
| **3** | Không lưu được dữ liệu khi đặt nhiều sản phẩm cùng lúc. | Transaction bị ngắt giữa chừng do vi phạm ràng buộc CHECK đơn giá/số lượng hoặc đụng độ khóa chính. | Kiểm tra ràng buộc CSDL, bao bọc toàn bộ khối lệnh `INSERT DonHang` và `INSERT ChiTietDonHang` bằng `SqlTransaction` kết hợp `try...catch` Rollback an toàn. |

---

## 5. HƯỚNG DẪN KIỂM THỬ VÀ CHẠY DỰ ÁN (FOR GRADING / TESTING)

### 🗄️ Bước 1: Cấu hình Cơ sở dữ liệu (SQL Server)
1. Mở **SQL Server Management Studio (SSMS)**.
2. Mở và thực thi (Execute `F5`) file Script SQL:
   - Bài 1: `QuanLyNhanVienKD_DB` trong tài liệu Bài 1.
   - Bài 2: `eShoppingDB.sql` trong thư mục `Bai2_LAB_shopping`.
3. Cập nhật Chuỗi kết nối (Connection String) trong file `Data/Db.cs` trùng khớp với tên SQL Server Instance trên máy kiểm thử:
   ```csharp
   private static string connectionString = @"Data Source=.;Initial Catalog=eShoppingDB;Integrated Security=True";
### 🚀 Bước 2: Chạy ứng dụng WinForms C# (Bài 2)
1. Mở Solution `eShoppingSolution.sln` trong thư mục `Bai2_LAB_shopping/UI` bằng **Visual Studio 2022**.
2. Bấm phím **`F5`** (hoặc nút **Start**) để biên dịch và chạy dự án.
3. **Kịch bản kiểm thử đề xuất cho Giảng viên:**
   - **Đăng nhập:** Đăng nhập tài khoản test (Tên đăng nhập: `nguyenvanan` | Mật khẩu: `123456`).
   - **Xem chi tiết:** Chọn sản phẩm `SP001` trên DataGridView → Bấm **"Xem chi tiết SP"** để kiểm tra Form Popup.
   - **Thêm giỏ hàng & Đặt hàng:** Thêm sản phẩm vào giỏ → Bấm **"TÍNH TIỀN (ĐẶT HÀNG)"**.
   - **Thanh toán:** Nhập thông tin người nhận, chọn loại thẻ **VISA** (`4111222233331234`), mã CSV (`123`) → Bấm **XÁC NHẬN** để kiểm tra SQL Transaction và Masking thẻ.