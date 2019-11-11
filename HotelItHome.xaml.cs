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

namespace Hotel2
{
    /// <summary>
    /// Логика взаимодействия для HotelItHome.xaml
    /// </summary>
    public partial class HotelItHome : Page
    {
        public HotelItHome()
        {
            InitializeComponent();
        }
        // View Expense Report
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginPassword loginPassword = new LoginPassword();
            this.NavigationService.Navigate(loginPassword);

            // View Expense Report
            // Report occupancyReportPage = new Report();
            //  this.NavigationService.Navigate(occupancyReportPage);
        }

    }
}
