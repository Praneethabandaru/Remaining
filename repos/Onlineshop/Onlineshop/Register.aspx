<%@ Page Title="" Language="C#" MasterPageFile="~/MyTemplate.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Onlineshop.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style8 {
        width: 261px;
    }
    .auto-style9 {
        width: 261px;
        height: 24px;
    }
    .auto-style10 {
        height: 24px;
    }
    .auto-style11 {
        width: 261px;
        height: 17px;
    }
    .auto-style12 {
        height: 17px;
    }
        .auto-style13 {
        width: 202px;
    }
        .auto-style14 {
        height: 24px;
        width: 202px;
    }
        .auto-style15 {
            height: 17px;
            width: 202px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>

    <script>
        function myfunc(source, args)
        {
            //country has to be india , canada and japan

            if(args.Value == "india" || args.Value == "canada" || args.Value == "japan")
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    </script>

<table style="width: 100%; height: 57px; margin-bottom: 63px;">
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style13">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style8">Username</td>
        <td class="auto-style13">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please Enter Username" Display="None"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">Password </td>
        <td class="auto-style14">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style10">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">Confirm Password</td>
        <td class="auto-style14">
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style10">
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Passwords Mismatch!" Display="None"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">Gender</td>
        <td class="auto-style14">
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
        </td>
        <td class="auto-style10"></td>
    </tr>
    <tr>
        <td class="auto-style9">Age</td>
        <td class="auto-style14">
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style10">
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="You are not eligible to register" MaximumValue="100" MinimumValue="10" Type="Integer" Display="None"></asp:RangeValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">Email</td>
        <td class="auto-style14">
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style10">
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="Invalid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="None"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style11">Nationality</td>
        <td class="auto-style15">
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
        <td class="auto-style12">
            <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="myfunc" ControlToValidate="TextBox6" Display="None" ErrorMessage="You are living in wrong country"></asp:CustomValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style14">&nbsp;</td>
        <td class="auto-style10">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">&nbsp;</td>
        <td class="auto-style14">
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
        <td class="auto-style10">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" />
        </td>
    </tr>

</table>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
