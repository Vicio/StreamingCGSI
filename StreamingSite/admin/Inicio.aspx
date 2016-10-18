<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="StreamingSite.admin.Inicio" %>
<asp:Content ID="encabezado" ContentPlaceHolderID="encabezado" runat="server">
</asp:Content>
<asp:Content ID="titulo" ContentPlaceHolderID="titulo" runat="server">
    <h3 class="hidden-xs hidden-sm margin-top-null"><strong><%=Session["subtituloCuerpo"]%></strong></h3>
    <h4 class="visible-sm margin-top-null"><strong><%=Session["subtituloCuerpo"]%></strong></h4>
    <h5 class="visible-xs text-center margin-top-null"><strong><%=Session["subtituloCuerpo"]%></strong></h5>
    <h3 class="hidden-xs hidden-sm margin-top-null"><%=Session["temaStreaming"] %></h3>
    <h4 class="visible-sm margin-top-null"><%=Session["temaStreaming"] %></h4>
    <h5 class="visible-xs text-center margin-top-null"><%=Session["temaStreaming"] %></h5>
</asp:Content>
<asp:Content ID="contenido" ContentPlaceHolderID="contenido" runat="server">
    <div class="row">
        <div class="container-fluid text-center">
            <h3 class="hidden-xs">Ingrese su contraseña y datos aquí.</h3>
            <h4 class="visible-xs">Ingrese su contraseña y datos aquí.</h4>
        </div>
        <div class="container-fluid col-xs-10 col-xs-offset-1 col-sm-6 col-sm-offset-3 col-md-8 col-md-offset-2 col-lg-6 col-lg-offset-3">
            <div class="input-group">
                <span class="input-group-addon">Correo:</span>
                <input runat="server" name="correo" id="textboxCorreo" type="text" class="form-control" placeholder="ej. lol123@yopmail.com" />
            </div>
            <div class="row-xs"></div>
            <div class="input-group">
                <span class="input-group-addon">Password:</span>
                <input runat="server" name="password" id="textboxPassword" type="password" class="form-control" placeholder="ej. p@$$w0rd" />
            </div>
            <asp:Button runat="server" ID="buttonIngresar" OnClick="buttonIngresar_Click" CssClass="btn btn-primary center-block margin-top-sm" Text="Ingresar" />
        </div>
    </div>
</asp:Content>
