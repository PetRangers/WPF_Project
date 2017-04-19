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

namespace PetWPF
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class PetPostMain : UserControl
    {
        public PetPostMain()
        {
            InitializeComponent();
        }
        private void Post_Click(object sender, RoutedEventArgs e)
        {
            PetPostAddControl padd = new PetPostAddControl();
            this.listBox.Items.Clear();
            this.listBox.Items.Add(padd);
            //this.listBox.Children.Clear();
            //this.listBox.Children.Add(padd);

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            PetPostControl ppo = new PetPostControl();
            this.listBox.Items.Clear();
            this.listBox.Items.Add(ppo);
            //this.listBox.Children.Clear();
            //this.listBox.Children.Add(ppo);
        }
    }
}
