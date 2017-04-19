using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
using View;

namespace Shopping
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class Index : UserControl
    {

        public Index()
        {
            InitializeComponent();
            Loading();
            MediaLoading();
            
        }

        private void MediaLoading()
        {
            
        }

        Model.WPF_ProjectDBEntities animalShoppingDB = new Model.WPF_ProjectDBEntities();

        private void Loading()
        {

            this.combobox1.ItemsSource = this.aside.ItemsSource =  animalShoppingDB.Categories.ToList();
            //使用AsEnumerable 解決 linq複雜問題
            this.main.ItemsSource = animalShoppingDB.Merchandises.AsEnumerable().
                Select(p => new ListData { ID= p.merchandise_ID,
                                                        Photo = p.merchandise_Photo,
                                                        Name = p.merchandise_Name,
                                                        Price = (p.merchandise_Price).ToString("C0")
                                        }).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine(e.OriginalSource);
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            
             var Ans= animalShoppingDB.Merchandises.AsEnumerable().
                                                Where(p => p.merchandise_Name.Contains(this.tb_Select.Text)).
                                                Select(p => new ListData { ID = p.merchandise_ID,
                                                                                        Photo = p.merchandise_Photo,
                                                                                        Name = p.merchandise_Name,
                                                                                        Price = (p.merchandise_Price).ToString("C")
                                                                                    }).ToList();
            if (Ans.Count.Equals(0) || this.tb_Select.Text.Length.Equals(0)) {
                MessageBox.Show("很抱歉，找不到您要的商品，請重新輸入");
            }
            else {
                this.main.ItemsSource = Ans;
            }
            
        }

        private void AddMerchandise_Click(object sender, RoutedEventArgs e)
        {
            //未必要這樣轉換。之後可以刪除。
            
            Window mainWindow = Application.Current.MainWindow;
            ((MainWindow)mainWindow).grdShow.Children.Clear();

            Merchandise uc2 = new Merchandise();
            ((MainWindow)mainWindow).grdShow.Children.Add(uc2);
        }




        private void AddShoppingbus_Click(object sender, RoutedEventArgs e)
        {
            ListData shoppingA =(ListData)((Button)sender).DataContext;
            //MessageBox.Show(shoppingA.Name);

            Bus.Add(shoppingA);
            MessageBox.Show($"{shoppingA.Name}已加入您的購物車");
        }

        private void Shoppingbus_Click(object sender, RoutedEventArgs e)
        {
            foreach (var x in Bus) {
                animalShoppingDB.Orders.Add(new Model.Order { merchandise_ID = x.ID, merchandise_Volume=1 });
            }
            animalShoppingDB.SaveChanges();
            shoppinginbus f = new shoppinginbus();
            f.Show();
            //this.Close();

        }

        List<ListData> Bus = new List<ListData>();

        internal class ListData
        {
            public byte[] Photo { get; set; }
            public string Name { get; set; }
            public string Price { get; set; }
            public int ID { get; internal set; }
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Storyboard)this.Resources["sb1"]).Begin();
            
        }

        private void gridheight_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Storyboard)this.Resources["sb2"]).Begin();
        }


    }
}
