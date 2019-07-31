using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace FinTest
{
    public partial class MainForm : MaterialForm
    {
        MySqlConnection connection =
        new MySqlConnection("Server=aemaeth.iptime.org;Database=CSFINAL;Uid=csuser;Pwd=tltiq;Allow User Variables=True");
        private MySqlDataAdapter mySqlDataAdapter;

        public MainForm()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo400, Primary.Indigo500,
                Primary.Indigo500, Accent.Indigo100,
                TextShade.WHITE
            );

            PatientInfo.BackColor = Color.FromArgb(92, 107, 192);
            DoctorInfo.BackColor = Color.FromArgb(92, 107, 192);
            DepartInfo.BackColor = Color.FromArgb(92, 107, 192);
            MediRecord.BackColor = Color.FromArgb(92, 107, 192);

            Book.BackColor = Color.FromArgb(92, 107, 192);
            Cancel.BackColor = Color.FromArgb(92, 107, 192);
        }

        //메뉴 목록
        private void PatientInfo_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            //환자정보에서 선택된 환자의 정보를 받아오는 델리게이트
            patient.sendName += new Patient.sendNameDelegate(recieveName);
            patient.sendRegi += new Patient.sendRegiDelegate(recieveRegi);
            patient.sendAddr += new Patient.sendAddrDelegate(recieveAddr);
            patient.sendPhone += new Patient.sendPhoneDelegate(recievePhone);
        }

        private void DoctorInfo_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Show();
        }

        private void DepartInfo_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Show();
        }

        private void MediRecord_Click(object sender, EventArgs e)
        {
            MediRecord medirecord = new MediRecord();
            medirecord.Show();
        }


        //진료과를 선택할때 목록을 불러온다.
        private void Department_DropDown(object sender, EventArgs e)
        {
            Department.Items.Clear();
            Load_Department();
        }

        private void Load_Department()
        {
            connection.Open();

            var query = "SELECT dpName FROM department";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    //Iterate through the rows and add it to the combobox's items
                    while (reader.Read())
                    {
                        Department.Items.Add(reader.GetString("dpName"));
                    }
                }
            }

            connection.Close();
        }

        //진료과를 선택했을때
        private void Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocList.Items.Clear();

            connection.Open();

            string selectQuery = "select dName from doctor where dDepart = (select dpNo from department where dpName='" + Department.SelectedItem.ToString() + "')";
            MySqlCommand cmdDataBase = new MySqlCommand(selectQuery, connection);
            MySqlDataReader myReader;
            try
            {
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    DocList.Items.Add(myReader["dName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        //예약하기로 진료기록에 저장
        private void Book_Click(object sender, EventArgs e)
        {
            if (Department.SelectedItem == null || pName == null || pRegiNo == null || pAddress == null || pPhone == null || DocList.SelectedItem == null)
            {
                MessageBox.Show("진료예약 정보를 입력해주세요.");
                return;
            }
            else
            {
                //bookChart.Rows.Add("넘버", pName.Text, Department.SelectedItem.ToString(), pRegiNo, pAddress, pPhone, DocList.SelectedItem.ToString());
                //칼럼에 추가하는 커리문 insertQuery
                string insertQuery = "INSERT INTO medirecord(pNo, dNo, dpNo, tDate) " +
                    "SELECT pNo, dNo, dpNo, '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' " + 
                    "FROM patient, doctor, department " +
                    "WHERE pName = '" + pName.Text +"' and dName = '" + DocList.SelectedItem.ToString() + "' and dpName = '" + Department.SelectedItem.ToString() + "'";

                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                try//예외 처리
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("예약되었습니다.");
                        dataGridReset();
                    }
                    else
                    {
                        MessageBox.Show("예약에 실패했습니다.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();
            }
        }

        //삭제하기로 진료기록 및 예약목록에서 삭제
        private void Cancel_Click(object sender, EventArgs e)
        {
            //진료기록에서 이름, 시간 특정하기
            string selectedName = "";
            string selectedTime = "";

            for (int i = 0; i < bookChart.Rows.Count - 1; i++)
            {
                if (bookChart.Rows[i].Selected || 
                    bookChart.Rows[i].Cells[0].Selected || 
                    bookChart.Rows[i].Cells[1].Selected || 
                    bookChart.Rows[i].Cells[2].Selected || 
                    bookChart.Rows[i].Cells[3].Selected || 
                    bookChart.Rows[i].Cells[4].Selected || 
                    bookChart.Rows[i].Cells[5].Selected || 
                    bookChart.Rows[i].Cells[6].Selected || 
                    bookChart.Rows[i].Cells[7].Selected) //어떤 셀이 눌리더라도 해당 셀의 전체 행을 검색
                {
                    selectedName = bookChart.Rows[i].Cells[1].FormattedValue.ToString();
                    selectedTime = bookChart.Rows[i].Cells[7].FormattedValue.ToString();
                }
            }

            //bookChart에서 삭제
            for (int i=0; i<bookChart.Rows.Count-1; i++)
            {
                if (bookChart.Rows[i].Selected)
                    bookChart.Rows.Remove(bookChart.Rows[i]);
            }

            //medirecord에서 삭제
            //칼럼 수정 커리문 deleteQuery
            string deleteQuery = "Delete mr FROM medirecord mr JOIN patient p ON p.pNo = mr.pNo WHERE TIME(tDATE)='" + selectedTime + "'";

            connection.Open();
            MySqlCommand command = new MySqlCommand(deleteQuery, connection);

            try//예외 처리
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("예약이 취소되었습니다.");
                }
                else
                {
                    MessageBox.Show("예약취소에 실패했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridReset();

            connection.Close();

        }

        //이름란을 클릭하여 환자 검색 및 선택
        private void pName_MouseClick(object sender, MouseEventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            patient.sendName += new Patient.sendNameDelegate(recieveName);
            patient.sendRegi += new Patient.sendRegiDelegate(recieveRegi);
            patient.sendAddr += new Patient.sendAddrDelegate(recieveAddr);
            patient.sendPhone += new Patient.sendPhoneDelegate(recievePhone);
        }

        //폼 간 데이터전송 델리게이트
        private void recieveName(string name)
        {
            pName.Text = name;
        }

        private void recieveRegi(string regi)
        {
            pRegiNo.Text = regi;
        }

        private void recieveAddr(string addr)
        {
            pAddress.Text = addr;
        }

        private void recievePhone(string phone)
        {
            pPhone.Text = phone;
        }

        private void bookChart_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)bookChart.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                mySqlDataAdapter.Update(changes);
                ((DataTable)bookChart.DataSource).AcceptChanges();
            }
        }

        private void dataGridReset()
        {
            string AddbookChart = "SELECT @SEQ := @SEQ+1 AS 'No', 이름, 진료과, 주민번호, 주소, 전화번호, 담당의, 접수시간 " +
                      "FROM " +
                      "(SELECT p.pName AS 이름, dp.dpName AS 진료과, p.pReginum AS 주민번호, p.pAddr AS 주소, p.pPhone AS 전화번호, d.dName AS 담당의, TIME(mr.tDate) AS 접수시간 " +
                      "FROM medirecord as mr " +
                      "JOIN patient as p " +
                      "ON mr.pNo = p.pNo " +
                      "JOIN doctor as d " +
                      "ON mr.dNo = d.dNo " +
                      "JOIN department as dp " +
                      "ON mr.dpNo = dp.dpNo " +
                      "WHERE DATE(mr.tDate) = '" + DateTime.Now.ToString() + "'" +
                      "ORDER BY mr.tDate ASC) " +
                      "AS tbl, (SELECT @SEQ:= 0) A";

            mySqlDataAdapter = new MySqlDataAdapter(AddbookChart, connection);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            bookChart.DataSource = DS.Tables[0];
        }

        private void PatientInfo_MouseEnter(object sender, EventArgs e)
        {
            PatientInfo.BackColor = Color.FromArgb(92, 130, 192);
            PatientInfo.Font = new Font(PatientInfo.Font.Name, 11, FontStyle.Underline);
        }

        private void PatientInfo_MouseLeave(object sender, EventArgs e)
        {
            PatientInfo.BackColor = Color.FromArgb(92, 107, 192);
            PatientInfo.Font = new Font(PatientInfo.Font.Name, 11);
        }

        private void DoctorInfo_MouseEnter(object sender, EventArgs e)
        {
            DoctorInfo.BackColor = Color.FromArgb(92, 130, 192);
            DoctorInfo.Font = new Font(PatientInfo.Font.Name, 11, FontStyle.Underline);
        }

        private void DoctorInfo_MouseLeave(object sender, EventArgs e)
        {
            DoctorInfo.BackColor = Color.FromArgb(92, 107, 192);
            DoctorInfo.Font = new Font(PatientInfo.Font.Name, 11);
        }

        private void DepartInfo_MouseEnter(object sender, EventArgs e)
        {
            DepartInfo.BackColor = Color.FromArgb(92, 130, 192);
            DepartInfo.Font = new Font(PatientInfo.Font.Name, 11, FontStyle.Underline);
        }

        private void DepartInfo_MouseLeave(object sender, EventArgs e)
        {
            DepartInfo.BackColor = Color.FromArgb(92, 107, 192);
            DepartInfo.Font = new Font(PatientInfo.Font.Name, 11);
        }

        private void MediRecord_MouseEnter(object sender, EventArgs e)
        {
            MediRecord.BackColor = Color.FromArgb(92, 130, 192);
            MediRecord.Font = new Font(PatientInfo.Font.Name, 11, FontStyle.Underline);
        }

        private void MediRecord_MouseLeave(object sender, EventArgs e)
        {
            MediRecord.BackColor = Color.FromArgb(92, 107, 192);
            MediRecord.Font = new Font(PatientInfo.Font.Name, 11);
        }

        private void bookChart_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bookChart.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.Automatic;
        }
    }
}
