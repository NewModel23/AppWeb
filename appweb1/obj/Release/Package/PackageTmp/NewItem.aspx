<%@ Page Title="Nueva falla" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewItem.aspx.cs" Inherits="appweb1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>&nbsp;</h3>
    <h3>Agregar nuevas fallas</h3>
    <p>
        
    </p>

        <table class="nav-justified">
            <tr>
                <td style="width: 472px">Seleccione el ambiente:</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 472px"><asp:DropDownList ID="Ambiente" runat="server" Height="31px" Width="222px">
        </asp:DropDownList></td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 472px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
        <table class="nav-justified">
            <tr>
                <td style="width: 362px">Tipo de Falla:</td>
                <td style="width: 362px">¿Qué falló?:</td>
                <td style="width: 362px">¿Qué lo causó?</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 362px">
                    <asp:TextBox ID="Falla" runat="server" Width="332px"></asp:TextBox>
                </td>
                <td style="width: 362px">
                    <asp:TextBox ID="Modo" runat="server" Width="332px"></asp:TextBox>
                </td>
                <td style="width: 362px">
                    <asp:TextBox ID="Causa" runat="server" Width="332px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 362px">&nbsp;</td>
                <td style="width: 362px">&nbsp;</td>
                <td style="width: 362px">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    <p>&nbsp;</p>

        <table class="nav-justified">
            <tr>
                <td style="width: 175px">
                    <asp:Button ID="Button1" runat="server" BackColor="Lime" Text="Guardar nueva falla" Width="185px" OnClick="Button1_Click" />
                </td>
                <td style="width: 362px">
                    <asp:Button ID="Button2" runat="server" BackColor="#FF3300" Text="Cancelar" OnClick="Button2_Click" />
                </td>
                <td style="width: 362px">&nbsp;</td>
            </tr>
        </table>
    
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    
  
    



</asp:Content>
