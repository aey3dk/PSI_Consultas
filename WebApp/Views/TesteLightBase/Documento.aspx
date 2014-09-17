<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html>

<html>
<head>
    <title></title>
    <script src="~/Resources/js/jquery-1.11.1.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#frmDocumento").submit();
        });
    </script>
</head>
<body>
    <form id="frmDocumento" action="http://psiconsultas/lbweb/apps/LOCALHOST/DEFUDB/PSIDOCS/navegacao.lbsp">
        <input type="hidden" name="LBWCGI_OPENSESSION" value="Ok" />
        <input type="hidden" name="LBWCGI_SERVERNAME"  value="LOCALHOST" />
        <input type="hidden" name="LBWCGI_UDBNAME"     value="DEFUDB" />
        <input type="hidden" name="LBWCGI_BASENAME"    value="PSIDOCS" />
        <input type="hidden" name="LBWCGI_USERNAME"    value="lbw" />
        <input type="hidden" name="LBWCGI_PASSWORD"    value="lbw" />
        <input type="hidden" name="LBWCGI_ALLRECORDS"  value="Ok" />
    </form>
</body>
</html>