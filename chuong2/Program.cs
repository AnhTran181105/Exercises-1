internal class Test
{
    public static void Main()
    {
        //Q1();
        //Q2();
        //Q3();
        //Q4();
        //Q5();
        //Q6();
        //Q7();
        Q10();

        Console.ReadKey();
    }
    public static void Q1()
    {
        Console.Write("a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b:");
        int b = int.Parse(Console.ReadLine());
        int c = a + b;
        Console.WriteLine($"{a}+{b}={c}");
    }
    public static void Q2()
    {
        Console.Write("a:");
        string a = Console.ReadLine();
        Console.Write("b:");
        string b = Console.ReadLine();
        string c = b;
        b = a;
        a = c;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
    public static void Q3()
    {
        Console.Write("a:");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b:");
        float b = float.Parse(Console.ReadLine());
        float c = a * b;
        Console.WriteLine($"{a}*{b}={c}");
    }
    public static void Q4()
    {
        Console.Write("Nhap so feet:");
        float a = float.Parse(Console.ReadLine());
        float c = (float)(a * 0.3048);
        Console.WriteLine($"{c}meters");
    }
    public static void Q5()
    {
        Console.Write("Nhap so do:");
        double a = double.Parse(Console.ReadLine());
        double c = (a - 32) * (1.8);
        double f = (a / 1.8) +32;
        Console.WriteLine($"Tu {a} do C sang F:{f}");
        Console.WriteLine($"Tu {a} do F sang C:{c}");
    }
    public static void Q6()
    {
        int a = sizeof(int);
        Console.WriteLine(a);
    }
    public static void Q7()
    {
        Console.Write("Nhap ki tu:");
        char a = char.Parse(Console.ReadLine());
        int b = (int)a;
        Console.WriteLine(b);
    }
    public static void Q8()
    {
        Console.Write("Nhap ban kinh:");
        double a = double.Parse(Console.ReadLine());
        double s = Math.Pow(a, 2) * Math.PI;
        Console.WriteLine($"Dien tich:{s}");
    }
    public static void Q9()
    {
        Console.Write("Nhap chieu dai canh:");
        double a = double.Parse(Console.ReadLine());
        double s = Math.Pow(a, 2);
        Console.WriteLine($"Dien tich:{s}");
    }
    public static void Q10()
    {
        Console.Write("Nhap số ngày:");
        int so_ngay = int.Parse(Console.ReadLine());
        int nam = so_ngay / 365;
        int tuan = (so_ngay - nam * 365) / 7;
        int ngay = so_ngay - nam * 365 - tuan * 7;
        Console.WriteLine($"{nam} Nam,{tuan} Tuan, {ngay} Ngay");
    }
}