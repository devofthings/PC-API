<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="API._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" style="width: 100vw; height:100vh;">

    <div class="jumbotron">
        <h1>requests</h1>
        <asp:Button ID="btn_get" Text="GET" OnClick="btn_get_Click" runat="server"/>
        <asp:Button ID="btn_put" Text="PUT" OnClick="btn_put_Click" runat="server" />
        <asp:Button ID="btn_post" Text="POST" OnClick="btn_post_Click" runat="server" />
        <asp:Button ID="btn_del" Text="DEL" OnClick="btn_del_Click" runat="server" />
        <asp:Button ID="btn_dwnl" Text="DOWNLOAD" OnClick="btn_dwnl_Click" runat="server" />
    </div>

    <div class="jumbotron">
        <h1>edit stuff</h1>
        <asp:Label Text="Change or Add PC by ID" runat="server" />
        <asp:TextBox ID="txt_selection_id" runat="server" />
        <asp:Label Text="CPU" runat="server" />
        <asp:TextBox ID="txt_cpu" runat="server" Text="" />
        <asp:Label Text="RAM" runat="server" />
        <asp:TextBox ID="txt_ram" runat="server" TextMode="Number" Text=0 />
    </div>

    <div class="jumbotron">
        <h1>result</h1>
        <asp:TextBox ID="txt_resultbox" width="1600px" runat="server" textmode="MultiLine" />
    </div>


</asp:Content>
