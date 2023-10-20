using System;
using lib5;
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

namespace пр5_головиной
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Calc1_Click(object sender, RoutedEventArgs e)
        {
            //параметры машины
            int st = Convert.ToInt32(stamp.Text);
            int cy = Convert.ToInt32(cylinders.Text);
            int po = Convert.ToInt32(power.Text);
            //вызов класса и вывод
            Car calc = new Car();
            int money = calc.SetParams(st);

            int money2 = calc.SetParams(st, cy);

            int money3 = calc.SetParams(st,cy,po);
        }

    }
}
