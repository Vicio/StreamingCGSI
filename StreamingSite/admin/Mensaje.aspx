<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.Master" AutoEventWireup="true" CodeBehind="Mensaje.aspx.cs" Inherits="StreamingSite.admin.Mensaje" %>
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
            <h3 class="hidden-xs">Cambie el mensaje del canal.</h3>
            <h4 class="visible-xs">Cambie el mensaje del canal.</h4>
        </div>
        <div class="container-fluid col-xs-10 col-xs-offset-1 col-sm-6 col-sm-offset-3 col-md-8 col-md-offset-2 col-lg-6 col-lg-offset-3">
            <div class="input-group">
                <span class="input-group-addon">Mensaje:</span>
                <input runat="server" name="mensaje" id="textboxMensaje" type="text" class="form-control" placeholder="ej. XIV Encuentro de investigadores." />
            </div>
            <asp:Button runat="server" ID="buttonCambiarMensaje" OnClick="buttonCambiarMensaje_Click" CssClass="btn btn-primary center-block margin-top-sm" Text="Ingresar" />
        </div>
    </div>
</asp:Content>
