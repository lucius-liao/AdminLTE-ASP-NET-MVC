﻿<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    <!-- Google Font -->
    @If IsSectionDefined("Styles") Then
        @RenderSection("Styles", required:= false)
    End If
</head>

<body class="hold-transition skin-blue sidebar-mini">
    <div class="wrapper">
        @Html.Partial("_Header")
        @Html.Partial("_Sidebar")
        @RenderBody()
        @Html.Partial("_Footer")
        @Html.Partial("_Aside")
        <!-- Add the sidebar's background. This div must be placed
        immediately after the control sidebar -->
        <div class="control-sidebar-bg"></div>
    </div>


    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/lib")
    @RenderSection("scripts", required:= false)
</body>
</html>
