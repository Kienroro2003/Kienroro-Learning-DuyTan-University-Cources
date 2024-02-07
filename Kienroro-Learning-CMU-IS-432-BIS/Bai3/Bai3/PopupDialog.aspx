<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PopupDialog.aspx.cs" Inherits="Bai3.PopupDialog" %>

<%@ Register Assembly="AjaxControlToolkit"
    Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1">
        <asp:Button ID="cmdOpenPopup" runat="server" Text="Cửa sổ Login" />
        <%--<asp:ScriptManager ID="sm1" runat="server"></asp:ScriptManager>--%>
        <asp:Panel ID="NoiDung" runat="server" Style="background-color: White; margin: 10px 10px 10px 10px; border: solid 2px">
            <asp:Panel ID="TieuDe" runat="server">
                <div style="background-color: Yellow">Thông báo  </div>
            </asp:Panel>
            User name:
            <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
            <br />
            Password :
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox><br />
            <asp:Button ID="cmdCancel" runat="server" Text="Hủy bỏ" />
            <asp:Button ID="cmdLogin" runat="server" Text="Đăng nhập" />
        </asp:Panel>
        <ajaxToolkit:ModalPopupExtender ID="Popup01" runat="server" TargetControlID="cmdOpenPopup"
            PopupControlID="NoiDung" OkControlID="cmdLogin" DropShadow="true" PopupDragHandleControlID="TieuDe">
        </ajaxToolkit:ModalPopupExtender>
    </form>
</asp:Content>
