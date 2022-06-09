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

    protected void btn_checkin_item(object sender, EventArgs e)
    {
        string checkin_item_id = txt_checkin_ID.Text;
        string checkin_item_dewey_call_number = txt_checkin_dewey_call_no.Text;
        string checkin_item_title = txt_checkin_title.Text;
        string checkin_item_publication_info = txt_checkin_publication_info.Text;
        string checkin_item_physical_description = txt_checkin_physical_description.Text;
        //string checkin_item_general_note = txt_checkin_general_note.Text;
        //string checkin_item_bibliography_note = txt_checkin_bibliography_note.Text;
        string checkin_item_action_note = txt_checkin_action_note.Text;
        string checkin_item_subject_term = txt_checkin_subject_term.Text;
        string checkin_item_authors = txt_checkin_author.Text;
        //string checkin_item_held_by = txt_checkin_held_by.Text;
        string checkin_item_leader = txt_checkin_leader.Text;
        string checkin_item_control_no = txt_checkin_control_number.Text;
        string checkin_item_fixed_field_data = txt_checkin_fixed_field_data.Text;
        string checkin_item_natl_bibliography_no = txt_checkin_natl_bibliography_info.Text;
        string checkin_item_ISBN10 = txt_checkin_isbn10.Text;
        string checkin_item_ISBN13 = txt_checkin_isbn13.Text;
        //string checkin_item_system_control_number = txt_checkin_system_control_number.Text;
        string checkin_item_cataloging_source = txt_checkin_cataloging_source.Text;
        string checkin_item_LLC_call_no = txt_checkin_llc_call_number.Text;

        string sqlstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Ajay\Desktop\Visual Studio Projects\Book Processing Software for Public Libraries\Book Processing Software for Public Libraries\App_Data\LibraryDatabase.mdf; Integrated Security = True";
        SqlConnection connection = new SqlConnection(sqlstring);
        connection.Open();

        string insertquery = "insert into dbo.Materials(Id, DeweyCallNo, Title, " +
            "PublicationInfo, PhysicalDescription, " +
            "ActionNote, SubjectTerm, " +
            "Authors, Leader, ControlNo, " +
            "FixedFieldData, NatlBibliographyNo, ISBN10, " +
            "ISBN13, CatalogingSource, LCCallNo) " +
            "values(@Id, @DeweyCallNo, @Title, @PublicationInfo, " +
            "@PhysicalDescription, " +
            "@ActionNote, @SubjectTerm, @Authors, @Leader, " +
            "@ControlNo, @FixedFieldData, @NatlBibliographyNo, @ISBN10, " +
            "@ISBN13, @CatalogingSource, @LCCallNo)";
        SqlCommand cmd = new SqlCommand(insertquery, connection);
        cmd.Parameters.AddWithValue("Id", checkin_item_id);
        cmd.Parameters.AddWithValue("DeweyCallNo", checkin_item_dewey_call_number);
        cmd.Parameters.AddWithValue("Title", checkin_item_title);
        cmd.Parameters.AddWithValue("PublicationInfo", checkin_item_publication_info);
        cmd.Parameters.AddWithValue("PhysicalDescription", checkin_item_physical_description);
        //cmd.Parameters.AddWithValue("GeneralNote", checkin_item_id);
        //cmd.Parameters.AddWithValue("BibliographyNote", checkin_item_id);
        cmd.Parameters.AddWithValue("ActionNote", checkin_item_action_note);
        cmd.Parameters.AddWithValue("SubjectTerm", checkin_item_subject_term);
        cmd.Parameters.AddWithValue("Authors", checkin_item_authors);
        //cmd.Parameters.AddWithValue("HeldBy", checkin_item_id);
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
    }
}