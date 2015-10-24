<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Courses.ascx.cs" Inherits="required_field_validateors.Courses" %>
<div>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</div>
<div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Course Name" HeaderText="Course Name" SortExpression="Course Name" />
            <asp:BoundField DataField="Course Description" HeaderText="Course Description" SortExpression="Course Description" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QualityThoughtConnectionString %>" SelectCommand="SELECT * FROM [Courses]"></asp:SqlDataSource>
</div>
<div>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
</div>