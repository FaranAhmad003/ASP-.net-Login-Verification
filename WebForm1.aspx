<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Pokedex_ZFH.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        
    </title>
</head>
    
<body>
    <form id="form1" runat="server" visible="True">
        
        
        
        
       Username: <asp:Textbox ID ="txtusername" runat="server"></asp:Textbox>
         <br />
        <br />
         Password: <asp:Textbox Textmode="Password" ID="txtpassword" runat="server"></asp:Textbox>
        <br />
        <br />
        
        <p>
             <asp:Label runat="server" Text="Verification" ID="label"></asp:Label>
             <br /><br />
           
            <asp:Button ID="Button1" runat="server" Text="Login" Width="166px" Visible="True" BorderStyle="Inset" ViewStateMode="Enabled" OnClick="Button1_Click1"> </asp:Button>
            <asp:Button runat="server" Text="SignUp" OnClick="Unnamed1_Click" BorderStyle="Inset"></asp:Button>
            
        </p>
    </form>
</body>
</html>     
