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
   * **Câu 4:** Biểu đồ Use Case phân rã quy trình Đăng ký → Khám → Xét nghiệm → Toa thuốc.
   * **Câu 5:** Biểu đồ hoạt động (Activity Diagram) luồng xử lý phân nhánh và phân rã kê toa.
   * **Câu 6:** Biểu đồ tuần tự (Sequence Diagram) nghiệp vụ "Lập toa thuốc" theo mô hình 3 lớp (Boundary-Control-Entity) chạy trong 1 Transaction.
3. **Thiết kế Cơ sở dữ liệu SQL Server:**
   * Thiết kế 13 bảng CSDL đạt chuẩn chuẩn hóa, thiết lập đầy đủ Khóa chính (PK), Khóa ngoại (FK), ràng buộc `CHECK` giá trị và chỉ mục `UNIQUE`.
4. **Thiết kế & Hiện thực Hệ thống WinForms:**
   * Hiện thực theo kiến trúc 3 lớp (`Forms` → `Services` → `Data/Db.cs`).
   * Sử dụng `Transaction` khi lưu Toa thuốc và Chi tiết toa thuốc để đảm bảo tính toàn vẹn dữ liệu.

---

## 📊 KẾT QUẢ ĐẠT ĐƯỢC
* **Cơ sở dữ liệu SQL Server:**
  * Xây dựng thành công CSDL `QuanLyHoSoBenhAn` gồm 13 bảng Entity với đầy đủ khóa chính (PK), khóa ngoại (FK), chỉ mục (`Index`) và các ràng buộc (`CHECK`, `DEFAULT`, `PERSISTED Column`).
  * Hiện thực các Stored Procedure tích hợp Transaction nâng cao: `sp_DangKyMoi`, `sp_LapToaThuoc`, `sp_DatLichHen`, `sp_HoanTatPhieu` đạt tính toàn vẹn dữ liệu chuẩn ACID.
* **Biểu đồ Phân tích & Thiết kế (UML):**
  * Xây dựng hoàn chỉnh Hệ thống Biểu đồ Use Case (Tổng quát, Phân rã đăng ký/khám bệnh, Phân rã lập toa).
  * Biểu đồ lớp phân tích tổng quát và chi tiết (Class Diagram).
  * Biểu đồ hoạt động (Activity Diagram) mô tả toàn bộ quy trình từ Đăng ký -> Khám -> Xét nghiệm -> Toa thuốc -> Thanh toán -> Phát thuốc -> Chốt hồ sơ.
* **Giao diện Ứng dụng (WinForms C#):**
  * Hiện thực đầy đủ các Form chức năng: `FrmMain`, `FrmDangKy`, `FrmHoSo`, `FrmLichHen`, `FrmKhamBenh`, `FrmXetNghiem`, `FrmLapToa`, `FrmThanhToan`, `FrmPhatThuoc`, `FrmHoanTat`.

---

## ⚠️ LỖI GẶP PHẢI & CÁCH KHẮC PHỤC (ISSUES & FIXES)

| STT | Lỗi gặp phải (Issue) | Nguyên nhân (Root Cause) | Cách khắc phục (Fix / Solution) |
| :---: | :--- | :--- | :--- |
| **1** | Lỗi kết nối CSDL khi chạy dự án (`SqlException: Cannot open database...`). | Chuỗi kết nối `ConnectionString` trong file `App.config` chưa khớp với tên SQL Server Instance trên máy. | Cập nhật `Data Source=(localdb)\MSSQLLocalDB` (hoặc `.\SQLEXPRESS`) trong file `App.config` đúng với cấu hình máy đang chạy. |
| **2** | Lỗi vi phạm khóa ngoại (`FK Constraint Violation`) khi lưu Chi tiết toa thuốc. | Nhập mã thuốc không tồn tại trong danh sách hoặc lưu Chi tiết toa khi Toa thuốc chưa được khởi tạo bản ghi chính. | Sử dụng `SqlTransaction` để bọc toàn bộ thao tác thêm ToaThuoc và ChiTietToaThuoc; đồng thời ràng buộc người dùng chỉ được chọn thuốc từ ComboBox/Grid hiển thị sẵn. |
| **3** | Toa thuốc hoặc Chỉ định xét nghiệm bị trùng lặp khi bấm nút Lưu nhiều lần. | Chưa disable (vô hiệu hóa) nút bấm sau khi nhấn hoặc chưa kiểm tra trùng khóa chính trước khi Insert. | Thêm kiểm tra `Exists` trong Service và disable nút bấm/hiển thị thông báo khi thao tác lưu đang xử lý. |

---

## 🕹️ HƯỚNG DẪN DÀNH CHO GIẢNG VIÊN ĐỂ KIỂM TRA / CHẠY LẠI (RUN INSTRUCTIONS)

Giảng viên thực hiện các bước sau để cấu hình và kiểm tra dự án:

### Bước 1: Clone / Tải Source Code
```bash
git clone <URL_REPOSITORY_GIABAN>
```

Hoặc giải nén file `.zip` bài làm đã nộp.

---

### Bước 3: Cấu hình Chuỗi kết nối (Connection String)
1. Mở file solution `QuanLyHoSoBenhAn.sln` bằng **Visual Studio 2022**.
2. Mở file **`App.config`** và chỉnh sửa dòng `connectionString` nếu cần thiết:

```xml
<connectionStrings>
    <add name="QuanLyHoSoBenhAnDB" 
         connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyHoSoBenhAn;Integrated Security=True" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

---

### Bước 4: Biên dịch và Chạy phần mềm
1. Chọn **Build** → **Rebuild Solution** (đảm bảo không có lỗi biên dịch).
2. Nhấn **`F5`** (hoặc chọn nút **Start**) để chạy ứng dụng WinForms.

### Bước 5: Các kịch bản kiểm thử nhanh cho Giảng viên (Quick Test Flow)
1. **Đăng ký mới (`FrmDangKy`):** Nhập thông tin bệnh nhân test + Đóng phí 200.000 VNĐ → Kiểm tra hệ thống cấp Mã Bệnh nhân & Mã Hồ sơ.
2. **Đặt lịch hẹn (`FrmLichHen`):** Chọn bệnh nhân vừa tạo → Đặt lịch khám định kỳ cho Quý hiện tại.
3. **Khám bệnh (`FrmKhamBenh`):** Mở phiếu khám → Nhập triệu chứng, chẩn đoán → Chỉ định 1 dịch vụ xét nghiệm.
4. **Xét nghiệm (`FrmXetNghiem`):** Cập nhật kết quả cho dịch vụ xét nghiệm vừa chỉ định (`DaCoKetQua`).
5. **Lập toa thuốc (`FrmLapToa`):** Chọn 2 loại thuốc từ danh mục, nhập số lượng, liều dùng → Bấm **"Lưu Toa"**.
6. **Thanh toán (`FrmThanhToan`):** Kiểm tra bảng kê (được miễn tiền khám định kỳ, tính tiền thuốc + XN) → Bấm **"Thanh toán"**.
7. **Phát thuốc & Chốt hồ sơ (`FrmPhatThuoc` & `FrmHoanTat`):** Xác nhận phát thuốc → Bấm **"Hoàn tất đợt khám"** → Kiểm tra phiếu chuyển trạng thái `HoanTat` và khóa sửa.