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
                int Class=Int32.Parse(rd.ReadLine()); 
                AddSub(new CourseSchedule(classID,className,teacher,room,enddate,startdate), day, startclass, Class);
            }

            rd.Close();
        }
        public void AddSub(CourseSchedule Info, int Day, int StartCalss, int Class)
        {
            
                Container.Children.Add(new Class.CourseDisplay(Info, Day, StartCalss, Class));
            
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
    
    public class CourseSchedule
    {
        public string Name { set; get; }
        public string Room { set; get; }
        public string Teacher { set; get; }
        public string ID { set; get; }
        public string StartD { set; get; }
        public string EndD { set; get; }
        public CourseSchedule(string _ID, string _name, string _teacher, string _room, string _sd, string _ed)
        {
            ID = _ID;
            Name = _name;
            Room = _room;
            Teacher = _teacher;
            StartD = _sd;
            EndD = _ed;
        }
    }
   
   
}
