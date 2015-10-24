<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validator2.aspx.cs" Inherits="required_field_validateors.validator2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>
    <script src="Scripts/jquery-2.1.4.js"></script>
</head>
<body>
   <form id="form1" runat="server">
    Your name:<br />
    <asp:TextBox runat="server" id="txtName" />
    <asp:RequiredFieldValidator runat="server" id="reqName" controltovalidate="txtName" errormessage="Please enter your name!" Display="Dynamic" />
    <br /><br />
       <asp:RangeValidator ID="RangeValidator1" ControlToValidate="txtName" MaximumValue="8" runat="server" ErrorMessage="name should be 8 characters"></asp:RangeValidator>
    <asp:Button runat="server" id="btnSubmitForm" text="submit" />
       <p>
           <asp:Label ID="Label1" runat="server"></asp:Label>
       </p>
</form>
</body>
</html>
