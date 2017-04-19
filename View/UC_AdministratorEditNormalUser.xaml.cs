using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// UC_AdministratorEditNormalUser.xaml 的互動邏輯
    /// </summary>
    public partial class UC_AdministratorEditNormalUser : UserControl
    {
        public UC_AdministratorEditNormalUser()
        {
            InitializeComponent();

            normalUserViewSource = (CollectionViewSource)this.Resources["normalUserViewSource"];

            dataentity = new Model.WPF_ProjectDBEntities();
            dataentity.UserInformations.Load();
            normalUserViewSource.Source = dataentity.UserInformations.Local;
        }

        WPF_ProjectDBEntities dataentity;
        System.Windows.Data.CollectionViewSource normalUserViewSource;

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
          
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //this.normalUserViewSource.Source = dataentity.NormalUsers.Local.Where(u=> u.Username.Contains(tbSearchCondition.Text));

            var q = dataentity.UserInformations.Local.Where(u => u.Username.Contains(tbSearchCondition.Text));
            //q.Load();
            this.normalUserViewSource.Source = q.ToList();
            //q.ToList();
            //this.normalUserViewSource.View.Filter(q);
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            this.normalUserViewSource.View.MoveCurrentToPrevious();
            if (this.normalUserViewSource.View.IsCurrentBeforeFirst)
            {
                this.normalUserViewSource.View.MoveCurrentToLast();
            }
            this.normalUserDataGrid.ScrollIntoView(this.normalUserViewSource.View.CurrentItem);
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            this.normalUserViewSource.View.MoveCurrentToNext();
            if (this.normalUserViewSource.View.IsCurrentAfterLast)
            {
                this.normalUserViewSource.View.MoveCurrentToFirst();
            }
            this.normalUserDataGrid.ScrollIntoView(this.normalUserViewSource.View.CurrentItem);
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            this.normalUserViewSource.View.MoveCurrentToLast();
            this.normalUserDataGrid.ScrollIntoView(this.normalUserViewSource.View.CurrentItem);
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            this.normalUserViewSource.View.MoveCurrentToFirst();
            this.normalUserDataGrid.ScrollIntoView(this.normalUserViewSource.View.CurrentItem);
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            W_AdministratorAddNormalUser w = new W_AdministratorAddNormalUser();
           UC_NormalUserRegistration uc = new UC_NormalUserRegistration();
            w.grid1.Children.Add(uc);
            w.Show();
            //dataentity.NormalUsers.Local.Add(new Model.NormalUser {  });
            //btnLast_Click(sender, e);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            dataentity.UserInformations.Local.Remove((Model.UserInformation)this.normalUserViewSource.View.CurrentItem);
            //this.normalUserViewSource.View.Refresh();
            btnSearch_Click(sender, e);
            //this.normalUserDataGrid.ScrollIntoView(this.normalUserViewSource.View.CurrentItem);
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.dataentity.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowsePic_Click(object sender, RoutedEventArgs e)
        {
            //將對話方塊選取的圖片送到Image
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "Image files|*.jpg;*.JPG;*.JPEG;*.png;*.PNG;*.bmp;*.BMP";
            BitmapImage bi = new BitmapImage();
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                bi = new BitmapImage(new Uri(dlg.FileName, UriKind.Absolute));

                //將Image轉為byte[]
                MemoryStream ms = new MemoryStream();
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bi));
                encoder.Save(ms);
                byte[] imgData = ms.ToArray();
                ms.Close();
                ((Model.UserInformation)this.normalUserViewSource.View.CurrentItem).Photo = imgData;
            }

            this.normalUserViewSource.View.Refresh();
            this.normalUserDataGrid.ScrollIntoView(this.normalUserViewSource.View.CurrentItem);
        }
    }
}
