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
                <td colspan="2"><strong>Instructions:</strong><br />
                    1. Enter a number.<br />
                    2. Click the button to view the numeric sequence<br />
                    <br />
                    Note:The following numeric sequences shall be displayed:
                    <br />
                    S3.1.1 All numbers up to and including the number entered, 
                    <br />       
                    S3.1.2 All odd numbers up to and including the number entered, 
                    <br />
                    S3.1.3 All even numbers up to and including the number entered, 
                    <br />
                    S3.1.4 All numbers up to and including the number entered, except when, 
                    <br />
                    S3.1.4.1 A number is a multiple of 3 output C, and when, 
                    <br />
                    S3.1.4.2 A number is a multiple of 5 output E, and when, 
                    <br />
                    S3.1.4.3 A number is a multiple of both 3 and 5 output Z, 
                    <br />
                    S3.1.5 All fibonacci number up to and including the number entered.</td>
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
