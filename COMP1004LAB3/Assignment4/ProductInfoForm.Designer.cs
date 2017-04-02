namespace Assignment4
{
    partial class ProductInfoForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip_productInfo = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFD_productInfo = new System.Windows.Forms.OpenFileDialog();
            this.saveFD_productInfo = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_productID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_condition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_OS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_manufacturer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_platform = new System.Windows.Forms.TextBox();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_webcam = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_gpuType = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_HDD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cpuSpeed = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cpuNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_lcdSize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cpuType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cpuBrand = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_memory = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_selectAnotherProduct = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip_productInfo.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_productInfo
            // 
            this.menuStrip_productInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip_productInfo.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_productInfo.Name = "menuStrip_productInfo";
            this.menuStrip_productInfo.Size = new System.Drawing.Size(754, 24);
            this.menuStrip_productInfo.TabIndex = 0;
            this.menuStrip_productInfo.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.selectAnotherProductToolStripMenuItem.Text = "Se&lect Another Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product ID";
            // 
            // txt_productID
            // 
            this.txt_productID.BackColor = System.Drawing.SystemColors.Control;
            this.txt_productID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_productID.Location = new System.Drawing.Point(76, 45);
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.ReadOnly = true;
            this.txt_productID.Size = new System.Drawing.Size(100, 20);
            this.txt_productID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Condition";
            // 
            // txt_condition
            // 
            this.txt_condition.BackColor = System.Drawing.SystemColors.Control;
            this.txt_condition.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_condition.Location = new System.Drawing.Point(338, 45);
            this.txt_condition.Name = "txt_condition";
            this.txt_condition.ReadOnly = true;
            this.txt_condition.Size = new System.Drawing.Size(100, 20);
            this.txt_condition.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cost";
            // 
            // txt_cost
            // 
            this.txt_cost.BackColor = System.Drawing.SystemColors.Control;
            this.txt_cost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_cost.Location = new System.Drawing.Point(568, 45);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.ReadOnly = true;
            this.txt_cost.Size = new System.Drawing.Size(100, 20);
            this.txt_cost.TabIndex = 8;
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.label7);
            this.ProductInfoGroupBox.Controls.Add(this.txt_model);
            this.ProductInfoGroupBox.Controls.Add(this.label6);
            this.ProductInfoGroupBox.Controls.Add(this.txt_OS);
            this.ProductInfoGroupBox.Controls.Add(this.label5);
            this.ProductInfoGroupBox.Controls.Add(this.txt_manufacturer);
            this.ProductInfoGroupBox.Controls.Add(this.label4);
            this.ProductInfoGroupBox.Controls.Add(this.txt_platform);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(15, 86);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(664, 73);
            this.ProductInfoGroupBox.TabIndex = 9;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Model";
            // 
            // txt_model
            // 
            this.txt_model.BackColor = System.Drawing.SystemColors.Control;
            this.txt_model.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_model.Location = new System.Drawing.Point(314, 45);
            this.txt_model.Name = "txt_model";
            this.txt_model.ReadOnly = true;
            this.txt_model.Size = new System.Drawing.Size(339, 20);
            this.txt_model.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "OS";
            // 
            // txt_OS
            // 
            this.txt_OS.BackColor = System.Drawing.SystemColors.Control;
            this.txt_OS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_OS.Location = new System.Drawing.Point(314, 19);
            this.txt_OS.Name = "txt_OS";
            this.txt_OS.ReadOnly = true;
            this.txt_OS.Size = new System.Drawing.Size(339, 20);
            this.txt_OS.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Manufacturer";
            // 
            // txt_manufacturer
            // 
            this.txt_manufacturer.BackColor = System.Drawing.SystemColors.Control;
            this.txt_manufacturer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_manufacturer.Location = new System.Drawing.Point(87, 45);
            this.txt_manufacturer.Name = "txt_manufacturer";
            this.txt_manufacturer.ReadOnly = true;
            this.txt_manufacturer.Size = new System.Drawing.Size(100, 20);
            this.txt_manufacturer.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Platform";
            // 
            // txt_platform
            // 
            this.txt_platform.BackColor = System.Drawing.SystemColors.Control;
            this.txt_platform.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_platform.Location = new System.Drawing.Point(87, 19);
            this.txt_platform.Name = "txt_platform";
            this.txt_platform.ReadOnly = true;
            this.txt_platform.Size = new System.Drawing.Size(100, 20);
            this.txt_platform.TabIndex = 9;
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.label14);
            this.TechSpecsGroupBox.Controls.Add(this.txt_webcam);
            this.TechSpecsGroupBox.Controls.Add(this.label15);
            this.TechSpecsGroupBox.Controls.Add(this.txt_gpuType);
            this.TechSpecsGroupBox.Controls.Add(this.label16);
            this.TechSpecsGroupBox.Controls.Add(this.txt_HDD);
            this.TechSpecsGroupBox.Controls.Add(this.label11);
            this.TechSpecsGroupBox.Controls.Add(this.txt_cpuSpeed);
            this.TechSpecsGroupBox.Controls.Add(this.label12);
            this.TechSpecsGroupBox.Controls.Add(this.txt_cpuNumber);
            this.TechSpecsGroupBox.Controls.Add(this.label13);
            this.TechSpecsGroupBox.Controls.Add(this.txt_lcdSize);
            this.TechSpecsGroupBox.Controls.Add(this.label10);
            this.TechSpecsGroupBox.Controls.Add(this.txt_cpuType);
            this.TechSpecsGroupBox.Controls.Add(this.label9);
            this.TechSpecsGroupBox.Controls.Add(this.txt_cpuBrand);
            this.TechSpecsGroupBox.Controls.Add(this.label8);
            this.TechSpecsGroupBox.Controls.Add(this.txt_memory);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(15, 184);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(664, 105);
            this.TechSpecsGroupBox.TabIndex = 10;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(382, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "WebCam";
            // 
            // txt_webcam
            // 
            this.txt_webcam.BackColor = System.Drawing.SystemColors.Control;
            this.txt_webcam.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_webcam.Location = new System.Drawing.Point(435, 71);
            this.txt_webcam.Name = "txt_webcam";
            this.txt_webcam.ReadOnly = true;
            this.txt_webcam.Size = new System.Drawing.Size(218, 20);
            this.txt_webcam.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(376, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "GPU Type";
            // 
            // txt_gpuType
            // 
            this.txt_gpuType.BackColor = System.Drawing.SystemColors.Control;
            this.txt_gpuType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_gpuType.Location = new System.Drawing.Point(435, 45);
            this.txt_gpuType.Name = "txt_gpuType";
            this.txt_gpuType.ReadOnly = true;
            this.txt_gpuType.Size = new System.Drawing.Size(218, 20);
            this.txt_gpuType.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(398, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "HDD";
            // 
            // txt_HDD
            // 
            this.txt_HDD.BackColor = System.Drawing.SystemColors.Control;
            this.txt_HDD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_HDD.Location = new System.Drawing.Point(435, 19);
            this.txt_HDD.Name = "txt_HDD";
            this.txt_HDD.ReadOnly = true;
            this.txt_HDD.Size = new System.Drawing.Size(218, 20);
            this.txt_HDD.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(185, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "CPU Speed";
            // 
            // txt_cpuSpeed
            // 
            this.txt_cpuSpeed.BackColor = System.Drawing.SystemColors.Control;
            this.txt_cpuSpeed.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_cpuSpeed.Location = new System.Drawing.Point(254, 71);
            this.txt_cpuSpeed.Name = "txt_cpuSpeed";
            this.txt_cpuSpeed.ReadOnly = true;
            this.txt_cpuSpeed.Size = new System.Drawing.Size(100, 20);
            this.txt_cpuSpeed.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "CPU Number";
            // 
            // txt_cpuNumber
            // 
            this.txt_cpuNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txt_cpuNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_cpuNumber.Location = new System.Drawing.Point(254, 45);
            this.txt_cpuNumber.Name = "txt_cpuNumber";
            this.txt_cpuNumber.ReadOnly = true;
            this.txt_cpuNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_cpuNumber.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(197, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "LCD Size";
            // 
            // txt_lcdSize
            // 
            this.txt_lcdSize.BackColor = System.Drawing.SystemColors.Control;
            this.txt_lcdSize.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_lcdSize.Location = new System.Drawing.Point(254, 19);
            this.txt_lcdSize.Name = "txt_lcdSize";
            this.txt_lcdSize.ReadOnly = true;
            this.txt_lcdSize.Size = new System.Drawing.Size(100, 20);
            this.txt_lcdSize.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "CPU Type";
            // 
            // txt_cpuType
            // 
            this.txt_cpuType.BackColor = System.Drawing.SystemColors.Control;
            this.txt_cpuType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_cpuType.Location = new System.Drawing.Point(73, 71);
            this.txt_cpuType.Name = "txt_cpuType";
            this.txt_cpuType.ReadOnly = true;
            this.txt_cpuType.Size = new System.Drawing.Size(100, 20);
            this.txt_cpuType.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "CPU Brand";
            // 
            // txt_cpuBrand
            // 
            this.txt_cpuBrand.BackColor = System.Drawing.SystemColors.Control;
            this.txt_cpuBrand.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_cpuBrand.Location = new System.Drawing.Point(73, 45);
            this.txt_cpuBrand.Name = "txt_cpuBrand";
            this.txt_cpuBrand.ReadOnly = true;
            this.txt_cpuBrand.Size = new System.Drawing.Size(100, 20);
            this.txt_cpuBrand.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Memory";
            // 
            // txt_memory
            // 
            this.txt_memory.BackColor = System.Drawing.SystemColors.Control;
            this.txt_memory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_memory.Location = new System.Drawing.Point(73, 19);
            this.txt_memory.Name = "txt_memory";
            this.txt_memory.ReadOnly = true;
            this.txt_memory.Size = new System.Drawing.Size(100, 20);
            this.txt_memory.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(51, 326);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(177, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Click Next to Confirm Your Selection";
            // 
            // btn_selectAnotherProduct
            // 
            this.btn_selectAnotherProduct.Location = new System.Drawing.Point(291, 316);
            this.btn_selectAnotherProduct.Name = "btn_selectAnotherProduct";
            this.btn_selectAnotherProduct.Size = new System.Drawing.Size(157, 29);
            this.btn_selectAnotherProduct.TabIndex = 13;
            this.btn_selectAnotherProduct.Text = "Select Another Product";
            this.btn_selectAnotherProduct.UseVisualStyleBackColor = true;
            this.btn_selectAnotherProduct.Click += new System.EventHandler(this.btn_selectAnotherProduct_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(478, 319);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(84, 26);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(593, 319);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(86, 26);
            this.btn_next.TabIndex = 15;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 357);
            this.ControlBox = false;
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_selectAnotherProduct);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_condition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_productID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip_productInfo);
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.menuStrip_productInfo.ResumeLayout(false);
            this.menuStrip_productInfo.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_productInfo;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFD_productInfo;
        private System.Windows.Forms.SaveFileDialog saveFD_productInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_productID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_condition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_OS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_manufacturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_platform;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_webcam;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_gpuType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_HDD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_cpuSpeed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_cpuNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_lcdSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_cpuType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cpuBrand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_memory;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_selectAnotherProduct;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Timer timer1;
    }
}