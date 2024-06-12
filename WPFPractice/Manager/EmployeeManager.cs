using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPractice
{
    public enum Role
    {
        Manager,
        HumanResource,
        SeniorDeveloper,
        JuniorDeveloper,
        Tester,
        ImageProcessing,
        Intern
    }
    public enum Degree
    {
       BA,MA,MBA,BSC,MSC,BE,ME,MTech,BTech,BCA,MCA, Diploma,Other
    }
    public enum Gender
    {
        Male,
        Female,
        Other
    }
  
    public class EnumHelper
    {
        public static List<string> ConvertEnumToList<T>()
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("T must be an enumerated type");

            return Enum.GetNames(typeof(T)).ToList();
        }
    }

    public static class EmployeeManager
    {
        public static List<string> RoleSource = Enum.GetNames(typeof(Role)).ToList();
        public static List<string> GenderSource = Enum.GetNames(typeof(Gender)).ToList();
        private static double textFontSize = 16;
        public static double TextFontSize
        {
            get
            {
                return textFontSize;
            }
            set
            {
                if (value >= 10)
                {
                    textFontSize = value;
                }
            }
        }
        public static void CreateEmployeeTable()
        {
            string tableQuery = $"Create Table Employee(Id int auto_increment,EmployeeId varchar(100),Name varchar(100),Age int,Gender varchar(100),MarriageStatus varchar(100),Salary int,Joindate DateTime,PhoneNumber varchar(100) ,Email varchar(100),IsExEmployee TINYINT)";
        }
        public static void CreateEmployee(Employee employee)
        {
            String employeeCreateQuery = $"";
        }
    }
}
