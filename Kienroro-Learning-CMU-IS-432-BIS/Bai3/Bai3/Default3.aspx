<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default3.aspx.cs" Inherits="Bai3.Default3" %>

<%@ Register
    Assembly="AjaxControlToolkit"
    Namespace="AjaxControlToolkit"
    TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1">
        <%--<asp:ScriptManager ID="ScriptManager1"
            runat="Server" EnableScriptGlobalization="true"
            EnableScriptLocalization="true" />--%>
        <b>Nhập ngày sinh:</b>
        <asp:TextBox runat="server" ID="txtNS"></asp:TextBox>
        <ajaxToolkit:CalendarExtender ID="cal" TargetControlID="txtNS" runat="server"></ajaxToolkit:CalendarExtender>
    </form>
</asp:Content>
