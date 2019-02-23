using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ControlsDemo
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void LoginTapped(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
                DisplayAlert("Alert", "Please Enter UserName", "Ok");
            else if (string.IsNullOrEmpty(txtPassword.Text))
                DisplayAlert("Alert", "Please Enter Password", "Ok");
            else
                DisplayAlert("Alert", "userName" + " " + txtUserName.Text + " " + "txtPassword" + " " + txtPassword.Text, "Ok");
            // throw new NotImplementedException();
        }
    }
}
