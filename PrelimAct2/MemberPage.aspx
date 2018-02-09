<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberPage.aspx.cs" Inherits="PrelimAct2.MemberPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        .cust{
            margin-top: 20px;
        }
        .show{
            display: none;
        }
        .cust-tb{
            max-width: 50%;
            display: inline;
        }
        .cust-btn{
            display: inline;
            vertical-align: unset;
        }
        .margin2x {
            margin-top: 50px;
        }
        .btn-submit{
            width: 100%;
            display: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
   
        <h3 class="display-3 text-center">Member's page</h3>
        <p class="text-center">You can only buy 10 products per item</p>
        <table class="table table-hover cust">
            <thead>
                <tr>
                    <th>Items</th>
                    <th>Stock</th>
                    <th>Price</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tr>
                <td>Ebooks</td>
                <td><asp:Label runat="server" ID="lbl1" Text="100"></asp:Label></td>
                <td>$20.25</td>
                <td>
                    <asp:TextBox id="tb1" CssClass ="form-control cust-tb" runat="server" TextMode="Number">0</asp:TextBox>
                    <asp:Button runat="server" ID="btnAdd" Text="Add" CssClass="btn btn-primary cust-btn" OnClick="btnAdd_Click"/>
                </td>
            </tr>
            
            <tr>
                <td>Training (Audio)</td>
                <td><asp:Label runat="server" ID="lbl2" Text="100"></asp:Label></td>
                <td>$8.75</td>
                <td><asp:TextBox CssClass ="form-control cust-tb" id="tb2" runat="server" TextMode="Number">0</asp:TextBox>
                    <asp:Button runat="server" ID="Button1" Text="Add" CssClass="btn btn-primary cust-btn" OnClick="Button1_Click"/></td>
            </tr>
           
            
            <tr>
                <td>Training (Video)</td>
                <td><asp:Label runat="server" ID="lbl3" Text="100"></asp:Label></td>
                <td>$32.55</td>
                <td><asp:TextBox CssClass ="form-control cust-tb" ID="tb3" runat="server" TextMode="Number">0</asp:TextBox>
                    <asp:Button runat="server" ID="Button2" Text="Add" CssClass="btn btn-primary cust-btn" OnClick="Button2_Click"/></td>
            </tr>
        </table>

        <div class="margin2x display-4">Transaction List
            <small runat="server" id="totalLabel" class="show text-muted">
                (Total: <asp:Label runat="server" ID="lblTotal" Text=""/>)
            </small>
        </div>

        <table>
            <asp:Repeater runat="server" ID="rptTrans">
                <HeaderTemplate>
                    <table class="table table-hover table-striped">
                        <thead>
                            <tr>
                                <th>Product</th>
                                <th>Quantity</th>
                                <th>Subtotal</th>
                            </tr>
                        </thead>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# DataBinder.Eval(Container.DataItem, "ProductName") %> </td>
                        <td><%# DataBinder.Eval(Container.DataItem, "ProductQuantity") %> </td>
                        <td><%# DataBinder.Eval(Container.DataItem, "Subtotal") %> </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </table>
        <div runat="server" id="btnsubmit" class="btn-submit form-group">
            <asp:Button runat="server" OnClick="submit_click" Text="Submit" CssClass="btn btn-primary" />
        </div>
    </div>
    </form>
</body>
</html>
