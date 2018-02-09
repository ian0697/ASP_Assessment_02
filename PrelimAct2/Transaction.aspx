<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="PrelimAct2.Transaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        .container{
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <table class="table">
                <thead>
                    <tr>
                        <th>Description</th>
                        <th>Value</th>
                    </tr>
                </thead>
                <tr>
                    <td>Full name: </td>
                    <td><asp:Label ID="lblFullname" runat="server"></asp:Label></td>
                </tr>
                
                <tr>
                    <td>Birthday: </td>
                    <td><asp:Label ID="lblBirthday" runat="server"></asp:Label></td>
                </tr>

                
                <tr>
                    <td>Address: </td>
                    <td><asp:Label ID="lblAddress" runat="server"></asp:Label></td>
                </tr>

                
                <tr>
                    <td>Contact: </td>
                    <td><asp:Label ID="lblContact" runat="server"></asp:Label></td>
                </tr>
                 
                <tr>
                    <td>Total Amount purchased: </td>
                    <td><asp:Label ID="lblTotal" runat="server"></asp:Label></td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
