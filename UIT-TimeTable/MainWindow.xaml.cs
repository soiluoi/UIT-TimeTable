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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    // 1 hoc bu - blue
    // 2 doi phong - doi gio - red
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Display();

        }
        public void Display()
        {
            FileStream fs = new FileStream("TimeTable.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.Unicode);
            while (!rd.EndOfStream) {
                string classID = rd.ReadLine();
                string className = rd.ReadLine();
                string teacher = rd.ReadLine();
                string room = rd.ReadLine();
                string enddate = rd.ReadLine();
                string startdate = rd.ReadLine();
                int day = Int32.Parse(rd.ReadLine());
                int startclass = Int32.Parse(rd.ReadLine());
                int Class = Int32.Parse(rd.ReadLine());
                AddSub(new Class.CourseSchedule(classID, className, teacher, room, enddate, startdate), day, startclass, Class);
            }

            rd.Close();
        }
        public void AddSub(Class.CourseSchedule Info, int Day, int StartCalss, int Class)
        {

            Container.Children.Add(new Class.CourseDisplay(Info, Day, StartCalss, Class));

        }
        private void btn_ShowCrawler(object sender, RoutedEventArgs e)
        {
            WindowView.AddLinkCrawler Crawler = new WindowView.AddLinkCrawler();
            if (Crawler.GetCounter()==1) { Crawler.Show(); }
           

        }
        private void X_click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
           
        }

        private void Window_Move(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }

   
    

    


}
