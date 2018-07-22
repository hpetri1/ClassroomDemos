<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MovieLibrary.aspx.cs" Inherits="WebApp.WebForms.MovieLibrary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-sm-12">
        <h1>Movie Library</h1>
        <p class="col-sm-5" style="padding-left:0; padding-right: 37px;">
            Fill out the form below to add information on the movie for your movie library.
        </p>
    </div>

    <asp:RequiredFieldValidator ID="RequiredFieldMovieTitle" runat="server" ErrorMessage="Title is required"
        ControlToValidate="MovieTitle" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldYear" runat="server" ErrorMessage="Year is required"
        ControlToValidate="Year" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
    <asp:RangeValidator ID="RangeValidatorYear" runat="server" ErrorMessage="Valid Year must be since 1900"
        ControlToValidate="Year" SetFocusOnError="true" Display="None" MinimumValue="1900" Type="Integer" MaximumValue="2018"></asp:RangeValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldMedia" runat="server" ErrorMessage="You must indicate the type of media on which the movie is stored"
        ControlToValidate="Media" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldRating" runat="server" ErrorMessage="You must indicate the rating type of the movie"
        ControlToValidate="Rating" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldReview" runat="server" ErrorMessage="Review is required"
        ControlToValidate="Review" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldIsbn" runat="server" ErrorMessage="ISBN is required"
        ControlToValidate="Isbn" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>

    <div class="col-sm-6 grid-form2">
        <asp:Label ID="Label1" runat="server" Text="Title" AssociatedControlID="MovieTitle"></asp:Label>
        <asp:TextBox ID="MovieTitle" runat="server"></asp:TextBox>

        <asp:Label ID="Label2" runat="server" Text="Year" AssociatedControlID="Year"></asp:Label>
        <asp:TextBox ID="Year" runat="server"></asp:TextBox>

        <asp:Label ID="Label3" runat="server" Text="Media" AssociatedControlID="Media"></asp:Label>
        <asp:RadioButtonList ID="Media" runat="server">
            <asp:ListItem Value="1" Text="DVD"></asp:ListItem>
            <asp:ListItem Value="2" Text="VHS"></asp:ListItem>
            <asp:ListItem Value="3" Text="File"></asp:ListItem>
        </asp:RadioButtonList>

        <asp:Label ID="Label4" runat="server" Text="Rating" AssociatedControlID="Rating"></asp:Label>
        <asp:RadioButtonList ID="Rating" runat="server">
            <asp:ListItem Value="1" Text="General (G)"></asp:ListItem>
            <asp:ListItem Value="2" Text="Parental Guidence (PG)"></asp:ListItem>
            <asp:ListItem Value="3" Text="14A"></asp:ListItem>
            <asp:ListItem Value="4" Text="18A"></asp:ListItem>
            <asp:ListItem Value="5" Text="Restricted (R)"></asp:ListItem>
        </asp:RadioButtonList>

        <asp:Label ID="Label5" runat="server" Text="Review (1-5 Stars)" AssociatedControlID="Review"></asp:Label>
        <div>
        <asp:DropDownList ID="Review" runat="server">
            <asp:ListItem Value="0">select...</asp:ListItem>
            <asp:ListItem Value="1" Text="1 Star"></asp:ListItem>
            <asp:ListItem Value="2" Text="2 Star"></asp:ListItem>
            <asp:ListItem Value="3" Text="3 Star"></asp:ListItem>
            <asp:ListItem Value="4" Text="4 Star"></asp:ListItem>
            <asp:ListItem Value="5" Text="5 Star"></asp:ListItem>
        </asp:DropDownList>
        </div>
        <asp:Label ID="Label6" runat="server" Text="ISBN" AssociatedControlID="Isbn"></asp:Label>
        <asp:TextBox ID="Isbn" runat="server"></asp:TextBox>
        <asp:Button ID="SearchOnline" runat="server" Text="Search Online" OnClick="SearchOnline_Click" />

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>

    <div class="col-sm-4">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Business Rules" CssClass ="alert" BackColor="Yellow"/>

        <asp:Label ID="MessageUserInfo" runat="server" ForeColor="Firebrick"></asp:Label>
    </div>

    <div class="col-sm-12">
        <asp:Button ID="AddToLibrary" runat="server" Text="Add To Library" OnClick="AddToLibrary_Click" />
    </div>
</asp:Content>
