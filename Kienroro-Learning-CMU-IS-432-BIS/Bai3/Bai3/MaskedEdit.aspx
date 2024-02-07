<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MaskedEdit.aspx.cs" Inherits="Bai3.MaskedEdit" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1">
        <%--<asp:ScriptManager ID="SM1" runat="server" EnablePartialRendering="True" />--%>
        Nhập ngày tháng theo dạng: MM/dd/yyyy (culture sensitive)<br />
        <asp:TextBox ID="TextBox1" runat="server" Width="130px" ValidationGroup="Demo1" MaxLength="1" Style="text-align: justify" />

        <ajaxToolkit:MaskedEditExtender ID="MaskedEditExtender1" runat="server" TargetControlID="TextBox1"
            Mask="99/99/9999" MessageValidatorTip="true" MaskType="Date" DisplayMoney="Left"
            AcceptNegative="Left" />
        <ajaxToolkit:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1" ControlToValidate="TextBox1"
            IsValidEmpty="False"
            EmptyValueMessage="Phải nhập ngày tháng" InvalidValueMessage="Ngày tháng nhập sai" ValidationGroup="Demo1"
            Display="Dynamic" TooltipMessage="Nhập vào một ngày" />
    </form>
</asp:Content>
