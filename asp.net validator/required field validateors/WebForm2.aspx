<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="required_field_validateors.WebForm2" %>

<%@ Register Src="~/Courses.ascx" TagPrefix="uc1" TagName="Courses" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:Courses runat="server" ID="Courses" Header="Testing"/>
    </div>
    </form>
</body>
</html>
