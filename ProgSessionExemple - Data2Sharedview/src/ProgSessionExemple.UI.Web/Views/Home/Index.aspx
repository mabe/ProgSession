﻿<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Exemple5.Master" Inherits="System.Web.Mvc.ViewPage<ProgSessionExemple.UI.Web.Models.ArchiveViewModel>" %>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%= Html.Encode(ViewData["Message"]) %></h2>
    <p>
        To learn more about ASP.NET MVC visit <a href="http://asp.net/mvc" title="ASP.NET MVC Website">http://asp.net/mvc</a>.
    </p>
</asp:Content>
