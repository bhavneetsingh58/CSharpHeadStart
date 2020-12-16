using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessions
{
    class Crud
    {
        public static List<Employee> emplist = new List<Employee>()
        {
            new Employee(){EmpID=101,Name="Bhavneet",Dept="Dev"},
            new Employee(){EmpID=102,Name="Singh",Dept="Admin"},
            new Employee(){EmpID=103,Name="Sachdev",Dept="HR"}
        };

        public static void Add()
        {
            Employee emp = new Employee();
            Console.WriteLine("ENter id,name,dept of new EMployee");
            emp.EmpID = int.Parse(Console.ReadLine());
            emp.Name = Console.ReadLine();
            emp.Dept = Console.ReadLine();
        }

        public void Display()
        {
            foreach(var em in emplist)
            {
                Console.WriteLine("{0} {1} {2}", em.EmpID, em.Name, em.Dept);
            }
        }

        public void remove(int input)
        {
            foreach (var em in emplist)
            {
                if (em.EmpID == input) {
                    emplist.Remove(em);
                    return ;
                         }
            }
        }
        public static void main()
        {
            Crud c1 = new Crud();
            c1.Display();
            Console.WriteLine("------------------------------------");
            c1.remove(103);
            Console.WriteLine("------------------------------------");
            c1.Display();
        }
    }
}
