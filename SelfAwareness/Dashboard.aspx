<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Site.Master" CodeBehind="Dashboard.aspx.cs" Inherits="FundingMaktab.Dashboard" %>

<asp:Content ID="bodycontent" ContentPlaceHolderID="body" runat="server">
      <div class="container-fluid">
                <!-- ============================================================== -->
                <!-- Bread crumb and right sidebar toggle -->
                <!-- ============================================================== -->
                <div class="row page-titles">
                    <div class="col-md-5 align-self-center">
                        <h4 class="text-themecolor">Career Guide Dashboard</h4>
                    </div>
                    <div class="col-md-7 align-self-center text-right">
                       
                    </div>
                </div>
                <!-- ============================================================== -->
                <!-- End Bread crumb and right sidebar toggle -->
                <!-- ============================================================== -->
                <!-- ============================================================== -->
                <!-- Info box -->
                <!-- ============================================================== -->
                <!--.row -->
                <div class="row">
                    <div class="col-lg-3 col-sm-6 col-xs-12">
                        <div class="card">
                            <div class="card-body">
                                <h5 class="card-title text-uppercase">Total Questions</h5>
                                <div class="d-flex align-items-center no-block m-t-20 m-b-10">
                                    <h1><i class="ti-home text-info"></i></h1>
                                    <div class="ml-auto">
                                        <h1 class="text-muted">
                                            <asp:Label ID="Label1" runat="server" Text=""></asp:Label></h1>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3 col-sm-6 col-xs-12">
                        <div class="card">
                            <div class="card-body">
                                <h5 class="card-title text-uppercase">Total Levels</h5>
                                <div class="d-flex align-items-center no-block m-t-20 m-b-10">
                                    <h1><i class="icon-tag text-purple"></i></h1>
                                    <div class="ml-auto">
                                        <h1 class="text-muted">
                                            <asp:Label ID="Label4" runat="server" Text=""></asp:Label></h1>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-3 col-sm-6 col-xs-12">
                        <div class="card">
                            <div class="card-body">
                                <h5 class="card-title text-uppercase">Total Users</h5>
                                <div class="d-flex align-items-center no-block m-t-20 m-b-10">
                                    <h1><i class="icon-basket text-danger"></i></h1>
                                    <div class="ml-auto">
                                        <h1 class="text-muted"><asp:Label ID="Label3" runat="server" Text=""></asp:Label></h1>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    
                </div>
              <%--  <div class="row">
                    <div class="col-lg-8">
                        <div class="card">
                        </div>
                    </div>
                    <div class="col-lg-4">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="card m-b-15">
                                    <div class="card-body">
                                        <h5 class="card-title">Total InHand Amount of Custodians</h5>
                                        <div class="row">
                                            <div class="col-6 m-t-30">
                                                <h1 class="text-info">Rs <asp:Label ID="Label5" runat="server" Text=""></asp:Label></h1>
                                               <%-- <p class="text-muted">APRIL 2017</p> <b>(150 Sales)</b> </div>
                                            <div class="col-6">
                                                <div id="sparkline2dash" class="text-right"></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="card bg-purple m-b-15">
                                    <div class="card-body">
                                        <h5 class="text-white card-title">Total Top User</h5>
                                        <div class="row">
                                            <div class="col-6 m-t-30">
                                                <h1 class="text-yellow">
                                                    <asp:Label ID="Label6" runat="server" Text=""></asp:Label></h1>
                                                <p class="text-white">Marks</p> <b class="text-white">
                                                    <asp:Label ID="Label7" runat="server" Text=""></asp:Label></b> </div>
                                            <div class="col-md-6 col-sm-6 col-6">
                                                <div id="sales1" class="text-right"></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>--%>
            </div>

     

</asp:Content>