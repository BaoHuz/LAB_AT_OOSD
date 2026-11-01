# LAB 3 - HỆ THỐNG QUẢN LÝ KHÁCH SẠN

## 1. Thông tin sinh viên

- **Họ và tên:** Nguyễn Hữu Bảo
- **MSSV:** 1250080016
- **Lớp:** 12_ĐH_CNPM1
- **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng
- **Bài thực hành:** LAB 3 - Hệ thống quản lý khách sạn
- **Repository:** https://github.com/BaoHuz/LAB_AT_OOSD

---

## 2. Mục tiêu bài LAB

Xây dựng ứng dụng **Quản lý khách sạn** bằng C# Windows Forms kết hợp SQL Server.

Các nội dung chính đã thực hiện:

- Xây dựng cơ sở dữ liệu quản lý khách sạn.
- Quản lý khu vực, nhân viên, loại tiện nghi, dịch vụ và quy định đền bù.
- Quản lý phòng và tiện nghi trong phòng.
- Quản lý việc lắp đặt, luân chuyển tiện nghi.
- Quản lý khách hàng.
- Lập phiếu đặt phòng.
- Nhận phòng và quản lý người lưu trú.
- Ghi nhận dịch vụ khách sử dụng.
- Trả phòng.
- Lập phiếu đền bù.
- Lập hóa đơn.
- Thanh toán hóa đơn.
- Thống kê hoạt động khách sạn theo khoảng thời gian.
- Chụp ảnh kết quả thực tế và đưa vào báo cáo Word.

---

## 3. Công nghệ và môi trường

- **Hệ điều hành:** Windows 11
- **IDE:** Microsoft Visual Studio 2022
- **Ngôn ngữ:** C#
- **Framework:** .NET Framework 4.7.2
- **Giao diện:** Windows Forms
- **Cơ sở dữ liệu:** Microsoft SQL Server
- **Truy cập dữ liệu:** ADO.NET
- **Kiến trúc chương trình:** UI → Service → Data → SQL Server

---

## 4. Cấu trúc thư mục

```text
LAB3/
│
├── 1250080016_NguyenHuuBao_12_ĐH_CNPM1_LAB3.docx
├── QuanLyKhachSan.sql
├── README.md
├── .vs/
│
└── QuanLyKhachSan/
    │
    ├── QuanLyKhachSan.sln
    │
    └── QuanLyKhachSan/
        ├── App.config
        ├── Program.cs
        │
        ├── Data/
        │   └── Db.cs
        │
        ├── Services/
        │   ├── DanhMucService.cs
        │   ├── PhongTienNghiService.cs
        │   ├── DatPhongService.cs
        │   ├── DichVuService.cs
        │   ├── TraPhongService.cs
        │   └── ThongKeService.cs
        │
        └── Forms/
            ├── FrmMain.cs
            ├── FrmMain.Designer.cs
            ├── FrmDanhMuc.cs
            ├── FrmDanhMuc.Designer.cs
            ├── FrmPhongTienNghi.cs
            ├── FrmPhongTienNghi.Designer.cs
            ├── FrmDatPhong.cs
            ├── FrmDatPhong.Designer.cs
            ├── FrmDichVu.cs
            ├── FrmDichVu.Designer.cs
            ├── FrmTraPhong.cs
            ├── FrmTraPhong.Designer.cs
            ├── FrmThongKe.cs
            └── FrmThongKe.Designer.cs
```

> `.vs`, `bin` và `obj` là các thư mục do Visual Studio tự sinh, không phải mã nguồn chính của bài.

---

## 5. Thiết kế cơ sở dữ liệu

File SQL:

```text
QuanLyKhachSan.sql
```

Hệ thống sử dụng 18 bảng:

1. `KhuVuc`
2. `NhanVien`
3. `LoaiTienNghi`
4. `TienNghi`
5. `Phong`
6. `PhieuLapDat`
7. `KhachHang`
8. `PhieuDatPhong`
9. `ChiTietDatPhong`
10. `NguoiLuuTru`
11. `DichVu`
12. `PhieuSuDungDV`
13. `ChiTietPhieuSuDungDV`
14. `QuyDinhDenBu`
15. `PhieuDenBu`
16. `ChiTietPhieuDenBu`
17. `HoaDon`
18. `ThanhToan`

Báo cáo Word đã chụp dữ liệu thực tế của các bảng và sơ đồ Database Diagram trong SQL Server.

---

## 6. Các chức năng đã thực hiện

### 6.1. `FrmMain` - Màn hình chính

Màn hình điều hướng đến các chức năng:

- Danh mục
- Phòng - Tiện nghi
- Đặt / Nhận phòng
- Sử dụng dịch vụ
- Trả phòng - Thanh toán
- Thống kê
- Thoát chương trình

Các Form con được mở bằng `ShowDialog()`.

---

### 6.2. `FrmDanhMuc` - Quản lý danh mục

Quản lý các danh mục cơ bản:

#### Khu vực

- Thêm khu vực.
- Hiển thị danh sách khu vực.

Thông tin:

- Mã khu vực
- Tên khu vực

#### Nhân viên

- Thêm nhân viên.
- Hiển thị danh sách nhân viên.

Thông tin:

- Mã nhân viên
- Họ tên
- Vai trò
- Số điện thoại

#### Loại tiện nghi

- Thêm loại tiện nghi.
- Hiển thị danh sách loại tiện nghi.

#### Dịch vụ

- Thêm dịch vụ.
- Quản lý:
  - Mã dịch vụ
  - Tên dịch vụ
  - Đơn vị tính
  - Đơn giá

#### Quy định đền bù

- Thêm quy định đền bù.
- Liên kết loại tiện nghi.
- Xác định mức độ thiệt hại.
- Xác định số tiền đền bù.

---

## 7. Quản lý phòng và tiện nghi

### `FrmPhongTienNghi`

Thực hiện:

- Thêm phòng.
- Xác định khu vực của phòng.
- Xác định sức chứa tối đa.
- Xác định đơn giá theo ngày.
- Thêm tiện nghi.
- Quản lý số thứ tự thiết bị.
- Quản lý tình trạng tiện nghi.
- Lập phiếu lắp đặt tiện nghi vào phòng.
- Ghi nhận nhân viên thực hiện.
- Ghi nhận ngày lắp đặt.

Các danh sách được tải trực tiếp từ SQL Server thông qua lớp Service.

---

## 8. Đặt phòng và nhận phòng

### `FrmDatPhong`

Form gồm các nghiệp vụ:

### Khách hàng

- Thêm khách hàng.
- Quản lý:
  - Mã khách
  - Họ tên
  - CCCD/CMND
  - Quốc tịch
  - Số điện thoại

### Đặt phòng

- Chọn khách hàng.
- Chọn nhân viên lập phiếu.
- Chọn ngày lập.
- Chọn ngày nhận.
- Chọn ngày trả.
- Nhập tiền cọc.
- Chọn kênh đặt:
  - Điện thoại
  - Website
  - Trực tiếp
- Chọn một hoặc nhiều phòng.
- Kiểm tra phòng đã được chọn trước khi thêm vào danh sách.
- Lập phiếu đặt phòng.

### Nhận phòng

- Chọn phiếu đặt.
- Xem chi tiết các phòng đã đặt.
- Thêm người lưu trú.
- Nhận phòng.
- Có chức năng đánh dấu `No Show` nếu khách không nhận phòng.

---

## 9. Sử dụng dịch vụ

### `FrmDichVu`

Thực hiện:

- Chọn phiếu khách đang lưu trú.
- Xác định phòng.
- Chọn dịch vụ.
- Chọn ngày sử dụng.
- Nhập số lượng.
- Ghi nhận lượt sử dụng dịch vụ.
- Hiển thị lịch sử dịch vụ đã sử dụng.
- Tính thành tiền dựa trên số lượng và đơn giá.

Một số dịch vụ mẫu:

- Ăn sáng
- Tắm hơi
- Karaoke

---

## 10. Trả phòng - Đền bù - Hóa đơn - Thanh toán

### `FrmTraPhong`

Form thực hiện nhiều nghiệp vụ liên quan đến quá trình trả phòng.

### Trả phòng

- Chọn phiếu khách đang ở.
- Hiển thị các phòng trong phiếu.
- Kiểm tra tiện nghi trong phòng.

### Đền bù

Nếu có tiện nghi bị mất hoặc hư hỏng:

- Chọn tiện nghi.
- Nhập mức độ thiệt hại.
- Nhập số tiền đền bù.
- Không cho thêm trùng cùng một tiện nghi vào phiếu.
- Lập phiếu đền bù.
- Ghi nhận nhân viên lập phiếu.

### Hóa đơn

- Tạo hóa đơn theo phiếu đặt.
- Tính số ngày thực tế.
- Tính tiền phòng.
- Tính tiền dịch vụ.
- Tổng hợp tiền đền bù.
- Khấu trừ tiền cọc nếu nghiệp vụ yêu cầu.
- Lưu hóa đơn.

### Thanh toán

Hỗ trợ các hình thức:

- Tiền mặt
- Chuyển khoản
- Thẻ
- Ví điện tử

Thông tin thanh toán gồm:

- Mã thanh toán
- Số hóa đơn
- Ngày thanh toán
- Hình thức
- Số tiền

Sau khi hoàn tất có thể thực hiện chức năng trả phòng.

---

## 11. Thống kê

### `FrmThongKe`

Cho phép chọn:

```text
Từ ngày → Đến ngày
```

Hệ thống thống kê:

- Số phiếu đặt.
- Số lượt đang ở.
- Số hóa đơn.
- Doanh thu hóa đơn.
- Tổng tiền đền bù.
- Danh sách dịch vụ đã sử dụng.
- Tổng số lượng sử dụng từng dịch vụ.
- Tổng tiền của từng dịch vụ.

Có kiểm tra dữ liệu:

```text
Đến ngày không được trước Từ ngày.
```

---

## 12. Kiểm tra nghiệp vụ đã thực hiện

Trong quá trình chạy thử, các nghiệp vụ sau đã được kiểm tra:

### Phòng

- Không xếp số người vượt quá sức chứa tối đa.
- Chỉ sử dụng phòng phù hợp với trạng thái hiện tại.

### Tiện nghi

- Quản lý thiết bị tiện nghi theo phòng.
- Theo dõi tình trạng thiết bị.
- Tránh ghi nhận trùng thông tin lắp đặt không hợp lệ.

### Đặt phòng

- Không thêm cùng một phòng hai lần vào danh sách chọn.
- Lưu nhiều phòng trong một phiếu đặt.
- Quản lý số người của từng phòng.

### Dịch vụ

- Ghi nhận số lượng dịch vụ.
- Tính thành tiền dựa trên:

```text
Thành tiền = Số lượng × Đơn giá
```

### Đền bù

- Không thêm trùng một tiện nghi trong cùng phiếu đền bù.
- Ghi nhận mức độ thiệt hại.
- Ghi nhận số tiền đền bù.

### Thanh toán

- Hỗ trợ nhiều hình thức thanh toán.
- Ghi nhận thông tin thanh toán vào cơ sở dữ liệu.

---

## 13. Kết quả thực hiện

Bài LAB đã hoàn thành các nội dung chính:

- Tạo cơ sở dữ liệu SQL Server.
- Tạo và nhập dữ liệu mẫu cho 18 bảng.
- Tạo Database Diagram.
- Xây dựng chương trình C# WinForms.
- Kết nối WinForms với SQL Server bằng ADO.NET.
- Tách chương trình thành các lớp `Forms`, `Services` và `Data`.
- Quản lý danh mục khách sạn.
- Quản lý phòng và tiện nghi.
- Quản lý khách hàng.
- Đặt và nhận phòng.
- Ghi nhận người lưu trú.
- Sử dụng dịch vụ.
- Xử lý đền bù.
- Lập hóa đơn.
- Thanh toán.
- Hoàn tất trả phòng.
- Thống kê theo khoảng thời gian.
- Chụp ảnh kết quả thực tế và đưa vào báo cáo Word.

File báo cáo:

```text
1250080016_NguyenHuuBao_12_ĐH_CNPM1_LAB3.docx
```

---

## 14. Một số lỗi có thể gặp và cách khắc phục

### 14.1. Lỗi file `.exe` đang được sử dụng

Ví dụ:

```text
Could not copy ... because it is being used by another process
```

**Nguyên nhân:**

Ứng dụng `QuanLyKhachSan.exe` vẫn còn chạy.

**Khắc phục:**

- Đóng chương trình đang chạy.
- Mở Task Manager.
- End Task tiến trình `QuanLyKhachSan.exe`.
- Chọn:

```text
Build → Clean Solution
Build → Rebuild Solution
```

---

### 14.2. Lỗi chuỗi kết nối

Ví dụ:

```text
Keyword not supported: 'data source'
```

**Nguyên nhân:**

Connection String trong `App.config` bị sai cú pháp.

**Khắc phục:**

Kiểm tra lại:

```xml
<connectionStrings>
    <add name="QuanLyKhachSanDb"
         connectionString="Data Source=.;Initial Catalog=QuanLyKhachSan;Integrated Security=True;"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

Thay `Data Source` cho phù hợp SQL Server trên máy.

Ví dụ SQL Server Express:

```text
Data Source=.\SQLEXPRESS
```

Hoặc LocalDB:

```text
Data Source=(localdb)\MSSQLLocalDB
```

---

### 14.3. Không mở được Database

Ví dụ:

```text
Cannot open database "QuanLyKhachSan" requested by the login
```

**Nguyên nhân:**

- Chưa chạy script SQL.
- Sai tên Database.
- Sai SQL Server Instance.

**Khắc phục:**

Chạy lại:

```text
QuanLyKhachSan.sql
```

sau đó kiểm tra Database đã được tạo thành công.

---

### 14.4. PRIMARY KEY hoặc FOREIGN KEY bị lỗi

Ví dụ:

```text
Violation of PRIMARY KEY constraint
Violation of FOREIGN KEY constraint
```

**Nguyên nhân:**

- Insert trùng khóa chính.
- Dữ liệu cha chưa tồn tại.
- Xóa dữ liệu đang được bảng khác tham chiếu.

**Khắc phục:**

- Kiểm tra dữ liệu trước khi thêm.
- Insert bảng cha trước bảng con.
- Nếu cần xóa dữ liệu thử nghiệm, xóa bảng con trước bảng cha.

---

## 15. Hướng dẫn chạy lại dự án

### Bước 1 - Tạo Database

Mở:

```text
QuanLyKhachSan.sql
```

bằng SQL Server Management Studio hoặc SQL Server Object Explorer.

Chạy toàn bộ script.

Kiểm tra Database và dữ liệu mẫu đã được tạo.

---

### Bước 2 - Mở Visual Studio

Mở:

```text
QuanLyKhachSan/QuanLyKhachSan.sln
```

bằng Visual Studio 2022.

---

### Bước 3 - Cấu hình Connection String

Mở:

```text
App.config
```

Kiểm tra `Data Source` và tên Database.

---

### Bước 4 - Build

Chọn:

```text
Build
→ Rebuild Solution
```

hoặc:

```text
Ctrl + Shift + B
```

Kiểm tra project không còn lỗi compile.

---

### Bước 5 - Chạy

Nhấn:

```text
F5
```

hoặc nút:

```text
Start
```

---

## 16. Trình tự kiểm tra chương trình

Có thể kiểm tra lần lượt:

```text
FrmMain
   ↓
Danh mục
   ↓
Phòng - Tiện nghi
   ↓
Khách hàng
   ↓
Đặt phòng
   ↓
Nhận phòng
   ↓
Sử dụng dịch vụ
   ↓
Trả phòng / Đền bù
   ↓
Lập hóa đơn
   ↓
Thanh toán
   ↓
Thống kê
```

---
