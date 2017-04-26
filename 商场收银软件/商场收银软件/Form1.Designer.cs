namespace 商场收银软件
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.bntOk = new System.Windows.Forms.Button();
            this.labelNum = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.bntCancel = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.labelCal = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(23, 25);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(52, 15);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "单价：";
            this.labelPrice.Click += new System.EventHandler(this.labelPrice_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(95, 20);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(117, 25);
            this.txtPrice.TabIndex = 1;
            // 
            // bntOk
            // 
            this.bntOk.Location = new System.Drawing.Point(227, 21);
            this.bntOk.Name = "bntOk";
            this.bntOk.Size = new System.Drawing.Size(75, 23);
            this.bntOk.TabIndex = 2;
            this.bntOk.Text = "确定";
            this.bntOk.UseVisualStyleBackColor = true;
            this.bntOk.Click += new System.EventHandler(this.bntOk_Click);
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(23, 67);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(52, 15);
            this.labelNum.TabIndex = 3;
            this.labelNum.Text = "数量：";
            this.labelNum.Click += new System.EventHandler(this.labelNum_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(95, 62);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(117, 25);
            this.txtNum.TabIndex = 4;
            // 
            // bntCancel
            // 
            this.bntCancel.Location = new System.Drawing.Point(227, 63);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(75, 23);
            this.bntCancel.TabIndex = 5;
            this.bntCancel.Text = "重置";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(26, 309);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(52, 15);
            this.labelSum.TabIndex = 7;
            this.labelSum.Text = "总计：";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(109, 309);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 30);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "0.0";
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.ItemHeight = 15;
            this.lbxList.Location = new System.Drawing.Point(26, 145);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(276, 139);
            this.lbxList.TabIndex = 9;
            this.lbxList.SelectedIndexChanged += new System.EventHandler(this.lbxList_SelectedIndexChanged_1);
            // 
            // labelCal
            // 
            this.labelCal.AutoSize = true;
            this.labelCal.Location = new System.Drawing.Point(10, 101);
            this.labelCal.Name = "labelCal";
            this.labelCal.Size = new System.Drawing.Size(82, 15);
            this.labelCal.TabIndex = 10;
            this.labelCal.Text = "计算方式：";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(95, 101);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(117, 23);
            this.cbxType.TabIndex = 11;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 365);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.labelCal);
            this.Controls.Add(this.lbxList);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.bntOk);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.labelPrice);
            this.Name = "Form1";
            this.Text = "商场收银系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button bntOk;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.Label labelCal;
        private System.Windows.Forms.ComboBox cbxType;

    }
}

