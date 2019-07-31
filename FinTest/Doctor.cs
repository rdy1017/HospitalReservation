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
    public partial class Doctor : MaterialForm
    {
        MySqlConnection connection =
        new MySqlConnection("Server=aemaeth.iptime.org;Database=CSFINAL;Uid=csuser;Pwd=tltiq;Allow User Variables=True");
        private MySqlDataAdapter mySqlDataAdapter;

        public Doctor()
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
            //의사 추가
            //빈칸이 있으면 아무일도 안일어나게 함
            if (dName.Text == null || dDepart.Text == null || dRegiNo.Text == null || dAddress.Text == null || dPhone.Text == null)
            {
                MessageBox.Show("정보를 모두 입력해주세요.");
                return;
            }

            else
            {
                //칼럼에 추가하는 커리문 insertQuery
                string insertQuery = "INSERT INTO doctor(dName, dDepart, dReginum, dAddr, dPhone) " +
                    "SELECT '" + dName.Text + "', dpNo, '" + dRegiNo.Text + "','" + dAddress.Text + "','" + dPhone.Text + "' " +
                    "FROM department " +
                    "WHERE dpName='" + dDepart.Text + "'";
               
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
            //의사 수정
            //빈칸이 있으면 아무일도 안일어나게 함
            if (dName.Text == null || dDepart.Text == null || dRegiNo.Text == null || dAddress.Text == null || dPhone.Text == null)
            {
                MessageBox.Show("정보를 모두 입력해주세요.");
                return;
            }
            else
            {
                //칼럼 수정 커리문 updateQuery
                string updateQuery = "UPDATE doctor SET dName='" + dName.Text + "', dDepart= (SELECT dpNo From department WHERE dpName='" + dDepart.Text + "'), dReginum='" + dRegiNo.Text + "', dAddr='" + dAddress.Text + "', dPhone='" + dPhone.Text + "' WHERE dNo='" + dNo.Text + "'";

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
            //의사 삭제
            //칼럼 수정 커리문 deleteQuery
            string deleteQuery = "Delete FROM doctor WHERE dNo='" + dNo.Text + "'";

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

        private void Doctor_Load(object sender, EventArgs e)
        {
            dataGridReset();
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)doctorChart.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                mySqlDataAdapter.Update(changes);
                ((DataTable)doctorChart.DataSource).AcceptChanges();
            }
        }

        private void dataGridReset()
        {
            connection.Open();

            mySqlDataAdapter = new MySqlDataAdapter("select d.dNo as No, d.dName as 이름, dp.dpName as 진료과, d.dReginum as 주민번호, d.dAddr as 주소, d.dPhone as 전화번호 from doctor as d join department as dp on d.dDepart = dp.dpNo", connection);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            doctorChart.DataSource = DS.Tables[0];

            //진료과 선택 콤보박스에 현재 존재하는 진료과를 표시
            var query = "SELECT dpName FROM department";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dDepart.Items.Add(reader.GetString("dpName"));
                    }
                }
            }

            connection.Close();
        }

        private void doctorChart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dNo.Text = doctorChart.Rows[e.RowIndex].Cells[0].Value.ToString();
            dName.Text = doctorChart.Rows[e.RowIndex].Cells[1].Value.ToString();
            dDepart.Text = doctorChart.Rows[e.RowIndex].Cells[2].Value.ToString();
            dRegiNo.Text = doctorChart.Rows[e.RowIndex].Cells[3].Value.ToString();
            dAddress.Text = doctorChart.Rows[e.RowIndex].Cells[4].Value.ToString();
            dPhone.Text = doctorChart.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void doctorChart_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            doctorChart.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.Automatic;
        }
    }
}
