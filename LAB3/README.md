# BÁO CÁO BÀI THỰC HÀNH LAB 3 - NỔI BẬT NGIỆP VỤ QUẢN LÝ KHÁCH SẠN

## 1. THÔNG TIN SINH VIÊN
* **Họ và tên:** Nguyễn Hữu Bảo
* **Mã số sinh viên (MSSV):** 1250080016
* **Tên bài Lab:** LAB 3 - Khảo sát, Thiết kế & Phát triển Hệ thống Quản lý Khách sạn
* **Học phần:** Phân tích và Thiết kế Hướng đối tượng (OOSD)
* **Link Repository GitHub:** https://github.com/BaoHuz/LAB_AT_OOSD

---

## 2. MÔI TRƯỜNG & PHIÊN BẢN (ENVIRONMENT & VERSIONS)
* **Hệ điều hành:** Windows 11
* **Ngôn ngữ lập trình:** C# (.NET Framework 4.7.2)
* **Công cụ phát triển (IDE):** Visual Studio 2022
* **Hệ quản trị CSDL:** Microsoft SQL Server 2019 / LocalDB
* **Công cụ vẽ biểu đồ:** Draw.io / StarUML

---

## 3. NỘI DUNG ĐÃ THỰC HIỆN (COMPLETED CONTENT)

### A. Phân tích & Thiết kế Mô hình (UML)
- [x] **Khảo sát hiện trạng & Phân loại nghiệp vụ:** Lưu trữ, Tra cứu, Tính toán, Kết xuất / Thống kê.
- [x] **Xác định các thành phần hệ thống:** Classes, Primary/Foreign Keys, Associations, Multiplicities, Actors, Use Cases.
- [x] **Đặc tả Use Case trọng tâm:** Đặt phòng, Nhận phòng, Sử dụng dịch vụ, Trả phòng & Đền bù, Thanh toán hóa đơn.
- [x] **Xây dựng hệ thống sơ đồ/biểu đồ UML:**
  - Biểu đồ Use Case tổng quát và Use Case phân rã.
  - Biểu đồ Lớp phân tích (Analysis Class Diagram) & Biểu đồ Lớp chi tiết (Detail Class Diagram).
  - Biểu đồ Trạng thái (State Machine Diagram).
  - Các Biểu đồ Tuần tự (Sequence Diagrams) & Biểu đồ Hoạt động (Activity Diagrams).

### B. Thiết kế Cơ sở Dữ liệu (SQL Server)
- [x] Thiết kế 18 bảng CSDL chuẩn hóa (3NF) chứa khóa chính, khóa ngoại, chỉ mục (Index) và các ràng buộc (`CHECK`, `DEFAULT`, `UNIQUE`):
  - `Phong`, `KhuVuc`, `LoaiTienNghi`, `TienNghi`, `PhieuLapDat`
  - `KhachHang`, `PhieuDatPhong`, `ChiTietDatPhong`, `NguoiLuuTru`
  - `DichVu`, `PhieuSuDungDV`, `ChiTietPhieuSuDungDV`
  - `QuyDinhDenBu`, `PhieuDenBu`, `ChiTietPhieuDenBu`
  - `HoaDon`, `ThanhToan`, `NhanVien`

### C. Lập trình Hệ thống WinForms (C#)
- [x] **FrmMain**: Màn hình điều hướng chính.
- [x] **FrmDanhMuc**: Quản lý danh mục Phòng, Loại tiện nghi, Tiện nghi, Dịch vụ, Nhân viên.
- [x] **FrmPhongTienNghi**: Lắp đặt & Quản lý thiết bị tiện nghi theo phòng.
- [x] **FrmDatPhong**: Đa tab (Khách hàng - Đặt phòng - Nhận phòng/Người lưu trú).
- [x] **FrmDichVu**: Ghi nhận và cộng dồn dịch vụ sử dụng theo phiếu lưu trú.
- [x] **FrmTraPhong**: Lập phiếu đền bù, lập hóa đơn, thanh toán đa hình thức và hoàn tất trả phòng.
- [x] **FrmThongKe**: Thống kê doanh thu hóa đơn, tổng đền bù và tần suất sử dụng dịch vụ theo mốc thời gian.

---

## 4. KẾT QUẢ KIỂM THỬ NGIỆP VỤ (TESTING RESULTS)

Hệ thống đã vượt qua các bài test kiểm thử quy tắc nghiệp vụ thực tế:
1. **Kiểm thử sức chứa & Trạng thái phòng:** Báo lỗi nếu xếp số người vượt quá `SoNguoiToiDa` hoặc phòng không ở trạng thái `Trống`.
2. **Kiểm thử trùng lịch lắp đặt:** Ràng buộc `UQ_PhieuLapDat_ThietBi_Ngay` ngăn chặn 1 thiết bị tiện nghi lắp cùng lúc vào nhiều phòng trong cùng 1 ngày.
3. **Kiểm thử cộng dồn dịch vụ:** Tự động tính toán tổng tiền (`ThanhTien = SoLuong * DonGia`) và cộng dồn các lượt gọi dịch vụ trong ngày.
4. **Kiểm thử Đền bù & Hóa đơn:** Tính toán chính xác tổng phí đền bù hư hỏng vật tư, tiền phòng theo số ngày ở thực tế và trừ đi tiền cọc.
5. **Kiểm thử Thanh toán:** Hỗ trợ linh hoạt 4 hình thức thanh toán (`Tiền mặt`, `Chuyển khoản`, `Thẻ`, `Ví điện tử`).

---

## 5. CÁC LỖI GẶP PHẢI & CÁCH KHẮC PHÚC (ISSUES & FIXES)

1. **Lỗi `Could not copy ... because it is being used by another process`:**
   - *Nguyên nhân:* Tiến trình `QuanLyKhachSan.exe` vẫn đang chạy ngầm làm khóa file thực thi.
   - *Khắc phục:* Sử dụng `Task Manager` để `End Task` tiến trình chạy ngầm hoặc chọn `Build -> Clean Solution` trong Visual Studio.

2. **Lỗi `Keyword not supported: 'data source'`:**
   - *Nguyên nhân:* Chuỗi `connectionString` trong `App.config` bị xuống hàng đột ngột hoặc gõ sai quy cách từ khóa `Data Source`.
   - *Khắc phục:* Định dạng lại XML trên 1 dòng duy nhất và chuẩn hóa lại cú pháp: `Data Source=...;Initial Catalog=QuanLyKhachSan;Integrated Security=True;`.

3. **Lỗi `Cannot open database "QuanLyKhachSan" requested by the login`:**
   - *Nguyên nhân:* Chưa chạy file script SQL để khởi tạo Database hoặc cấu hình sai tên SQL Instance.
   - *Khắc phục:* Chạy file `QuanLyKhachSan.sql` trong SQL Server Management Studio (SSMS) để khởi tạo Database và dữ liệu mẫu.

4. **Lỗi `Violation of PRIMARY KEY constraint` / `FOREIGN KEY constraint` khi chèn dữ liệu:**
   - *Nguyên nhân:* Chèn trùng khóa chính hoặc chèn dữ liệu không tuân thủ thứ tự mối quan hệ cha-con giữa các bảng.
   - *Khắc phục:* Thêm câu lệnh `DELETE` dọn dẹp bảng theo thứ tự từ bảng con đến bảng cha trước khi thực hiện `INSERT`.

---

## 6. HƯỚNG DẪN CHẠY LẠI DỰ ÁN (HOW TO RUN)

Dành cho Giảng viên / Người kiểm thử dự án:

1. **Bước 1 (Khởi tạo CSDL):**
   - Mở phần mềm SQL Server Management Studio (SSMS).
   - Mở file `QuanLyKhachSan.sql` trong thư mục `LAB3` và nhấn **Execute (F5)** để tạo CSDL và chèn toàn bộ dữ liệu mẫu.

2. **Bước 2 (Cấu hình chuỗi kết nối):**
   - Mở dự án `QuanLyKhachSan.sln` bằng Visual Studio 2022.
   - Mở file `App.config`, chỉnh lại giá trị `Data Source` cho phù hợp với Server SQL trên máy kiểm thử (ví dụ: `.\SQLEXPRESS` hoặc `(localdb)\MSSQLLocalDB`).

3. **Bước 3 (Thực thi dự án):**
   - Bấm `Ctrl + Shift + B` để Rebuild Solution.
   - Bấm **`F5`** (hoặc nút `Start`) để khởi chạy chương trình.

---

## 7. BẰNG CHỨNG THỰC HÀNH (EVIDENCE)
- [x] File báo cáo chi tiết Word (chứa hình ảnh giao diện thực tế và cấu trúc CSDL chụp từ máy cá nhân) đã được đính kèm trong thư mục `LAB3/BaoCao_LAB3.docx`.