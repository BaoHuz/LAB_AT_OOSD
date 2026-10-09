# BÁO CÁO THỰC HÀNH PHÂN TÍCH VÀ THIẾT KẾ PHẦN MỀM HƯỚNG ĐỐI TƯỢNG

## THÔNG TIN SV
- **Họ và tên**: Nguyễn Hữu Bảo
- **MSSV**: 1250080016
- **Lớp**: 12_ĐH_CNPM1
- **Tên bài Lab**: LAB 5 - Quản lý công ty du lịch Văn Hóa Việt (Bài 6)

---

## 1. MÔI TRƯỜNG & PHIÊN BẢN (ENVIRONMENT)
- **Hệ điều hành**: Windows 11 Pro 64-bit
- **IDE**: Visual Studio 2022 (Community / Professional)
- **Nền tảng**: .NET Framework 4.7.2 (Windows Forms App)
- **Ngôn ngữ**: C# (.NET)
- **Hệ quản trị CSDL**: SQL Server 2019 / SQL Server Express / LocalDB (`(localdb)\MSSQLLocalDB`)
- **Công cụ CSDL**: SQL Server Management Studio (SSMS) / SQL Server Object Explorer

---

## 2. NỘI DUNG ĐÃ THỰC HIỆN
Bài thực hành xây dựng ứng dụng Windows Forms quản lý công ty du lịch theo kiến trúc phân tầng rời rạc (WinForms UI $\rightarrow$ Services $\rightarrow$ Data/Db.cs $\rightarrow$ SQL Server):

1. **Cơ sở dữ liệu (Database)**:
   - Khởi tạo CSDL `QuanLyCongTyDuLich` với 15 bảng liên kết toàn vẹn (`CHECK`, `UNIQUE`, `FOREIGN KEY`).
   - Thiết lập các ràng buộc quy định kinh doanh (BR01, BR02, BR03, QD01, QD02,...).
2. **Kiến trúc mã nguồn**:
   - Tầng `Data`: `Db.cs` quản lý kết nối `SqlConnection`, thực thi Query, Execute, Scalar và tham số hóa `SqlParameter` chống SQL Injection.
   - Tầng `Services`: Lập trình các lớp nghiệp vụ tách rời UI bao gồm `DanhMucService`, `TourService`, `ChuyenLeService`, `DangKyLeService`, `DangKyDoanService`, `PhanCongService`, `KetThucService`, `ThongKeService`.
   - Tầng `Forms`: Thiết kế 9 Form giao diện chuẩn WinForms (`FrmMain`, `FrmDanhMuc`, `FrmTour`, `FrmChuyenLe`, `FrmDangKyLe`, `FrmDangKyDoan`, `FrmPhanCongHDV`, `FrmKetThucKhaoSat`, `FrmLuongThongKe`).
3. **Các tính năng nghiệp vụ hoàn thành**:
   - Quản lý danh mục (Phương tiện, Điểm bán vé, HDV, Điểm tham quan).
   - Thiết lập Tour, chi tiết điểm dừng, chặng phương tiện và điểm tham quan theo tour.
   - Quản lý lịch chuyến lẻ, tự động tính ngày về, mở/đóng đăng ký.
   - Đăng ký và thanh toán tiền vé cho nhóm khách lẻ (< 12 người).
   - Lập phiếu đăng ký đoàn (> 12 người), đặt cọc, nhập danh sách bảo hiểm (Sử dụng SQL Transaction) và xử lý hủy phiếu mất cọc.
   - Phân công HDV dẫn tour và kiểm tra chống trùng lịch công tác.
   - Thanh toán bổ sung sau tour cho đoàn khách và ghi nhận khảo sát ý kiến khách hàng.
   - Tính lương hàng tháng cho HDV và lập báo cáo thống kê doanh thu tổng hợp.

---

## 3. KẾT QUẢ ĐẠT ĐƯỢC
- Chạy thành công toàn bộ **24/24 Test Cases** theo yêu cầu đề bài.
- Ứng dụng đáp ứng đúng kiến trúc 3 lớp: không viết câu lệnh SQL trực tiếp trên các Form UI.
- Giao diện thân thiện, xử lý ngoại lệ chặt chẽ, thông báo kết quả rõ ràng qua `FormHelper`.

---

## 4. LỖI GẶP PHẢI & CÁCH KHẮC PHỤC

| STT | Mã lỗi / Hiện tượng | Nguyên nhân | Cách khắc phục |
| :---: | :--- | :--- | :--- |
| **1** | `CS0246: The type or namespace name 'DangKyDoanService' could not be found` | Thiếu file `DangKyDoanService.cs` (hoặc các file Service khác) trong thư mục `Services/`. | Bổ sung file class tương ứng vào thư mục `Services/` và đăng ký đúng namespace `QuanLyCongTyDuLich.Services`. |
| **2** | `SqlException: Cannot open database "QuanLyCongTyDuLich"` | CSDL chưa được khởi tạo trên SQL Server Instance hoặc chuỗi kết nối `connectionString` trong `App.config` trỏ sai Server Name. | Đổi `Data Source` trong `App.config` thành `.` / `.\SQLEXPRESS` / `(localdb)\MSSQLLocalDB` và chạy script tạo CSDL `QuanLyCongTyDuLich` trong SSMS. |
| **3** | `SqlException: Invalid column name 'MaPhanCong', 'LoaiPhanCong'` | Cấu trúc bảng `PhanCongHDV` dưới CSDL bị lệch tên cột so với câu lệnh truy vấn trong `PhanCongService.cs`. | Thực thi lại script `CREATE TABLE PhanCongHDV` chuẩn hóa đúng các thuộc tính `MaPhanCong`, `LoaiPhanCong`, `NgayPhanCong`. |
| **4** | `SqlException: Invalid object name 'PhieuThanhToanDoan'` / `'KhaoSatYKien'` | CSDL thiếu các bảng lưu trữ thông tin thanh toán đoàn bổ sung và phiếu khảo sát ý kiến. | Chạy script bổ sung bảng `PhieuThanhToanDoan` và `KhaoSatYKien` vào CSDL `QuanLyCongTyDuLich`. |

---

## 5. HƯỚNG DẪN KIỂM TRA & CHẠY LẠI (FOR TEACHER/EVALUATOR)

### Bước 1: Chuẩn bị CSDL SQL Server
1. Mở **SSMS** (SQL Server Management Studio) hoặc **SQL Server Object Explorer** trong Visual Studio.
2. Kết nối tới SQL Server (`.` hoặc `.\SQLEXPRESS` hoặc `(localdb)\MSSQLLocalDB`).
3. Mở file script SQL (có sẵn trong báo cáo/thư mục dự án) và thực thi để tạo CSDL `QuanLyCongTyDuLich` cùng các dữ liệu mẫu.

### Bước 2: Cấu hình Chuỗi Kết nối
Mở file `LAB5/QuanLyCongTyDuLich/App.config` và điều chỉnh `connectionString` phù hợp với máy kiểm tra:
```xml
<connectionStrings>
  <add name="QuanLyCongTyDuLichDB" 
       connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyCongTyDuLich;Integrated Security=True;TrustServerCertificate=True" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
### Bước 3: Biên dịch & Chạy dự án
1. Mở Solution `QuanLyThuVien.sln` hoặc file project `QuanLyCongTyDuLich.csproj` bằng **Visual Studio 2022**.
2. Nhấn **Ctrl + Shift + B** để Rebuild Solution.
3. Nhấn **F5** để khởi chạy ứng dụng.
---

### PHẦN 2: Hướng dẫn các lệnh Git để Push thư mục LAB5 và README.md lên GitHub

Bạn mở terminal **Git Bash** hoặc **Command Prompt (cmd)** tại thư mục `C:\Users\Admin\source\repos\QuanLyThuVien`[cite: 148] và lần lượt gõ các lệnh sau:

```bash
# 1. Chuyển vào thư mục repository
cd C:\Users\Admin\source\repos\QuanLyThuVien

# 2. Kiểm tra trạng thái các file thay đổi (sẽ thấy thư mục LAB5 và README.md)
git status

# 3. Thêm tất cả file thay đổi vào Staging Area
git add .

# 4. Tạo commit ghi nhận thay đổi
git commit -m "Upload LAB5 project and update README.md"

# 5. Push code lên GitHub repository (nhánh main)
git push origin main