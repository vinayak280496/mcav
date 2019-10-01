<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 376px;
        }
        .style3
        {
            width: 376px;
            height: 193px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style1" style="text-align: center">
                    <asp:Label ID="Label1" runat="server" 
                        style="text-align: center; font-weight: 700; color: #CC0000" 
                        Text="Stark ATM System Welcomes You."></asp:Label>
                </td>
                <td rowspan="3" valign="top">
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3" 
                    style="padding: 10px; border: thin ridge #990000; text-align: center">
                    <asp:Label ID="Label2" runat="server" Text="ATM Card Number"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="ATM PIN"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblstatus" runat="server" style="color: #FF0000"></asp:Label>
                    <br />
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Login" 
                        Width="100px" />
&nbsp;
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Withdraw" 
                        Width="100px" />
                </td>
            </tr>
            <tr>
                <td class="style1" style="text-align: right">
                    <asp:Label ID="Label4" runat="server" ForeColor="#FFCC99" 
                        style="text-align: right"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
