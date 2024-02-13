<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="Week15_Lezione2_Esercitazione.Logout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <label>Username</label>
            <br />
            <br />

            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <label>Password</label>
            <br />
            <br />

            <asp:Button ID="Logout_Btn" runat="server" Text="Logout" OnClick="Logout_Btn_Click" />
        </div>
    </form>
</body>
</html>
