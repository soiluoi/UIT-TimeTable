using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Text;
using System.Timers; //this use for like you request some data from sites but if you wait too long (http not response so it will terminate the request and resend another request pack )
using System.Web;
using System.Web.Services;
using System.Xml;

namespace Crawler
{
    public partial class Form1 : Form
    {
        //8 info ? get a form of info like student id ,class,blah blah
        String classID;
        String className;
        String TeacherName;
        String Room;
        String Startday;
        String Endingday;
        String Timeoflesson;
        String Lesson;
            
                                         

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            WebRequest myWebRequest;
            WebResponse myWebResponse;
            String URL = textBox1.Text;

            myWebRequest = WebRequest.Create(https://daa.uit.edu.vn/user/login%26homepage?destination=node);
            //at line 29 ,replace URL with https://daa.uit.edu.vn/user/login%26homepage?destination=node
            //https://oep.uit.edu.vn/vi/node?destination=node
            //https://courses.uit.edu.vn/login/index.php

            myWebResponse = myWebRequest.GetResponse());//Returns a response from an Internet resource

            Stream streamResponse = myWebResponse.GetResponseStream();//return the data stream from the internet
                                                                      //and save it in the stream

            StreamReader sreader = new StreamReader(streamResponse);//reads the data stream
            Rstring = sreader.ReadToEnd();//reads it to the end
            String Links = GetContent();//gets the links only
            textBox1.Text = classID;
            textBox2.Text = className;
            textBox3.Text = TeacherName;
            textBox4.Text = Room;
            textBox5.Text = Startday;
            textBox6.Text = Endingday;
            textBox7.Text = Timeoflesson;
            textBox8.Text = Lesson;
            streamResponse.Close();
            sreader.Close();
            myWebResponse.Close();




        }

        private String GetContent(String Rstring)
        {
            String sString = "";
            HTMLDocument d = new HTMLDocument();
            IHTMLDocument2 doc = (IHTMLDocument2)d;
            doc.write(Rstring);

            IHTMLElementCollection L = doc.links;

            foreach (IHTMLElement links in L)
            {
                sString += links.getAttribute("href", 0);
                sString += "/n";
            }
            return sString;
        }
        /*public ISet<string> GetNewLinks(string content)
        {
            Regex regexLink = new Regex("(?<=<a\\s*?href=(?:'|\"))[^'\"]*?(?=(?:'|\"))");

            ISet<string> newLinks = new HashSet<string>();
            foreach (var match in regexLink.Matches(content))
            {
                if (!newLinks.Contains(match.ToString()))
                    newLinks.Add(match.ToString());
            }

            return newLinks;
        }*/
        
    }
}

//get content method=get new links method choose what your like