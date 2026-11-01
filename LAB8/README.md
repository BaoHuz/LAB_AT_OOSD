# LAB 8 - QUẢN LÝ CHO THUÊ VĂN PHÒNG Ở CAO ỐC

## 1. Thông tin sinh viên

- **Họ và tên:** Nguyễn Hữu Bảo
- **MSSV:** 1250080016
- **Lớp:** 12_ĐH_CNPM1
- **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng
- **Bài thực hành:** LAB 8 - Bài 4
- **Tên bài:** Quản lý cho thuê văn phòng ở cao ốc
- **Repository:** `LAB_AT_OOSD`

---

## 2. Mục tiêu bài LAB

Phân tích, thiết kế cơ sở dữ liệu và hiện thực Prototype **Hệ thống quản lý cho thuê văn phòng ở cao ốc**.

Các nghiệp vụ chính:

- Quản lý tầng và văn phòng.
- Quản lý khách hàng.
- Lập hợp đồng thuê một hoặc nhiều văn phòng.
- Kiểm tra thời hạn thuê tối thiểu 6 tháng.
- Kiểm tra văn phòng bị trùng lịch thuê.
- Thu trước tiền thuê 6 tháng đầu khi ký hợp đồng.
- Thanh toán tiền thuê từ tháng thứ 7 trở đi.
- Quản lý dịch vụ điện, nước, Internet và các dịch vụ khác.
- Ghi nhận sử dụng dịch vụ theo văn phòng.
- Lập hóa đơn dịch vụ cuối tháng.
- Thanh toán hóa đơn dịch vụ.
- Gia hạn văn phòng.
- Kiểm tra công nợ trước khi gia hạn.
- Kiểm tra giới hạn tổng thời gian gia hạn.
- Quản lý nhân viên làm việc tại các văn phòng thuê.
- Quản lý thẻ giữ xe.
- Kiểm tra tình trạng văn phòng và ghi nhận vi phạm kết cấu.
- Kiểm thử các quy tắc nghiệp vụ chính.

Hệ thống được hiện thực theo kiến trúc:

```text
UI (Forms)
    ↓
Service
    ↓
Data / Db.cs
    ↓
SQL Server
```

---

## 3. Môi trường và công nghệ

- **Hệ điều hành:** Windows 11
- **IDE:** Microsoft Visual Studio 2022
- **Ngôn ngữ:** C#
- **Framework:** .NET Framework 4.7.2
- **Giao diện:** Windows Forms
- **Cơ sở dữ liệu:** Microsoft SQL Server
- **Truy cập dữ liệu:** ADO.NET
- **Công cụ CSDL:** SQL Server Management Studio
- **Công cụ UML:** Draw.io / PlantUML
- **Công cụ báo cáo:** Microsoft Word
- **Quản lý mã nguồn:** Git & GitHub

---

## 4. Cấu trúc thư mục

```text
LAB8/
│
├── 1250080016_NguyenHuuBao_12_ĐH_CNPM1_Lab8.docx
├── Bai_4_Cho_thue_van_phong_cao_oc.docx
├── LAB8.drawio
├── QuanLyChoThueVanPhong.sql
├── README.md
│
└── QuanLyChoThueVanPhong/
    │
    ├── QuanLyChoThueVanPhong.sln
    ├── .vs/
    │
    └── QuanLyChoThueVanPhong/
        │
        ├── App.config
        ├── Program.cs
        │
        ├── Data/
        │   └── Db.cs
        │
        ├── Forms/
        │   ├── FrmMain.cs
        │   ├── FrmTangVanPhong.cs
        │   ├── FrmKhachHang.cs
        │   ├── FrmHopDong.cs
        │   ├── FrmThanhToanTienThue.cs
        │   ├── FrmDichVu.cs
        │   ├── FrmHoaDonDichVu.cs
        │   ├── FrmGiaHan.cs
        │   ├── FrmNhanVien.cs
        │   ├── FrmTheGiuXe.cs
        │   └── FrmKiemTraPhong.cs
        │
        └── Services/
            ├── DichVuService.cs
            ├── FormHelper.cs
            ├── GiaHanService.cs
            ├── HoaDonDichVuService.cs
            ├── HopDongService.cs
            ├── KhachHangService.cs
            ├── KiemTraPhongService.cs
            ├── NhanVienService.cs
            ├── TangVanPhongService.cs
            ├── ThanhToanTienThueService.cs
            └── TheGiuXeService.cs
```

> Các thư mục `.vs`, `bin` và `obj` được Visual Studio tự sinh, không phải thành phần mã nguồn chính của bài.

---

# 5. Nội dung phân tích và thiết kế

Báo cáo trả lời đầy đủ 6 yêu cầu của đề bài.

## Câu 1 - Xác định Class, thuộc tính, phương thức và ID

Các lớp nghiệp vụ chính:

```text
Tang
VanPhong
KhachHang
HopDongThue
ChiTietHopDong
ThanhToanTienThue
DichVu
SuDungDichVu
HoaDonDichVu
PhieuGiaHan
NhanVienVanPhong
TheGiuXe
KiemTraPhong
```

Ngoài ra ở pha thiết kế CSDL có thêm các lớp/bảng chi tiết phục vụ hóa đơn dịch vụ và thanh toán.

---

## Câu 2 - Mối liên kết giữa các Class

Một số quan hệ chính:

```text
Tang
  1
  ↓
  *
VanPhong
```

```text
KhachHang
  1
  ↓
  *
HopDongThue
```

```text
HopDongThue
   *
   ↕
   *
VanPhong
```

Quan hệ nhiều-nhiều giữa hợp đồng và văn phòng được triển khai thông qua:

```text
ChiTietHopDong
```

với khóa:

```text
MaHD + MaVP
```

---

## Câu 3 - Actor và Use Case tổng quát

Các Actor chính:

- Khách hàng.
- NV quản lý cho thuê.
- Kế toán.
- NV an ninh / giữ xe.
- NV kỹ thuật / quản lý tòa nhà.

Các Use Case chính:

- Xem thông tin văn phòng.
- Quản lý tầng - văn phòng.
- Quản lý khách hàng.
- Lập hợp đồng thuê.
- Thanh toán tiền thuê.
- Quản lý dịch vụ.
- Lập và thanh toán hóa đơn dịch vụ.
- Lập phiếu gia hạn.
- Quản lý nhân viên làm việc.
- Cấp / khóa / thu hồi thẻ giữ xe.
- Kiểm tra phòng và xử lý vi phạm.

---

## Câu 4 - Use Case phân rã

Quy trình trọng tâm:

```text
Lập hợp đồng thuê
       ↓
Chọn một hoặc nhiều văn phòng
       ↓
Kiểm tra thời hạn >= 6 tháng
       ↓
Kiểm tra văn phòng còn trống
       ↓
Thu trước tiền thuê 6 tháng
       ↓
Bắt đầu sử dụng văn phòng
       ↓
Ghi nhận dịch vụ trong tháng
       ↓
Cuối tháng lập hóa đơn dịch vụ
       ↓
Thanh toán hóa đơn dịch vụ
       ↓
Từ tháng thứ 7 trở đi
       ↓
Thanh toán tiền thuê định kỳ
```

---

## Câu 5 - Activity Diagram

Activity Diagram mô tả xuyên suốt từ lúc chọn văn phòng đến khi hợp đồng kết thúc hoặc chuyển sang gia hạn.

Luồng chính:

```text
Chọn văn phòng
      ↓
Lập hợp đồng
      ↓
Kiểm tra thuê >= 6 tháng
      ↓
Kiểm tra phòng còn trống
      ↓
Thu trước 6 tháng
      ↓
Sử dụng văn phòng
      ↓
Ghi nhận dịch vụ
      ↓
Lập hóa đơn dịch vụ cuối tháng
      ↓
Thanh toán hóa đơn dịch vụ
      ↓
Thanh toán tiền thuê tháng 7+
      ↓
Còn thời hạn?
   ↙       ↘
 Có       Không
 ↓          ↓
Lặp      Kết thúc / Gia hạn
```

---

## Câu 6 - Sequence Diagram lập phiếu gia hạn

Trình tự chính:

```text
NV quản lý
    ↓
FrmGiaHan
    ↓
GiaHanService
    ↓
Kiểm tra hợp đồng
    ↓
Kiểm tra số tháng thuê ban đầu
    ↓
Kiểm tra tổng thời gian đã gia hạn
    ↓
Kiểm tra nợ tiền thuê
    ↓
Kiểm tra nợ dịch vụ
    ↓
Kiểm tra xung đột lịch tương lai
    ↓
BEGIN TRANSACTION
    ↓
INSERT PhieuGiaHan
    ↓
UPDATE ChiTietHopDong
    ↓
COMMIT
```

Nếu bất kỳ bước nào lỗi:

```text
ROLLBACK
```

---

# 6. UML và Draw.io

File:

```text
LAB8.drawio
```

File gồm 16 page:

```text
P01_usecase_tongquat
P02_usecase_phanra
P03_class_phan_tich
P04_state_hopdong
P05_sequence_giahan
P06_sequence_hopdong
P07_sequence_tienthue
P08_sequence_dichvu
P09_activity
P10_erd
P11_navigation
P12_class_phantich_chitiet
P13_chucnang_hopdong
P14_chucnang_dichvu
P15_chucnang_giahan
P16_chucnang_anninh&kythuat
```

Các sơ đồ đã thực hiện:

- Use Case Diagram tổng quát.
- Use Case Diagram phân rã.
- Class Diagram phân tích.
- Class Diagram phân tích chi tiết.
- State Machine Diagram hợp đồng.
- Sequence Diagram lập phiếu gia hạn.
- Sequence Diagram lập hợp đồng nhiều văn phòng.
- Sequence Diagram thanh toán tiền thuê tháng 7+.
- Sequence Diagram lập hóa đơn dịch vụ.
- Activity Diagram.
- ERD.
- Sơ đồ điều hướng Form.
- Thiết kế lớp chức năng Hợp đồng.
- Thiết kế lớp chức năng Dịch vụ.
- Thiết kế lớp chức năng Gia hạn.
- Thiết kế lớp nhóm chức năng An ninh - Kỹ thuật.

---

# 7. Thiết kế cơ sở dữ liệu

File:

```text
QuanLyChoThueVanPhong.sql
```

Database:

```text
QuanLyChoThueVanPhong
```

Hệ thống sử dụng **15 bảng**:

1. `Tang`
2. `VanPhong`
3. `KhachHang`
4. `HopDongThue`
5. `ChiTietHopDong`
6. `ThanhToanTienThue`
7. `DichVu`
8. `SuDungDichVu`
9. `HoaDonDichVu`
10. `ChiTietHoaDonDichVu`
11. `ThanhToanDichVu`
12. `PhieuGiaHan`
13. `NhanVienVanPhong`
14. `TheGiuXe`
15. `KiemTraPhong`

---

# 8. User-defined Table Type

Hệ thống sử dụng:

```text
dbo.VanPhongThueType
```

để truyền danh sách nhiều văn phòng vào Stored Procedure lập hợp đồng.

Điều này giúp nghiệp vụ:

```text
1 HopDongThue
      ↓
N ChiTietHopDong
```

được xử lý trong cùng một Transaction.

---

# 9. Stored Procedure

File SQL có 3 Stored Procedure chính:

```text
sp_LapHopDongVaThu6Thang
sp_LapHoaDonDichVuThang
sp_GiaHanVanPhong
```

## `sp_LapHopDongVaThu6Thang`

Thực hiện:

```text
Kiểm tra thời hạn >= 6 tháng
        ↓
Kiểm tra danh sách phòng
        ↓
Kiểm tra chồng lịch thuê
        ↓
BEGIN TRAN
        ↓
INSERT HopDongThue
        ↓
INSERT ChiTietHopDong
        ↓
Tạo khoản thanh toán 6 tháng đầu
        ↓
COMMIT
```

---

## `sp_LapHoaDonDichVuThang`

Thực hiện:

```text
Chọn hợp đồng + tháng
        ↓
Lấy các lượt sử dụng dịch vụ
        ↓
BEGIN TRAN
        ↓
INSERT HoaDonDichVu
        ↓
INSERT ChiTietHoaDonDichVu
        ↓
Tính tổng tiền
        ↓
COMMIT
```

---

## `sp_GiaHanVanPhong`

Kiểm tra:

- Hợp đồng còn hiệu lực.
- Văn phòng thuộc hợp đồng.
- Tổng số tháng gia hạn không vượt quá 1/2 thời gian thuê ban đầu.
- Không còn nợ tiền thuê.
- Không còn nợ hóa đơn dịch vụ.
- Văn phòng không bị chồng lịch với hợp đồng khác.

Nếu hợp lệ:

```text
BEGIN TRAN
    ↓
INSERT PhieuGiaHan
    ↓
UPDATE ChiTietHopDong
    ↓
COMMIT
```

---

# 10. Quy tắc nghiệp vụ chính

## BR01 - Tầng và văn phòng

- Một tầng có nhiều văn phòng.
- Một văn phòng thuộc đúng một tầng.

---

## BR02 - Hợp đồng

- Một khách hàng có thể có nhiều hợp đồng.
- Một hợp đồng có thể thuê nhiều văn phòng.
- Thời gian thuê ban đầu tối thiểu:

```text
6 tháng
```

---

## BR03 - Thanh toán trước

Khi lập hợp đồng:

```text
Khách hàng phải thanh toán trước 6 tháng đầu.
```

---

## BR04 - Thanh toán từ tháng thứ 7

Từ tháng thứ 7:

```text
Thanh toán theo từng tháng
```

Ngày đến hạn được chọn là ngày:

```text
01
```

của tháng tương ứng.

---

## BR05 - Dịch vụ

Giá thuê không bao gồm:

- Điện.
- Nước.
- Internet.
- Các dịch vụ phát sinh khác.

Thành tiền:

```text
ThanhTien
=
SoLuong × DonGia
```

Hóa đơn dịch vụ được tổng hợp cuối tháng.

---

## BR06 - Gia hạn

Gia hạn chỉ được thực hiện khi:

```text
Hợp đồng còn hiệu lực
AND
Không còn nợ tiền thuê
AND
Không còn nợ dịch vụ
AND
Tổng thời gian gia hạn <= 1/2 thời gian thuê ban đầu
AND
Không chồng lịch với hợp đồng khác
```

---

## BR07 - Nhân viên làm việc

Mỗi nhân viên làm việc tại văn phòng có:

- Mã nhân viên.
- Công ty / khách hàng.
- Văn phòng.
- Họ tên.
- Chức vụ.
- Hình ảnh.
- Ngày bắt đầu.
- Trạng thái đang làm việc.

---

## BR08 - Thẻ giữ xe

Một nhân viên có tối đa một thẻ giữ xe hoạt động.

Thẻ lưu:

- Biển số xe.
- Loại xe.
- Màu xe.
- Ngày cấp.
- Trạng thái.

Biển số xe không được trùng.

---

## BR09 - Kiểm tra phòng

Bộ phận kỹ thuật kiểm tra văn phòng định kỳ.

Lưu:

- Văn phòng.
- Ngày kiểm tra.
- Tình trạng.
- Có thay đổi kết cấu hay không.
- Mức phạt.
- Kiến nghị sửa chữa.
- Người kiểm tra.

---

# 11. Các quyết định triển khai

## QD01 - Ngày đến hạn tiền thuê

Đề không xác định cụ thể “đầu tháng”.

Hệ thống chọn:

```text
Ngày 01
```

làm ngày đến hạn.

---

## QD02 - Hạn thanh toán dịch vụ

Đề không quy định số ngày phải thanh toán sau khi lập hóa đơn.

Hệ thống chỉ theo dõi:

```text
Chưa thanh toán
Đã thanh toán
```

---

## QD03 - Tổng thời gian gia hạn

Để tránh gia hạn nhiều lần vượt quy định:

```text
Tổng số tháng đã gia hạn
+
Số tháng gia hạn mới
<=
FLOOR(SoThangThue / 2)
```

---

## QD04 - Mức phạt

Đề không cung cấp mức phạt cố định.

Mức phạt do bộ phận quản lý nhập, không hard-code.

---

## QD05 - Công nợ

Khi gia hạn một văn phòng, hệ thống yêu cầu:

```text
Toàn bộ hợp đồng không còn nợ
```

để bảo đảm an toàn nghiệp vụ.

---

## QD06 - Chồng lịch văn phòng

Một văn phòng không được xuất hiện trong hai khoảng thuê hiệu lực bị giao nhau.

---

# 12. Kiến trúc mã nguồn

## Data Layer

### `Data/Db.cs`

Chịu trách nhiệm:

- Đọc Connection String.
- Tạo `SqlConnection`.
- Thực hiện Query.
- Thực hiện Execute.
- Thực hiện Scalar.
- Hỗ trợ `SqlParameter`.

---

## Service Layer

### `TangVanPhongService`

Quản lý:

- Tầng.
- Văn phòng.
- Giá thuê.
- Trạng thái văn phòng.

### `KhachHangService`

Quản lý thông tin khách hàng / công ty thuê.

### `HopDongService`

Quản lý:

- Hợp đồng thuê.
- Danh sách văn phòng.
- Kiểm tra phòng trống.
- Kiểm tra chồng lịch.
- Thu trước 6 tháng.

### `ThanhToanTienThueService`

Quản lý:

- Các kỳ tiền thuê.
- Thanh toán từ tháng thứ 7 trở đi.
- Theo dõi trạng thái công nợ.

### `DichVuService`

Quản lý:

- Danh mục dịch vụ.
- Ghi nhận sử dụng dịch vụ.

### `HoaDonDichVuService`

Quản lý:

- Lập hóa đơn dịch vụ cuối tháng.
- Xem hóa đơn.
- Ghi nhận thanh toán hóa đơn dịch vụ.

### `GiaHanService`

Quản lý:

- Kiểm tra điều kiện gia hạn.
- Tính giới hạn gia hạn.
- Kiểm tra công nợ.
- Kiểm tra chồng lịch.
- Lập phiếu gia hạn.

### `NhanVienService`

Quản lý nhân viên của công ty thuê văn phòng.

### `TheGiuXeService`

Quản lý:

- Cấp thẻ.
- Khóa thẻ.
- Thu hồi thẻ.
- Thông tin phương tiện.

### `KiemTraPhongService`

Quản lý:

- Biên bản kiểm tra.
- Tình trạng văn phòng.
- Thay đổi kết cấu.
- Mức phạt.
- Kiến nghị sửa chữa.

---

# 13. Các Form đã thực hiện

## `FrmMain`

Màn hình điều hướng chính.

---

## `FrmTangVanPhong`

Quản lý:

- Tầng.
- Văn phòng.
- Diện tích.
- Hướng.
- Đơn giá.
- Trạng thái.

---

## `FrmKhachHang`

Quản lý thông tin khách hàng / công ty thuê.

---

## `FrmHopDong`

Thực hiện:

- Chọn khách hàng.
- Nhập ngày bắt đầu.
- Nhập số tháng thuê.
- Chọn nhiều văn phòng.
- Kiểm tra điều kiện thuê.
- Lập hợp đồng.
- Thu trước tiền thuê 6 tháng.

---

## `FrmThanhToanTienThue`

Thực hiện:

- Chọn hợp đồng.
- Xem các kỳ tiền thuê.
- Ghi nhận thanh toán.
- Theo dõi công nợ.

---

## `FrmDichVu`

Thực hiện:

- Quản lý danh mục dịch vụ.
- Ghi nhận số lượng dịch vụ sử dụng theo văn phòng và tháng.

---

## `FrmHoaDonDichVu`

Thực hiện:

- Lập hóa đơn dịch vụ cuối tháng.
- Xem danh sách hóa đơn.
- Ghi nhận thanh toán hóa đơn dịch vụ.

---

## `FrmGiaHan`

Thực hiện:

- Chọn hợp đồng.
- Chọn văn phòng.
- Xem điều kiện gia hạn.
- Nhập số tháng gia hạn.
- Kiểm tra công nợ.
- Kiểm tra giới hạn 1/2.
- Lập phiếu gia hạn.

---

## `FrmNhanVien`

Quản lý:

- Nhân viên.
- Công ty.
- Văn phòng làm việc.
- Chức vụ.
- Hình ảnh.
- Ngày bắt đầu.
- Trạng thái làm việc.

---

## `FrmTheGiuXe`

Quản lý:

- Thẻ giữ xe.
- Nhân viên.
- Biển số.
- Loại xe.
- Màu xe.
- Trạng thái thẻ.

---

## `FrmKiemTraPhong`

Quản lý:

- Ngày kiểm tra.
- Tình trạng phòng.
- Vi phạm kết cấu.
- Mức phạt.
- Kiến nghị sửa chữa.

---

# 14. SQL Transaction

Các nghiệp vụ nhiều bảng quan trọng được xử lý bằng Transaction.

## Lập hợp đồng

```text
BEGIN TRAN
   ↓
HopDongThue
   ↓
ChiTietHopDong
   ↓
ThanhToanTienThue tháng 1-6
   ↓
COMMIT
```

## Lập hóa đơn dịch vụ

```text
BEGIN TRAN
   ↓
HoaDonDichVu
   ↓
ChiTietHoaDonDichVu
   ↓
Cập nhật tổng tiền
   ↓
COMMIT
```

## Gia hạn

```text
BEGIN TRAN
   ↓
PhieuGiaHan
   ↓
UPDATE ChiTietHopDong
   ↓
COMMIT
```

Nếu có lỗi:

```text
ROLLBACK
```

---

# 15. Kiểm thử

Báo cáo xây dựng bộ Test Case để kiểm tra các nghiệp vụ trọng tâm.

Các nhóm kiểm thử:

```text
Tầng - văn phòng
Khách hàng
Hợp đồng
Thu trước 6 tháng
Thanh toán tháng 7+
Dịch vụ
Hóa đơn dịch vụ
Gia hạn
Công nợ
Nhân viên
Thẻ giữ xe
Kiểm tra phòng
```

---

# 16. Một số Test Case quan trọng

## Thuê dưới 6 tháng

```text
SoThangThue < 6
→ Từ chối lập hợp đồng
```

---

## Thuê nhiều văn phòng

```text
Một hợp đồng
+
Nhiều văn phòng còn trống
→ Lập hợp đồng thành công
```

---

## Phòng bị chồng lịch

```text
Khoảng thuê mới giao với khoảng thuê hiện tại
→ Từ chối
```

---

## Thanh toán trước 6 tháng

Sau khi lập hợp đồng:

```text
Kỳ tháng 1-6
→ Đã thanh toán
```

---

## Thanh toán tháng 7+

```text
Kỳ tháng >= 7
→ Ghi nhận thanh toán đầu tháng
```

---

## Hóa đơn dịch vụ

```text
Dữ liệu sử dụng dịch vụ trong tháng
→ Tổng hợp thành hóa đơn cuối tháng
```

---

## Gia hạn khi còn nợ

```text
Còn nợ tiền thuê
OR
Còn nợ dịch vụ
→ Không cho gia hạn
```

---

## Gia hạn vượt 1/2

```text
Tổng gia hạn > FLOOR(SoThangThue / 2)
→ Từ chối
```

---

## Thẻ xe trùng biển số

```text
BienSoXe đã tồn tại
→ Không cấp thẻ mới
```

---

## Kiểm tra thay đổi kết cấu

```text
CoThayDoiKetCau = 1
→ Ghi nhận MucPhat
→ Ghi nhận KienNghiSuaChua
```

---

# 17. Kết quả thực hiện

LAB8 đã hoàn thành:

- Phân tích nghiệp vụ.
- Xác định Class, thuộc tính, phương thức và ID.
- Xác định association và multiplicity.
- Xác định Actor.
- Xây dựng Use Case tổng quát.
- Xây dựng Use Case phân rã.
- Đặc tả Use Case trọng tâm.
- Class Diagram phân tích.
- State Diagram.
- Sequence Diagram.
- Class Diagram thiết kế.
- Activity Diagram.
- ERD.
- Sơ đồ điều hướng Form.
- Thiết kế CSDL SQL Server với 15 bảng.
- Thiết kế User-defined Table Type.
- Xây dựng 3 Stored Procedure.
- Xây dựng dữ liệu mẫu.
- Xây dựng ứng dụng C# WinForms.
- Tổ chức code theo `UI → Service → Data`.
- Quản lý hợp đồng nhiều văn phòng.
- Thu trước 6 tháng.
- Thanh toán tháng 7+.
- Quản lý dịch vụ.
- Lập và thanh toán hóa đơn dịch vụ.
- Gia hạn.
- Quản lý nhân viên.
- Quản lý thẻ xe.
- Kiểm tra phòng.
- Kiểm thử các quy tắc nghiệp vụ.

---

# 18. Lỗi gặp phải và cách khắc phục

## 18.1. CHECK Constraint tham chiếu cột khác

### Lỗi

```text
Column CHECK constraint for column 'KyDenThang'
references another column
```

### Nguyên nhân

SQL Server không cho Column-level CHECK của một cột tham chiếu trực tiếp tới cột khác.

### Cách khắc phục

Không viết:

```sql
KyDenThang INT CHECK(KyDenThang >= KyTuThang)
```

mà dùng Table-level Constraint:

```sql
KyDenThang INT NOT NULL,

CONSTRAINT CK_TTT_Ky
CHECK(KyDenThang >= KyTuThang)
```

---

## 18.2. Sai thứ tự tạo bảng

### Nguyên nhân

Bảng con được tạo trước bảng cha dẫn đến lỗi FOREIGN KEY.

### Khắc phục

Tạo bảng theo thứ tự phụ thuộc:

```text
Tang
↓
VanPhong

KhachHang
↓
HopDongThue
↓
ChiTietHopDong
↓
ThanhToanTienThue
↓
Dịch vụ / Gia hạn / Nhân viên...
```

---

## 18.3. Thuê trùng văn phòng

### Nguyên nhân

Chỉ kiểm tra trạng thái `Đang thuê` không đủ để xác định overlap.

### Khắc phục

Kiểm tra:

```text
NgayBatDauMoi <= NgayKetThucCu
AND
NgayKetThucMoi >= NgayBatDauCu
```

trước khi lập hợp đồng.

---

## 18.4. Lập hợp đồng nhiều bảng

Nếu:

```text
INSERT HopDongThue
```

thành công nhưng `ChiTietHopDong` hoặc thanh toán thất bại thì dữ liệu bị dở dang.

### Khắc phục

Dùng:

```text
BEGIN TRAN
COMMIT
ROLLBACK
TRY...CATCH
```

trong `sp_LapHopDongVaThu6Thang`.

---

## 18.5. Gia hạn khi còn nợ

### Khắc phục

Trong `sp_GiaHanVanPhong`, kiểm tra:

```text
ThanhToanTienThue
HoaDonDichVu
```

không còn bản ghi `Chưa thanh toán`.

---

## 18.6. Gia hạn vượt giới hạn

### Khắc phục

Tính:

```text
Tổng gia hạn cũ
+
Số tháng gia hạn mới
<=
FLOOR(SoThangThue / 2)
```

---

## 18.7. State Diagram PlantUML

Một số cú pháp `entry /`, `do /` không được draw.io xử lý đúng khi đặt trực tiếp bên trong block.

### Khắc phục

Dùng:

```plantuml
HieuLuc : entry / Ghi nhận hợp đồng có hiệu lực
HieuLuc : do / Theo dõi thời hạn thuê
HieuLuc : do / Theo dõi thanh toán tiền thuê
```

---

# 19. Hướng dẫn chạy lại dự án

## Bước 1 - Clone Repository

```bash
git clone https://github.com/BaoHuz/LAB_AT_OOSD.git
```

Sau đó:

```bash
cd LAB_AT_OOSD/LAB8
```

---

## Bước 2 - Tạo Database

Mở:

```text
QuanLyChoThueVanPhong.sql
```

bằng SQL Server Management Studio.

Nhấn:

```text
Execute
```

Kiểm tra Database:

```text
QuanLyChoThueVanPhong
```

---

## Bước 3 - Kiểm tra bảng

```sql
USE QuanLyChoThueVanPhong;
GO

SELECT * FROM Tang;
SELECT * FROM VanPhong;
SELECT * FROM KhachHang;
SELECT * FROM HopDongThue;
SELECT * FROM ChiTietHopDong;
SELECT * FROM ThanhToanTienThue;
SELECT * FROM DichVu;
SELECT * FROM SuDungDichVu;
SELECT * FROM HoaDonDichVu;
SELECT * FROM ChiTietHoaDonDichVu;
SELECT * FROM ThanhToanDichVu;
SELECT * FROM PhieuGiaHan;
SELECT * FROM NhanVienVanPhong;
SELECT * FROM TheGiuXe;
SELECT * FROM KiemTraPhong;
```

---

## Bước 4 - Kiểm tra Stored Procedure

```sql
SELECT name
FROM sys.procedures
ORDER BY name;
```

Kết quả cần có:

```text
sp_GiaHanVanPhong
sp_LapHoaDonDichVuThang
sp_LapHopDongVaThu6Thang
```

---

## Bước 5 - Cấu hình Connection String

Mở:

```text
LAB8/QuanLyChoThueVanPhong/QuanLyChoThueVanPhong/App.config
```

Ví dụ SQL Server Express:

```xml
<connectionStrings>
  <add name="Db"
       connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyChoThueVanPhong;Integrated Security=True;TrustServerCertificate=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Nếu sử dụng SQL Server mặc định:

```text
Data Source=.
```

Nếu sử dụng LocalDB:

```text
Data Source=(localdb)\MSSQLLocalDB
```

---

## Bước 6 - Mở Solution

Mở:

```text
LAB8/QuanLyChoThueVanPhong/QuanLyChoThueVanPhong.sln
```

bằng Visual Studio 2022.

---

## Bước 7 - Build

Chọn:

```text
Build
→ Clean Solution
→ Rebuild Solution
```

hoặc:

```text
Ctrl + Shift + B
```

Đảm bảo:

```text
0 Error(s)
```

---

## Bước 8 - Chạy chương trình

Nhấn:

```text
F5
```

---
