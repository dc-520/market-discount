namespace 商场打折
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_danjia = new System.Windows.Forms.TextBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.comboBox_discount = new System.Windows.Forms.ComboBox();
            this.button_sure = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.listBox_msg = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "单价：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "计算方式：";
            // 
            // textBox_danjia
            // 
            this.textBox_danjia.Location = new System.Drawing.Point(120, 30);
            this.textBox_danjia.Name = "textBox_danjia";
            this.textBox_danjia.Size = new System.Drawing.Size(100, 21);
            this.textBox_danjia.TabIndex = 3;
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(120, 64);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(100, 21);
            this.textBox_amount.TabIndex = 4;
            // 
            // comboBox_discount
            // 
            this.comboBox_discount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_discount.FormattingEnabled = true;
            this.comboBox_discount.Items.AddRange(new object[] {
            "正常收费",
            "打8折",
            "单价满300返100"});
            this.comboBox_discount.Location = new System.Drawing.Point(120, 99);
            this.comboBox_discount.Name = "comboBox_discount";
            this.comboBox_discount.Size = new System.Drawing.Size(121, 20);
            this.comboBox_discount.TabIndex = 5;
            // 
            // button_sure
            // 
            this.button_sure.Location = new System.Drawing.Point(326, 30);
            this.button_sure.Name = "button_sure";
            this.button_sure.Size = new System.Drawing.Size(75, 23);
            this.button_sure.TabIndex = 6;
            this.button_sure.Text = "确定";
            this.button_sure.UseVisualStyleBackColor = true;
            this.button_sure.Click += new System.EventHandler(this.button_sure_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(326, 61);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 7;
            this.button_reset.Text = "重置";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // listBox_msg
            // 
            this.listBox_msg.FormattingEnabled = true;
            this.listBox_msg.ItemHeight = 12;
            this.listBox_msg.Location = new System.Drawing.Point(47, 143);
            this.listBox_msg.Name = "listBox_msg";
            this.listBox_msg.Size = new System.Drawing.Size(354, 136);
            this.listBox_msg.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "总计：";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(163, 307);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(41, 12);
            this.label_total.TabIndex = 10;
            this.label_total.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 371);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_msg);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_sure);
            this.Controls.Add(this.comboBox_discount);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.textBox_danjia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "商场收银系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_danjia;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.ComboBox comboBox_discount;
        private System.Windows.Forms.Button button_sure;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.ListBox listBox_msg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_total;
    }
}

