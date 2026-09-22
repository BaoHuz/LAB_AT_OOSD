public class Program {
    public static void main(String[] args) {
        CHinhVe tamGiac = new CTamGiac(3.0f, 4.0f, 5.0f);
        System.out.println("Hinh Tam giac");
        tamGiac.Ve();
        System.out.println("Chu vi: " + tamGiac.ChuVi());
        System.out.println("Dien tich: " + tamGiac.DienTich());

        System.out.println();


        CHinhVe tuGiac = new CTuGiac(2.0f, 3.0f, 4.0f, 5.0f);
        System.out.println("Hinh Tu Giac");
        tuGiac.Ve();
        System.out.println("Chu vi: " + tuGiac.ChuVi());
        System.out.println("Dien tich: " + tuGiac.DienTich());

        System.out.println();


        CHinhVe elipse = new CElipse(0.0f, 3.0f, 5.0f);
        System.out.println("Hinh Elipse");
        elipse.Ve();
        System.out.println("Chu vi : " + elipse.ChuVi());
        System.out.println("Dien tich: " + elipse.DienTich());
    }
}