using System;
using System.Collections.Generic;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Adoption
{
    /// <summary>
    /// UCAdoption.xaml 的互動邏輯
    /// </summary>
    public partial class UCAdoption : UserControl
    {
        public UCAdoption()
        {
            InitializeComponent();
        }

        System.Windows.Data.CollectionViewSource petViewSource;
        global::Model.WPF_ProjectDBEntities dbContext;

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            petViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("petViewSource")));
            // 透過設定 CollectionViewSource.Source 屬性載入資料: 
            dbContext = new Model.WPF_ProjectDBEntities();
            dbContext.PetAdoptions.Load();

            petViewSource.Source = dbContext.PetAdoptions.Local;
            listBox1.ItemsSource = dbContext.PetAdoptions.Local;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.dbContext.PetAdoptions.Add(new Model.PetAdoption
            {
                Category = comboBox.Text,
                Furcolor = txtFurcolor.Text,
                Region = txtRegion.Text,
                Size = txtSize.Text,
                Yearold = txtYearold.Text,
                PostDate = DateTime.Now
            });
            this.petViewSource.View.MoveCurrentToLast();
            if (MessageBox.Show("是否要新增?", "新增確認", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.dbContext.SaveChanges();
                MessageBox.Show("新增成功");
                UserControl_Loaded(sender, e);
            }
            else
            {
                this.petViewSource.View.MoveCurrentToLast();
                dbContext.PetAdoptions.Local.RemoveAt(this.petViewSource.View.CurrentPosition);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Storyboard In = (Storyboard)this.Resources["sb1"];
            In.Begin();

            petViewSource.View.MoveCurrentToPosition(listBox1.SelectedIndex);
        
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("是否要刪除?", "刪除確認", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                dbContext.PetAdoptions.Local.RemoveAt(listBox1.SelectedIndex);
                MessageBox.Show("刪除成功");
                this.dbContext.SaveChanges();
                UserControl_Loaded(sender, e);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            postDateDatePicker.SelectedDate = DateTime.Now;
            Storyboard Out = (Storyboard)this.Resources["sb2"];
            Out.Begin();

            this.dbContext.SaveChanges();
            MessageBox.Show("更新成功");
            UserControl_Loaded(sender, e);
        }

        private void btnCanel_Click(object sender, RoutedEventArgs e)
        {
            Storyboard Out = (Storyboard)this.Resources["sb2"];
            Out.Begin();
        }

        private void btnAdd0_Click(object sender, RoutedEventArgs e)
        {
            Storyboard In = (Storyboard)this.Resources["sb3"];
            In.Begin();
        }

        private void btnCanel_Copy_Click(object sender, RoutedEventArgs e)
        {
            Storyboard Out = (Storyboard)this.Resources["sb4"];
            Out.Begin();
        }
    }
}
