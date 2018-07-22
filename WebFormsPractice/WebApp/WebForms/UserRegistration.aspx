<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="WebApp.WebForms.UserRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <h1>User Registration</h1>
            <p class="col-sm-5" style="padding-left:0; padding-right: 37px;">
                Please fill in the form below and click submit. After submitting the
                form, you will receive an email with a link to confirm your registration.
                By clicking on that link, you will complete the registration process.
            </p>
        </div>

        <%--validation controls 
            ErrorMessage: displays the error message in summary
            ControlToValidate: which input control does this validation belong to
            SetFocusOnError: places curser on control if invalid
            ForeColor: styling change message color
            Display handles whether control side messages appear and the location beside the control--%>

        <asp:RequiredFieldValidator ID="RequiredFieldFirstName" runat="server" ErrorMessage="First Name is required"
            ControlToValidate="FirstName" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldLastName" runat="server" ErrorMessage="Last Name is required"
            ControlToValidate="LastName" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldUserName" runat="server" ErrorMessage="User Name is required"
            ControlToValidate="UserName" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>

        <asp:RequiredFieldValidator ID="RequiredFieldEmailAddress" runat="server" ErrorMessage="Email Address is required"
            ControlToValidate="EmailAddress" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionEmailAddress" runat="server" ErrorMessage="Invalid Email Address, needs to be in format xxx@yyy.zzz"
            ControlToValidate="EmailAddress" SetFocusOnError="true" Display="None" 
            ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldConfirmEmail" runat="server" ErrorMessage="Confirm Email is required"
            ControlToValidate="ConfirmEmail" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareEmail" runat="server" ErrorMessage="Email Address does not match Confirm Email"
            ControlToValidate="ConfirmEmail" ControlToCompare="EmailAddress" SetFocusOnError="true" Display="None"></asp:CompareValidator>

        <asp:RequiredFieldValidator ID="RequiredFieldPassword" runat="server" ErrorMessage="Password is required"
            ControlToValidate="Password" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Password must include at least one numeric digit"
            Display="None" ControlToValidate="Password" ValidationExpression=".*[0-9].*"></asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionPassword2" runat="server" ErrorMessage="Password must be between 4 and 8 digits long"
            Display="None" ControlToValidate="Password" ValidationExpression="[^\s]{4,8}"></asp:RegularExpressionValidator> 
       <asp:RequiredFieldValidator ID="RequiredFieldConfirmPassword" runat="server" ErrorMessage="Confirm Password is required"
            ControlToValidate="ConfirmPassword" SetFocusOnError="true" Display="None"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="ComparePassword" runat="server" ErrorMessage="Password and Confirm Password do not match"
            ControlToValidate="ConfirmPassword" ControlToCompare="Password" SetFocusOnError="true" Display="None"></asp:CompareValidator>


        <div class="col-sm-5 grid-form">
            <asp:Label ID="Label1" runat="server" Text="First Name" AssociatedControlID="FirstName"></asp:Label>
            <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>

            <asp:Label ID="Label2" runat="server" Text="Last Name" AssociatedControlID="LastName"></asp:Label>
            <asp:TextBox ID="LastName" runat="server"></asp:TextBox>

            <asp:Label ID="Label3" runat="server" Text="User Name" AssociatedControlID="UserName"></asp:Label>
            <asp:TextBox ID="UserName" runat="server"></asp:TextBox>

            <asp:Label ID="Label4" runat="server" Text="Email Address" AssociatedControlID="EmailAddress"></asp:Label>
            <asp:TextBox ID="EmailAddress" runat="server"></asp:TextBox>

            <asp:Label ID="Label5" runat="server" Text="Confirm Email" AssociatedControlID="ConfirmEmail"></asp:Label>
            <asp:TextBox ID="ConfirmEmail" runat="server"></asp:TextBox>

            <asp:Label ID="Label6" runat="server" Text="Password" AssociatedControlID="Password"></asp:Label>
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>

            <asp:Label ID="Label7" runat="server" Text="Confirm Password" AssociatedControlID="ConfirmPassword"></asp:Label>
            <asp:TextBox ID="ConfirmPassword" runat="server"></asp:TextBox>

        </div>
        <div class="col-sm-4">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Business Rules" CssClass ="alert" BackColor="Yellow"/>

            <asp:Label ID="MessageUserInfo" runat="server" ForeColor="Firebrick"></asp:Label>
        </div>
        <div class="col-sm-12 grid-form">
            <asp:CheckBox ID="Terms" runat="server" Text="I agree to the terms of this site" />
        </div>
        <div class="col-sm-12">
            <asp:Button ID="SubmitRegistration" runat="server" Text="Submit Registration" OnClick="SubmitRegistration_Click"/>
            <br />
            <br />
            <br />
            <asp:GridView ID="UserInfoGridView" runat="server"></asp:GridView>
        </div>
    </div>
</asp:Content>
