# LAB 2 - HỆ THỐNG QUẢN LÝ THƯ VIỆN

## 1. Thông tin sinh viên

- **Họ và tên:** Nguyễn Hữu Bảo
- **MSSV:** 1250080016
- **Lớp:** 12_ĐH_CNPM1
- **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng
- **Bài thực hành:** LAB 2 - Hệ thống quản lý thư viện

---

## 2. Mục tiêu bài LAB

Xây dựng ứng dụng **Quản lý thư viện** bằng C# Windows Forms kết hợp SQL Server.

Bài thực hành tập trung vào các nội dung:

- Quản lý nhân viên, thể loại và nhà xuất bản.
- Quản lý đầu sách.
- Quản lý độc giả và thẻ thư viện.
- Thực hiện nghiệp vụ mượn sách.
- Thực hiện nghiệp vụ trả sách và xử lý phạt.
- Thống kê tình hình mượn, quá hạn, mất, hư hỏng và phí phạt.
- Tổ chức chương trình theo kiến trúc:

```text
UI (Forms)
   ↓
Service
   ↓
Data
   ↓
SQL Server
```

---

## 3. Công nghệ và môi trường

- **IDE:** Microsoft Visual Studio 2022
- **Ngôn ngữ:** C#
- **Framework:** .NET Framework 4.7.2
- **Giao diện:** Windows Forms
- **Cơ sở dữ liệu:** Microsoft SQL Server
- **Truy cập dữ liệu:** ADO.NET
- **Kiến trúc:** UI → Service → Data
- **Database:** `QuanLyThuVienDB`

---

## 4. Cấu trúc thư mục

```text
LAB2/
│
├── 1250080016_NguyenHuuBao_12_ĐH_CNPM1_LAB2.docx
├── QuanLyThuVien.sql
├── QuanLyThuVien.sln
├── Models.cs
├── README.md
│
└── QuanLyThuVien/
    │
    ├── App.config
    ├── Program.cs
    ├── Models.cs
    │
    ├── Data/
    │   └── Db.cs
    │
    ├── Services/
    │   ├── DanhMucService.cs
    │   ├── SachService.cs
    │   ├── DocGiaService.cs
    │   ├── MuonTraService.cs
    │   └── ThongKeService.cs
    │
    └── Forms/
        ├── FrmMain.cs
        ├── FrmMain.Designer.cs
        │
        ├── FrmDanhMuc.cs
        ├── FrmDanhMuc.Designer.cs
        │
        ├── FrmSach.cs
        ├── FrmSach.Designer.cs
        │
        ├── FrmDocGia.cs
        ├── FrmDocGia.Designer.cs
        │
        ├── FrmMuonTra.cs
        ├── FrmMuonTra.Designer.cs
        │
        ├── FrmThongKe.cs
        └── FrmThongKe.Designer.cs
```

> Các thư mục `.vs`, `bin` và `obj` là dữ liệu được Visual Studio tự sinh, không phải mã nguồn chính của bài.

---

## 5. Cơ sở dữ liệu

File:

```text
QuanLyThuVien.sql
```

Script tạo Database:

```text
QuanLyThuVienDB
```

Các bảng chính:

1. `NhanVien`
2. `TheLoai`
3. `NhaXuatBan`
4. `DauSach`
5. `DocGia`
6. `TheDocGia`
7. `PhieuMuon`
8. `ChiTietPhieuMuon`
9. `PhieuPhat`

Một số ràng buộc nghiệp vụ chính:

- Số lượng sách hiện có không được âm.
- Một đầu sách thuộc một thể loại.
- Một đầu sách thuộc một nhà xuất bản.
- Một độc giả chỉ có một thẻ đang hoạt động tại một thời điểm.
- Thẻ hết hạn hoặc chưa đóng lệ phí thì không được sử dụng để mượn sách.
- Một độc giả được mượn tối đa 3 đầu sách.
- Không được mượn thêm khi còn sách quá hạn.
- Một phiếu mượn không được có hai dòng cùng một đầu sách.
- Chỉ được mượn sách khi số lượng hiện có lớn hơn 0.
- Ngày hẹn trả không được trước ngày mượn.
- Trả trễ, mất hoặc hư hỏng có thể phát sinh phiếu phạt.

---

## 6. Các chức năng đã thực hiện

### 6.1. Màn hình chính - `FrmMain`

Màn hình chính dùng để điều hướng đến các chức năng:

- Danh mục / Nhân viên
- Quản lý đầu sách
- Độc giả và thẻ
- Mượn - Trả sách
- Thống kê
- Thoát chương trình

Các Form chức năng được mở bằng `ShowDialog()`.

---

### 6.2. Danh mục và nhân viên - `FrmDanhMuc`

Quản lý:

#### Nhân viên

- Thêm nhân viên.
- Cập nhật thông tin.
- Xóa nhân viên.
- Làm mới dữ liệu.
- Hiển thị danh sách nhân viên.

Thông tin gồm:

- Mã nhân viên
- Họ
- Tên
- Phái
- Ngày sinh
- Chức vụ
- Số điện thoại

#### Thể loại

- Thêm thể loại.
- Cập nhật thể loại.
- Xóa thể loại.
- Hiển thị danh sách thể loại.

#### Nhà xuất bản

- Thêm nhà xuất bản.
- Cập nhật nhà xuất bản.
- Xóa nhà xuất bản.
- Hiển thị danh sách nhà xuất bản.

---

### 6.3. Quản lý đầu sách - `FrmSach`

Thực hiện:

- Thêm đầu sách.
- Cập nhật đầu sách.
- Xóa đầu sách.
- Tìm kiếm sách.
- Hiển thị danh sách đầu sách.
- Liên kết thể loại.
- Liên kết nhà xuất bản.

Thông tin đầu sách gồm:

- Mã đầu sách
- Tên sách
- Năm xuất bản
- Số lượng hiện có
- Thể loại
- Nhà xuất bản

---

### 6.4. Độc giả và thẻ thư viện - `FrmDocGia`

Quản lý hồ sơ độc giả gồm:

- Mã độc giả
- Họ
- Tên
- Ngày sinh
- Phái
- Số điện thoại
- Địa chỉ
- Email
- Ảnh 3x4

Các chức năng về thẻ:

- Cấp thẻ thư viện.
- Gia hạn thẻ.
- Ghi nhận ngày cấp.
- Ghi nhận hạn sử dụng.
- Kiểm tra trạng thái đóng lệ phí.

---

### 6.5. Mượn sách - `FrmMuonTra`

Khi lập phiếu mượn, chương trình kiểm tra:

- Độc giả có thẻ hợp lệ.
- Độc giả đã đóng lệ phí.
- Không có sách quá hạn chưa trả.
- Tổng số sách đang mượn và sách mới không vượt quá 3.
- Sách còn trong kho.
- Không chọn trùng một đầu sách.

Nếu hợp lệ:

- Tạo phiếu mượn.
- Tạo chi tiết phiếu mượn.
- Giảm số lượng sách hiện có.
- Thông báo lập phiếu thành công.

Các thao tác nhiều bảng được xử lý bằng Transaction để hạn chế tình trạng dữ liệu cập nhật dở dang.

---

### 6.6. Trả sách - `FrmMuonTra`

Khi trả sách:

- Chọn độc giả.
- Tải danh sách sách đang mượn.
- Chọn nhân viên nhận trả.
- Chọn ngày trả.
- Chọn tình trạng sách:
  - Bình thường
  - Rách/Hư hỏng
  - Mất
- Nhập phí phạt nếu có.
- Xác nhận trả sách.

Trường hợp sách bình thường:

- Ghi nhận ngày trả.
- Tăng lại số lượng sách hiện có.

Trường hợp trễ hạn, mất hoặc hư hỏng:

- Ghi nhận thông tin phạt.
- Lưu lý do và phí phạt tương ứng.

---

### 6.7. Thống kê - `FrmThongKe`

Thống kê theo khoảng thời gian:

- Lượt sách mượn.
- Số sách quá hạn.
- Số sách bị mất.
- Số sách hư hỏng.
- Tổng phí phạt.
- Danh sách chi tiết các trường hợp bị phạt.

---

## 7. Kiến trúc chương trình

### `Forms/`

Chứa giao diện WinForms và xử lý sự kiện người dùng.

Form không thực hiện truy vấn SQL trực tiếp.

### `Services/`

Chứa logic nghiệp vụ:

```text
DanhMucService
SachService
DocGiaService
MuonTraService
ThongKeService
```

Các Business Rule được kiểm tra tại Service trước khi thao tác với cơ sở dữ liệu.

### `Data/Db.cs`

Chịu trách nhiệm:

- Đọc chuỗi kết nối.
- Mở kết nối SQL Server.
- Thực thi câu lệnh SQL.
- Hỗ trợ truy vấn dữ liệu bằng ADO.NET.

---

## 8. Hướng dẫn cài đặt và chạy chương trình

### Bước 1 - Clone hoặc tải project

Nếu sử dụng Git:

```bash
git clone https://github.com/BaoHuz/LAB_AT_OOSD.git
```

Sau đó mở:

```text
LAB_AT_OOSD/LAB2
```

---

### Bước 2 - Tạo cơ sở dữ liệu

Mở SQL Server Management Studio hoặc SQL Server Object Explorer trong Visual Studio.

Mở file:

```text
QuanLyThuVien.sql
```

Chạy toàn bộ script.

Sau khi chạy thành công cần xuất hiện:

```text
QuanLyThuVienDB
```

và 9 bảng của hệ thống.

---

### Bước 3 - Cấu hình kết nối

Mở:

```text
QuanLyThuVien/App.config
```

Kiểm tra Connection String.

Ví dụ với SQL Server mặc định:

```xml
<connectionStrings>
  <add name="QuanLyThuVienDb"
       connectionString="Data Source=.;Initial Catalog=QuanLyThuVienDB;Integrated Security=True;"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Nếu sử dụng SQL Server Express có thể thay:

```text
Data Source=.\SQLEXPRESS
```

Nếu sử dụng LocalDB có thể sử dụng:

```text
Data Source=(localdb)\MSSQLLocalDB
```

---

### Bước 4 - Mở Solution

Mở file:

```text
QuanLyThuVien.sln
```

bằng Visual Studio 2022.

Kiểm tra project sử dụng:

```text
.NET Framework 4.7.2
```

---

### Bước 5 - Build project

Chọn:

```text
Build
→ Rebuild Solution
```

Đảm bảo không có lỗi compile.

---

### Bước 6 - Chạy chương trình

Nhấn:

```text
F5
```

hoặc:

```text
Start
```

Thứ tự kiểm tra đề xuất:

```text
FrmMain
→ Danh mục / Nhân viên
→ Quản lý đầu sách
→ Độc giả và thẻ
→ Mượn - Trả sách
→ Thống kê
```

---

## 9. Một số trường hợp kiểm thử

### Cấp thẻ

| Trường hợp | Kết quả mong đợi |
|---|---|
| Độc giả chưa có thẻ hoạt động | Cấp thẻ thành công |
| Độc giả đang có thẻ còn hạn | Không cho cấp thẻ thứ hai |

### Mượn sách

| Trường hợp | Kết quả mong đợi |
|---|---|
| Thẻ hết hạn | Từ chối mượn |
| Chưa đóng lệ phí | Từ chối mượn |
| Có sách quá hạn chưa trả | Từ chối mượn |
| Đang mượn 2 và chọn thêm 2 | Từ chối vì tổng vượt 3 |
| Chọn 1-3 đầu sách hợp lệ | Lập phiếu thành công |
| Sách hết số lượng | Từ chối mượn |
| Chọn trùng đầu sách | Không cho thêm |

### Trả sách

| Trường hợp | Kết quả mong đợi |
|---|---|
| Trả đúng hạn, sách bình thường | Cập nhật trả, tăng tồn kho |
| Trả trễ | Ghi nhận phí phạt |
| Sách mất | Tạo phiếu phạt |
| Sách rách/hư hỏng | Tạo phiếu phạt |

### Thống kê

Kiểm tra một khoảng thời gian có giao dịch và đối chiếu:

- Lượt mượn.
- Quá hạn.
- Mất.
- Hư hỏng.
- Phí phạt.

---

## 10. Kết quả thực hiện

Bài LAB đã thực hiện được:

- Xây dựng cơ sở dữ liệu SQL Server.
- Kết nối chương trình WinForms với SQL Server thông qua ADO.NET.
- Hoàn thiện các Form chức năng.
- Thực hiện CRUD cho các danh mục chính.
- Cấp và gia hạn thẻ độc giả.
- Kiểm tra điều kiện mượn sách.
- Lập phiếu mượn.
- Xử lý trả sách.
- Xử lý trường hợp mất/hư hỏng/trễ hạn.
- Thống kê dữ liệu theo thời gian.
- Chụp ảnh giao diện kết quả và đưa vào file báo cáo Word.

File báo cáo:

```text
1250080016_NguyenHuuBao_12_ĐH_CNPM1_LAB2.docx
```

---

## 11. Một số lỗi có thể gặp và cách khắc phục

### Không kết nối được SQL Server

**Nguyên nhân:**

- Sai `Data Source`.
- SQL Server chưa chạy.
- Database chưa được tạo.

**Khắc phục:**

- Kiểm tra lại `App.config`.
- Kiểm tra SQL Server instance.
- Chạy lại `QuanLyThuVien.sql`.

---

### Không xóa được thể loại hoặc nhà xuất bản

**Nguyên nhân:**

Dữ liệu đang được bảng `DauSach` tham chiếu bằng Foreign Key.

**Khắc phục:**

Không xóa danh mục đang được sử dụng hoặc xử lý dữ liệu liên quan trước.

---

### Không thể mượn sách

Kiểm tra:

- Hạn thẻ.
- Trạng thái lệ phí.
- Sách quá hạn.
- Số sách đang mượn.
- Số lượng sách trong kho.
- Đầu sách bị chọn trùng.

---

### Trả sách nhưng không tạo phiếu phạt

Kiểm tra:

- Tình trạng sách.
- Ngày trả.
- Giá trị phí phạt.
- Dữ liệu sách đang mượn.

---

