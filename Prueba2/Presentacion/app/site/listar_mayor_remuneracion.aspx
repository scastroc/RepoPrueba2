<%@ Page Title="" Language="C#" MasterPageFile="~/app/site/template/template.Master" AutoEventWireup="true" CodeBehind="listar_mayor_remuneracion.aspx.cs" Inherits="Presentacion.app.site.listar_mayor_remuneracion" %>
<asp:Content ID="Content_head" ContentPlaceHolderID="head" runat="server">
    <title>Listar Mayor Remuneracion</title>
</asp:Content>
<asp:Content ID="Content_body" ContentPlaceHolderID="content" runat="server">
    <div class="row">
        <asp:GridView ID="tbl_empleados" runat="server"     
            AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Run" DataField="Run" ReadOnly="true" />
                <asp:BoundField HeaderText="Nombres" DataField="Nombres" ReadOnly="true" />
                <asp:BoundField HeaderText="Apellido Paterno" DataField="ApellidoPaterno" ReadOnly="true" />
                <asp:BoundField HeaderText="Apellido Materno" DataField="ApellidoMaterno" ReadOnly="true" />
                <asp:BoundField HeaderText="Tipo Empleado" DataField="TipoEmpleado.Nombre" ReadOnly="true" />                
                <asp:BoundField HeaderText="Telefono" DataField="Telefono" ReadOnly="true" />
                <asp:BoundField HeaderText="Remuneracion" DataField="Remuneracion" ReadOnly="true" />
                <asp:BoundField HeaderText="Fecha de Nacimiento" DataField="FechaNacimiento"
                    DataFormatString="{0:dd/MM/yyyy}" ReadOnly="true" />               
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
