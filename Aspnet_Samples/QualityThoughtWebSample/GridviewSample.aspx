<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridviewSample.aspx.cs" Inherits="QualityThoughtWebSample.GridviewSample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" OnRowDeleted="GridView1_RowDeleted">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="Course_Name" HeaderText="Course_Name" SortExpression="Course_Name" />
                <asp:BoundField DataField="Course_Description" HeaderText="Course_Description" SortExpression="Course_Description" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:QualityThoughtConnectionString %>" 
            DeleteCommand="DELETE FROM [Courses] WHERE [Id] = @Id" 
            InsertCommand="INSERT INTO [Courses] ([Course Name], [Course Description]) VALUES (@Course_Name, @Course_Description)" 
            SelectCommand="SELECT [Course Name] AS Course_Name, [Course Description] AS Course_Description, [Id] FROM [Courses]" 
            UpdateCommand="UPDATE [Courses] SET [Course Name] = @Course_Name, [Course Description] = @Course_Description WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Course_Name" Type="String" />
                <asp:Parameter Name="Course_Description" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Course_Name" Type="String" />
                <asp:Parameter Name="Course_Description" Type="String" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
