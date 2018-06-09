using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIT_TimeTable.Class
{
    public class CourseSchedule
    {
        public string Name { set; get; }
        public string Room { set; get; }
        public string Teacher { set; get; }
        public string ID { set; get; }
        public string StartD { set; get; }
        public string EndD { set; get; }
        public string Stt { set; get; }
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
