using Adoption;
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

namespace View
{
    /// <summary>
    /// UC_AdministratorOperation.xaml 的互動邏輯
    /// </summary>
    public partial class UC_AdministratorOperation : UserControl
    {
        public UC_AdministratorOperation()
        {
            InitializeComponent();
        }

        private void btnEditNormalUserProfile_Click(object sender, RoutedEventArgs e)
        {
            gridAdministrator.Children.Clear();
            //await this.ShowMessageAsync("管理介面", "管理員您好!", MessageDialogStyle.Affirmative, new MetroDialogSettings { ColorScheme = MetroDialogColorScheme.Accented, AffirmativeButtonText = "開始工作", DialogTitleFontSize = 48 });
            UC_AdministratorEditNormalUser uc = new UC_AdministratorEditNormalUser();
            gridAdministrator.Children.Add(uc);
        }

        private void btnEditPetAdoption_Click(object sender, RoutedEventArgs e)
        {
            gridAdministrator.Children.Clear();
            UCAdoption uc = new UCAdoption();
            gridAdministrator.Children.Add(uc);
        }

        private void btnEditPetService_Click(object sender, RoutedEventArgs e)
        {
            gridAdministrator.Children.Clear();
            PetUserControl1 uc = new PetUserControl1();
            gridAdministrator.Children.Add(uc);
        }
    }
}
