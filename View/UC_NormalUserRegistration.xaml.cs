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
    /// UC_NormalUserRegistration.xaml 的互動邏輯
    /// </summary>
    public partial class UC_NormalUserRegistration : UserControl
    {
        public UC_NormalUserRegistration()
        {
            InitializeComponent();

            data = new Model.WPF_ProjectDBEntities();
        }

        Model.WPF_ProjectDBEntities data;

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            switch (UserViewModel.CreateUser
                (tbUsername.Text, tbPassword1.Password, tbPassword2.Password,
                tbEmail.Text, tbFirstname.Text, tbLastname.Text,
                tbMobile.Text, imgProfilePicture))
            {
                case UserViewModel.RegisterErrorTypes.SuccessfulRegistration:
                    MessageBox.Show("登錄成功!", "註冊會員", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case UserViewModel.RegisterErrorTypes.LackOfUsername:
                    MessageBox.Show("請輸入使用者名稱。", "註冊會員", MessageBoxButton.OK, MessageBoxImage.Question);
                    break;
                case UserViewModel.RegisterErrorTypes.LackOfEmail:
                    MessageBox.Show("請輸入電子信箱。", "註冊會員", MessageBoxButton.OK, MessageBoxImage.Question);
                    break;
                case UserViewModel.RegisterErrorTypes.LackOfPassword:
                    MessageBox.Show("請輸入密碼。", "註冊會員", MessageBoxButton.OK, MessageBoxImage.Question);
                    break;
                case UserViewModel.RegisterErrorTypes.DuplicatedUsername:
                    tbUsername.Text = "";
                    MessageBox.Show("使用者帳號重複，請輸入新的帳號。", "註冊會員", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
                case UserViewModel.RegisterErrorTypes.DuplicateEmail:
                    tbEmail.Text = "";
                    MessageBox.Show("此電子信箱已被登錄過，請輸入新的信箱。", "註冊會員", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
                case UserViewModel.RegisterErrorTypes.InconsistentPassword:
                    tbPassword1.Password = tbPassword2.Password = "";
                    MessageBox.Show("密碼不一致，請重新輸入。", "註冊會員", MessageBoxButton.OK, MessageBoxImage.Error);
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

        private void btnDataGenerator_Click(object sender, RoutedEventArgs e)
        {
            Model.UserInformation fUser = UserViewModel.GenerateData();
            tbLastname.Text = fUser.Lastname;
            tbFirstname.Text = fUser.Firstname;
            tbEmail.Text = fUser.email;
            tbMobile.Text = fUser.mobile;
            tbUsername.Text = fUser.Username;
            tbPassword1.Password = tbPassword2.Password = "aaa";
        }
    }
}
