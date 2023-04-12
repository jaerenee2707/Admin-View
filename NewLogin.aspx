<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewLogin.aspx.cs" Inherits="WebApplication1.NewLogin" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>

    <link href="AdminPages.css" rel="stylesheet" />
    <link href="navbar.css" rel="stylesheet" />


    <title>Add Logn</title>
</head>
<body>
    <!-- Define the navigation bar at the top of the page -->
    <div class="navbar">
	  <div class="navbar-right">
		<a href="HomePage.aspx" class="nav-item">Home</a>
		<a href="#" class="nav-item">About Us</a>
		<a href="#" class="nav-item">Contact Us</a>
		<a href="PatientLogin.aspx" class="nav-item">Patient Login</a>
		<a href="ProviderLogin.aspx" class="nav-item">Provider Login</a>
	  </div>
	</div>
        <br />
        <br />
        <br />

        <form id="form1" runat="server">
            <div>
                <h1>Add New Login</h1>
                <p>Please fill out where indicated</p>
               <div class="form-group">
                            <br />
                            Select a personnel type <span class="required">*</span></label>&nbsp;
                            <label for="jobtype">Choose Personnel Type:</label>
                            <select name="jobtype" id="jobtype">
                                <option value="doctor">Doctor</option>
                                <option value="nurse">Nurse</option>
                                <option value="staff">Admin</option>
                            </select>
                            <br />
                            <br />
                        </div>
                        <div class="form-container">
                            <form id="form2" runat="server">
                                <fieldset>
                                    <legend>Contact Information</legend>

                                    <div class="form-group">
                                        <label for="username">Username <span class="required">*</span></label>&nbsp;
                                        <asp:TextBox ID="username" runat="server"></asp:TextBox>
                                    </div>

                                    <div class="form-group">
                                        <label for="password">Password</label>&nbsp;
                                        <asp:TextBox ID="password" runat="server"></asp:TextBox>
                                    </div>
                                  <div class="form-group">
                                        <label for="id">ID</label>&nbsp;
                                        <asp:TextBox ID="id" runat="server"></asp:TextBox>
                                    </div>
                        <p style="font-weight: normal;"><span class="required">*</span> Required information</p>
                        <asp:Button ID="clear" runat="server" OnClick="ButtonClear_Click" Text="Clear Entries"/>
                        <asp:Button ID="SUBMIT" runat="server" Text="SUBMIT" OnClick="SUBMIT_Click_AddPer" />
                </div>
                <div>
                    <asp:Button ID="exit" runat="server" OnClick="ButtonExit_Click" Text="Return to Admin Page" />
                </div>
                <script>
                    //Client-side jQuery to cancel form submission if required fields empty
                    $(function () {
                        // Attach event handler to form submit button click
                        $('#<%=SUBMIT.ClientID %>').on('click', function () {
                            // Check if required fields are filled out
                            if ($('#<%=address.ClientID %>').val() === '') {
                                // Display dialog box
                                alert('Please fill out all required fields.');
                                return false; // Cancel form submission
                            }
                        });
                    });
                </script>
            </div>
    </form>
</body>
</html>
