<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirm_faculty.aspx.cs" Inherits="student_registration.Admin.Confirmfaculty" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    Student Users Confirmation
</head>
<body style="background-color:#f3cded;">
    <form id="form1" runat="server">
        <div>
              <asp:GridView ID="GridView1" runat="server" DataKeyNames="lid1" OnRowDeleting="GridView1_RowDeleting" >
                <Columns>
                    <asp:CommandField HeaderText="Sts" ShowDeleteButton="True" DeleteText="confirm" />
                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
