﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFPractice
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
     
        public AddWindow()
        {
            InitializeComponent();
            RoleComboBox.ItemsSource = EmployeeManager.RoleSource;
          
            DegreeComboBox.ItemsSource = Enum.GetNames(typeof(Degree)).ToList();
            JoinDatePicker.SelectedDate = DateTime.Now;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseBtnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            
        }
    }
}
