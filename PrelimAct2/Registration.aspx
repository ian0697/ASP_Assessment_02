<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="PrelimAct2.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: #eee;
        }

        .container {
            margin-top: 20px;
        }

        .form-signin {
            width: 600px;
            padding: 20px;
            border-radius: 10px;
            background-color: #fff;
            margin: auto;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="form-signin align-content-center">


                <h3 class="display-4 text-center">REGISTRATION</h3>
                <h5 class="display-5 text-center">Please enter all the required fields*</h5>


                <div class="form-group">
                    <label>Email Address:</label>
                    <asp:TextBox CssClass="form-control" ID="TbEmail" TextMode="Email" runat="server"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label>Password:</label>
                    <asp:TextBox CssClass="form-control" ID="TbPassword" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator CssClass="alert-danger" Display="Dynamic" runat="server" ControlToValidate="TbPassword" Text="*Required field" ForeColor="#CC0000">*Required field</asp:RequiredFieldValidator>

                </div>

                <div class="form-group">
                    <label>Confirm Password:</label>
                    <asp:TextBox CssClass="form-control" ID="TbPassword2" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="Compare1"
                        Display="Dynamic"
                        ControlToValidate="TbPassword2"
                        ControlToCompare="TbPassword"
                        Type="String"
                        EnableClientScript="false"
                        ForeColor="#CC0000"
                        Text="Password doesn't match!"
                        CssClass="alert-danger"
                        runat="server" />
                </div>

                <div class="form-group">
                    <label>First Name:</label>
                    <asp:TextBox CssClass="form-control" ID="TbFirstName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator Display="Dynamic" runat="server" ControlToValidate="TbFirstName" Text="*Required field" ForeColor="#CC0000">*Required field</asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label>Last Name:</label>
                    <asp:TextBox CssClass="form-control" ID="TbLastName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator Display="Dynamic" runat="server" ControlToValidate="TbLastName" Text="*Required field" ForeColor="#CC0000">*Required field</asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <label>Birthday:</label>
                    <asp:TextBox CssClass="form-control" ID="TbBirthday" TextMode="Date" runat="server"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label>Address:</label>
                    <asp:TextBox CssClass="form-control" ID="TbAddress" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator Display="Dynamic" runat="server" ControlToValidate="TbAddress" Text="*Required field" ForeColor="#CC0000">*Required field</asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label>Contact number:</label>
                    <asp:TextBox CssClass="form-control" ID="TbContact" runat="server" TextMode="Number"></asp:TextBox>
                    <asp:RequiredFieldValidator Display="Dynamic" runat="server" ControlToValidate="TbContact" Text="*Required field" ForeColor="#CC0000">*Required field</asp:RequiredFieldValidator>
                </div>

                <div class="form-group">
                    <asp:Button CssClass="form-control btn btn-primary" Text="REGISTER" runat="server" OnClick="Unnamed1_Click" />
                </div>


                <a href="LoginForm.aspx" class="text-center">Already have an account? Sign in here</a>


            </div>




        </div>
    </form>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
