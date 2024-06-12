using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPractice
{
    public class Employee
    {
        private int Id;
        public string EmployeeId;
        private DateTime experience=DateTime.MinValue; 
        public string Name;
        public int Age;
        public Role Role;
        public int Salary;
        public string MarriageStatus;
        public DateTime JoinDateTime;
        public string PhoneNumber;
        public string Email;
        public DateTime DateOfBirth;
        public string Address;
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
        public Employee(string employeeId,string name,int age, Gender gender, Role role,int salary,string marriageStatus,DateTime joinDateTime,string phoneNumber,string email){
            EmployeeId = employeeId;
            Name = name;
            Age = age;
            Gender = gender;
            Role = role;
            Salary = salary;
            MarriageStatus = marriageStatus;
            JoinDateTime = joinDateTime;
            Experience =new DateTime( DateTime.Now.Year - JoinDateTime.Year,DateTime.Now.Month-JoinDateTime.Month,DateTime.Now.Day-JoinDateTime.Day);
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
