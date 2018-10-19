<%@ Page Title="" Language="C#" MasterPageFile="~/app/site/template/template.Master" AutoEventWireup="true" CodeBehind="listar_por_remuneracion.aspx.cs" Inherits="Presentacion.app.site.listar_por_remuneracion" %>
<asp:Content ID="Content_head" ContentPlaceHolderID="head" runat="server">
    <title>Buscar Por Remuneracion</title>
</asp:Content>
<asp:Content ID="Content_body" ContentPlaceHolderID="content" runat="server">
    <div class="row">
        <div class="col-50">
            <span>REMUNERACION</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_remuneracion_init"
                runat="server" 
                TextMode="Number"
                placeholder="000000"/>
        </div>
    </div>
    <div class="row">
        <div class="col-50">
            <span>REMUNERACION</span>
        </div>
        <div class="col-50">
            <asp:TextBox ID="txt_remuneracion_end"
                runat="server" 
                TextMode="Number"
                placeholder="000000"/>
        </div>
    </div>
    <div class="row">
        <div class="col-75">
            &nbsp;
        </div>
        <div class="col-25">
            <asp:Button ID="btn_buscar"
                runat="server" 
                OnClick="btn_buscar_Click"
                Text="Buscar" />
        </div>
    </div>
    <div class="row">
        <asp:GridView ID="tbl_empleados" runat="server"     
            AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Run" DataField="Run" ReadOnly="true" />
                <asp:BoundField HeaderText="Nombres" DataField="Nombres" ReadOnly="true" />
                <asp:BoundField HeaderText="Apellido Paterno" DataField="ApellidoPaterno" ReadOnly="true" />
                <asp:BoundField HeaderText="Apellido Materno" DataField="ApellidoMaterno" ReadOnly="true" />
                <asp:BoundField HeaderText="Tipo Empleado" DataField="TipoEmpleado.Codigo" ReadOnly="true" />                
                <asp:BoundField HeaderText="Telefono" DataField="Telefono" ReadOnly="true" />
                <asp:BoundField HeaderText="Remuneracion" DataField="Remuneracion" ReadOnly="true" />
                <asp:BoundField HeaderText="Fecha de Nacimiento" DataField="FechaNacimiento"
                    DataFormatString="{0:dd/MM/yyyy}" ReadOnly="true" />               
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
