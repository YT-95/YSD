<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage1.master" AutoEventWireup="true" CodeFile="ysd_admin_busdetails.aspx.cs" Inherits="Admin_ysd_admin_busdetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 43px;
        }
        .auto-style3 {
            width: 41px;
        }
        .auto-style4 {
            text-align: right;
            width: 105px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            
            
    <table class="w-100">
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label1" runat="server" ForeColor="White" Text="To"></asp:Label>        
            </td>
            <td style="text-align: left" class="auto-style3">
                <asp:TextBox ID="txt_to" runat="server" Width="200" Height="30"></asp:TextBox>
            </td>
            <td class="auto-style2" style="text-align: right">
                <asp:Label ID="Label2" runat="server" Text="From" Width="200" Height="30"></asp:Label>
            </td>
            <td style="text-align: left">
                <asp:TextBox ID="txt_from" runat="server" Width="198px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label3" runat="server" Text="Departure Time"></asp:Label></td>
            <td class="auto-style3"><asp:TextBox ID="dep_time" runat="server" Width="200" Height="30"></asp:TextBox></td>
            <td class="text-right"><asp:Label ID="Label4" runat="server" Text="Reach Time"></asp:Label></td></td>
            <td class="text-left"><asp:TextBox ID="arr_time" runat="server" Width="200" Height="30"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style4"><asp:Label ID="Label5" runat="server" Text="Kilometer"></asp:Label></td></td>
            <td class="auto-style3"><asp:TextBox ID="km" runat="server" Width="200" Height="30"></asp:TextBox></td>
            <td class="text-right"><asp:Label ID="Label6" runat="server" Text="Rate"></asp:Label></td></td>
            <td class="text-left"><asp:TextBox ID="rate" runat="server" Width="200" Height="30"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="text-left">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2"><asp:Button ID="btn_save" runat="server" Text="Add Bus" OnClick="btn_save_Click" /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
            
            
    
            
            
<br />
   
            
</asp:Content>

