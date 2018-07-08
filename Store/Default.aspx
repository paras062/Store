<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Store.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblID" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblContentName" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblContentQuantity" runat="server"></asp:Label>

            <br />
            <asp:GridView ID="gridViewStoreInventory" runat="server"></asp:GridView>
            <br />
            <br />
            <h3>Insert Data</h3>
            <table>
                <tr>
                    <th>Content ID:</th>
                    <td><asp:TextBox ID="textBoxContentID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <th>Content Name:</th>
                    <td><asp:TextBox ID="textBoxContentName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <th>Content Quantity:</th>
                    <td><asp:TextBox ID="textBoxContentQuantity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <th><asp:Button ID="buttonInsertData" runat="server" Text="Insert Data" OnClick="buttonInsertData_Click" /></th>
                    <th><asp:Button ID="buttonUpdateData" runat="server" Text="Update Data" OnClick="buttonUpdateData_Click" /></th>
                    <th><asp:Button ID="buttonDeleteData" runat="server" Text="Delete Data" OnClick="buttonDeleteData_Click"/></th>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
