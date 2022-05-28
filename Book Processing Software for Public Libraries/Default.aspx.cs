﻿using System;
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
        if (Session["userID"]!=null)
        {
            welcomeText.Text = "Welcome, you are logged in as " + Session["Username"];
        } else {
            welcomeText.Text = "Welcome! you are not logged in.";
        }
    }
}