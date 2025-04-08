using Tutorial3.Models;

namespace Tutorial3;

public class Program
{
    public static void Main(string[] args)
    {
        var emps = Database.GetEmps();
        var depts = Database.GetDepts();
        var grades = Database.GetSalgrades();

        decimal? minSalary = emps.Where(e => e.DeptNo == 30).Select(e => e.Sal).Min();

        Console.WriteLine(minSalary.ToString());
    }
}