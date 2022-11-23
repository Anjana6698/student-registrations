<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="student_registration.Guest.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#fabff2;">
    <form id="form1" runat="server">
        <div>
             <h2 style="margin-left: 495px;margin-top: 100px" >
               USER LOGIN</h2>

            <asp:Label ID="Label1" runat="server" Text="Username" style="margin-left: 500px"></asp:Label>
            <br />

            <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="185px" style="margin-left: 500px"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Password" style="margin-left: 500px"></asp:Label>
            <br />

            <asp:TextBox ID="TextBox2" runat="server" Height="29px" TextMode="Password" style="margin-left: 500px" Width="185px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" Height="34px" OnClick="Button1_Click" style="margin-left: 500px" Width="113px" /><br /><br />
            <a href="../admin/admin_login.aspx" style="margin-left: 500px">Admin Login</a>
        </div>
    </form>
</body>
</html>
