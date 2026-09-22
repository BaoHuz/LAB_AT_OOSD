\# LAB 2: HỆ THỐNG QUẢN LÝ THƯ VIỆN (LIBRARY MANAGEMENT SYSTEM)



\*\*Môn học:\*\* Phương pháp phát triển phần mềm hướng đối tượng  

\*\*Giảng viên hướng dẫn:\*\* Phạm Trọng Huynh

\*\*Sinh viên thực hiện:\*\* Nguyễn Hữu Bảo 



\---



\## 📌 Giới thiệu dự án

Dự án \*\*Quản Lý Thư Viện\*\* được xây dựng trên nền tảng \*\*Windows Forms (.NET Framework 4.7.2)\*\* kết hợp với cơ sở dữ liệu \*\*SQL Server\*\*. Hệ thống cung cấp giải pháp toàn diện cho thủ thư trong việc quản lý danh mục, độc giả, đầu sách, quy trình mượn - trả sách và thống kê báo cáo.



\---



\## 🚀 Các chức năng chính



1\. \*\*Quản lý Danh mục \& Nhân viên (`FrmDanhMuc`)\*\*:

&#x20;  \* Quản lý thông tin Nhân viên (Thêm, sửa, xóa, làm mới).

&#x20;  \* Quản lý Danh mục Thể loại sách và Nhà xuất bản.

2\. \*\*Quản lý Đầu sách (`FrmSach`)\*\*:

&#x20;  \* Quản lý thông tin sách: Mã sách, tên sách, năm xuất bản, số lượng, thể loại, NXB.

&#x20;  \* Tìm kiếm đầu sách theo từ khóa linh hoạt.

3\. \*\*Quản lý Độc giả \& Thẻ thư viện (`FrmDocGia`)\*\*:

&#x20;  \* Quản lý hồ sơ độc giả (Thông tin cá nhân, ảnh 3x4).

&#x20;  \* Cấp thẻ thư viện mới, gia hạn thời hạn sử dụng thẻ và quản lý lệ phí.

4\. \*\*Quản lý Mượn - Trả sách (`FrmMuonTra`)\*\*:

&#x20;  \* \*\*Mượn sách\*\*: Kiểm tra điều kiện thẻ độc giả, chọn tối đa 3 đầu sách/lần mượn, lập phiếu mượn.

&#x20;  \* \*\*Trả sách\*\*: Tra cứu sách đang mượn, xử lý trả sách, ghi nhận tình trạng (bình thường, hỏng, mất) và tính phí phạt.

5\. \*\*Thống kê \& Báo cáo (`FrmThongKe`)\*\*:

&#x20;  \* Thống kê tổng hợp theo khoảng thời gian: Lượt mượn, sách quá hạn, sách mất, sách hư hỏng, tổng tiền phạt.

&#x20;  \* Hiển thị danh sách chi tiết các trường hợp bị xử phạt.



\---



\## 🛠 Kiến trúc \& Công nghệ sử dụng



\* \*\*Ngôn ngữ lập trình:\*\* C# (.NET Framework 4.7.2)

\* \*\*Giao diện:\*\* Windows Forms (WinForms)

\* \*\*Cơ sở dữ liệu:\*\* Microsoft SQL Server (`QuanLyThuVienDB`)

\* \*\*Mô hình kiến trúc:\*\* 3-Tier Architecture

&#x20; \* \*\*`Data/Db.cs`\*\*: Lớp xử lý kết nối và truy vấn ADO.NET.

&#x20; \* \*\*`Services/`\*\*: Lớp xử lý logic nghiệp vụ (`SachService`, `DocGiaService`, `MuonTraService`, `ThongKeService`, `DanhMucService`).

&#x20; \* \*\*`Forms/`\*\*: Lớp giao diện người dùng (UI Forms).



\---



\## 📋 Hướng dẫn cài đặt \& Chạy dự án



\### 1. Chuẩn bị Cơ sở dữ liệu

1\. Mở \*\*SQL Server Management Studio (SSMS)\*\* hoặc \*\*Visual Studio\*\*.

2\. Mở file `QuanLyThuVien.sql` trong thư mục project và thực thi script (`Execute`) để tạo Database `QuanLyThuVienDB` cùng dữ liệu mẫu.



\### 2. Cấu hình Chuỗi kết nối (ConnectionString)

Mở file `App.config` trong dự án và chỉnh sửa thông số `Data Source` phù hợp với SQL Server trên máy của bạn:



```xml

<connectionStrings>

&#x20;   <add name="QuanLyThuVienDb" 

&#x20;        connectionString="Data Source=.;Initial Catalog=QuanLyThuVienDB;Integrated Security=True;" 

&#x20;        providerName="System.Data.SqlClient" />

</connectionStrings>

