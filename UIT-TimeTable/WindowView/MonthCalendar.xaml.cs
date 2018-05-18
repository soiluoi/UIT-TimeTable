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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MonthCalendar : Window
    {
        public MonthCalendar()
        {
            InitializeComponent();
        }
        void Popup_Click(object sender, RoutedEventArgs e)
        {
            GroupBox aboutWindow = new GroupBox();
            aboutWindow.ShowDialog();
        }
        private void ClosePopupClicked(object sender, RoutedEventArgs e)
        {
            // if the Popup is open, then close it 
            if (StandardPopup.IsOpen) { StandardPopup.IsOpen = false; }
            
        }

        private void ShowPopupOffsetClicked(object sender, RoutedEventArgs e)
        {
            // open the Popup if it isn't open already 
            if (!StandardPopup.IsOpen) { StandardPopup.IsOpen = true; }
            //var desktopWorkingArea = System.Windows.SystemParameters.WorkArea;
            //StandardPopup.HorizontalOffset = desktopWorkingArea.Right - this.Width;
            //StandardPopup.VerticalOffset = desktopWorkingArea.Bottom - this.Height;
        }
    }
    
}
