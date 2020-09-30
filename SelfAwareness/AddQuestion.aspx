<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Site.Master" CodeBehind="AddQuestion.aspx.cs" Inherits="SelfAwareness.AddQuestion" %>

<asp:Content ID="bodycontent" ContentPlaceHolderID="body" runat="server">

    <div class="row">
                    <div class="col-sm-12">
                        <div class="card">
                            <div class="card-body">
                                <h4 class="card-title">Add Question</h4>
                                <form id="form1" class="form" runat="server">
                                     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                <ContentTemplate>
                                        <div class="form-group row">
                                        <label for="example-month-input2" class="control-label">Level</label>
                                        <div class="col-lg-12">
                                            <asp:DropDownList ID="DropDownList1" CssClass="custom-select col-12" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="form-group mt-5 row">
                                        <label for="example-text-input" class="control-label">Question Text</label>
                                        <div class="col-10">
                                            <asp:TextBox ID="textBox1" CssClass="form-control" type="text" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                    <h6>Options of Questions</h6>
                                    <div class="form-group mt-5 row">
                                        <label for="example-text-input" class="control-label">Option1 Text</label>
                                        <div class="col-10">
                                            <asp:TextBox ID="option1" CssClass="form-control" type="text" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-10">
                                            <asp:CheckBox ID="CheckBox1" AutoPostBack="true" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Right Answer" CssClass="form-check" runat="server" />
                                        </div>
                                    </div>
                                    <div class="form-group mt-5 row">
                                        <label for="example-text-input" class="control-label">Option2 Text</label>
                                        <div class="col-10">
                                            <asp:TextBox ID="option2" CssClass="form-control" type="text" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-10">
                                            <asp:CheckBox ID="CheckBox2" AutoPostBack="true" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Right Answer" CssClass="form-check" runat="server" />
                                        </div>
                                    </div>
                                                    <div class="form-group mt-5 row">
                                        <label for="example-text-input" class="control-label">Option3 Text</label>
                                        <div class="col-10">
                                            <asp:TextBox ID="option3" CssClass="form-control" type="text" runat="server"></asp:TextBox>
                                        </div>
                                          <div class="col-10">
                                            <asp:CheckBox ID="CheckBox3" AutoPostBack="true" OnCheckedChanged="CheckBox3_CheckedChanged" Text="Right Answer" CssClass="form-check" runat="server" />
                                        </div>
                                    </div>
                                    <div class="form-group mt-5 row">
                                        <label for="example-text-input" class="control-label">Option4 Text</label>
                                        <div class="col-10">
                                            <asp:TextBox ID="option4" CssClass="form-control" type="text" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-10">
                                            <asp:CheckBox ID="CheckBox4" AutoPostBack="true" OnCheckedChanged="CheckBox4_CheckedChanged" Text="Right Answer" CssClass="form-check" runat="server" />
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        
                                        <asp:Button ID="Button1"  CssClass="btn btn-success mr-2" OnClick="Button1_Click" runat="server" Text="Save" />
                                        <asp:Button ID="Button2" CssClass="btn btn-dark" runat="server" Text="Cancel" />
                                    </div>
                                                    </ContentTemplate>
                                         </asp:UpdatePanel>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>

</asp:Content>