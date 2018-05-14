<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Almacenes.Presentacion.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Login ID="lgLogMein" runat="server" DisplayRememberMe="false" LoginButtonText="[ Ingresar ]" TitleText="Ingreso a SGA" OnAuthenticate="lgLogMein_Authenticate"></asp:Login>
        </div>
    </form>
</body>
</html>
