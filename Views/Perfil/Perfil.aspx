<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<BuPhoto.Models.PerfilModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Perfil
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="jumbotron">
    <h2><%: Page.User.Identity.Name %></h2>
    <div class="btn-group">
        <button type="button" class="btn btn-default">Modificar información personal</button>
        <button type="button" class="btn btn-default">Subir fotografías</button>
        <button type="button" class="btn btn-default" onclick="bucle()">Crear publicación</button>
    </div>
    <p></p>

        <div id="prueba1" class="row">
        </div>

    </div>

    <script type="text/javascript">
        function bucle() {
            var obj = document.getElementById('prueba1');
            var div1 = document.createElement("div");
            div1.className = "col-xs-6 col-md-3";
            var a = document.createElement("a");
            a.href = "#";
            a.className = "thumbnail";
            var img = document.createElement("img");
            img.src = "../../Content/images/fondo.jpg";
            img.className = "img-responsive";
            img.alt = "Responsive image";
            var div2 = document.createElement("div");
            div2.className = "caption";
            var h4 = document.createElement("h4");
            h4.innerHTML = "Nombre del album";
            //obj.appendChild(div1.appendChild(a.appendChild(img, div2.appendChild(h4))));
            obj.appendChild(div1);
            div1.appendChild(a);
            a.appendChild(img);
            a.appendChild(div2);
            div2.appendChild(h4);
        }
    </script>

</asp:Content>
