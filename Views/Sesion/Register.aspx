<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<BuPhoto.Models.RegisterModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Register
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<div class="jumbotron">
    <% using (Html.BeginForm()) { %>
        <%: Html.ValidationSummary(true, "La creación de la cuenta falló. Favor corregir los errores e intentar de nuevo") %>
        <div class="well">
            <fieldset class="control-grouperror">
                <legend>Información de la cuenta</legend>
                
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.UserName) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.UserName,new { @class = "span3" }) %>
                    <%: Html.ValidationMessageFor(m => m.UserName) %>
                </div>

                <div class="editor-label">
                    <%: Html.LabelFor(m => m.Name) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.Name,new { @class = "span3" }) %>
                    <%: Html.ValidationMessageFor(m => m.Name) %>
                </div>
                
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.LastName) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.LastName,new { @class = "span3" }) %>
                    <%: Html.ValidationMessageFor(m => m.LastName) %>
                </div>

                <div class="editor-label">
                    <%: Html.LabelFor(m => m.Email) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.Email,new { @class = "span3" }) %>
                    <%: Html.ValidationMessageFor(m => m.Email) %>
                </div>

                <div class="editor-label">
                    <%: Html.LabelFor(m => m.PaisOrigen) %>
                </div>
                <div class="editor-field">
                    <%: Html.DropDownListFor(m => m.PaisOrigen, (SelectList)ViewBag.PaisOrigen, new { @class = "form-control" })%>
                    <%--<%: Html.ValidationMessageFor(m => m.PaisOrigen) %>--%>
                </div>

                <div class="editor-label">
                    <%: Html.LabelFor(m => m.Password) %>
                </div>
                <div class="editor-field">
                    <%: Html.PasswordFor(m => m.Password,new { @class = "span3" }) %>
                    <%: Html.ValidationMessageFor(m => m.Password) %>
                </div>
                
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.ConfirmPassword) %>
                </div>
                <div class="editor-field">
                    <%: Html.PasswordFor(m => m.ConfirmPassword,new { @class = "span3" }) %>
                    <%: Html.ValidationMessageFor(m => m.ConfirmPassword) %>
                </div>
                <p></p>

                <p class="bottom">
                    <input type="submit" value="Registrar" class="btn btn-primary btn-large"/>
                </p>
            </fieldset>
        </div>
    <% } %>
</div>

</asp:Content>
