<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityInfo.aspx.cs" Inherits="CountryInfo.UI.CityInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 180px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
                <legend>City Entry</legend>
                <table>
                    <tr>
                        <th>Name</th>
                        <td class="auto-style1">
                            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <th>About</th>
                        <td class="auto-style1">
                            <asp:TextBox ID="aboutTextBox" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <th>Dwellers</th>
                        <td class="auto-style1">
                            <asp:TextBox ID="dwellersTextBox" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <th>Location</th>
                        <td class="auto-style1">
                            <asp:TextBox ID="locationTextBox" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <th>Weather</th>
                        <td class="auto-style1">
                            <asp:TextBox ID="weatherTextBox" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <th>Country</th>
                        <td class="auto-style1">
                            <asp:DropDownList ID="countryDropDownList" runat="server" Height="16px" Width="128px" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="id"></asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CityInfoDBConnectionString %>" SelectCommand="SELECT [name], [id] FROM [tbl_Country]"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="saveButton" runat="server" Text="Save" Width="80px" OnClick="saveButton_Click" /></td>
                        <td class="auto-style1">
                            <asp:Button ID="cancelButton" runat="server" Text="Cancel" Width="80px" /></td>
                    </tr>
                </table>
            </fieldset>
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        </div>
        <asp:GridView ID="showGridView" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
