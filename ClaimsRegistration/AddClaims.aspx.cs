using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ClaimsRegistration
{
    public partial class AddClaims : System.Web.UI.Page
    {
        string ST = "Data Source=DESKTOP-L7KVMKE\\SQLEXPRESS;Initial Catalog=SalesPerformance;Integrated Security=True;";
        int flag = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!Page.IsPostBack)
            {
                refreshdata();
                var yourFile = this.Request.Files["excel-file"];

            }
            

            if (!IsPostBack)
            {



                if (Request.QueryString["Val"] != null && Request.QueryString["Val"] != string.Empty)
                {
                    ViewState["Claimno"] = Request.QueryString["Val"];
                    binddate(ViewState["Claimno"].ToString());
                }
                if (Request.QueryString["flag"] != null)
                {
                    flag = Convert.ToInt32(Request.QueryString["flag"]);
                    binddate(ViewState["Claimno"].ToString());
                }

            }

        }

        public void refreshdata()
        {



        }

        public void binddate(String Claimno)
        {
            SqlConnection con = new SqlConnection(ST);
            SqlDataAdapter sda = new SqlDataAdapter("select * from TBL_ClaimsRegistration where CL_ClaimsNumber='" + Claimno + "'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Label1.Visible = false;
                txtPolNo.Text = ds.Tables[0].Rows[0]["CL_PolicyNumber"].ToString();
                txtProcDate.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["CL_Month"]).ToString("yyyy-MM-dd");
                txtTpa.Text = ds.Tables[0].Rows[0]["CL_Tpa"].ToString();
                txtPolHol.Text = ds.Tables[0].Rows[0]["CL_PolicyHolder"].ToString();
                txtSrc.Text = ds.Tables[0].Rows[0]["CL_Source"].ToString();
                txtCrdNo.Text = ds.Tables[0].Rows[0]["CL_CardNumber"].ToString();
                txtStfNo.Text = ds.Tables[0].Rows[0]["CL_StaffNumber"].ToString();
                txtClaimsNo.Text = ds.Tables[0].Rows[0]["CL_ClaimsNumber"].ToString();
                txtRegBy.Text = ds.Tables[0].Rows[0]["CL_RegisteredBy"].ToString();
                txtPrinName.Text = ds.Tables[0].Rows[0]["CL_PrincipleName"].ToString();
                txtClaimtName.Text = ds.Tables[0].Rows[0]["CL_ClaimantName"].ToString();
                txtDiag.Text = ds.Tables[0].Rows[0]["CL_Diagnosis"].ToString();
                txtHospName.Text = ds.Tables[0].Rows[0]["CL_HospitalName"].ToString();
                txtClaimAmt.Text = ds.Tables[0].Rows[0]["CL_ClaimedAmount"].ToString();
                txtAppAmt.Text = ds.Tables[0].Rows[0]["CL_ApprovedAmount"].ToString();
                txtRej.Text = ds.Tables[0].Rows[0]["CL_Rejection"].ToString();
                txtTreatDate.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["CL_TreatmentDate"]).ToString("yyyy-MM-dd");
                txtDateRecFromCli.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["CL_DateReceivedFromClient"]).ToString("yyyy-MM-dd");
                txtOrigDocRec.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["CL_OriginalDocumentsReceivedDate"]).ToString("yyyy-MM-dd");
                txtDateSentToTPA.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["CL_DateSentToTPA"]).ToString("yyyy-MM-dd");
                txtQuertSentToTPA.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["CL_QuerySentToClient"]).ToString("yyyy-MM-dd");
                txtFinalDocRec.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["CL_FinalDocsReceived"]).ToString("yyyy-MM-dd");
                txtRefNo.Text = ds.Tables[0].Rows[0]["CL_ReferenceNo"].ToString();
                txtDateRevTpa.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["CL_DateReceivedFromTPA"]).ToString("yyyy-MM-dd");
                txtTpaBatchNo.Text = ds.Tables[0].Rows[0]["CL_TPABatchNo"].ToString();
                txtCurrentStatus.Text = ds.Tables[0].Rows[0]["CL_CurrentStatus"].ToString();
                txtRemarks.Text = ds.Tables[0].Rows[0]["CL_Remarks"].ToString();
                txtProceDate.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["CL_ProcessingDate"]).ToString("yyyy-MM-dd");
                txtRejUpdatToClientOn.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["CL_RejectionUpdatedToClientOn"]).ToString("yyyy-MM-dd");
                txtCreditNotNo.Text = ds.Tables[0].Rows[0]["CL_CreditNoteNo"].ToString();
                txtRIDebitNoteNo.Text = ds.Tables[0].Rows[0]["CL_RIDebitNoteNo"].ToString();
                txtDateSentToAcc.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["CL_DateSentToAcc"]).ToString("yyyy-MM-dd");
                txtDateRecToAcc.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["CL_ReceivedFromAcc"]).ToString("yyyy-MM-dd");
                txtBnkTrans.Text = ds.Tables[0].Rows[0]["CL_BTChequeCash"].ToString();
                txtChkNo.Text = ds.Tables[0].Rows[0]["CL_ChequeNoTTNO"].ToString();
                txtChkDate.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["CL_ChequeTTDate"]).ToString("yyyy-MM-dd");
                txtDateOfDisp.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["CL_DateOfDispatch"]).ToString("yyyy-MM-dd");
                txtBnkName.Text = ds.Tables[0].Rows[0]["CL_BankName"].ToString();
                txtAccno.Text = ds.Tables[0].Rows[0]["CL_AccountNo"].ToString();
                txtbefnam.Text = ds.Tables[0].Rows[0]["CL_BeneficiaryName"].ToString();
                txtAcno.Text = ds.Tables[0].Rows[0]["CL_AccNo"].ToString();
                txtSubAcNo.Text = ds.Tables[0].Rows[0]["CL_SubAccNo"].ToString();
                txtTat.Text = ds.Tables[0].Rows[0]["CL_TAT"].ToString();
                txtRem1.Text = ds.Tables[0].Rows[0]["CL_Remainder1"].ToString();
                txtRem2.Text = ds.Tables[0].Rows[0]["CL_Remainder2"].ToString();
                txtRem3.Text = ds.Tables[0].Rows[0]["CL_Remainder3"].ToString();
                if (flag > 0)
                {
                    //txtRem1.ReadOnly = true;
                    Add.Visible = false;
                    
                    Update.Visible = false;
                    Label3.Visible = false;
                    Label1.Visible = false;
                    Label2.Text = "View Claim Number - " + txtClaimsNo.Text;
                    txtPolNo.ReadOnly = true;
                    txtProcDate.ReadOnly = true;
                    txtTpa.ReadOnly = true;
                    txtPolHol.ReadOnly = true;
                    txtSrc.ReadOnly = true;
                    txtCrdNo.ReadOnly = true;
                    txtStfNo.ReadOnly = true;
                    txtClaimsNo.ReadOnly = true;
                    txtRegBy.ReadOnly = true;
                    txtPrinName.ReadOnly = true;
                    txtClaimtName.ReadOnly = true;
                    txtDiag.ReadOnly = true;
                    txtHospName.ReadOnly = true;
                    txtClaimAmt.ReadOnly = true;
                    txtAppAmt.ReadOnly = true;
                    txtRej.ReadOnly = true;
                    txtTreatDate.ReadOnly = true;
                    txtDateRecFromCli.ReadOnly = true;
                    txtOrigDocRec.ReadOnly = true;
                    txtDateSentToTPA.ReadOnly = true;
                    txtQuertSentToTPA.ReadOnly = true;
                    txtFinalDocRec.ReadOnly = true;
                    txtRefNo.ReadOnly = true;
                    txtDateRevTpa.ReadOnly = true;
                    txtTpaBatchNo.ReadOnly = true;
                    txtCurrentStatus.ReadOnly = true;
                    txtRemarks.ReadOnly = true;
                    txtProceDate.ReadOnly = true; ;
                    txtRejUpdatToClientOn.ReadOnly = true;
                    txtCreditNotNo.ReadOnly = true;
                    txtRIDebitNoteNo.ReadOnly = true;
                    txtDateSentToAcc.ReadOnly = true;
                    txtDateRecToAcc.ReadOnly = true;
                    txtBnkTrans.ReadOnly = true;
                    txtChkNo.ReadOnly = true;
                    txtChkDate.ReadOnly = true;
                    txtDateOfDisp.ReadOnly = true;
                    txtBnkName.ReadOnly = true;
                    txtAccno.ReadOnly = true;
                    txtbefnam.ReadOnly = true;
                    txtAcno.ReadOnly = true;
                    txtSubAcNo.ReadOnly = true;
                    txtTat.ReadOnly = true;
                    txtRem1.ReadOnly = true;
                    txtRem2.ReadOnly = true;
                    txtRem3.ReadOnly = true;
                }
              

            }

        }
        protected void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPolNo.Text) || string.IsNullOrEmpty(txtPolHol.Text))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Please enter mandatory fields');", true);
                }
                else
                {
                    SqlConnection con = new SqlConnection(ST);
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Insert", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@ProcDate", SqlDbType.DateTime).Value = txtProcDate.Text.ToString();
                        cmd.Parameters.Add("@Tpa", SqlDbType.NVarChar).Value = txtTpa.Text;
                        cmd.Parameters.Add("@PolicyNo", SqlDbType.NVarChar).Value = txtPolNo.Text;
                        cmd.Parameters.Add("@PolicyHolder", SqlDbType.NVarChar).Value = txtPolHol.Text;
                        cmd.Parameters.Add("@Source", SqlDbType.NVarChar).Value = txtSrc.Text;
                        cmd.Parameters.Add("@CrdNo", SqlDbType.NVarChar).Value = txtCrdNo.Text;
                        cmd.Parameters.Add("@StfNo", SqlDbType.NVarChar).Value = txtStfNo.Text;
                        cmd.Parameters.Add("@CliamNo", SqlDbType.NVarChar).Value = txtClaimsNo.Text;
                        cmd.Parameters.Add("@Reg", SqlDbType.NVarChar).Value = txtRegBy.Text;
                        cmd.Parameters.Add("@PrinNo", SqlDbType.NVarChar).Value = txtPrinName.Text;
                        cmd.Parameters.Add("@CliamntNo", SqlDbType.NVarChar).Value = txtClaimtName.Text;
                        cmd.Parameters.Add("@Diagnosis", SqlDbType.NVarChar).Value = txtDiag.Text;
                        cmd.Parameters.Add("@Hospname", SqlDbType.NVarChar).Value = txtHospName.Text;
                        cmd.Parameters.Add("@ClimAmt", SqlDbType.NVarChar).Value = txtClaimAmt.Text;
                        cmd.Parameters.Add("@AppNo", SqlDbType.NVarChar).Value = txtAppAmt.Text;
                        cmd.Parameters.Add("@Rejection", SqlDbType.NVarChar).Value = txtRej.Text;
                        cmd.Parameters.Add("@TrtDate", SqlDbType.DateTime).Value = txtTreatDate.Text.ToString();
                        cmd.Parameters.Add("@Daterevclient", SqlDbType.DateTime).Value = txtDateRecFromCli.Text.ToString();
                        cmd.Parameters.Add("@OrgDocRec", SqlDbType.DateTime).Value = txtOrigDocRec.Text.ToString();
                        cmd.Parameters.Add("@DateSentTpa", SqlDbType.DateTime).Value = txtDateSentToTPA.Text.ToString();
                        cmd.Parameters.Add("@QrySentTpa", SqlDbType.DateTime).Value = txtQuertSentToTPA.Text.ToString();
                        cmd.Parameters.Add("@FinalDocRec", SqlDbType.DateTime).Value = txtFinalDocRec.Text.ToString();
                        cmd.Parameters.Add("@RefNo", SqlDbType.NVarChar).Value = txtRefNo.Text;
                        cmd.Parameters.Add("@DateRevTpa", SqlDbType.DateTime).Value = txtDateRevTpa.Text.ToString();
                        cmd.Parameters.Add("@TpaBatNo", SqlDbType.NVarChar).Value = txtTpaBatchNo.Text;
                        cmd.Parameters.Add("@CurrentStatus", SqlDbType.NVarChar).Value = txtCurrentStatus.Text;
                        cmd.Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = txtRemarks.Text;
                        cmd.Parameters.Add("@ProceDate", SqlDbType.DateTime).Value = txtProceDate.Text.ToString();
                        cmd.Parameters.Add("@RejUpdOn", SqlDbType.DateTime).Value = txtRejUpdatToClientOn.Text.ToString();
                        cmd.Parameters.Add("@CreditNoteNo", SqlDbType.NVarChar).Value = txtCreditNotNo.Text;
                        cmd.Parameters.Add("@RiDebNoteNo", SqlDbType.NVarChar).Value = txtRIDebitNoteNo.Text;
                        cmd.Parameters.Add("@DateSentToAcc", SqlDbType.DateTime).Value = txtDateSentToAcc.Text.ToString();
                        cmd.Parameters.Add("@DateRecFmAcc", SqlDbType.DateTime).Value = txtDateRecToAcc.Text.ToString();
                        cmd.Parameters.Add("@BankTrans", SqlDbType.NVarChar).Value = txtBnkTrans.Text;
                        cmd.Parameters.Add("@ChqNo", SqlDbType.NVarChar).Value = txtChkNo.Text;
                        cmd.Parameters.Add("@ChqDate", SqlDbType.DateTime).Value = txtChkDate.Text.ToString();
                        cmd.Parameters.Add("@DateOfDisp", SqlDbType.DateTime).Value = txtDateOfDisp.Text.ToString();
                        cmd.Parameters.Add("@BnkNo", SqlDbType.NVarChar).Value = txtBnkName.Text;
                        cmd.Parameters.Add("@AccNo", SqlDbType.NVarChar).Value = txtAccno.Text;
                        cmd.Parameters.Add("@BeneNo", SqlDbType.NVarChar).Value = txtbefnam.Text;
                        cmd.Parameters.Add("@AcNo", SqlDbType.NVarChar).Value = txtAcno.Text;
                        cmd.Parameters.Add("@SubAcNo", SqlDbType.NVarChar).Value = txtSubAcNo.Text;
                        cmd.Parameters.Add("@Tat", SqlDbType.NVarChar).Value = txtTat.Text;
                        cmd.Parameters.Add("@Rem1", SqlDbType.NVarChar).Value = txtRem1.Text;
                        cmd.Parameters.Add("@Rem2", SqlDbType.NVarChar).Value = txtRem2.Text;
                        cmd.Parameters.Add("@Rem3", SqlDbType.NVarChar).Value = txtRem3.Text;
                        //cmd.Parameters.AddWithValue("@Cr_User", Session["UserName"]);
                        // cmd.Parameters.AddWithValue("@Cr_Dt", DateTime.Now.ToString());
                        //cmd.Parameters.AddWithValue("@Up_User",);
                        //cmd.Parameters.AddWithValue("@Up_Dt",);
                        cmd.Parameters.AddWithValue("@Up_Status", "L");

                        int output1 = cmd.ExecuteNonQuery();
                        if (output1 > 0)
                        {

                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Data added Successfully');", true);
                            Response.Redirect("Transaction.aspx");
                        }
                        else if (output1 == 0)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('null output');", true);
                        }
                        else
                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Error');", true);

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }

            }



            /*  protected void Search_Click(object sender, EventArgs e)
              {


         }*/
            catch (Exception ex)
            {
                throw ex;
            }

        }

        protected void Transac_Click(object sender, EventArgs e)
        {
            Response.Redirect("Transaction.aspx");
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ST);
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("UserRegistrationupdate", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ProcDate", SqlDbType.NVarChar).Value = txtProcDate.Text;
                    cmd.Parameters.Add("@PolicyNo", SqlDbType.NVarChar).Value = txtPolNo.Text;
                    cmd.Parameters.Add("@Source", SqlDbType.NVarChar).Value = txtSrc.Text;
                    cmd.Parameters.Add("@Tpa", SqlDbType.NVarChar).Value = txtTpa.Text;
                    cmd.Parameters.Add("@PolicyHolder", SqlDbType.NVarChar).Value = txtPolHol.Text;
                    cmd.Parameters.Add("@CliamNo", SqlDbType.NVarChar).Value = txtClaimsNo.Text;
                    cmd.Parameters.Add("@CrdNo", SqlDbType.NVarChar).Value = txtCrdNo.Text;
                    cmd.Parameters.Add("@StfNo", SqlDbType.NVarChar).Value = txtStfNo.Text;
                    cmd.Parameters.Add("@RegBy", SqlDbType.NVarChar).Value = txtRegBy.Text;
                    cmd.Parameters.Add("@PrinName", SqlDbType.NVarChar).Value = txtPrinName.Text;
                    cmd.Parameters.Add("@ClaimtName", SqlDbType.NVarChar).Value = txtClaimtName.Text;
                    cmd.Parameters.Add("@Diag", SqlDbType.NVarChar).Value = txtDiag.Text;
                    cmd.Parameters.Add("@HospName", SqlDbType.NVarChar).Value = txtHospName.Text;
                    cmd.Parameters.Add("@ClaimAmt", SqlDbType.NVarChar).Value = txtClaimAmt.Text;
                    cmd.Parameters.Add("@AppAmt", SqlDbType.NVarChar).Value = txtAppAmt.Text;
                    cmd.Parameters.Add("@Rej", SqlDbType.NVarChar).Value = txtRej.Text;
                    cmd.Parameters.Add("@TreatDate", SqlDbType.NVarChar).Value = txtTreatDate.Text;
                    cmd.Parameters.Add("@DateRecFromCli", SqlDbType.NVarChar).Value = txtDateRecFromCli.Text;
                    cmd.Parameters.Add("@OrigDocRec", SqlDbType.NVarChar).Value = txtOrigDocRec.Text;
                    cmd.Parameters.Add("@DateSentToTPA", SqlDbType.NVarChar).Value = txtDateSentToTPA.Text;
                    cmd.Parameters.Add("@QuertSentToTPA", SqlDbType.NVarChar).Value = txtQuertSentToTPA.Text;
                    cmd.Parameters.Add("@FinalDocRec", SqlDbType.NVarChar).Value = txtFinalDocRec.Text;
                    cmd.Parameters.Add("@RefNo", SqlDbType.NVarChar).Value = txtRefNo.Text;
                    cmd.Parameters.Add("@DateRevTpa", SqlDbType.NVarChar).Value = txtDateRevTpa.Text;
                    cmd.Parameters.Add("@TpaBatchNo", SqlDbType.NVarChar).Value = txtTpaBatchNo.Text;
                    cmd.Parameters.Add("@CurrentStatus", SqlDbType.NVarChar).Value = txtCurrentStatus.Text;
                    cmd.Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = txtRemarks.Text;
                    cmd.Parameters.Add("@ProceDate", SqlDbType.NVarChar).Value = txtProceDate.Text;
                    cmd.Parameters.Add("@RejUpdatToClientOn", SqlDbType.NVarChar).Value = txtRejUpdatToClientOn.Text;
                    cmd.Parameters.Add("@CreditNotNo", SqlDbType.NVarChar).Value = txtCreditNotNo.Text;
                    cmd.Parameters.Add("@RIDebitNoteNo", SqlDbType.NVarChar).Value = txtRIDebitNoteNo.Text;
                    cmd.Parameters.Add("@DateSentToAcc", SqlDbType.NVarChar).Value = txtDateSentToAcc.Text;
                    cmd.Parameters.Add("@DateRecToAcc", SqlDbType.NVarChar).Value = txtDateRecToAcc.Text;
                    cmd.Parameters.Add("@BnkTrans", SqlDbType.NVarChar).Value = txtBnkTrans.Text;
                    cmd.Parameters.Add("@ChkNo", SqlDbType.NVarChar).Value = txtChkNo.Text;
                    cmd.Parameters.Add("@ChkDate", SqlDbType.NVarChar).Value = txtChkDate.Text;
                    cmd.Parameters.Add("@DateOfDisp", SqlDbType.NVarChar).Value = txtDateOfDisp.Text;
                    cmd.Parameters.Add("@BnkName", SqlDbType.NVarChar).Value = txtBnkName.Text;
                    cmd.Parameters.Add("@Accno", SqlDbType.NVarChar).Value = txtAccno.Text;
                    cmd.Parameters.Add("@befnam", SqlDbType.NVarChar).Value = txtbefnam.Text;
                    cmd.Parameters.Add("@Acno", SqlDbType.NVarChar).Value = txtAcno.Text;
                    cmd.Parameters.Add("@SubAcNo", SqlDbType.NVarChar).Value = txtSubAcNo.Text;
                    cmd.Parameters.Add("@Tat", SqlDbType.NVarChar).Value = txtTat.Text;
                    cmd.Parameters.Add("@Rem1", SqlDbType.NVarChar).Value = txtRem1.Text;
                    cmd.Parameters.Add("@Rem2", SqlDbType.NVarChar).Value = txtRem2.Text;
                    cmd.Parameters.Add("@Rem3", SqlDbType.NVarChar).Value = txtRem3.Text;
                 


                        int output12 = cmd.ExecuteNonQuery();
                    if (output12 > 0)
                    {
                      
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Claim Updated Successfully');", true);
                        Response.Redirect("Transaction.aspx");
                    }
                    else if (output12 < 0)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Errror');", true);
                    }
              


                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}