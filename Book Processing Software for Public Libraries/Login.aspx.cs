﻿using System;
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
        //Opens a connection to the SQL materials database
        using (SqlConnection sqlcon2 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ajay\Desktop\Visual Studio Projects\Book Processing Software for Public Libraries\Book Processing Software for Public Libraries\App_Data\LibraryDatabase.mdf; Integrated Security = True;"))
        {
            sqlcon2.Open();
            string Query2 = "SELECT * FROM dbo.Materials"; // WHERE Id = @Id";
            SqlCommand sqlCmd2 = new SqlCommand(Query2, sqlcon2);

            //Reads each cell of a row in the materials database, so we can access all their user information from the database.
            using (SqlDataReader y = sqlCmd2.ExecuteReader())
            {
                while (y.Read())
                {
                    Session["Id"] = y["Id"].ToString();
                    Session["DeweyCallNo"] = y["DeweyCallNo"].ToString();
                    Session["Title"] = y["Title"].ToString();
                    Session["PublicationInfo"] = y["PublicationInfo"].ToString();
                    Session["PhysicalDescription"] = y["PhysicalDescription"].ToString();
                    Session["GeneralNote"] = y["GeneralNote"].ToString();
                    Session["BibliographyNote"] = y["BibliographyNote"].ToString();
                    Session["ActionNote"] = y["ActionNote"].ToString();
                    Session["SubjectTerm"] = y["SubjectTerm"].ToString();
                    Session["Authors"] = y["Authors"].ToString();
                    Session["Leader"] = y["Leader"].ToString();
                    Session["ControlNo"] = y["ControlNo"].ToString();
                    Session["FixedFieldData"] = y["FixedFieldData"].ToString();
                    Session["NatlBibliographyNo"] = y["NatlBibliographyNo"].ToString();
                    Session["ISBN10"] = y["ISBN10"].ToString();
                    Session["ISBN13"] = y["ISBN13"].ToString();
                    Session["CatalogingSource"] = y["CatalogingSource"].ToString();
                    Session["LCCallNo"] = y["LCCallNo"].ToString();
                    Session["isHeld"] = y["isHeld"].ToString();
                    Session["dueDate"] = y["dueDate"].ToString();
                    //TODO: Error Handling

                }
            }
        }
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
            using (SqlDataReader x = sqlCmd.ExecuteReader())
            {
                while (x.Read())
                {
                    Session["userID"] = usernameField.Text.Trim();
                    Session["userPIN"] = passwordField.Text.Trim();
                    Session["Username"] = x["Username"].ToString();
                    Session["Password"] = x["Password"].ToString();
                    Session["isAdmin"] = x["isAdmin"].ToString();
                    Session["fees"] = x["fees"].ToString();
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
