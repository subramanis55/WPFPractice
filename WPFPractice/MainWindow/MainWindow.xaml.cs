using System;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsMenuDrawVisible=false;

        public static readonly DependencyProperty AnimatedColumnWidthProperty =
           DependencyProperty.Register("AnimatedColumnWidth", typeof(double), typeof(MainWindow), new PropertyMetadata(10));

        public double AnimatedColumnWidth
        {
            get => (double)GetValue(AnimatedColumnWidthProperty);
            set => SetValue(AnimatedColumnWidthProperty, value);
        }

        // Callback to update the column width
        private static void OnAnimatedColumnWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MainWindow window)
            {
                window.Maingrid.ColumnDefinitions[0].Width = new GridLength((double)e.NewValue, GridUnitType.Pixel);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Loaded += MainWindowLoaded;
        }

        private void MainWindowLoaded(object sender, RoutedEventArgs e)
        {
           EmployeeManager.EmployeeManagerSetUp();
            ExitsEmployeesCardsAdd();
        }

        private void ExitsEmployeesCardsAdd()
        { List<Employee> EmployeeList = EmployeeManager.EmployeeDictionary.Values.ToList();
            for (int i = 0; i < EmployeeList.Count; i++) {
                EmployeeCardAlignPanel.Children.Add(new EmployeeCard(EmployeeList[i]) { Margin = new Thickness(12, 12, 12, 12) });
              }
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void MenuButtonClick(object sender, RoutedEventArgs e)
        {
            
                IsMenuDrawVisible = !IsMenuDrawVisible;
           if(IsMenuDrawVisible){
                DoubleAnimation animation = new DoubleAnimation(300, new TimeSpan(500));
                BeginAnimation(AnimatedColumnWidthProperty, animation);
                //MenuColumn.BeginAnimation(ColumnDefinition.WidthProperty, animation);
                //Maingrid.ColumnDefinitions[0].BeginAnimation
                //Maingrid.ColumnDefinitions[0].Width = new GridLength(300);
            }
            else{
                DoubleAnimation animation = new DoubleAnimation(0,new TimeSpan(500));
               BeginAnimation(AnimatedColumnWidthProperty, animation);
                //(AnimatedColumnWidthProperty, animation);
                //Maingrid.ColumnDefinitions[0].BeginAnimation(WidthProperty, animation);
                //Maingrid.ColumnDefinitions[0].Width = new GridLength(0);
            }
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedItem = HomePage;
        }

        private void EmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedItem = EmployeePage;
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedItem = EditPage;
        }

        private void FilterBtn_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedItem = FilterPage;
        }

        private void DashboardBtn_Click(object sender, RoutedEventArgs e)
        {
            MainTabControl.SelectedItem = DashboardPage;
        }

        private void MainTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.OnClickEmployeeObjectGet += AddWindowOnClickEmployeeObjectGet;
            addWindow.ShowDialog();
        }

        private void AddWindowOnClickEmployeeObjectGet(object sender, Employee employee)
        {
            Window window = (Window)(sender);
            window.Close();
            EmployeeManager.CreateEmployee(employee);
            EmployeeCard employeeCard = new EmployeeCard(employee) { Margin=new Thickness(12,12,12,12)};
            EmployeeCardAlignPanel.Children.Add(employeeCard);
        }
    }
}
