<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Code.aspx.cs" Inherits="career_guidance_system.Code" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>CACG</title>
        <link href="css/optical.css" rel="stylesheet" type="text/css"/>
        <link href="css/bootstrap.css" rel="stylesheet" type="text/css"/>
        <link rel="icon" type="image/png" href="images/logo.jpg"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="top_bar">
        <div class="left_top">
        <img src="images/logo.jpg"/>
        <h3>Computer Assisted Career Guidance</h3>
        </div>
        </div>
    <div class="container">
        
        
        <div class="card"  style="width:40rem;">
				<img class="card-img-top" src="images/topcard.jpg" alt="Card image cap"/>
				<div class="body">
                  <div class="card-header">
                        <h5>Check code sent to your email</h5> 
                    </div>
                    <action="ResetCode.aspx" method="post">
                    
                    <table class="table">
                    
                    <tr>
                        <td>Enter Code:<asp:TextBox ID="txtCode" runat="server" class= "form-control-cimas-login" placeholder ="Code" required="required" TextMode="Number"></asp:TextBox>
                       </td>
                        </tr>
                         <tr>
                           <td> <asp:Button ID="BtnSendCode" runat="server" Text="Verify Code" class="btn btn-success" OnClick="BtnSendCode_Click"  />
                        
                       </td>
                        </tr>

                   
                    </table>
                        <asp:Label ID="Label1" Visible="false" runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="Label2" Visible="false" runat="server" Text="Label"></asp:Label>
                <div class="card-footer">
                 <p><small><i><b>Powered By Farmer the Coder &copy; 2021</b></i></small></p>
            </div>
                </div>
                </div>
        
        
        </div>
        <div>
        </div>
    </form>
</body>
</html>
