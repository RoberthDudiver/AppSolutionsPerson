<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Layout.Master" CodeBehind="Default.aspx.vb" Inherits="APPWebPerson.Formulario_web1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
      
       
    </asp:ScriptManager>
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Button ID="Agregar" runat="server" Text="Agregar Persona" />
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                <div class="container">

                    <div id="signupbox" style="margin-top: 5px" class="mainbox col-md-9">
                        <div class="panel panel-info">
                            <div class="panel-heading">
                                <div class="title">Persona</div>
                             
                            </div>
                            <div class="panel-body">
                                 <div class="controls col-md-6 "  style="margin-bottom: 10px">
                                <asp:TextBox ID="Name" class="form-control" placeholder="Nombre" runat="server"></asp:TextBox>
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Name" ErrorMessage="Se requiere los nombres">*</asp:RequiredFieldValidator>
                                </div>
                                <div class="controls col-md-6 "  style="margin-bottom: 10px">
                                <asp:TextBox ID="SecondName" class="form-control" placeholder="Apellido" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="SecondName" ErrorMessage="se requiere los apellidos">*</asp:RequiredFieldValidator>
                                </div>
                                   <div class="controls col-md-6 "  style="margin-bottom: 10px">
                <asp:TextBox ID="BirthDate"  class=" form-control" placeholder="Fechade Nacimiento" runat="server"></asp:TextBox>
                                       <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="BirthDate" ErrorMessage="se requiere la fecha de nacimiento">*</asp:RequiredFieldValidator>
                                       <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="BirthDate" ErrorMessage="Debe ingresar una fecha correcta" ValidationExpression="(^(((0[1-9]|1[0-9]|2[0-8])[\/](0[1-9]|1[012]))|((29|30|31)[\/](0[13578]|1[02]))|((29|30)[\/](0[4,6,9]|11)))[\/](19|[2-9][0-9])\d\d$)|(^29[\/]02[\/](19|[2-9][0-9])(00|04|08|12|16|20|24|28|32|36|40|44|48|52|56|60|64|68|72|76|80|84|88|92|96)$)">*</asp:RegularExpressionValidator>
                                </div>
                                  <div class="controls col-md-6 "  style="margin-bottom: 10px">
                                      <p class="text-primary">Sexo</p>
                                      <asp:RadioButton   class="controls " ID="Femenino" runat="server"  GroupName="Sex" Text="Femenino"/>
                                      <asp:RadioButton   class="controls " ID="Masculino" runat="server" GroupName="Sex" Text="Masculino" />

                                </div>
                                 <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                                 <asp:Button ID="Button1" runat="server" Text="Guardar"  OnClientClick="return confirm('Seguro quiere Guardar?')" />
                                 <asp:Button ID="Eliminar" runat="server" Text="Eliminar"  OnClientClick="return confirm('Seguro desea Eliminar?')" />
                                 <asp:Button ID="Button3" runat="server" CausesValidation="False" Text="Cancelar" />
                                 <asp:Button ID="Button2" runat="server" CausesValidation="False" Text="Cerrar" />
                            
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>

            <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" EnableModelValidation="True" Width="1004px" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="IDPeople" HeaderText="IDPeople" Visible="False" />
                    <asp:BoundField DataField="FullName" HeaderText="Nombre Completo" />
                    <asp:BoundField DataField="Age" HeaderText="Edad" />
                    <asp:BoundField DataField="Sex" HeaderText="Sexo" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:GridView>
        </ContentTemplate>

    </asp:UpdatePanel>
 
</asp:Content>
