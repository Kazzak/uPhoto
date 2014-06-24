<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%
    if (Request.IsAuthenticated) {
%>
    <form class="nav navbar-nav navbar-right">
        <li>
            <a href="<%:Url.Action("Perfil", "Perfil") %>">Bienvenido <strong><%: Page.User.Identity.Name %></strong>!</a>
            <a id="b_logOff" class="btn btn-default navbar-btn" href="<%:Url.Action("LogOff", "Sesion") %>">Salir</a>
        </li>
    </form>
<%
    }
    else {
%>
    <form class="nav navbar-nav navbar-right">
        <a id="b_logON" class="btn btn-default navbar-btn" href="../Sesion/LogON">Iniciar sesión</a>
        <a id="b_createAccount" class="btn btn-default navbar-btn" href="../Sesion/Register">Crear cuenta</a>
    </form>
<%
    }
%>