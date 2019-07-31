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
    public partial class Department : MaterialForm
    {
        MySqlConnection connection =
        new MySqlConnection("Server=aemaeth.iptime.org;Database=CSFINAL;Uid=csuser;Pwd=tltiq;Allow User Variables=True");
        private MySqlDataAdapter mySqlDataAdapter;

        public Department()
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
            //진료과 추가
            //빈칸이 있으면 아무일도 안일어나게 함
            if (dpName.Text == null || dpLocate.Text == null || dpPhone.Text == null)
            {
                MessageBox.Show("정보를 모두 입력해주세요.");
                return;
            }

            else
            {
                //칼럼에 추가하는 커리문 insertQuery
                string insertQuery = "INSERT INTO department(dpName, dpLocate, dpPhone) VALUES('" + dpName.Text + "','" + dpLocate.Text + "','" + dpPhone.Text + "')";

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
            //진료과 수정
            //빈칸이 있으면 아무일도 안일어나게 함
            if (dpName.Text == null || dpLocate.Text == null || dpPhone.Text == null)
            {
                MessageBox.Show("정보를 모두 입력해주세요.");
                return;
            }
            else
            {
                //칼럼 수정 커리문 updateQuery
                string updateQuery = "UPDATE department SET dpName='" + dpName.Text + "', dpLocate='" + dpLocate.Text +  "', dpPhone='" + dpPhone.Text + "' WHERE dpNo='" + dpNo.Text + "'";

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
            //진료과 삭제
            //칼럼 수정 커리문 deleteQuery
            string deleteQuery = "Delete FROM department WHERE dNo='" + dpNo.Text + "'";

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

        private void Department_Load(object sender, EventArgs e)
        {
            dataGridReset();
        }

        private void departChart_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)departChart.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                mySqlDataAdapter.Update(changes);
                ((DataTable)departChart.DataSource).AcceptChanges();
            }
        }

        private void dataGridReset()
        {
            connection.Open();

            mySqlDataAdapter = new MySqlDataAdapter("select dpNo as No, dpName as 진료과명, dpLocate as 위치, dpPhone as 전화번호 from department", connection);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            departChart.DataSource = DS.Tables[0];

            connection.Close();
        }

        private void departChart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dpNo.Text = departChart.Rows[e.RowIndex].Cells[0].Value.ToString();
            dpName.Text = departChart.Rows[e.RowIndex].Cells[1].Value.ToString();
            dpLocate.Text = departChart.Rows[e.RowIndex].Cells[2].Value.ToString();
            dpPhone.Text = departChart.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void departChart_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            departChart.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.Automatic;
        }
    }
}
