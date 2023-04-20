<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListBox ID="ListPerson" runat="server" OnSelectedIndexChanged="ListPerson_SelectedIndexChanged" AutoPostBack="true"></asp:ListBox>
    <asp:Label ID="LabelDetail" runat="server" Text=""></asp:Label>
</asp:Content>
