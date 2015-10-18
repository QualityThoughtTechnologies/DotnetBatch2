<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Candidate.aspx.cs" Inherits="QualityThoughtWebSample.Candidate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Firstname<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <p>
            Lastname<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            Parentsname<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            Contact number<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            Qualification<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            Emailid<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </p>
        <p>
            Parentcontact number<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="submit" />
    </form>
</body>
</html>
