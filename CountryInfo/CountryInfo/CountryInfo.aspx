<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryInfo.aspx.cs" Inherits="CountryInfo.CountryInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
                <legend>Country Entry</legend>
                <table style="width: 307px">
                    <tr>
                        <td>Name</td>
                        <td>
                            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>About</td>
                        <td>
                            <asp:TextBox ID="aboutTextBox" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="saveButton" runat="server" Text="Save" Width="80px" OnClick="saveButton_Click" /></td>
                        <td>
                            <asp:Button ID="cancelButton" runat="server" Text="Cancel" Width="80px" /></td>
                    </tr>
                </table>
                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
            </fieldset>
            <asp:GridView ID="countryGridView" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
