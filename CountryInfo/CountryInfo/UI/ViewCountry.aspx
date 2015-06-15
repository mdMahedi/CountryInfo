<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCountry.aspx.cs" Inherits="CountryInfo.UI.ViewCountry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <legend>Search Criteria</legend>
        <table style="width: 326px">
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="searchTextBox" runat="server" Width="160px"></asp:TextBox></td>
                <td>
                    <asp:Button ID="searchButton" runat="server" Text="Search" Width="80px" OnClick="searchButton_Click" /></td>
            </tr>
        </table>
    </fieldset>
    </div>
        <asp:GridView ID="showGridView" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
