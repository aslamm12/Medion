<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="user_page.aspx.cs" Inherits="Medion.user_page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 18px;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
            text-align: center;
        }
        .auto-style4 {
            width: 99px;
        }
        .auto-style5 {
            height: 18px;
            width: 99px;
        }
        .auto-style6 {
            height: 26px;
            width: 99px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="4"></td>
            <td class="auto-style2" colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style5">
                <asp:DataList ID="DataList1" runat="server" DataKeyField="cat_id" DataSourceID="SqlDataSource1" RepeatColumns="3" Width="832px" OnItemCommand="ImageButton1_Command">
                    <ItemTemplate>
                        <table class="w-100">
                            <tr>
                                <td class="text-center"><strong>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("cat_name") %>'></asp:Label>
                                    </strong></td>
                            </tr>
                            <tr>
                                <td class="text-center">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style3">
                                    <asp:ImageButton ID="ImageButton1" runat="server" Height="108px" Width="175px" ImageUrl='<%# Eval("cat_image") %>' />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="text-center"><em>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("cat_desc") %>'></asp:Label>
                                    </em></td>
                            </tr>
                        </table>
                        <div class="text-center">
                            <br />
                            <table class="w-100">
                                <tr>
                                    <td class="text-center">
                                        &nbsp;</td>
                                </tr>
                            </table>
                            <br />
                        </div>
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
