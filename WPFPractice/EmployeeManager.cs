using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPractice
{
public enum Role{
       Manager,
       HumanResource,
       SeniorDeveloper,
       JuniorDeveloper,
       Tester,
       ImageProcessing,
       Intern
}
public enum Gender{
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
        public static List<string> RoleSource =Enum.GetNames(typeof(Role)).ToList();
        public static List<string> GenderSource=Enum.GetNames(typeof(Gender)).ToList();

    }
}
