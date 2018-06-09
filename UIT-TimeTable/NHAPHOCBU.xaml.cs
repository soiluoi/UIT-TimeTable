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
using System.IO;

namespace UIT_TimeTable
{
    /// <summary>
    /// Interaction logic for NHAPHOCBU.xaml
    /// </summary>
    public partial class NHAPHOCBU : Window
    {
        public NHAPHOCBU()
        {
            InitializeComponent();
        }

      
        private void btn_OK(object sender, RoutedEventArgs e)
        {
            if (tb_NghiHoc.Text != "")
            {
                FileStream fs = new FileStream("NghiHoc.txt", FileMode.Create);
                StreamWriter rd = new StreamWriter(fs, Encoding.Unicode);
                rd.WriteLine(tb_NghiHoc.Text);
                rd.Close();
            }
            if (tb_HocBu.Text != ""){
                FileStream fs = new FileStream("HocBu.txt", FileMode.Create);
                StreamWriter rd = new StreamWriter(fs, Encoding.Unicode);
                rd.WriteLine(tb_HocBu.Text);
                rd.Close();
            }
          
            this.Close();
        }
    }

}
