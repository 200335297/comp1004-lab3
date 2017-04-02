namespace Assignment4
{
    partial class OrderForm
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
            this.menuStrip_order = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_manufacturer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_platform = new System.Windows.Forms.TextBox();
            this.txt_condition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_webcam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_gpuType = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_OS = new System.Windows.Forms.TextBox();
            this.txt_HDD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cpuSpeed = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cpuNumber = new System.Windows.Forms.TextBox();
            this.txt_lcdSize = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cpuType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cpuBrand = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_memory = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_finish = new System.Windows.Forms.Button();
            this.menuStrip_order.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PriceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_order
            // 
            this.menuStrip_order.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip_order.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_order.Name = "menuStrip_order";
            this.menuStrip_order.Size = new System.Drawing.Size(687, 24);
            this.menuStrip_order.TabIndex = 14;
            this.menuStrip_order.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.label5);
            this.ProductInfoGroupBox.Controls.Add(this.label7);
            this.ProductInfoGroupBox.Controls.Add(this.txt_manufacturer);
            this.ProductInfoGroupBox.Controls.Add(this.label4);
            this.ProductInfoGroupBox.Controls.Add(this.txt_model);
            this.ProductInfoGroupBox.Controls.Add(this.txt_platform);
            this.ProductInfoGroupBox.Controls.Add(this.txt_condition);
            this.ProductInfoGroupBox.Controls.Add(this.label2);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(12, 44);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(409, 76);
            this.ProductInfoGroupBox.TabIndex = 21;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Manufacturer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Model";
            // 
            // txt_manufacturer
            // 
            this.txt_manufacturer.Location = new System.Drawing.Point(78, 45);
            this.txt_manufacturer.Name = "txt_manufacturer";
            this.txt_manufacturer.ReadOnly = true;
            this.txt_manufacturer.Size = new System.Drawing.Size(100, 20);
            this.txt_manufacturer.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Platform";
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(249, 45);
            this.txt_model.Name = "txt_model";
            this.txt_model.ReadOnly = true;
            this.txt_model.Size = new System.Drawing.Size(148, 20);
            this.txt_model.TabIndex = 15;
            // 
            // txt_platform
            // 
            this.txt_platform.Location = new System.Drawing.Point(249, 19);
            this.txt_platform.Name = "txt_platform";
            this.txt_platform.ReadOnly = true;
            this.txt_platform.Size = new System.Drawing.Size(148, 20);
            this.txt_platform.TabIndex = 9;
            // 
            // txt_condition
            // 
            this.txt_condition.Location = new System.Drawing.Point(78, 19);
            this.txt_condition.Name = "txt_condition";
            this.txt_condition.ReadOnly = true;
            this.txt_condition.Size = new System.Drawing.Size(100, 20);
            this.txt_condition.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Condition";
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.label14);
            this.TechSpecsGroupBox.Controls.Add(this.txt_webcam);
            this.TechSpecsGroupBox.Controls.Add(this.label6);
            this.TechSpecsGroupBox.Controls.Add(this.label15);
            this.TechSpecsGroupBox.Controls.Add(this.txt_gpuType);
            this.TechSpecsGroupBox.Controls.Add(this.label16);
            this.TechSpecsGroupBox.Controls.Add(this.txt_OS);
            this.TechSpecsGroupBox.Controls.Add(this.txt_HDD);
            this.TechSpecsGroupBox.Controls.Add(this.label11);
            this.TechSpecsGroupBox.Controls.Add(this.txt_cpuSpeed);
            this.TechSpecsGroupBox.Controls.Add(this.label12);
            this.TechSpecsGroupBox.Controls.Add(this.txt_cpuNumber);
            this.TechSpecsGroupBox.Controls.Add(this.txt_lcdSize);
            this.TechSpecsGroupBox.Controls.Add(this.label13);
            this.TechSpecsGroupBox.Controls.Add(this.label10);
            this.TechSpecsGroupBox.Controls.Add(this.txt_cpuType);
            this.TechSpecsGroupBox.Controls.Add(this.label9);
            this.TechSpecsGroupBox.Controls.Add(this.txt_cpuBrand);
            this.TechSpecsGroupBox.Controls.Add(this.label8);
            this.TechSpecsGroupBox.Controls.Add(this.txt_memory);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(12, 135);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(409, 197);
            this.TechSpecsGroupBox.TabIndex = 22;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(196, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "WebCam";
            // 
            // txt_webcam
            // 
            this.txt_webcam.Location = new System.Drawing.Point(249, 45);
            this.txt_webcam.Name = "txt_webcam";
            this.txt_webcam.ReadOnly = true;
            this.txt_webcam.Size = new System.Drawing.Size(148, 20);
            this.txt_webcam.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "OS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "GPU Type";
            // 
            // txt_gpuType
            // 
            this.txt_gpuType.Location = new System.Drawing.Point(78, 138);
            this.txt_gpuType.Name = "txt_gpuType";
            this.txt_gpuType.ReadOnly = true;
            this.txt_gpuType.Size = new System.Drawing.Size(319, 20);
            this.txt_gpuType.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(212, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "HDD";
            // 
            // txt_OS
            // 
            this.txt_OS.Location = new System.Drawing.Point(78, 164);
            this.txt_OS.Name = "txt_OS";
            this.txt_OS.ReadOnly = true;
            this.txt_OS.Size = new System.Drawing.Size(319, 20);
            this.txt_OS.TabIndex = 13;
            // 
            // txt_HDD
            // 
            this.txt_HDD.Location = new System.Drawing.Point(249, 19);
            this.txt_HDD.Name = "txt_HDD";
            this.txt_HDD.ReadOnly = true;
            this.txt_HDD.Size = new System.Drawing.Size(148, 20);
            this.txt_HDD.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "CPU Speed";
            // 
            // txt_cpuSpeed
            // 
            this.txt_cpuSpeed.Location = new System.Drawing.Point(78, 97);
            this.txt_cpuSpeed.Name = "txt_cpuSpeed";
            this.txt_cpuSpeed.ReadOnly = true;
            this.txt_cpuSpeed.Size = new System.Drawing.Size(72, 20);
            this.txt_cpuSpeed.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "CPU Number";
            // 
            // txt_cpuNumber
            // 
            this.txt_cpuNumber.Location = new System.Drawing.Point(78, 71);
            this.txt_cpuNumber.Name = "txt_cpuNumber";
            this.txt_cpuNumber.ReadOnly = true;
            this.txt_cpuNumber.Size = new System.Drawing.Size(72, 20);
            this.txt_cpuNumber.TabIndex = 25;
            // 
            // txt_lcdSize
            // 
            this.txt_lcdSize.Location = new System.Drawing.Point(249, 71);
            this.txt_lcdSize.Name = "txt_lcdSize";
            this.txt_lcdSize.ReadOnly = true;
            this.txt_lcdSize.Size = new System.Drawing.Size(148, 20);
            this.txt_lcdSize.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(192, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "LCD Size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "CPU Type";
            // 
            // txt_cpuType
            // 
            this.txt_cpuType.Location = new System.Drawing.Point(78, 45);
            this.txt_cpuType.Name = "txt_cpuType";
            this.txt_cpuType.ReadOnly = true;
            this.txt_cpuType.Size = new System.Drawing.Size(72, 20);
            this.txt_cpuType.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "CPU Brand";
            // 
            // txt_cpuBrand
            // 
            this.txt_cpuBrand.Location = new System.Drawing.Point(78, 19);
            this.txt_cpuBrand.Name = "txt_cpuBrand";
            this.txt_cpuBrand.ReadOnly = true;
            this.txt_cpuBrand.Size = new System.Drawing.Size(72, 20);
            this.txt_cpuBrand.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Memory";
            // 
            // txt_memory
            // 
            this.txt_memory.Location = new System.Drawing.Point(249, 97);
            this.txt_memory.Name = "txt_memory";
            this.txt_memory.ReadOnly = true;
            this.txt_memory.Size = new System.Drawing.Size(148, 20);
            this.txt_memory.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Assignment4.Properties.Resources.comp21;
            this.pictureBox1.Location = new System.Drawing.Point(450, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.txt_total);
            this.PriceGroupBox.Controls.Add(this.label17);
            this.PriceGroupBox.Controls.Add(this.txt_tax);
            this.PriceGroupBox.Controls.Add(this.label1);
            this.PriceGroupBox.Controls.Add(this.txt_cost);
            this.PriceGroupBox.Controls.Add(this.label3);
            this.PriceGroupBox.Location = new System.Drawing.Point(450, 183);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(226, 114);
            this.PriceGroupBox.TabIndex = 28;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Your Price";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(120, 88);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Total";
            // 
            // txt_tax
            // 
            this.txt_tax.Location = new System.Drawing.Point(120, 46);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.ReadOnly = true;
            this.txt_tax.Size = new System.Drawing.Size(100, 20);
            this.txt_tax.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sales Tax (13%)";
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(120, 23);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.ReadOnly = true;
            this.txt_cost.Size = new System.Drawing.Size(100, 20);
            this.txt_cost.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(427, 309);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 29;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(508, 309);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 30;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_finish
            // 
            this.btn_finish.Location = new System.Drawing.Point(589, 309);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(75, 23);
            this.btn_finish.TabIndex = 31;
            this.btn_finish.Text = "Finish";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 360);
            this.ControlBox = false;
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.menuStrip_order);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip_order.ResumeLayout(false);
            this.menuStrip_order.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PriceGroupBox.ResumeLayout(false);
            this.PriceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_order;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_manufacturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_platform;
        private System.Windows.Forms.TextBox txt_condition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_webcam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_gpuType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_OS;
        private System.Windows.Forms.TextBox txt_HDD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_cpuSpeed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_cpuNumber;
        private System.Windows.Forms.TextBox txt_lcdSize;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_cpuType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cpuBrand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_memory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_finish;
    }
}