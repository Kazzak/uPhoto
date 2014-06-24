<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Foro
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Foro</h1>
        <p>
            <button id="b_logON" class="btn btn-lg btn-primary" data-toggle="modal">View navbar docs</button>
        </p>
    </div>
</asp:Content>
