<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="PrelimAct2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        .hidden{
            display: none;
        }
        body{
            background-color: #eee;
        }
        .container{ margin-top: 20px; }
        .form-signin{
            width: 600px;
            padding: 20px;
            border-radius: 10px;
            background-color: #fff;
            margin: auto;
        }

    </style>

    <script runat="server">
      
   </script>    


</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        

            <h3 class="display-4 text-center">Welcome</h3>
            <h5 class="display-5 text-center">Log-in to Ian Santiago's shop</h5>
     
        <div class="form-signin align-content-center">
         <div runat="server" id="custalert" class="alert alert-danger alert-dismissible hidden">
            <asp:CustomValidator 
                id="customValidator"
                ControlToValidate="TbEmail"  
                runat="server" 
                ErrorMessage="No account exist!"
                OnServerValidate="ServerValidation" 
                Display="Dynamic"/>
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        </div>
            <div class="form-group">
                <label>Email address:</label>
                <asp:TextBox CssClass="form-control" ID = "TbEmail" runat="server" TextMode="Email"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Password:</label>
                <asp:TextBox CssClass="form-control" ID = "TbPassword" runat="server" Text="Password" TextMode="Password"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Button CssClass="form-control btn btn-primary" Text="log-in" runat="server" OnClick="Unnamed1_Click" />
            </div>


            &nbsp;<asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="Registration.aspx">No Account yet? Register here</asp:LinkButton>

        </div>




    </div>
    </form>
    <script src="Scripts/jquery-3.0.0.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

</body>
</html>
