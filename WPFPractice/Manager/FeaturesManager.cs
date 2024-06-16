using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFPractice.Manager
{
    public static class FeaturesManager
    {
        public static Brush EmployeeRoleBackGroundColor(Role role){
            switch (role)
            {
                case Role.Manager:
                    return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FDD164"));

                case Role.Intern:
                    return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0C8EEE"));

                case Role.ImageProcessing:
                    return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5873FA"));

                case Role.JuniorDeveloper:
                    return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F84B3B"));
               

                case Role.SeniorDeveloper:
                    return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#015C93"));
                   
                case Role.Tester:
                    return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#631E3B"));
                
                case Role.HumanResource:
                    return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#67CC52"));
                   
            }
            return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FDD164"));
        }
    }
}
