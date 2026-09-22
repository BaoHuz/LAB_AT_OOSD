\# BÁO CÁO BÀI TẬP LAB 1



\## 📌 Thông tin sinh viên

\- \*\*Họ và tên:\*\* Nguyễn Hữu Bảo

\- \*\*Mã sinh viên:\*\* 1250080016

\- \*\*Lớp:\*\* 12\_ĐH\_CNPM1

\- \*\*Môn học:\*\* Phương pháp phát triển phần mềm hướng đối tượng  (Buổi 2 - LAB 1)



\---



\## 📂 Cấu trúc thư mục



```text

LAB1/

├── BT1/

│   ├── CElipse.java

│   ├── CHinhVe.java

│   ├── CTamGiac.java

│   ├── CTuGiac.java

│   └── Program.java

├── BT2/

│   ├── 1250080016\_NguyenHuuBao\_12\_H\_CNPM1\_LAB1\_Buoi2.docx

│   └── LAB1\_Dac\_ta\_yeu\_cau\_use\_case.pdf

└── README.md



\---



\## 🛠️ Nội dung thực hiện



\### \*\*Bài tập 1 (BT1) - Lập trình Hướng đối tượng với Java\*\*

\- \*\*Mục tiêu:\*\* Xây dựng hệ thống lớp hình vẽ minh họa tính kế thừa và đa hình trong lập trình hướng đối tượng.

\- \*\*Các lớp chính:\*\*

&#x20; - `CHinhVe.java`: Lớp cơ sở trừu tượng (`abstract class`) định nghĩa các phương thức `DienTich()`, `ChuVi()`, `Ve()`.

&#x20; - `CTamGiac.java`: Lớp con kế thừa từ `CHinhVe`, tính chu vi và diện tích tam giác theo công thức Heron.

&#x20; - `CTuGiac.java`: Lớp con kế thừa từ `CHinhVe`, quản lý thông tin và tính chu vi hình tứ giác.

&#x20; - `CElipse.java`: Lớp con kế thừa từ `CHinhVe`, tính chu vi và diện tích hình Elipse dựa vào bán trục $A$ và $B$.

&#x20; - `Program.java`: Lớp chứa hàm `main` khởi tạo các đối tượng hình vẽ, thực hiện vẽ và xuất thông số chu vi, diện tích.



\### \*\*Bài tập 2 (BT2) - Phân tích \& Đặc tả Yêu cầu Use Case\*\*

\- \*\*Mục tiêu:\*\* Báo cáo phân tích và đặc tả các yêu cầu Use Case theo tài liệu hướng dẫn.

\- \*\*Tập tin đính kèm:\*\*

&#x20; - `1250080016\_NguyenHuuBao\_12\_H\_CNPM1\_LAB1\_Buoi2.docx`: Báo cáo chi tiết kết quả thực hiện.

&#x20; - `LAB1\_Dac\_ta\_yeu\_cau\_use\_case.pdf`: Tài liệu đặc tả yêu cầu Use Case gốc.



\---



\## 🚀 Hướng dẫn biên dịch và chạy chương trình (BT1)



\### 1. Biên dịch các file Java

Mở terminal tại thư mục `LAB1/BT1` và chạy lệnh:

javac \*.java



\### 2. Chạy chương trình

Chạy hàm main trong file Program:

java Program

