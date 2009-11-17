<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<System.Collections.Generic.IDictionary<string, short>>" %>
<ul>
<% foreach (var pair in Model)
   { %>
	<li><a href="#"><%= pair.Key%></a> (<%= pair.Value%>)</li>
<% } %>
</ul>