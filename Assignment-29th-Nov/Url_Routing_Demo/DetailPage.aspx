<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailPage.aspx.cs" Inherits="Url_Routing_Demo.DetailPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Article</h1>

            <h3>Title: </h3>
            <asp:Label ID="lbl_title" runat="server" Text="Label"></asp:Label>

            <h3>Author: </h3>
            <asp:Label ID="lbl_author" runat="server" Text="Label"></asp:Label>

             <h3>Description: </h3>
            <asp:Label ID="lbl_desc" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
