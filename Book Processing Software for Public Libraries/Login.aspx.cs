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

    }
    protected void login_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\LibraryDatabase.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand("select * from dbo.Users where username=@userID and password=@userPIN", con);
        cmd.Parameters.AddWithValue("@userID", usernameField.Text);
        cmd.Parameters.AddWithValue("@userPIN", passwordField.Text);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        con.Open();
        int i = cmd.ExecuteNonQuery();
        con.Close();

        if (dt.Rows.Count > 0)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            errorLabel.Text = "Your username and PIN is incorrect";
            errorLabel.ForeColor = System.Drawing.Color.Red;

        }


    }
}  
