namespace FinTest
{
    partial class MediRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mediChart = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Department = new System.Windows.Forms.ComboBox();
            this.pPhoneSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dNameSearch = new System.Windows.Forms.TextBox();
            this.pNameSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mediChart
            // 
            this.mediChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediChart.Location = new System.Drawing.Point(9, 231);
            this.mediChart.Name = "mediChart";
            this.mediChart.RowTemplate.Height = 27;
            this.mediChart.Size = new System.Drawing.Size(609, 121);
            this.mediChart.TabIndex = 10;
            this.mediChart.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mediChart_ColumnHeaderMouseClick);
            this.mediChart.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.mediChart_RowValidated);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.Department);
            this.panel1.Controls.Add(this.pPhoneSearch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dNameSearch);
            this.panel1.Controls.Add(this.pNameSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mediChart);
            this.panel1.Location = new System.Drawing.Point(10, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 366);
            this.panel1.TabIndex = 11;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // Department
            // 
            this.Department.FormattingEnabled = true;
            this.Department.Location = new System.Drawing.Point(411, 29);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(198, 23);
            this.Department.TabIndex = 15;
            this.Department.DropDown += new System.EventHandler(this.Department_DropDown);
            this.Department.SelectedIndexChanged += new System.EventHandler(this.Department_SelectedIndexChanged);
            // 
            // pPhoneSearch
            // 
            this.pPhoneSearch.Location = new System.Drawing.Point(411, 166);
            this.pPhoneSearch.Name = "pPhoneSearch";
            this.pPhoneSearch.Size = new System.Drawing.Size(198, 25);
            this.pPhoneSearch.TabIndex = 13;
            this.pPhoneSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pPhoneSearch_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "연락처";
            // 
            // dNameSearch
            // 
            this.dNameSearch.Location = new System.Drawing.Point(411, 116);
            this.dNameSearch.Name = "dNameSearch";
            this.dNameSearch.Size = new System.Drawing.Size(198, 25);
            this.dNameSearch.TabIndex = 14;
            this.dNameSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dNameSearch_KeyUp);
            // 
            // pNameSearch
            // 
            this.pNameSearch.Location = new System.Drawing.Point(411, 71);
            this.pNameSearch.Name = "pNameSearch";
            this.pNameSearch.Size = new System.Drawing.Size(198, 25);
            this.pNameSearch.TabIndex = 14;
            this.pNameSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pNameSearch_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "담당의";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "진료과";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "이름";
            // 
            // MediRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 460);
            this.Controls.Add(this.panel1);
            this.Name = "MediRecord";
            this.Text = "Medical Record";
            ((System.ComponentModel.ISupportInitialize)(this.mediChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView mediChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox pNameSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dNameSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pPhoneSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Department;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}