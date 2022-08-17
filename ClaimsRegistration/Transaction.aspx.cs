using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;
using System.IO;

namespace ClaimsRegistration
{
    public partial class Transaction : System.Web.UI.Page
    {
        string ST = "Data Source=DESKTOP-L7KVMKE\\SQLEXPRESS;Initial Catalog=Claims;Integrated Security =True;";

        protected void Page_Load(object sender, EventArgs e)
        {
       
            if (!Page.IsPostBack)
            {
                //refreshdata();
               // var yourFile = this.Request.Files["excel-file"];

            }
        }

        public void refreshdata()
        {
            SqlConnection con = new SqlConnection(ST);
            SqlDataAdapter sda = new SqlDataAdapter("select * from TBL_ClaimsRegistration", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            TransGrid.DataSource = ds;
            TransGrid.DataBind();
        }
        public void clear()
        {
            txtPlyNumber.Text = string.Empty;
            txtCliNumber.Text = string.Empty;
            txtCrdNumber.Text = string.Empty;
            


        }

        protected void ButSearch_Click(object sender, EventArgs e)
        {
            try
            {
                TransGrid.Visible = true;
                string polno = txtPlyNumber.Text;
                string climno = txtCliNumber.Text;
                string cardno = txtCrdNumber.Text;
                SqlConnection con = new SqlConnection(ST);
                SqlDataAdapter sdaa = new SqlDataAdapter("select * from TBL_ClaimsRegistration where CL_PolicyNumber='" + polno + "' or CL_CardNumber='" + cardno + "' or CL_ClaimsNumber='" + climno + "'", con);
                DataSet dsa = new DataSet();
                sdaa.Fill(dsa);
                TransGrid.DataSource = dsa;
                TransGrid.DataBind();
               


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void insertdataintosql(DateTime ProcDate,string TPA,string PolNo,string PolHold,string Source,string Cardno,string Staffno,string ClaimNo,string Regby,string PrinNo,string ClaimtNo,string Diag,string Hosname,string ClaimAmt,string AppAmt,string Rej, DateTime TrtDate, DateTime DateRec, DateTime OrgDocRec, DateTime DateSentTPA, DateTime QrysentCli, DateTime FinalDocRec,string refno, DateTime daterecfromtpa,string tpabano,string CurrStat,string Remarks, DateTime Processingdate, DateTime RejupdatedtoClient,string CrediNoteNo,string RIDebitnote, DateTime Datesenttoacc, DateTime Recfromacc,string btchqcash,string cheqnott, DateTime chqttdate, DateTime dateofdispatch,string bankname,string accno,string benename,string acno,string subaccno,string tat,string rem1,string rem2,string rem3)

        {

            SqlConnection conn = new SqlConnection(ST);


            string query1 = "INSERT INTO TBL_ClaimsRegistration(CL_Month, CL_Tpa,	CL_PolicyNumber,	CL_PolicyHolder,	CL_Source,	CL_CardNumber,	CL_StaffNumber,	CL_ClaimsNumber,	CL_RegisteredBy,	CL_PrincipleName,	CL_ClaimantName,	CL_Diagnosis,	CL_HospitalName,	CL_ClaimedAmount,	CL_ApprovedAmount,	CL_Rejection,	CL_TreatmentDate,	CL_DateReceivedFromClient,	CL_OriginalDocumentsReceivedDate,	CL_DateSentToTPA,	CL_QuerySentToClient,	CL_FinalDocsReceived,	CL_ReferenceNo,	CL_DateReceivedFromTPA,	CL_TPABatchNo,	CL_CurrentStatus,	CL_Remarks,	CL_ProcessingDate,	CL_RejectionUpdatedToClientOn,	CL_CreditNoteNo,	CL_RIDebitNoteNo,	CL_DateSentToAcc,	CL_ReceivedFromAcc,	CL_BTChequeCash,	CL_ChequeNoTTNO,	CL_ChequeTTDate,	CL_DateOfDispatch,	CL_BankName,	CL_AccountNo,	CL_BeneficiaryName,	CL_AccNo,	CL_SubAccNo,	CL_TAT,	CL_Remainder1,	CL_Remainder2,	CL_Remainder3)"
              + " VALUES (@ProcDate,@TPA,@PolNo,@PolHold,@Source,@Cardno,@Staffno,@ClaimNo,@Regby,@PrinNo,@ClaimtNo,@Diag,@Hosname,@ClaimAmt,@AppAmt,@Rej,@TrtDate, @DateRec,@OrgDocRec,@DateSentTPA,@QrysentCli,@FinalDocRec,@refno,@daterecfromtpa,@tpabano,@CurrStat,@Remarks,@Processingdate,@RejupdatedtoClient,@CrediNoteNo,@RIDebitnote,@Datesenttoacc,@Recfromacc,@btchqcash,@cheqnott,@chqttdate,@dateofdispatch,@bankname,@accno,@benename,@acno,@subaccno,@tat,@rem1,@rem2,@rem3)";
            SqlCommand cmd = new SqlCommand(query1, conn);
            cmd.CommandText = query1;
            cmd.Parameters.Add("@ProcDate", SqlDbType.DateTime).Value = ProcDate;
            cmd.Parameters.Add("@TPA", SqlDbType.NVarChar, 100).Value = TPA;
            cmd.Parameters.Add("@PolNo", SqlDbType.NVarChar, 100).Value = PolNo;
            cmd.Parameters.Add("@PolHold", SqlDbType.NVarChar, 100).Value = PolHold;
            cmd.Parameters.Add("@Source", SqlDbType.NVarChar, 100).Value = Source;
            cmd.Parameters.Add("@Cardno", SqlDbType.NVarChar, 100).Value = Cardno;
            cmd.Parameters.Add("@Staffno", SqlDbType.NVarChar, 100).Value = Staffno;
            cmd.Parameters.Add("@ClaimNo", SqlDbType.NVarChar, 100).Value = ClaimNo;
            cmd.Parameters.Add("@Regby", SqlDbType.NVarChar, 100).Value = Regby;
            cmd.Parameters.Add("@PrinNo", SqlDbType.NVarChar, 100).Value = PrinNo;
            cmd.Parameters.Add("@ClaimtNo", SqlDbType.NVarChar, 100).Value = ClaimtNo;
            cmd.Parameters.Add("@Diag", SqlDbType.NVarChar, 100).Value = Diag;
            cmd.Parameters.Add("@Hosname", SqlDbType.NVarChar, 100).Value = Hosname;
            cmd.Parameters.Add("@ClaimAmt", SqlDbType.Float).Value = ClaimAmt;
            cmd.Parameters.Add("@AppAmt", SqlDbType.Float).Value = AppAmt;
            cmd.Parameters.Add("@Rej", SqlDbType.Float).Value = Rej;
            cmd.Parameters.Add("@TrtDate", SqlDbType.DateTime).Value = TrtDate;
            cmd.Parameters.Add("@DateRec", SqlDbType.DateTime).Value = DateRec;
            cmd.Parameters.Add("@OrgDocRec", SqlDbType.DateTime).Value = OrgDocRec;
            cmd.Parameters.Add("@DateSentTPA", SqlDbType.DateTime).Value = DateSentTPA;
            cmd.Parameters.Add("@QrysentCli", SqlDbType.DateTime).Value = QrysentCli;
            cmd.Parameters.Add("@FinalDocRec", SqlDbType.DateTime).Value = FinalDocRec;
            cmd.Parameters.Add("@refno", SqlDbType.NVarChar, 100).Value = refno;
            cmd.Parameters.Add("@daterecfromtpa", SqlDbType.DateTime).Value = daterecfromtpa;
            cmd.Parameters.Add("@tpabano", SqlDbType.NVarChar, 100).Value = tpabano;
            cmd.Parameters.Add("@CurrStat", SqlDbType.NVarChar, 100).Value = CurrStat;
            cmd.Parameters.Add("@Remarks", SqlDbType.NVarChar, 100).Value = Remarks;
            cmd.Parameters.Add("@Processingdate", SqlDbType.DateTime).Value = Processingdate;
            cmd.Parameters.Add("@RejupdatedtoClient", SqlDbType.DateTime).Value = RejupdatedtoClient;
            cmd.Parameters.Add("@CrediNoteNo", SqlDbType.NVarChar, 100).Value = CrediNoteNo;
            cmd.Parameters.Add("@RIDebitnote", SqlDbType.NVarChar, 100).Value = RIDebitnote;
            cmd.Parameters.Add("@Datesenttoacc", SqlDbType.DateTime).Value = Datesenttoacc;
            cmd.Parameters.Add("@Recfromacc", SqlDbType.DateTime).Value = Recfromacc;
            cmd.Parameters.Add("@btchqcash", SqlDbType.NVarChar, 100).Value = btchqcash;
            cmd.Parameters.Add("@cheqnott", SqlDbType.NVarChar, 100).Value = cheqnott;
            cmd.Parameters.Add("@chqttdate", SqlDbType.DateTime).Value = chqttdate;
            cmd.Parameters.Add("@dateofdispatch", SqlDbType.DateTime).Value = dateofdispatch;
            cmd.Parameters.Add("@bankname", SqlDbType.NVarChar, 100).Value = bankname;
            cmd.Parameters.Add("@accno", SqlDbType.NVarChar, 100).Value = accno;
            cmd.Parameters.Add("@benename", SqlDbType.NVarChar, 100).Value = benename;
            cmd.Parameters.Add("@acno", SqlDbType.NVarChar, 100).Value = acno;
            cmd.Parameters.Add("@subaccno", SqlDbType.NVarChar, 100).Value = subaccno;
            cmd.Parameters.Add("@tat", SqlDbType.NVarChar, 100).Value = tat;
            cmd.Parameters.Add("@rem1", SqlDbType.NVarChar, 100).Value = rem1;
            cmd.Parameters.Add("@rem2", SqlDbType.NVarChar, 100).Value = rem2;
            cmd.Parameters.Add("@rem3", SqlDbType.NVarChar, 100).Value = rem3;
            cmd.CommandType = CommandType.Text;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
       


        protected void UploadBulkData_Click(object sender, EventArgs e)
        {
            OleDbConnection oconn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = " + Server.MapPath("Uploads/Policy.xls") + "; Extended Properties = 'Excel 8.0;IMEX=1'");
            try
            {
                OleDbCommand ocmd = new OleDbCommand("select * from [Sheet1$]", oconn);
                oconn.Open();
                OleDbDataReader odr = ocmd.ExecuteReader();
                DateTime ProcDate;
                string TPA = "";
                string PolNo = "";
                string PolHold = "";
                string Source = "";
                string Cardno = "";
                string Staffno = "";
                string ClaimNo = "";
                string Regby = "";
                string PrinNo = "";
                string ClaimtNo = "";
                string Diag = "";
                string Hosname = "";
                string ClaimAmt = "";
                string AppAmt = "";
                string Rej = "";
                DateTime TrtDate;
                DateTime DateRec;
                DateTime OrgDocRec;
                DateTime DateSentTPA;
                DateTime QrysentCli;
                DateTime FinalDocRec;
                string refno = "";
                DateTime daterecfromtpa;
                string tpabano = "";
                string CurrStat = "";
                string Remarks = "";
                DateTime Processingdate;
                DateTime RejupdatedtoClient;
                string CrediNoteNo = "";
                string RIDebitnote = "";
                DateTime Datesenttoacc;
                DateTime Recfromacc;
                string btchqcash = "";
                string cheqnott = "";
                DateTime chqttdate;
                DateTime dateofdispatch;
                string bankname = "";
                string accno = "";
                string benename = "";
                string acno = "";
                string subaccno = "";
                string tat = "";
                string rem1 = "";
                string rem2 = "";
                string rem3 = "";



                while (odr.Read())
                {
                    ProcDate =Convert.ToDateTime(valid(odr, 45));
                    TPA = valid(odr, 0);
                    PolNo = valid(odr, 1);
                    PolHold = valid(odr, 2);
                    Source = valid(odr, 3);
                    Cardno = valid(odr, 4);
                    Staffno = valid(odr, 5);
                    ClaimNo = valid(odr, 6);
                    Regby = valid(odr, 7);
                    PrinNo = valid(odr, 8);
                    ClaimtNo = valid(odr, 9);
                    Diag = valid(odr, 10);
                    Hosname = valid(odr, 11);
                    ClaimAmt = valid(odr, 12);
                    AppAmt = valid(odr, 13);
                    Rej = valid(odr, 14);
                    TrtDate = Convert.ToDateTime(valid(odr, 15));
                    DateRec = Convert.ToDateTime(valid(odr, 16));
                    OrgDocRec = Convert.ToDateTime(valid(odr, 17));
                    DateSentTPA = Convert.ToDateTime(valid(odr, 18));
                    QrysentCli = Convert.ToDateTime(valid(odr, 19));
                    FinalDocRec = Convert.ToDateTime(valid(odr, 20));
                    refno = valid(odr, 21);
                    daterecfromtpa = Convert.ToDateTime(valid(odr, 22));
                    tpabano = valid(odr, 23);
                    CurrStat = valid(odr, 24);
                    Remarks = valid(odr, 25);
                    Processingdate = Convert.ToDateTime(valid(odr, 26));
                    RejupdatedtoClient = Convert.ToDateTime(valid(odr, 27));
                    CrediNoteNo = valid(odr, 28);
                    RIDebitnote = valid(odr, 29);
                    Datesenttoacc = Convert.ToDateTime(valid(odr, 30));
                    Recfromacc = Convert.ToDateTime(valid(odr, 31));
                    btchqcash = valid(odr, 32);
                    cheqnott = valid(odr, 33);
                    chqttdate = Convert.ToDateTime(valid(odr, 34));
                    dateofdispatch = Convert.ToDateTime(valid(odr, 35));
                    bankname = valid(odr, 36);
                    accno = valid(odr, 37);
                    benename = valid(odr, 38);
                    acno = valid(odr, 39);
                    subaccno = valid(odr, 40);
                    tat = valid(odr, 41);
                    rem1 = valid(odr, 42);
                    rem2 = valid(odr, 43);
                    rem3 = valid(odr, 44);

                    insertdataintosql(ProcDate,TPA, PolNo,PolHold,Source,Cardno,Staffno,ClaimNo,Regby,PrinNo,ClaimtNo,Diag,Hosname,ClaimAmt,AppAmt,Rej,TrtDate,DateRec,OrgDocRec,DateSentTPA,QrysentCli,FinalDocRec,refno,daterecfromtpa,tpabano,CurrStat,Remarks,Processingdate,RejupdatedtoClient,CrediNoteNo,RIDebitnote,Datesenttoacc,Recfromacc,btchqcash,cheqnott,chqttdate,dateofdispatch,bankname,accno,benename,acno,subaccno,tat,rem1,rem2,rem3);
                    refreshdata();

                }

                oconn.Close();
            }

            catch (DataException ee)
            {
                throw ee;
            }
            finally
            {
               
            }

        }


        protected string valid(OleDbDataReader myreader, int stval) //if any columns are found null then they are replaced by zero
        {
            object val = myreader[stval];
            if (val != DBNull.Value)
                return val.ToString();
            else
                return Convert.ToString(0);
        }







    

    protected void AddPolicy_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddClaims.aspx");
        }

        protected void Bulkupload_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", string.Format("attachment; filename=" + "Policy.xls"));
            Response.ContentType = "application/ms-excel";
            DataTable dt = GetDatafromDatabase();
            string str = string.Empty;
            foreach (DataColumn dtcol in dt.Columns)
            {
                Response.Write(str + dtcol.ColumnName);
                str = "\t";
            }
            Response.Write("\n");
            foreach (DataRow dr in dt.Rows)
            {
                str = "";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Response.Write(str + Convert.ToString(dr[j]));
                    str = "\t";
                }
                Response.Write("\n");
            }
            Response.End();

        }

        protected DataTable GetDatafromDatabase()
        {

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ST))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select TOP 10 CL_PolicyNumber,CL_CardNumber,CL_ClaimsNumber FROM TBL_ClaimsRegistration", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }


        protected void TransGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "View")
            {
                
                string ClaimNo = Convert.ToString(e.CommandArgument.ToString());
                int flag = 1;
                Response.Redirect("AddClaims.aspx?Val=" + ClaimNo + "&flag=" + flag + "");

            }

        }

        protected void TransGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            string ClaimNo = TransGrid.DataKeys[e.NewEditIndex].Value.ToString();
            int flag = 0;
            Response.Redirect("AddClaims.aspx?Val=" + ClaimNo + "&flag=" + flag + "");

        }



        protected void TransGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TransGrid_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            string ClaimNO;
            ClaimNO = TransGrid.DataKeys[e.RowIndex].Value.ToString();
            SqlConnection con = new SqlConnection(ST);
            con.Open();

            SqlCommand cmd = new SqlCommand("UserRegistrationdelete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CliamNo", SqlDbType.NVarChar, 100).Value =ClaimNO;
            cmd.ExecuteNonQuery();
            con.Close();
            refreshdata();
        }

        protected void ButClear_Click(object sender, EventArgs e)
        {
            clear();
            refreshdata();

        }
    }
}