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
    public partial class AddLinkCrawler : Window
    {
        static public int counter = 0;
        public AddLinkCrawler()
        {
            InitializeComponent();
            counter++;

        }
        public int GetCounter() {
            return counter;
        }
        private void tb_getfocus(object sender, RoutedEventArgs e)
        {
            if (tb_GetLink != null)
            {
                tb_GetLink.Text=""; 
            }
        }
       
        private void btn_GetLink(object sender, RoutedEventArgs e)
        {
            
            this.Close();

        }
    }
}
