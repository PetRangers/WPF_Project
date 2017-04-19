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

namespace PetWPF
{
    /// <summary>
    /// PetPostControl.xaml 的互動邏輯
    /// </summary>
    public partial class PetPostControl : UserControl
    {
        public PetPostControl()
        {
            InitializeComponent();
            
            petPostTextViewSource = ((CollectionViewSource)(this.FindResource("petPostTextViewSource")));
            db.PetPostTexts.Load();
            petPostTextViewSource.Source = db.PetPostTexts.Local;

            this.listBox.ItemsSource = db.PetPostTexts.Local;
        }

        CollectionViewSource petPostTextViewSource;
        global::Model.WPF_ProjectDBEntities db = new Model.WPF_ProjectDBEntities();

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var a = from n in db.PetPostTexts
                    where n.Category == "Dog"
                    orderby n.DateTime descending
                    select n;
                this.listBox.ItemsSource=a.ToList();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var a = from n in db.PetPostTexts
                    where n.Category == "Cat"
                    orderby n.DateTime descending
                    select n;
                this.listBox.ItemsSource = a.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PetPostText a = (PetPostText)((Button)sender).DataContext;
            LoadPack(a.ContentText);
        }

        public void LoadPack(string SQLdata)
        {
            MemoryStream ms = new MemoryStream(ASCIIEncoding.Default.GetBytes(SQLdata));
            ms.Position = 0;
            richTextBox.SelectAll();
            richTextBox.Selection.Load(ms, DataFormats.Rtf);
            richTextBox.Document.PageWidth = 600;
            ms.Close();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            // 請勿在設計階段載入您的資料。
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//請在此載入資料並將結果指派給 CollectionViewSource。
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listBox.ItemsSource = db.PetPostTexts.Local;

            db.PetPostTexts.Local.RemoveAt(listBox.SelectedIndex);


            db.SaveChanges();
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //if (MessageBox.Show("Are you sure change?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            //{
            //    MemoryStream ms = new MemoryStream();
            //    TextRange range = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            //    range.Save(ms, DataFormats.Rtf);
                db.SaveChanges();
            //}
            //dataRow["FormattedText"] = this.richTextBox1.Rtf;
        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            this.listBox.ItemsSource = db.PetPostTexts.Local;
        }
    }
}
