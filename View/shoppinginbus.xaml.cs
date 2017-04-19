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
using System.Windows.Shapes;
using View;

namespace Shopping
{
    /// <summary>
    /// shoppinginbus.xaml 的互動邏輯
    /// </summary>
    public partial class shoppinginbus : Window
    {
        public shoppinginbus()
        {
            InitializeComponent();          
            loading();
            System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.IsEnabled = true;
            Timer.Interval = new TimeSpan(0, 0, 0,0,500);
            Timer.Tick += Timer_Tick;
        }
        global::Model.WPF_ProjectDBEntities animalShoppingDB;


        private void loading()
        {
            


            animalShoppingDB = new Model.WPF_ProjectDBEntities();




            //this.main_total_Right.ItemsSource = animalShoppingDB.Orders.ToList();
            //this.main_total_Left.ItemsSource = animalShoppingDB.Orders.AsEnumerable().Select(p => new {
            //    p.merchandise_ID, 
            //    p. .Merchandise.merchandise_Name,
            //    p.Merchandise.merchandise_Photo,
            //    price = p.Merchandise.merchandise_Price.ToString("C0"),
            //}).ToList();

            this.main_total_Right.ItemsSource = animalShoppingDB.Orders.ToList();
            this.main_total_Left.ItemsSource = animalShoppingDB.Orders.AsEnumerable().Select(p => new {
                p.merchandise_ID,
                p.Merchandise.merchandise_Name,
                p.Merchandise.merchandise_Photo,
                price = p.Merchandise.merchandise_Price.ToString("C0"),
            }).ToList();


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            animalShoppingDB.SaveChanges();
            int total = 0;
            foreach (var y in animalShoppingDB.Orders)
            {
                total += (int)y.merchandise_Volume * (int)y.Merchandise.merchandise_Price;
            }
            this.totalmoney.Content = total.ToString("C0");
        }


        private void delet_click(object sender, RoutedEventArgs e)
        {           
            animalShoppingDB.Orders.Remove ((Model.Order)((Button)sender).DataContext);
            animalShoppingDB.SaveChanges();
            loading();
        }

        private void goindex_click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = Application.Current.MainWindow;
            ((MainWindow)mainWindow).grdShow.Children.Clear();

            Index uc2 = new Index();
            ((MainWindow)mainWindow).grdShow.Children.Add(uc2);
            
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            animalShoppingDB.SaveChanges();

        }
    }


}
