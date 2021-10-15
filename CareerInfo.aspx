<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CareerInfo.aspx.cs" Inherits="career_guidance_system.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 1117px;
        }
        .auto-style2 {
            width: 1112px;
            height: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
 <div>
				<div class="card" >
				<img class="auto-style2" src="images/topcard.jpg" alt="Card image cap"/>
				<div class="card-body">
                     <table class="auto-style1">
                        <asp:GridView ID="GridView1" CssClass="table" AutoGenerateColumns="false" runat="server">
                            <Columns>
                                   <asp:BoundField DataField="Career" HeaderText="Career"/>
                                  <asp:BoundField DataField="Details" HeaderText="Description"/>
                                  <asp:BoundField DataField="Requirements" HeaderText="Requirements"/>
                           
                            </Columns>
                        </asp:GridView>
                   <asp:Panel ID="Panel1" class="form-control-cimas-login"  runat="server"></asp:Panel>
                    </table>
                </div>
                </div>
        </div>
    </div>
</asp:Content>

 