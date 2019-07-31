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
    public partial class MediRecord : MaterialForm
    {
        MySqlConnection connection =
        new MySqlConnection("Server=aemaeth.iptime.org;Database=CSFINAL;Uid=csuser;Pwd=tltiq;Allow User Variables=True");
        private MySqlDataAdapter mySqlDataAdapter;

        public MediRecord()
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
        }

        //날짜 선택했을때
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string selectedStartDate;
            string selectedEndDate;
            string searchToDate = "";

            if (monthCalendar1.SelectionRange.Start == monthCalendar1.SelectionRange.End)
            {
                selectedStartDate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
                searchToDate = "where DATE(mr.tDate) = '" + selectedStartDate + "'";
            }
            else
            {
                selectedStartDate = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
                selectedEndDate = monthCalendar1.SelectionRange.End.ToString("yyyy-MM-dd");
                searchToDate = "where DATE(mr.tDate) BETWEEN '" + selectedStartDate + "' AND '" + selectedEndDate + "'";
            }

            dataGridReset(searchToDate);
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
            string searchToDepart = "where dp.dpName = '" + Department.SelectedItem.ToString() + "'";

            dataGridReset(searchToDepart);
        }


        private void mediChart_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)mediChart.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                mySqlDataAdapter.Update(changes);
                ((DataTable)mediChart.DataSource).AcceptChanges();
            }
        }

        //환자이름으로 검색
        private void pNameSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string searchTopName = "where p.pName LIKE '%" + pNameSearch.Text + "%'";
            dataGridReset(searchTopName);
        }

        //의사이름으로 검색
        private void dNameSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string searchTodName = "where d.dName LIKE '%" + dNameSearch.Text + "%'";
            dataGridReset(searchTodName);
        }

        //환자연락처로 검색
        private void pPhoneSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string searchTopPhone = "where p.pPhone LIKE '%" + pPhoneSearch.Text + "%'";
            dataGridReset(searchTopPhone);
        }

        //접수목록을 갱신
        private void dataGridReset(string where)
        {
            connection.Open();

            string AddmediChart = "SELECT 접수번호, 접수날짜, 이름, 진료과, 주민번호, 주소, 전화번호, 담당의 " +
                      "FROM " +
                      "(SELECT mr.tNo AS 접수번호, mr.tDate AS 접수날짜, p.pName AS 이름, dp.dpName AS 진료과, p.pReginum AS 주민번호, p.pAddr AS 주소, p.pPhone AS 전화번호, d.dName AS 담당의 " +
                      "FROM medirecord as mr " +
                      "JOIN patient as p " +
                      "ON mr.pNo = p.pNo " +
                      "JOIN doctor as d " +
                      "ON mr.dNo = d.dNo " +
                      "JOIN department as dp " +
                      "ON mr.dpNo = dp.dpNo " +
                      where + 
                      "ORDER BY mr.tNo ASC) " +
                      "AS tbl, (SELECT @SEQ:= 0) A";

            mySqlDataAdapter = new MySqlDataAdapter(AddmediChart, connection);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            mediChart.DataSource = DS.Tables[0];

            connection.Close();
        }

        private void mediChart_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mediChart.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.Automatic;
        }
    }
}
