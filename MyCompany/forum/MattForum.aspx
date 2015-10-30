<%@ Page Title="Listen First Forums" Language="C#" AutoEventWireup="true" CodeBehind="MattForum.aspx.cs" Inherits="MyCompany.forum.MattForum" %>
<%@ Register TagPrefix="YAF" Assembly="YAF" Namespace="YAF" %>
<%@ Register TagPrefix="YAF" TagName="ForumActiveDiscussion" Src="~/forum/controls/ForumActiveDiscussion.ascx" %>



<!DOCTYPE html>
<html lang="en">
<head>
    <title>News</title>
    <meta charset="utf-8">
    <meta name="format-detection" content="telephone=no"/>
    <link rel="icon" href="images/favicon.ico" type="image/x-icon">
    <link href="c/forum/Styles/Site.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="/site/css/grid.css">
    <link rel="stylesheet" href="/site/css/style.css">
    <script src="/site/js/jquery.js"></script>
    <script src="/site/js/jquery-migrate-1.2.1.js"></script>
    <script src="/site/js/jquery.equalheights.js"></script>
    <!--[if (gt IE 9)|!(IE)]><!-->
    <script src="/site/js/jquery.mobile.customized.min.js"></script>
    <script src="/site/js/wow/wow.js"></script>
    <script>
        $(document).ready(function () {
            if ($('html').hasClass('desktop')) {
                new WOW().init();
                $('#stuck_container').TMStickUp({
                })
            }
        });
    </script>
    <!--<![endif]-->
    <!--[if lt IE 9]>
    <div style=' clear: both; text-align:center; position: relative; background: #fff;'>
        <a href="http://windows.microsoft.com/en-US/internet-explorer/products/ie/home?ocid=ie6_countdown_bannercode">
            <img src="http://storage.ie6countdown.com/assets/100/images/banners/warning_bar_0000_us.jpg" border="0"
                 height="42" width="820"
                 alt="You are using an outdated browser. For a faster, safer browsing experience, upgrade for free today."/>
        </a>
    </div>

    <script src="js/html5shiv.js"></script>
    <link rel="stylesheet" type="text/css" media="screen" href="css/ie.css">
    <![endif]-->
</head>

<body>
    <form name="MattForum" runat="server">
        <asp:ScriptManager runat="server" id="YafScriptManager" EnablePartialRendering="true"></asp:ScriptManager>
<div class="page">
<!--========================================================
                          HEADER
=========================================================-->
<header id="header">
    <div id="stuck_container">
        <div class="container">
            <div class="row">
                <div class="grid_12">
                    <div class="brand">
                        <h1>
                            <a href="./">
                                <span class="text_1">
                                    <span class="color_6">S</span>
                                    <span class="color_2">o</span>
                                    <span class="color_5">f</span>
                                    <span class="color_1">t</span>
                                </span>
                                <span class="text_2 color_6">Ware</span>
                            </a>
                        </h1>
                    </div>

                    <nav>
                        <ul class="sf-menu">
                            <li><a href="./">Home</a></li>
                            <li><a href="index-1.html">About</a></li>
                            <li>
                                <a class="fa fa-caret-down" href="index-2.html">Products</a>
                                <ul>
                                    <li><a href="#">Lorem ipsum dolor</a></li>
                                    <li><a href="#">Sit amet conse</a></li>
                                    <li>
                                        <a class="fa fa-caret-down" href="#">Ctetur adipisicing </a>
                                        <ul>
                                            <li><a href="#">Elit sed do </a></li>
                                            <li><a href="#">Eiusmod tempor </a></li>
                                            <li><a href="#">Incididunt ut</a></li>
                                        </ul>
                                    </li>
                                </ul>
                            </li>
                            <li class="current"><a href="index-3.html">News</a></li>
                            <li><a href="index-4.html">Contacts</a></li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>
</header>
<!--========================================================
                          CONTENT
=========================================================-->
<section id="content" style-"background-color: white;">
    <div class="bg_1">
        <div class="container">
            <div class="wrapper_2">zzzzzz
                <YAF:Forum runat="server" ID="testForum" BoardID="1"  /><br /><br />
            </div>
        </div>
    </div>
</section>

<!--========================================================
                          FOOTER
=========================================================-->
<footer id="footer">
    <div class="bg_1 wrapper_3">
        <div class="container">
            <div class="row">
                <div class="grid_3 wow fadeInLeft" data-wow-delay="0.2s">
                    <h2 class="header_5 text_3 color_6">Company</h2>
                    <ul class="list">
                        <li><a href="#">Lorem ipsum dolor </a></li>
                        <li><a href="#">Ctetur adipisicing</a></li>
                        <li><a href="#">Do eiusmod tempor</a></li>
                        <li><a href="#">Incididunt ut labore</a></li>
                        <li><a href="#">Et dolore magna</a></li>
                        <li><a href="#">Minim veniam</a></li>
                    </ul>
                </div>
                <div class="grid_3 wow fadeInLeft" data-wow-delay="0.4s">
                    <h2 class="header_5 text_3 color_6">Products</h2>
                    <ul class="list">
                        <li><a href="#">Ctetur adipisicing </a></li>
                        <li><a href="#">Do eiusmod tempor</a></li>
                        <li><a href="#">Incididunt ut labore</a></li>
                        <li><a href="#">Et dolore magna </a></li>
                        <li><a href="#">Minim veniam</a></li>
                        <li><a href="#">Quis nostrud set </a></li>
                        <li><a href="#">Ullamco laboris nis</a></li>
                    </ul>
                </div>
                <div class="grid_3 wow fadeInRight" data-wow-delay="0.6s">
                    <h2 class="header_5 text_3 color_6">Partnerships</h2>
                    <ul class="list">
                        <li><a href="#">Do eiusmod tempor</a></li>
                        <li><a href="#">Incididunt ut labore </a></li>
                        <li><a href="#">Et dolore magna</a></li>
                        <li><a href="#">Minim veniam</a></li>
                        <li><a href="#">Quis nostrud set</a></li>
                        <li><a href="#">Ullamco laboris nis</a></li>
                    </ul>
                </div>
                <div class="grid_3 wow fadeInRight" data-wow-delay="0.8s">
                    <h2 class="header_5 text_3 color_6">Follow Us</h2>
                    <ul class="social-list">
                        <li><a class="fa fa-twitter" href="#"></a></li>
                        <li><a class="fa fa-facebook" href="#"></a></li>
                        <li><a class="fa fa-rss" href="#"></a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="grid_12">
                <div class="info text_11">
                    <a href="./">Software©</a> 2014. <a href="index-5.html">Privacy Policy</a>
                </div>
            </div>
        </div>
    </div>
</footer>
</div>

<script src="js/script.js"></script>
        </form>
</body>
</html>