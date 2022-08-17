<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="ClaimsRegistration.Transaction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid">

        <div class="header">
            <h1 class="header-title">Welcome back 
                <asp:Label ID="lblUserName" runat="server" ForeColor="#ffffff"></asp:Label></b>
            </h1>
            <nav aria-label="breadcrumb">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="Dashboard.aspx">Home</a></li>
                    <li class="breadcrumb-item active" aria-current="page">Transaction</li>
                </ol>
            </nav>
        </div>
        <div class="row">
            <div class="col-12 col-xl-12">
                <div class="card">
                    <div class="card-header">
                        <h5 class="card-title">Search Claims</h5>
                        <h6 class="card-subtitle text-muted">Please use card no, claims no or policy no to search. </h6>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="mb-3 col-md-3">
                                <asp:TextBox ID="txtPlyNumber" runat="server" CssClass="form-control" placeholder="PolicyNumber"></asp:TextBox>
                            </div>
                            <div class="mb-3 col-md-3">
                                <asp:TextBox ID="txtCliNumber" runat="server" CssClass="form-control" placeholder="ClaimsNumber"></asp:TextBox>
                            </div>
                            <div class="mb-3 col-md-3">
                                <asp:TextBox ID="txtCrdNumber" runat="server" CssClass="form-control" placeholder="CardNumber"></asp:TextBox>
                            </div>
                            <div class="mb-3 col-md-1">
                                <asp:Button ID="ButSearch" runat="server" CssClass="btn btn-primary" Text="Search" OnClick="ButSearch_Click" />
                            </div>
                            <div class="mb-3 col-md-1">
                                <asp:Button ID="ButClear" runat="server" CssClass="btn btn-primary" Text="Clear " OnClick="ButClear_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-12">
                <div class="card">
                    <div class="card-header d-flex justify-content-between">
                        <div>
                            <h5 class="card-title">List of Claims Registered</h5>
                            <h6 class="card-subtitle text-muted">Total number of claims registered are tabulated below.</h6>
                        </div>

   

                         <div class="card-header d-flex justify-content-between">
                        <div>
                            <h5 class="card-title">Bulk Upload</h5>


                            
                       
                             
                        <div class="input-group">
                            <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" />
                            <asp:Button ID="Button1" runat="server" CssClass="btn btn-outline-secondary" Text="BulkUpload" OnClick="UploadBulkData_Click" />
                        </div>

                    </div>

                    </div>

                        <div>
                            <asp:Button ID="AddPolicy" runat="server" CssClass="btn btn-primary btn-sm mx-3" Text="Add New Claim" OnClick="AddPolicy_Click" />
                            <asp:Button ID="Bulkupload" runat="server" CssClass="btn btn-primary btn-sm" Text="Export To Excel" OnClick="Bulkupload_Click" />
                        </div>
                    </div>
                    <div class="card-body">
                        <div class="table-responsive">
                            <asp:GridView ID="TransGrid" runat="server" CssClass="table table-bordered" Width="100%" DataKeyNames="CL_ClaimsNumber" AutoGenerateColumns="false" Visible="true" OnRowCommand="TransGrid_RowCommand" OnRowEditing="TransGrid_RowEditing" OnRowDeleting="TransGrid_RowDeleting1" OnSelectedIndexChanged="TransGrid_SelectedIndexChanged">
                                <Columns>
                                    <asp:BoundField DataField="CL_Month" HeaderText="Processing Month" />
                                    <asp:BoundField DataField="CL_Tpa" HeaderText="TPA" />
                                    <asp:BoundField DataField="CL_PolicyNumber" HeaderText="Policy No" />
                                    <asp:BoundField DataField="CL_PolicyHolder" HeaderText="Holder Name" />
                                    <asp:BoundField DataField="CL_Source" HeaderText="Source" />
                                    <asp:BoundField DataField="CL_CardNumber" HeaderText="Card No" />
                                    <asp:BoundField DataField="CL_StaffNumber" HeaderText="Staff No" />
                                    <asp:BoundField DataField="CL_ClaimsNumber" HeaderText="Claims No" />
                                    <asp:BoundField DataField="CL_RegisteredBy" HeaderText="Registered By" />
                                    <asp:BoundField DataField="CL_PrincipleName" HeaderText="Principle Name" />
                                    <asp:BoundField DataField="CL_ClaimantName" HeaderText="Claimant Name" />
                                    <asp:TemplateField HeaderText="Actions"  ItemStyle-Width="8%">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" CausesValidation="false" CommandArgument='<%#Eval("CL_ClaimsNumber")%>' CommandName="Edit"><i class="align-middle fas fa-fw fa-pen"></i></asp:LinkButton>
                                            <asp:LinkButton ID="lnkView" runat="server" CausesValidation="false" CommandArgument='<%#Eval("CL_ClaimsNumber") %>' CommandName="View"><i class="align-middle fas fa-fw fa-eye"></i></asp:LinkButton>
                                            <asp:LinkButton ID="lnkdelete" runat="server" CausesValidation="false" CommandArgument='<%#Eval("CL_ClaimsNumber") %>' CommandName="Delete"><i class="align-middle fas fa-fw fa-trash "></i></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <%--End of Transaction Page Code--%>
</asp:Content>
