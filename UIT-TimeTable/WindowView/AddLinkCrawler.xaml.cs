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
using System.Net;
using System.IO;
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
        private void tb_gotfocus(object sender, RoutedEventArgs e)
        {
            if (tb_GetLink != null)
            {
                tb_GetLink.Text=""; 
            }
        }
        protected void Page_Load(string url)
        {
            //text1.Text = GetWebSiteContents("https://daa.uit.edu.vn/sinhvien/thoikhoabieu");
        }

        protected string GetWebSiteContents(string url)
        {
            WebRequest req = WebRequest.Create(url);
            // Get the stream from the returned web response
            StreamReader sr = new StreamReader(req.GetResponse().GetResponseStream());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string strLine;
            // Read the stream a line at a time and place each one into the stringbuilder
            while ((strLine = sr.ReadLine()) != null)
            {
                // Ignore blank lines
                if (strLine.Length > 0) sb.Append(strLine);
            }
            sr.Close();
            return sb.ToString();
        }
        private void btn_GetLink(object sender, RoutedEventArgs e)
        {
            Page_Load(tb_GetLink.Text);
            this.Close();

        }
    }
}
