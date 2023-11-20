<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Countries.aspx.cs" Inherits="TourManagementSystem.Pages.Countries" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="row mt-3">
        <div class="col-12">
            <asp:Button Text="New" ID="btnShowModal" CssClass="btn btn-primary" OnClick="btnShowModal_Click" runat="server" />

        </div>
    </div>
    <div class="row mt-3">
        <div class="col-12">
            <table class="table table-bordered table-striped table-hover border-dark">
                <thead>
                    <tr>
                        <th colspan="2"></th>
                        <th>ID</th>
                        <th>Name</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater runat="server" ID="rptData" OnItemCommand="rptData_ItemCommand">
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <asp:LinkButton runat="server" Text=" " CommandArgument='<%# Eval("ID") %>' CommandName="Edit">
                                        <i class="fa-solid fa-edit text-info"></i>
                                    </asp:LinkButton>
                                </td>
                                <td>
                                    <asp:LinkButton runat="server" Text=" " CommandArgument='<%# Eval("ID") %>' CommandName="Delete">
                                        <i class="fa-solid fa-trash-alt text-info"></i>
                                    </asp:LinkButton>
                                </td>
                                <td>
                                    <asp:Label Text='<%# Eval("ID") %>' runat="server" />
                                </td>
                                <td>
                                    <asp:Label Text='<%# Eval("Name") %>' runat="server" />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
    <div runat="server" class="modal fade show" id="divCountryModal" style="display: none;">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
                </div>
                <div class="modal-body">
                    <asp:HiddenField runat="server" ID="hfRowId" />
                    <div class="row">
                        <div class="col-6">
                            <asp:Label Text="Name" runat="server" />
                        </div>
                        <div class="col-6">
                            <asp:TextBox runat="server" ID="txtName" CssClass="form-control" />
                        </div>
                    </div>

                </div>
                <div class="modal-footer">
                    <asp:Button Text="Save" ID="btnSave" CssClass="btn btn-primary" runat="server" OnClick="btnSave_Click" />
                    <asp:Button Text="Close" ID="btnClose" CssClass="btn btn-primary" runat="server" OnClick="btnClose_Click" />

                </div>
            </div>
        </div>
    </div>

    <script>
        function showModal() {
            document.getElementById("btnShowModal").click();
        }
    </script>
</asp:Content>
