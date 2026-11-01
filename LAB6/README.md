# LAB 6 - QUẢN LÝ HỒ SƠ BỆNH ÁN CỦA BỆNH NHÂN

## 1. Thông tin sinh viên

- **Họ và tên:** Nguyễn Hữu Bảo
- **MSSV:** 1250080016
- **Lớp:** 12_ĐH_CNPM1
- **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng
- **Bài thực hành:** LAB 6 - Bài 5: Quản lý hồ sơ bệnh án của bệnh nhân
- **Repository:** `LAB_AT_OOSD`

---

## 2. Mục tiêu bài LAB

Phân tích, thiết kế cơ sở dữ liệu và xây dựng Prototype **Hệ thống quản lý hồ sơ bệnh án của bệnh nhân**.

Các nghiệp vụ chính:

- Đăng ký bệnh nhân lần đầu.
- Thu lệ phí và cấp hồ sơ bệnh án.
- Tra cứu lịch sử bệnh án.
- Gia hạn lệ phí.
- Đặt lịch khám sức khỏe định kỳ theo quý.
- Khám bệnh và ghi nhận chẩn đoán.
- Chỉ định xét nghiệm.
- Cập nhật kết quả xét nghiệm.
- Lập toa thuốc.
- Thanh toán viện phí.
- Phát thuốc sau thanh toán.
- Hoàn tất và chốt hồ sơ khám.

Hệ thống được xây dựng bằng:

```text
C# WinForms
    ↓
Service / Data
    ↓
ADO.NET
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
- **Công cụ UML:** Draw.io / PlantUML
- **Quản lý mã nguồn:** Git & GitHub

---

## 4. Cấu trúc thư mục

```text
LAB6/
│
├── 1250080016_NguyenHuuBao_12_ĐH_CNPM1_Lab6.docx
├── Bai_5_Quan_ly_ho_so_benh_an.docx
├── Lab6.drawio
├── QuanLyHoSoBenhAn.sql
├── README.md
├── .vs/
│
└── QuanLyHoSoBenhAn/
    │
    ├── QuanLyHoSoBenhAn.sln
    │
    ├── .vs/
    │
    └── QuanLyHoSoBenhAn/
        │
        ├── App.config
        ├── Program.cs
        │
        ├── Data/
        │   └── Db.cs
        │
        ├── Models/
        │   └── Models.cs
        │
        ├── Services/
        │   ├── DangKyService.cs
        │   ├── KhamService.cs
        │   └── ToaThuocService.cs
        │
        └── Forms/
            ├── FrmMain.cs
            ├── FrmDangKy.cs
            ├── FrmHoSo.cs
            ├── FrmLichHen.cs
            ├── FrmKhamBenh.cs
            ├── FrmXetNghiem.cs
            ├── FrmLapToa.cs
            ├── FrmThanhToan.cs
            ├── FrmPhatThuoc.cs
            └── FrmHoanTat.cs
```

> Các thư mục `.vs`, `bin` và `obj` được Visual Studio tự sinh, không phải thành phần mã nguồn chính.

---

# 5. Hoạt động nghiệp vụ

## 5.1. Đăng ký lần đầu

Bệnh nhân cung cấp:

- Họ tên.
- Địa chỉ.
- Ngày sinh.
- Điện thoại.
- Ảnh 3×4.

Sau khi xác nhận đã thu lệ phí:

```text
BenhNhan
    ↓
HoSoBenhAn
    ↓
PhieuThuLePhi
```

được lưu trong cùng nghiệp vụ.

Chỉ khi toàn bộ dữ liệu được lưu thành công mới cấp mã hồ sơ.

---

## 5.2. Khám bệnh

Khi bệnh nhân đến khám:

```text
Tra cứu hồ sơ
      ↓
Xem lịch sử bệnh án
      ↓
Tạo Phiếu khám
      ↓
Ghi triệu chứng
      ↓
Chẩn đoán
```

Một phiếu khám gắn với:

- Một hồ sơ bệnh án.
- Một bác sĩ.
- Một khoa điều trị.
- Thời điểm khám.
- Loại khám.

Loại khám gồm:

```text
Thuong
DinhKy
```

---

## 5.3. Xét nghiệm

Một phiếu khám có thể có nhiều chỉ định xét nghiệm.

Mỗi chỉ định được xác định bằng khóa ghép:

```text
MaPhieuKham
+
MaXetNghiem
```

Trạng thái:

```text
ChoKetQua
    ↓
DaCoKetQua
```

Khi cập nhật kết quả phải ghi:

- Kết quả.
- Ngày thực hiện.
- Trạng thái `DaCoKetQua`.

---

## 5.4. Toa thuốc

Một phiếu khám:

```text
0..1 ToaThuoc
```

Một toa thuốc:

```text
1..* ChiTietToaThuoc
```

Thông tin từng dòng gồm:

- Mã thuốc.
- Số lượng.
- Liều dùng.
- Cách dùng.
- Đơn giá áp dụng.
- Thành tiền.

Toa thuốc được lưu cùng toàn bộ chi tiết bằng Transaction.

---

## 5.5. Khám định kỳ

Bệnh nhân có thể đặt lịch khám sức khỏe theo quý.

Các quý:

```text
Quý I   : Tháng 1 - 3
Quý II  : Tháng 4 - 6
Quý III : Tháng 7 - 9
Quý IV  : Tháng 10 - 12
```

Mỗi hồ sơ chỉ được có tối đa một lịch hiệu lực trong cùng:

```text
MaHoSo + Nam + Quy
```

Khám định kỳ được miễn **tiền khám**, không mặc định miễn:

- Xét nghiệm.
- Thuốc.

Quy tắc này được xác định rõ trong báo cáo.

---

# 6. Actor của hệ thống

Các Actor chính:

- Bệnh nhân.
- NV lễ tân / CSKH.
- Bác sĩ.
- NV xét nghiệm.
- Dược sĩ.
- Thu ngân / kế toán.
- Quản trị.

Vai trò được phân chia theo nghiệp vụ, từ tiếp nhận bệnh nhân đến khám, xét nghiệm, thanh toán và phát thuốc.

---

# 7. Danh sách Use Case

Hệ thống gồm các Use Case:

```text
UC01 - Đăng ký và cấp hồ sơ
UC02 - Tra cứu lịch sử bệnh án
UC03 - Thu và gia hạn lệ phí
UC04 - Đặt / đổi / hủy lịch khám quý
UC05 - Khám và ghi nhận bệnh án
UC06 - Chỉ định và trả kết quả xét nghiệm
UC07 - Lập và in toa thuốc
UC08 - Lập hóa đơn và thu viện phí
UC09 - Kiểm tra toa và phát thuốc
UC10 - Hoàn tất và chốt hồ sơ
UC11 - Quản lý danh mục
```

---

# 8. Quy tắc nghiệp vụ chính

## BR01 - Đăng ký và thu phí

Đăng ký bệnh nhân, cấp hồ sơ và ghi nhận lệ phí là một nghiệp vụ liên kết.

```text
Nếu thu phí thất bại
→ Không cấp hồ sơ thành công
```

---

## BR02 - Hồ sơ bệnh án

- Mã hồ sơ duy nhất.
- Một bệnh nhân có một hồ sơ.
- Tra cứu phải đúng bệnh nhân và đúng lần khám.

---

## BR03 - Khám định kỳ

Bệnh nhân được khám sức khỏe định kỳ theo quý.

Nếu đủ điều kiện:

```text
Tiền khám = 0
```

Thuốc và xét nghiệm vẫn được tính riêng.

---

## BR04 - Toa thuốc và xét nghiệm

Toa thuốc và chỉ định xét nghiệm phải thuộc đúng phiếu khám.

---

## BR05 - Hoàn tất hồ sơ

Chỉ được hoàn tất khi:

- Có chẩn đoán/kết luận.
- Không còn xét nghiệm chờ kết quả.
- Hóa đơn đã thanh toán hoặc xác nhận miễn phí.
- Nếu có toa thuốc thì toa đã được phát.

---

## BR06 - Lịch sử khám

Hệ thống lưu:

- Bác sĩ.
- Khoa điều trị.
- Thời điểm khám.
- Triệu chứng.
- Chẩn đoán.
- Diễn biến.
- Phản ứng phụ.

---

# 9. Các quyết định triển khai

## QD01 - Hiệu lực lệ phí

Một lần thu lệ phí được giả định có hiệu lực:

```text
365 ngày
```

Khoảng hiệu lực:

```text
[TuNgay, DenNgay)
```

---

## QD02 - Lịch khám theo quý

Một hồ sơ chỉ có một lịch khám định kỳ hiệu lực cho mỗi quý trong một năm.

---

## QD03 - Toa và xét nghiệm

- Một phiếu có tối đa một toa.
- Toa phải có ít nhất một dòng.
- Một thuốc chỉ xuất hiện một lần trong cùng toa.
- Một loại xét nghiệm chỉ xuất hiện tối đa một lần trong cùng phiếu theo thiết kế hiện tại.

---

## QD04 - Thanh toán

Mỗi phiếu khám:

```text
0..1 HoaDonVienPhi
```

Bài LAB áp dụng:

```text
Thanh toán một lần toàn bộ
```

Không xử lý:

- Thanh toán nhiều đợt.
- Công nợ.
- Hoàn tiền.
- Bảo hiểm.

---

## QD05 - Lập toa và phát thuốc

```text
Lập toa
→ có thể thực hiện trước thanh toán

Phát thuốc
→ chỉ sau khi đã thanh toán
```

---

## QD06 - Khám định kỳ

Chỉ miễn tiền khám.

Không tự động miễn:

```text
Thuốc
Xét nghiệm
```

---

## QD07 - Nhận diện bệnh nhân

- Một `MaBN` có một hồ sơ.
- Số điện thoại không dùng làm khóa duy nhất.
- CCCD không phải thuộc tính bắt buộc của đề.

---

# 10. UML và Draw.io

File:

```text
Lab6.drawio
```

Hiện gồm 14 page:

```text
1. Biểu đồ lớp phân tích tổng quát
2. Biểu đồ lớp phân tích tổng quát chi tiết
3. Use Case tổng quát
4. Use Case phân rã quy trình khám bệnh
5. Use Case phân rã lập toa thuốc
6. Activity quy trình khám bệnh và hoàn tất
7. Activity lập toa thuốc
8. Sequence lập toa thuốc
9. Trạng thái phiếu khám bệnh
10. Trạng thái lịch hẹn và hóa đơn
11. Sequence đăng ký mới và thu lệ phí
12. Sequence đặt lịch khám định kỳ
13. Thiết kế lớp chức năng lập toa thuốc
14. ERD cơ sở dữ liệu bệnh án
```

Các sơ đồ bao phủ cả pha phân tích và pha thiết kế.

---

# 11. Thiết kế cơ sở dữ liệu

File:

```text
QuanLyHoSoBenhAn.sql
```

Database:

```text
QuanLyHoSoBenhAn
```

Hệ thống sử dụng **13 bảng**:

1. `BenhNhan`
2. `HoSoBenhAn`
3. `PhieuThuLePhi`
4. `BacSi`
5. `KhoaDieuTri`
6. `LichHenDinhKy`
7. `PhieuKhamBenh`
8. `XetNghiem`
9. `ChiDinhXetNghiem`
10. `Thuoc`
11. `ToaThuoc`
12. `ChiTietToaThuoc`
13. `HoaDonVienPhi`

Báo cáo xác định `HoaDonVienPhi` liên kết 0..1 với `PhieuKhamBenh`, còn `ToaThuoc` liên kết 0..1 với một phiếu khám.

---

# 12. Một số ràng buộc CSDL quan trọng

## Hồ sơ bệnh án

```text
HoSoBenhAn.MaBN
→ UNIQUE
```

Bảo đảm một bệnh nhân có tối đa một hồ sơ.

---

## Lịch khám

```text
UNIQUE (MaHoSo, Nam, Quy)
WHERE TrangThai <> 'Huy'
```

Tránh sử dụng nhiều quyền lợi khám định kỳ trong cùng quý.

---

## Phiếu khám

Trạng thái:

```text
DangXuLy
ChoThanhToan
HoanTat
```

Chỉ được hoàn tất khi có:

```text
NgayHoanTat
NguoiHoanTat
```

---

## Chỉ định xét nghiệm

Khóa chính:

```text
(MaPhieuKham, MaXetNghiem)
```

Nếu trạng thái:

```text
DaCoKetQua
```

thì bắt buộc:

```text
KetQua != NULL
NgayThucHien != NULL
```

---

## Toa thuốc

```text
MaPhieuKham UNIQUE
```

Bảo đảm tối đa một toa cho một phiếu khám.

---

## Chi tiết toa thuốc

Khóa chính:

```text
(MaToa, MaThuoc)
```

Không cho cùng một thuốc xuất hiện hai lần trong một toa.

---

## Hóa đơn

```text
MaPhieuKham UNIQUE
```

Bảo đảm một phiếu có tối đa một hóa đơn.

---

# 13. Stored Procedure

File SQL có các Stored Procedure phục vụ nghiệp vụ trọng tâm:

```text
sp_DangKyMoi
sp_LapToaThuoc
sp_DatLichHen
sp_HoanTatPhieu
```

### `sp_DangKyMoi`

Xử lý:

```text
BenhNhan
+
HoSoBenhAn
+
PhieuThuLePhi
```

trong cùng Transaction.

### `sp_LapToaThuoc`

Lưu:

```text
ToaThuoc
+
ChiTietToaThuoc
```

trong cùng Transaction.

### `sp_DatLichHen`

Kiểm tra:

- Hồ sơ.
- Hiệu lực lệ phí.
- Quý/năm.
- Trùng lịch.

### `sp_HoanTatPhieu`

Kiểm tra:

- Chẩn đoán.
- Xét nghiệm.
- Thanh toán.
- Phát thuốc nếu có.

sau đó mới chuyển phiếu sang:

```text
HoanTat
```

---

# 14. Data Layer

## `Data/Db.cs`

Chịu trách nhiệm tạo kết nối SQL Server từ Connection String trong:

```text
App.config
```

Các Form/Service sử dụng:

```csharp
Db.CreateConnection()
```

để lấy kết nối.

---

# 15. Service Layer

## `DangKyService`

Thực hiện nghiệp vụ:

- Đăng ký bệnh nhân.
- Thu lệ phí.
- Cấp hồ sơ bệnh án.

Sử dụng Stored Procedure để bảo đảm Transaction.

---

## `KhamService`

Thực hiện các xử lý liên quan đến quá trình khám và hồ sơ khám.

---

## `ToaThuocService`

Lập toa thuốc thông qua:

```text
sp_LapToaThuoc
```

Dữ liệu chi tiết toa được truyền bằng bảng dữ liệu để lưu toàn bộ toa trong cùng nghiệp vụ.

---

# 16. Các Form đã thực hiện

## `FrmMain`

Màn hình chính điều hướng đến các chức năng.

---

## `FrmDangKy`

Đăng ký bệnh nhân lần đầu:

- Nhập thông tin bệnh nhân.
- Ghi nhận lệ phí.
- Cấp hồ sơ bệnh án.

---

## `FrmHoSo`

Tra cứu thông tin hồ sơ bệnh án và lịch sử liên quan.

---

## `FrmLichHen`

Đặt lịch khám sức khỏe định kỳ.

---

## `FrmKhamBenh`

Thực hiện:

- Nhập mã hồ sơ.
- Nhập triệu chứng.
- Nhập chẩn đoán.
- Kiểm tra hồ sơ.
- Xác định loại khám.
- Tạo `PhieuKhamBenh`.

`MaPhieuKham` được sinh dưới dạng chuỗi, phù hợp với cấu trúc:

```text
varchar(20)
```

của CSDL.

---

## `FrmXetNghiem`

Cập nhật kết quả xét nghiệm.

Do giao diện hiện có một ô mã, dữ liệu được nhập theo dạng:

```text
MaPhieuKham|MaXetNghiem
```

Ví dụ:

```text
PK01|XN01
```

Sau đó hệ thống cập nhật:

```text
KetQua
NgayThucHien
TrangThai = DaCoKetQua
```

cho đúng khóa ghép của `ChiDinhXetNghiem`.

---

## `FrmLapToa`

Lập toa thuốc:

- Chọn phiếu khám.
- Chọn thuốc.
- Nhập số lượng.
- Nhập liều dùng.
- Nhập cách dùng.
- Nhập lời dặn.
- Lưu toàn bộ toa bằng Transaction.

---

## `FrmThanhToan`

Thanh toán viện phí.

Hệ thống:

1. Kiểm tra phiếu khám.
2. Kiểm tra chẩn đoán.
3. Kiểm tra xét nghiệm đã hoàn tất.
4. Tính tiền xét nghiệm.
5. Tính tiền thuốc.
6. Áp dụng miễn tiền khám định kỳ.
7. Tạo hoặc cập nhật `HoaDonVienPhi`.
8. Đánh dấu `DaThanhToan = 1`.

Công thức:

```text
TongThanhToan
=
TongTienKham
+
TongTienXN
+
TongTienThuoc
-
MienGiam
```

---

## `FrmPhatThuoc`

Kiểm tra:

```text
Toa thuốc tồn tại?
        ↓
Đã phát trước đó?
        ↓
Hóa đơn đã thanh toán?
```

Nếu hợp lệ:

```text
DaPhat = 1
NgayPhat = SYSDATETIME()
```

---

## `FrmHoanTat`

Chốt đợt khám khi:

- Có chẩn đoán.
- Không còn xét nghiệm chờ.
- Đã thanh toán.
- Toa đã phát nếu có.

Sau đó:

```text
TrangThai = HoanTat
```

---

# 17. Kiểm thử

Báo cáo xây dựng bộ kiểm thử khoảng **30 Test Case**, bao phủ:

- Đăng ký bệnh nhân.
- Cấp hồ sơ.
- Thu lệ phí.
- Gia hạn lệ phí.
- Đặt lịch định kỳ.
- Khám bệnh.
- Xét nghiệm.
- Lập toa.
- Thanh toán.
- Phát thuốc.
- Hoàn tất hồ sơ.
- Transaction và rollback.
- Các ràng buộc PK/FK/UNIQUE/CHECK.

---

# 18. Một số trường hợp kiểm thử quan trọng

## Đăng ký

```text
Bệnh nhân mới + dữ liệu hợp lệ
→ Cấp hồ sơ thành công
```

Nếu một bước ghi dữ liệu lỗi:

```text
Rollback toàn bộ
```

---

## Lịch định kỳ

```text
Lệ phí hết hạn
→ Không được đặt lịch hưởng quyền lợi
```

```text
Đã có lịch hiệu lực cùng quý
→ Không cho tạo lịch thứ hai
```

---

## Xét nghiệm

```text
Đúng MaPhieuKham + MaXetNghiem
→ Cập nhật kết quả
```

```text
Đã có kết quả
→ Không cập nhật lại theo luồng thông thường
```

---

## Thanh toán

```text
Còn xét nghiệm chờ
→ Không thanh toán
```

```text
Khám định kỳ
→ TongTienKham = 0
```

```text
Đã thanh toán
→ Không thanh toán lần hai
```

---

## Phát thuốc

```text
Chưa thanh toán
→ Không phát thuốc
```

```text
Đã phát thuốc
→ Không phát lần hai
```

---

## Hoàn tất

```text
Chưa thanh toán
→ Không hoàn tất
```

```text
Có toa chưa phát
→ Không hoàn tất
```

---

# 19. Kết quả thực hiện

LAB6 đã thực hiện:

- Phân tích hoạt động nghiệp vụ.
- Xác định Actor.
- Xác định Business Rules.
- Xác định Class và ID.
- Class Diagram phân tích.
- Use Case tổng quát.
- Use Case phân rã.
- Đặc tả Use Case.
- State Machine Diagram.
- Sequence Diagram.
- Activity Diagram.
- Class Diagram thiết kế.
- ERD.
- Thiết kế SQL Server.
- Tạo 13 bảng.
- Tạo Stored Procedure.
- Xây dựng WinForms.
- Kết nối SQL Server bằng ADO.NET.
- Đăng ký bệnh nhân.
- Cấp hồ sơ.
- Đặt lịch.
- Khám bệnh.
- Cập nhật xét nghiệm.
- Lập toa.
- Thanh toán.
- Phát thuốc.
- Hoàn tất hồ sơ.
- Xây dựng bộ Test Case.
- Xây dựng Requirement Traceability Matrix.

---

# 20. Một số lỗi gặp phải và cách khắc phục

## 20.1. Sai tên bảng phiếu khám

### Lỗi cũ

```text
PHIEUKHAM
```

trong khi CSDL sử dụng:

```text
PhieuKhamBenh
```

### Khắc phục

Sửa `FrmKhamBenh.cs` sử dụng đúng bảng và đúng khóa:

```text
MaPhieuKham varchar(20)
```

Không sử dụng `SCOPE_IDENTITY()`.

---

## 20.2. Sai khóa chỉ định xét nghiệm

### Lỗi cũ

```text
MaChiDinh
```

CSDL không có cột này.

Khóa đúng:

```text
MaPhieuKham + MaXetNghiem
```

### Khắc phục

`FrmXetNghiem` sử dụng định dạng:

```text
MaPhieuKham|MaXetNghiem
```

---

## 20.3. Sai tên bảng hóa đơn

### Lỗi cũ

```text
HOADON
```

### Bảng đúng

```text
HoaDonVienPhi
```

### Khắc phục

Sửa `FrmThanhToan.cs` để tạo/cập nhật đúng `HoaDonVienPhi`.

---

## 20.4. Sai thuộc tính toa thuốc

### Lỗi cũ

```text
MaToaThuoc
TrangThai
```

Trong khi CSDL dùng:

```text
MaToa
DaPhat
NgayPhat
```

### Khắc phục

Sửa thành:

```sql
UPDATE ToaThuoc
SET DaPhat = 1,
    NgayPhat = SYSDATETIME()
WHERE MaToa = @MaToa;
```

Bản báo cáo mới đã cập nhật thao tác phát thuốc theo đúng các trường `DaPhat` và `NgayPhat`.

---

# 21. Hướng dẫn chạy lại dự án

## Bước 1 - Clone Repository

```bash
git clone https://github.com/BaoHuz/LAB_AT_OOSD.git
```

Sau đó:

```bash
cd LAB_AT_OOSD/LAB6
```

---

## Bước 2 - Tạo Database

Mở file:

```text
QuanLyHoSoBenhAn.sql
```

bằng SQL Server Management Studio.

Chạy toàn bộ script.

Kiểm tra Database:

```text
QuanLyHoSoBenhAn
```

và 13 bảng đã được tạo.

---

## Bước 3 - Cấu hình Connection String

Mở:

```text
LAB6/QuanLyHoSoBenhAn/QuanLyHoSoBenhAn/App.config
```

Ví dụ LocalDB:

```xml
<connectionStrings>
  <add name="Db"
       connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyHoSoBenhAn;Integrated Security=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Nếu dùng SQL Server Express:

```text
Data Source=.\SQLEXPRESS
```

Nếu dùng SQL Server mặc định:

```text
Data Source=.
```

---

## Bước 4 - Mở Solution

Mở:

```text
LAB6/QuanLyHoSoBenhAn/QuanLyHoSoBenhAn.sln
```

bằng Visual Studio 2022.

---

## Bước 5 - Build

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

## Bước 6 - Chạy

Nhấn:

```text
F5
```

---
