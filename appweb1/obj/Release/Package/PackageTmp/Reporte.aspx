<%@ Page Title="Reporte" Language="C#" Debug=true MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reporte.aspx.cs" Inherits="appweb1.Reporte" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Reporte de tiempos muertos</h2>
    
<table class="egt" id="Table_calidad" runat="server">

        </table>
    
<table class="egt" id="Table_calidad0" runat="server">

    <tr>


        <td>
            <asp:Label ID="Label1" runat="server" Text="Fecha inicial:"></asp:Label>
            <asp:DropDownList ID="Fecha_1" runat="server" autopostback="true" Height="26px" OnSelectedIndexChanged="Fecha_1_SelectedIndexChanged" Width="123px"></asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Fecha final:"></asp:Label>
&nbsp;<asp:DropDownList ID="Fecha_2" runat="server" AutoPostBack="true" Height="26px" OnSelectedIndexChanged="Fecha_2_SelectedIndexChanged" Width="123px" CssClass="col-md-offset-0"></asp:DropDownList></td>

        <td>&nbsp;</td>
    </tr>
    
    <tr>

    <td style="width: 1094px">
   
                <asp:Chart Id="Grafica" runat ="Server" Palette="Berry" Width="659px" style="margin-left: 98px" BorderlineDashStyle="Dash" BorderlineWidth="0">

                    <Series>
                        <asp:Series Name="Serie">

                        </asp:Series>
                    </Series>

                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea">

                        </asp:ChartArea>

                    </ChartAreas>

                    <BorderSkin BorderWidth="0" />

                </asp:Chart>

    
              </td>

            
  </tr>
    <tr>
        <td>
        <asp:PlaceHolder ID = "PlaceHolder2" runat="server" /></td>
    </tr>
</table>
    <p>
        
        &nbsp;&nbsp;&nbsp;
        
    
    <p>&nbsp;</p>

</asp:Content>
