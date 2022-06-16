<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book Processing Software for Public Libraries</title>
    <link rel="stylesheet" href="StyleSheet.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--<!--Navigation Bar-->--%>
            <div class="navbar">

                <!--"About" Button-->
                <strong><a href="Default.aspx">About</a></strong>
                <!--End of "About" Button-->

                <!--"Common Tasks" Dropdown Button-->
                <div class="dropdown"> 
                    <button class="dropbtn" id="commonTasks" runat="server">Common Tasks
                        <i class="fa fa-caret-down"></i>
                    </button>
                    <div class="dropdown-content">
                        <asp:LinkButton runat="server" ID="btnCheckIn" OnClick="btnCheckIn_Click">Check-In</asp:LinkButton>
                        <asp:LinkButton runat="server" ID="btnCheckOut" OnClick="btnCheckOut_Click">Check-Out</asp:LinkButton>
                        <asp:LinkButton runat="server" ID="btnRenewUserItems" OnClick="btnRenewUserItems_Click">Renew User Items</asp:LinkButton>
                        <asp:LinkButton runat="server" ID="btnBillUser" OnClick="btnBillUser_Click">Bill a User</asp:LinkButton>
                    </div>
                </div>
                <!--End of "Common Tasks" Dropdown Button-->

                <!--"Users" Dropdown Button-->
                <div class="dropdown">
                    <button class="dropbtn" id="users" runat="server">Users
                        <i class="fa fa-caret-down"></i>
                    </button>
                    <div class="dropdown-content">
                        <asp:LinkButton runat="server" ID="btnShowUser" OnClick="btnShowUser_Click">Show Library User</asp:LinkButton>
                        <asp:LinkButton runat="server" ID="btnRegisterUser" OnClick="btnRegisterUser_Click">Register Library User</asp:LinkButton>
                        <asp:LinkButton runat="server" ID="btnModifyUser" OnClick="btnModifyUser_Click">Modify Library User</asp:LinkButton>
                        <asp:LinkButton runat="server" ID="btnRemoveUser" OnClick="btnRemoveUser_Click">Remove Library User</asp:LinkButton>
                    </div>
                </div>
                <!--End of "Users" Dropdown Button-->

                <!--"Items" Button-->
                <asp:LinkButton runat="server" ID="items" OnClick="btnItems_Click">Items</asp:LinkButton>
                <!--End of "Items" Button-->

                <!--"Holds" Dropdown Button-->
                <div class="dropdown">
                    <button class="dropbtn" id="holdsDropdown" runat="server">Holds
                        <i class="fa fa-caret-down"></i>
                    </button>
                    <div class="dropdown-content" id="holds" runat="server">
                        <asp:LinkButton runat="server" ID="btnPlaceHold" OnClick="btnPlaceHold_Click">Place Hold</asp:LinkButton>
                        <!--<asp:LinkButton runat="server" ID="btnShowUserHolds" OnClick="btnShowUserHolds_Click">Show User Holds</asp:LinkButton>-->
                        <!--<asp:LinkButton runat="server" ID="btnModifyUserHolds" OnClick="btnModifyUserHolds_Click">Modify User Holds</asp:LinkButton>-->
                        <asp:LinkButton runat="server" ID="btnRemoveUserHolds" OnClick="btnRemoveUserHolds_Click">Remove User Holds</asp:LinkButton>
                        <asp:LinkButton runat="server" ID="btnShowTitleHolds" OnClick="btnShowTitleHolds_Click">Show Item/Title Holds</asp:LinkButton>
                        <!--<asp:LinkButton runat="server" ID="btnRemoveTitleHolds" OnClick="btnRemoveTitleHolds_Click">Remove Item/Title Holds</asp:LinkButton>-->
                        <asp:LinkButton runat="server" ID="btnHoldPullList" OnClick="btnHoldPullList_Click">Hold Pull List</asp:LinkButton>
                        <asp:LinkButton runat="server" ID="btnPullListProcessing" OnClick="btnPullListProcessing_Click">Pull List Processing</asp:LinkButton>
                        <asp:LinkButton runat="server" ID="btnTransitHoldProcessing" OnClick="btnTransitHoldProcessing_Click">Transit Hold Processing</asp:LinkButton>
                    </div>
                </div>
                <!--End of "Holds" Dropdown Button-->

                <!--Login/Logout Buttons (Only one can be visible at a time)-->
                <asp:LinkButton runat="server" ID="login" OnClick="Login_Click">Log In</asp:LinkButton>
                <asp:LinkButton runat="server" ID="logout" Visible="false" OnClick="Logout_Click">Log Out</asp:LinkButton>
                <!--End of Login/Logout Buttons-->

            </div>
            <!--End of Navigation Bar-->

            <!--"About" Page Content-->
            <div class="about_content" runat="server" id="about_content" visible="true">
                <h1><asp:Label runat="server" ID="welcomeText">Welcome! You are not logged in.</asp:Label></h1>
                <br />
                <h2><asp:Label runat="server" ID="libCardText">Your library card number is: </asp:Label></h2>
                <br />
                <h2><asp:Label runat="server" ID="adminText">You are not an admin.</asp:Label></h2>
            </div>
            <!--End of "About" Page Content-->

            <!--"CheckIn" Page Content-->
            <div class="checkin_content" runat="server" id="checkin_content" Visible="false">
                <div class="checkin_content_1" style="width:50%; float:left;">
                    <h1><asp:Label runat="server">Check-In</asp:Label></h1>
                    <h2>Required Fields:</h2>
                    <p>Item ID: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_checkin_ID" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                    <p>Item Title: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_checkin_title"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                    <p>Item Author: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_checkin_author"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                    <p>Dewey Call Number: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_checkin_dewey_call_no"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                    <p>ISBN10: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_checkin_isbn10"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                    <p>ISBN13: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_checkin_isbn13"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                    <br /><br /><br />
                    <asp:Button runat="server" class="buttons" ID="checkin_item" OnClick="btn_checkin_item" Text="Check In"/>
                </div>
                <div class="checkin_content_2" style="width:50%; float:right;">
                    <h2>Optional Fields:</h2>
                    <p>Publication Info: <asp:TextBox runat="server" ID="txt_checkin_publication_info"></asp:TextBox></p>
                    <p>Physical Description: <asp:TextBox runat="server" ID="txt_checkin_physical_description"></asp:TextBox></p>
                    <p>Action Note: <asp:TextBox runat="server" ID="txt_checkin_action_note"></asp:TextBox></p>
                    <p>Subject Term: <asp:TextBox runat="server" ID="txt_checkin_subject_term"></asp:TextBox></p>
                    <p>Leader: <asp:TextBox runat="server" ID="txt_checkin_leader"></asp:TextBox></p>
                    <p>Control Number: <asp:TextBox runat="server" ID="txt_checkin_control_number"></asp:TextBox></p>
                    <p>Fixed Field Data: <asp:TextBox runat="server" ID="txt_checkin_fixed_field_data"></asp:TextBox></p>
                    <p>Natl Bibliography Info: <asp:TextBox runat="server" ID="txt_checkin_natl_bibliography_info"></asp:TextBox></p>
                    <p>Cataloging Source: <asp:TextBox runat="server" ID="txt_checkin_cataloging_source"></asp:TextBox></p>
                    <p>LLC Call Number: <asp:TextBox runat="server" ID="txt_checkin_llc_call_number"></asp:TextBox></p>
                    <p>General Note: <asp:TextBox runat="server" ID="txt_checkin_general_note"></asp:TextBox></p>
                    <p>Bibliography Note: <asp:TextBox runat="server" ID="txt_checkin_bibliography_note"></asp:TextBox></p>
                </div>
            </div>
            <!--End of "CheckIn" Page Content-->

            <!--"CheckOut" Page Content-->
            <div class="checkout_content" runat="server" id="checkout_content" Visible="false">
                <h1><asp:Label runat="server">Check-Out</asp:Label></h1>
                <p>Item ID: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_checkout_ID" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <asp:Button runat="server" class="buttons" ID="checkout_item" OnClick="btn_checkout_item" Text="Check Out"/>
            </div>
            <!--End of "CheckOut" Page Content-->

            <!--"RenewUserItems" Page Content-->
            <div class="renewuseritems_content" runat="server" id="renewuseritems_content" Visible="false">
                <h1><asp:Label runat="server">Renew User Items</asp:Label></h1>
                <p>Item ID: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_renew_user_items_ID" MaxLength="14" Placeholder="39065XXXXXXXXX"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <p>New Due Date: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_renew_user_items_new_due_date" MaxLength="8" Placeholder="MMDDYYYY"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <asp:Button runat="server" class="buttons" ID="renew_user_item" OnClick="btn_renew_user_item" Text="Renew Item"/>
            </div>
            <!--End of "RenewUserItems" Page Content-->

            <!--"BillUser" Page Content-->
            <div class="billuser_content" runat="server" id="billuser_content" Visible="false">
                <h1><asp:Label runat="server">Bill a User</asp:Label></h1>
                <p>User to bill's ID: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_bill_user_ID" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <p>Amount to bill user: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_bill_user_amount" MaxLength="10"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <asp:Button runat="server" class="buttons" ID="bill_user" OnClick="btn_bill_user" Text="Bill User"/>
            </div>
            <!--End of "BillUser" Page Content-->

            <!--"ShowUser" Page Content-->
            <div class="showuser_content" runat="server" id="showuser_content" Visible="false">
                <h1><asp:Label runat="server">Show User</asp:Label></h1>
                <p>User's ID: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_show_user_ID" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <asp:Button runat="server" class="buttons" ID="show_user" OnClick="btn_show_user" Text="Show User Info"/><br />
                <asp:Label runat="server" ID="showUserID"></asp:Label><br />
                <asp:Label runat="server" ID="showID"></asp:Label><br />
                <asp:Label runat="server" ID="showUserPIN"></asp:Label><br />
                <asp:Label runat="server" ID="showUsername"></asp:Label><br />
                <asp:Label runat="server" ID="showPassword"></asp:Label><br />
                <asp:Label runat="server" ID="showFees"></asp:Label><br />
                <asp:Label runat="server" ID="showIsAdmin"></asp:Label><br />
            </div>
            <!--End of "ShowUser" Page Content-->

            <!--"RegisterUser" Page Content-->
            <div class="registeruser_content" runat="server" id="registeruser_content" Visible="false">
                <h1><asp:Label runat="server">Register User</asp:Label></h1>
                <p>Library Card Number: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_register_user_library_card_number" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <p>Library Card PIN: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_register_user_library_card_PIN" MaxLength="7"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <p>Username: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_register_user_username"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <p>Password: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_register_user_password"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <asp:CheckBox runat="server" Text="Is this user going to be an administrator?" ID="checkbox_register_user_isAdmin"/><strong style="color:red;">(Required)</strong>
                <asp:Button runat="server" class="buttons" ID="register_user" OnClick="btn_register_user" Text="Show User Info"/><br />
            </div>
            <!--End of "RegisterUser" Page Content-->

            <!--"ModifyUser" Page Content-->
            <div class="modifyuser_content" runat="server" id="modifyuser_content" Visible="false">
                <h1><asp:Label runat="server">Modify User</asp:Label></h1>
                <p>User's ID: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_modify_user_ID" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <p>User's New PIN: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_modify_user_new_PIN" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <p>User's New Username: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_modify_user_new_Username" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <p>User's New Password: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_modify_user_new_Password" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <p>Is the user now an admin?: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_modify_user_new_isAdmin" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <p>Total User Fees: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_modify_user_new_fees" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <asp:Button runat="server" class="buttons" ID="modify_user" OnClick="btn_modify_user" Text="Modify User Account"/>
            </div>
            <!--End of "ModifyUser" Page Content-->

            <!--"RemoveUser" Page Content-->
            <div class="removeuser_content" runat="server" id="removeuser_content" Visible="false">
                <h1><asp:Label runat="server">Remove User</asp:Label></h1>
                <p>User's ID: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_remove_user_ID" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <asp:Button runat="server" class="buttons" ID="remove_user" OnClick="btn_remove_user" Text="Remove User Account"/>
            </div>
            <!--End of "RemoveUser" Page Content-->

            <!--"Items" Page Content-->
            <div class="items_content" runat="server" id="items_content" Visible="false">
                <h1><asp:Label runat="server">Items</asp:Label></h1>
                <asp:PlaceHolder runat="server" ID="placeholder1"></asp:PlaceHolder>
                <!--TODO: Add list of books, and use the search bar above to be able to search for items that match the search query. like in a previous project.-->
            </div>
            <!--End of "Items" Page Content-->

            <!--"Place Hold" Page Content-->
            <div class="placehold_content" runat="server" id="placehold_content" Visible="false">
                <h1><asp:Label runat="server">Place a Hold</asp:Label></h1>
                <p>Item's ID: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_place_hold_item_ID" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <asp:Button runat="server" class="buttons" ID="place_hold" OnClick="btn_place_hold" Text="Place Hold"/>
                
            </div>
            <!--End of "Place Hold" Page Content-->

            <!--"Show User Hold" Page Content
            <div class="showuserholds_content" runat="server" id="showuserholds_content" Visible="false">
                <h1><asp:Label runat="server">Show User Holds</asp:Label></h1>
                <p>User's ID: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_show_user_holds_ID" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <asp:Button runat="server" class="buttons" ID="btn_show_user_holds" Text="Show User Holds"/>
            </div>-->
            <!--End of "Show User Hold" Page Content-->

            <!--"Modify User Hold" Page Content
            <div class="modifyuserholds_content" runat="server" id="modifyuserholds_content" Visible="false">
                <h1><asp:Label runat="server">Modify User Holds</asp:Label></h1>
                <p>User's ID: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_modify_user_holds_ID" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <asp:Button runat="server" class="buttons" ID="btn_modify_user_holds" Text="Modify User Holds"/>
            </div>
            End of "Modify User Hold" Page Content-->

            <!--"Remove User Hold" Page Content-->
            <div class="removeuserholds_content" runat="server" id="removeuserholds_content" Visible="false">
                <h1><asp:Label runat="server">Remove User Holds</asp:Label></h1>
                <p>Hold's ID: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_remove_user_holds_item_ID" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <asp:Button runat="server" class="buttons" ID="remove_user_hold" OnClick="btn_remove_user_hold" Text="Remove User Holds"/>
            </div>
            <!--End of "Remove User Hold" Page Content-->

            <!--"Show Title Hold" Page Content-->
            <div class="showtitleholds_content" runat="server" id="showtitleholds_content" Visible="false">
                <h1><asp:Label runat="server">Show Title Holds</asp:Label></h1>
                <p>Item's ID: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_show_title_holds_ID" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <asp:Button runat="server" class="buttons" ID="btn_show_title_holds" Text="View Title Holds"/>
            </div>
            <!--End of "Show Title Hold" Page Content-->

            <!--"Remove Title Hold" Page Content
            <div class="removetitleholds_content" runat="server" id="removetitleholds_content" Visible="false">
                <h1><asp:Label runat="server">Remove Title Holds</asp:Label></h1>
                <p>Item's ID: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_remove_title_holds_ID" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <asp:Button runat="server" class="buttons" ID="btn_remove_title_holds" Text="Remove Title Holds"/>
            </div>
            <!--End of "Remove Title Hold" Page Content-->

            <!--"Hold Pull List" Page Content-->
            <div class="holdpulllist_content" runat="server" id="holdpulllist_content" Visible="false">
                <h1><asp:Label runat="server">Hold Pull List</asp:Label></h1>
                <asp:Button runat="server" class="buttons" ID="btn_hold_pull_list" Text="View Hold Pull List"/>
            </div>
            <!--End of "Hold Pull List" Page Content-->

            <!--"Pull List Processing" Page Content-->
            <div class="pulllistprocessing_content" runat="server" id="pulllistprocessing_content" Visible="false">
                <h1><asp:Label runat="server">Pull List Processing</asp:Label></h1>
                <p>Item's ID: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_pull_list_processing_ID" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <asp:Button runat="server" class="buttons" ID="btn_pull_list_processing" Text="Process Item"/>
            </div>
            <!--End of "Pull List Processing" Page Content-->

            <!--"Transit Hold Processing" Page Content-->
            <div class="transitholdprocessing_content" runat="server" id="transitholdprocessing_content" Visible="false">
                <h1><asp:Label runat="server">Transit Holds Processing</asp:Label></h1>
                <p>Item's ID: <strong style="color:red;">*</strong><asp:TextBox runat="server" ID="txt_transit_hold_processing_ID" MaxLength="14"></asp:TextBox><strong style="color:red;">(Required)</strong></p>
                <asp:Button runat="server" class="buttons" ID="btn_transit_hold_processing" Text="Process Item"/>
            </div>
            <!--End of "Transit Hold Processing" Page Content-->
        </div>
        <div class="footer">
            <p>Ajay Arora</p>
        </div>
    </form>
</body>
</html>
