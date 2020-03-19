<%@ Page Title="" Language="C#" MasterPageFile="~/maghalat.Master" AutoEventWireup="true" CodeBehind="instructors.aspx.cs" Inherits="WebApplication1.WebForm2" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder_title" runat="server">
    <%--موسسه آموزشی صابر--%>
    <% Response.Write(HeaderContent_meta_title); %>
</asp:Content>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder_TopLinkBar" runat="server">
    <%Response.Write(BodyContent_html_TopLinkkBar); %>
</asp:Content>


<asp:Content  ContentPlaceHolderID="ContentPlaceHolder_footer" runat="server">
    <%Response.Write(BodyContent_html_TopLinkkBar); %>
</asp:Content>

<asp:Content ID="Content1"  ContentPlaceHolderID="ContentPlaceHolder_matnemaghale" runat="server">
    <%Response.Write(BodyContent_html_instructors); %>
</asp:Content>