# 🏥 HỆ THỐNG QUẢN LÝ HỒ SƠ BỆNH ÁN CỦA BỆNH NHÂN

## 👤 THÔNG TIN SINH VIÊN
* **Họ và tên:** Nguyễn Hữu Bảo
* **Mã số sinh viên (MSSV):** 1250080016
* **Lớp:** 12_ĐH_CNPM1
* **Tên bài Lab:** Bài 5 - Quản lý hồ sơ bệnh án của bệnh nhân (Thực hành Phân tích thiết kế hướng đối tượng)
* **Trường:** Đại học Tài Nguyên và Môi Trường TP.HCM

---

## 💻 MÔI TRƯỜNG & PHIÊN BẢN (ENVIRONMENT & VERSIONS)
* **IDE:** Visual Studio 2022 (Version 17.x)
* **Framework:** .NET Framework 4.7.2
* **Ngôn ngữ:** C# (CSharp)
* **Cơ sở dữ liệu:** Microsoft SQL Server 2019 / SQL Server LocalDB (`(localdb)\MSSQLLocalDB`)
* **Công cụ vẽ mô hình UML:** StarUML / PlantUML / Draw.io

---

## 📋 NỘI DUNG ĐÃ THỰC HIỆN
1. **Phân tích nghiệp vụ & Quy tắc hệ thống (Business Rules):**
   * **BR01 (Khách mới / Cấp hồ sơ):** Bệnh nhân lần đầu khám phải đóng Lệ phí năm (hạn 365 ngày) để cấp Hồ sơ bệnh án kèm `MaHoSo` duy nhất.
   * **BR02 (Tra cứu hồ sơ):** Tái khám chỉ cần đọc `MaHoSo` hoặc tra cứu qua SĐT/Số CMND.
   * **BR03 (Lịch khám định kỳ quý):** Bệnh nhân còn hạn lệ phí năm được đặt lịch và khám sức khỏe định kỳ theo quý miễn phí (tối đa 4 lần/năm).
   * **BR04 (Liên kết phiếu khám):** Toa thuốc và Chỉ định xét nghiệm bắt buộc gắn liền với đúng 1 Phiếu khám bệnh.
   * **BR05 (Thanh toán & Chốt đợt khám):** Toa thuốc chỉ được phát và hoàn tất đợt khám sau khi đã hoàn tất thanh toán viện phí.
2. **Xây dựng Mô hình UML (Pha Phân tích & Thiết kế):**
   * **Câu 1:** Bảng xác định 13 Class, Primary Key (ID), thuộc tính và phương thức.
   * **Câu 2:** Biểu đồ lớp (Class Diagram) kèm bản số và mối quan hệ giữa các thực thể.
   * **Câu 3:** Biểu đồ Use Case tổng quát bao phủ 6 Actor và các nhóm chức năng.
   * **Câu 4:** Biểu đồ Use Case phân rã quy trình Đăng ký $\rightarrow$ Khám $\rightarrow$ Xét nghiệm $\rightarrow$ Toa thuốc.
   * **Câu 5:** Biểu đồ hoạt động (Activity Diagram) luồng xử lý phân nhánh và phân rã kê toa.
   * **Câu 6:** Biểu đồ tuần tự (Sequence Diagram) nghiệp vụ "Lập toa thuốc" theo mô hình 3 lớp (Boundary-Control-Entity) chạy trong 1 Transaction.
3. **Thiết kế Cơ sở dữ liệu SQL Server:**
   * Thiết kế 13 bảng CSDL đạt chuẩn chuẩn hóa, thiết lập đầy đủ Khóa chính (PK), Khóa ngoại (FK), ràng buộc `CHECK` giá trị và chỉ mục `UNIQUE`.
4. **Thiết kế & Hiện thực Hệ thống WinForms:**
   * Hiện thực theo kiến trúc 3 lớp (`UI Forms` $\rightarrow$ `Services` $\rightarrow$ `Data/Db.cs`).
   * Sử dụng `Transaction` khi lưu Toa thuốc và Chi tiết toa thuốc để đảm bảo tính toàn vẹn dữ liệu.

---

## 📊 KẾT QUẢ ĐẠT ĐƯỢC
* [x] Hoàn thành 100% tài liệu phân tích và biểu đồ UML theo đúng yêu cầu đề bài.
* [x] Tạo thành công CSDL `QuanLyHoSoBenhAn` trên SQL Server với các ràng buộc toàn vẹn dữ liệu chặt chẽ.
* [x] Giao diện WinForms hoạt động ổn định, phân tách rõ ràng giữa lớp xử lý giao diện và lớp dịch vụ nghiệp vụ (Service).
* [x] Thực hiện đầy đủ kịch bản kiểm thử (Test Cases) từ đăng ký lần đầu, đặt lịch hẹn quý, kê toa thuốc cho đến thanh toán viện phí.

---

## ⚠️ LỖI GẶP PHẢI & CÁCH KHẮC PHỤC (ISSUES & FIXES)

| STT | Lỗi gặp phải (Issue) | Nguyên nhân (Root Cause) | Cách khắc phục (Fix / Solution) |
| :---: | :--- | :--- | :--- |
| **1** | Lỗi kết nối CSDL khi chạy dự án (`SqlException: Cannot open database...`). | Chuỗi kết nối `ConnectionString` trong file `App.config` chưa khớp với tên SQL Server Instance trên máy. | Cập nhật `Data Source=(localdb)\MSSQLLocalDB` (hoặc `.\SQLEXPRESS`) trong file `App.config` đúng với cấu hình máy đang chạy. |
| **2** | Lỗi vi phạm khóa ngoại (`FK Constraint Violation`) khi lưu Chi tiết toa thuốc. | Nhập mã thuốc không tồn tại trong danh sách hoặc lưu Chi tiết toa khi Toa thuốc chưa được khởi tạo bản ghi chính. | Sử dụng `SqlTransaction` để bọc toàn bộ thao tác thêm ToaThuoc và ChiTietToaThuoc; đồng thời ràng buộc người dùng chỉ được chọn thuốc từ ComboBox/Grid hiển thị sẵn. |
| **3** | Toa thuốc hoặc Chỉ định xét nghiệm bị trùng lặp khi bấm nút Lưu nhiều lần. | Chưa disable (vô hiệu hóa) nút bấm sau khi nhấn hoặc chưa kiểm tra trùng khóa chính trước khi Insert. | Thêm kiểm tra `Exits` trong Service và disable nút bấm/hiển thị thông báo khi thao tác lưu đang xử lý. |

---

## 🕹️ HƯỚNG DẪN DÀNH CHO GIẢNG VIÊN ĐỂ KIỂM TRA / CHẠY LẠI (RUN INSTRUCTIONS)

Giảng viên thực hiện các bước sau để cấu hình và kiểm tra dự án:

### Bước 1: Clone / Tải Source Code
```bash
git clone <URL_REPOSITORY_GIABAN>
Hoặc giải nén file `.zip` bài làm đã nộp.

### Bước 2: Khởi tạo Cơ sở dữ liệu SQL Server
1. Mở **SQL Server Management Studio (SSMS)** hoặc **Visual Studio SQL Server Object Explorer**.
2. Mở và thực thi file script SQL: `QuanLyHoSoBenhAn.sql` (nằm trong thư mục `Database/` hoặc thư mục gốc của project).
3. Script sẽ tự động tạo Database `QuanLyHoSoBenhAn`, tạo toàn bộ 13 bảng cùng các ràng buộc PK, FK, CHECK, UNIQUE và chèn sẵn dữ liệu mẫu (Data Test).

### Bước 3: Cấu hình Chuỗi kết nối (Connection String)
1. Mở file solution `QuanLyHoSoBenhAn.sln` bằng **Visual Studio 2022**.
2. Mở file **`App.config`** và chỉnh sửa dòng `connectionString` nếu cần thiết:

```xml
<connectionStrings>
    <add name="QuanLyHoSoBenhAnDB" 
         connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyHoSoBenhAn;Integrated Security=True" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
### Bước 4: Biên dịch và Chạy phần mềm
1. Chọn **Build** $\rightarrow$ **Rebuild Solution** (đảm bảo không có lỗi biên dịch).
2. Nhấn **`F5`** (hoặc chọn nút **Start**) để chạy ứng dụng WinForms.

### Bước 5: Các kịch bản kiểm thử nhanh cho Giảng viên (Quick Test Flow)
* **Kịch bản 1 (Bệnh nhân mới):** Chọn menu **Tiếp nhận** $\rightarrow$ Thêm bệnh nhân mới $\rightarrow$ Hệ thống bắt buộc nhập tiền Lệ phí năm $\rightarrow$ Nhấn **Lập hồ sơ** $\rightarrow$ Hệ thống cấp `MaHoSo` mới.
* **Kịch bản 2 (Tái khám & Kê toa):** Chọn menu **Khám bệnh** $\rightarrow$ Nhập `MaHoSo` $\rightarrow$ Nhập Triệu chứng $\rightarrow$ Mở màn hình **Lập toa thuốc** $\rightarrow$ Chọn thuốc & nhập liều dùng $\rightarrow$ Nhấn **Lưu toa thuốc** (Kiểm tra lưu bằng Transaction thành công).
* **Kịch bản 3 (Thanh toán & Xuất thuốc):** Chọn menu **Thanh toán viện phí** $\rightarrow$ Chọn phiếu khám $\rightarrow$ Thực hiện thu tiền viện phí $\rightarrow$ Đợt khám chuyển trạng thái hoàn tất và cho phép phát thuốc.