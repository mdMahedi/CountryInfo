<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CountryInfo.UI.index" %>


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
                <a class="navbar-brand" href="index.aspx">CountryInfo</a>
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
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
