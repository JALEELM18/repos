class Myclass
{
    enum Grade { pass = 60, Distinction = 85 };

    public static void Main()
    {
        int empid;
        int mark;

        Console.WriteLine("wHAT'S YOUR EMPID?");
        empid = int.Parse(Console.ReadLine());
        Console.WriteLine("Hello,World!");
        Console.WriteLine($"tHANKS for giving empid{empid}");

        Console.WriteLine("Enter your TSQL marks");
        mark = Convert.ToInt32(Console.ReadLine());
        if (mark >= (int)Grade.Distinction)
        {
            Console.WriteLine("You are in Distinction grade");
        }
        else if (mark >= (int)Grade.pass)
        {
            Console.WriteLine("You are in pass grade");
        }
        else
        {
            Console.WriteLine("sorry, your grade is FAIL");
        }
    }
}