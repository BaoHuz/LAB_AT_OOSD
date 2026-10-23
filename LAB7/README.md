# LAB 7 – QUẢN LÝ NHÂN SỰ CÔNG TY SƠN ĐÔNG Á

## 1. Thông tin sinh viên

| Thông tin | Nội dung |
| --- | --- |
| Họ và tên | Nguyễn Hữu Bảo |
| MSSV | 1250080016 |
| Lớp | 12_ĐH_CNPM1 |
| Tên bài Lab | Bài 7 – Quản lý nhân sự |


## 2. Các tệp trong bài nộp

| Tệp / thư mục | Nội dung |
| --- | --- |
| `Bai_7_Quan_ly_nhan_su.docx` | Đề bài, mô tả nghiệp vụ và 6 câu hỏi thực hành. |
| `1250080016_NguyenHuuBao_12_ĐH_CNPM1_Lab7.docx` | Báo cáo phân tích, thiết kế, hình UML, giao diện, mã minh họa và kịch bản kiểm thử. |
| `LAB7.drawio` | Tệp sơ đồ có 22 trang, từ P01 đến P22; mở bằng diagrams.net/draw.io. |
| `QuanLyNhanSuDongA.sql` | Script tạo CSDL, 21 bảng, ràng buộc, chỉ mục và dữ liệu mẫu. Tệp nằm ngay thư mục gốc LAB7. |
| `QuanLyNhanSuDongA/QuanLyNhanSuDongA.sln` | Solution để mở và build chương trình. |
| `QuanLyNhanSuDongA/QuanLyNhanSuDongA/` | Mã nguồn C#, cấu hình và tài nguyên WinForms. |
| `README.md` | Mô tả kết quả, môi trường, hướng dẫn chạy và kiểm tra lại. |

Cấu trúc mã nguồn chính:

```text
QuanLyNhanSuDongA/
├── QuanLyNhanSuDongA.sln
└── QuanLyNhanSuDongA/
    ├── App.config                 # Chuỗi kết nối SQL Server
    ├── Program.cs                 # Khởi động FrmMain
    ├── Data/Db.cs                 # Open, Query, Execute, Scalar
    ├── Services/                  # Xử lý nghiệp vụ
    ├── Forms/                     # Giao diện và các tệp Designer
    ├── Properties/                # AssemblyInfo, Resources, Settings
    └── QuanLyNhanSuDongA.csproj
```

`Form1.cs` là form mẫu còn trong project; chương trình thực tế khởi động bằng `Forms.FrmMain`. Các thư mục `.vs`, `bin`, `obj` nếu có là dữ liệu IDE và sản phẩm build, không phải phần mã nguồn cần chỉnh sửa.

## 3. Môi trường và phiên bản

| Thành phần | Cấu hình / yêu cầu |
| --- | --- |
| Hệ điều hành | Windows; chương trình dùng Windows Forms và gọi `user32.dll`. |
| Ngôn ngữ, giao diện | C#, Windows Forms. |
| Framework đích | **.NET Framework 4.7.2**, cấu hình trong `.csproj` và `App.config`. |
| Visual Studio | Solution lưu phiên bản **17.14.37710.0** (Visual Studio 2022); cần workload **.NET desktop development** và Developer Pack/Targeting Pack 4.7.2. |
| Cấu hình build | Debug hoặc Release, Any CPU. |
| Truy cập dữ liệu | ADO.NET, `System.Data.SqlClient`, `System.Configuration`; không có gói NuGet bên ngoài được khai báo trong project. |
| CSDL | SQL Server **2016 trở lên** để dùng cú pháp `DROP TABLE IF EXISTS`; có thể dùng bản Express. Phiên bản SQL Server thực tế chưa xác minh được. |
| Công cụ SQL | SQL Server Management Studio (SSMS), hoặc `sqlcmd` nếu đã cài. |
| Công cụ xem tài liệu | Microsoft Word hoặc phần mềm đọc DOCX; diagrams.net/draw.io để xem sơ đồ. Chưa có thông tin phiên bản draw.io trong tệp. |
| Phiên bản ứng dụng | Assembly/File Version **1.0.0.0**. |

Lần kiểm tra README ngày **23/10/2026**: build thành công trên Windows `10.0.26300.0`, bằng MSBuild `18.10.1.42706` của Visual Studio Community cài trên máy. Đây là môi trường kiểm tra hiện tại; phiên bản lưu trong solution vẫn là Visual Studio 2022 như trên.

## 4. Nội dung đã thực hiện

### 4.1. Phân tích và thiết kế

- Phân tích vòng đời nhân sự: tuyển dụng, thử việc, hợp đồng, bảo hiểm, lương/chức vụ, kế hoạch tuần, chấm công, phụ trội, khen thưởng/kỷ luật và bảng lương.
- Xác định tác nhân: nhân viên nhân sự, trưởng đơn vị, ban chấm công, kế toán và giám đốc.
- Xác định các lớp, thuộc tính, phương thức, định danh và quan hệ giữa các lớp.
- Xây dựng sơ đồ use case tổng quát/phân rã, lớp phân tích/thiết kế, trạng thái, tuần tự, hoạt động, ERD và điều hướng form.

Đối chiếu 6 câu hỏi của đề bài trong `LAB7.drawio`:

| Câu | Sản phẩm để kiểm tra |
| --- | --- |
| 1. Class, thuộc tính, phương thức, ID | Bảng lớp tại mục 2.2 báo cáo; P13 – Class thiết kế chi tiết. |
| 2. Quan hệ giữa các Class | P04 – Class phân tích. |
| 3. Actor, Use Case tổng quát | P01 – Use Case tổng quát. |
| 4. Phân rã từ thử việc đến hợp đồng | P02 – Use Case phân rã thử việc/hợp đồng. |
| 5. Activity cho Câu 4 | P20 – Activity từ thử việc đến hợp đồng. |
| 6. Sequence lập quyết định khen thưởng | P07 – Sequence lập quyết định khen thưởng. |

Đề bài nhắc StarUML; tệp mô hình thực tế được nộp ở định dạng `.drawio`, không có tệp StarUML trong thư mục.

### 4.2. Cơ sở dữ liệu và chương trình

Thiết kế 21 bảng với khóa chính, khóa ngoại, CHECK, UNIQUE và các chỉ mục phục vụ tra cứu. Các thao tác tuyển dụng, lập phiếu phụ trội và tính lương có sử dụng transaction.

| Màn hình | Chức năng thực tế trong mã nguồn |
| --- | --- |
| `FrmMain` | Điều hướng tới 8 nhóm chức năng và thoát ứng dụng. |
| `FrmDanhMuc` | Xem danh mục phòng ban, ca làm việc, chức vụ. |
| `FrmTuyenDung` | Lập quyết định tuyển dụng, tạo/cập nhật nhân viên ở trạng thái đang thử việc, xem danh sách. |
| `FrmHopDongBaoHiem` | Ký hợp đồng ngắn/dài hạn; kiểm tra ngày bắt đầu sau khi hết thử việc; nhập riêng hồ sơ BHYT/BHXH cho hợp đồng dài hạn. |
| `FrmLuongChucVu` | Thêm quyết định lương, phụ cấp và chức vụ, giữ lịch sử các quyết định. |
| `FrmKeHoachChamCong` | Tạo kế hoạch đủ 7 ngày, phân công trong tuần, ghi chấm công theo nhân viên/ngày/ca. |
| `FrmPhuTroi` | Lập phiếu phụ trội cho nhiều nhân viên, hệ số cố định 1,50. |
| `FrmKhenThuongKyLuat` | Lập quyết định cho đúng một cá nhân hoặc một phòng ban; chọn cách thu phạt. |
| `FrmBangLuong` | Tính lương tháng cho nhân viên chính thức, xem danh sách bảng lương và chi tiết từng người. |

Cấu trúc chính là UI → Service → Data → SQL Server. Trong bản hiện tại, các form vẫn có SQL tra cứu trực tiếp; riêng `FrmLuongChucVu` còn trực tiếp thêm quyết định qua `Db.Execute`.

Công thức tính lương đang được hiện thực:

```text
Tiền theo công = Lương cơ bản × Số bản ghi chấm công “Đi làm” / Ngày công chuẩn
Đơn giá giờ = Lương cơ bản / Ngày công chuẩn / Giờ công chuẩn mỗi ngày
Tiền phụ trội = Tổng(Số giờ phụ trội × 1,50) × Đơn giá giờ
Khấu trừ bảo hiểm = Lương cơ bản × Tổng tỷ lệ NLĐ của hồ sơ BH hiệu lực trong kỳ
Thực lĩnh = Tiền theo công + Phụ cấp lương + Phụ cấp độc hại
           + Phụ cấp chức vụ + Tiền phụ trội - Bảo hiểm - Kỷ luật trừ lương
```

Quyết định lương/chức vụ được chọn theo ngày hiệu lực mới nhất không sau ngày cuối tháng. Ngày công/giờ chuẩn lấy từ `CauHinhTinhLuong`. Các tỷ lệ bảo hiểm trong dữ liệu mẫu là tham số phục vụ bài Lab.

## 5. Kết quả và giới hạn kiểm chứng

- Có báo cáo Word, tệp sơ đồ 22 trang, script CSDL và ứng dụng WinForms với các nhóm chức năng nêu trên.
- **Đã build Debug / Any CPU thành công** bằng MSBuild, mã thoát 0; sinh `QuanLyNhanSuDongA/QuanLyNhanSuDongA/bin/Debug/QuanLyNhanSuDongA.exe`.
- Dữ liệu mẫu trong script có 5 phòng ban, 5 chức vụ, 4 ca, 10 nhân viên (7 chính thức, 2 thử việc, 1 chờ hợp đồng), 7 hợp đồng và 12 hồ sơ bảo hiểm.
- Có cấu hình lương tháng 9–12/2026; bảng lương mẫu `BL202609` có 7 chi tiết. Kế hoạch được tạo cho tháng 9–10/2026; chấm công mẫu đến **23/10/2026**.
- **Chưa xác nhận chạy trọn luồng giao diện và nghiệp vụ với CSDL trong lần kiểm tra này.** Thử kết nối bằng `System.Data.SqlClient` theo cấu hình hiện tại báo `The target principal name is incorrect. Cannot generate SSPI context.`; thử bằng `sqlcmd` cũng không kết nối được, báo lỗi mã hóa/SSL. Các số lượng dữ liệu ở trên được đối chiếu từ script, chưa phải kết quả truy vấn thực tế.

Các phần còn giới hạn trong bản cài đặt:

- Chưa có đăng nhập/phân quyền; vai trò tác nhân mới được mô tả trong mô hình nghiệp vụ.
- Danh mục chỉ có giao diện xem; chưa có đầy đủ sửa/xóa hoặc xuất báo cáo.
- `PhieuChiKhenThuong`, `PhieuThuNopPhat` đã có bảng và dữ liệu mẫu, nhưng chưa có màn hình lập phiếu tương ứng.
- Hợp đồng và bảo hiểm được nhập riêng; chưa bắt buộc đủ cả BHYT và BHXH trước khi nhân viên chuyển chính thức. Ký hợp đồng và cập nhật nhân viên chưa nằm chung transaction.
- Phân công trên giao diện hiện truyền `false` cho kế hoạch phụ trội; chưa có trường nhập phụ trội dự kiến như mô hình thiết kế.
- Chưa có giao diện cấu hình/chốt/mở lại bảng lương. Tính lương chưa cập nhật `DaXuLy` cho tiền phạt, nên khoản phạt chưa xử lý có thể tiếp tục bị tính ở kỳ sau.
- Ngày công đang đếm bản ghi theo ca, chưa quy đổi theo số giờ; cần tránh dùng nhiều ca cùng ngày để suy diễn kết quả ngoài phạm vi công thức hiện có.

## 6. Hướng dẫn cài đặt và chạy lại

### Bước 1 – Chuẩn bị

1. Dùng máy Windows có Visual Studio và các thành phần ở mục 3.
2. Bật dịch vụ SQL Server của instance muốn dùng, ví dụ `SQL Server (SQLEXPRESS)`.
3. Mở SSMS và đăng nhập bằng Windows Authentication; ghi lại đúng tên Server đã kết nối thành công.

### Bước 2 – Khởi tạo CSDL mẫu

**Lưu ý:** script có `DROP TABLE IF EXISTS` rồi tạo lại 21 bảng. Chạy lại sẽ xóa dữ liệu hiện có trong các bảng này của CSDL `QuanLyNhanSuDongA`; chỉ dùng trên CSDL bài Lab và sao lưu nếu cần giữ kết quả đã nhập.

1. Trong SSMS, mở `QuanLyNhanSuDongA.sql` tại thư mục gốc LAB7.
2. Chọn đúng instance SQL Server và Execute toàn bộ tệp, gồm các batch `GO`.
3. Script tự tạo CSDL nếu chưa có; sau khi chạy, Refresh Databases và kiểm tra CSDL `QuanLyNhanSuDongA`.

Nếu đã cài `sqlcmd`, có thể chạy từ PowerShell ở thư mục LAB7; thay tên instance theo máy:

```powershell
sqlcmd -S '.\SQLEXPRESS' -E -C -b -i '.\QuanLyNhanSuDongA.sql'
```

### Bước 3 – Sửa chuỗi kết nối

Mở `QuanLyNhanSuDongA/QuanLyNhanSuDongA/App.config`. Cấu hình đang lưu là `LAPTOP-LDQSVJLM\SQLEXPRESS`, dùng Windows Authentication. Thay `Data Source` bằng đúng Server đã dùng ở bước 2, ví dụ:

```xml
<connectionStrings>
  <add name="QuanLyNhanSuDongADB"
       connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyNhanSuDongA;Integrated Security=True;TrustServerCertificate=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Giữ đúng tên kết nối `QuanLyNhanSuDongADB` và tên CSDL. Tài khoản Windows chạy ứng dụng phải có quyền đọc/ghi trên CSDL; tài khoản chạy script cần quyền tạo CSDL nếu CSDL chưa tồn tại. Nếu dùng LocalDB đã cài sẵn, thay Server bằng `(localdb)\MSSQLLocalDB` và chạy script trên chính instance đó.

### Bước 4 – Build và chạy

1. Mở `QuanLyNhanSuDongA/QuanLyNhanSuDongA.sln`.
2. Nếu cần, chọn project `QuanLyNhanSuDongA` → **Set as Startup Project**.
3. Chọn **Debug / Any CPU** → **Build Solution** (`Ctrl+Shift+B`).
4. Chạy bằng `F5` hoặc `Ctrl+F5`; cửa sổ chính hiển thị “CÔNG TY CỔ PHẦN SƠN ĐÔNG Á”.
5. Mở **Danh mục** để kiểm tra kết nối và dữ liệu trước khi nhập nghiệp vụ.

Hoặc dùng **Developer PowerShell for Visual Studio** tại thư mục LAB7:

```powershell
msbuild '.\QuanLyNhanSuDongA\QuanLyNhanSuDongA.sln' /t:Build /p:Configuration=Debug /p:Platform="Any CPU"
& '.\QuanLyNhanSuDongA\QuanLyNhanSuDongA\bin\Debug\QuanLyNhanSuDongA.exe'
```

Sau khi thay `App.config`, build lại để sao chép cấu hình sang `QuanLyNhanSuDongA.exe.config`. Khi chuyển bản build sang máy khác, giữ cả tệp `.exe.config` bên cạnh `.exe` và bảo đảm máy đích có .NET Framework tương thích.

## 7. Hướng dẫn giảng viên kiểm tra

### 7.1. Kiểm tra tài liệu và dữ liệu ban đầu

Mở báo cáo Word, đối chiếu 6 yêu cầu theo bảng ở mục 4.1. Mở `LAB7.drawio` bằng diagrams.net/draw.io và chọn các trang P01, P02, P04, P07, P13, P20, P21 (ERD), P22 (điều hướng form).

Sau khi chạy script, thực thi trong SSMS:

```sql
USE QuanLyNhanSuDongA;
SELECT COUNT(*) AS SoBang FROM sys.tables WHERE schema_id = SCHEMA_ID('dbo');
SELECT COUNT(*) AS SoNhanVien FROM dbo.NhanVien;
SELECT TrangThai, COUNT(*) AS SoLuong FROM dbo.NhanVien GROUP BY TrangThai;
SELECT COUNT(*) AS SoHopDong FROM dbo.HopDongLaoDong;
SELECT COUNT(*) AS SoHoSoBH FROM dbo.HoSoBaoHiem;
SELECT * FROM dbo.CauHinhTinhLuong ORDER BY Nam, Thang;
SELECT * FROM dbo.BangLuong;
SELECT * FROM dbo.ChiTietBangLuong WHERE MaBangLuong = 'BL202609';
```

Kỳ vọng ngay sau khởi tạo: 21 bảng của bài Lab (nếu CSDL không có bảng khác), 10 nhân viên, 7 hợp đồng, 12 hồ sơ bảo hiểm, 4 cấu hình kỳ lương, 1 bảng lương tháng 9/2026 với 7 chi tiết.

### 7.2. Kiểm tra giao diện và nghiệp vụ

Các ca sau là **hướng dẫn và kết quả mong đợi**, chưa được xác nhận chạy thành công trong lần viết README. Dùng dữ liệu vừa khởi tạo; mỗi ca tạo mới chỉ chạy một lần, hoặc đổi mã khi chạy lại. Nhập đầy đủ người lập/người ký và nội dung ở các màn hình có yêu cầu.

| Ca | Thao tác / dữ liệu | Kết quả mong đợi |
| --- | --- | --- |
| 1 | Mở **Danh mục**, xem 3 tab. | Có 5 phòng ban, 4 ca làm, 5 chức vụ. |
| 2 | **Tuyển dụng – thử việc**: QĐ `TD_TEST01`, NV `NV_TEST01`, họ tên `Nhân viên kiểm tra`, phòng PB02, từ 01/09/2026 đến 30/09/2026, lương 8.000.000, nội dung `Thử việc`, người ký `Giảng viên`. | Thêm QĐ và nhân viên đang thử việc; danh sách được cập nhật. |
| 3 | Đổi mã QĐ/NV sang `TD_TEST02`/`NV_TEST02`; nhập đến ngày sớm hơn từ ngày. | Từ chối với thông báo về ngày thử việc. |
| 4 | **Hợp đồng – bảo hiểm**: tạo `HD_TEST01` cho `NV_TEST01`, dài hạn, ngày ký 01/10/2026, từ ngày 30/09/2026. | Từ chối vì ngày bắt đầu chưa sau ngày hết thử việc. |
| 5 | Giữ dữ liệu ca 4, đổi từ ngày thành 01/10/2026 rồi ký. | Lưu hợp đồng; `NV_TEST01` chuyển sang chính thức. |
| 6 | Tab **Bảo hiểm**: tạo `BH_TEST01`, NV `NV_TEST01`, HĐ `HD_TEST01`, BHYT, số thẻ `TEST-BHYT`, tỷ lệ NV `0,015`, công ty `0,030`, từ 01/10/2026. | Lưu hồ sơ. Nhập theo dấu thập phân của Windows; 0,015 tương đương 1,5%. |
| 7 | Thêm BHXH bằng mã `BH_TEST02`, số thẻ `TEST-BHXH`, tỷ lệ NV `0,080`, công ty `0,175`, cùng NV/HĐ/ngày. | Có đủ hai loại hồ sơ cho hợp đồng thử nghiệm. |
| 8 | Thử lập BHYT cho `NV005`, HĐ `HD005` ngắn hạn, mã BH mới. | Từ chối: bài Lab chỉ áp dụng hồ sơ BH cho hợp đồng dài hạn. |
| 9 | **Quyết định lương – chức vụ**: thêm QĐ `L_TEST01` cho `NV_TEST01`, hiệu lực 01/10/2026, lương 10.000.000, phụ cấp lương 500.000, độc hại 0; thêm QĐ `CV_TEST01`, chức vụ Chuyên viên, phụ cấp 300.000, cùng ngày hiệu lực. | Lưu hai quyết định, có thể xem trong danh sách. |
| 10 | **Kế hoạch – chấm công**: tạo `KH_TEST01` cho PB02, từ 26/10/2026 đến 01/11/2026. | Thành công vì đủ 7 ngày liên tiếp. Nếu đổi đến ngày thành 31/10 thì bị từ chối. |
| 11 | Phân công `KH_TEST01`, STT 1, `NV_TEST01`, ngày 26/10/2026, ca Hành chính (CA01). | Lưu chi tiết; chọn ngày ngoài tuần sẽ bị từ chối. |
| 12 | Chấm công `CC_TEST01`, `NV_TEST01`, ngày 26/10/2026, ca CA01, 8 giờ, trạng thái Đi làm. | Lưu và hiện trong danh sách. Cặp NV/ngày/ca không được trùng. |
| 13 | **Phiếu phụ trội**: `PT_TEST01`, ngày 26/10/2026, 2 giờ, Tăng ca, danh sách `NV_TEST01,NV001`. | Tạo phiếu và 2 chi tiết; hệ số 1,50. Danh sách cũng chấp nhận dấu `;`. |
| 14 | **Khen thưởng – kỷ luật**: tạo `KT_TEST01`, cá nhân `NV_TEST01`, để trống mã PB, 500.000, loại `Hoàn thành nhiệm vụ`, nội dung `Kiểm tra`. | Lưu QĐ. Thử nhập cả mã NV và mã PB hoặc để trống cả hai sẽ bị từ chối. |
| 15 | Tạo kỷ luật `KL_TEST01`, cá nhân `NV_TEST01`, ngày 26/10/2026, phạt 100.000, cách thu `TRU_LUONG`, nội dung/hình thức `Vi phạm nội quy`. | Lưu QĐ, `DaXuLy = 0`, được đưa vào tính lương. |
| 16 | **Bảng lương – thống kê**: chọn tháng 10, năm 2026, nhập người lập, bấm **Tính Bảng Lương**. | Tạo `BL202610`, có 8 chi tiết nếu đã làm đủ các ca trên (7 NV chính thức mẫu + NV thử nghiệm vừa ký HĐ). Chọn dòng bảng lương để xem chi tiết. |
| 17 | Bấm tính lại tháng 10/2026. | Bị từ chối do trùng mã/kỳ lương; không tạo thêm bảng lương. |
| 18 | Chọn tháng 1/2027 và tính lương, khi chưa thêm cấu hình cho kỳ này. | Thông báo `Chưa có cấu hình kỳ lương.` |

Để đối chiếu lương mẫu độc lập với chuỗi nhập thử, khởi tạo lại CSDL theo bước 2 rồi **chỉ tính tháng 10/2026**. Kỳ vọng `BL202610` có 7 nhân viên. Với `NV001`: lương cơ bản 13.000.000; 17 bản ghi đi làm đến 23/10; tổng giờ phụ trội quy đổi 9; phụ cấp lương 1.000.000; phụ cấp chức vụ 500.000; bảo hiểm 1.235.000; kỷ luật 100.000; thực lĩnh khoảng **10.875.227,27 đồng** theo công thức hiện tại. Đây là kết quả tính đối chiếu từ script/mã nguồn, chưa phải kết quả chạy thực tế. Tháng 10 chưa có đủ chấm công cả tháng.

Có thể kiểm tra bản ghi mới bằng SQL:

```sql
SELECT * FROM dbo.NhanVien WHERE MaNV = 'NV_TEST01';
SELECT * FROM dbo.HopDongLaoDong WHERE SoHD = 'HD_TEST01';
SELECT * FROM dbo.HoSoBaoHiem WHERE SoHD = 'HD_TEST01';
SELECT * FROM dbo.ChiTietKeHoachTuan WHERE MaKH = 'KH_TEST01';
SELECT * FROM dbo.ChiTietPhuTroi WHERE SoPhieu = 'PT_TEST01';
SELECT * FROM dbo.QuyetDinhKyLuat WHERE SoQDKL = 'KL_TEST01';
SELECT * FROM dbo.ChiTietBangLuong WHERE MaBangLuong = 'BL202610';
```

Một số mã/kỳ lương trong bảng test của báo cáo Word không còn khớp dữ liệu mẫu hiện tại, ví dụ `TD004`, `KT002`, `PT002` đã tồn tại và tháng 11/2026 đã có cấu hình. Khi chạy lại, ưu tiên các mã thử nghiệm và điều kiện tại mục này để tránh trùng khóa hoặc kiểm tra sai điều kiện.

## 8. Lỗi gặp phải và cách khắc phục

### 8.1. Lỗi thực tế trong lần kiểm tra

| Lỗi / hiện tượng | Xử lý và trạng thái |
| --- | --- |
| Gọi `msbuild` theo tên không tìm thấy trong PATH của PowerShell thông thường. | Đã tìm MSBuild trong thư mục Visual Studio và gọi bằng đường dẫn đầy đủ; build thành công. Giảng viên có thể dùng Developer PowerShell hoặc Build Solution trong IDE. |
| Kết nối theo `App.config` báo `The target principal name is incorrect. Cannot generate SSPI context.` | Chưa khắc phục trong lần kiểm tra. Cần xác nhận tên máy/instance, tài khoản Windows và quyền CSDL; thử kết nối SSMS trên cùng máy. Với SQL cục bộ, cấu hình tên instance cục bộ đúng thay cho tên máy cũ; nếu vẫn lỗi SSPI, cần kiểm tra cấu hình xác thực/SPN của môi trường. |
| `sqlcmd` báo `Encryption not supported on the client`, lỗi SSL và không thiết lập được kết nối. | Chưa xác nhận nguyên nhân cuối cùng. Kiểm tra driver ODBC, thiết lập mã hóa và instance; thử SSMS để tách lỗi công cụ với lỗi máy chủ. Không coi việc bật `TrustServerCertificate` là đã giải quyết lỗi SSPI. |

### 8.2. Tình huống có thể gặp khi chạy lại

Các mục dưới đây là hướng dẫn xử lý theo cấu hình và ràng buộc trong mã nguồn, không phải toàn bộ đều đã phát sinh khi kiểm tra.

| Hiện tượng | Nguyên nhân / cách xử lý |
| --- | --- |
| Không tìm thấy .NET Framework 4.7.2 hoặc lỗi MSB3644 | Cài Developer Pack/Targeting Pack 4.7.2 và workload .NET desktop development, sau đó build lại. |
| `Server not found`, không nạp được danh mục | Bật đúng dịch vụ SQL Server, dùng tên instance đã kết nối SSMS thành công, kiểm tra `Data Source`. |
| `Cannot open database` / `Invalid object name` | Chạy đầy đủ script trên cùng instance; kiểm tra `Initial Catalog=QuanLyNhanSuDongA` và quyền tài khoản. |
| Trùng khóa chính / UNIQUE | Dùng mã mới; chấm công không trùng NV/ngày/ca; bảng lương chỉ có một bản cho tháng/năm. Chỉ khởi tạo lại CSDL khi chấp nhận xóa dữ liệu thử. |
| Vi phạm khóa ngoại | Dùng mã NV, PB, ca, hợp đồng đã tồn tại; thực hiện tạo dữ liệu cha trước dữ liệu con. |
| Tỷ lệ bảo hiểm bị CHECK từ chối | Nhập tỷ lệ trong khoảng 0–1, ví dụ 0,015 cho 1,5%, không nhập 1,5 hoặc 15. |
| Không ký được hợp đồng | Ngày bắt đầu phải lớn hơn ngày kết thúc thử việc mới nhất của nhân viên. |
| Không tạo được kế hoạch / phân công | Ngày kết thúc cách ngày bắt đầu đúng 6 ngày; ngày phân công phải nằm trong tuần. |
| Chưa có cấu hình kỳ lương | Bổ sung bản ghi hợp lệ vào `CauHinhTinhLuong` bằng SSMS; giao diện hiện chưa hỗ trợ cấu hình. |
| Chữ hoặc vùng nhập bị lệch khi đổi DPI | Mã nguồn có `SetProcessDPIAware`, `AutoScaleMode.Dpi` và `FormLayout.Apply` để bố trí lại phần nhập; nếu còn khó hiển thị, kiểm tra ở mức scale Windows 100% và dùng thanh cuộn của form. Chưa kiểm chứng mọi độ phân giải. |

Một số thao tác ghi dữ liệu chưa bắt toàn bộ ngoại lệ SQL ở form/service; dữ liệu vi phạm ràng buộc có thể hiện hộp lỗi ngoại lệ thay vì thông báo nghiệp vụ. Khi kiểm tra, ghi lại thao tác, dữ liệu đầu vào và thông báo cụ thể; các ca kiểm tra dương nên thực hiện trước ca cố ý nhập sai.
