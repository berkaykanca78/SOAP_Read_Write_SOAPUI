<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TempSite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Testing Our Web Service</title>
    <style type="text/css">
        .auto-style1 {
            width: 47%;
            height: 156px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This is to Test Our Web Service</div>
        <table align="center" class="auto-style1">
            <tr>
                <td>Enter Temperature</td>
                <td>
                    <asp:TextBox ID="TemperatureTextbox" runat="server" Width="266px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnConvert" runat="server" Text="Convert" Width="268px" OnClick="btnConvert_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Temperature in Celcius</td>
                <td>
                    <asp:Label ID="CelciusLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Temperature in Fahrenheit</td>
                <td>
                    <asp:Label ID="FahrenheitLabel" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
