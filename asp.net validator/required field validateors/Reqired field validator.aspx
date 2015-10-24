<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reqired field validator.aspx.cs" Inherits="required_field_validateors.Reqired_field_validator" %>

<%@ Register Src="~/Courses.ascx" TagPrefix="uc1" TagName="Courses" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-2.1.4.js"></script>
</head>
<body>
    <form id="form1" runat="server">

        <table>
            <tr>
                <td>pwd<asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td>cpwd<asp:TextBox ID="txtcpwd" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtcpwd" ControlToValidate="txtpwd" ErrorMessage="pwd and cpwd doesn't match"></asp:CompareValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="submit" /></td>
                <uc1:Courses runat="server" id="Courses"/>
            </tr>
        </table>
    </form>
</body>
</html>
