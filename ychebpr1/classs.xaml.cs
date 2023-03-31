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
using System.Xml.Linq;
using ychebpr1.yc1DataSetTableAdapters;

namespace ychebpr1
{
    /// <summary>
    /// Логика взаимодействия для classs.xaml
    /// </summary>
    public partial class classs : Window
    {

        classTableAdapter clas = new classTableAdapter();
        public classs()
        {
            InitializeComponent();
            ycheb.ItemsSource = clas.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clas.InsertQuery(tx.Text, tx2.Text);
            ycheb.ItemsSource = clas.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (ycheb.SelectedItem as DataRowView).Row[0];
            clas.DeleteQuery(Convert.ToInt32(id));
            ycheb.ItemsSource =clas.GetData();
        }
    }
}
