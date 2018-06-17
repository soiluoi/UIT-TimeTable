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
using System.Windows.Shapes;
using System.IO;
namespace UIT_TimeTable.WindowView
{
    /// <summary>
    /// Interaction logic for AddCourses.xaml
    /// </summary>
    public partial class AddCourses : Window
    {
        public AddCourses()
        {
            InitializeComponent();
        }
        private void tb_gotfocus(object sender, RoutedEventArgs e)
        {   
            if (tb_CourseID != null)
            {
                tb_CourseID.Text = "";
            }
        }
        private void btn_OK(object sender, RoutedEventArgs e)
        {
            if (tb_CourseID.Text != "")
            {
                FileStream fs = new FileStream("CoursesID.txt", FileMode.Create);
                StreamWriter rd = new StreamWriter(fs, Encoding.Unicode);
                rd.WriteLine(tb_CourseID.Text);
                rd.Close();
            }
            this.Close();
        }
    }
}
