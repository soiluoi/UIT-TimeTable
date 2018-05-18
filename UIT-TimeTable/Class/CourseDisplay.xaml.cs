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

namespace UIT_TimeTable.Class
{
    /// <summary>
    /// Interaction logic for CourseDisplay.xaml
    /// </summary>
    public partial class CourseDisplay : UserControl
    {
        public CourseDisplay()
        {
            InitializeComponent();
            
        }
        public CourseDisplay(CourseSchedule _CourseSchedule, int Day, int StartClass , int Class)
        {
            InitializeComponent();
            double stdH = this.Height;
            this.CourseName.Text = _CourseSchedule.Name;
            this.CourseID.Text = _CourseSchedule.ID;
            this.Teacher.Text = _CourseSchedule.Teacher;
            this.Room.Text = _CourseSchedule.Room;
            this.EndDate.Text = _CourseSchedule.EndD;
            this.StartDate.Text = _CourseSchedule.StartD;
            this.Height = stdH*Class;
            Grid.SetRow(this, StartClass-1);
            Grid.SetColumn(this, Day-2);
            Grid.SetRowSpan(this, Class);
            //this.Height = { Binding ActualWidth, ElementName = Tb}
        }
    }
}
