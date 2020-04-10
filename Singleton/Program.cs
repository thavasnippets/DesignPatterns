using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(() => StudentDetails(),
                () => EmployeeDetails());

            Console.ReadKey();
        }

        private static void EmployeeDetails()
        {
            clsSingleTon _employeeDetails = clsSingleTon.getInstance;
            _employeeDetails.printValue("Employee");
        }

        private static void StudentDetails()
        {
            clsSingleTon _studentDetails = clsSingleTon.getInstance;
            _studentDetails.printValue("Student");
        }
    }
}
