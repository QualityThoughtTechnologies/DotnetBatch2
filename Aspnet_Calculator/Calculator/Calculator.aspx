<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Calculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtResult" runat="server" Width="804px">0</asp:TextBox>
        </div>
        <asp:Button ID="btn1" runat="server" Text="1" OnClick="btn1_Click" />
        <asp:Button ID="btn2" runat="server" Text="2" OnClick="btn1_Click" />
        <asp:Button ID="btn3" runat="server" Text="3" OnClick="btn1_Click" />
        <asp:Button ID="btn4" runat="server" Text="4" OnClick="btn1_Click" />
        <asp:Button ID="btn5" runat="server" Text="5" OnClick="btn1_Click" />
        <div>

            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnSub" runat="server" Text="Sub" OnClick="btnSub_Click" />

            <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate" />
            <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset" />

        </div>
        <div>
        </div>
    </form>
</body>
</html>
