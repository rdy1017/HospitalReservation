namespace FinTest
{
    partial class Department
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
            this.dpNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dpPhone = new System.Windows.Forms.TextBox();
            this.dpLocate = new System.Windows.Forms.TextBox();
            this.dpName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departChart = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.dpNo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dpPhone);
            this.panel1.Controls.Add(this.dpLocate);
            this.panel1.Controls.Add(this.dpName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.departChart);
            this.panel1.Location = new System.Drawing.Point(8, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 383);
            this.panel1.TabIndex = 2;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Delete.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Delete.Location = new System.Drawing.Point(655, 317);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 35);
            this.Delete.TabIndex = 21;
            this.Delete.Text = "삭제";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Edit.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Edit.Location = new System.Drawing.Point(546, 317);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 35);
            this.Edit.TabIndex = 22;
            this.Edit.Text = "수정";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Add.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Add.Location = new System.Drawing.Point(439, 317);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 35);
            this.Add.TabIndex = 23;
            this.Add.Text = "추가";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dpNo
            // 
            this.dpNo.AutoSize = true;
            this.dpNo.Location = new System.Drawing.Point(529, 31);
            this.dpNo.Name = "dpNo";
            this.dpNo.Size = new System.Drawing.Size(0, 15);
            this.dpNo.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(468, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "번호";
            // 
            // dpPhone
            // 
            this.dpPhone.Location = new System.Drawing.Point(532, 176);
            this.dpPhone.Name = "dpPhone";
            this.dpPhone.Size = new System.Drawing.Size(198, 25);
            this.dpPhone.TabIndex = 10;
            // 
            // dpLocate
            // 
            this.dpLocate.Location = new System.Drawing.Point(532, 126);
            this.dpLocate.Name = "dpLocate";
            this.dpLocate.Size = new System.Drawing.Size(198, 25);
            this.dpLocate.TabIndex = 11;
            // 
            // dpName
            // 
            this.dpName.Location = new System.Drawing.Point(532, 75);
            this.dpName.Name = "dpName";
            this.dpName.Size = new System.Drawing.Size(198, 25);
            this.dpName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(452, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "연락처";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(468, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "위치";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("함초롬바탕 확장", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(436, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "진료과명";
            // 
            // departChart
            // 
            this.departChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departChart.Location = new System.Drawing.Point(5, 4);
            this.departChart.Name = "departChart";
            this.departChart.RowTemplate.Height = 27;
            this.departChart.Size = new System.Drawing.Size(385, 370);
            this.departChart.TabIndex = 0;
            this.departChart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.departChart_CellClick);
            this.departChart.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.departChart_ColumnHeaderMouseClick);
            this.departChart.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.departChart_RowValidated);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panel1);
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox dpPhone;
        private System.Windows.Forms.TextBox dpLocate;
        private System.Windows.Forms.TextBox dpName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView departChart;
        private System.Windows.Forms.Label dpNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
    }
}