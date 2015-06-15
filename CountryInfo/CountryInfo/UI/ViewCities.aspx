<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCities.aspx.cs" Inherits="CountryInfo.UI.ViewCities" %>

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
        <table style="width: 383px">
            <tr>
                <td>
                    <input type="radio" id="cityNameRadiobox" runat="server" name="cityInfo"/>City Name</td>
                <td>
                    <asp:TextBox ID="cityNameTextBox" runat="server" Width="150px"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <input type="radio" id="countryNameRadiobox" runat="server" name="cityInfo"/>Country</td>
                <td>
                    <asp:DropDownList ID="countryDropDownList" runat="server" Width="155px" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="id"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CityInfoDBConnectionString2 %>" SelectCommand="SELECT [name], [id] FROM [tbl_Country]"></asp:SqlDataSource>
                </td>
                <td>
                    <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" /></td>
            </tr>
        </table>
    </fieldset>
    </div>
        <asp:GridView ID="showGridView" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
