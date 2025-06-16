<%@ Page Title="" Language="C#" MasterPageFile="~/MyTemplate.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Onlineshop.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" Height="230px" Width="403px" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" PageSize="4">
        <Columns>
            <asp:CommandField />
            <asp:BoundField DataField="pid" HeaderText="pid" ReadOnly="True" SortExpression="pid" />
            <asp:BoundField DataField="pname" HeaderText="pname" SortExpression="pname" />
            <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
            <asp:ImageField DataImageUrlField="pimage">
            </asp:ImageField>
        </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:myshopConnectionString %>" SelectCommand="SELECT * FROM [products]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [products] WHERE [pid] = @original_pid AND (([pname] = @original_pname) OR ([pname] IS NULL AND @original_pname IS NULL)) AND (([description] = @original_description) OR ([description] IS NULL AND @original_description IS NULL)) AND (([price] = @original_price) OR ([price] IS NULL AND @original_price IS NULL)) AND (([pimage] = @original_pimage) OR ([pimage] IS NULL AND @original_pimage IS NULL))" InsertCommand="INSERT INTO [products] ([pid], [pname], [description], [price], [pimage]) VALUES (@pid, @pname, @description, @price, @pimage)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [products] SET [pname] = @pname, [description] = @description, [price] = @price, [pimage] = @pimage WHERE [pid] = @original_pid AND (([pname] = @original_pname) OR ([pname] IS NULL AND @original_pname IS NULL)) AND (([description] = @original_description) OR ([description] IS NULL AND @original_description IS NULL)) AND (([price] = @original_price) OR ([price] IS NULL AND @original_price IS NULL)) AND (([pimage] = @original_pimage) OR ([pimage] IS NULL AND @original_pimage IS NULL))">
    <DeleteParameters>
        <asp:Parameter Name="original_pid" Type="String" />
        <asp:Parameter Name="original_pname" Type="String" />
        <asp:Parameter Name="original_description" Type="String" />
        <asp:Parameter Name="original_price" Type="Int32" />
        <asp:Parameter Name="original_pimage" Type="String" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="pid" Type="String" />
        <asp:Parameter Name="pname" Type="String" />
        <asp:Parameter Name="description" Type="String" />
        <asp:Parameter Name="price" Type="Int32" />
        <asp:Parameter Name="pimage" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="pname" Type="String" />
        <asp:Parameter Name="description" Type="String" />
        <asp:Parameter Name="price" Type="Int32" />
        <asp:Parameter Name="pimage" Type="String" />
        <asp:Parameter Name="original_pid" Type="String" />
        <asp:Parameter Name="original_pname" Type="String" />
        <asp:Parameter Name="original_description" Type="String" />
        <asp:Parameter Name="original_price" Type="Int32" />
        <asp:Parameter Name="original_pimage" Type="String" />
    </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
