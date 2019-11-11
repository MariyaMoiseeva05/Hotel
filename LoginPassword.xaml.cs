using Hotel2.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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

namespace Hotel2
{
    /// <summary>
    /// Логика взаимодействия для LoginPassword.xaml
    /// </summary>
    public partial class LoginPassword : Page
    {



        public LoginPassword()
        {
            InitializeComponent();
        }


      
        private void buttonEnter_Click(object sender, RoutedEventArgs e)
        {
             Report occupancyReportPage = new Report();
             this.NavigationService.Navigate(occupancyReportPage);
            /*try
            {

            }
            catch
            { 
            
            }
            finally
            {

            }*/

        }
    }
}
