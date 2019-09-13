<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 199px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style1">
                    <asp:Label ID="Label1" runat="server" Text="ATM Card Number :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style1">
                    <asp:Label ID="Label2" runat="server" Text="ATM Pin Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style1">
                    <asp:Label ID="Label3" runat="server" Text="Withdrawal amount"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                &nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style1">
                    <asp:Label ID="lblstatus" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Login" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style1">
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                        Text="Show Balance" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                        Text="Withdraw Amout" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
