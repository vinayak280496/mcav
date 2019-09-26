<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" cellpadding="10" cellspacing="5" frame="box" 
            style="width: 33%;">
            <tr>
                <td colspan="3" style="text-align: center">
                    <asp:TextBox ID="TextBox1" runat="server" BorderStyle="None" 
                        ontextchanged="TextBox1_TextChanged" Width="312px" 
                        style="text-align: center" Font-Bold="True" Font-Names="Tahoma" 
                        Font-Size="Large" ForeColor="#FF6600"></asp:TextBox>
                        <hr />
                </td>
            </tr>
            <tr>
                <td rowspan="2">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem>English</asp:ListItem>
                        <asp:ListItem>Marathi</asp:ListItem>
                        <asp:ListItem>Kannada</asp:ListItem>
                        <asp:ListItem>Science</asp:ListItem>
                        <asp:ListItem>Maths</asp:ListItem>
                        <asp:ListItem>History</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" 
                        BorderStyle="Solid" Font-Bold="False" Font-Names="Arial Black" Height="30px" 
                        Width="100px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
