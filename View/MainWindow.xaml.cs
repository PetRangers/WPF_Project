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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using ViewModel;

namespace View
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            UC_Template uc = new UC_Template();
            this.grdShow.Children.Add(uc);
        }
        
        private void btnNormalUserRegistration_Click(object sender, RoutedEventArgs e)
        {
            this.grdShow.Children.Clear();
            UC_NormalUserRegistration uc = new UC_NormalUserRegistration();
            grdShow.Children.Add(uc);
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            switch (UserViewModel.ValidateUser(tbUsername.Text, tbPassword.Password))
            {
                case UserViewModel.LogonErrorTypes.ValidNormalUser:
                    Window mainWindow = Application.Current.MainWindow;
                    ((MainWindow)mainWindow).grdShow.Children.Clear();
                    UserViewModel.CurrentUser = tbUsername.Text;
                    await ((MainWindow)mainWindow).ShowMessageAsync("使用者操作介面", 
                        $"{UserViewModel.CurrentUser}您好!", MessageDialogStyle.Affirmative, 
                        new MetroDialogSettings { ColorScheme = MetroDialogColorScheme.Accented,
                            AffirmativeButtonText = "開始", DialogTitleFontSize = 48 });
                    UC_NormalUserOperation uc = new UC_NormalUserOperation();
                    ((MainWindow)mainWindow).grdShow.Children.Add(uc);
                    break;
                case UserViewModel.LogonErrorTypes.ValidStoreUser:
                    mainWindow = Application.Current.MainWindow;
                    ((MainWindow)mainWindow).grdShow.Children.Clear();
                    UserViewModel.CurrentUser = tbUsername.Text;
                    await ((MainWindow)mainWindow).ShowMessageAsync("商家操作介面",
                        $"{UserViewModel.CurrentUser}您好!", MessageDialogStyle.Affirmative,
                        new MetroDialogSettings
                        {
                            ColorScheme = MetroDialogColorScheme.Accented,
                            AffirmativeButtonText = "開始",
                            DialogTitleFontSize = 48
                        });
                    Shopping.Merchandise uc2 = new Shopping.Merchandise();
                    ((MainWindow)mainWindow).grdShow.Children.Add(uc2);
                    break;
                case UserViewModel.LogonErrorTypes.ValidAdminUser:
                    mainWindow = Application.Current.MainWindow;
                    ((MainWindow)mainWindow).grdShow.Children.Clear();
                    UserViewModel.CurrentUser = tbUsername.Text;
                    await ((MainWindow)mainWindow).ShowMessageAsync("管理介面", "管理員您好!", 
                        MessageDialogStyle.Affirmative, new MetroDialogSettings
                        { ColorScheme = MetroDialogColorScheme.Accented,
                            AffirmativeButtonText = "開始工作", DialogTitleFontSize = 48 });
                    UC_AdministratorOperation uc1 = new UC_AdministratorOperation();
                    ((MainWindow)mainWindow).grdShow.Children.Add(uc1);
                    break;
                case UserViewModel.LogonErrorTypes.LackOfUsername:
                    MessageBox.Show("請輸入使用者名稱。");
                    break;
                case UserViewModel.LogonErrorTypes.LackOfPassword:
                    MessageBox.Show("請輸入密碼。");
                    break;
                case UserViewModel.LogonErrorTypes.InvalidUser:
                    MessageBox.Show("密碼錯誤", "警告訊息", MessageBoxButton.OK, MessageBoxImage.Stop);
                    break;
                case UserViewModel.LogonErrorTypes.UserNotExist:
                    MessageBox.Show("使用者不存在。");
                    break;
                default:
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.grdShow.Children.Clear();
            UC_Template uc = new UC_Template();
            this.grdShow.Children.Add(uc);
        }
    }
}
