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
}