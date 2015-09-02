<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WalterCodingTask.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width:200px;
        }

        table, td, th {
            border: 1px solid blue;
            border-collapse: collapse;
        }

        th {
            background-color: blue;
            color: white;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <table style="width:100%;">
            <tr>
                <th class="auto-style1" colspan="2">Numeric Sequence Calculator - Walter</th>
            </tr>
            <tr>
                <td class="auto-style1">Please enter a number</td>
                <td>
                    <asp:TextBox ID="txtNumber" runat="server" required="required" pattern="[0-9]*"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="btnViewNumSequence" runat="server" Text="View numeric sequence" OnClick="btnViewNumSequence_Click"  />
                &nbsp;<asp:Label ID="lblSuccess" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">
                    <asp:Label ID="lblOutput" runat="server" Text="Output is displayed here"></asp:Label>
                </td>
            </tr>
        </table>
        <br />

    
    </div>
    </form>
</body>
</html>
