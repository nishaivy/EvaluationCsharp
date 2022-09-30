using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ques_9
{
   
delegate bool isPromote(Employee emp);
class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int salary { get; set; }
    public float Experiance { get; set; }


    public static void PromoteEmp(List<Employee> EmployeeList, isPromote IsEligible)
    {
        foreach (Employee emp in EmployeeList)
        {
            if (IsEligible(emp))  
            {
                Console.WriteLine(emp.Name + " Promoted");
            }
        }
    }
        public static bool promote(Employee emp)
        {
            if (emp.Experiance >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main()
        {
            List<Employee> empl = new List<Employee>();
            empl.Add(new Employee() { ID = 101, Name = "Nisha",salary = 40000, Experiance = 6 });
            empl.Add(new Employee() { ID = 101, Name = "Ravi", salary = 20000, Experiance = 3 });
            empl.Add(new Employee() { ID = 102, Name = "John", salary = 30000, Experiance = 5 });
            empl.Add(new Employee() { ID = 103, Name = "Mery", salary = 50000, Experiance = 8 });
            empl.Add(new Employee() { ID = 104, Name = "Mike", salary = 10000, Experiance = 2 });

            isPromote pro = new isPromote(promote);
            Employee.PromoteEmp(empl, pro);
        }
    }  


}
