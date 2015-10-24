<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="required_field_validateors.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="0" cellpadding="0" cellspacing="0">
        <tbody><tr>
            <td>
                <b>Enter Your Name </b>
                <asp:textbox runat="server" id="txtTestForRequiredField">
            </asp:textbox></td>
        </tr>
        <tr>
            <td>
                <asp:requiredfieldvalidator id="RequiredFieldValidator1" forecolor="Red" errormessage="Please enter your name" controltovalidate="txtTestForRequiredField" runat="server">
            </asp:requiredfieldvalidator></td>
        </tr>
        <tr>
            <td>
                <asp:button id="Button1" text="Save" runat="server">
            </asp:button></td>
        </tr>
    </tbody></table>

    </div>
    </form>
</body>
</html>
