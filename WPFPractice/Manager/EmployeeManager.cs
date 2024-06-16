using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

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
        BA, MA, MBA, BSC, MSC, BE, ME, MTech, BTech, BCA, MCA, Diploma, Other
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
        public static MySqlConnection Connection;
        public static Dictionary<string, Employee> EmployeeDictionary = new Dictionary<string, Employee>();
        public static List<string> RoleSource = Enum.GetNames(typeof(Role)).ToList();
        public static List<string> GenderSource = Enum.GetNames(typeof(Gender)).ToList();
        private static double textFontSize = 16;
        private static string DatabaseName = "employeemanager";
        private static string DatabasePassword = "";
       public static readonly DependencyProperty EmployeeRoleBackgroundColorProperty = DependencyProperty.Register("EmployeeRoleBackGroundColor", typeof(Brush), typeof(EmployeeCard), new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#015C93"))));
        //public static Brush ThemeColor
        //{
        //    set
        //    {
        //        SetValue(EmployeeRoleBackgroundColorProperty,value)
        //    }
        //    get
        //    {

        //    }
        //}

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
        public static MySqlCommand command = new MySqlCommand();
        public static bool EmployeeManagerSetUp()
        {
            DatabaseConnection();
            EmployeeDictionary = GetEmployees();
            //ThemeColor = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#015C93"));
            return true;
        }

        public static bool DatabaseConnection()
        {
            try
            {
                string Connectionstring = $"server=localhost;port=3306;uid=root;pwd={DatabasePassword};database={DatabaseName}";
                Connection = new MySqlConnection(Connectionstring);
                Connection.Open();
                command.Connection = Connection;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void CreateEmployeeTable()
        {
            string tableQuery = $"Create Table Employee(Id int auto_increment PRIMARY KEY,FirstName varchar(100),LastName varchar(100),DateOfBirth DateTime,Age int,Gender varchar(100),MarriageStatus varchar(100),PhoneNumber Varchar(100),Email varchar(100),Address varchar(500),AadharNumber varchar(100),EmployeeId varchar(100),Role varchar(100),salary int,JoinDateTime DateTime ,Degree varchar(100),DegreeSpecification varchar(100),CollageName varchar(100),BankName varchar(100),BankIFSCCode varchar(100),AccountNumber varchar(100),PanCardNumber varchar(100),IsExEmployee TINYINT)";
        }
        public static void CreateEmployee(Employee employee)
        {
            try
            {
                String employeeCreateQuery = $"Insert Into Employee(FirstName,LastName,DateOfBirth,Age,Gender,MarriageStatus,PhoneNumber,Email,Address,AadharNumber,EmployeeId,Role,salary,JoinDateTime ,Degree,DegreeSpecification,CollageName,BankName,BankIFSCCode,AccountNumber,PanCardNumber,IsExEmployee) Values('{employee.FirstName}','{employee.LastName}','{employee.DateOfBirth.ToString("yyyy-MM-dd HH:mm:ss")}' ,{employee.Age},'{employee.Gender}','{employee.MarriageStatus}','{employee.PhoneNumber}','{employee.Email}','{employee.Address}','{employee.AadharNumber}','{employee.EmployeeId}','{employee.Role}',{employee.Salary},'{employee.JoinDateTime.ToString("yyyy-MM-dd HH:mm:ss")}','{employee.Degree}','{employee.DegreeSpecification}','{employee.CollageName}','{employee.BankName}','{employee.BankIFSCCode}','{employee.AccountNumber}','{employee.PanCardNumber}',{employee.IsExEmployee})";
                command.CommandText = employeeCreateQuery;
                command.ExecuteNonQuery();
            }
            catch
            {

            }

        }
        public static Dictionary<string, Employee> GetEmployees()
        {
            String employeeGetQuery = $"Select * from Employee";
            Dictionary<string, Employee> employees = new Dictionary<string, Employee>();
            DataTable dataTable = new DataTable();
            command.CommandText = employeeGetQuery;
            using (MySqlDataReader dataReader = command.ExecuteReader())
            {
                dataTable.Load(dataReader);
            }
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                employees.Add("" + dataTable.Rows[i]["Id"], new Employee()
                {
                    Id = int.Parse("" + dataTable.Rows[i]["Id"]),
                    FirstName = dataTable.Rows[i]["FirstName"].ToString(),
                    LastName = dataTable.Rows[i]["LastName"].ToString(),
                    Age = int.Parse("" + dataTable.Rows[i]["Age"]),
                    DateOfBirth = (DateTime)dataTable.Rows[i]["DateOfBirth"],

                    Gender = (Gender)Enum.Parse(typeof(Gender), dataTable.Rows[i]["Gender"].ToString()),
                    MarriageStatus = dataTable.Rows[i]["MarriageStatus"].ToString(),
                    PhoneNumber = dataTable.Rows[i]["PhoneNumber"].ToString(),
                    AadharNumber = dataTable.Rows[i]["AadharNumber"].ToString(),
                    Email = dataTable.Rows[i]["Email"].ToString(),
                    Address = dataTable.Rows[i]["Address"].ToString(),
                    Role = (Role)Enum.Parse(typeof(Role), dataTable.Rows[i]["Role"].ToString()),
                    JoinDateTime = (DateTime)dataTable.Rows[i]["JoinDateTime"],
                    Salary = int.Parse("" + dataTable.Rows[i]["Salary"]),
                    CollageName = dataTable.Rows[i]["CollageName"].ToString(),
                    Degree = (Degree)Enum.Parse(typeof(Degree), dataTable.Rows[i]["Degree"].ToString()),
                    DegreeSpecification = dataTable.Rows[i]["DegreeSpecification"].ToString(),
                    BankName = dataTable.Rows[i]["BankName"].ToString(),
                    BankIFSCCode = dataTable.Rows[i]["BankIFSCCode"].ToString(),
                    AccountNumber = dataTable.Rows[i]["AccountNumber"].ToString(),
                    PanCardNumber = dataTable.Rows[i]["PanCardNumber"].ToString(),
                    IsExEmployee = Convert.ToBoolean(dataTable.Rows[i]["IsExEmployee"])
                });

            }
            return employees;
        }
    }
}
