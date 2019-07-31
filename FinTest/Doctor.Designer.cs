namespace FinTest
{
    partial class Doctor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.dDepart = new System.Windows.Forms.ComboBox();
            this.dNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dPhone = new System.Windows.Forms.TextBox();
            this.dAddress = new System.Windows.Forms.TextBox();
            this.dRegiNo = new System.Windows.Forms.TextBox();
            this.dName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doctorChart = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.dDepart);
            this.panel1.Controls.Add(this.dNo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dPhone);
            this.panel1.Controls.Add(this.dAddress);
            this.panel1.Controls.Add(this.dRegiNo);
            this.panel1.Controls.Add(this.dName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.doctorChart);
            this.panel1.Location = new System.Drawing.Point(8, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 383);
            this.panel1.TabIndex = 1;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Delete.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Delete.Location = new System.Drawing.Point(655, 320);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 35);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "삭제";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Edit.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Edit.Location = new System.Drawing.Point(546, 320);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 35);
            this.Edit.TabIndex = 19;
            this.Edit.Text = "수정";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Add.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Add.Location = new System.Drawing.Point(439, 320);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 35);
            this.Add.TabIndex = 20;
            this.Add.Text = "추가";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dDepart
            // 
            this.dDepart.FormattingEnabled = true;
            this.dDepart.Location = new System.Drawing.Point(532, 102);
            this.dDepart.Name = "dDepart";
            this.dDepart.Size = new System.Drawing.Size(198, 23);
            this.dDepart.TabIndex = 17;
            // 
            // dNo
            // 
            this.dNo.AutoSize = true;
            this.dNo.Location = new System.Drawing.Point(529, 17);
            this.dNo.Name = "dNo";
            this.dNo.Size = new System.Drawing.Size(0, 15);
            this.dNo.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(468, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "번호";
            // 
            // dPhone
            // 
            this.dPhone.Location = new System.Drawing.Point(532, 262);
            this.dPhone.Name = "dPhone";
            this.dPhone.Size = new System.Drawing.Size(198, 25);
            this.dPhone.TabIndex = 10;
            // 
            // dAddress
            // 
            this.dAddress.Location = new System.Drawing.Point(532, 185);
            this.dAddress.Multiline = true;
            this.dAddress.Name = "dAddress";
            this.dAddress.Size = new System.Drawing.Size(198, 61);
            this.dAddress.TabIndex = 11;
            // 
            // dRegiNo
            // 
            this.dRegiNo.Location = new System.Drawing.Point(532, 142);
            this.dRegiNo.Name = "dRegiNo";
            this.dRegiNo.Size = new System.Drawing.Size(198, 25);
            this.dRegiNo.TabIndex = 12;
            // 
            // dName
            // 
            this.dName.Location = new System.Drawing.Point(532, 57);
            this.dName.Name = "dName";
            this.dName.Size = new System.Drawing.Size(198, 25);
            this.dName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(450, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "연락처";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(468, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(435, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "주민번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(453, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "진료과";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(468, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "이름";
            // 
            // doctorChart
            // 
            this.doctorChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorChart.Location = new System.Drawing.Point(5, 4);
            this.doctorChart.Name = "doctorChart";
            this.doctorChart.RowTemplate.Height = 27;
            this.doctorChart.Size = new System.Drawing.Size(385, 370);
            this.doctorChart.TabIndex = 0;
            this.doctorChart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorChart_CellClick);
            this.doctorChart.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.doctorChart_ColumnHeaderMouseClick);
            this.doctorChart.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panel1);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox dPhone;
        private System.Windows.Forms.TextBox dAddress;
        private System.Windows.Forms.TextBox dRegiNo;
        private System.Windows.Forms.TextBox dName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView doctorChart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dDepart;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
    }
}