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
        public CourseDisplay(CourseSchedule _CourseSchedule, int day, int startL, int numL)
        {
            this.Background = Brushes.White;
            InitializeComponent();
            double stdH = this.Height;
            this.CourseName.Text = _CourseSchedule.Name;
            this.CourseID.Text = _CourseSchedule.ID;
            this.Teacher.Text = _CourseSchedule.Teacher;
            this.Room.Text = _CourseSchedule.Room;
            this.EndDate.Text = _CourseSchedule.EndD;
            this.StartDate.Text = _CourseSchedule.StartD;
            this.Height = stdH * numL;
           // float t = Grid.GetColumn(this).Equals.Width
            Grid.SetRow(this, startL );
            Grid.SetColumn(this, day - 2);
            Grid.SetRowSpan(this, numL);
        }
    }
}
