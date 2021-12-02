<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Registration_Form.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <%-- First Name --%>
        <asp:Label ID="label_firstName" runat="server" Text="First Name"></asp:Label>
        <br/>
        <asp:TextBox ID="txt_box_firstName" runat="server" OnTextChanged="txt_box_firstName_TextChanged"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_box_firstName" ForeColor="Red" SetFocusOnError="True" Display="Dynamic">* First Name Required</asp:RequiredFieldValidator>
        <br/>

        <%-- Last Name --%>

        <asp:Label ID="label_lastName" runat="server" Text="Last Name"></asp:Label>
        <br/>
        <asp:TextBox ID="txt_box_lastName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ControlToValidate="txt_box_lastName">* Last Name Required</asp:RequiredFieldValidator>
        <br/>


        <%-- Email --%>
        <asp:Label ID="label_email" runat="server" Text="Email"></asp:Label>
        <br/>
        <asp:TextBox ID="txt_box_email" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_box_email" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">* Email Required</asp:RegularExpressionValidator>
        <br/>
        

        <%-- Password and confirm password --%>
        <asp:Label ID="label_password" runat="server" Text="Password"></asp:Label>
        <br/>
        <asp:TextBox ID="txt_box_password" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txt_box_password" Display="Dynamic" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" SetFocusOnError="True">* Password required</asp:CustomValidator>
        <br/>

        <asp:Label ID="label_confrimPassword" runat="server" Text="Confirm Password"></asp:Label>
        <br/>
        <asp:TextBox ID="txt_box_confirmPassword" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txt_box_confirmPassword" Display="Dynamic" ForeColor="Red" SetFocusOnError="True">* Password not matching</asp:CompareValidator>
        <br/>

        
        <%-- Mobile number --%>
        <asp:Label ID="label_mobileNumber" runat="server" Text="Mobile"></asp:Label>
        <br/>
        <asp:TextBox ID="txt_box_mobile" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_box_mobile" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\d(10)">* Mobile Required</asp:RegularExpressionValidator>
        <br/>
        
        <%-- Address --%>
        <asp:Label ID="label_address" runat="server" Text="Address"></asp:Label>
        <br/>
        <textarea id="txt_address" cols="20" rows="2"></textarea>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_box_firstName" ForeColor="Red" SetFocusOnError="True" Display="Dynamic">* Address Required</asp:RequiredFieldValidator>
        <br/>

        <%-- DOB --%>
        <asp:Label ID="label_dob" runat="server" Text="Age"></asp:Label>
        <br/>
        <asp:TextBox ID="txt_box_dob" runat="server" Height="20px" Width="185px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_box_dob" Display="Dynamic" ForeColor="Red">* Age required</asp:RequiredFieldValidator>
        <br/>

        <%-- Button(Submit) --%>
        <asp:Button ID="submit_button" runat="server" Text="Submit" />

    </form>
</body>
</html>
