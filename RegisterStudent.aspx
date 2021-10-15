<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterStudent.aspx.cs" Inherits="career_guidance_system.RegisterStudent" %>

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
             <div class="top_bar">
        <div class="left_top">
        <img src="images/logo.jpg"/>
        <h3>Computer Assisted Career Guidance</h3>
              </div>
        </div>
      
        
        </div>
    
        
        <div class="container">
        
        
        <div class="card" >
				<img class="card-img-top" src="../images/topcard.jpg" alt="Card image cap"/>
				<div class="card-body">
                <h5 class="card-title">Student Registration</h5> 
            <action="RegisterParent.aspx" method="post">    
                    <table class="table table-striped">
                      
                    <tr>
                    <td>
                        
                        <label for="fn">Firstname</label>
                        </td>
                    <td><asp:TextBox ID="firstname" class="form-control" required="required" runat="server"></asp:TextBox></td>
                        <td>
                        <label for="sn">Surname</label>
                        </td>
                   <td><asp:TextBox ID="surname" class="form-control" required="required" runat="server"></asp:TextBox></td>
                    </tr>
                     <tr>
                    <td>
                        <label for="email" >Email Address</label>
                        </td>
                  <td><asp:TextBox ID="email" class="form-control" required="required" TextMode="Email" runat="server"></asp:TextBox></td>
                        <td>
                        <label for="idno">Password</label>
                        </td>
                         <td><asp:TextBox ID="password"  class="form-control" TextMode="Password" required="required" runat="server"></asp:TextBox></td>
                         </tr>
              <tr>
                  <td>
                        <label for="Role">Role</label>
                        </td>
                    <td>
                          <asp:DropDownList ID="txtRole" class="form-control" TextMode="text" required="required" runat="server" Height="32px" Width="185px">
                          <asp:ListItem>Please Select</asp:ListItem>
                          <asp:ListItem>Student</asp:ListItem>
                          <asp:ListItem>Parent</asp:ListItem>
                          
                          </asp:DropDownList>
                          </td>
     
                    <td>
                        <label for="idno">ConfirmPassword</label>
                        </td>
                   <td><asp:TextBox ID="ConfirmPassword" class="form-control" TextMode="Password" required="required" runat="server"></asp:TextBox></td>
                    </tr>
                        
                        
                        <tr>
                        <td>
                            <asp:Button class="btn btn-success" ID="Register" runat="server" Text="Register" OnClick="Register_Click" />
                            </td>
                        </tr>
                    </table>
                </div>
                </div>
        </div>
    </form>
</body>

</html>
