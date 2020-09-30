<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Site.Master" CodeBehind="Levels.aspx.cs" Inherits="SelfAwareness.Levels" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="body" runat="server">
    <div class="row">
        <div class="col-12">
                   <div class="card">
                            <div class="card-body">
                                <h4 class="card-title">List of All Levels</h4>
                               <div class="table-responsive m-t-40">
                                   <table id="example23" class="display nowrap table table-hover table-striped table-bordered" cellspacing="0" width="100%">
                                        <thead>
                                            <tr>
                                                <th>Level ID</th>
                                                <th>Level Name</th>
                                            </tr>
                                        </thead>
                                        <tfoot>
                                            <tr>
                                                <th>Level ID</th>
                                                <th>Level Name</th>
                                            </tr>
                                        </tfoot>
                                        <tbody>
                                            <asp:Repeater ID="Repeater1" runat="server">
                                                <ItemTemplate>
                                            <tr>
                                                <td><%#Eval("Quize_Id") %></td>
                                                <td><%#Eval("Title") %></td>
                                            </tr>
                                                    </ItemTemplate>
                                            </asp:Repeater>
                                        </tbody>
                                    </table>

                                    </div>
                                   
                                   
                                   
                                </div>
                            </div>
                        </div>
                    </div>

     
  


</asp:Content>
