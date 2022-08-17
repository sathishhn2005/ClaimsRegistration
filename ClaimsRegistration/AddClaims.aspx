<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddClaims.aspx.cs" Inherits="ClaimsRegistration.AddClaims" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">

        <div class="header">
            <h1 class="header-title">Welcome back 
             <asp:Label ID="lblUserName" runat="server" ForeColor="#ffffff"></asp:Label></b>
            </h1>
           
            <nav aria-label="breadcrumb">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="Dashboard.aspx">Home</a></li>
                    <li class="breadcrumb-item active" aria-current="page">Add New Claim</li>
                </ol>
            </nav>
        </div>
        <div class="row">
            <div class="col-12 col-xl-12">
                <div class="card">
                    <div class="card-header">
                        
                        <asp:Label ID="Label1" runat="server">Add New Claim</asp:Label>
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                        <asp:Label ID="Label3" runat="server">Edit Claim</asp:Label>
                        
                    </div>
                    <div class="card-body">
                        <div class="row">

                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblProcDate" runat="server">Processing Date</asp:Label>
                                <asp:TextBox ID="txtProcDate" Type="date" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblTpa" runat="server">TPA</asp:Label>
                                <asp:TextBox ID="txtTpa" runat="server" CssClass="form-control"></asp:TextBox>

                            </div>

                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblPolicyNumber" runat="server">PolicyNumber</asp:Label>
                                <asp:TextBox ID="txtPolNo" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>




                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblPolHol" runat="server">Policy Holder</asp:Label>
                                <asp:TextBox ID="txtPolHol" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>

                        </div>


                        <div class="row">


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblSrc" runat="server">Source</asp:Label>
                                <asp:TextBox ID="txtSrc" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblCrdNo" runat="server">CardNumber</asp:Label>
                                <asp:TextBox ID="txtCrdNo" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblStfNo" runat="server">StaffNo</asp:Label>
                                <asp:TextBox ID="txtStfNo" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblClaimsNo" runat="server">ClaimNumber</asp:Label>
                                <asp:TextBox ID="txtClaimsNo" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>


                        <div class="row">

                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblRegBy" runat="server">RegisteredBy</asp:Label>
                                <asp:TextBox ID="txtRegBy" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>

                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblPrinName" runat="server">PrincipleName</asp:Label>
                                <asp:TextBox ID="txtPrinName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblClaimtName" runat="server">ClaimantName</asp:Label>
                                <asp:TextBox ID="txtClaimtName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblDiag" runat="server">Diagnosis</asp:Label>
                                <asp:TextBox ID="txtDiag" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="row">

                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblHospName" runat="server">HospitalName</asp:Label>
                                <asp:TextBox ID="txtHospName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblClaimAmt" runat="server">ClaimedAmount</asp:Label>
                                <asp:TextBox ID="txtClaimAmt" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblAppAmt" runat="server">ApprovedAmount</asp:Label>
                                <asp:TextBox ID="txtAppAmt" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblRej" runat="server">Rejection</asp:Label>
                                <asp:TextBox ID="txtRej" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="row">

                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblTreatDate" runat="server">TreatmentDate</asp:Label>
                                <asp:TextBox ID="txtTreatDate" Type="date" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblDateRecFromCli" runat="server">Date Recived from Client</asp:Label>
                                <asp:TextBox ID="txtDateRecFromCli" Type="date" runat="server" class="form-control" />
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">

                                <asp:Label ID="lblOrigDocRec" runat="server">Original Docs Recived from Client</asp:Label>
                                <asp:TextBox ID="txtOrigDocRec" Type="date" runat="server" class="form-control" />
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblDateSentToTPA" runat="server">Processing Date</asp:Label>
                                <asp:TextBox ID="txtDateSentToTPA" Type="date" runat="server" class="form-control" />
                            </div>
                        </div>


                        <div class="row">

                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblQuertSentToTPA" runat="server">Text Query Sent To TPA</asp:Label>
                                <asp:TextBox ID="txtQuertSentToTPA" Type="date" runat="server" class="form-control" />
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblFinalDocRec" runat="server">Final Documnet Received</asp:Label>
                                <asp:TextBox ID="txtFinalDocRec" Type="date" runat="server" class="form-control" />
                            </div>



                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblRefNo" runat="server">Refenrece No</asp:Label>
                                <asp:TextBox ID="txtRefNo" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>



                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblDateRevTpa" runat="server">Date received from TPA</asp:Label>
                                <asp:TextBox ID="txtDateRevTpa" Type="Date" runat="server" class="form-control" />
                            </div>
                        </div>

                        <div class="row">

                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblTpaBatchNo" runat="server">TPA Batch No</asp:Label>
                                <asp:TextBox ID="txtTpaBatchNo" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblCurrentStatus" runat="server">Status</asp:Label>
                                <asp:TextBox ID="txtCurrentStatus" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblRemarks" runat="server">Remarks</asp:Label>
                                <asp:TextBox ID="txtRemarks" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">

                                <asp:Label ID="lblProceDate" runat="server">Processing date</asp:Label>
                                <asp:TextBox ID="txtProceDate" Type="date" runat="server" CssClass="form-control" />
                            </div>
                        </div>


                        <div class="row">

                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lbltxtRejUpdatToClientOn" runat="server">Rejection update to client on</asp:Label>
                                <asp:TextBox ID="txtRejUpdatToClientOn" Type="date" runat="server" CssClass="form-control" />
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblCreditNotNo" runat="server">Credit Note Number</asp:Label>
                                <asp:TextBox ID="txtCreditNotNo" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblRIDebitNoteNo" runat="server">RI Debit Note Number</asp:Label>
                                <asp:TextBox ID="txtRIDebitNoteNo" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblDateSentToAcc" runat="server">Date Sent To Accounts</asp:Label>
                                <asp:TextBox ID="txtDateSentToAcc" Type="date" runat="server" class="form-control" />
                            </div>
                        </div>

                        <div class="row">

                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblDateRecToAcc" runat="server">Date Receied From Accounts</asp:Label>
                                <asp:TextBox ID="txtDateRecToAcc" Type="date" runat="server" class="form-control" />
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblBankTrans" runat="server">Bank Transfer</asp:Label>
                                <asp:TextBox ID="txtBnkTrans" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblChkNo" runat="server">Cheque No</asp:Label>
                                <asp:TextBox ID="txtChkNo" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblChkDate" runat="server">Cheque Date</asp:Label>
                                <asp:TextBox ID="txtChkDate" Type="date" runat="server" class="form-control" />
                            </div>
                        </div>

                        <div class="row">

                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblDateOfDisp" runat="server">Date Of Displacement</asp:Label>
                                <asp:TextBox ID="txtDateOfDisp" Type="date" runat="server" class="form-control" />
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblBnkName" runat="server">Bank Name</asp:Label>
                                <asp:TextBox ID="txtBnkName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblAccno" runat="server">Account Number</asp:Label>
                                <asp:TextBox ID="txtAccno" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblbefnam" runat="server">Beneficiary Name</asp:Label>
                                <asp:TextBox ID="txtbefnam" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">

                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblAcno" runat="server">Account No</asp:Label>
                                <asp:TextBox ID="txtAcno" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblSubAcNo" runat="server">Sub Account No</asp:Label>
                                <asp:TextBox ID="txtSubAcNo" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblTAT" runat="server">TAT</asp:Label>
                                <asp:TextBox ID="txtTat" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>


                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblRem1" runat="server">Remainder1</asp:Label>
                                <asp:TextBox ID="txtRem1" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="row">

                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblRem2" runat="server">Remainder2</asp:Label>
                                <asp:TextBox ID="txtRem2" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>



                            <div class="form-group col-md-3" style="padding-top: 20px">
                                <asp:Label ID="lblRem3" runat="server">Remainder3</asp:Label>
                                <asp:TextBox ID="txtRem3" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>



                        <div class="d-flex justify-content-evenly text-center">
                            <div class="form-group col-md-2" style="padding-top: 20px">
                                <asp:Button ID="Transac" runat="server" CssClass="btn btn-primary" Text="Back" OnClick="Transac_Click" />
                            </div>
                            <div class="form-group col-md-2" style="padding-top: 20px">
                                <asp:Button ID="Update" runat="server" CssClass="btn btn-warning" Text="Update" OnClick="Update_Click" />
                            </div>
                            <div class="form-group col-md-2" style="padding-top: 20px">

                                <asp:Button ID="Add" runat="server" CssClass="btn btn-success" Text="Submit" OnClick="Add_Click" />

                            </div>


                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <%--End of Add Claims --%>
</asp:Content>

