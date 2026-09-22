public class CTamGiac extends CHinhVe {
    protected float CDiemP1;
    protected float CDiemP2;
    protected float CDiemP3;
    public CTamGiac(float CDiemP1, float CDiemP2, float CDiemP3){
        this.CDiemP1 = CDiemP1;
        this.CDiemP2 = CDiemP2;
        this.CDiemP3 = CDiemP3;
    }
    @Override 
    public float DienTich(){
        float p = (CDiemP1 + CDiemP2 + CDiemP3) / 2;
        return (float) Math.sqrt(p * (p - CDiemP1) * (p - CDiemP2) * (p - CDiemP3));
    }
    @Override 
    public float ChuVi(){
        return CDiemP1 + CDiemP2 + CDiemP3;
    }
    @Override 
    public void Ve(){
        System.out.println(String.format("Ve tam giac voi 3 canh: %.1f, %.1f, %.1f", CDiemP1, CDiemP2, CDiemP3));
    }
}
