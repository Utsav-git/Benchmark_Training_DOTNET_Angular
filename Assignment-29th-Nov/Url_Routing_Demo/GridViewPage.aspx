<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewPage.aspx.cs" Inherits="Url_Routing_Demo.GridViewPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns ="False" >
            <Columns>
                <asp:TemplateField HeaderText ="Title">
                    
                    <ItemTemplate>
                        
                        <asp:HyperLink ID="HyperLink1" runat="server"  Text='<%# Eval("title") %>'  href='<%# GetRouteUrl("RouteForArticle", new {id = Eval("id"), title= getTitle(Eval("title"))})%>'>HyperLink</asp:HyperLink>

                    </ItemTemplate>

                </asp:TemplateField>


                <asp:TemplateField HeaderText ="Description">
                
                    <ItemTemplate>
                        
                        <asp:Label id = "lbl_desc" runat="server" Text='<%#Eval("description") %>'></asp:Label>

                    </ItemTemplate>

                </asp:TemplateField>

                <asp:TemplateField HeaderText ="Author">
                
                    <ItemTemplate>
                        
                        <asp:Label id = "lbl_author" runat="server" Text='<%#Eval("author") %>'></asp:Label>

                    </ItemTemplate>

                </asp:TemplateField>

            </Columns>
        </asp:GridView>
       
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmpDBConnectionString %>" SelectCommand="SELECT * FROM [article]"></asp:SqlDataSource>
       
    </form>
</body>
</html>
