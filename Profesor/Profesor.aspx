﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profesor.aspx.cs" Inherits="lab2.Profesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml%22%3E
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 440px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="botonCerrarSesion" runat="server" Text="Cerrar sesión" OnClick="botonCerrarSesion_Click" style="margin-left: 454px" Width="133px" />
         <br />
            <br />
            <br />
            <br />
        <asp:Button ID="botonVerTareasAlumno" runat="server" BackColor="#0066FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="57px" OnClick="Button1_Click" Text="Tareas" Width="202px" />
        <div style="margin-left: 480px">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#0066FF" Text="Gestión Web de Tareas-Dedicación"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#0066FF" Text="Profesores"></asp:Label>
            <br />
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="#0066FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="53px" OnClick="Button1_Click1" Text="Estadisticas" Width="196px" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" BackColor="#0066FF" Font-Bold="True" Font-Size="Small" ForeColor="White" Height="53px" OnClick="Button2_Click" Text="Importar v. XMLDocument" Width="194px" />
        </p>
        <asp:Button ID="Button3" runat="server" BackColor="#0066FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="53px" OnClick="Button3_Click" Text="Exportar" Width="190px" />
        
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick">
                </asp:Timer>
                <br />
                <asp:Label ID="LabelUsuarios" runat="server"></asp:Label>
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" style="margin-left: 154px; margin-top: 6px" Width="358px"></asp:ListBox>
        <asp:ListBox ID="ListBox2" runat="server" Width="370px"></asp:ListBox>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>