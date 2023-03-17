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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculate(object sender, RoutedEventArgs e)
        {
            DateTime startdate = Convert.ToDateTime(enddate.ToString());
            DateTime nowdate = DateTime.Now;
            TimeSpan diffdate = nowdate.Subtract(startdate);
            int totaldate = 1 * Convert.ToInt32(diffdate.TotalDays);
            int year = totaldate / 365;
            int remday = totaldate % 365;
            int month = remday / 30;
            remday = remday % 30;
            tage.Text = ("yourcurrentage is" + year + "year," + month + "month" + remday + "days");
        }
    }
}
