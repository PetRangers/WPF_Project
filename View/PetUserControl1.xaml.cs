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
using View;

namespace View
{
    /// <summary>
    /// PetUserControl1.xaml 的互動邏輯
    /// </summary>
    public partial class PetUserControl1 : UserControl
    {
        global::Model.WPF_ProjectDBEntities dbContext = new Model.WPF_ProjectDBEntities();
        public PetUserControl1()
        {
            InitializeComponent();
            var a = from b in dbContext.Hospitals
                    select b.HospitalName;
            foreach (var c in a)
            {
                this.ComHospitalName.Items.Add(c);
            }
            var a1 = from b1 in dbContext.Hospitals
                     select b1.AddressArea;
            foreach (var c1 in a1)
            {
                this.ComAddressArea.Items.Add(c1);
            }

            var a2 = from b in dbContext.Hospitals
                     select b.PetRace;
            foreach (var c2 in a2)
            {
                this.ComPetRace.Items.Add(c2);
            }
        }
        public void SelectAll()
        {
            var q = from p in dbContext.Hospitals
                    where p.OnView != "0"
                    select new ABCClass1 { HospitaNumber = p.HospitaNumber, HospitalName = p.HospitalName, HospitalAddress = p.HospitalAddress, AddressArea = p.AddressArea, HospitalPhone = p.HospitalPhone, PetRace = p.PetRace, BusinessHours = p.BusinessHours, Emergency = p.Emergency, OutpatientProject = p.OutpatientProject, Equipment = p.Equipment, WebAddress = p.WebAddress, OnlineConsultation = p.OnlineConsultation };

            this.dataGrid.ItemsSource = q.ToList();
            ComCleared();
        }
        public void Cleared()
        {
            textBox.Text = "";
            textBox_Copy.Text = "";
            textBox_Copy1.Text = "";
            textBox_Copy2.Text = "";
            textBox_Copy3.Text = "";
            textBox_Copy4.Text = "";
            textBox_Copy5.Text = "";
            textBox_Copy6.Text = "";
            textBox_Copy7.Text = "";
            textBox_Copy8.Text = "";
            textBox_Copy9.Text = "";
        }
        public void ComCleared()
        {
            ComAddressArea.Text = "";
            ComHospitalName.Text = "";
            ComPetRace.Text = "";
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            SelectAll();
            ComCleared();
        }

        private void SearchButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            Window w = new SeacrerADD();
            w.Show();
            //註冊關閉時呼叫事件
            w.Closing += W_Closing; ;
            ComCleared();
        }

        private void W_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SelectAll();
        }

        private void SearchButton_Copy1_Click(object sender, RoutedEventArgs e)
        {
            var q = from p in dbContext.Hospitals
                    where (p.HospitalName.IndexOf(textBox.Text) >= 0 || p.HospitalAddress.IndexOf(textBox_Copy.Text) >= 0 || p.AddressArea.IndexOf(textBox_Copy1.Text) >= 0 || p.HospitalPhone.IndexOf(textBox_Copy2.Text) >= 0 || p.PetRace.IndexOf(textBox_Copy3.Text) >= 0 || p.BusinessHours.IndexOf(textBox_Copy4.Text) >= 0 || p.Emergency.IndexOf(textBox_Copy5.Text) >= 0 || p.OutpatientProject.IndexOf(textBox_Copy6.Text) >= 0 || p.Equipment.IndexOf(textBox_Copy7.Text) >= 0 || p.WebAddress.IndexOf(textBox_Copy8.Text) >= 0 || p.OnlineConsultation.IndexOf(textBox_Copy9.Text) >= 0) && p.OnView != "0"
                    select new ABCClass1 { HospitaNumber = p.HospitaNumber, HospitalName = p.HospitalName, HospitalAddress = p.HospitalAddress, AddressArea = p.AddressArea, HospitalPhone = p.HospitalPhone, PetRace = p.PetRace, BusinessHours = p.BusinessHours, Emergency = p.Emergency, OutpatientProject = p.OutpatientProject, Equipment = p.Equipment, WebAddress = p.WebAddress, OnlineConsultation = p.OnlineConsultation };

            { this.dataGrid.ItemsSource = q.ToList(); }
            ComCleared();
        }

        private void SearchButton_Copy2_Click(object sender, RoutedEventArgs e)
        {
            int SaveInt;
            int.TryParse(this.label2.Content.ToString(), out SaveInt);
            var q = (from p in dbContext.Hospitals where p.HospitaNumber == SaveInt select p).FirstOrDefault();

            if (textBox.Text != "" && textBox_Copy.Text != "")
            {
                q.HospitalName = textBox.Text;
                q.HospitalAddress = textBox_Copy.Text;
                q.AddressArea = textBox_Copy1.Text;
                q.HospitalPhone = textBox_Copy2.Text;
                q.PetRace = textBox_Copy3.Text;
                q.BusinessHours = textBox_Copy4.Text;
                q.Emergency = textBox_Copy5.Text;
                q.OutpatientProject = textBox_Copy6.Text;
                q.Equipment = textBox_Copy7.Text;
                q.WebAddress = textBox_Copy8.Text;
                q.OnlineConsultation = textBox_Copy9.Text;

                this.dbContext.SaveChanges();
                SelectAll();
                ComCleared();
                MessageBox.Show(textBox.Text + "修改成功");
            }
        }

        private void SearchButton_Copy3_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("確定要刪除？", "提示：", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                var q = (from p in dbContext.Hospitals
                         where p.HospitalName == textBox.Text
                         select p).FirstOrDefault();
                if (q.Equals(null)) return;
                q.OnView = "0";
                this.dbContext.SaveChanges();
                MessageBox.Show(textBox.Text + "已刪除");

                SelectAll();
                //this.dataGrid.ItemsSource = dbContext.Hospital.ToList();
                ComCleared();
            }
        }

        private void SearchButton_Copy4_Click(object sender, RoutedEventArgs e)
        {
            label2.Content = "";
            Cleared();
        }

        private void ComAddressArea_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox mCB = sender as ComboBox;

            if (mCB != null)
            {
                var SerchItem = from p in dbContext.Hospitals
                                where p.AddressArea == mCB.SelectedValue.ToString()
                                select new ABCClass1 { HospitaNumber = p.HospitaNumber, HospitalName = p.HospitalName, HospitalAddress = p.HospitalAddress, AddressArea = p.AddressArea, HospitalPhone = p.HospitalPhone, PetRace = p.PetRace, BusinessHours = p.BusinessHours, Emergency = p.Emergency, OutpatientProject = p.OutpatientProject, Equipment = p.Equipment, WebAddress = p.WebAddress, OnlineConsultation = p.OnlineConsultation };

                this.dataGrid.ItemsSource = SerchItem.ToList();
            }
        }

        private void ComPetRace_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox mCB = sender as ComboBox;

            if (mCB != null)
            {
                var SerchItem = from p in dbContext.Hospitals
                                where p.PetRace == mCB.SelectedValue.ToString()
                                select new ABCClass1 { HospitaNumber = p.HospitaNumber, HospitalName = p.HospitalName, HospitalAddress = p.HospitalAddress, AddressArea = p.AddressArea, HospitalPhone = p.HospitalPhone, PetRace = p.PetRace, BusinessHours = p.BusinessHours, Emergency = p.Emergency, OutpatientProject = p.OutpatientProject, Equipment = p.Equipment, WebAddress = p.WebAddress, OnlineConsultation = p.OnlineConsultation };

                this.dataGrid.ItemsSource = SerchItem.ToList();
            }
        }

        private void ComHospitalName_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox mCB = sender as ComboBox;

            if (mCB != null)
            {
                var SerchItem = from p in dbContext.Hospitals
                                where p.HospitalName == mCB.SelectedValue.ToString()
                                select new ABCClass1 { HospitaNumber = p.HospitaNumber, HospitalName = p.HospitalName, HospitalAddress = p.HospitalAddress, AddressArea = p.AddressArea, HospitalPhone = p.HospitalPhone, PetRace = p.PetRace, BusinessHours = p.BusinessHours, Emergency = p.Emergency, OutpatientProject = p.OutpatientProject, Equipment = p.Equipment, WebAddress = p.WebAddress, OnlineConsultation = p.OnlineConsultation };

                this.dataGrid.ItemsSource = SerchItem.ToList();
            }
        }

        private void ComHospitalName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
