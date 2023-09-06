using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

class MyClass
{
    public int code;
    public char symb;
    public MyClass(int n,char s)
    {
        code = n;
        symb = s;
    }
    public override int GetHashCode()
    {

        return code ^ symb;
        
    }
    public override bool Equals(Object obj)
    {
        MyClass t = (MyClass)obj;
        if (code == t.code && symb == t.symb) return true;
        else return false;
    }
    public static bool operator==(MyClass a,MyClass b)
    {
        return a.Equals(b);
    }
    public static bool operator!=(MyClass a,MyClass b)
    {
        return !(a == b);
    }
   
}
class OverridingEqualsDemo
{
    static void Main()
    {
        MyClass A = new MyClass(100, 'A');
        MyClass B = new MyClass(100, 'B');
        MyClass C = new MyClass(200, 'A');
        MyClass D = new MyClass(100, 'A');
        Console.WriteLine("Hash-code A:  {0}", A.GetHashCode());
        Console.WriteLine("Hash-code B:  {0}", B.GetHashCode());
        Console.WriteLine("Hash-code C:  {0}", C.GetHashCode());
        Console.WriteLine("Hash-code D:  {0}", D.GetHashCode());

        Console.WriteLine("A==B daet {0}", A == B);
        Console.WriteLine("A!=B daet {0}", A != B);
        Console.WriteLine("A==C daet {0}", A == C);
        Console.WriteLine("A!=C daet {0}", A != C);
        Console.WriteLine("A==D daet {0}", A == D);
        Console.WriteLine("A!=D daet {0}", A != D);
    }
}