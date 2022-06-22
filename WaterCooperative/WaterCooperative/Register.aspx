<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WaterCooperative.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>SPWC - Register</title>

    <!-- Custom fonts for this template-->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <link
        href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"
        rel="stylesheet">

    <!-- Custom styles for this template-->
    <link href="css/sb-admin-2.min.css" rel="stylesheet">
</head>
<body class="bg-gradient-primary">
    <form id="form1" runat="server">
     <div class="container">

        <div class="card o-hidden border-0 shadow-lg my-5">
            <div class="card-body p-0">
                <!-- Nested Row within Card Body -->
                <div class="row">
                    <div class="col-lg-5 d-none d-lg-block bg-register-image"></div>
                    <div class="col-lg-7">
                        <div class="p-5">
                            <div class="text-center">
                                <h1 class="h4 text-gray-900 mb-4">Create an Account!</h1>
                            </div>

                            <asp:Label Text="" ID="lblError" ForeColor="Red" Font-Bold="true" runat="server" />

                            <div class="user">
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">

                                        <asp:TextBox runat="server" ID="textFirstName" CssClass="form-control form-control-user" placeholder="First Name" />
                                     
                                    </div>
                                    <div class="col-sm-6">

                                        <asp:TextBox runat="server" ID="textLastName" CssClass="form-control form-control-user" placeholder="Last Name" />
                                       
                                    </div>
                                </div>
                                <div class="form-group">

                                    <asp:TextBox runat="server" ID="textUsername" CssClass="form-control form-control-user" placeholder="Username" />

                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">

                                        <asp:TextBox runat="server" ID="textPassword" TextMode="Password" CssClass="form-control form-control-user" placeholder="Password" />

                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox runat="server" ID="textRepeatPassword" TextMode="Password" CssClass="form-control form-control-user" placeholder="Repeat Password" />
                                    </div>
                                </div>

                                <asp:Button Text="Register Account" ID="buttonRegister" CssClass="btn btn-primary btn-user btn-block" runat="server" OnClick="buttonRegister_Click" />
                               
                            </div>
                            <hr>
                            <div class="text-center">
                                <a class="small" href="forgot-password.html">Forgot Password?</a>
                            </div>
                            <div class="text-center">
                                <a class="small" href="Login.aspx">Already have an account? Login!</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>

    <!-- Bootstrap core JavaScript-->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

    <!-- Custom scripts for all pages-->
    <script src="js/sb-admin-2.min.js"></script>

    </form>
</body>
</html>
