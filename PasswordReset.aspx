<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PasswordReset.aspx.cs" Inherits="career_guidance_system.PasswordReset" %>

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
        <div>
            <div class="container">
        <div class="card"  style="width:40rem;">
				<img class="card-img-top" src="images/topcard.jpg" alt="Card image cap"/>
				<div class="body">
                  <div class="card-header">
                        <h5>Reset your password</h5>
                    </div>
                    <action="Login.aspx" method="post">
                    
                    <table class="table">
                    <tr>
                        <td>New Password:<asp:TextBox ID="txtPass" runat="server" class= "form-control-cimas-login" placeholder ="Password" required="required" TextMode="Password" ></asp:TextBox>
                       </td>
                        </tr>
                        <tr> <td>Confirm Password:<asp:TextBox ID="txtConfirm" runat="server" class= "form-control-cimas-login" placeholder ="Confirm Password" required="required" TextMode="Password" ></asp:TextBox>
                       </td></tr>
                        <tr> <td><asp:Button ID="BtnSend" class= "btn btn-success" runat="server" Text="Save New Password" OnClick="BtnSend_Click1" />
                       </td></tr>
         </table>
                        
                <div class="card-footer">
                 <p><small><i>Powered By Farmer the Coder &copy; 2021</i></small></p>
            </div>
                </div>
                </div>
                </div>
        </div>
        <asp:Label ID="Label1" Visible="false" runat="server" ></asp:Label>
         <asp:Label ID="Label2" Visible="false" runat="server" ></asp:Label>
    </form>
</body>
</html>
