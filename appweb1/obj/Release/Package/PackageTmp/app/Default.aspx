<%@ Page Title="" Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile="~/app/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="appweb1.app.Default"%>
<asp:Content ID="BodyContent" ContentPlaceHolderID="Head" runat="server">

    
    <asp:PlaceHolder ID = "PlaceHolder1" runat="server" />

    <script type="text/javascript">
        $(function () {
            var Min_Mantto_1 = $('input:text[id$=Min_Mantto_1]').keyup(foo);
            var Min_Mantto_2 = $('input:text[id$=Min_Mantto_1]').keyup(foo);

            function foo() {
                var value1 = Min_Mantto_1.val();
                var value2 = Min_Mantto_2.val();
                var sum = add(value1, value2);
                $('input:text[id$=Hora_select]').val(sum);
            }

            function add() {
                var sum = 0;
                for (var i = 0, j = arguments.length; i < j; i++) {
                    if (IsNumeric(arguments[i])) {
                        sum += parseFloat(arguments[i]);
                    }
                } return sum;
            } function IsNumeric(input) { return (input - 0) == input && input.length > 0; }
        });
    </script>


    <style type="text/css">
        .auto-style1 {
            max-width: 500px;
            margin: auto;
            width: 590px;
        }
        #DropDownList1 {
            height: 16px;
        }
        .subtoc {
        height: 1563px;
        margin-bottom: 0px;
            width: 1267px;
            margin-left: 0px;
        }
        .auto-style2 {
            width: 348px;
            margin-left: 40px;
        }
        .auto-style3 {
            height: 36px;
        }
        .auto-style4 {
            width: 348px;
            height: 36px;
        }
        .auto-style5 {
            max-width: 500px;
            margin: auto;
            width: 590px;
            height: 36px;
        }
        .auto-style7 {
            width: 924px;
        }
        .auto-style10 {
            height: 126px;
        }
        .auto-style11 {
            width: 348px;
            height: 126px;
        }
        .auto-style12 {
        max-width: 500px;
        margin: auto;
        width: 853px;
        height: 36px;
    }
    .auto-style13 {
        max-width: 500px;
        margin: auto;
        width: 853px;
    }
    .auto-style14 {
        height: 42px;
    }
    .auto-style15 {
        width: 348px;
        height: 42px;
    }
    .auto-style16 {
        max-width: 500px;
        margin: auto;
        width: 924px;
        height: 36px;
    }
        .auto-style17 {
            width: 349px;
            height: 42px;
        }
        .auto-style18 {
            width: 349px;
            margin-left: 40px;
        }
        .auto-style19 {
            width: 2395px;
        }
        .auto-style20 {
            max-width: 500px;
            margin: auto;
            width: 103px;
        }
        </style>


    </asp:Content>

 

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="subtoc">
    <br />
    <table class="egt"><asp:Image ID="Image1" runat="server" align="center" Height="83px" ImageUrl="~/app/Images/logo_autotek.png" Width="238px" /></table>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label" Font-Size="Smaller"></asp:Label>
        <br />
        <br />
 
 <table border='0' class="egt" id="tabla_hora">
    <tr>
    <th class="auto-style16"> <asp:Label ID="Label2" runat="server" Text="Parte seleccionada:  " Font-Size="Large"></asp:Label>  <asp:Label ID="Item_nbr" runat="server" Text="Número de parte:" Font-Bold="True" Font-Size="Large"></asp:Label>  </th>
    <td class="auto-style12"><asp:Label ID="Modo_fallo_lbl4" runat="server" Text="Seleccione la hora a capturar:" Font-Size="X-Large"></asp:Label></td>
    
    <td class="auto-style5"><asp:Label ID="Modo_fallo_lbl0" runat="server" Text="Minutos de esta falla" Font-Size="X-Large"></asp:Label></td>
    
  </tr>
  <tr>
      <th class="auto-style7">  <asp:Label ID="item_desc" runat="server" Font-Size="Large" ForeColor="#FF3300"></asp:Label></th>

    <td class="auto-style13">
        <asp:DropDownList ID="Hora_Sel_usr" runat="server" AutoPostBack="true" Height="31px" Width="104px" OnSelectedIndexChanged="Hora_Sel_usr_SelectedIndexChanged">
        </asp:DropDownList>
      </td>

    <td class="auto-style1">
        <asp:Label ID="hora_select" runat="server" BackColor="White" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" Text="0"></asp:Label>
      </td>

  </tr>
  </table>
 
 <table border='0' class="egt" id="tabla_hora1">
  <tr>
      <th class="auto-style19">  
          <asp:Label ID="error_id" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
      </th>

    <td class="auto-style20">
        <asp:Label ID="Label3" runat="server" Text="Minutos de producción:"></asp:Label>
      </td>

    <td class="auto-style1">
        <asp:Label ID="Minutos_prod" runat="server" BackColor="White" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" Text="0"></asp:Label>
      </td>

  </tr>
  </table>

        <br />
&nbsp;<asp:Label ID="ambiente_lbl0" runat="server" Text="Mantenimiento" Font-Size="X-Large"></asp:Label>
    
<br />
    <table class="egt" id="Table_mantto" runat="server">

        <tr>

    <td class="auto-style15">&nbsp;</td>

    <td aria-multiline="True" class="auto-style14">
        <asp:Label ID="Fallo_lbl" runat="server" Text="Seleccione Fallo:" Font-Size="X-Large"></asp:Label></td>

    <td class="auto-style14"><asp:Label ID="Modo_fallo_lbl" runat="server" Text="Seleccione el modo de fallo:" Font-Size="X-Large"></asp:Label></td>

    <td class="auto-style15"><asp:Label ID="Causa_lbl2" runat="server" Text="Seleccione la causa:" Font-Size="X-Large"></asp:Label></td>

    <td class="auto-style17"><asp:Label ID="Causa_lbl" runat="server" Text="Minutos:" Font-Size="X-Large"></asp:Label></td>

    <td class="auto-style15">&nbsp;</td>

  </tr>

  <tr>

    <td class="auto-style2">
        &nbsp;</td>

    <td><asp:DropDownList ID="Dropdown_Mantto_Fallo_1" runat="server" AutoPostBack="true" Height="31px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="220px" Font-Size="Large">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Mantto_Fallo_2" runat="server"  AutoPostBack="true" Height="31px" OnSelectedIndexChanged="Mantenimiento_2_opt_Modo" Width="220px" Font-Size="Large">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Mantto_Fallo_3" runat="server" AutoPostBack="true" Height="31px" OnSelectedIndexChanged="Mantenimiento_3_opt_Modo" Width="220px" Font-Size="Large">
    </asp:DropDownList></td>

    <td><asp:DropDownList ID="Dropdown_Mantto_Modo_1" runat="server"  AutoPostBack="true" Height="31px" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" Width="335px" Font-Size="Large">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Mantto_Modo_2" runat="server"  AutoPostBack="true" Height="31px" OnSelectedIndexChanged="Mantenimiento_2_opt_Causa" Width="335px" Font-Size="Large">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Mantto_Modo_3" runat="server"  AutoPostBack="true" Height="31px" OnSelectedIndexChanged="Mantenimiento_3_opt_Causa" Width="335px" Font-Size="Large">
    </asp:DropDownList></td>

    <td class="auto-style2"><asp:DropDownList ID="Dropdown_Mantto_Causa_1" runat="server" AutoPostBack="true" Height="31px" Width="367px" Font-Size="Large" OnSelectedIndexChanged="Dropdown_Mantto_Causa_1_SelectedIndexChanged">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Mantto_Causa_2" runat="server" AutoPostBack="true" Height="31px" Width="367px" Font-Size="Large" OnSelectedIndexChanged="Dropdown_Mantto_Causa_2_SelectedIndexChanged">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Mantto_Causa_3" runat="server" AutoPostBack="true" Height="31px" Width="367px" Font-Size="Large" OnSelectedIndexChanged="Dropdown_Mantto_Causa_3_SelectedIndexChanged">
    </asp:DropDownList></td>

    <td class="auto-style18">
        <asp:DropDownList ID="Min_Mantto_1" runat="server" AutoPostBack ="True" Height="31px" Width="200px" BackColor="White" OnTextChanged="Min_Mantto_1_TextChanged" AutoCompleteType="Disabled" Font-Bold="True" Font-Size="Large" ForeColor="Blue"></asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Min_Mantto_2" runat="server" Height="31px" Width="200px" AutoCompleteType="Disabled" AutoPostBack="True" Font-Bold="True" Font-Size="Large" ForeColor="Blue" OnTextChanged="Min_Mantto_1_TextChanged"></asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Min_Mantto_3" runat="server" Height="31px" Width="200px" AutoCompleteType="Disabled" AutoPostBack="True" Font-Bold="True" Font-Size="Large" ForeColor="Blue" OnTextChanged="Min_Mantto_1_TextChanged"></asp:DropDownList>
        <br />
      </td>

    <td class="auto-style2">
        <br />
      </td>

  </tr>

  
    </table>
    <br />
        <br />
        <br />
&nbsp;<asp:Label ID="ambiente_lbl1" runat="server" Text="Calidad" Font-Size="X-Large"></asp:Label>
    
<br />
    <table class="egt" id="Table_calidad" runat="server">

        <tr>

    <td class="auto-style4">&nbsp;</td>

    <td aria-multiline="True" class="auto-style3">
        <asp:Label ID="Fallo_lbl0" runat="server" Text="Seleccione Fallo:" Font-Size="X-Large"></asp:Label></td>

    <td class="auto-style3"><asp:Label ID="Modo_fallo_lbl2" runat="server" Text="Seleccione el modo de fallo:" Font-Size="X-Large"></asp:Label></td>

    <td class="auto-style4"><asp:Label ID="Causa_lbl0" runat="server" Text="Seleccione la causa:" Font-Size="X-Large"></asp:Label></td>

    <td class="auto-style4"><asp:Label ID="Causa_lbl3" runat="server" Text="Minutos:" Font-Size="X-Large"></asp:Label></td>

    <td class="auto-style4">&nbsp;</td>

  </tr>

  <tr>

    <td class="auto-style2">
        <br />
      </td>

    <td><asp:DropDownList ID="Dropdown_Calidad_Fallo_1" runat="server" AutoPostBack="true"  Height="31px" OnSelectedIndexChanged="Calidad_1_opt_Modo" Width="220px" Font-Size="Large">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Calidad_Fallo_2" runat="server" AutoPostBack="true"  Height="31px" OnSelectedIndexChanged="Calidad_2_opt_Modo" Width="220px" Font-Size="Large">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Calidad_Fallo_3" runat="server" AutoPostBack="true"  Height="31px" OnSelectedIndexChanged="Calidad_3_opt_Modo" Width="220px" Font-Size="Large">
    </asp:DropDownList></td>

    <td><asp:DropDownList ID="Dropdown_Calidad_Modo_1" runat="server"  AutoPostBack="true" Height="31px" OnSelectedIndexChanged="Calidad_1_opt_Causa" Width="335px" Font-Size="Large">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Calidad_Modo_2" runat="server" AutoPostBack="true"  Height="31px" OnSelectedIndexChanged="Calidad_2_opt_Causa" Width="335px" Font-Size="Large">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Calidad_Modo_3" runat="server" AutoPostBack="true"  Height="31px" OnSelectedIndexChanged="Calidad_3_opt_Causa" Width="335px" Font-Size="Large">
    </asp:DropDownList></td>

    <td class="auto-style2"><asp:DropDownList ID="Dropdown_Calidad_Causa_1" runat="server" AutoPostBack="true" Height="31px" Width="367px" Font-Size="Large" OnSelectedIndexChanged="Dropdown_Calidad_Causa_1_SelectedIndexChanged">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Calidad_Causa_2" runat="server" AutoPostBack="true" Height="31px" Width="367px" Font-Size="Large" OnSelectedIndexChanged="Dropdown_Calidad_Causa_2_SelectedIndexChanged">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Calidad_Causa_3" runat="server" AutoPostBack="true" Height="31px"  Width="367px" Font-Size="Large" OnSelectedIndexChanged="Dropdown_Calidad_Causa_3_SelectedIndexChanged">
    </asp:DropDownList></td>

    <td class="auto-style2">
        <asp:DropDownList ID="Min_Calidad_1" runat="server" Height="31px" Width="200px" AutoCompleteType="Disabled" AutoPostBack="True" Font-Bold="True" Font-Size="Large" ForeColor="Blue" OnTextChanged="Min_Mantto_1_TextChanged"></asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Min_Calidad_2" runat="server" Height="31px" Width="200px" AutoCompleteType="Disabled" AutoPostBack="True" Font-Bold="True" Font-Size="Large" ForeColor="Blue" OnTextChanged="Min_Mantto_1_TextChanged"></asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Min_Calidad_3" runat="server" Height="31px" Width="200px" AutoCompleteType="Disabled" AutoPostBack="True" Font-Bold="True" Font-Size="Large" ForeColor="Blue" OnTextChanged="Min_Mantto_1_TextChanged"></asp:DropDownList>
      </td>

    <td class="auto-style2">
        <br />
      </td>

  </tr>

  
    </table>
        
&nbsp;<br />
        <br />
        <asp:Label ID="ambiente_lbl2" runat="server" Text="Logística" Font-Size="X-Large"></asp:Label>
    

        <br />
    

    <table class="egt" id="Table_logistica" runat="server">

        <tr>

    <td class="auto-style4">&nbsp;</td>

    <td aria-multiline="True" class="auto-style3">
        <asp:Label ID="Fallo_lbl1" runat="server" Text="Seleccione Fallo:" Font-Size="X-Large"></asp:Label></td>

    <td class="auto-style3"><asp:Label ID="Modo_fallo_lbl3" runat="server" Text="Seleccione el modo de fallo:" Font-Size="X-Large"></asp:Label></td>

    <td class="auto-style4"><asp:Label ID="Causa_lbl1" runat="server" Text="Seleccione la causa:" Font-Size="X-Large"></asp:Label></td>

    <td class="auto-style4"><asp:Label ID="Causa_lbl4" runat="server" Text="Minutos:" Font-Size="X-Large"></asp:Label></td>

    <td class="auto-style4">&nbsp;</td>

  </tr>

  <tr>

    <td class="auto-style2">
        <br />
      </td>

    <td class="auto-style10"><asp:DropDownList ID="Dropdown_Logistica_Fallo_1" runat="server" AutoPostBack="true"  Height="31px" OnSelectedIndexChanged="Logistica_1_opt_Modo" Width="220px" Font-Size="Large">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Logistica_Fallo_2" runat="server" AutoPostBack="true"  Height="31px" OnSelectedIndexChanged="Logistica_2_opt_Modo" Width="220px" Font-Size="Large">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Logistica_Fallo_3" runat="server" AutoPostBack="true"  Height="31px" OnSelectedIndexChanged="Logistica_3_opt_Modo" Width="220px" Font-Size="Large">
    </asp:DropDownList></td>

    <td class="auto-style10"><asp:DropDownList ID="Dropdown_Logistica_Modo_1" runat="server" AutoPostBack="true"  Height="31px" OnSelectedIndexChanged="Logistica_1_opt_Causa" Width="335px" Font-Size="Large">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Logistica_Modo_2" runat="server" AutoPostBack="true"  Height="31px" OnSelectedIndexChanged="Logistica_2_opt_Causa" Width="335px" Font-Size="Large">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Logistica_Modo_3" runat="server" AutoPostBack="true"  Height="31px" OnSelectedIndexChanged="Logistica_3_opt_Causa" Width="335px" Font-Size="Large">
    </asp:DropDownList></td>

    <td class="auto-style11"><asp:DropDownList ID="Dropdown_Logistica_Causa_1" runat="server" AutoPostBack="true" Height="31px" Width="367px" Font-Size="Large" OnSelectedIndexChanged="Dropdown_Logistica_Causa_1_SelectedIndexChanged">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Logistica_Causa_2" runat="server" AutoPostBack="true" Height="31px" Width="367px" Font-Size="Large" OnSelectedIndexChanged="Dropdown_Logistica_Causa_2_SelectedIndexChanged">
    </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Dropdown_Logistica_Causa_3" runat="server" AutoPostBack="true" Height="31px"  Width="367px" Font-Size="Large" OnSelectedIndexChanged="Dropdown_Logistica_Causa_3_SelectedIndexChanged">
    </asp:DropDownList></td>

    <td class="auto-style11">
        <asp:DropDownList ID="Min_Logistica_1" runat="server" Height="31px" Width="200px" AutoCompleteType="Disabled" AutoPostBack="True" Font-Bold="True" Font-Size="Large" ForeColor="Blue" OnTextChanged="Min_Mantto_1_TextChanged"></asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Min_Logistica_2" runat="server" Height="31px" Width="200px" AutoCompleteType="Disabled" AutoPostBack="True" Font-Bold="True" Font-Size="Large" ForeColor="Blue" OnTextChanged="Min_Mantto_1_TextChanged"></asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="Min_Logistica_3" runat="server" Height="31px" Width="200px" AutoCompleteType="Disabled" AutoPostBack="True" Font-Bold="True" Font-Size="Large" ForeColor="Blue" OnTextChanged="Min_Mantto_1_TextChanged"></asp:DropDownList>
      </td>

    <td class="auto-style2">
        &nbsp;</td>

  </tr>

  
    </table>
        <br />
    <table class="egt">

        <tr>

    <td class="auto-style4">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click"  Text="Guardar información" Height="46px" Width="285px" BackColor="#33CC33" BorderStyle="Groove" ForeColor="White" Font-Bold="True" Font-Size="X-Large" />
            </td>

  </tr>

  <tr>

    <td class="auto-style2">
        <br />
        <asp:Button ID="Button2" runat="server" BackColor="Red" ForeColor="White" Height="24px" OnClick="Button2_Click" Text="Cancelar" Width="88px" />
      </td>

  </tr>

  
    </table>
        <br />
        <br />
        <br />
        <br />
    <br />
        <br />
        <br />
        <br />
        <br />
    <asp:SqlDataSource ID="Tipo_Falla" runat="server" ConnectionString="<%$ ConnectionStrings:Tipos_falla_cnn %>" ProviderName="<%$ ConnectionStrings:Tipos_falla_cnn.ProviderName %>" SelectCommand="SELECT DISTINCT Tipo_falla FROM Fallos_Mantenimiento"></asp:SqlDataSource>
    <br />   


        <br />
 </div>
    
</asp:Content>
 