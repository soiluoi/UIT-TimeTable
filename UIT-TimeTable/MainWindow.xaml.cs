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
using Spire.Xls;

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
            ConvertExceltoText();
            createTBfromID();
            Display();

        }
        public void Display()
        {
            Container.Children.Clear();
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
            if (Crawler.GetCounter() == 1) { Crawler.Show(); }


        }
        private void btn_AC(object sender, RoutedEventArgs e)
        {
            WindowView.AddCourses AC = new WindowView.AddCourses();
            AC.Show();


        }
        private void X_click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
            //this.Close();

        }

        private void Window_Move(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        void ConvertExceltoText() {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(@"inputExcel.xlsx");
            Worksheet sheet = workbook.Worksheets[0];
            sheet.SaveToFile("ExceltoTxt.txt", ",", Encoding.UTF8);
        }
        void createTBfromID()
        {

            FileStream fr = new FileStream("ExceltoTxt.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fr, Encoding.Unicode);
            FileStream coursesIDfile = new FileStream("CoursesID.txt", FileMode.Open);
            StreamReader coursesID = new StreamReader(coursesIDfile, Encoding.Unicode);
            string[] ID = new string[10];
            int t = 0;
            while (!coursesID.EndOfStream) {
                ID[t] = coursesID.ReadLine();
                t++;
            }
            const char Space = '"';
            const char Comma = ',';
            char[] delimiters = new char[]{Space,Comma};

            FileStream fw = new FileStream("TimeTable.txt", FileMode.Create);
            StreamWriter wf = new StreamWriter(fw, Encoding.Unicode);
            while (!rd.EndOfStream)
            {
                string readFromFile = rd.ReadLine();
                string[] arr = readFromFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                foreach (string tID in ID)
                if (arr[0] == tID)
                {
                    wf.WriteLine(arr[0] );
                    wf.WriteLine(arr[1]);
                    wf.WriteLine(arr[2]);
                    wf.WriteLine("P " + arr[5]);
                    wf.WriteLine("BĐ:"+arr[6]);
                    wf.WriteLine("KT:"+arr[7]);
                    wf.WriteLine(arr[3]);
                    wf.WriteLine(arr[4][0]);
                    wf.WriteLine(arr[4].Length);
                }
            }
            coursesIDfile.Close();
            rd.Close();
            wf.Close();

        }
    }

   
    

    


}
