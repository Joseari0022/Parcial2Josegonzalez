<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="PresupuestoWebForm.aspx.cs" Inherits="Parcial_2_JoseGonzalez.UI.Registros.PresupuestoWebForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <div class="container">
            <h2 class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registro Presupuesto</h2>

            <%-- nombre usuario --%>
            <div class="text-center">
                <div>
                    <label for="id Usuario">Id Presupuesto</label>
                </div>
            </div>
            <div class="text-center">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox ID="idPresupuestosTextbox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="BuscarButton" runat="server" Text="Buscar" class="btn btn-Button1" OnClick="BuscarButton_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="idPresupuestosTextbox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
            </div>
            <%-- nombre --%>
            <div class="text-center">
                <div>
                    <label for="Nombres Usuario">&nbsp;Fecha</label>
                </div>
            </div>
            <div class="text-center">
                <asp:TextBox ID="FechaTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="FechaTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
            </div>
            <%-- contraseña --%>
            <div class="text-center">
                <div>
                    <label for="Nombres">Descripcion</label>
                </div>
            </div>
            <div class="text-center">
                <asp:TextBox ID="DescripcionTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="DescripcionTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
            </div>
            <%-- Fecha --%>
            <div class="text-center">
                <div>
                    <label for="Contraseña">&nbsp;Monto</label>
                <div class="text-center">
                <asp:TextBox ID="MontoTextBox" runat="server" Width="190px" Height="33px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="**" ValidationGroup="buscar" ControlToValidate="MontoTextBox" Font-Bold="True" ForeColor="Black"></asp:RequiredFieldValidator>
            </div>
            </div>
                </div>

       </div>

                <!--botones del formulario-->

            

                
                <div>
                    <div class="text-center">
                
                <asp:Button ID="NuevoButton" runat="server" Text="Nuevo" class="btn btn-Button1" OnClick="NuevoButton_Click" />
                <asp:Button ID="GuardarButton" runat="server" Text="Guardar" class="btn btn-Button1" OnClick="GuardarButton_Click" />
                <asp:Button ID="EliminarButton" runat="server" Text="Eliminar" class="btn btn-Button1" OnClick="EliminarButton_Click" />


                </div>



</asp:Content>


