<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CdLibrary.aspx.cs" Inherits="WebApp.WebForms.CdLibrary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-sm-12">
        <h1>CD Library</h1>
        <p class="col-sm-5" style="padding-left:0; padding-right: 37px;">
            Fill the form to add a music CD to your personal library.
        </p>
    </div>
    <div class="col-sm-5 grid-cdpage">
        <asp:Label ID="Label1" runat="server" Text="ISBN (Barcode)" AssociatedControlID="IsbnBarcode"></asp:Label>
        <asp:TextBox ID="IsbnBarcode" runat="server"></asp:TextBox>

        <asp:Button ID="Search" runat="server" Text="Search Online for CD"/>

        <asp:Label ID="Label2" runat="server" Text="Title" AssociatedControlID="CdTitle"></asp:Label>
        <asp:TextBox ID="CdTitle" runat="server"></asp:TextBox>

        <asp:Label ID="Label3" runat="server" Text="Artist(s)" AssociatedControlID="Artist"></asp:Label> 
        <asp:TextBox ID="Artist" runat="server" TextMode="MultiLine" Rows="2"></asp:TextBox> <%-- Gridview wasn't showing up in Chrome but in Firefox, commented out these two lines and opened it in Chrome, then it started working.--%>

        <asp:Label ID="Label4" runat="server" Text="Year" AssociatedControlID="Year"></asp:Label>
        <asp:TextBox ID="Year" runat="server"></asp:TextBox>

        <asp:Label ID="Label5" runat="server" Text="Number of Tracks" AssociatedControlID="NumberOfTracks"></asp:Label>
        <asp:TextBox ID="NumberOfTracks" runat="server"></asp:TextBox>

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    <div class="col-sm-12">
        <asp:Button ID="AddToLibrary" runat="server" Text="Add to Library"/>
    </div>
</asp:Content>
