<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login1.aspx.cs" Inherits="career_guidance_system.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>CACG</title>
        <link href="css/optical.css" rel="stylesheet" type="text/css"/>
        <link href="css/bootstrap.css" rel="stylesheet" type="text/css"/>
        <!--link rel="icon" type="image/png" href="images/logo.jpg"/-->
</head>
<body>
    <form id="form1" runat="server">
        <div class="top_bar">
        <div class="left_top">
        <img src="images/logo.jpg"/>
        <h3>Computer Assisted Career Guidance</h3>
        </div>
            <asp:Label ID="Label1" runat="server" Visible="false"></asp:Label>
      
            <asp:Label ID="Label2" runat="server" Visible="false"></asp:Label>
        </div>
    <div class="container">
        
        
        <div class="card"  style="width:40rem;">
				<img class="card-img-top" src="images/topcard.jpg" alt="Card image cap"/>
				<div class="body">
                  <div class="card-header">
                        <h5>Login</h5> 
                    </div>
                    <action="Login.aspx" method="post">
                    
                    <table class="table">
                    
                    <tr>
                        <td>Email Address:<asp:TextBox ID="txtEmail" runat="server" class= "form-control-cimas-login" placeholder ="Email Address" required="required" TextMode="Email" ></asp:TextBox>
                       </td>
                        </tr>
                    <tr>
                        <td>Password:<asp:TextBox ID="txtPass" runat="server" class= "form-control-cimas-login" placeholder ="Password" required="required" TextMode="Password" ></asp:TextBox>
                          
                          
                            
                       </td>
                        </tr>

                         <tr>
                      
                      
                           <td> <asp:Button ID="BtnLogin" runat="server" Text="Login" class="btn btn-success" OnClick="BtnLogin_Click" />
                        
                       </td>
                        </tr>

                    <tr>
                        <td><a href="RegisterStudent.aspx">Sign Up?</a></td><td><a href="ResetCode.aspx">Reset Password</a></td>
                        </tr>
                    </table>
                    
                <div class="card-footer">
                 <p><small><i> <b>Powered By Farmer the Coder &copy; 2021 </b></i></small></p>
            </div>
                </div>
                </div>
      
        
        </div>
        <div>
        </div>
    </form>
</body>
</html>
