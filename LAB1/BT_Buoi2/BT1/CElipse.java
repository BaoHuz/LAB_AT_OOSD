public class CElipse extends CHinhVe {
    protected float CDiemTam;
    protected float A;
    protected float B;
    
    public CElipse(float CDiemTam, float A, float B){
        this.CDiemTam = CDiemTam;
        this.A = A;
        this.B = B;
    }
    
    @Override 
    public float DienTich(){
        return (float) (Math.PI * A * B);
    }
    
    @Override 
    public float ChuVi(){
        return (float) (Math.PI * (3 * (A + B) - Math.sqrt((3 * A + B) * (A + 3 * B))));
    }
    
    @Override 
    public void Ve(){
        System.out.println(String.format("Ve Elipse voi tam: %.1f, ban truc A: %.1f, ban truc B: %.1f", CDiemTam, A, B));
    }
}