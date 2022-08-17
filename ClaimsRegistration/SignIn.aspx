<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="ClaimsRegistration.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i&amp;display=swap" rel="stylesheet" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <link href="Content/Fonts/all.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="Content/css/Login.css" />
</head>
<body class="form-login-body">

    <div>
        <div class="container">
            <div class="row">
                <div class="col-lg-10 mx-auto login-desk">
                    <div class="row">
                        <div class="col-md-7 detail-box">
                            <img class="logo" src="Content/Img/cake.jpeg" alt="" />
                            <div class="detailsh">
                                <h3>Register here</h3>

                            </div>
                        </div>
                        <div class="col-md-5 loginform">
                            <form class="form-login" runat="server" method="post">
                                <h4>Welcome Back</h4>
                                <p>Signin to your Account</p>
                                <div class="login-det">
                                    <div class="form-row">
                                        <label for="">Username</label>
                                        <div class="input-group mb-3">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text" id="basic-addon1">
                                                    <i class="far fa-user"></i>
                                                </span>
                                            </div>
                                            <asp:TextBox ID="LoginTxtLn1" runat="server" CssClass="form-control" placeholder="Enter Username"></asp:TextBox>
                                            <%--<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Enter Username"></asp:TextBox>--%>
                                        </div>
                                    </div>
                                    <div class="form-row">
                                        <label for="">Password</label>
                                        <div class="input-group mb-3">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text" id="basicaddon1">
                                                    <i class="fas fa-lock"></i>
                                                </span>
                                            </div>
                                            <asp:TextBox ID="LoginTxtPw" runat="server" TextMode="Password" CssClass="form-control" placeholder="Enter Password"></asp:TextBox>
                                            <%--<asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" type="password" placeholder="Enter Password"></asp:TextBox>--%>
                                        </div>
                                    </div>

                                    <p class="forget"><a href="#">Forget Password?</a></p>

                                    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-sm btn-danger" OnClick="btnLogin_Click" />
                                </div>
                            </form>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</body>
</html>
