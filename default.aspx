<%@ Page Title="" Language="C#" MasterPageFile="~/mainpage.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1.WebForm1" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder_title" runat="server">
    <%--موسسه آموزشی صابر--%>
    <% Response.Write(HeaderContent_meta_title); %>
</asp:Content>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder_TopLinkBar" runat="server">
    <%Response.Write(BodyContent_html_TopLinkkBar); %>
</asp:Content>


<asp:Content ContentPlaceHolderID="ContentPlaceHolderNextCources" runat="server">
    <tr>
        <td>
    <%Response.Write(BodyContent_html_NextCources); %>
        </td>
    </tr>
</asp:Content>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder_certified" runat="server">
    <tr>
        <td>
    <% Response.Write(BodyContent_html_certified); %>
        </td>
    </tr>
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder_footer" runat="server">
    <form id="form1" runat="server">
    <%Response.Write(BodyContent_html_TopLinkkBar); %>
    </form>
</asp:Content>
