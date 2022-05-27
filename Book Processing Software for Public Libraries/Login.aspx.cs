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
    }
    protected void login_Click(object sender, EventArgs e)
    {
        using (SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ajay\Desktop\Visual Studio Projects\Book Processing Software for Public Libraries\Book Processing Software for Public Libraries\App_Data\LibraryDatabase.mdf; Integrated Security = True;"))
        {
            sqlcon.Open();
            string Query = "SELECT COUNT(1) FROM dbo.Users WHERE userID=@userID AND userPIN=@userPIN";
            SqlCommand sqlCmd = new SqlCommand(Query, sqlcon);
            sqlCmd.Parameters.AddWithValue("@userID", usernameField.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@userPIN", passwordField.Text.Trim());
            //sqlCmd.Parameters.AddWithValue("@Username", SqlDbType.VarChar);
            int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            if (count == 1)
            {
                Session["userID"] = usernameField.Text.Trim();
                errorLabel.Visible = false;
                Response.Redirect("default.aspx");
            }
            else
            {
                errorLabel.Visible = true;
            }

        }
        


    }
}  
