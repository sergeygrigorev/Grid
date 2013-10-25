<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Hello.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nublo</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Table ID="t" runat="server" Height="114px" Width="1000px" 
        BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
    </asp:Table>
    <div class="ololo" align="center">
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Prev" />
        <asp:Button ID="Button2" runat="server" Text="Next" onclick="Button2_Click" />
    </div>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
