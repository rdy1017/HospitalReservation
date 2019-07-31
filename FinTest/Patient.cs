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
    public partial class Patient : MaterialForm
    {
        MySqlConnection connection =
        new MySqlConnection("Server=aemaeth.iptime.org;Database=CSFINAL;Uid=csuser;Pwd=tltiq;Allow User Variables=True");
        private MySqlDataAdapter mySqlDataAdapter;

        public delegate void sendNameDelegate(string name);
        public event sendNameDelegate sendName;
        public delegate void sendRegiDelegate(string regi);
        public event sendRegiDelegate sendRegi;
        public delegate void sendAddrDelegate(string addr);
        public event sendAddrDelegate sendAddr;
        public delegate void sendPhoneDelegate(string phone);
        public event sendPhoneDelegate sendPhone;

        public Patient()
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

            Add.BackColor = Color.FromArgb(92, 107, 192);
            Edit.BackColor = Color.FromArgb(92, 107, 192);
            Delete.BackColor = Color.FromArgb(92, 107, 192);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            //환자 추가
            //빈칸이 있으면 아무일도 안일어나게 함
            if (pName.Text == null || pRegiNo.Text == null || pAddress.Text == null || pPhone.Text == null)
            {
                MessageBox.Show("정보를 모두 입력해주세요.");
                return;
            }

            else
            {
                //칼럼에 추가하는 커리문 insertQuery
                string insertQuery = "INSERT INTO patient(pName, pReginum, pAddr, pPhone) VALUES('" + pName.Text + "','" + pRegiNo.Text + "','" + pAddress.Text + "','" + pPhone.Text + "')";

                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                try//예외 처리
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("추가되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("추가에 실패했습니다.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();

                dataGridReset();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            //환자 수정
            //빈칸이 있으면 아무일도 안일어나게 함
            if (pName.Text == null || pRegiNo.Text == null || pAddress.Text == null || pPhone.Text == null)
            {
                MessageBox.Show("정보를 모두 입력해주세요.");
                return;
            }
            else
            {
                //칼럼 수정 커리문 updateQuery
                string updateQuery = "UPDATE patient SET pName='" + pName.Text + "', pReginum='" + pRegiNo.Text + "', pAddr='" + pAddress.Text + "', pPhone='" + pPhone.Text + "' WHERE pNo='"+ pNo.Text +"'";

                connection.Open();
                MySqlCommand command = new MySqlCommand(updateQuery, connection);

                try//예외 처리
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("수정되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("수정에 실패했습니다.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();

                dataGridReset();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //환자 삭제
            //칼럼 수정 커리문 deleteQuery
            string deleteQuery = "Delete FROM patient WHERE pNo='" + pNo.Text + "'";
        
            connection.Open();
            MySqlCommand command = new MySqlCommand(deleteQuery, connection);

            try//예외 처리
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("삭제되었습니다.");
                }
                else
                {
                    MessageBox.Show("삭제에 실패했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();

            dataGridReset();
        }

        //폼이 로드될때 데이터그리드뷰를 갱신
        private void Patient_Load(object sender, EventArgs e)
        {
            dataGridReset();
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)patientChart.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                mySqlDataAdapter.Update(changes);
                ((DataTable)patientChart.DataSource).AcceptChanges();
            }
        }

        //데이터에 변동이 있을때마다 갱신하는 함수
        private void dataGridReset()
        {
            connection.Open();

            mySqlDataAdapter = new MySqlDataAdapter("select pNo as No, pName as 이름, pReginum as 주민번호, pAddr as 주소, pPhone as 전화번호 from patient", connection);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            patientChart.DataSource = DS.Tables[0];

            connection.Close();
        }

        //데이터그리드뷰에서 셀을 선택할때 정보창에 표시
        private void patientChart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pNo.Text = patientChart.Rows[e.RowIndex].Cells[0].Value.ToString();
            pName.Text = patientChart.Rows[e.RowIndex].Cells[1].Value.ToString();
            pRegiNo.Text = patientChart.Rows[e.RowIndex].Cells[2].Value.ToString();
            pAddress.Text = patientChart.Rows[e.RowIndex].Cells[3].Value.ToString();
            pPhone.Text = patientChart.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        //이름으로 검색
        private void pName_KeyUp(object sender, KeyEventArgs e)
        {
            connection.Open();

            string searchName = "select pNo as No, pName as 이름, pReginum as 주민번호, pAddr as 주소, pPhone as 전화번호 from patient where pName like '%" + pName.Text + "%'";
            mySqlDataAdapter = new MySqlDataAdapter(searchName, connection);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            patientChart.DataSource = DS.Tables[0];

            connection.Close();
        }

        //환자를 선택하여 메인으로 보내준다.
        private void patientChart_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string passName = patientChart.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            string passRegi = patientChart.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            string passAddr = patientChart.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            string passPhone = patientChart.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

            this.sendName(passName);
            this.sendRegi(passRegi);
            this.sendAddr(passAddr);
            this.sendPhone(passPhone);
            this.Close();
        }

        private void patientChart_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            patientChart.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.Automatic;
        }
    }
}
