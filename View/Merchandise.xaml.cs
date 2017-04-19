using System;
using System.Collections.Generic;
using System.IO;
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
using View;

namespace Shopping
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class Merchandise : UserControl
    {
        public Merchandise()
        {
            InitializeComponent();
            animalShoppingDB = new Model.WPF_ProjectDBEntities();
            Loading();
            
        }
        global::Model.WPF_ProjectDBEntities animalShoppingDB;
        //ShoppingEntityDB.AnimalEntities animalShoppingDB;
        string storeID = "42618435";        //商店統編
        string Photo;


        private void Loading()
        {
            this.main_aside.ItemsSource = animalShoppingDB.Categories.ToList();
            IEnumerable<string> x = animalShoppingDB.Stores.Where(p => p.store_ID== storeID ).Select(p => p.store_Name);
            foreach (var y in x) {
                this.lab_Store.Content = y;
            }
        }

        private void ShowMerchandise_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void merchandise_Add(object sender, RoutedEventArgs e)
        {


            bool fiFitness = this.tbox_Fitness.IsChecked.Value?true:false;   //'商品狀態
            byte[] _ImageBytes = null;

            if (Photo != null)
            {
                System.Drawing.Image _image = System.Drawing.Image.FromFile(Photo);
                MemoryStream ms = new MemoryStream();
                _image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                _ImageBytes = ms.GetBuffer();
                ms.Dispose();
            }


            try
            {
                animalShoppingDB.Merchandises.Add(new Model.Merchandise
                {
                    merchandise_Name = this.tbox_Name.Text,
                    merchandise_Price = decimal.Parse(this.tbox_Price.Text),
                    merchandise_Description = this.tbox_Description.Text,
                    merchandise_Fitness = fiFitness,
                    merchandise_Photo = _ImageBytes,
                    merchandise_TypeID = 1,
                    merchandise_store_ID = storeID,
                    merchandise_ID = 2
                });
                MessageBox.Show("新增成功");
                this.Loading();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            //animalShoppingDB.Stores.Add( new ShoppingEntityDB.Store { store_ID = "02312312", store_Name = "傲視群犬", store_Phone = "23099999" });
            //MessageBox.Show("新增成功");

            //資料庫異動就須用savechanges
            animalShoppingDB.SaveChanges();




        }

        private void add_pix_click(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog diaD = new Microsoft.Win32.OpenFileDialog();
            if (diaD.ShowDialog() == true)
            {
                Photo = diaD.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(diaD.FileName, UriKind.Absolute);
                bitmap.EndInit();
                shoppingPix.Source = bitmap;
            }
        }

        private void Closs_click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = Application.Current.MainWindow;
            ((MainWindow)mainWindow).grdShow.Children.Clear();

            Index uc2 = new Index();
            ((MainWindow)mainWindow).grdShow.Children.Add(uc2);
            
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
