using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userID"]!=null) //If the user is logged in.
        {
            welcomeText.Text = "Welcome, you are logged in as " + Session["Username"];
            libCardText.Text = "Your library card number is: " + Session["userID"];
            libCardText.Visible = true;
            adminText.Visible = true;
            login.Visible = false;
            logout.Visible = true;
        } else {                    //If the user is not logged in.
            welcomeText.Text = "Welcome! you are not logged in.";
            libCardText.Visible = false;
            adminText.Visible = false;
            commonTasks.Visible = false;
            users.Visible = false;
            holds.Visible = false;
            holdsDropdown.Visible = false;
            items.Visible = false;
            login.Visible = true;
            logout.Visible = false;
        }

        if ((string)Session["isAdmin"] == "Yes") //If user is an administrator.
        {
            adminText.Text = "You are an admin.";
            commonTasks.Visible = true;
            users.Visible = true;
            holds.Visible = true; 
        } else                                  //If user is not an administrator.
        {
            adminText.Text = "You are not an admin.";
            commonTasks.Visible = false;
            users.Visible = false;
            holds.Visible = false;
        }
    }
    protected void Login_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    protected void Logout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
}