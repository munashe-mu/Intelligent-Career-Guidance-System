<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CareerPaths.aspx.cs" Inherits="career_guidance_system.CareerPaths" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>CACG</title>
        <link href="css/optical.css" rel="stylesheet" type="text/css"/>
        <link href="css/bootstrap.css" rel="stylesheet" type="text/css"/>
        <link rel="icon" type="image/png" href="images/logo.jpg"/>

    <script type="text/javascript" src="https://ajax.googeapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js"></script>
    <link href="https://cdn.datatables.net/1.10.20/css/jquery.dataTables.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript">
        $(document).ready(function () {
            $('#<%= GridView1.ClientID%>').prepend($("<thead></thead>").append($(this).find("tr:first"))).DataTable();
        });
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
             <div class="top_bar">
        <div class="left_top">
        <img src="images/logo.jpg"/>
        <h3>Intelligent Career Guidance</h3>
        </div>
        
        <div class="right_top">
        <ul>
            <li><a href="alevel_homepage.aspx">Home</a></li>
            <li><a href="vehicle">Careers</a></li>
            <li><asp:LinkButton ID="IQtest" runat="server">IQ Test</asp:LinkButton></li> 
           <li><a href="student_results.aspx">Add Results</a></li> 
            <li><asp:LinkButton ID="BtnLogout" runat="server"> </asp:LinkButton></li>
            </ul>
        </div>
        </div>
            
</div>
     <div class="container">
         <div class="right_top">
      
        
        </div>
        </div>

        <div class="card" >

				<img class="card-img-top" src="images/topcard.jpg" alt="Card image cap"/>
				<div class="card-body">
                   <h5 class="card-title">Some of the Career Paths 
      
        
               <asp:TextBox ID="txtSearch" class="form-control" runat="server" ></asp:TextBox>
        
      
                    </h5> 
                    <table class="auto-style1">

      <asp:GridView ID="GridView1" AutoGenerateColumns="false" CssClass="table" runat="server">
          <Columns>
              <asp:BoundField DataField="Career_Path" HeaderText="Career" />
               <asp:BoundField DataField="Description" HeaderText="Career Description" />
               <asp:BoundField DataField="Requirements" HeaderText="Requirements" />
          </Columns>
       </asp:GridView>
                   
                    </table>
                    </div></div>  
        <div>
        </div>
    </form>
</body>
</html>
