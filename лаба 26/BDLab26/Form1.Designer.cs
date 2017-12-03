namespace BDLab26
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.SValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.SDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.VDiscount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.VPhoneNumber = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.VFIO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.VDate = new System.Windows.Forms.DateTimePicker();
            this.VMaster = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VVisitor = new System.Windows.Forms.ComboBox();
            this.VService = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.FindVisitor = new System.Windows.Forms.Button();
            this.ServiceMoreThenThis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.MasterForFind = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.Avg = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SValue)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 387);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.SValue);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.SDescription);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SName);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Service";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Value";
            // 
            // SValue
            // 
            this.SValue.Location = new System.Drawing.Point(479, 223);
            this.SValue.Name = "SValue";
            this.SValue.Size = new System.Drawing.Size(120, 20);
            this.SValue.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // SDescription
            // 
            this.SDescription.Location = new System.Drawing.Point(313, 224);
            this.SDescription.Name = "SDescription";
            this.SDescription.Size = new System.Drawing.Size(100, 20);
            this.SDescription.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // SName
            // 
            this.SName.Location = new System.Drawing.Point(128, 223);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(100, 20);
            this.SName.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.VDiscount);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.VPhoneNumber);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.VFIO);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visitors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Discount";
            // 
            // VDiscount
            // 
            this.VDiscount.Location = new System.Drawing.Point(606, 204);
            this.VDiscount.Name = "VDiscount";
            this.VDiscount.Size = new System.Drawing.Size(120, 20);
            this.VDiscount.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "PhoneNumber";
            // 
            // VPhoneNumber
            // 
            this.VPhoneNumber.Location = new System.Drawing.Point(400, 204);
            this.VPhoneNumber.Name = "VPhoneNumber";
            this.VPhoneNumber.Size = new System.Drawing.Size(120, 20);
            this.VPhoneNumber.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VFIO
            // 
            this.VFIO.Location = new System.Drawing.Point(185, 204);
            this.VFIO.Name = "VFIO";
            this.VFIO.Size = new System.Drawing.Size(100, 20);
            this.VFIO.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "FIO";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(863, 177);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.Avg);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.MasterForFind);
            this.tabPage3.Controls.Add(this.FindVisitor);
            this.tabPage3.Controls.Add(this.ServiceMoreThenThis);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.VDate);
            this.tabPage3.Controls.Add(this.VMaster);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.VVisitor);
            this.tabPage3.Controls.Add(this.VService);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(983, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Visits";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // VDate
            // 
            this.VDate.Location = new System.Drawing.Point(608, 183);
            this.VDate.Name = "VDate";
            this.VDate.Size = new System.Drawing.Size(200, 20);
            this.VDate.TabIndex = 8;
            // 
            // VMaster
            // 
            this.VMaster.Location = new System.Drawing.Point(476, 183);
            this.VMaster.Name = "VMaster";
            this.VMaster.Size = new System.Drawing.Size(100, 20);
            this.VMaster.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(431, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Master";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Visitor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Service";
            // 
            // VVisitor
            // 
            this.VVisitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VVisitor.FormattingEnabled = true;
            this.VVisitor.Location = new System.Drawing.Point(304, 182);
            this.VVisitor.Name = "VVisitor";
            this.VVisitor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VVisitor.Size = new System.Drawing.Size(121, 21);
            this.VVisitor.TabIndex = 3;
            // 
            // VService
            // 
            this.VService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VService.FormattingEnabled = true;
            this.VService.Location = new System.Drawing.Point(136, 180);
            this.VService.Name = "VService";
            this.VService.Size = new System.Drawing.Size(121, 21);
            this.VService.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(877, 171);
            this.dataGridView3.TabIndex = 0;
            // 
            // FindVisitor
            // 
            this.FindVisitor.Location = new System.Drawing.Point(266, 218);
            this.FindVisitor.Name = "FindVisitor";
            this.FindVisitor.Size = new System.Drawing.Size(75, 23);
            this.FindVisitor.TabIndex = 13;
            this.FindVisitor.Text = "Find";
            this.FindVisitor.UseVisualStyleBackColor = true;
            this.FindVisitor.Click += new System.EventHandler(this.FindVisitor_Click);
            // 
            // ServiceMoreThenThis
            // 
            this.ServiceMoreThenThis.Location = new System.Drawing.Point(145, 220);
            this.ServiceMoreThenThis.Name = "ServiceMoreThenThis";
            this.ServiceMoreThenThis.Size = new System.Drawing.Size(100, 20);
            this.ServiceMoreThenThis.TabIndex = 12;
            this.ServiceMoreThenThis.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Service more then this";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Find Visitor with Max Discount";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // MasterForFind
            // 
            this.MasterForFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MasterForFind.FormattingEnabled = true;
            this.MasterForFind.Location = new System.Drawing.Point(67, 252);
            this.MasterForFind.Name = "MasterForFind";
            this.MasterForFind.Size = new System.Drawing.Size(121, 21);
            this.MasterForFind.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Master";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(223, 250);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "ServiceByThisMasterToday";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Average";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(232, 286);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(223, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Masters with average price more then this";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Avg
            // 
            this.Avg.Location = new System.Drawing.Point(100, 288);
            this.Avg.Name = "Avg";
            this.Avg.Size = new System.Drawing.Size(100, 20);
            this.Avg.TabIndex = 19;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 325);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 20;
            this.button7.Text = "Visits count";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 387);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SValue)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox SName;
        public System.Windows.Forms.NumericUpDown SValue;
        public System.Windows.Forms.TextBox SDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.NumericUpDown VDiscount;
        public System.Windows.Forms.NumericUpDown VPhoneNumber;
        public System.Windows.Forms.TextBox VFIO;
        public System.Windows.Forms.DateTimePicker VDate;
        public System.Windows.Forms.TextBox VMaster;
        public System.Windows.Forms.ComboBox VVisitor;
        public System.Windows.Forms.ComboBox VService;
        private System.Windows.Forms.Button FindVisitor;
        public System.Windows.Forms.TextBox ServiceMoreThenThis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox MasterForFind;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox Avg;
        private System.Windows.Forms.Button button7;
    }
}

