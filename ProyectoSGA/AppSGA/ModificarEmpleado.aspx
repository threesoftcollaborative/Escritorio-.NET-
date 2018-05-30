<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModificarEmpleado.aspx.cs" Inherits="WPF_RegistroFerme.ModificarEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>
                Ingrese el Id del Empleado</td>
            <td>
                <asp:TextBox ID="txtIdEmpleado" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" onclick="btnBuscar_Click" 
                    Text="Buscar" />
            </td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <table style="width:100%;">
        <tr>
            <td>
            ID Empleado</td>
            <td>
                <asp:Label ID="lblIdEmpleado" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            Rut Empleado</td>
            <td>
                <asp:TextBox ID="txtRutEmpl" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            Nombre Empleado</td>
            <td>
                <asp:TextBox ID="txtNomEmp" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            Direccion Empleado</td>
            <td>
                <asp:TextBox ID="txtDirecEmp" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            Fecha Nacimiento</td>
            <td>
                <asp:TextBox ID="txtFecNac" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            Telefono Empleado</td>
            <td>
                <asp:TextBox ID="txtTelEmpl" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            Correo Empleado</td>
            <td>
                <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            Perfil Id Perfil</td>
            <td>
                <asp:TextBox ID="txtIdPerfil" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            est_usu_id_estado_usu</td>
            <td>
                <asp:TextBox ID="txtEstaUsuario" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblResultados" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="btnEditar" runat="server" onclick="btnEditar_Click" 
                    Text="Editar" />
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
