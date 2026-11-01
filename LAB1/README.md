# BÁO CÁO BÀI TẬP LAB 1

## 📌 Thông tin sinh viên

- **Họ và tên:** Nguyễn Hữu Bảo
- **MSSV:** 1250080016
- **Lớp:** 12_ĐH_CNPM1
- **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng
- **Bài thực hành:** Buổi 2 - LAB 1

---

## 📂 Cấu trúc thư mục

```text
LAB1/
├── BT_Buoi2/
│   ├── BT1/
│   │   ├── CElipse.java
│   │   ├── CHinhVe.java
│   │   ├── CTamGiac.java
│   │   ├── CTuGiac.java
│   │   └── Program.java
│   │
│   └── BT2/
│       ├── 1250080016_NguyenHuuBao_12_ĐH_CNPM1_LAB1_Buoi2.docx
│       ├── LAB1_Dac_ta_yeu_cau_use_case.pdf
│       └── LAB1_BT2.drawio
│
└── README.md
```

---

## 🛠️ Nội dung thực hiện

### Bài tập 1 (BT1) - Lập trình hướng đối tượng với Java

**Mục tiêu:** Xây dựng hệ thống lớp hình vẽ nhằm minh họa các đặc trưng kế thừa, trừu tượng và đa hình trong lập trình hướng đối tượng.

Các lớp chính:

- `CHinhVe.java`: Lớp cơ sở trừu tượng của các loại hình vẽ, cung cấp thuộc tính mã loại hình và các hành vi tính diện tích, chu vi và vẽ hình.
- `CTamGiac.java`: Kế thừa `CHinhVe`, lưu thông tin ba cạnh, tính chu vi và diện tích theo công thức Heron.
- `CTuGiac.java`: Kế thừa `CHinhVe`, lưu thông tin bốn cạnh và tính chu vi tứ giác. Phần diện tích hiện chưa được xác định do chưa đủ dữ liệu hình học để tính diện tích một tứ giác bất kỳ.
- `CElipse.java`: Kế thừa `CHinhVe`, tính diện tích và chu vi gần đúng của ellipse dựa trên hai bán trục `A`, `B`.
- `Program.java`: Chứa hàm `main`, khởi tạo các đối tượng thông qua kiểu `CHinhVe` để minh họa tính đa hình và hiển thị kết quả.

### Bài tập 2 (BT2) - Phân tích và đặc tả yêu cầu Use Case

**Mục tiêu:** Phân tích yêu cầu của hệ thống thư viện trực tuyến, xác định Actor, Use Case, đặc tả luồng xử lý và biểu diễn các Use Case bằng Activity Diagram.

Nội dung đã thực hiện:

- Xác định yêu cầu chức năng của hệ thống.
- Xây dựng bảng thuật ngữ.
- Xác định Actor và các Use Case.
- Xây dựng Use Case Model tổng quan.
- Đặc tả các Use Case.
- Xây dựng Activity Diagram tương ứng với các Use Case.

Các tập tin:

- `1250080016_NguyenHuuBao_12_ĐH_CNPM1_LAB1_Buoi2.docx`: Báo cáo bài làm.
- `LAB1_Dac_ta_yeu_cau_use_case.pdf`: Đề bài/tài liệu hướng dẫn của giảng viên.
- `LAB1_BT2.drawio`: Các Activity Diagram được sử dụng trong báo cáo.

---

## 🚀 Hướng dẫn biên dịch và chạy BT1

Yêu cầu:

- JDK đã được cài đặt.
- Có thể sử dụng Command Prompt, PowerShell hoặc Terminal.

Di chuyển đến:

```text
LAB1/BT_Buoi2/BT1
```

Biên dịch:

```bash
javac *.java
```

Chạy:

```bash
java Program
```

Kết quả chương trình sẽ hiển thị thông tin vẽ hình, chu vi và diện tích của tam giác, tứ giác và ellipse.

---

## ✅ Kết quả

- Các file Java biên dịch thành công.
- Chương trình minh họa được cơ chế kế thừa và đa hình thông qua lớp cha `CHinhVe`.
- Tam giác tính được chu vi và diện tích.
- Tứ giác tính được chu vi; phần diện tích hiện chưa đủ dữ liệu hình học để xác định tổng quát.
- Ellipse tính được chu vi gần đúng và diện tích.
- BT2 đã thực hiện phân tích và đặc tả Use Case của hệ thống thư viện trực tuyến cùng các Activity Diagram tương ứng.

## ⚠️ Lưu ý

Để tính chính xác diện tích tứ giác, cần biết thêm đặc điểm hình học của tứ giác hoặc tọa độ các đỉnh; chỉ bốn độ dài cạnh chưa đủ để xác định duy nhất diện tích.