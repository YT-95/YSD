﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage1.master" AutoEventWireup="true" CodeFile="ysd_admin_hoteldetails.aspx.cs" Inherits="Admin_ysd_admin_hoteldetails" %>

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
                <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Hotel Name"></asp:Label>        
            </td>
            <td style="text-align: left" class="auto-style3">
                <asp:TextBox ID="hotel_name" runat="server" Width="200" Height="30"></asp:TextBox>
            </td>
            <td class="auto-style2" style="text-align: right">
                <asp:Label ID="Label2" runat="server" Text="state" Width="200" Height="30"></asp:Label>
            </td>
            <td style="text-align: left">
                <asp:TextBox ID="state" runat="server" Width="198px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label3" runat="server" Text="city"></asp:Label></td>
            <td class="auto-style3"><asp:TextBox ID="city" runat="server" Width="200" Height="30"></asp:TextBox></td>
            <td class="text-right"><asp:Label ID="Label4" runat="server" Text="address"></asp:Label></td>
            <td class="text-left"><asp:TextBox ID="address" runat="server" Width="200" Height="30"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style4"><asp:Label ID="Label5" runat="server" Text="Rate"></asp:Label></td>
            <td class="auto-style3"><asp:TextBox ID="rate" runat="server" Width="200" Height="30"></asp:TextBox></td>
            <td class="text-right"><asp:Label ID="Label6" runat="server" Text="HelpLine No."></asp:Label></td></td>
            <td class="text-left"><asp:TextBox ID="help_no" runat="server" Width="200" Height="30"></asp:TextBox></td>
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
            <td class="auto-style2"><asp:Button ID="btn_save" runat="server" Text="Add Hotel" OnClick="btn_save_Click" /></td>
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

