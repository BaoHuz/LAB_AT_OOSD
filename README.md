# LAB Phương pháp phát triển phần mềm hướng đối tượng

Kho lưu trữ tổng hợp bài thực hành môn **Phương pháp phát triển phần mềm hướng đối tượng**, gồm tài liệu phân tích – thiết kế, sơ đồ UML, script SQL Server và các ứng dụng minh họa từ LAB1 đến LAB8.

## Thông tin sinh viên

| Nội dung | Thông tin |
|---|---|
| Họ và tên | Nguyễn Hữu Bảo |
| MSSV | 1250080016 |
| Lớp | 12_ĐH_CNPM1 |
| Môn học | Phương pháp phát triển phần mềm hướng đối tượng |

## Tổng quan nội dung

| Lab | Chủ đề | Sản phẩm chính | Chi tiết |
|---|---|---|---|
| LAB1 | OOP Java; phân tích và đặc tả Use Case | Chương trình hình học Java, báo cáo và Activity Diagram | [Xem README](LAB1/README.md) |
| LAB2 | Hệ thống quản lý thư viện | C# WinForms, SQL Server, UML và báo cáo | [Xem README](LAB2/README.md) |
| LAB3 | Hệ thống quản lý khách sạn | C# WinForms, SQL Server, UML và báo cáo | [Xem README](LAB3/README.md) |
| LAB4 | Chuyển UML sang CSDL; hệ thống e-Shopping | Hai bài tập, C# WinForms, SQL Server và UML | [Xem README](LAB4/README.md) |
| LAB5 | Quản lý công ty du lịch Văn Hóa Việt | C# WinForms, SQL Server, UML và báo cáo | [Xem README](LAB5/README.md) |
| LAB6 | Quản lý hồ sơ bệnh án | C# WinForms, SQL Server, UML và báo cáo | [Xem README](LAB6/README.md) |
| LAB7 | Quản lý nhân sự Công ty Sơn Đông Á | C# WinForms, SQL Server, UML và báo cáo | [Xem README](LAB7/README.md) |
| LAB8 | Quản lý cho thuê văn phòng ở cao ốc | C# WinForms, SQL Server, UML và báo cáo | [Xem README](LAB8/README.md) |

Các ứng dụng từ LAB2 đến LAB8 được tổ chức chủ yếu theo luồng:

```text
Forms (UI) -> Services (nghiệp vụ) -> Data (ADO.NET) -> SQL Server
```

## Công nghệ và công cụ

- Java/JDK cho bài lập trình ở LAB1.
- C# Windows Forms trên **.NET Framework 4.7.2** cho LAB2–LAB8.
- ADO.NET (`System.Data.SqlClient`) để truy cập dữ liệu.
- Microsoft SQL Server và SQL Server Management Studio (SSMS).
- Visual Studio 2022 với workload **.NET desktop development**.
- Draw.io/diagrams.net để xem và chỉnh sửa các sơ đồ `.drawio`.
- Microsoft Word hoặc phần mềm tương thích để xem báo cáo `.docx`; trình đọc PDF cho tài liệu `.pdf`.

## Cấu trúc repository

```text
LAB_AT_OOSD/
├── LAB1/       # Java OOP và đặc tả Use Case
├── LAB2/       # Quản lý thư viện
├── LAB3/       # Quản lý khách sạn
├── LAB4/       # UML -> CSDL và e-Shopping
├── LAB5/       # Quản lý công ty du lịch
├── LAB6/       # Quản lý hồ sơ bệnh án
├── LAB7/       # Quản lý nhân sự
├── LAB8/       # Quản lý cho thuê văn phòng
├── IMAGES/     # Các tệp sơ đồ Draw.io được tập hợp
├── TONGHOP/    # Báo cáo từng lab và báo cáo tổng hợp
└── README.md    # Tài liệu tổng quan này
```

Mỗi thư mục lab có README riêng mô tả nghiệp vụ, cấu trúc dữ liệu, chức năng, test case đề xuất và các lỗi thường gặp. Thư mục `.vs/`, `bin/` và `obj/` (nếu có) là dữ liệu do Visual Studio sinh ra, không phải mã nguồn chính.

## Chuẩn bị môi trường

1. Cài JDK và bảo đảm hai lệnh `javac`, `java` có trong `PATH` nếu cần chạy LAB1.
2. Cài Visual Studio 2022, workload **.NET desktop development** và .NET Framework 4.7.2 Developer Pack/Targeting Pack.
3. Cài SQL Server cùng SSMS. Có thể dùng SQL Server mặc định (`.`), SQL Server Express (`.\SQLEXPRESS`) hoặc LocalDB nếu cấu hình phù hợp.
4. Tải hoặc clone repository, sau đó mở thư mục lab cần kiểm tra.

## Chạy LAB1

Mở PowerShell tại thư mục repository và thực hiện:

```powershell
Set-Location .\LAB1\BT_Buoi2\BT1
javac *.java
java Program
```

Kết quả mong đợi là thông tin vẽ hình, chu vi và diện tích của tam giác, tứ giác và ellipse được in ra console. Phần phân tích Use Case của LAB1 nằm trong `LAB1/BT_Buoi2/BT2`.

## Chạy các ứng dụng WinForms

### 1. Khởi tạo cơ sở dữ liệu

Mở đúng script trong SSMS và chạy trên SQL Server cục bộ:

| Lab | Script SQL | Database được tạo |
|---|---|---|
| LAB2 | [`LAB2/QuanLyThuVien.sql`](LAB2/QuanLyThuVien.sql) | `QuanLyThuVienDB` |
| LAB3 | [`LAB3/QuanLyKhachSan.sql`](LAB3/QuanLyKhachSan.sql) | `QuanLyKhachSan` |
| LAB4 – Bài 1 | [`LAB4/Bai1_SoDo/QuanLyNhanVienKD_DB.sql`](LAB4/Bai1_SoDo/QuanLyNhanVienKD_DB.sql) | `QuanLyNhanVienKD_DB` |
| LAB4 – Bài 2 | [`LAB4/Bai2_LAB_shopping/eShoppingDB.sql`](LAB4/Bai2_LAB_shopping/eShoppingDB.sql) | `eShoppingDB` |
| LAB5 | [`LAB5/QuanLyCongTyDuLich.sql`](LAB5/QuanLyCongTyDuLich.sql) | `QuanLyCongTyDuLich` |
| LAB6 | [`LAB6/QuanLyHoSoBenhAn.sql`](LAB6/QuanLyHoSoBenhAn.sql) | `QuanLyHoSoBenhAn` |
| LAB7 | [`LAB7/QuanLyNhanSuDongA.sql`](LAB7/QuanLyNhanSuDongA.sql) | `QuanLyNhanSuDongA` |
| LAB8 | [`LAB8/QuanLyChoThueVanPhong.sql`](LAB8/QuanLyChoThueVanPhong.sql) | `QuanLyChoThueVanPhong` |

> **Cảnh báo:** nhiều script có lệnh xóa bảng hoặc tạo lại dữ liệu để phục vụ bài lab. Không chạy trên database có dữ liệu cần giữ; hãy sao lưu trước khi thực thi lại.

Sau khi chạy script, làm mới danh sách database trong SSMS và kiểm tra database/bảng tương ứng đã xuất hiện. Không tiếp tục chạy ứng dụng nếu script báo lỗi.

### 2. Cấu hình kết nối SQL Server

Kiểm tra chuỗi kết nối trước khi build:

| Lab | Tệp cấu hình | Tên connection string |
|---|---|---|
| LAB2 | `LAB2/QuanLyThuVien/App.config` | `QuanLyThuVienDb` |
| LAB3 | `LAB3/QuanLyKhachSan/QuanLyKhachSan/App.config` | `QuanLyKhachSanDB` |
| LAB4 – Bài 2 | `LAB4/Bai2_LAB_shopping/eShoppingApp/eShoppingApp/Data/Db.cs` | Chuỗi kết nối khai báo trực tiếp trong mã |
| LAB5 | `LAB5/QuanLyCongTyDuLich/QuanLyCongTyDuLich/App.config` | `QuanLyCongTyDuLichDB` |
| LAB6 | `LAB6/QuanLyHoSoBenhAn/QuanLyHoSoBenhAn/App.config` | `Db` |
| LAB7 | `LAB7/QuanLyNhanSuDongA/QuanLyNhanSuDongA/App.config` | `QuanLyNhanSuDongADB` |
| LAB8 | `LAB8/QuanLyChoThueVanPhong/QuanLyChoThueVanPhong/App.config` | `QLVanPhongDB` |

Ví dụ dùng Windows Authentication với SQL Server Express:

```xml
connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=TEN_DATABASE;Integrated Security=True;TrustServerCertificate=True"
```

Thay `TEN_DATABASE` bằng đúng tên trong bảng phía trên. Với SQL Server mặc định, dùng `Data Source=.`. LAB7 hiện chứa tên máy/instance cụ thể trong `App.config`, vì vậy thường phải chỉnh lại khi chạy trên máy khác.

### 3. Mở solution, build và chạy

| Lab | Solution |
|---|---|
| LAB2 | [`LAB2/QuanLyThuVien.sln`](LAB2/QuanLyThuVien.sln) |
| LAB3 | [`LAB3/QuanLyKhachSan/QuanLyKhachSan.sln`](LAB3/QuanLyKhachSan/QuanLyKhachSan.sln) |
| LAB4 – Bài 2 | [`LAB4/Bai2_LAB_shopping/eShoppingApp/eShoppingApp.sln`](LAB4/Bai2_LAB_shopping/eShoppingApp/eShoppingApp.sln) |
| LAB5 | [`LAB5/QuanLyCongTyDuLich/QuanLyCongTyDuLich.sln`](LAB5/QuanLyCongTyDuLich/QuanLyCongTyDuLich.sln) |
| LAB6 | [`LAB6/QuanLyHoSoBenhAn/QuanLyHoSoBenhAn.sln`](LAB6/QuanLyHoSoBenhAn/QuanLyHoSoBenhAn.sln) |
| LAB7 | [`LAB7/QuanLyNhanSuDongA/QuanLyNhanSuDongA.sln`](LAB7/QuanLyNhanSuDongA/QuanLyNhanSuDongA.sln) |
| LAB8 | [`LAB8/QuanLyChoThueVanPhong/QuanLyChoThueVanPhong.sln`](LAB8/QuanLyChoThueVanPhong/QuanLyChoThueVanPhong.sln) |

Trong Visual Studio:

1. Mở solution của lab cần chạy.
2. Chọn project WinForms làm **Startup Project** nếu Visual Studio chưa tự nhận.
3. Chọn **Build → Rebuild Solution** hoặc nhấn `Ctrl+Shift+B`.
4. Khi build không còn lỗi, nhấn `F5` để chạy có debug hoặc `Ctrl+F5` để chạy không debug.
5. Thực hiện các kịch bản kiểm tra được mô tả trong README của lab tương ứng.

## Kiểm tra nhanh sau khi cài đặt

- Database và các bảng được tạo đúng tên, script SQL không còn lỗi.
- `Data Source` trỏ đúng SQL Server instance đang chạy.
- `Initial Catalog` khớp chính xác với database của lab.
- Project build được với target .NET Framework 4.7.2.
- Form chính mở được và tải dữ liệu từ SQL Server.
- Các thao tác thêm, sửa, xóa và nghiệp vụ đặc thù được kiểm tra bằng dữ liệu mẫu theo README từng lab.

Repository không có project unit test tự động; các bảng test case trong README/báo cáo là kịch bản kiểm thử thủ công. Chỉ kết luận Pass/Fail sau khi thực sự chạy trên môi trường đã cấu hình.

## Xử lý lỗi thường gặp

### Không kết nối được SQL Server

- Kiểm tra dịch vụ SQL Server đang chạy.
- Xác nhận đúng instance: `.`, `.\SQLEXPRESS` hoặc `(localdb)\MSSQLLocalDB`.
- Kiểm tra database đã được tạo và tên trong `Initial Catalog` không sai.
- Nếu dùng Windows Authentication, bảo đảm tài khoản hiện tại có quyền truy cập database.

### Visual Studio báo thiếu .NET Framework 4.7.2

Cài .NET Framework 4.7.2 Developer Pack/Targeting Pack qua Visual Studio Installer, sau đó tải lại solution.

### Lỗi database đã tồn tại hoặc object đã tồn tại

Một số script có thể chạy lại an toàn hơn các script khác. Đọc phần đầu script trước khi thực thi; nếu script dùng `CREATE DATABASE` trực tiếp, hãy dùng database sạch hoặc xử lý database cũ sau khi đã sao lưu.

### Giao diện mở nhưng không có dữ liệu

Kiểm tra lại script dữ liệu mẫu, chuỗi kết nối và database mà ứng dụng đang truy cập. Có thể chạy một câu lệnh `SELECT` trực tiếp trong SSMS để xác nhận dữ liệu tồn tại trước khi kiểm tra giao diện.

### Lỗi khi biên dịch LAB1

Chạy `javac -version` và `java -version` để xác nhận JDK đã được cài và hai lệnh đang dùng cùng một phiên bản Java.

## Tài liệu tổng hợp

Thư mục [`TONGHOP`](TONGHOP/) chứa báo cáo của từng lab và báo cáo tổng hợp. Các sơ đồ nguồn được lưu trong từng thư mục lab; thư mục [`IMAGES`](IMAGES/) tập hợp thêm các tệp Draw.io để thuận tiện tra cứu.

## Ghi chú

- Không đưa mật khẩu hoặc tài khoản SQL Server thật vào repository. Ưu tiên Windows Authentication hoặc cấu hình cục bộ không commit.
- README tổng cung cấp quy trình chung; quy tắc nghiệp vụ, cấu trúc bảng, test case và hướng dẫn chi tiết nằm trong README của từng lab.
- Nội dung build/chạy phụ thuộc SQL Server instance trên máy; cần chỉnh chuỗi kết nối phù hợp trước khi kiểm chứng.
