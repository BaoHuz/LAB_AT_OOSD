public class CTuGiac extends CHinhVe {
    protected float CDiemP1;
    protected float CDiemP2;
    protected float CDiemP3;
    protected float CDiemP4;
    public CTuGiac(float CDiemP1, float CDiemP2, float CDiemP3, float CDiemP4){
        this.CDiemP1 = CDiemP1;
        this.CDiemP2 = CDiemP2;
        this.CDiemP3 = CDiemP3;
        this.CDiemP4 = CDiemP4;
    }
    @Override 
    public float DienTich(){
        return 0;
    }
    @Override 
    public float ChuVi(){
        return CDiemP1 + CDiemP2 + CDiemP3 + CDiemP4;
    }
    @Override 
    public void Ve(){
        System.out.println(String.format("Ve tu giac voi 4 canh: %.1f, %.1f, %.1f, %.1f", CDiemP1, CDiemP2, CDiemP3, CDiemP4));
    }
}
