<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirmuser.aspx.cs" Inherits="student_registration.Admin.Confirmuser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <h3>Student User Confirmation</h3>
</head>
<body style="background-color:#fdc8f6;">
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="lid1" OnRowDeleting="GridView1_RowDeleting1"  >
                <Columns>
                    <asp:CommandField HeaderText="Sts" ShowDeleteButton="True" DeleteText="confirm" />
                </Columns>

            </asp:GridView>

        </div>
    </form>
</body>
</html>
