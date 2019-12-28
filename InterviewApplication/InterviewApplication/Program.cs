using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Infoway Interview Application!");
            try
            {
                Student obj = new Student();
                obj.Selected += new InterviewDelegate(OracleDB);
                obj.Selected += MySqlDB;
                obj.Rejected += SqlServer;
                obj.StudentId = 3489;
                obj.StudentName = "Pravinkumar R. D.";
                obj.City = "Pune";
                obj.Phone = "+91 23893829";
                obj.TotalMarks = 99;
                if (obj.TotalMarks<=95)
                {
                    obj.Selected -= MySqlDB;
                }
                Console.WriteLine("Student Id is {0}", obj.StudentId);
                bool result=false;
                Console.WriteLine("Your result is {0}", obj.CalculateResult(obj.TotalMarks,ref result));
                Console.WriteLine(result)
;            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception - {0}", ex.Message);
            }
            Console.ReadKey();
        }
        private static void OracleDB()
        {
            Console.WriteLine("Student record stored in Oracle DB!");
        }
        private static void MySqlDB()
        {
            Console.WriteLine("Student record stored in MySql DB!");
        }
        private static void SqlServer()
        {
            Console.WriteLine("Student record stored in Sql Server DB!");
        }
    }
}
