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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FileStream fs = new FileStream("Tudattenfile.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.Unicode);
                         while (!rd.EndOfStream)
            {
                string classID = rd.ReadLine();
                string className = rd.ReadLine();
                string teacher = rd.ReadLine();
                string room = rd.ReadLine();
                string enddate = rd.ReadLine();
                string startdate = rd.ReadLine();
                int day = Int32.Parse(rd.ReadLine());
                int startclass = Int32.Parse(rd.ReadLine());
                int Class = Int32.Parse(rd.ReadLine());
                
            }

            rd.Close();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            FileStream fs = new FileStream("Tudattenfile2.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.Unicode);
            while (!rd.EndOfStream)
            {
                string classID = rd.ReadLine();
                string className = rd.ReadLine();
                string teacher = rd.ReadLine();
                string room = rd.ReadLine();
                string enddate = rd.ReadLine();
                string startdate = rd.ReadLine();
                int day = Int32.Parse(rd.ReadLine());
                int startclass = Int32.Parse(rd.ReadLine());
                int Class = Int32.Parse(rd.ReadLine());

            }

            rd.Close();

        }
    }
    
}
