<%@ Page Title="" Language="C#" MasterPageFile="~/app/site/template/template.Master" AutoEventWireup="true" CodeBehind="listar_todos.aspx.cs" Inherits="Presentacion.app.site.listar_todos" %>
<asp:Content ID="Content_head" ContentPlaceHolderID="head" runat="server">
    <title>Listar Empleados</title>
</asp:Content>
<asp:Content ID="Content_body" ContentPlaceHolderID="content" runat="server">
    <div class="row">
        <div class="col-75">
            <span>&nbsp;</span>
        </div>
        <div class="col-25 green-button">
            <asp:Button ID="btn_listar_todos" runat="server"
                Text="Listar"  OnClick="btn_listar_todos_Click"/>
        </div>
    </div>
    <div class="row">
        <asp:GridView ID="tbl_empleados" runat="server"            
            OnRowEditing ="tbl_empleados_RowEditing"
            OnRowDeleting="tbl_empleados_RowDeleting"
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

               <asp:TemplateField HeaderText="" ItemStyle-CssClass="skyblue-button">
                    <ItemTemplate>
                        <asp:Button ID="btn_edit" runat="server"
                            Text="EDITAR" CommandName="Edit" />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="" ItemStyle-CssClass="red-button">
                    <ItemTemplate>
                        <asp:Button ID="btn_delete" runat="server"
                            Text="ELIMINAR" CommandName="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    
</asp:Content>
