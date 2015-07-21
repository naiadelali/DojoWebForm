<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UnitMeasure.aspx.cs" Inherits="DojoWebForm.UI.UnitMeasure" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1>Unit Measure</h1>

    <asp:GridView ID="GridUnitMeasure" runat="server" AutoGenerateColumns="false" >
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="Id" />
            <asp:BoundField HeaderText="Description" DataField="Description" />
            <asp:BoundField HeaderText="Abbreviation" DataField="Abbreviation" />
        </Columns>
    </asp:GridView>

    <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click" />

</asp:Content>
