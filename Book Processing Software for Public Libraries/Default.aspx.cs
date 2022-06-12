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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;

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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = true;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = true;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = true;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = true;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = true;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = true;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = true;
        transitholdprocessing_content.Visible = false;
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
        showuserholds_content.Visible = false;
        modifyuserholds_content.Visible = false;
        removeuserholds_content.Visible = false;
        showtitleholds_content.Visible = false;
        removetitleholds_content.Visible = false;
        holdpulllist_content.Visible = false;
        pulllistprocessing_content.Visible = false;
        transitholdprocessing_content.Visible = true;
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
        if (result < 1) { 
            ClientScript.RegisterStartupScript(this.GetType(), "myalert8", "alert('This item does not exist.');", true);
        }
    }
}