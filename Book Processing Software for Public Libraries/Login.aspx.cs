using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        errorLabel.Visible = false;
        if (Session["userID"] != null) //If the user is logged in.
        {
            login.Visible = false;
            logout.Visible = true;
        }
        else
        {                    //If the user is not logged in.
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
            commonTasks.Visible = true;
            users.Visible = true;
            holds.Visible = true;
        }
        else                                  //If user is not an administrator.
        {
            commonTasks.Visible = false;
            users.Visible = false;
            holds.Visible = false;
        }
    }
    protected void login_Button_Click(object sender, EventArgs e)
    {
        //Opens a connection to the SQL users database.
        using (SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ajay\Desktop\Visual Studio Projects\Book Processing Software for Public Libraries\Book Processing Software for Public Libraries\App_Data\LibraryDatabase.mdf; Integrated Security = True;"))
        {
            sqlcon.Open();
            string Query = "SELECT * FROM dbo.Users WHERE userID=@userID AND userPIN=@userPIN";
            SqlCommand sqlCmd = new SqlCommand(Query, sqlcon);
            sqlCmd.Parameters.AddWithValue("@userID", usernameField.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@userPIN", passwordField.Text.Trim());
            //Reads each cell of a row in the user database, so we can access all their user information from the database.
            using(SqlDataReader x = sqlCmd.ExecuteReader()) {
                while (x.Read()) 
                {
                    Session["userID"] = usernameField.Text.Trim();
                    Session["Username"] = x["Username"].ToString();
                    Session["isAdmin"] = x["isAdmin"].ToString(); 
                    errorLabel.Visible = false;
                    Response.Redirect("default.aspx"); //Redirect to the homepage after logging in.
                }
                errorLabel.Visible = true;
            }
        }
    }
    protected void Login_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    protected void Logout_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
        Session.Abandon();
    }

    protected void btn_staySignedIn_CheckedChanged(object sender, EventArgs e)
    {
        //TODO: Stay Signed In Functionality
    }
}  
