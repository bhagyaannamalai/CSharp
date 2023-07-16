using System;
//Delegates and multicast delegate
public delegate int calculation(int x,int y);
//multicast delegate
public delegate void myDelegate();
public class Program
{
    static void Main(string[] args)
    {
maths obj = new maths();
calculation calc;
calc=obj.Add;
int result=calc(2,3);
Console.WriteLine("Add: " + result);
calc = obj.subtract;
result=calc(4,2);
Console.WriteLine("Subtract: " + result);

myDelegate multidel = obj.method1;
multidel+=obj.method2;
multidel();


    }
}

//Class Maths
public class maths
{
    public int Add(int x, int y)
    {
        return x+y;
    }
    public int subtract(int x,int y)
    {
        return x-y;
    }
    public void method1()
    {
        Console.WriteLine("I am Method 1");
    }
    public void method2()
    {
        Console.WriteLine("I am Method 2");
    }
}