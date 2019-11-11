using BLL;
using Hotel2.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hotel2
{
    /// <summary>
    /// Логика взаимодействия для Report.xaml
    /// </summary>
    public partial class Report : Page
    {
        DBDataOperations dbo = new DBDataOperations();
        HotelContext dbcontext = new HotelContext();
        BindingList<Client> allClients;
        List<Tariff> allTariffs;
        List<Room_category> allRoom_category;
        List<Additional_services> allAddition;
        List<Hotel_room> allHotel_Rooms;


        private void loadData()
        {
            allTariffs = dbcontext.Tariffs.ToList();
            loadClients();
           
        }
        public Report()
        {
            InitializeComponent();
            loadData();
        }
        private void loadClients()
        {
            dbcontext.Clients.Load();
            allClients = dbcontext.Clients.Local.ToBindingList();

            // Отображаем данные
            dataGridClient.ItemsSource = allClients;
     
        }
       
    }
}
