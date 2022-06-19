using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Domain;
using DAL;

namespace WaterCooperative
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonRegister_Click(object sender, EventArgs e)
        {
            var firstName = textFirstName.Text.Trim();
            var lastName = textLastName.Text.Trim();
            var username = textUsername.Text.Trim();
            var password = textPassword.Text.Trim();
            var repeatPassword = textRepeatPassword.Text.Trim();

            if (firstName == "")
            {
                lblError.Text = "Please Enter First Name!";
            }
            else
            {
                lblError.Text = "";
            }


            if (password != repeatPassword)
            {
                lblError.Text = "Password & Repeat Password should be same!";
                return;
            }
            var user = new Domain.Users
            {
                Username = username,
                Password = password,
                FirstName = firstName,
                LastName = lastName
            };
            if (UsersDAL.Insert(user))
            {
                lblError.Text = "User added Successfully";
            }
            else
            {
                lblError.Text = "Error";
            }
        }
    }
}