<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CaseConversion.aspx.cs" Inherits="Calculator.CaseConversion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Your Text
        <asp:TextBox ID="txtUserText" runat="server" OnTextChanged="txtUserText_TextChanged"></asp:TextBox>
    
    </div>
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
