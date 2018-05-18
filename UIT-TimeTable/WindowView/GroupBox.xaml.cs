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

namespace UIT_TimeTable.WindowView
{
    /// <summary>
    /// Interaction logic for GroupBox.xaml
    /// </summary>
    public partial class GroupBox : Window
    {
        public GroupBox()
        {
            InitializeComponent();
            Window_Loaded();
        }
        
        private void ok_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_Loaded()
        {
            var desktopWorkingArea = System.Windows.SystemParameters.WorkArea;
            this.Left = desktopWorkingArea.Right - this.Width;
            this.Top = desktopWorkingArea.Bottom - this.Height;
        }
    }

}
