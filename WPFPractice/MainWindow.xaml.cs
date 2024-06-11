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
        public bool IsMenuDrawVisible=true;
        public static readonly DependencyProperty AnimatedColumnWidthProperty =
           DependencyProperty.Register("AnimatedColumnWidth", typeof(double), typeof(MainWindow), new PropertyMetadata(0.0, OnAnimatedColumnWidthChanged));

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
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void MenuButtonClick(object sender, RoutedEventArgs e)
        {
            
                IsMenuDrawVisible = !IsMenuDrawVisible;
           if(IsMenuDrawVisible){
               
                ////MenuColumn.BeginAnimation(AnimatedColumnWidthProperty, animation);
                //MenuColumn.BeginAnimation(ColumnDefinition.WidthProperty, animation);
                //Maingrid.ColumnDefinitions[0].BeginAnimation

                Maingrid.ColumnDefinitions[0].Width = new GridLength(300);
            }
            else{
                //DoubleAnimation animation = new DoubleAnimation(0,new TimeSpan(500));
                //MenuColumn.BeginAnimation(ColumnDefinition.WidthProperty, animation);
                //(AnimatedColumnWidthProperty, animation);
                //Maingrid.ColumnDefinitions[0].BeginAnimation(WidthProperty, animation);
                Maingrid.ColumnDefinitions[0].Width = new GridLength(0);
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
            addWindow.ShowDialog();
        }
    }
}
