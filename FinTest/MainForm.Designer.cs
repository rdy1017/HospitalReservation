namespace FinTest
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pName = new System.Windows.Forms.TextBox();
            this.pRegiNo = new System.Windows.Forms.TextBox();
            this.pAddress = new System.Windows.Forms.TextBox();
            this.pPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DocList = new System.Windows.Forms.ListBox();
            this.Book = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Department = new System.Windows.Forms.ComboBox();
            this.bookChart = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.PatientInfo = new System.Windows.Forms.Label();
            this.DoctorInfo = new System.Windows.Forms.Label();
            this.DepartInfo = new System.Windows.Forms.Label();
            this.MediRecord = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(50, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(14, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "주민번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(50, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "주소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(32, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "연락처";
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(114, 58);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(198, 25);
            this.pName.TabIndex = 5;
            this.pName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pName_MouseClick);
            // 
            // pRegiNo
            // 
            this.pRegiNo.Enabled = false;
            this.pRegiNo.Location = new System.Drawing.Point(114, 104);
            this.pRegiNo.Name = "pRegiNo";
            this.pRegiNo.Size = new System.Drawing.Size(198, 25);
            this.pRegiNo.TabIndex = 5;
            // 
            // pAddress
            // 
            this.pAddress.Enabled = false;
            this.pAddress.Location = new System.Drawing.Point(114, 147);
            this.pAddress.Multiline = true;
            this.pAddress.Name = "pAddress";
            this.pAddress.Size = new System.Drawing.Size(198, 61);
            this.pAddress.TabIndex = 5;
            // 
            // pPhone
            // 
            this.pPhone.Enabled = false;
            this.pPhone.Location = new System.Drawing.Point(114, 224);
            this.pPhone.Name = "pPhone";
            this.pPhone.Size = new System.Drawing.Size(198, 25);
            this.pPhone.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(372, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "의사명";
            // 
            // DocList
            // 
            this.DocList.FormattingEnabled = true;
            this.DocList.ItemHeight = 15;
            this.DocList.Location = new System.Drawing.Point(376, 61);
            this.DocList.Name = "DocList";
            this.DocList.Size = new System.Drawing.Size(234, 124);
            this.DocList.TabIndex = 7;
            // 
            // Book
            // 
            this.Book.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Book.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Book.Location = new System.Drawing.Point(376, 212);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(110, 40);
            this.Book.TabIndex = 8;
            this.Book.Text = "접수하기";
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cancel.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Cancel.Location = new System.Drawing.Point(500, 212);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(110, 40);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "취소하기";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Department);
            this.panel1.Controls.Add(this.bookChart);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.Book);
            this.panel1.Controls.Add(this.DocList);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pPhone);
            this.panel1.Controls.Add(this.pAddress);
            this.panel1.Controls.Add(this.pRegiNo);
            this.panel1.Controls.Add(this.pName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 407);
            this.panel1.TabIndex = 9;
            // 
            // Department
            // 
            this.Department.FormattingEnabled = true;
            this.Department.Location = new System.Drawing.Point(114, 16);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(198, 23);
            this.Department.TabIndex = 10;
            this.Department.DropDown += new System.EventHandler(this.Department_DropDown);
            this.Department.SelectedIndexChanged += new System.EventHandler(this.Department_SelectedIndexChanged);
            // 
            // bookChart
            // 
            this.bookChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookChart.Location = new System.Drawing.Point(23, 273);
            this.bookChart.Name = "bookChart";
            this.bookChart.RowTemplate.Height = 27;
            this.bookChart.Size = new System.Drawing.Size(587, 121);
            this.bookChart.TabIndex = 9;
            this.bookChart.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bookChart_ColumnHeaderMouseClick);
            this.bookChart.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookChart_RowValidated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(32, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "진료과";
            // 
            // PatientInfo
            // 
            this.PatientInfo.AutoSize = true;
            this.PatientInfo.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PatientInfo.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.PatientInfo.Location = new System.Drawing.Point(182, 42);
            this.PatientInfo.Name = "PatientInfo";
            this.PatientInfo.Size = new System.Drawing.Size(88, 24);
            this.PatientInfo.TabIndex = 11;
            this.PatientInfo.Text = "환자 정보";
            this.PatientInfo.Click += new System.EventHandler(this.PatientInfo_Click);
            this.PatientInfo.MouseEnter += new System.EventHandler(this.PatientInfo_MouseEnter);
            this.PatientInfo.MouseLeave += new System.EventHandler(this.PatientInfo_MouseLeave);
            // 
            // DoctorInfo
            // 
            this.DoctorInfo.AutoSize = true;
            this.DoctorInfo.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DoctorInfo.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.DoctorInfo.Location = new System.Drawing.Point(297, 42);
            this.DoctorInfo.Name = "DoctorInfo";
            this.DoctorInfo.Size = new System.Drawing.Size(88, 24);
            this.DoctorInfo.TabIndex = 11;
            this.DoctorInfo.Text = "의사 정보";
            this.DoctorInfo.Click += new System.EventHandler(this.DoctorInfo_Click);
            this.DoctorInfo.MouseEnter += new System.EventHandler(this.DoctorInfo_MouseEnter);
            this.DoctorInfo.MouseLeave += new System.EventHandler(this.DoctorInfo_MouseLeave);
            // 
            // DepartInfo
            // 
            this.DepartInfo.AutoSize = true;
            this.DepartInfo.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DepartInfo.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.DepartInfo.Location = new System.Drawing.Point(410, 42);
            this.DepartInfo.Name = "DepartInfo";
            this.DepartInfo.Size = new System.Drawing.Size(106, 24);
            this.DepartInfo.TabIndex = 11;
            this.DepartInfo.Text = "진료과 정보";
            this.DepartInfo.Click += new System.EventHandler(this.DepartInfo_Click);
            this.DepartInfo.MouseEnter += new System.EventHandler(this.DepartInfo_MouseEnter);
            this.DepartInfo.MouseLeave += new System.EventHandler(this.DepartInfo_MouseLeave);
            // 
            // MediRecord
            // 
            this.MediRecord.AutoSize = true;
            this.MediRecord.Font = new System.Drawing.Font("함초롬돋움 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MediRecord.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.MediRecord.Location = new System.Drawing.Point(542, 42);
            this.MediRecord.Name = "MediRecord";
            this.MediRecord.Size = new System.Drawing.Size(82, 24);
            this.MediRecord.TabIndex = 11;
            this.MediRecord.Text = "진료기록";
            this.MediRecord.Click += new System.EventHandler(this.MediRecord_Click);
            this.MediRecord.MouseEnter += new System.EventHandler(this.MediRecord_MouseEnter);
            this.MediRecord.MouseLeave += new System.EventHandler(this.MediRecord_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 499);
            this.Controls.Add(this.MediRecord);
            this.Controls.Add(this.DepartInfo);
            this.Controls.Add(this.DoctorInfo);
            this.Controls.Add(this.PatientInfo);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.TextBox pRegiNo;
        private System.Windows.Forms.TextBox pAddress;
        private System.Windows.Forms.TextBox pPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox DocList;
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView bookChart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Department;
        private System.Windows.Forms.Label PatientInfo;
        private System.Windows.Forms.Label DoctorInfo;
        private System.Windows.Forms.Label DepartInfo;
        private System.Windows.Forms.Label MediRecord;
    }
}

