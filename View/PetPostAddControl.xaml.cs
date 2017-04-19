using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace PetWPF
{
    /// <summary>
    /// PetPostAddControl.xaml 的互動邏輯
    /// </summary>
    public partial class PetPostAddControl : UserControl
    {
        public PetPostAddControl()
        {
            InitializeComponent();

            this.DataContext = true;

            DispatcherTimer messagetimer = new DispatcherTimer();
            messagetimer.Tick += new EventHandler(messageTimer_Tick);
            messagetimer.Start();

            comFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            comFontSize.ItemsSource = new List<double>() { 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 36, 48,72 };
        }
        void messageTimer_Tick(object sender,EventArgs e)
        {
            label1.Content = DateTime.Now.ToString();
        }

        Model.WPF_ProjectDBEntities db = new Model.WPF_ProjectDBEntities();
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog op = new Microsoft.Win32.OpenFileDialog();
            op.DefaultExt = ".jpg";
            op.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            Nullable<bool> result = op.ShowDialog();
            string a = op.FileName;

            Paragraph para = new Paragraph();
            System.Windows.Controls.Image img = new Image();
            img.Source = new BitmapImage(new Uri(a, UriKind.Relative));
            Figure fig = new Figure();

            //fig.Width = new FigureLength(100);
            fig.Height = new FigureLength(100);
            BlockUIContainer cont = new BlockUIContainer(img);
            fig.Blocks.Add(cont);
            para.Inlines.Add(fig);
            rich1.Blocks.Add(para);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comFontFamily.SelectedItem!=null)
            {
                richTextBox.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, comFontFamily.SelectedItem);
            }
        }
        public string SQLdata = "";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            using (MemoryStream ms=new MemoryStream())
            {
                tr.Save(ms, System.Windows.Forms.DataFormats.Rtf);
                SQLdata = ASCIIEncoding.Default.GetString(ms.ToArray());
                db.PetPostTexts.Add(new Model.PetPostText { ContentText = SQLdata, Category = Category.Text, Title = Title.Text,DateTime=DateTime.Now });
                if (MessageBox.Show("Are you sure post?","Warning",MessageBoxButton.YesNo,MessageBoxImage.Warning)==MessageBoxResult.Yes)
                {
                    db.SaveChanges();
                }
            }
        }

        private void comFontSize_TextChanged(object sender, RoutedEventArgs e)
        {
            richTextBox.Selection.ApplyPropertyValue(Inline.FontSizeProperty, comFontSize.Text);
        }

        private void richTextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp = richTextBox.Selection.GetPropertyValue(Inline.FontWeightProperty);
            btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));

            temp = richTextBox.Selection.GetPropertyValue(Inline.FontStyleProperty);
            btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));

            temp = richTextBox.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            btnUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

            temp = richTextBox.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            comFontFamily.SelectedItem = temp;

            temp = richTextBox.Selection.GetPropertyValue(Inline.FontSizeProperty);
            comFontSize.Text = temp.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            tr.Text = "";
            Title.Text = "";
            Category.SelectedIndex = 0;
            comFontFamily.SelectedIndex = 0;
            comFontSize.SelectedIndex = 0;
        }
    }
}
