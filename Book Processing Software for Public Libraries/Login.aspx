<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book Processing Software - Log In</title>
    <link rel="stylesheet" href="StyleSheet.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="navbar">
                <a href="Default.aspx">About</a>
                    
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
                <strong><asp:LinkButton runat="server" ID="login" OnClick="Login_Click">Log In</asp:LinkButton></strong>
                <strong><asp:LinkButton runat="server" ID="logout" Visible="false" OnClick="Logout_Click">Log Out</asp:LinkButton></strong>
            </div>

            <div class="loginForm">
                <div class="loginFormContent">
                    <h1>Login</h1>
                    <strong>User ID: <strong style="color:red;">*</strong></strong>
                    <asp:TextBox runat="server" ID="usernameField" placeholder="(your library card number)" MaxLength="14" style="border: 2px solid grey; border-radius: 4px;"></asp:TextBox>
                    <strong style="color: red;">(Required)</strong>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ControlToValidate="usernameField" ErrorMessage="Please Enter Your Username" ForeColor="Red"></asp:RequiredFieldValidator>  
                    <br />
                    <strong>PIN No: <strong style="color:red;">*</strong></strong>
                    <asp:TextBox runat="server" ID="passwordField" placeholder="(last 7 digits of your phone #)" MaxLength="7" style="border: 2px solid grey; border-radius: 4px;" TextMode="Password"></asp:TextBox>
                    <strong style="color: red;">(Required)</strong>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="passwordField" ErrorMessage="Please Enter Your Password" ForeColor="Red"></asp:RequiredFieldValidator>  
                    <br />
                    <asp:CheckBox runat="server" Text="Stay signed in?" OnCheckedChanged="btn_staySignedIn_CheckedChanged" ID="btn_staySignedIn"/>
                    <br />
                    <br />
                    <asp:Button runat="server" class="buttons" Text="Log In!" onclick="login_Button_Click" />
                    <asp:Label ID="errorLabel" runat="server" Text="Error: Incorrect Login Details" ForeColor="Red"></asp:Label>
                </div>
            </div>
            <div class="footer">
                <p>Ajay Arora</p>
            </div>
        </div>
    </form>
</body>
</html>
