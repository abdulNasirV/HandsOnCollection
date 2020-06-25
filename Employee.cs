using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HandsOnCollections
{
    public class Employee : IComparable<Employee>
    {
        private int empId;
        private string empName;
        private int empAge;

        public Employee(int empId, string empName, int empAge)
        {
            this.empId = empId;
            this.empName = empName;
            this.empAge = empAge;
        }

        public string GetEmployeeName()
        {
            return empName;
        }

        public void SetEmployeeName(string empName)
        {
            this.empName = empName;
        }

        public int GetEmployeeID()
        {
            return empId;
        }

        public void SetEmployeeID(int empId)
        {
            this.empId = empId;
        }

        public int GetEmployeeAge()
        {
            return empAge;
        }
        public void SetEmployeeAge(int empAge)
        {
            this.empAge = empAge;
        }

        public int CompareTo(Employee obj)
        {
            return empAge.CompareTo(obj.empAge);

        }



        public static void Main(string[] args)
        {
            List<Employee> listOfemployees = new List<Employee>();
            listOfemployees.Add(new Employee(100, "John", 30));
            listOfemployees.Add(new Employee(600, "Rohsan", 42));
            listOfemployees.Add(new Employee(30, "Rohan", 41));
            listOfemployees.Add(new Employee(50, "Kaif", 10));
            listOfemployees.Add(new Employee(500, "Raj", 50));

            listOfemployees.Sort();
            foreach (var emp in listOfemployees)
            {
                Console.WriteLine(emp.GetEmployeeAge());
            }
        }
    }
}