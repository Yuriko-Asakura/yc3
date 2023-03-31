using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;
using ychebpr1.yc1DataSetTableAdapters;

namespace ychebpr1
{
    /// <summary>
    /// Логика взаимодействия для element.xaml
    /// </summary>
    public partial class element : Window
    {

        elementTableAdapter elements = new elementTableAdapter();
        public element()
        {
            InitializeComponent();
            ycheb.ItemsSource = elements.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            elementTableAdapter elements = new elementTableAdapter();
            elements.InsertQuery(tx.Text);
            ycheb.ItemsSource = elements.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (ycheb.SelectedItem as DataRowView).Row[0];
            elements.DeleteQuery(Convert.ToInt32(id));
            ycheb.ItemsSource = elements.GetData();
        }
    }
}
