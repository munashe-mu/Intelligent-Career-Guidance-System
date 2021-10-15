<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetCode.aspx.cs" Inherits="career_guidance_system.ResetCode" %>

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
                        <h5>Reset your password</h5> 
                    </div>
                    <action="ResetCode.aspx" method="post">
                    
                    <table class="table">
                    
                    <tr>
                        <td>Email Address:<asp:TextBox ID="txtEmail" runat="server" class= "form-control-cimas-login" placeholder ="Email Address" required="required" TextMode="Email" ></asp:TextBox>
                       </td>
                        </tr>
                         <tr>
                           <td> <asp:Button ID="BtnSendCode" runat="server" Text="Send Reset Code" class="btn btn-success" OnClick="BtnSendCode_Click"  />
                        
                       </td>
                        </tr>

                   
                    </table>
                    
                <div class="card-footer">
                 <p><small><i><b>Powered By Farmer the Coder &copy; 2021</b></i></small></p>
            </div>
                </div>
                </div>
        
        
        </div>
        <asp:Label ID="Label1" runat="server" Visible="false" Text="Label"></asp:Label>
        <div>
        </div>
    </form>
</body>
</html>
