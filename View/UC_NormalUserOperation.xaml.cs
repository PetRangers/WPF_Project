using PetWPF;
using Shopping;
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
    /// UC_NormalUserOperation.xaml 的互動邏輯
    /// </summary>
    public partial class UC_NormalUserOperation : UserControl
    {
        Model.WPF_ProjectDBEntities dataentity;

        public UC_NormalUserOperation()
        {
            InitializeComponent();

            dataentity = new Model.WPF_ProjectDBEntities();
            var q = from u in dataentity.UserInformations
                    where u.Username == UserViewModel.CurrentUser
                    select u;

            this.DataContext = q.ToList();
        }

        private void btnEditProfile_Click(object sender, RoutedEventArgs e)
        {
            UC_NormalUserEdit uc = new UC_NormalUserEdit();
            gridNormalUser.Children.Clear();
            gridNormalUser.Children.Add(uc);
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mg = MessageBox.Show("您確定要刪除帳號嗎?", "警告訊息", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (mg == MessageBoxResult.OK)
            {
                UserViewModel.DeleteUser(UserViewModel.CurrentUser);
                gridNormalUser.Children.Clear();
            }
        }

        private void btnShopping_Click(object sender, RoutedEventArgs e)
        {
            Index uc = new Index();
            gridNormalUser.Children.Clear();
            gridNormalUser.Children.Add(uc);
            
        }

        private void btnForum_Click(object sender, RoutedEventArgs e)
        {
            PetPostMain uc = new PetPostMain();
            gridNormalUser.Children.Clear();
            gridNormalUser.Children.Add(uc);
            
        }
    }
}
