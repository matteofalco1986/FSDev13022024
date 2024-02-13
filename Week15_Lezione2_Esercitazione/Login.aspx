<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Week15_Lezione2_Esercitazione.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
            <label>Username</label>            
            <br />
            <br />

            <asp:TextBox ID="TxtPassword" runat="server"></asp:TextBox>
            <label>Password</label>
            <br />
            <br />
            
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
