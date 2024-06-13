using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPractice
{
    class Employee
    {
        private DateTime experience=DateTime.MinValue; 
        public string Name;
        public int Age;
        public Role Role;
        public int Salary;
        public string MarriageStatus;
        public DateTime JoinDateTime;
        public DateTime Experience{
        set{
                experience = value;
        }
        get{
                if(experience.Year!= (DateTime.Now.Year - JoinDateTime.Year)&& experience.Month!=(DateTime.Now.Month - JoinDateTime.Month)&& experience.Day != (DateTime.Now.Day - JoinDateTime.Day))
                Experience= new DateTime(DateTime.Now.Year - JoinDateTime.Year, DateTime.Now.Month - JoinDateTime.Month, DateTime.Now.Day - JoinDateTime.Day);
                return Experience; 
        }
        }
        public  Gender Gender;
        public Employee(string name,int age,Role role,int salary,string marriageStatus,DateTime joinDateTime,Gender gender){
            Name = name;
            Age = age;
            Role = role;
            Salary = salary;
            MarriageStatus = marriageStatus;
            JoinDateTime = joinDateTime;
            Experience =new DateTime( DateTime.Now.Year - JoinDateTime.Year,DateTime.Now.Month-JoinDateTime.Month,DateTime.Now.Day-JoinDateTime.Day);
            Gender = gender;
        }
    }
}
