namespace Doanhnghiep;

public class DoanhNghiep
{
    private string tendn, mst, diachi;
    public string TenDN
    {
        get {return tendn;}
        set {tendn = value;}
    }
    public string MST
    {
        get {return mst;}
        set {mst = value;}
    }
    public string Diachi 
    {
        get {return diachi;}
        set {diachi = value;}
    }
    public DoanhNghiep()
    {
        Console.Write("Nhap ten DN: ");
        TenDN = Console.ReadLine();
        Console.Write("Nhap ma so thue: ");
        MST = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        Diachi = Console.ReadLine();
        Console.WriteLine();           
    }
}
public class DanhsachDN
{
    public List<DoanhNghiep> List_DN;
    public DanhsachDN()
    {
        List_DN = new List<DoanhNghiep>();
        DoanhNghiep A = new DoanhNghiep();
        List_DN.Add(A);

        DoanhNghiep B = new DoanhNghiep();
        List_DN.Add(B);

        DoanhNghiep C = new DoanhNghiep();
        List_DN.Add(C);

        DoanhNghiep D = new DoanhNghiep();
        List_DN.Add(D);
    }
    public void Xuat()
    {
        foreach (var dn in List_DN)
        {
            Console.WriteLine("Ten doanh nghiep: {0}",dn.TenDN);
            Console.WriteLine("Ma so thue: {0}",dn.MST);
            Console.WriteLine("Dia chi: {0}",dn.Diachi);
            Console.WriteLine("---------------------------------");
        }
    }
    public void Tim_MST()
    {
        Console.Write("Nhap ten DN muon tim: ");
        string tim_mst = Console.ReadLine();
        for (int i = 0; i < List_DN.Count; i++) //List_DN.Count: Số lượng doanh nghiệp
        {
            if (List_DN[i].TenDN == tim_mst)
            {
                Console.WriteLine("Doanh nghiep {0} co ma so thue: {1}",List_DN[i].TenDN,List_DN[i].MST);
                Console.WriteLine();
                break;
            }
        }
    }
    public void Tim_Ten_DC()
    {
        Console.Write("Nhap ma so thue muon tim: ");
        string tim_ten_dc = Console.ReadLine();
        for (int i = 0; i < List_DN.Count; i++)
        {
            if ( List_DN[i].MST == tim_ten_dc)
            {
                Console.WriteLine("Doanh nghiep co ma {0} co ten {1} o dia chi {2}",List_DN[i].MST, List_DN[i].TenDN, List_DN[i].Diachi);
                Console.WriteLine();
                break;
            }
        }
    }
}
class Program
{
    static void Main()
    {
        DanhsachDN doanh_nghiep = new DanhsachDN();
        doanh_nghiep.Xuat();
        doanh_nghiep.Tim_MST();
        doanh_nghiep.Tim_Ten_DC();
    }
}

