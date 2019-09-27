<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Country.aspx.cs" Inherits="PNY.Batch18.WebUI.Country" %>

<asp:Content ID="CountryPage" ContentPlaceHolderID="MainContent" runat="server">
    <div class="Row padTOP">
        <table>
            <tr>
                <td>Name: </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
