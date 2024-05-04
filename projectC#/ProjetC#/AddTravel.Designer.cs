
namespace GESTION
{
    partial class AddTravel
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
            this.label6 = new System.Windows.Forms.Label();
            this.trv = new System.Windows.Forms.TextBox();
            this.dst = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.src = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtv = new System.Windows.Forms.DateTimePicker();
            this.cdv = new System.Windows.Forms.TextBox();
            this.saveT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.title34 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.trv);
            this.panel1.Controls.Add(this.dst);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Controls.Add(this.src);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtv);
            this.panel1.Controls.Add(this.cdv);
            this.panel1.Controls.Add(this.saveT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 524);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Travel Coast";
            // 
            // trv
            // 
            this.trv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.trv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trv.Location = new System.Drawing.Point(204, 367);
            this.trv.Multiline = true;
            this.trv.Name = "trv";
            this.trv.Size = new System.Drawing.Size(115, 32);
            this.trv.TabIndex = 17;
            // 
            // dst
            // 
            this.dst.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dst.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dst.Location = new System.Drawing.Point(377, 367);
            this.dst.Multiline = true;
            this.dst.Name = "dst";
            this.dst.Size = new System.Drawing.Size(115, 32);
            this.dst.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Source";
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.ForeColor = System.Drawing.Color.Red;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.ItemHeight = 18;
            this.comboBox.Location = new System.Drawing.Point(226, 289);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(114, 26);
            this.comboBox.Sorted = true;
            this.comboBox.TabIndex = 13;
            this.comboBox.UseWaitCursor = true;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // src
            // 
            this.src.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.src.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.src.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.src.Location = new System.Drawing.Point(23, 367);
            this.src.Multiline = true;
            this.src.Name = "src";
            this.src.Size = new System.Drawing.Size(115, 32);
            this.src.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date de Voyage";
            // 
            // dtv
            // 
            this.dtv.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.dtv.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtv.Location = new System.Drawing.Point(318, 216);
            this.dtv.MaximumSize = new System.Drawing.Size(120, 100);
            this.dtv.Name = "dtv";
            this.dtv.Size = new System.Drawing.Size(109, 26);
            this.dtv.TabIndex = 10;
            // 
            // cdv
            // 
            this.cdv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cdv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cdv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdv.Location = new System.Drawing.Point(132, 216);
            this.cdv.Multiline = true;
            this.cdv.Name = "cdv";
            this.cdv.Size = new System.Drawing.Size(85, 28);
            this.cdv.TabIndex = 2;
            this.cdv.TextChanged += new System.EventHandler(this.idT_TextChanged);
            // 
            // saveT
            // 
            this.saveT.BackColor = System.Drawing.Color.Blue;
            this.saveT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveT.ForeColor = System.Drawing.Color.White;
            this.saveT.Location = new System.Drawing.Point(226, 427);
            this.saveT.Name = "saveT";
            this.saveT.Size = new System.Drawing.Size(70, 41);
            this.saveT.TabIndex = 7;
            this.saveT.Text = "SAVE";
            this.saveT.UseVisualStyleBackColor = false;
            this.saveT.Click += new System.EventHandler(this.saveT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Code de Train";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code de Voyage";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.title34);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 139);
            this.panel2.TabIndex = 0;
            // 
            // title34
            // 
            this.title34.AutoSize = true;
            this.title34.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title34.ForeColor = System.Drawing.Color.White;
            this.title34.Location = new System.Drawing.Point(175, 89);
            this.title34.Name = "title34";
            this.title34.Size = new System.Drawing.Size(162, 26);
            this.title34.TabIndex = 0;
            this.title34.Text = "Add a new Travel";
            // 
            // AddTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 517);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTravel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTravel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cdv;
        private System.Windows.Forms.Button saveT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title34;
        private System.Windows.Forms.DateTimePicker dtv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox src;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox trv;
    }
}