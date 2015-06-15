<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityInfo.aspx.cs" Inherits="CountryInfo.UI.CityInfo" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>CountryInfo</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <link href="//maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css" rel="stylesheet">
    <nav class="navbar navbar-default navbar-inverse" role="navigation">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand " href="index.aspx">CountryInfo</a>
            </div>
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav">
                    <li class="active"><a href="index.aspx">Home</a></li>
                    <li><a href="AddCountry.aspx">Add Country</a></li>
                    <li><a href="CityInfo.aspx">Add City</a></li>
                    <li><a href="ViewCities.aspx">View City</a></li>
                    <li><a href="ViewCountry.aspx">View Country</a></li>
                </ul>
                <ul class="nav navbar-nav navbar-right"></ul>
            </div>
        </div>
    </nav>
    <form id="form2" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 col-md-4">
                    <div class="row">
                        <fieldset>
                            <legend>City Entry</legend>
                            <div class="form-group">
                                <label for="name" class="col-md-12 control-label success">Name</label>
                                <div class="col-md-12">
                                    <asp:TextBox ID="nameTextBox" class="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="name" class="col-md-12 control-label success">About</label>
                                <div class="col-md-12">
                                    <asp:TextBox ID="aboutTextBox" class="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="name" class="col-md-12 control-label success">Dwellers</label>
                                <div class="col-md-12">
                                    <asp:TextBox ID="dwellersTextBox" class="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="name" class="col-md-12 control-label success">Location</label>
                                <div class="col-md-12">
                                    <asp:TextBox ID="locationTextBox" class="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="name" class="col-md-12 control-label success">Weather</label>
                                <div class="col-md-12">
                                    <asp:TextBox ID="weatherTextBox" class="form-control" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="name" class="col-md-12 control-label success">Country</label>
                                <div class="col-md-12">
                                    <asp:DropDownList ID="countryDropDownList" class="form-control" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="id"></asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource1"  runat="server" ConnectionString="<%$ ConnectionStrings:CityInfoDBConnectionString2 %>" SelectCommand="SELECT [name], [id] FROM [tbl_Country]"></asp:SqlDataSource>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-6">
                                    <asp:Button ID="saveButton" class="form-control btn-warning" runat="server" Text="Save" OnClick="saveButton_Click"/>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-6">
                                    <asp:Button ID="cancelButton" class="form-control btn-warning" runat="server" Text="Cancel" OnClick="cancelButton_Click"/>
                                </div>
                            </div>
                        </fieldset>
                        <%--<fieldset>
                            <legend> </legend>
                            
                        </fieldset>--%>
                        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                
                <div class="col-xs-12 col-md-8">
                    <fieldset>
                        <legend>City Details</legend>
                        <asp:GridView ID="showGridView" class="table table-bordered media-heading" runat="server"></asp:GridView>
                    </fieldset>
                </div>
            </div>
        </div>
    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
