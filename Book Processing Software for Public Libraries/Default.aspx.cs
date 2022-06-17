using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.IO;

public partial class _Default : System.Web.UI.Page
{

    /// <summary>
    /// Initial state when the page first loads
    /// </summary>
    protected void Page_Load(object sender, EventArgs e)
    {
        about_content.Visible = true;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;

        if (Session["userID"] != null) //If the user is logged in.
        {
            welcomeText.Text = "Welcome, you are logged in as " + Session["Username"];
            libCardText.Text = "Your library card number is: " + Session["userID"];
            libCardText.Visible = true;
            adminText.Visible = true;
            login.Visible = false;
            logout.Visible = true;
        }
        else
        {                    //If the user is not logged in.
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
        }
        else                                  //If user is not an administrator.
        {
            adminText.Text = "You are not an admin.";
            commonTasks.Visible = false;
            users.Visible = false;
            holds.Visible = false;
        }

        if (items_content.Visible == true)
        {
            //
        }
    }

    /// <summary>
    /// Navbar Buttons
    /// </summary>

    protected void Login_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    protected void Logout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }

    protected void btnCheckIn_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = true;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;
    }

    protected void btnCheckOut_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = true;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;
    }

    protected void btnRenewUserItems_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = true;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;
    }

    protected void btnBillUser_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = true;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;
    }

    protected void btnShowUser_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = true;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;
    }

    protected void btnRegisterUser_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = true;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;
    }

    protected void btnModifyUser_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = true;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;
    }

    protected void btnRemoveUser_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = true;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;
    }

    protected void btnItems_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = true;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;

        //Display Materials Table
        StringBuilder table = new StringBuilder();
        SqlConnection itemCon = new SqlConnection();
        itemCon.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        itemCon.Open();
        SqlCommand itemCmd = new SqlCommand();
        itemCmd.CommandText = "Select * from dbo.Materials";
        itemCmd.Connection = itemCon;
        SqlDataReader rd = itemCmd.ExecuteReader();
        table.Append("<table border='1'>");
        table.Append("<tr><th>Id</th><th>DeweyCallNo</th><th>Title</th><th>Authors</th><th>ISBN10</th><th>ISBN13</th><th>CatalogingSource</th><th>isHeld</th><th>dueDate</th><th>heldBy</th>");
        table.Append("</tr>");

        if (rd.HasRows)
        {
            while (rd.Read())
            {
                table.Append("<tr>");
                table.Append("<td>" + rd[0] + "</td>");
                table.Append("<td>" + rd[1] + "</td>");
                table.Append("<td>" + rd[2] + "</td>");
                //table.Append("<td>" + rd[3] + "</td>");
                //table.Append("<td>" + rd[4] + "</td>");
                //table.Append("<td>" + rd[5] + "</td>");
                //table.Append("<td>" + rd[6] + "</td>");
                //table.Append("<td>" + rd[7] + "</td>");
                //table.Append("<td>" + rd[8] + "</td>");
                table.Append("<td>" + rd[9] + "</td>");
                //table.Append("<td>" + rd[10] + "</td>");
                //table.Append("<td>" + rd[11] + "</td>");
                //table.Append("<td>" + rd[12] + "</td>");
                //table.Append("<td>" + rd[13] + "</td>");
                table.Append("<td>" + rd[14] + "</td>");
                table.Append("<td>" + rd[15] + "</td>");
                table.Append("<td>" + rd[16] + "</td>");
                //table.Append("<td>" + rd[17] + "</td>");
                table.Append("<td>" + rd[18] + "</td>");
                table.Append("<td>" + rd[19] + "</td>");
                table.Append("<td>" + rd[20] + "</td>");
                table.Append("</tr>");
            }
        }
        table.Append("</table>");
        placeholder1.Controls.Add(new Literal { Text = table.ToString() });
        rd.Close();

    }

    protected void btnPlaceHold_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = true;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;
    }

    protected void btnShowUserHolds_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = true;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;
    }

    protected void btnModifyUserHolds_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = true;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;
    }

    protected void btnRemoveUserHolds_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = true;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;
    }

    protected void btnShowTitleHolds_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = true;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;
    }

    protected void btnRemoveTitleHolds_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = true;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;
    }

    protected void btnHoldPullList_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = true;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = false;

        //Display Materials Table
        StringBuilder table = new StringBuilder();
        SqlConnection itemCon = new SqlConnection();
        itemCon.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        itemCon.Open();
        SqlCommand itemCmd = new SqlCommand();
        itemCmd.CommandText = "Select * from dbo.Materials WHERE isHeld = 'Yes' AND isProcessed != 'Yes'";
        itemCmd.Connection = itemCon;
        SqlDataReader rd = itemCmd.ExecuteReader();
        table.Append("<table border='1'>");
        table.Append("<tr><th>Id</th><th>DeweyCallNo</th><th>Title</th><th>Authors</th><th>ISBN10</th><th>ISBN13</th><th>CatalogingSource</th><th>isHeld</th><th>dueDate</th><th>heldBy</th>");
        table.Append("</tr>");

        if (rd.HasRows)
        {
            while (rd.Read())
            {
                table.Append("<tr>");
                table.Append("<td>" + rd[0] + "</td>");
                table.Append("<td>" + rd[1] + "</td>");
                table.Append("<td>" + rd[2] + "</td>");
                //table.Append("<td>" + rd[3] + "</td>");
                //table.Append("<td>" + rd[4] + "</td>");
                //table.Append("<td>" + rd[5] + "</td>");
                //table.Append("<td>" + rd[6] + "</td>");
                //table.Append("<td>" + rd[7] + "</td>");
                //table.Append("<td>" + rd[8] + "</td>");
                table.Append("<td>" + rd[9] + "</td>");
                //table.Append("<td>" + rd[10] + "</td>");
                //table.Append("<td>" + rd[11] + "</td>");
                //table.Append("<td>" + rd[12] + "</td>");
                //table.Append("<td>" + rd[13] + "</td>");
                table.Append("<td>" + rd[14] + "</td>");
                table.Append("<td>" + rd[15] + "</td>");
                table.Append("<td>" + rd[16] + "</td>");
                //table.Append("<td>" + rd[17] + "</td>");
                table.Append("<td>" + rd[18] + "</td>");
                table.Append("<td>" + rd[19] + "</td>");
                table.Append("<td>" + rd[20] + "</td>");
                //table.Append("<td>" + rd[21] + "</td>");
                table.Append("</tr>");
            }
        }
        table.Append("</table>");
        placeholder2.Controls.Add(new Literal { Text = table.ToString() });
        rd.Close();
    }

    protected void btnPullListProcessing_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = true;
        //transitholdprocessing_content.Visible = false;
    }

    protected void btnTransitHoldProcessing_Click(object sender, EventArgs e)
    {
        about_content.Visible = false;
        checkin_content.Visible = false;
        checkout_content.Visible = false;
        renewuseritems_content.Visible = false;
        billuser_content.Visible = false;
        showuser_content.Visible = false;
        modifyuser_content.Visible = false;
        registeruser_content.Visible = false;
        removeuser_content.Visible = false;
        items_content.Visible = false;
        placehold_content.Visible = false;
        //showuserholds_content.Visible = false;
        //modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        //removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        //transitholdprocessing_content.Visible = true;
    }

    /// <summary>
    /// Functionality for the buttons on each page after data is entered.
    /// </summary>

    //When clicking the button on the check in page after all data is entered.
    protected void btn_checkin_item(object sender, EventArgs e)
    {
        string checkin_item_id = txt_checkin_ID.Text;
        string checkin_item_dewey_call_number = txt_checkin_dewey_call_no.Text;
        string checkin_item_title = txt_checkin_title.Text;
        string checkin_item_publication_info = txt_checkin_publication_info.Text;
        string checkin_item_physical_description = txt_checkin_physical_description.Text;
        string checkin_item_general_note = txt_checkin_general_note.Text;
        string checkin_item_bibliography_note = txt_checkin_bibliography_note.Text;
        string checkin_item_action_note = txt_checkin_action_note.Text;
        string checkin_item_subject_term = txt_checkin_subject_term.Text;
        string checkin_item_authors = txt_checkin_author.Text;
        string checkin_item_leader = txt_checkin_leader.Text;
        string checkin_item_control_no = txt_checkin_control_number.Text;
        string checkin_item_fixed_field_data = txt_checkin_fixed_field_data.Text;
        string checkin_item_natl_bibliography_no = txt_checkin_natl_bibliography_info.Text;
        string checkin_item_ISBN10 = txt_checkin_isbn10.Text;
        string checkin_item_ISBN13 = txt_checkin_isbn13.Text;
        string checkin_item_cataloging_source = txt_checkin_cataloging_source.Text;
        string checkin_item_LLC_call_no = txt_checkin_llc_call_number.Text;

        //If the item ID is 1-13 characters (Error)
        if (checkin_item_id.Length < 14 && checkin_item_id.Length > 0)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('The item ID is too short. It must be 14 numeric characters starting with 39065. The format should be 39065XXXXXXXXX.');", true);
        }
        //If the item ID is 0 characters (Error)
        else if (checkin_item_id.Length == 0)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert2", "alert('You must enter an item ID.');", true);
        }
        //If the item ID does not contain 39065 (Error)
        else if (!checkin_item_id.Contains("39065"))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert2", "alert('Item ID must start with 39065');", true);
        }
        //If the item has no title (Error)
        else if (checkin_item_title.Length == 0)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert3", "alert('You must enter a title for the item.');", true);
        }
        //If the item has no Author (Error)
        else if (checkin_item_authors.Length == 0)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert4", "alert('You must enter an author for the item.');", true);
        }
        //If the item has no dewey call number (Error)
        else if (checkin_item_dewey_call_number.Length == 0)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert5", "alert('You must enter a dewey call number for the item.');", true);
        }
        //If ISBN10 is the wrong length (Error)
        else if (checkin_item_ISBN10.Length != 10)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert6", "alert('ISBN10 is required and must be 10 digits long.');", true);
        }
        //If ISBN13 is the wrong length (Error)
        else if (checkin_item_ISBN13.Length != 13)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert7", "alert('ISBN13 is required and must be 13 digits long.');", true);
        }
        else //If there are no errors, proceed with adding the item to the database.
        {
            string sqlstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ajay\Desktop\Visual Studio Projects\Book Processing Software for Public Libraries\Book Processing Software for Public Libraries\App_Data\LibraryDatabase.mdf; Integrated Security = True";
            SqlConnection connection = new SqlConnection(sqlstring);
            connection.Open();

            string insertquery = "insert into dbo.Materials(Id, DeweyCallNo, Title, " +
                "PublicationInfo, PhysicalDescription, GeneralNote, " +
                "BibliographyNote, ActionNote, SubjectTerm, " +
                "Authors, Leader, ControlNo, " +
                "FixedFieldData, NatlBibliographyNo, ISBN10, " +
                "ISBN13, CatalogingSource, LCCallNo) " +
                "values(@Id, @DeweyCallNo, @Title, @PublicationInfo, " +
                "@PhysicalDescription, @GeneralNote, @BibliographyNote, " +
                "@ActionNote, @SubjectTerm, @Authors, @Leader, " +
                "@ControlNo, @FixedFieldData, @NatlBibliographyNo, @ISBN10, " +
                "@ISBN13, @CatalogingSource, @LCCallNo)";
            SqlCommand cmd = new SqlCommand(insertquery, connection);
            cmd.Parameters.AddWithValue("Id", checkin_item_id);
            cmd.Parameters.AddWithValue("DeweyCallNo", checkin_item_dewey_call_number);
            cmd.Parameters.AddWithValue("Title", checkin_item_title);
            cmd.Parameters.AddWithValue("PublicationInfo", checkin_item_publication_info);
            cmd.Parameters.AddWithValue("PhysicalDescription", checkin_item_physical_description);
            cmd.Parameters.AddWithValue("GeneralNote", checkin_item_general_note);
            cmd.Parameters.AddWithValue("BibliographyNote", checkin_item_bibliography_note);
            cmd.Parameters.AddWithValue("ActionNote", checkin_item_action_note);
            cmd.Parameters.AddWithValue("SubjectTerm", checkin_item_subject_term);
            cmd.Parameters.AddWithValue("Authors", checkin_item_authors);
            cmd.Parameters.AddWithValue("Leader", checkin_item_leader);
            cmd.Parameters.AddWithValue("ControlNo", checkin_item_control_no);
            cmd.Parameters.AddWithValue("FixedFieldData", checkin_item_fixed_field_data);
            cmd.Parameters.AddWithValue("NatlBibliographyNo", checkin_item_natl_bibliography_no);
            cmd.Parameters.AddWithValue("ISBN10", checkin_item_ISBN10);
            cmd.Parameters.AddWithValue("ISBN13", checkin_item_ISBN13);
            cmd.Parameters.AddWithValue("CatalogingSource", checkin_item_cataloging_source);
            cmd.Parameters.AddWithValue("LCCallNo", checkin_item_LLC_call_no);
            cmd.ExecuteNonQuery();
            connection.Close();
            //TODO: Error Handling and Success/Failure Message
        }
    }

    //When clicking the button on the check out page after all data is entered.
    protected void btn_checkout_item(object sender, EventArgs e)
    {
        string checkout_item_id = txt_checkout_ID.Text;
        string sqlstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ajay\Desktop\Visual Studio Projects\Book Processing Software for Public Libraries\Book Processing Software for Public Libraries\App_Data\LibraryDatabase.mdf; Integrated Security = True";
        SqlConnection connection = new SqlConnection(sqlstring);
        connection.Open();
        string removequery = "DELETE FROM dbo.Materials WHERE Id = @Id";
        SqlCommand cmd = new SqlCommand(removequery, connection);
        cmd.Parameters.AddWithValue("Id", checkout_item_id);
        int result = (Int32)cmd.ExecuteNonQuery();
        connection.Close();
        if (result < 1)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert8", "alert('This item does not exist.');", true);
        }
    }

    //When clicking the button on the renew item page after all data is entered.
    protected void btn_renew_user_item(object sender, EventArgs e)
    {
        string renew_user_item_id = txt_renew_user_items_ID.Text;
        string renew_user_item_due_date = txt_renew_user_items_new_due_date.Text;
        string sqlstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ajay\Desktop\Visual Studio Projects\Book Processing Software for Public Libraries\Book Processing Software for Public Libraries\App_Data\LibraryDatabase.mdf; Integrated Security = True";
        SqlConnection connection = new SqlConnection(sqlstring);
        connection.Open();
        string updatequery = "UPDATE dbo.Materials SET dueDate = @dueDate WHERE (Id = @Id AND isHeld = 'Yes')";
        SqlCommand cmd = new SqlCommand(updatequery, connection);
        cmd.Parameters.AddWithValue("Id", renew_user_item_id);
        cmd.Parameters.AddWithValue("dueDate", renew_user_item_due_date);
        int result = (Int32)cmd.ExecuteNonQuery();
        connection.Close();
        if (result < 1)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert9", "alert('This item does either does not exist, or it is not on hold.');", true);
        }
    }

    //When clicking the button on the bill user page after all data is entered.
    protected void btn_bill_user(object sender, EventArgs e)
    {
        string bill_user_id = txt_bill_user_ID.Text;
        string bill_user_amount = txt_bill_user_amount.Text;
        string sqlstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ajay\Desktop\Visual Studio Projects\Book Processing Software for Public Libraries\Book Processing Software for Public Libraries\App_Data\LibraryDatabase.mdf; Integrated Security = True";
        SqlConnection connection = new SqlConnection(sqlstring);
        connection.Open();

        string updatequery = "UPDATE dbo.Users SET fees = @fees WHERE userID = @userID";
        SqlCommand cmd = new SqlCommand(updatequery, connection);
        cmd.Parameters.AddWithValue("userID", bill_user_id);
        cmd.Parameters.AddWithValue("fees", bill_user_amount);
        int result = (Int32)cmd.ExecuteNonQuery();
        connection.Close();
        if (result < 1)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert10", "alert('This user does not exist.');", true);
        }
    }

    //When clicking the button on the show user page after all data is entered.
    protected void btn_show_user(object sender, EventArgs e)
    {
        string show_user_id = txt_show_user_ID.Text;
        using (SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ajay\Desktop\Visual Studio Projects\Book Processing Software for Public Libraries\Book Processing Software for Public Libraries\App_Data\LibraryDatabase.mdf; Integrated Security = True;"))
        {
            sqlcon.Open();
            string Query = "SELECT * FROM dbo.Users WHERE userID = @userID";
            SqlCommand sqlCmd = new SqlCommand(Query, sqlcon);
            sqlCmd.Parameters.AddWithValue("userID", show_user_id);
            //Reads each cell of a row in the materials database, so we can access all their user information from the database.
            using (SqlDataReader y = sqlCmd.ExecuteReader())
            {
                while (y.Read())
                {
                    showUserID.Text = "\nUser ID: " + show_user_id + "\n";
                    showID.Text = "System ID: " + y["ID"].ToString() + "\n";
                    showUserPIN.Text = "User PIN: " + y["userPIN"].ToString() + "\n";
                    showUsername.Text = "Username: " + y["Username"].ToString() + "\n";
                    showPassword.Text = "Password: " + y["Password"].ToString() + "\n";
                    showFees.Text = "Fees Due: " + y["fees"].ToString() + "\n";
                    showIsAdmin.Text = "Is Admin: " + y["isAdmin"].ToString();
                }
                if (!y.HasRows)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert11", "alert('This user does not exist.');", true);
                }
            }
            sqlcon.Close();
        }
    }

    //When clicking the button on the register user page after all data is entered.
    protected void btn_register_user(object sender, EventArgs e)
    {

        string register_user_id = txt_register_user_library_card_number.Text;
        string register_user_pin = txt_register_user_library_card_PIN.Text;
        string register_user_username = txt_register_user_username.Text;
        string register_user_password = txt_register_user_password.Text;
        string register_user_isAdmin = "";
        if (checkbox_register_user_isAdmin.Checked == true)
        {
            register_user_isAdmin = "Yes";
        }
        else
        {
            register_user_isAdmin = "No";
        }
        string register_user_fees = "$0";

        if (register_user_id.Length < 14)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert12", "alert('User ID must be 14 digits long.');", true);
        }
        else if (!register_user_id.Contains("29065"))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert13", "alert('User ID must start with 29065');", true);
        }
        else
        {
            string sqlstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ajay\Desktop\Visual Studio Projects\Book Processing Software for Public Libraries\Book Processing Software for Public Libraries\App_Data\LibraryDatabase.mdf; Integrated Security = True";
            SqlConnection connection = new SqlConnection(sqlstring);
            connection.Open();

            string insertquery = "insert into dbo.Users(Username, Password, isAdmin, userID, userPIN, fees) values(@Username, @Password, @isAdmin, @userID, @userPIN, @fees)";
            SqlCommand cmd = new SqlCommand(insertquery, connection);

            cmd.Parameters.AddWithValue("userID", register_user_id);
            cmd.Parameters.AddWithValue("userPIN", register_user_pin);
            cmd.Parameters.AddWithValue("Username", register_user_username);
            cmd.Parameters.AddWithValue("Password", register_user_password);
            cmd.Parameters.AddWithValue("isAdmin", register_user_isAdmin);
            cmd.Parameters.AddWithValue("fees", register_user_fees);

            cmd.ExecuteNonQuery();
            connection.Close();
            //TODO: Error Handling and Success/Failure Message
        }
    }

    //When clicking the button on the modify user page after all data is entered.
    protected void btn_modify_user(object sender, EventArgs e)
    {
        string modify_user_oldid = txt_modify_user_ID.Text;
        string modify_user_pin = txt_modify_user_new_PIN.Text;
        string modify_user_username = txt_modify_user_new_Username.Text;
        string modify_user_password = txt_modify_user_new_Password.Text;
        string modify_user_isadmin = txt_modify_user_new_isAdmin.Text;
        string modify_user_fees = txt_modify_user_new_fees.Text;
        string sqlstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ajay\Desktop\Visual Studio Projects\Book Processing Software for Public Libraries\Book Processing Software for Public Libraries\App_Data\LibraryDatabase.mdf; Integrated Security = True";
        SqlConnection connection = new SqlConnection(sqlstring);
        connection.Open();

        string updatequery = "UPDATE dbo.Users SET userPIN = @userPIN, Username = @Username, Password = @Password, isAdmin = @isAdmin, fees = @fees WHERE userID = @userID";
        SqlCommand cmd = new SqlCommand(updatequery, connection);
        cmd.Parameters.AddWithValue("userID", modify_user_oldid);
        cmd.Parameters.AddWithValue("userPIN", modify_user_pin);
        cmd.Parameters.AddWithValue("Username", modify_user_username);
        cmd.Parameters.AddWithValue("Password", modify_user_password);
        cmd.Parameters.AddWithValue("isAdmin", modify_user_isadmin);
        cmd.Parameters.AddWithValue("fees", modify_user_fees);
        int result = (Int32)cmd.ExecuteNonQuery();
        connection.Close();
        if (result < 1)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert15", "alert('Error: Either this user does not exist or not all appropriate fields were filled in.');", true);
        }
    }

    //When clicking the button on the remove user page after all data is entered.
    protected void btn_remove_user(object sender, EventArgs e)
    {
        string remove_user_id = txt_remove_user_ID.Text;
        string sqlstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ajay\Desktop\Visual Studio Projects\Book Processing Software for Public Libraries\Book Processing Software for Public Libraries\App_Data\LibraryDatabase.mdf; Integrated Security = True";
        SqlConnection connection = new SqlConnection(sqlstring);
        connection.Open();
        string removequery = "DELETE FROM dbo.Users WHERE userID = @userID";
        SqlCommand cmd = new SqlCommand(removequery, connection);
        cmd.Parameters.AddWithValue("userID", remove_user_id);
        int result = (Int32)cmd.ExecuteNonQuery();
        connection.Close();
        if (result < 1)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert14", "alert('This user does not exist.');", true);
        }
    }

    //When clicking the button on place hold after all data is entered.
    protected void btn_place_hold(object sender, EventArgs e)
    {

        string place_hold_id = txt_place_hold_item_ID.Text;
        string place_hold_isHeld = "Yes";
        string place_hold_dueDate = DateTime.Now.AddDays(7).ToString("MMddyyyy");
        string place_hold_heldBy = Session["userID"].ToString();
        string sqlstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ajay\Desktop\Visual Studio Projects\Book Processing Software for Public Libraries\Book Processing Software for Public Libraries\App_Data\LibraryDatabase.mdf; Integrated Security = True";
        SqlConnection connection = new SqlConnection(sqlstring);
        connection.Open();

        string updatequery = "UPDATE dbo.Materials SET isHeld = @isHeld, dueDate = @dueDate, heldBy = @heldBy WHERE Id = @Id AND isHeld != 'Yes'";
        SqlCommand cmd = new SqlCommand(updatequery, connection);
        cmd.Parameters.AddWithValue("Id", place_hold_id);
        cmd.Parameters.AddWithValue("isHeld", place_hold_isHeld);
        cmd.Parameters.AddWithValue("dueDate", place_hold_dueDate);
        cmd.Parameters.AddWithValue("heldBy", place_hold_heldBy);
        int result = (Int32)cmd.ExecuteNonQuery();
        connection.Close();
        if (result < 1)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert16", "alert('Error: Either this user does not exist or this item is already held.');", true);
        }
    }

    //When clicking the button on remove hold after all data is entered.
    protected void btn_remove_user_hold(object sender, EventArgs e)
    {

        string remove_hold_id = txt_remove_user_holds_item_ID.Text;
        string remove_hold_isHeld = "No";
        string remove_hold_dueDate = "";
        string remove_hold_heldBy = "";
        string sqlstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ajay\Desktop\Visual Studio Projects\Book Processing Software for Public Libraries\Book Processing Software for Public Libraries\App_Data\LibraryDatabase.mdf; Integrated Security = True";
        SqlConnection connection = new SqlConnection(sqlstring);
        connection.Open();

        string updatequery = "UPDATE dbo.Materials SET isHeld = @isHeld, dueDate = @dueDate, heldBy = @heldBy WHERE Id = @Id AND isHeld = 'Yes'";
        SqlCommand cmd = new SqlCommand(updatequery, connection);
        cmd.Parameters.AddWithValue("Id", remove_hold_id);
        cmd.Parameters.AddWithValue("isHeld", remove_hold_isHeld);
        cmd.Parameters.AddWithValue("dueDate", remove_hold_dueDate);
        cmd.Parameters.AddWithValue("heldBy", remove_hold_heldBy);
        int result = (Int32)cmd.ExecuteNonQuery();
        connection.Close();
        if (result < 1)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert17", "alert('Error: Either this item does not exist or this item already has no holds on it.');", true);
        }
    }

    //When clicking the button on show title hold after all data is entered.
    protected void btn_show_title_holds(object sender, EventArgs e)
    {
        string show_item_id = txt_show_title_holds_ID.Text;
        using (SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ajay\Desktop\Visual Studio Projects\Book Processing Software for Public Libraries\Book Processing Software for Public Libraries\App_Data\LibraryDatabase.mdf; Integrated Security = True;"))
        {
            sqlcon.Open();
            string Query = "SELECT * FROM dbo.Materials WHERE Id = @Id AND isHeld = 'Yes' AND isProcessed != 'Yes'";
            SqlCommand sqlCmd = new SqlCommand(Query, sqlcon);
            sqlCmd.Parameters.AddWithValue("Id", show_item_id);
            //Reads each cell of a row in the materials database, so we can access all their user information from the database.
            using (SqlDataReader y = sqlCmd.ExecuteReader())
            {
                if (y.Read())
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert18", "alert('This item is held by library user " + y["heldBy"].ToString() + ".');", true);
                }
                if (!y.HasRows)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert19", "alert('This item either doesn't exist or it has no holds on it.');", true);
                }
            }
            sqlcon.Close();
        }
    }

    //When clicking the button on pull list processing after all data is entered.
    protected void btn_pull_list_processing(object sender, EventArgs e)
    {
        string pull_list_item = txt_pull_list_processing_ID.Text;
        using (SqlConnection sqlcon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ajay\Desktop\Visual Studio Projects\Book Processing Software for Public Libraries\Book Processing Software for Public Libraries\App_Data\LibraryDatabase.mdf; Integrated Security = True;"))
        {
            sqlcon.Open();
            string Query = "SELECT * FROM dbo.Materials WHERE Id = @Id AND isProcessed != 'Yes' " + "UPDATE dbo.Materials SET isProcessed = 'Yes' WHERE Id = @Id";
            SqlCommand sqlCmd = new SqlCommand(Query, sqlcon);
            sqlCmd.Parameters.AddWithValue("Id", pull_list_item);
            //Reads each cell of a row in the materials database, so we can access all their user information from the database.
            using (SqlDataReader y = sqlCmd.ExecuteReader())
            {
                while (y.Read())
                {
                    //write info to a text file and print it. Then change 'isProcessed' to 'Yes'
                    string receiptText = "Item ID: " + y["Id"].ToString() + "\n" + "Held By: " + y["heldBy"].ToString() + "\n" + "Pick Up By: " + DateTime.Now.AddDays(7).ToString("MM/dd/yyyy"); //Environment.NewLine;
                    string path = HttpContext.Current.Server.MapPath(@"~/textFiles/receipt.txt");
                    File.CreateText(path).Close();
                    File.WriteAllText(path, receiptText);
                    //TO DO: Print the text file automatically (or open the print preview first, whichever works better).
                }
                if (!y.HasRows)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert20", "alert('This item has either already been processed or has no holds on it.');", true);
                }
            }
            sqlcon.Close();
        }
    }

}