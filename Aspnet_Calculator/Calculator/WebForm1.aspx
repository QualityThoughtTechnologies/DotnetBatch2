<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="std_id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="std_id" HeaderText="std_id" ReadOnly="True" SortExpression="std_id" />
                <asp:BoundField DataField="std_name" HeaderText="std_name" SortExpression="std_name" />
                <asp:BoundField DataField="adress" HeaderText="adress" SortExpression="adress" />
                <asp:BoundField DataField="ph_no" HeaderText="ph_no" SortExpression="ph_no" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DotnetBatch2ConnectionString %>" SelectCommand="SELECT * FROM [student_master]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
