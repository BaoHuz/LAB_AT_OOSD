# LAB8 – QUẢN LÝ CHO THUÊ VĂN PHÒNG Ở CAO ỐC

## 1. Thông tin sinh viên
- **Họ và tên:** Nguyễn Hữu Bảo
- **MSSV:** 1250080016
- **Lớp:** 12_ĐH_CNPM1
- **Bài Lab:** LAB8
- **Tên bài:** Quản lý cho thuê văn phòng ở cao ốc

## 2. Môi trường / phiên bản sử dụng
- **Hệ điều hành:** Windows 11
- **Visual Studio:** Visual Studio 2022
- **Ngôn ngữ lập trình:** C#
- **Nền tảng dự kiến hiện thực:** Windows Forms App (.NET Framework)
- **.NET Framework:** 4.7.2
- **Cơ sở dữ liệu:** Microsoft SQL Server
- **Công cụ quản lý CSDL:** SQL Server Management Studio (SSMS)
- **Công cụ vẽ UML:** draw.io / PlantUML
- **Công cụ soạn báo cáo:** Microsoft Word

## 3. Nội dung đã thực hiện
Bài LAB8 thực hiện phân tích và thiết kế hệ thống **Quản lý cho thuê văn phòng ở cao ốc**, bao gồm:

- Phân tích nghiệp vụ quản lý tầng và văn phòng.
- Quản lý khách hàng và hợp đồng thuê văn phòng.
- Xử lý quy tắc thời gian thuê tối thiểu 6 tháng.
- Thanh toán trước tiền thuê 6 tháng đầu.
- Từ tháng thứ 7 trở đi thanh toán tiền thuê theo từng tháng.
- Quản lý dịch vụ sử dụng như điện, nước, Internet và lập hóa đơn dịch vụ cuối tháng.
- Quản lý gia hạn văn phòng thuê.
- Kiểm tra điều kiện gia hạn: không còn nợ tiền thuê, không còn nợ dịch vụ và tổng thời gian gia hạn không vượt quá 1/2 thời gian thuê ban đầu.
- Quản lý nhân viên làm việc tại các văn phòng.
- Quản lý thẻ giữ xe của nhân viên.
- Quản lý kiểm tra tình trạng phòng, thay đổi kết cấu, mức phạt và kiến nghị sửa chữa.
- Xác định các Class, thuộc tính, phương thức, ID, association và multiplicity.
- Xây dựng các sơ đồ UML:
  - Use Case Diagram tổng quát.
  - Use Case Diagram phân rã.
  - Class Diagram phân tích.
  - Class Diagram thiết kế chi tiết.
  - State Diagram.
  - Activity Diagram.
  - Sequence Diagram cho nghiệp vụ gia hạn.
  - Các sơ đồ thiết kế chức năng liên quan.
- Thiết kế CSDL SQL Server có Primary Key, Foreign Key, UNIQUE, CHECK Constraint, Index, User-defined Table Type, Stored Procedure và Transaction cho nghiệp vụ nhiều bảng.

## 4. Các file chính trong LAB8
```text
LAB8/
├── 1250080016_NguyenHuuBao_12_DH_CNPM1_...docx
├── Bai_4_Cho_thue_van_phong_cao_oc.docx
├── LAB8.drawio
└── QuanLyChoThueVanPhong.sql
```

Ý nghĩa:
- **File báo cáo Word:** nội dung phân tích, thiết kế và mô hình UML.
- **Bai_4_Cho_thue_van_phong_cao_oc.docx:** đề bài gốc.
- **LAB8.drawio:** các sơ đồ UML có thể chỉnh sửa.
- **QuanLyChoThueVanPhong.sql:** script tạo CSDL, ràng buộc, stored procedure và dữ liệu mẫu.

## 5. Kết quả đạt được
- Hoàn thành phân tích nghiệp vụ theo yêu cầu của đề.
- Xác định được các lớp chính và mối quan hệ giữa các lớp.
- Hoàn thành các sơ đồ UML phục vụ pha phân tích và pha thiết kế.
- Xây dựng được CSDL **QuanLyChoThueVanPhong** trên SQL Server.
- CSDL quản lý các bảng chính: `Tang`, `VanPhong`, `KhachHang`, `HopDongThue`, `ChiTietHopDong`, `ThanhToanTienThue`, `DichVu`, `SuDungDichVu`, `HoaDonDichVu`, `ChiTietHoaDonDichVu`, `ThanhToanDichVu`, `PhieuGiaHan`, `NhanVienVanPhong`, `TheGiuXe`, `KiemTraPhong`.
- Đã xây dựng các stored procedure:
  - `sp_LapHopDongVaThu6Thang`
  - `sp_LapHoaDonDichVuThang`
  - `sp_GiaHanVanPhong`
- Có dữ liệu mẫu để kiểm tra hoạt động của CSDL.

## 6. Một số quy tắc nghiệp vụ đã xử lý
### 6.1. Hợp đồng thuê
- Thời gian thuê tối thiểu **6 tháng**.
- Một hợp đồng có thể thuê nhiều văn phòng.
- Khi lập hợp đồng, khách phải thanh toán trước tiền thuê của **6 tháng đầu**.
- Văn phòng đang được thuê không được cấp cho hợp đồng khác trong cùng khoảng thời gian.

### 6.2. Thanh toán tiền thuê
- 6 tháng đầu được thanh toán khi lập hợp đồng.
- Từ tháng thứ 7 trở đi, tiền thuê được thanh toán theo từng tháng.

### 6.3. Dịch vụ
- Các dịch vụ như điện, nước, Internet được ghi nhận theo từng tháng.
- Hóa đơn dịch vụ được lập cuối tháng.
- Thành tiền dịch vụ dựa trên số lượng sử dụng và đơn giá.

### 6.4. Gia hạn
Chỉ cho phép gia hạn khi:
- Hợp đồng còn hiệu lực.
- Văn phòng đang thuộc hợp đồng cần gia hạn.
- Không còn nợ tiền thuê.
- Không còn nợ hóa đơn dịch vụ.
- Tổng thời gian gia hạn không vượt quá **1/2 thời gian thuê ban đầu**.
- Văn phòng không bị trùng lịch với hợp đồng khác trong khoảng thời gian gia hạn.

## 7. Lỗi gặp phải và cách khắc phục
### Lỗi 1: Sai quan hệ giữa các bảng
**Nguyên nhân:** Một số nghiệp vụ liên quan đồng thời đến hợp đồng và văn phòng nên nếu chỉ dùng một khóa ngoại đơn sẽ không đảm bảo đúng dữ liệu.

**Cách khắc phục:** Sử dụng khóa chính ghép `(MaHD, MaVP)` trong `ChiTietHopDong` và khóa ngoại ghép cho các bảng phụ thuộc.

### Lỗi 2: Có thể thuê trùng văn phòng trong cùng khoảng thời gian
**Nguyên nhân:** Chỉ kiểm tra trạng thái `Đang thuê` là chưa đủ để phát hiện giao nhau giữa các khoảng ngày.

**Cách khắc phục:** Kiểm tra khoảng thời gian trước khi lập hợp đồng bằng điều kiện giao nhau giữa `NgayBatDau` và `NgayKetThuc`.

### Lỗi 3: Nghiệp vụ lập hợp đồng liên quan nhiều bảng
**Nguyên nhân:** Nếu thêm hợp đồng thành công nhưng thêm chi tiết hoặc thanh toán thất bại thì dữ liệu sẽ không đồng nhất.

**Cách khắc phục:** Sử dụng `BEGIN TRAN`, `COMMIT`, `ROLLBACK` và `TRY...CATCH` trong stored procedure `sp_LapHopDongVaThu6Thang`.

### Lỗi 4: Gia hạn khi khách vẫn còn nợ
**Nguyên nhân:** Nếu chỉ cập nhật ngày kết thúc hợp đồng mà không kiểm tra công nợ sẽ vi phạm yêu cầu nghiệp vụ.

**Cách khắc phục:** Trong `sp_GiaHanVanPhong`, kiểm tra `ThanhToanTienThue` và `HoaDonDichVu` phải ở trạng thái `Đã thanh toán`.

### Lỗi 5: Thời gian gia hạn vượt giới hạn
**Nguyên nhân:** Có thể gia hạn nhiều lần khiến tổng số tháng gia hạn vượt quy định.

**Cách khắc phục:** Tính tổng số tháng đã gia hạn và chỉ chấp nhận khi:
```text
Tổng số tháng gia hạn <= 1/2 số tháng thuê ban đầu
```

### Lỗi 6: PlantUML State Diagram không nhận `entry /` và `do /` khi đặt trực tiếp trong block
**Nguyên nhân:** Cú pháp PlantUML trong draw.io không nhận đúng các dòng `entry / ...` và `do / ...` đặt trực tiếp trong `{ }`.

**Cách khắc phục:** Dùng cú pháp:
```plantuml
HieuLuc : entry / Ghi nhận hợp đồng có hiệu lực
HieuLuc : do / Theo dõi thời hạn thuê
HieuLuc : do / Theo dõi thanh toán tiền thuê
```

## 8. Hướng dẫn giảng viên kiểm tra / chạy lại
### Bước 1. Mở thư mục LAB8
Kiểm tra các file:
```text
LAB8.drawio
QuanLyChoThueVanPhong.sql
Bai_4_Cho_thue_van_phong_cao_oc.docx
File báo cáo bài làm .docx
```

### Bước 2. Kiểm tra sơ đồ UML
1. Mở **draw.io / diagrams.net**.
2. Chọn **File → Open From → Device**.
3. Mở `LAB8.drawio`.
4. Kiểm tra các sơ đồ UML trong file.

### Bước 3. Tạo CSDL SQL Server
1. Mở **SQL Server Management Studio**.
2. Kết nối tới SQL Server.
3. Chọn **File → Open → File**.
4. Mở `QuanLyChoThueVanPhong.sql`.
5. Nhấn **Execute**.

Script sẽ tạo database:
```text
QuanLyChoThueVanPhong
```

### Bước 4. Kiểm tra các bảng
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
SELECT * FROM PhieuGiaHan;
SELECT * FROM NhanVienVanPhong;
SELECT * FROM TheGiuXe;
SELECT * FROM KiemTraPhong;
```

### Bước 5. Kiểm tra stored procedure
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

### Bước 6. Kiểm tra dữ liệu mẫu
```sql
SELECT * FROM HopDongThue WHERE MaHD = 'HD001';
SELECT * FROM ChiTietHopDong WHERE MaHD = 'HD001';
SELECT * FROM ThanhToanTienThue WHERE MaHD = 'HD001' ORDER BY KyTuThang;
SELECT * FROM HoaDonDichVu WHERE MaHD = 'HD001';
```

## 9. Ghi chú
- Script SQL có lệnh xóa và tạo lại các bảng, procedure và type để thuận tiện chạy lại bài.
- Nên chạy toàn bộ file SQL từ đầu để đảm bảo CSDL được tạo đúng thứ tự khóa ngoại.
- Nếu SQL Server sử dụng instance khác, chọn đúng instance trước khi Execute.
- Các sơ đồ UML có thể chỉnh sửa trực tiếp trong `LAB8.drawio`.
- Báo cáo Word trình bày chi tiết phần phân tích và thiết kế của LAB8.

---

**Sinh viên thực hiện:** Nguyễn Hữu Bảo  
**MSSV:** 1250080016
