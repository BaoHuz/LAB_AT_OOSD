# LAB 4 - PHÂN TÍCH, THIẾT KẾ HỆ THỐNG VÀ CHUYỂN ĐỔI UML SANG CSDL

## 1. Thông tin sinh viên

- **Họ và tên:** Nguyễn Hữu Bảo
- **MSSV:** 1250080016
- **Lớp:** 12_ĐH_CNPM1
- **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng
- **Bài thực hành:** LAB 4
- **Repository:** `LAB_AT_OOSD`

---

## 2. Môi trường và công cụ

- **Hệ điều hành:** Windows 11
- **IDE:** Microsoft Visual Studio 2022
- **Ngôn ngữ:** C#
- **Framework:** .NET Framework 4.7.2
- **Giao diện:** Windows Forms
- **Cơ sở dữ liệu:** Microsoft SQL Server
- **Truy cập dữ liệu:** ADO.NET
- **Công cụ UML:** Draw.io / PlantUML
- **Quản lý mã nguồn:** Git & GitHub

---

## 3. Cấu trúc LAB4

```text
LAB4/
│
├── README.md
│
├── Bai1_SoDo/
│   ├── 1250080016_NguyenHuuBao_12_ĐH_CNPM1_LAB4_bai1.docx
│   ├── QuanLyNhanVienKD_DB.sql
│   └── LAB4_Bai1.drawio
│
└── Bai2_LAB_shopping/
    ├── 1250080016_NguyenHuuBao_12_ĐH_CNPM1_Lab4_bai2.docx
    ├── eShoppingDB.sql
    ├── LAB4_Bai2.drawio
    │
    └── eShoppingApp/
        ├── eShoppingApp.sln
        │
        └── eShoppingApp/
            ├── App.config
            ├── Program.cs
            │
            ├── Data/
            │   └── Db.cs
            │
            ├── Services/
            │   ├── AccountService.cs
            │   ├── OrderService.cs
            │   ├── ProductAdapter.cs
            │   ├── PaymentAdapter.cs
            │   └── EmailAdapter.cs
            │
            └── UI/
                ├── frmMain.cs
                ├── frmDanhSachSanPham.cs
                ├── frmChiTietSanPham.cs
                ├── frmThanhToan.cs
                ├── frmDangNhap.cs
                └── frmDangKy.cs
```

> Các thư mục `.vs`, `bin` và `obj` do Visual Studio tự sinh và không phải thành phần mã nguồn chính.

---

# 4. BÀI 1 - CHUYỂN ĐỔI MÔ HÌNH UML SANG CSDL

## 4.1. Mục tiêu

Chuyển đổi Class Diagram của hệ thống quản lý nhân viên kinh doanh và đơn hàng sang mô hình cơ sở dữ liệu quan hệ chuẩn hóa.

File báo cáo:

```text
Bai1_SoDo/1250080016_NguyenHuuBao_12_ĐH_CNPM1_LAB4_bai1.docx
```

File SQL:

```text
Bai1_SoDo/QuanLyNhanVienKD_DB.sql
```

File sơ đồ:

```text
Bai1_SoDo/LAB4_Bai1.drawio
```

---

## 4.2. Nội dung thực hiện

### Xử lý kế thừa

Mô hình ban đầu gồm:

```text
NHAN_VIEN
    ↓
NV_KINH_DOANH
    ↓
NV_KD_LAU_NAM / NV_KD_TAP_SU
```

Khi chuyển sang CSDL:

- `NhanVien` lưu các thuộc tính chung.
- `NhanVienKinhDoanh` kế thừa thông qua `MaNV`.
- Thuộc tính `CapDoKD` dùng để phân biệt:
  - `Lâu năm`
  - `Tập sự`

---

### Quan hệ tự tham chiếu

Một nhân viên kinh doanh lâu năm có thể hướng dẫn nhiều nhân viên tập sự.

Được hiện thực bằng:

```text
MaNVHuongDan
```

trong bảng `NhanVienKinhDoanh`.

---

### Association Class `ThuongLuong`

Quan hệ giữa:

```text
NhanVienKinhDoanh
↔
DonHang
```

là quan hệ nhiều-nhiều và có thuộc tính:

```text
HoaHong
```

Do đó được chuyển thành bảng trung gian:

```text
ThuongLuong
```

với khóa chính:

```text
(MaNV, SoDOH)
```

---

### Quá trình tăng lương

Một nhân viên có thể có nhiều lần tăng lương.

Bảng:

```text
QuaTrinhTangLuong
```

lưu:

- Nhân viên.
- Ngày hiệu lực.
- Lương mới.

Có ràng buộc:

```text
UNIQUE (MaNV, NgayHieuLuc)
```

để tránh một nhân viên có hai quyết định tăng lương trong cùng ngày.

---

## 4.3. Các bảng CSDL Bài 1

Database:

```text
QuanLyNhanVienKD_DB
```

Các bảng:

1. `NhanVien`
2. `NhanVienKinhDoanh`
3. `QuaTrinhTangLuong`
4. `DonHang`
5. `ThuongLuong`

---

## 4.4. Các sơ đồ đã thực hiện

File:

```text
LAB4_Bai1.drawio
```

Các page UML chính:

```text
ClassDiagram
Sequence_ThuongLuong
State_NV_KinhDoanh
Activity_TangLuong
```

Ngoài ra báo cáo có Relational Model thể hiện cấu trúc các bảng SQL Server.

Các sơ đồ gồm:

- Relational Model
- Class Diagram
- Sequence Diagram
- State Machine Diagram
- Activity Diagram

---

# 5. BÀI 2 - HỆ THỐNG CỬA HÀNG ONLINE e-SHOPPING

## 5.1. Mục tiêu

Phân tích, thiết kế và xây dựng Prototype cho hệ thống cửa hàng online **e-SHOPPING**.

Hệ thống hỗ trợ:

- Duyệt sản phẩm theo nhóm.
- Xem chi tiết sản phẩm.
- Quản lý giỏ hàng.
- Đăng ký tài khoản.
- Đăng nhập.
- Đặt hàng.
- Tính phí giao hàng.
- Thanh toán bằng thẻ tín dụng.
- Lưu đơn hàng.
- Mô phỏng gửi email xác nhận.

---

## 5.2. System Boundaries

Hệ thống e-SHOPPING tương tác với ba hệ thống/dịch vụ ngoài:

### Product System

Cung cấp:

- Nhóm sản phẩm.
- Danh sách sản phẩm.
- Giá bán.
- Thông tin kỹ thuật.
- Tình trạng sản phẩm.

### Payment Gateway

Dùng để mô phỏng quá trình:

- Kiểm tra loại thẻ.
- Kiểm tra độ dài số thẻ.
- Kiểm tra mã CSV.
- Xác thực thông tin thanh toán.

### Email Service

`EmailAdapter` mô phỏng việc gửi email xác nhận đơn hàng sau khi đặt hàng thành công.

---

## 5.3. Bộ UML

File:

```text
LAB4_Bai2.drawio
```

Các page:

```text
UseCase_TongQuan
UseCase_UC01_DuyetSanPham
UseCase_UC05_DatHangThanhToan
AnalysisClassDiagram
State_DonHang
Sequence_DatHangThanhToan
Activity_TinhPhiGiaoHang_DatHang
DesignClassDiagram
ERD
```

Các loại sơ đồ đã thực hiện:

- Use Case Diagram tổng quan.
- Use Case UC01 - Duyệt & Xem chi tiết sản phẩm.
- Use Case UC05 - Đặt hàng & Thanh toán.
- Analysis Class Diagram.
- State Machine Diagram của đơn hàng.
- Sequence Diagram đặt hàng và thanh toán.
- Activity Diagram tính phí giao hàng và đặt hàng.
- Design Class Diagram.
- ERD.

---

# 6. Cơ sở dữ liệu e-SHOPPING

File:

```text
eShoppingDB.sql
```

Database:

```text
eShoppingDB
```

Các bảng:

1. `KhachHang`
2. `NhomSanPham`
3. `SanPham`
4. `DonHang`
5. `ChiTietDonHang`

---

## 6.1. Bảo mật thông tin thẻ

Hệ thống không lưu mã CSV vào CSDL.

Số thẻ chỉ được lưu dưới dạng che bớt:

```text
**** **** **** 1234
```

Bảng `DonHang` chỉ lưu:

```text
LoaiTheThanhToan
SoTheMasked
```

---

# 7. Kiến trúc chương trình

Prototype sử dụng kiến trúc:

```text
UI
 ↓
Services / Adapters
 ↓
Data
 ↓
SQL Server
```

---

## 7.1. Data Layer

File:

```text
Data/Db.cs
```

Chịu trách nhiệm:

- Tạo kết nối SQL Server.
- Thực thi truy vấn ADO.NET.
- Cung cấp kết nối cho các lớp Service.

---

## 7.2. Services / Adapters

### `AccountService.cs`

- Đăng nhập.
- Đăng ký tài khoản.
- Lưu thông tin khách hàng hiện tại.

### `OrderService.cs`

- Tính tổng giỏ hàng.
- Tính phí giao hàng.
- Gọi PaymentAdapter.
- Tạo đơn hàng.
- Tạo chi tiết đơn hàng.
- Masking số thẻ.
- Điều khiển SQL Transaction.
- Rollback khi lưu dữ liệu thất bại.
- Gọi EmailAdapter sau khi đặt hàng thành công.

### `ProductAdapter.cs`

- Đọc dữ liệu sản phẩm.
- Lấy thông tin chi tiết sản phẩm.

### `PaymentAdapter.cs`

Mô phỏng kiểm tra thông tin thẻ.

Quy tắc:

```text
VISA / Master / Discover
→ 16 chữ số
→ CSV 3 chữ số

American Express
→ 15 chữ số
→ CSV 4 chữ số
```

### `EmailAdapter.cs`

Mô phỏng gửi email xác nhận đơn hàng.

Email không chứa:

- Số thẻ đầy đủ.
- Mã CSV.

---

# 8. Quy tắc tính phí giao hàng

Các hình thức:

```text
THUONG
CPN
CPN_TRONG_NGAY
```

Quy tắc miễn phí:

```text
Tổng giỏ hàng >= 1.000.000 VNĐ
và Loại phiếu = CPN
→ Phí giao hàng = 0
```

```text
Tổng giỏ hàng >= 5.000.000 VNĐ
và Loại phiếu = CPN_TRONG_NGAY
→ Phí giao hàng = 0
```

Nếu không đủ điều kiện miễn phí:

```text
Nội thành  = 20.000 VNĐ
Ngoại thành = 45.000 VNĐ
```

Phụ phí:

```text
CPN             + 15.000 VNĐ
CPN trong ngày  + 35.000 VNĐ
```

---

# 9. SQL Transaction

Khi đặt hàng:

```text
BeginTransaction
      ↓
INSERT DonHang
      ↓
INSERT ChiTietDonHang
      ↓
Commit
```

Nếu xảy ra lỗi:

```text
Exception
   ↓
Rollback
```

Điều này giúp tránh trường hợp:

- Đã tạo `DonHang` nhưng chưa tạo đủ `ChiTietDonHang`.
- Dữ liệu đơn hàng bị lưu dở dang.

---

# 10. Các Form đã thực hiện

## `frmMain`

- Màn hình MDI chính.
- Đăng nhập.
- Đăng xuất.
- Điều hướng đến màn hình mua sắm.

## `frmDanhSachSanPham`

- Lọc sản phẩm theo nhóm.
- Hiển thị danh sách sản phẩm.
- Thêm sản phẩm vào giỏ.
- Tăng số lượng sản phẩm.
- Xóa sản phẩm khỏi giỏ.
- Tính tổng tiền.
- Xem chi tiết sản phẩm.
- Chuyển sang thanh toán.

## `frmChiTietSanPham`

Hiển thị:

- Tên sản phẩm.
- Nhà sản xuất.
- Giá bán.
- Tình trạng.
- Mô tả kỹ thuật.

## `frmDangNhap`

- Nhập tên đăng nhập.
- Nhập mật khẩu.
- Xác thực tài khoản.

## `frmDangKy`

Cho phép nhập:

- Họ tên.
- Tên đăng nhập.
- Mật khẩu.
- Email.
- Số điện thoại.
- Địa chỉ.

## `frmThanhToan`

Cho phép nhập:

### Người nhận

- Họ tên.
- Địa chỉ.
- Điện thoại.
- Email.

### Giao hàng

- Loại phiếu.
- Khu vực.

### Thẻ tín dụng

- Loại thẻ.
- Số thẻ.
- CSV.
- Hạn sử dụng.
- Chủ thẻ.

Hệ thống tự tính:

```text
Tổng thanh toán
=
Tổng giỏ hàng + Phí giao hàng
```

---

# 11. Kiểm thử

Báo cáo có:

- Traceability Matrix.
- Test Case cho phí giao hàng.
- Test Case thẻ VISA.
- Test Case American Express.
- Test Case SQL Transaction.
- Test Case Masking thẻ.
- Test Case email xác nhận.

Một số trường hợp tiêu biểu:

### `TC_SHIP_01`

```text
Tổng giỏ hàng = 1.500.000
Loại phiếu = CPN
→ Phí giao = 0
```

### `TC_SHIP_02`

```text
Tổng giỏ hàng = 800.000
Loại phiếu = CPN_TRONG_NGAY
Khu vực = Nội thành

20.000 + 35.000
= 55.000 VNĐ
```

### `TC_PAY_01`

```text
VISA có số thẻ không đủ 16 chữ số
→ Từ chối thanh toán
```

### `TC_PAY_02`

```text
Amex sử dụng CSV 3 chữ số
→ Từ chối
→ Yêu cầu CSV 4 chữ số
```

---

# 12. Kết quả thực hiện

## Bài 1

Đã thực hiện:

- Phân tích quy tắc chuyển đổi UML → Relational Model.
- Chuyển đổi kế thừa.
- Quan hệ tự tham chiếu.
- Association Class.
- Quan hệ 1-N.
- Chuẩn hóa tới 3NF.
- Viết SQL DDL.
- Xây dựng các sơ đồ UML liên quan.

## Bài 2

Đã thực hiện:

- Phân định System Boundaries.
- Use Case.
- Analysis Class Diagram.
- State Machine Diagram.
- Sequence Diagram.
- Activity Diagram.
- Design Class Diagram.
- ERD.
- SQL Server Database.
- WinForms Prototype.
- Giỏ hàng.
- Đăng nhập / đăng ký.
- Tính phí giao hàng.
- Thanh toán mô phỏng.
- SQL Transaction.
- Masking số thẻ.
- Email xác nhận mô phỏng.
- Traceability Matrix.
- Test Cases.

---

# 13. Lỗi gặp phải và cách khắc phục

| STT | Lỗi | Nguyên nhân | Cách khắc phục |
|---|---|---|---|
| 1 | Không mở được cửa sổ sản phẩm hoặc Form không phản hồi như mong muốn | Logic MDI và việc chống mở trùng Form | Kiểm tra `MdiChildren`, sử dụng `Activate()` khi Form đã tồn tại và mở Form mới khi chưa tồn tại |
| 2 | Không xem được chi tiết sản phẩm | Thiếu nút hoặc chưa gắn sự kiện `btnXemChiTiet` | Bổ sung nút và mở `frmChiTietSanPham` bằng `ShowDialog()` |
| 3 | Amex 15 số nhưng bị từ chối | Validate độ dài thẻ/CSV chưa đúng | Sửa Amex thành 15 số và CSV 4 số |
| 4 | Đơn hàng có thể gán sai khách hàng | Sử dụng mã khách hàng cố định | Lấy `MaKH` từ `AccountService.CurrentMaKH` |
| 5 | Quy tắc miễn phí giao hàng chưa đúng | Điều kiện tổng tiền chưa kết hợp với loại giao hàng | Chỉ miễn CPN từ 1 triệu và CPN trong ngày từ 5 triệu |
| 6 | Lỗi khi lưu nhiều chi tiết đơn hàng | Một lệnh SQL trong Transaction thất bại | Rollback toàn bộ Transaction và hiển thị lỗi |

---

# 14. Hướng dẫn chạy LAB4

## 14.1. Bài 1

Mở SQL Server Management Studio.

Chạy:

```text
Bai1_SoDo/QuanLyNhanVienKD_DB.sql
```

Kiểm tra Database:

```text
QuanLyNhanVienKD_DB
```

---

## 14.2. Bài 2 - Tạo Database

Chạy:

```text
Bai2_LAB_shopping/eShoppingDB.sql
```

Kiểm tra Database:

```text
eShoppingDB
```

---

## 14.3. Mở Solution

Mở:

```text
Bai2_LAB_shopping/eShoppingApp/eShoppingApp.sln
```

bằng Visual Studio 2022.

---

## 14.4. Kiểm tra Connection String

Mở:

```text
eShoppingApp/eShoppingApp/Data/Db.cs
```

Ví dụ:

```csharp
private static string connectionString =
    @"Data Source=.;Initial Catalog=eShoppingDB;Integrated Security=True";
```

Nếu dùng SQL Server Express:

```text
Data Source=.\SQLEXPRESS
```

---

## 14.5. Build

Trong Visual Studio:

```text
Build
→ Rebuild Solution
```

hoặc:

```text
Ctrl + Shift + B
```

---

## 14.6. Chạy

Nhấn:

```text
F5
```

---