namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listdisk_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.format_btn = new System.Windows.Forms.Button();
            this.fs = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listdisk_output = new System.Windows.Forms.TextBox();
            this.output_name = new System.Windows.Forms.TextBox();
            this.name_enter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.format_output_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listdisk_btn
            // 
            this.listdisk_btn.Location = new System.Drawing.Point(21, 109);
            this.listdisk_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listdisk_btn.Name = "listdisk_btn";
            this.listdisk_btn.Size = new System.Drawing.Size(112, 35);
            this.listdisk_btn.TabIndex = 0;
            this.listdisk_btn.Text = "List Disk";
            this.listdisk_btn.UseVisualStyleBackColor = true;
            this.listdisk_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Navn: ";
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(96, 34);
            this.name_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(306, 26);
            this.name_input.TabIndex = 5;
            this.name_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 502);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Velg volume";
            // 
            // format_btn
            // 
            this.format_btn.Location = new System.Drawing.Point(1070, 1117);
            this.format_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.format_btn.Name = "format_btn";
            this.format_btn.Size = new System.Drawing.Size(112, 35);
            this.format_btn.TabIndex = 11;
            this.format_btn.Text = "Format";
            this.format_btn.UseVisualStyleBackColor = true;
            this.format_btn.Click += new System.EventHandler(this.format_btn_Click);
            // 
            // fs
            // 
            this.fs.AutoSize = true;
            this.fs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fs.Location = new System.Drawing.Point(18, 614);
            this.fs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fs.Name = "fs";
            this.fs.Size = new System.Drawing.Size(150, 25);
            this.fs.TabIndex = 12;
            this.fs.Text = "Velg Fil system:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NTFS",
            "FAT32"});
            this.comboBox1.Location = new System.Drawing.Point(22, 643);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Volume 0",
            "Volume 1",
            "Volume 2",
            "Volume 3"});
            this.comboBox2.Location = new System.Drawing.Point(22, 531);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 28);
            this.comboBox2.TabIndex = 14;
            // 
            // listdisk_output
            // 
            this.listdisk_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listdisk_output.Cursor = System.Windows.Forms.Cursors.Help;
            this.listdisk_output.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listdisk_output.Location = new System.Drawing.Point(22, 154);
            this.listdisk_output.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listdisk_output.Multiline = true;
            this.listdisk_output.Name = "listdisk_output";
            this.listdisk_output.ReadOnly = true;
            this.listdisk_output.Size = new System.Drawing.Size(1160, 318);
            this.listdisk_output.TabIndex = 1;
            this.listdisk_output.TextChanged += new System.EventHandler(this.listdisk_output_TextChanged);
            // 
            // output_name
            // 
            this.output_name.BackColor = System.Drawing.SystemColors.Control;
            this.output_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_name.Location = new System.Drawing.Point(99, 74);
            this.output_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.output_name.Name = "output_name";
            this.output_name.ReadOnly = true;
            this.output_name.Size = new System.Drawing.Size(108, 19);
            this.output_name.TabIndex = 16;
            this.output_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // name_enter
            // 
            this.name_enter.Location = new System.Drawing.Point(412, 32);
            this.name_enter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_enter.Name = "name_enter";
            this.name_enter.Size = new System.Drawing.Size(112, 35);
            this.name_enter.TabIndex = 17;
            this.name_enter.Text = "Enter";
            this.name_enter.UseVisualStyleBackColor = true;
            this.name_enter.Click += new System.EventHandler(this.name_enter_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(936, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(246, 19);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(172, 1137);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(244, 19);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 1132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Serial Number:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // format_output_text
            // 
            this.format_output_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.format_output_text.Cursor = System.Windows.Forms.Cursors.Help;
            this.format_output_text.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.format_output_text.Location = new System.Drawing.Point(21, 685);
            this.format_output_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.format_output_text.Multiline = true;
            this.format_output_text.Name = "format_output_text";
            this.format_output_text.ReadOnly = true;
            this.format_output_text.Size = new System.Drawing.Size(1160, 300);
            this.format_output_text.TabIndex = 15;
            this.format_output_text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.format_btn;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 1171);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.name_enter);
            this.Controls.Add(this.output_name);
            this.Controls.Add(this.format_output_text);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fs);
            this.Controls.Add(this.format_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listdisk_output);
            this.Controls.Add(this.listdisk_btn);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Format Logger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listdisk_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button format_btn;
        private System.Windows.Forms.Label fs;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox listdisk_output;
        private System.Windows.Forms.TextBox output_name;
        private System.Windows.Forms.Button name_enter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox format_output_text;
    }
}

