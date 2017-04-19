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
    /// PetUserControl2.xaml 的互動邏輯
    /// </summary>
    public partial class PetUserControl2 : UserControl
    {
        global::Model.WPF_ProjectDBEntities dbContext = new Model.WPF_ProjectDBEntities();

        public PetUserControl2()
        {
           InitializeComponent();
        
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
        
        private void ComHospitalName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComAddressArea.Text = "";
            ComPetRace.Text = "";
            Cleared();
        }

        private void ComAddressArea_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComHospitalName.Text = "";
            ComPetRace.Text = "";
            Cleared();
        }

        private void ComPetRace_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComAddressArea.Text = "";
            ComHospitalName.Text = "";
            Cleared();
        }

        private void Searcherbutton_Copy1_Click(object sender, RoutedEventArgs e)
        {
            ComCleared();
            Cleared();
        }

        private void Searcherbutton_Click(object sender, RoutedEventArgs e)//全部
        {
      var q = from p in dbContext.Hospitals
                    where p.OnView != "0"
                    select new ABCClass1 { HospitaNumber = p.HospitaNumber, HospitalName = p.HospitalName, HospitalAddress = p.HospitalAddress, AddressArea = p.AddressArea, HospitalPhone = p.HospitalPhone, PetRace = p.PetRace, BusinessHours = p.BusinessHours, Emergency = p.Emergency, OutpatientProject = p.OutpatientProject, Equipment = p.Equipment, WebAddress = p.WebAddress, OnlineConsultation = p.OnlineConsultation };

            this.dataGrid.ItemsSource = q.ToList();
            ComCleared();
            Cleared();
        }

        private void Searcherbutton_Copy_Click(object sender, RoutedEventArgs e)//搜尋
        { var q = from p in dbContext.Hospitals
                    where (p.HospitalName.IndexOf(textBox.Text) >= 0 || p.HospitalAddress.IndexOf(textBox_Copy.Text) >= 0 || p.AddressArea.IndexOf(textBox_Copy1.Text) >= 0 || p.HospitalPhone.IndexOf(textBox_Copy2.Text) >= 0 || p.PetRace.IndexOf(textBox_Copy3.Text) >= 0 || p.BusinessHours.IndexOf(textBox_Copy4.Text) >= 0 || p.Emergency.IndexOf(textBox_Copy5.Text) >= 0 || p.OutpatientProject.IndexOf(textBox_Copy6.Text) >= 0 || p.Equipment.IndexOf(textBox_Copy7.Text) >= 0 || p.WebAddress.IndexOf(textBox_Copy8.Text) >= 0 || p.OnlineConsultation.IndexOf(textBox_Copy9.Text) >= 0) && p.OnView != "0"
                    select new ABCClass1 { HospitaNumber = p.HospitaNumber, HospitalName = p.HospitalName, HospitalAddress = p.HospitalAddress, AddressArea = p.AddressArea, HospitalPhone = p.HospitalPhone, PetRace = p.PetRace, BusinessHours = p.BusinessHours, Emergency = p.Emergency, OutpatientProject = p.OutpatientProject, Equipment = p.Equipment, WebAddress = p.WebAddress, OnlineConsultation = p.OnlineConsultation };

            { this.dataGrid.ItemsSource = q.ToList(); }
            ComCleared();
           
        }

        private void ComHospitalName_DropDownClosed_1(object sender, EventArgs e)
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
    }

}
    

