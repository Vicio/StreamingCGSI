<%@ Page Title="" Language="C#" MasterPageFile="~/canales/MasterPage.Master" AutoEventWireup="true" CodeBehind="fba.aspx.cs" Inherits="StreamingSite.canales.fba" %>

<asp:Content ID="encabezado" ContentPlaceHolderID="encabezado" Runat="Server">
    <script type="text/javascript" src="http://content.jwplatform.com/libraries/jtnYe0hj.js"></script>
</asp:Content>
<asp:Content ID="titulo" ContentPlaceHolderID="titulo" runat="server">
    <h3 class="hidden-xs hidden-sm margin-top-null"><strong><%=Session["subtituloCuerpo"]%></strong></h3>
    <h4 class="visible-sm margin-top-null"><strong><%=Session["subtituloCuerpo"]%></strong></h4>
    <h5 class="visible-xs text-center margin-top-null"><strong><%=Session["subtituloCuerpo"]%></strong></h5>
    <h3 class="hidden-xs hidden-sm margin-top-null"><%=Session["temaStreaming"] %></h3>
    <h4 class="visible-sm margin-top-null"><%=Session["temaStreaming"] %></h4>
    <h5 class="visible-xs text-center margin-top-null"><%=Session["temaStreaming"] %></h5>
</asp:Content>
<asp:Content ID="contenido" ContentPlaceHolderID="contenido" Runat="Server">
	<div runat="server" id='playerDesktop'></div>
	<div runat="server" id='playerMobile'></div>
    <div class="row">
        <div class="col-xs-12 margin-top-xs">
<%--            <div class="fb-follow" data-href="https://www.facebook.com/informatizacion.uaq" data-layout="button" data-show-faces="false">
            </div>
            <div class="fb-share-button" data-href="https://www.facebook.com/informatizacion.uaq" data-layout="button" data-mobile-iframe="true"></div>
            <div class="fb-like" data-href="https://www.facebook.com/informatizacion.uaq" data-layout="button_count" data-action="like" data-show-faces="false" data-share="false"></div>--%>
        </div>
    </div>
    <div id="disqus_thread"></div>
    <script>
        /**
            *  RECOMMENDED CONFIGURATION VARIABLES: EDIT AND UNCOMMENT THE SECTION BELOW TO INSERT DYNAMIC VALUES FROM YOUR PLATFORM OR CMS.
            *  LEARN WHY DEFINING THESE VARIABLES IS IMPORTANT: https://disqus.com/admin/universalcode/#configuration-variables
            */
        /*
        var disqus_config = function () {
            this.page.url = PAGE_URL;  // Replace PAGE_URL with your page's canonical URL variable
            this.page.identifier = PAGE_IDENTIFIER; // Replace PAGE_IDENTIFIER with your page's unique identifier variable
        };
        */
        (function() {  // DON'T EDIT BELOW THIS LINE
            var d = document, s = d.createElement('script');
        
            s.src = '//uaqfba.disqus.com/embed.js';
        
            s.setAttribute('data-timestamp', +new Date());
            (d.head || d.body).appendChild(s);
        })();
    </script>
    <noscript>Please enable JavaScript to view the <a href="https://disqus.com/?ref_noscript" rel="nofollow">comments powered by Disqus.</a></noscript>
<%--    <div class="row margin-bottom-xs">
        <div class="col-xs-12">
            <textarea class="form-control" rows="5" id="comentarios"></textarea>
        </div>
    </div>
    <div class="row">
        <div class="col-xs-7 col-sm-9 col-md-10">
            <input type="text" class="form-control" />
        </div>
        <div class="col-xs-5 col-sm-3 col-md-2">
            <button type="button" class="btn btn-primary form-control" >Comentar</button>
        </div>
    </div>--%>
	<script type='text/javascript'>
	    jwplayer('contenido_playerDesktop').setup
        (
            {
                sources: 
	            [
	                    {
	                        file: 'rtmp://148.220.38.241:1935/live/fbauC7bSEhNjVbNUa0oe5e7',
	                        label: "720p HD"
	                    },
	                    {
	                        file: 'rtmp://148.220.38.241:1935/live/fbauC7bSEhNjVbNUa0oe5e7',
                            label: "480p SD",
                        }

	            ]
	        }
        );
	</script>
	<script type='text/javascript'>
	    jwplayer('contenido_playerMobile').setup
		(
			{
			    file: 'http://148.220.38.241/hls/fbauC7bSEhNjVbNUa0oe5e7.m3u8',
			}
		);
	</script>
</asp:Content>
