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
            <div class="navbar">
                <strong><a href="Default.aspx">About</a></strong>
                    
                <div class="dropdown"> 
                    <button class="dropbtn" id="commonTasks" runat="server">Common Tasks
                        <i class="fa fa-caret-down"></i>
                    </button>
                    <div class="dropdown-content">
                        <a href="#">Check-In</a>
                        <a href="#">Check-Out</a>
                        <a href="#">Renew User Items</a>
                        <a href="#">Bill a User</a>
                    </div>
                </div>

                <div class="dropdown">
                    <button class="dropbtn" id="users" runat="server">Users
                        <i class="fa fa-caret-down"></i>
                    </button>
                    <div class="dropdown-content">
                        <a href="#">Show Library User</a>
                        <a href="#">Register Library User</a>
                        <a href="#">Modify Library User</a>
                        <a href="#">Remove Library User</a>
                    </div>
                </div>

                <a href="#about" id="items" runat="server">Items</a>

                <div class="dropdown">
                    <button class="dropbtn" id="holdsDropdown" runat="server">Holds
                        <i class="fa fa-caret-down"></i>
                    </button>
                    <div class="dropdown-content" id="holds" runat="server">
                        <a href="#">Place Hold</a>
                        <a href="#">Show User Holds</a>
                        <a href="#">Modify User Holds</a>
                        <a href="#">Remove User Holds</a>
                        <a href="#">Show Item/Title Holds</a>
                        <a href="#">Remove Item/Title Holds</a>
                        <a href="#">Hold Pull List</a>
                        <a href="#">Pull List Processing</a>
                        <a href="#">Transit Holds Processing</a>
                    </div>
                </div>
                <asp:LinkButton runat="server" ID="login" OnClick="Login_Click">Log In</asp:LinkButton>
                <asp:LinkButton runat="server" ID="logout" Visible="false" OnClick="Logout_Click">Log Out</asp:LinkButton>
            </div>
            <asp:Label runat="server" ID="welcomeText">Welcome! You are not logged in.</asp:Label>
            <br />
            <asp:Label runat="server" ID="libCardText">Your library card number is: </asp:Label>
            <br />
            <asp:Label runat="server" ID="adminText">You are not an admin.</asp:Label>
        </div>
    </form>
</body>
</html>
