using System;
using System.Collections;
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

namespace ArrayList_HW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;

        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
            txt_box.Focus();
        }


        private void Add_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Add(txt_box.Text);
            txt_box.Text = String.Empty;
            txt_box.Focus();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(txt_box.Text);
            txt_box.Text = String.Empty;
            txt_box.Focus();
        }

        private void ShowAll_Click(object sender, RoutedEventArgs e)
        {
           foreach(string data in arrayList )
            {
                MessageBox.Show(data);
                
            }
        }
    }
}
