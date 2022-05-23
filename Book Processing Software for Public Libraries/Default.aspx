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
                <a href="#about">About</a>
                    
                <div class="dropdown">
                    <button class="dropbtn">Common Tasks
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
                    <button class="dropbtn">Users
                        <i class="fa fa-caret-down"></i>
                    </button>
                    <div class="dropdown-content">
                        <a href="#">Admin Log In</a>
                        <a href="#">Admin Log Out</a>
                        <a href="#">Show Library User</a>
                        <a href="#">Register Library User</a>
                        <a href="#">Modify Library User</a>
                        <a href="#">Remove Library User</a>
                    </div>
                </div>

                <a href="#about">Items</a>

                <div class="dropdown">
                    <button class="dropbtn">Holds
                        <i class="fa fa-caret-down"></i>
                    </button>
                    <div class="dropdown-content">
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
            </div>
        </div>
    </form>
</body>
</html>
