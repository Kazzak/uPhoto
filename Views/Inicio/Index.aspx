<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<BuPhoto.Models.searchProfileModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    uPhoto: El sitio para fotógrafos
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
    <div id="carousel" class="carousel slide">
        <!--Elementos del Carousel -->
        <div class="carousel-inner">
            <div class="item active">
            <img src="http://www.tundria.com/trams/FRA/Photos/Lyon-Metro-D.jpg" alt="">
            <div class="carousel-caption">
                <!-- Titulo -->
                <h4>Imagen prueba 1</h4>
                <!-- Descripcion -->
            </div>
            </div>
            <div class="item">
            <img src="http://www.online-utility.org/image/ImageCache?file=3/3a/L%C3%ADnea_3_Metro_Madrid_(31).jpg/800px-L%C3%ADnea_3_Metro_Madrid_(31).jpg" alt="">
            <div class="carousel-caption">
                <!-- Titulo -->
                <h4>Imagen prueba 2</h4>
                <!-- Descripcion -->
            </div>
            </div>
            <div class="item">
            <img src="http://static.progressivemediagroup.com/uploads/imagelibrary/nri/railway/news/DelhiMetroBlueLine.JPG" alt="">
            <div class="carousel-caption">
                <!-- Titulo -->
                <h4>Imagen prueba 3</h4>
                <!-- Descripcion -->
            </div>
            </div> 
        </div>
        <!-- Carousel nav -->
        <a class="carousel-control left" href="#carousel" data-slide="prev">&lsaquo;</a>
        <a class="carousel-control right" href="#carousel" data-slide="next">&rsaquo;</a>
    </div>
    </div>

</asp:Content>
