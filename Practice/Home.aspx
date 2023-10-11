<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Home.aspx.vb" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="ProductID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtproductID" runat="server" Width="200px"></asp:TextBox>
                &nbsp;
                    <asp:Button ID="Button4" runat="server" Height="34px" Text="Search" Width="138px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Item Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtitemname" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Specification"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtspecification" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Unit"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="Dropunit" runat="server">
                        <asp:ListItem>KG</asp:ListItem>
                        <asp:ListItem>PCS</asp:ListItem>
                        <asp:ListItem>DZN</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Color"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="Radiocolor" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Black</asp:ListItem>
                        <asp:ListItem>white</asp:ListItem>
                        <asp:ListItem>green</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Insert Date"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtdate" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Opening Quantity"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtopeningqty" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Product Status"></asp:Label>
                </td>
                <td>
                    <asp:CheckBoxList ID="Checkregular" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Regular</asp:ListItem>
                        <asp:ListItem>Irregular</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Height="34px" Text="Insert" Width="138px" />
                &nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Height="34px" Text="Update" Width="138px" />
                    <asp:Button ID="Button3" runat="server" Height="34px" Text="Delete" Width="138px" OnClientClick="return confirm('Are you sure to delete?')" />
                </td>
            </tr>
        </table>
        <br />
        <div align="center" style="padding:15px">

            <hr />
            <asp:GridView ID="GridView1" runat="server" Width="80%">
            </asp:GridView>
        </div>

    </form>
</body>
</html>
