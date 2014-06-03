<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
    if (Request.IsAuthenticated) {
%>
        Welcome <strong><%: Page.User.Identity.Name %></strong>!
        <%: Html.ActionLink("Cerrar sesión", "LogOff", "Account") %>
        <%: Html.ActionLink("Mi cuenta", "Perfil", "Home") %>
<%
    }
    else {
%> 
        <%: Html.ActionLink("Iniciar sesión", "LogOn", "Account") %>
        <%: Html.ActionLink("Crear Cuenta", "Register", "Account") %>
<%
    }
%>
