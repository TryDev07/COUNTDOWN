using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace COUNTDOWN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
          
            SCHEDULESCREEN_GRID.Visibility = Visibility.Collapsed;
            //AddVersionNumber();

            //MessageBox.Show(Directory.GetCurrentDirectory());
            //checkForUpdate();
         }


        




        private void AddVersionNumber()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            this.Version.Text = $"Version {versionInfo.FileVersion}";
        }


        private void HOME(object sender, MouseButtonEventArgs e)
        {
            HOME_BAR.Background = new SolidColorBrush(Color.FromRgb(255, 133, 0));
            SETTINGS_BAR.Background = new SolidColorBrush(Color.FromRgb(45, 45, 45));
            SHEDULE_BAR.Background = new SolidColorBrush(Color.FromRgb(45, 45, 45));

            HOMESCREEN_GRID.Visibility = Visibility.Visible;
            SCHEDULESCREEN_GRID.Visibility = Visibility.Collapsed;


        }

        private void SHEDULE(object sender, MouseButtonEventArgs e)
        {
            SHEDULE_BAR.Background = new SolidColorBrush(Color.FromRgb(255, 133, 0));
            HOME_BAR.Background = new SolidColorBrush(Color.FromRgb(45, 45, 45));
            SETTINGS_BAR.Background = new SolidColorBrush(Color.FromRgb(45, 45, 45));
            HOMESCREEN_GRID.Visibility = Visibility.Collapsed;
            SCHEDULESCREEN_GRID.Visibility = Visibility.Visible;


        }

        private void SETTINGS(object sender, MouseButtonEventArgs e)
        {
            SETTINGS_BAR.Background = new SolidColorBrush(Color.FromRgb(255, 133, 0));
            SHEDULE_BAR.Background = new SolidColorBrush(Color.FromRgb(45, 45, 45));
            HOME_BAR.Background = new SolidColorBrush(Color.FromRgb(45, 45, 45));
            HOMESCREEN_GRID.Visibility = Visibility.Collapsed;
            SCHEDULESCREEN_GRID.Visibility = Visibility.Collapsed;


        }

        private void CLOSE(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MINIMIZE(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void MOVEUI(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
