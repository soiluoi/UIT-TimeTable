
using System.ComponentModel;
using System.Windows;

namespace UIT_TimeTable
{
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {
            LoginLayer.Visibility = Visibility.Visible;
            this.Close();
    
        }
        private void MenuItem_Click2a(object sender, RoutedEventArgs e)
       {
            this.Hide();
            //connect sql server ?? don't have it right now so just leave it here
       }
        private void MenuItem_Click2b(object sender, RoutedEventArgs e)
        {
            this.Hide();
            //connect to sql server ?? don't have it
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            //connect to sql server ?? don't have it
        }
          



       /*private void MenuItem_Click2a(object sender, RoutedEventArgs e)
       {
           Stage.Child = new UserControl1();
       }

       private void MenuItem_Click2b(object sender, RoutedEventArgs e)
       {
           var win = new Window1();
           win.Show();

       private void Login_Click(object sender, RoutedEventArgs e)
       {
           LoginLayer.Visibility = Model.Authentication.Authenticate1(txtStudentID.Text, txtPassword.Text) ? Visibility.Collapsed : Visibility.Visible;
       }

       internal void RaisePropertyChanged(string prop)
       {
           if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
       }
       public event PropertyChangedEventHandler PropertyChanged;*/

    }
}