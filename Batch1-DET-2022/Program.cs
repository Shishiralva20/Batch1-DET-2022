/*public class returnAge
{
    public static int age(DateTime dob)
    {
        int CurrentYear = DateTime.Now.Year;
        int C = DateTime.Now.Month;
        return CurrentYear - dob.Year;

    }

    public static void Main()
    {


        DateTime date = DateTime.Parse(Console.ReadLine());
        int res = (age(date)); ;
        Console.WriteLine($"your age is{res}");
    }
}*/





/*

// See https://aka.ms/new-console-template for more information
using Batch1_DET_2022;
using System.Data;

class MyClass
{
    enum Grade { Pass = 60, Distinction = 85 };
    /// <summary>
    /// method that returns Grade based on the mark
    /// </summary>
    /// <param name="mark">mark as the input</param>
    /// <returns></returns>
    public static string GetGrade(int mark) //IN parameter
    {
        if (mark >= (int)Grade.Distinction)
            return "Distinction";
        else if (mark >= (int)Grade.Pass)
            return "PASS";
        else
            return "FAIL";
    }
    public static void Main()
    {
        try
        {
            Emp m = new Manager(4671, "Karthika", new DateTime(2005, 5, 10), "techtrng", 10);  //default constructor
                                                                                               // Console.WriteLine(m.Print());

            Emp m1 = new Manager(2345, "Jeeva", new DateTime(2010, 1, 14), "PEMS", 450);
            // Console.WriteLine(m1.Print());  //base class ref can point to derived object

            Emp e1 = new Emp(1, "Jiyana", new DateTime(2020, 1, 5));
            //Console.WriteLine(e1.Print());

            Console.WriteLine("enter empid b.w 1001 - 25000");
            int id = Convert.ToInt32(Console.ReadLine());
            if (id < 1001 || id > 25000)
                throw new InvalidEmpIdException("Entered empid is not in the range...");

            Console.WriteLine("enter emp name");
            string name = Console.ReadLine();

            Console.WriteLine("enter doj");
            DateTime doj = DateTime.Parse(Console.ReadLine());

            Emp e2 = new(id, name, doj);


            List<Emp> list = new List<Emp>();
            list.Add(m);
            list.Add(m1);
            list.Add(e1);
            foreach (Emp x in list)
                Console.WriteLine(x.Print());
        }
        catch (InvalidEmpIdException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        { }

        #region "containment"
        CompanyManager m = new CompanyManager { Name = "Balaji", Surname = "R", Phone = "9876543210" };
        Company company = new Company { Name = "SSL", Address = "Global City", Manager = m, Phone = "67781001", Website = "sonata-software.com" };

        Console.WriteLine(company.Print());
        #endregion

        #region "Abstract Types"
        Circ c = new Circ { Radius = 4 };
        Sphere s = new Sphere { Radius = 4 };

        Console.WriteLine(c.Area());
        Console.WriteLine(c.Area());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circ { Radius = 4 });
        shapes.Add(new Circ { Radius = 10 });
        shapes.Add(new Sphere { Radius = 5 });

        foreach (Shape shape in shapes)
            Console.WriteLine()
    }
}*/

