using System;
using System.Net;
using System.IO;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        text1.Text = GetWebSiteContents("https://daa.uit.edu.vn/sinhvien/thoikhoabieu");
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
}

//day la file xuat tkb ra lay tu crawler (tkb cua daa va oep giong nhau