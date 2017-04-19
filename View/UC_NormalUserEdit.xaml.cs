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
using ViewModel;

namespace View
{
    /// <summary>
    /// UC_NormalUserEdit.xaml 的互動邏輯
    /// </summary>
    public partial class UC_NormalUserEdit : UserControl
    {
        public UC_NormalUserEdit()
        {
            InitializeComponent();
        }

        private void tbUpdateUserProfile_Click(object sender, RoutedEventArgs e)
        {
            switch (UserViewModel.UpdateUser(tbEmail.Text, tbFirstname.Text, tbLastname.Text, tbMobile.Text, imgProfilePicture))
            {
                case UserViewModel.RegisterErrorTypes.SuccessfulRegistration:
                   MessageBox.Show("資料更新成功!", "會員資料編輯", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case UserViewModel.RegisterErrorTypes.LackOfEmail:
                    MessageBox.Show("請輸入電子信箱。", "會員資料編輯", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
                case UserViewModel.RegisterErrorTypes.DuplicateEmail:
                    tbEmail.Text = "";
                    MessageBox.Show("此電子信箱已被登錄過，請輸入新的信箱。", "會員資料編輯", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
                default:
                    break;
            }
        }

        private void btnAddProfilePicture_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "Image files|*.jpg;*.JPG;*.JPEG;*.png;*.PNG;*.bmp;*.BMP";

            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                BitmapImage bi = new BitmapImage(new Uri(dlg.FileName, UriKind.Absolute));
                imgProfilePicture.Stretch = Stretch.Uniform;
                imgProfilePicture.Source = bi;
            }
        }
    }
}
