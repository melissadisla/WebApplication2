<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="MembersOnly.aspx.cs" Inherits="WebApplication2.Account.MembersOnly" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
    <%@ Import Namespace="System.Web.Mail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    &nbsp;
  


     <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>


        
      <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Nivel Actual:"></asp:Label>
    <asp:Label ID="Label6" runat="server"></asp:Label>
    <br />


        
      <asp:Chart ID="Chart1" runat="server" AlternateText="Datos en Analog1" 
        DataSourceID="ObjectDataSource1" Width="863px" EnableViewState="True" 
        onload="Chart1_Load">
        <Series>
            <asp:Series ChartType="Line" Name="Series1" XValueMember="time" 
                XValueType="Time" YValueMembers="value">
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Rango deseado:"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Min:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="45px">0</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Max:"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" ontextchanged="TextBox2_TextChanged" 
        Width="42px">1000</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Guardar" />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="getAnalog1" TypeName="WebApplication2.Datos">
    </asp:ObjectDataSource>
    

 
        
    <asp:Label ID="Label4" runat="server" Text="Rango inválido" Visible="False"></asp:Label>
    <br />
    <asp:RangeValidator ID="RangeValidator1" runat="server" 
        ControlToValidate="TextBox1" ErrorMessage="Introduzca un mínimo válido" 
        MaximumValue="1000" MinimumValue="100" Type="Double"></asp:RangeValidator>
    <br />
    <asp:RangeValidator ID="RangeValidator2" runat="server" 
        ControlToValidate="TextBox2" ErrorMessage="Introduzca un máximo válido" 
        MaximumValue="1000" MinimumValue="100"></asp:RangeValidator>
    

 
        
    <br />
    <asp:Label ID="Label7" runat="server" Text="Nivel actual:"></asp:Label>
    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Chart ID="Chart2" runat="server" DataSourceID="ObjectDataSource2" 
        Width="869px">
        <Series>
            <asp:Series ChartType="Line" Name="Series1" XValueMember="time" 
                XValueType="Time" YValueMembers="value">
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
        SelectMethod="getAnalog2" TypeName="WebApplication2.Datos">
    </asp:ObjectDataSource>
    <br />
    <asp:Label ID="Label11" runat="server" Text="Rango deseado:"></asp:Label>
    <br />
    <asp:Label ID="Label12" runat="server" Text="Min:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server" Width="45px">0</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label13" runat="server" Text="Max:"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox4" runat="server" ontextchanged="TextBox2_TextChanged" 
        Width="42px">1000</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        Text="Guardar" />
    <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" 
        SelectMethod="getAnalog1" TypeName="WebApplication2.Datos">
    </asp:ObjectDataSource>
    

 
        
    <asp:Label ID="Label14" runat="server" Text="Rango inválido" Visible="False"></asp:Label>
    <br />
    <asp:RangeValidator ID="RangeValidator3" runat="server" 
        ControlToValidate="TextBox1" ErrorMessage="Introduzca un mínimo válido" 
        MaximumValue="1000" MinimumValue="100" Type="Double"></asp:RangeValidator>
    <br />
    <asp:RangeValidator ID="RangeValidator4" runat="server" 
        ControlToValidate="TextBox2" ErrorMessage="Introduzca un máximo válido" 
        MaximumValue="1000" MinimumValue="100"></asp:RangeValidator>
    

 
        
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label9" runat="server" Text="Nivel Actual:"></asp:Label>
    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Chart ID="Chart3" runat="server" DataSourceID="ObjectDataSource3" 
        Width="871px">
        <Series>
            <asp:Series ChartType="Line" Name="Series1" XValueMember="time" 
                XValueType="Time" YValueMembers="value">
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" 
        SelectMethod="getAnalog3" TypeName="WebApplication2.Datos">
    </asp:ObjectDataSource>
    <asp:Label ID="Label15" runat="server" Text="Rango deseado:"></asp:Label>
    <br />
    <asp:Label ID="Label16" runat="server" Text="Min:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox5" runat="server" Width="45px">0</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label17" runat="server" Text="Max:"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox6" runat="server" ontextchanged="TextBox2_TextChanged" 
        Width="42px">1000</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
        Text="Guardar" />
    <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" 
        SelectMethod="getAnalog1" TypeName="WebApplication2.Datos">
    </asp:ObjectDataSource>
    

 
        
    <asp:Label ID="Label18" runat="server" Text="Rango inválido" Visible="False"></asp:Label>
    <br />
    <asp:RangeValidator ID="RangeValidator5" runat="server" 
        ControlToValidate="TextBox1" ErrorMessage="Introduzca un mínimo válido" 
        MaximumValue="1000" MinimumValue="100" Type="Double"></asp:RangeValidator>
    <br />
    <asp:RangeValidator ID="RangeValidator6" runat="server" 
        ControlToValidate="TextBox2" ErrorMessage="Introduzca un máximo válido" 
        MaximumValue="1000" MinimumValue="100"></asp:RangeValidator>
    

 
        
    <br />
    

 
        
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpfoo" runat="server">
<asp:Timer ID="Timer1" runat="server" Interval="5000" 
        ontick="Timer1_Tick">
        </asp:Timer>

   
    </asp:Content>