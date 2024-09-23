namespace Test
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxX = new System.Windows.Forms.TextBox();
            this.tboxY = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.dgStatus = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(447, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 900);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // tboxX
            // 
            this.tboxX.Location = new System.Drawing.Point(31, 234);
            this.tboxX.Name = "tboxX";
            this.tboxX.Size = new System.Drawing.Size(121, 28);
            this.tboxX.TabIndex = 0;
            // 
            // tboxY
            // 
            this.tboxY.Location = new System.Drawing.Point(31, 268);
            this.tboxY.Name = "tboxY";
            this.tboxY.Size = new System.Drawing.Size(121, 28);
            this.tboxY.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(178, 234);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(78, 62);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "button1";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cboxType
            // 
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Items.AddRange(new object[] {
            "InterFace",
            "Normal",
            "Turn",
            "Long_1",
            "Long_2"});
            this.cboxType.Location = new System.Drawing.Point(31, 178);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(121, 26);
            this.cboxType.TabIndex = 2;
            // 
            // tboxID
            // 
            this.tboxID.Location = new System.Drawing.Point(31, 302);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(121, 28);
            this.tboxID.TabIndex = 3;
            // 
            // dgStatus
            // 
            this.dgStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Type});
            this.dgStatus.Location = new System.Drawing.Point(12, 467);
            this.dgStatus.Name = "dgStatus";
            this.dgStatus.RowHeadersWidth = 62;
            this.dgStatus.RowTemplate.Height = 30;
            this.dgStatus.Size = new System.Drawing.Size(365, 456);
            this.dgStatus.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 1024);
            this.Controls.Add(this.dgStatus);
            this.Controls.Add(this.tboxID);
            this.Controls.Add(this.cboxType);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tboxY);
            this.Controls.Add(this.tboxX);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tboxX;
        private System.Windows.Forms.TextBox tboxY;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.ComboBox cboxType;
        private System.Windows.Forms.TextBox tboxID;
        private System.Windows.Forms.DataGridView dgStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}

