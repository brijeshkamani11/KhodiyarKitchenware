<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="KhodiyarKitchenware.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login For Admin</title>
    <link href="Content/css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" href="Content/css/login.css" />
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <div class="card">
                    <form action="/Admin/Profile/Profile.aspx" class="box">
                        <h1>Login</h1>
                        <p class="text-muted">Please enter your Admin Id and password!</p>
                        <input type="text" name="" placeholder="Username">
                        <input type="password" name="" placeholder="Password">
                        <a class="forgot text-muted" href="#">Forgot password?</a>
                        <div class="row">
                            <input type="submit" name="" value="Login" href="/Admin/Profile/Profile.aspx" />
                            <input action="action" onclick="cancle();" type="submit" value="Cancel" />
                            <script type="text/javascript">
                                function cancle() {
                                    if (document.referrer == "") {
                                        location.href = "/Home.aspx";
                                    } else {
                                        history.back();
                                        //window.history.go(-1); return false;
                                    }


                                }
                            </script>
                        </div>
                        <div class="col-md-12">
                            <!--ul class="social-network social-circle">
                            <li><a href="#" class="icoFacebook" title="Facebook"><i class="fab fa-facebook-f"></i></a></li>
                            <li><a href="#" class="icoTwitter" title="Twitter"><i class="fab fa-twitter"></i></a></li>
                            <li><a href="#" class="icoGoogle" title="Google +"><i class="fab fa-google-plus"></i></a></li>
                        </ul-->
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
