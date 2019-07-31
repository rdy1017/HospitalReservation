namespace FinTest
{
    partial class Patient
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
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.pPhone = new System.Windows.Forms.TextBox();
            this.pAddress = new System.Windows.Forms.TextBox();
            this.pRegiNo = new System.Windows.Forms.TextBox();
            this.pName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.patientChart = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Delete.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Delete.Location = new System.Drawing.Point(654, 304);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 35);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "삭제";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Edit.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Edit.Location = new System.Drawing.Point(545, 304);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 35);
            this.Edit.TabIndex = 14;
            this.Edit.Text = "수정";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Add.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Add.Location = new System.Drawing.Point(438, 304);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 35);
            this.Add.TabIndex = 14;
            this.Add.Text = "추가";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // pPhone
            // 
            this.pPhone.Location = new System.Drawing.Point(531, 241);
            this.pPhone.Name = "pPhone";
            this.pPhone.Size = new System.Drawing.Size(198, 25);
            this.pPhone.TabIndex = 10;
            // 
            // pAddress
            // 
            this.pAddress.Location = new System.Drawing.Point(531, 158);
            this.pAddress.Multiline = true;
            this.pAddress.Name = "pAddress";
            this.pAddress.Size = new System.Drawing.Size(198, 61);
            this.pAddress.TabIndex = 11;
            // 
            // pRegiNo
            // 
            this.pRegiNo.Location = new System.Drawing.Point(531, 110);
            this.pRegiNo.Name = "pRegiNo";
            this.pRegiNo.Size = new System.Drawing.Size(198, 25);
            this.pRegiNo.TabIndex = 12;
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(531, 61);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(198, 25);
            this.pName.TabIndex = 13;
            this.pName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pName_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(449, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "연락처";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(467, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(431, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "주민번호";
            // 
            // patientChart
            // 
            this.patientChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientChart.Location = new System.Drawing.Point(5, 4);
            this.patientChart.Name = "patientChart";
            this.patientChart.RowTemplate.Height = 27;
            this.patientChart.Size = new System.Drawing.Size(385, 370);
            this.patientChart.TabIndex = 0;
            this.patientChart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientChart_CellClick);
            this.patientChart.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientChart_CellContentDoubleClick);
            this.patientChart.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.patientChart_ColumnHeaderMouseClick);
            this.patientChart.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(467, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "이름";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.pPhone);
            this.panel1.Controls.Add(this.pAddress);
            this.panel1.Controls.Add(this.pRegiNo);
            this.panel1.Controls.Add(this.pName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.patientChart);
            this.panel1.Location = new System.Drawing.Point(8, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 383);
            this.panel1.TabIndex = 1;
            // 
            // pNo
            // 
            this.pNo.AutoSize = true;
            this.pNo.Location = new System.Drawing.Point(528, 22);
            this.pNo.Name = "pNo";
            this.pNo.Size = new System.Drawing.Size(0, 15);
            this.pNo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(467, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "번호";
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panel1);
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox pPhone;
        private System.Windows.Forms.TextBox pAddress;
        private System.Windows.Forms.TextBox pRegiNo;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView patientChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pNo;
        private System.Windows.Forms.Label label5;
    }
}