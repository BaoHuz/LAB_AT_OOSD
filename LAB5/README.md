# LAB 5 - QUẢN LÝ CÔNG TY DU LỊCH VĂN HÓA VIỆT

## 1. Thông tin sinh viên

- **Họ và tên:** Nguyễn Hữu Bảo
- **MSSV:** 1250080016
- **Lớp:** 12_ĐH_CNPM1
- **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng
- **Bài thực hành:** LAB 5 - Bài 6: Quản lý công ty du lịch Văn Hóa Việt

---

## 2. Mục tiêu bài LAB

Phân tích, thiết kế và hiện thực hệ thống **Quản lý công ty du lịch Văn Hóa Việt**.

Các nội dung chính:

- Phân tích nghiệp vụ tour và hành trình.
- Quản lý chuyến dành cho khách lẻ.
- Quản lý đăng ký khách lẻ.
- Quản lý đăng ký khách theo đoàn.
- Quản lý danh sách thành viên đoàn.
- Phân công hướng dẫn viên.
- Kiểm tra trùng lịch hướng dẫn viên.
- Thanh toán kinh phí đoàn sau tour.
- Gửi phiếu khảo sát và ghi nhận góp ý.
- Tính lương hướng dẫn viên.
- Thống kê doanh thu và hoạt động.
- Thiết kế CSDL SQL Server.
- Xây dựng ứng dụng C# Windows Forms theo kiến trúc:

```text
UI (Forms)
    ↓
Services
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
- **Công cụ CSDL:** SQL Server Management Studio / SQL Server Object Explorer
- **Công cụ UML:** Draw.io / PlantUML
- **Quản lý mã nguồn:** Git & GitHub

---

## 4. Cấu trúc thư mục

```text
LAB5/
│
├── 1250080016_NguyenHuuBao_12_ĐH_CNPM1_Lab5.docx
├── QuanLyCongTyDuLich.sql
├── LAB5.drawio
├── README.md
│
└── QuanLyCongTyDuLich/
    │
    ├── QuanLyCongTyDuLich.sln
    │
    ├── .vs/
    │
    └── QuanLyCongTyDuLich/
        │
        ├── App.config
        ├── Program.cs
        │
        ├── Data/
        │   └── Db.cs
        │
        ├── Services/
        │   ├── ChuyenLeService.cs
        │   ├── DangKyDoanService.cs
        │   ├── DangKyLeService.cs
        │   ├── DanhMucService.cs
        │   ├── KetThucService.cs
        │   ├── Models.cs
        │   ├── PhanCongService.cs
        │   ├── ThongKeService.cs
        │   └── TourService.cs
        │
        └── Forms/
            ├── FormHelper.cs
            ├── FrmMain.cs
            ├── FrmDanhMuc.cs
            ├── FrmTour.cs
            ├── FrmChuyenLe.cs
            ├── FrmDangKyLe.cs
            ├── FrmDangKyDoan.cs
            ├── FrmPhanCongHDV.cs
            ├── FrmKetThucKhaoSat.cs
            └── FrmLuongThongKe.cs
```

> Các thư mục `.vs`, `bin` và `obj` do Visual Studio tự sinh, không phải thành phần mã nguồn chính của bài.

---

# 5. Nội dung phân tích và thiết kế

Báo cáo trả lời 6 yêu cầu chính của đề bài.

## Câu 1 - Xác định Class, thuộc tính, phương thức và ID

Các lớp nghiệp vụ chính gồm:

- `Tour`
- `DiemDung`
- `PhuongTien`
- `ChangPhuongTien`
- `DiemThamQuan`
- `TourDiemThamQuan`
- `ChuyenLe`
- `DiemBanVe`
- `PhieuDangKy`
- `PhieuDangKyLe`
- `PhieuDangKyDoan`
- `DoanKhach`
- `ThanhVienDoan`
- `HuongDanVien`
- `PhanCong`
- `ThanhToanDoan`
- `PhieuKhaoSat`

---

## Câu 2 - Mối liên kết giữa các Class

Một số quan hệ chính:

```text
PhieuDangKy
   ├── PhieuDangKyLe
   └── PhieuDangKyDoan
```

- `Tour` hợp thành từ nhiều điểm dừng.
- `Tour` sử dụng nhiều phương tiện theo từng chặng.
- `Tour` liên kết nhiều-nhiều với `DiemThamQuan`.
- `ChuyenLe` thuộc một `Tour`.
- `PhieuDangKyLe` đăng ký một chuyến khách lẻ.
- `PhieuDangKyDoan` sở hữu nhiều `ThanhVienDoan`.
- Một đoàn có thể có nhiều hướng dẫn viên.
- Một hướng dẫn viên không được bị phân công chồng chéo lịch.

---

## Câu 3 - Actor và Use Case tổng quát

Các Actor:

- Khách hàng
- NV bán vé
- NV kinh doanh
- NV điều hành
- Kế toán
- NV chăm sóc khách hàng

Các nghiệp vụ chính:

- Xem thông tin tour.
- Quản lý danh mục.
- Quản lý tour - hành trình.
- Lập lịch chuyến khách lẻ.
- Đăng ký khách lẻ.
- Lập phiếu đăng ký đoàn.
- Hủy đăng ký đoàn và mất cọc.
- Phân công hướng dẫn viên.
- Thanh toán kinh phí đoàn sau tour.
- Gửi khảo sát.
- Ghi nhận góp ý.
- Tính lương hướng dẫn viên.
- Thống kê.

---

## Câu 4 - Phân rã Use Case

Luồng nghiệp vụ được phân rã từ lúc đăng ký tour đến khi kết thúc tour.

### Khách lẻ

```text
Đăng ký khách lẻ
      ↓
Chọn chuyến đang mở
      ↓
Thanh toán tiền vé
```

### Khách đoàn

```text
Lập phiếu đăng ký đoàn
      ↓
Đặt cọc
      ↓
Nếu mua bảo hiểm
→ Nhập danh sách người cùng đi
```

Nếu đoàn không đi:

```text
Hủy đăng ký
→ Mất cọc
```

### Phân công hướng dẫn viên

```text
Phân công HDV
      ↓
Kiểm tra trùng lịch
```

### Sau tour

```text
Kết thúc tour
      ↓
Thanh toán kinh phí đoàn
      ↓
Gửi khảo sát
      ↓
Nếu khách phản hồi
→ Ghi nhận góp ý
```

---

## Câu 5 - Activity Diagram

Activity Diagram mô tả toàn bộ quy trình:

```text
Tiếp nhận yêu cầu đăng ký
             ↓
      Kiểm tra số người
        ↙           ↘
  Khách lẻ          Khách đoàn
    < 12              > 12
      ↓                 ↓
Chọn chuyến       Nhập thông tin đoàn
      ↓                 ↓
Thu tiền vé          Thu tiền cọc
      ↓                 ↓
Lưu đăng ký       Lưu trong Transaction
        ↘             ↙
          Phân công HDV
                ↓
        Kiểm tra trùng lịch
                ↓
           Thực hiện tour
                ↓
            Kết thúc tour
                ↓
       Thanh toán / Khảo sát
```

---

## Câu 6 - Sequence Diagram lập phiếu đăng ký đoàn

Trình tự chính:

```text
NV kinh doanh
      ↓
FrmDangKyDoan
      ↓
DangKyDoanService
      ↓
Kiểm tra dữ liệu
      ↓
Begin Transaction
      ↓
DoanKhach
      ↓
DangKyDoan
      ↓
ThanhVienDoan
      ↓
Commit
      ↓
Thông báo kết quả
```

---

# 6. File UML Draw.io

File:

```text
LAB5.drawio
```

Các page bổ sung hiện có:

```text
UseCase_QuanLyDanhMuc
UseCase_BaoCaoThongKe
Activity_PhanCongHDV
Activity_HuyDangKyDoan
Sequence_HuyPhieuDangKyDoan
Sequence_TaoLichChuyenKhachLe
```

Các sơ đồ trong báo cáo gồm:

- Class Diagram.
- Use Case tổng quát.
- Use Case phân rã.
- Activity Diagram.
- Sequence Diagram.
- Các sơ đồ bổ sung cho các nghiệp vụ trọng tâm.

---

# 7. Cơ sở dữ liệu

File:

```text
QuanLyCongTyDuLich.sql
```

Database:

```text
QuanLyCongTyDuLich
```

Hệ thống sử dụng **16 bảng**:

1. `Tour`
2. `PhuongTien`
3. `DiemThamQuan`
4. `DiemBanVe`
5. `HuongDanVien`
6. `TourDiemDung`
7. `TourPhuongTien`
8. `TourDiemThamQuan`
9. `ChuyenLe`
10. `DangKyLe`
11. `DoanKhach`
12. `DangKyDoan`
13. `ThanhVienDoan`
14. `PhanCongHDV`
15. `PhieuThanhToanDoan`
16. `KhaoSatYKien`

---

# 8. Các quy tắc nghiệp vụ chính

## BR01 - Tour và hành trình

- Mọi tour xuất phát từ TP.HCM.
- Hành trình kết thúc tại TP.HCM.
- Các điểm dừng được đánh thứ tự.

## BR02 - Khách sạn

Nếu điểm dừng có khách sạn:

```text
Hạng sao ∈ {2, 3, 4, 5}
```

Nếu không có khách sạn:

```text
HangSaoKhachSan = NULL
```

---

## BR03 - Khách lẻ

```text
1 ≤ Số người ≤ 11
```

- Đăng ký theo chuyến.
- Chuyến phải đang mở đăng ký.
- Thanh toán tiền vé ngay.

Thành tiền:

```text
Thành tiền = Đơn giá tour × Số người
```

---

## BR04 - Khách đoàn

```text
Số người > 12
```

- Được chọn ngày đi.
- Phải đặt cọc trước.
- Nếu không đi thì mất cọc.
- Thanh toán phần còn lại sau tour.

---

## QD01 - Trường hợp đúng 12 người

Đề bài không quy định rõ trường hợp đúng 12 người.

Hệ thống hiện từ chối:

```text
Số người = 12
```

ở cả đăng ký khách lẻ và khách đoàn.

---

## QD02 - Ngày kết thúc

```text
Ngày kết thúc
=
Ngày đi + Số ngày - 1
```

---

## BR05 - Bảo hiểm

Nếu đoàn mua bảo hiểm:

```text
Số thành viên trong danh sách
=
Số người của đoàn
```

---

## BR06 - Phân công hướng dẫn viên

- Mỗi chuyến khách lẻ có một hướng dẫn viên.
- Đoàn có thể có nhiều hướng dẫn viên.
- Một hướng dẫn viên không được bị phân công trùng khoảng thời gian.

---

## BR07 - Lương hướng dẫn viên

```text
Lương tháng
=
Lương cơ bản
+
Tổng thù lao các tour hoàn thành trong tháng
```

---

## BR08 - Khảo sát

- Chỉ gửi khảo sát sau khi tour kết thúc.
- Mỗi đăng ký tối đa một khảo sát.
- Điểm đánh giá:

```text
1 ≤ Điểm ≤ 5
```

---

# 9. Kiến trúc mã nguồn

## Data Layer

### `Db.cs`

Chịu trách nhiệm:

- Quản lý `SqlConnection`.
- Thực hiện Query.
- Thực hiện Execute.
- Thực hiện Scalar.
- Sử dụng `SqlParameter`.
- Cung cấp kết nối cho các Service.

Form không thực hiện SQL trực tiếp.

---

## Service Layer

### `DanhMucService`

Quản lý:

- Phương tiện.
- Điểm bán vé.
- Hướng dẫn viên.
- Điểm tham quan.

### `TourService`

Quản lý:

- Tour.
- Điểm dừng.
- Phương tiện theo chặng.
- Điểm tham quan theo tour.

### `ChuyenLeService`

Quản lý:

- Chuyến khách lẻ.
- Ngày đi.
- Ngày về.
- Trạng thái mở/đóng đăng ký.

### `DangKyLeService`

Quản lý đăng ký khách lẻ.

### `DangKyDoanService`

Quản lý:

- Đoàn khách.
- Phiếu đăng ký đoàn.
- Tiền cọc.
- Thành viên đoàn.
- Bảo hiểm.
- Hủy đăng ký mất cọc.

### `PhanCongService`

Quản lý phân công hướng dẫn viên và kiểm tra trùng lịch.

### `KetThucService`

Quản lý:

- Thanh toán kinh phí đoàn sau tour.
- Gửi khảo sát.
- Ghi nhận phản hồi của khách.

### `ThongKeService`

Quản lý:

- Tính lương hướng dẫn viên.
- Thống kê đăng ký.
- Thống kê doanh thu.
- Thống kê khảo sát.

---

# 10. Các Form đã thực hiện

Ứng dụng gồm 9 Form chính.

## `FrmMain`

Điều hướng đến toàn bộ chức năng.

## `FrmDanhMuc`

Quản lý:

- Phương tiện.
- Điểm bán vé.
- Hướng dẫn viên.
- Điểm tham quan.

## `FrmTour`

Quản lý:

- Tour.
- Điểm dừng.
- Phương tiện theo chặng.
- Điểm tham quan.

## `FrmChuyenLe`

Quản lý lịch chuyến dành cho khách lẻ.

## `FrmDangKyLe`

Đăng ký và thanh toán vé cho khách lẻ.

## `FrmDangKyDoan`

Quản lý:

- Đoàn khách.
- Đăng ký đoàn.
- Tiền cọc.
- Danh sách thành viên nếu mua bảo hiểm.
- Hủy đăng ký và mất cọc.

## `FrmPhanCongHDV`

Phân công hướng dẫn viên và kiểm tra trùng lịch.

## `FrmKetThucKhaoSat`

Quản lý:

- Thanh toán đoàn sau tour.
- Gửi khảo sát.
- Ghi nhận điểm đánh giá và góp ý.

## `FrmLuongThongKe`

Thực hiện:

- Tính lương hướng dẫn viên.
- Thống kê theo khoảng thời gian.

---

# 11. SQL Transaction

Các nghiệp vụ nhiều bảng quan trọng được xử lý bằng Transaction.

Ví dụ đăng ký đoàn:

```text
Begin Transaction
       ↓
Lưu / cập nhật DoanKhach
       ↓
INSERT DangKyDoan
       ↓
Nếu mua bảo hiểm
→ INSERT nhiều ThanhVienDoan
       ↓
Commit
```

Nếu xảy ra lỗi:

```text
Rollback
```

Việc này giúp tránh dữ liệu bị lưu dở dang.

---

# 12. Kiểm thử

Báo cáo xây dựng **24 Test Case**, bao phủ các nhóm:

```text
Tour - hành trình
Chuyến khách lẻ
Đăng ký khách lẻ
Đăng ký đoàn
Bảo hiểm
Hủy đoàn
Phân công HDV
Thanh toán sau tour
Khảo sát
Góp ý
Tính lương
Thống kê
```

Một số trường hợp quan trọng:

### Khách lẻ

- Số người từ 1 đến 11.
- Chuyến phải đang mở.
- Thành tiền đúng theo đơn giá × số người.

### Khách đoàn

- Số người phải lớn hơn 12.
- Tiền cọc phải lớn hơn 0.
- Tiền cọc không được vượt tổng tiền dự kiến.
- Nếu mua bảo hiểm phải có đủ danh sách thành viên.

### Phân công HDV

- Kiểm tra hướng dẫn viên đang làm việc.
- Không được phân công chồng chéo lịch.

### Thanh toán đoàn

- Chỉ thanh toán sau khi kết thúc tour.
- Số tiền không được vượt phần còn phải trả.

### Khảo sát

- Chỉ gửi sau tour.
- Mỗi đăng ký tối đa một phiếu khảo sát.
- Điểm đánh giá từ 1 đến 5.

---

# 13. Ma trận truy vết

Các artifact chính được liên kết như sau:

| Nghiệp vụ | Form | Service | Bảng CSDL |
|---|---|---|---|
| Tour - hành trình | `FrmTour` | `TourService` | `Tour`, `TourDiemDung`, `TourPhuongTien`, `TourDiemThamQuan` |
| Chuyến khách lẻ | `FrmChuyenLe` | `ChuyenLeService` | `ChuyenLe` |
| Đăng ký khách lẻ | `FrmDangKyLe` | `DangKyLeService` | `DangKyLe`, `DiemBanVe`, `ChuyenLe` |
| Đăng ký đoàn | `FrmDangKyDoan` | `DangKyDoanService` | `DoanKhach`, `DangKyDoan`, `ThanhVienDoan` |
| Phân công HDV | `FrmPhanCongHDV` | `PhanCongService` | `PhanCongHDV`, `HuongDanVien` |
| Thanh toán sau tour | `FrmKetThucKhaoSat` | `KetThucService` | `PhieuThanhToanDoan`, `DangKyDoan` |
| Khảo sát & phản hồi | `FrmKetThucKhaoSat` | `KetThucService` | `KhaoSatYKien` |
| Lương & thống kê | `FrmLuongThongKe` | `ThongKeService` | `HuongDanVien`, `PhanCongHDV`, `DangKyLe`, `PhieuThanhToanDoan` |

---

# 14. Kết quả thực hiện

Bài LAB đã thực hiện:

- Phân tích nghiệp vụ công ty du lịch.
- Xác định Class, thuộc tính, phương thức và ID.
- Xây dựng Class Diagram.
- Xác định Actor.
- Xây dựng Use Case tổng quát.
- Phân rã Use Case.
- Xây dựng Activity Diagram.
- Xây dựng Sequence Diagram.
- Thiết kế CSDL SQL Server với 16 bảng.
- Xây dựng dữ liệu mẫu.
- Xây dựng ứng dụng WinForms.
- Tổ chức mã nguồn theo UI → Service → Data.
- Quản lý tour và hành trình.
- Quản lý khách lẻ và khách đoàn.
- Phân công hướng dẫn viên.
- Thanh toán đoàn.
- Khảo sát khách hàng.
- Tính lương.
- Thống kê.
- Xây dựng bộ 24 Test Case.
- Xây dựng ma trận truy vết yêu cầu → UML → Form → Service → CSDL → Test Case.

---

# 15. Một số lỗi gặp phải và cách khắc phục

## Lỗi `CS0246`

Ví dụ:

```text
The type or namespace name 'DangKyDoanService' could not be found
```

**Nguyên nhân:**

Thiếu class Service hoặc namespace chưa đúng.

**Khắc phục:**

- Kiểm tra file có nằm trong thư mục `Services`.
- Kiểm tra namespace:

```csharp
namespace QuanLyCongTyDuLich.Services
```

---

## Không kết nối được Database

Ví dụ:

```text
Cannot open database "QuanLyCongTyDuLich"
```

**Nguyên nhân:**

- Chưa chạy SQL.
- Sai SQL Server Instance.
- Connection String sai.

**Khắc phục:**

- Chạy lại `QuanLyCongTyDuLich.sql`.
- Kiểm tra `Data Source`.
- Kiểm tra tên Database.

---

## Sai cột `PhanCongHDV`

Ví dụ:

```text
Invalid column name 'MaPhanCong'
Invalid column name 'LoaiPhanCong'
```

**Khắc phục:**

Kiểm tra bảng `PhanCongHDV` có các cột:

```text
MaPhanCong
MaHDV
LoaiPhanCong
MaChuyen
SoDKDoan
ThuLaoTour
NgayPhanCong
```

---

## Thiếu bảng thanh toán hoặc khảo sát

Ví dụ:

```text
Invalid object name 'PhieuThanhToanDoan'
Invalid object name 'KhaoSatYKien'
```

**Khắc phục:**

Chạy lại toàn bộ file:

```text
QuanLyCongTyDuLich.sql
```

để tạo đầy đủ 16 bảng.

---

# 16. Hướng dẫn chạy lại dự án

## Bước 1 - Tạo Database

Mở:

```text
LAB5/QuanLyCongTyDuLich.sql
```

bằng SQL Server Management Studio.

Chạy toàn bộ script.

Kiểm tra Database:

```text
QuanLyCongTyDuLich
```

---

## Bước 2 - Cấu hình Connection String

Mở:

```text
LAB5/QuanLyCongTyDuLich/QuanLyCongTyDuLich/App.config
```

Ví dụ dùng SQL Server Express:

```xml
<connectionStrings>
  <add name="QuanLyCongTyDuLichDB"
       connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyCongTyDuLich;Integrated Security=True;TrustServerCertificate=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Nếu dùng SQL Server mặc định:

```text
Data Source=.
```

Nếu dùng LocalDB:

```text
Data Source=(localdb)\MSSQLLocalDB
```

---

## Bước 3 - Mở Solution

Mở:

```text
LAB5/QuanLyCongTyDuLich/QuanLyCongTyDuLich.sln
```

bằng Visual Studio 2022.

---

## Bước 4 - Build

Chọn:

```text
Build
→ Rebuild Solution
```

hoặc:

```text
Ctrl + Shift + B
```

Kiểm tra project không có lỗi compile.

---

## Bước 5 - Chạy chương trình

Nhấn:

```text
F5
```

---
