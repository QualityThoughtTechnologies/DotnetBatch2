<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseMangement.aspx.cs" Inherits="QualityThoughtWebSample.CourseMangement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Course Name
        <asp:TextBox ID="txtCourseName" runat="server"></asp:TextBox>
    
    </div>
        <div>
            Course Description
            <asp:TextBox ID="txtCourseDescription" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="QualityThoughtDatasource">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Course Name" HeaderText="Course Name" SortExpression="Course Name" />
                    <asp:BoundField DataField="Course Description" HeaderText="Course Description" SortExpression="Course Description" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="QualityThoughtDatasource" runat="server" ConnectionString="<%$ ConnectionStrings:QualityThoughtConnectionString %>" SelectCommand="SELECT * FROM [Courses]"></asp:SqlDataSource>
            <br />
            <asp:ListBox ID="ListBox1" runat="server" DataSourceID="QualityThoughtDatasource" DataTextField="Course Name" DataValueField="Course Name" Height="96px" Width="317px"></asp:ListBox>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="QualityThoughtDatasource" DataTextField="Course Name" DataValueField="Course Name" Height="16px" Width="179px">
            </asp:DropDownList>
            <br />
        </div>
    </form>
</body>
</html>
