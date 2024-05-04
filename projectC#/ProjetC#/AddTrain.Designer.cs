
namespace GESTION
{
    partial class AddTrain
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
            this.notAvailable = new System.Windows.Forms.RadioButton();
            this.available = new System.Windows.Forms.RadioButton();
            this.idT = new System.Windows.Forms.TextBox();
            this.saveT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.capacityT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.notAvailable);
            this.panel1.Controls.Add(this.available);
            this.panel1.Controls.Add(this.idT);
            this.panel1.Controls.Add(this.saveT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.capacityT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 524);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // notAvailable
            // 
            this.notAvailable.AutoSize = true;
            this.notAvailable.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notAvailable.Location = new System.Drawing.Point(253, 342);
            this.notAvailable.Name = "notAvailable";
            this.notAvailable.Size = new System.Drawing.Size(118, 23);
            this.notAvailable.TabIndex = 9;
            this.notAvailable.TabStop = true;
            this.notAvailable.Text = "Not Available";
            this.notAvailable.UseVisualStyleBackColor = true;
            // 
            // available
            // 
            this.available.AutoSize = true;
            this.available.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available.Location = new System.Drawing.Point(158, 342);
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(89, 23);
            this.available.TabIndex = 8;
            this.available.TabStop = true;
            this.available.Text = "Available";
            this.available.UseVisualStyleBackColor = true;
            // 
            // idT
            // 
            this.idT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.idT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idT.Location = new System.Drawing.Point(158, 209);
            this.idT.Multiline = true;
            this.idT.Name = "idT";
            this.idT.Size = new System.Drawing.Size(200, 30);
            this.idT.TabIndex = 2;
            // 
            // saveT
            // 
            this.saveT.BackColor = System.Drawing.Color.Blue;
            this.saveT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveT.ForeColor = System.Drawing.Color.White;
            this.saveT.Location = new System.Drawing.Point(198, 401);
            this.saveT.Name = "saveT";
            this.saveT.Size = new System.Drawing.Size(70, 41);
            this.saveT.TabIndex = 7;
            this.saveT.Text = "SAVE";
            this.saveT.UseVisualStyleBackColor = false;
            this.saveT.Click += new System.EventHandler(this.saveP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Status :";
            // 
            // capacityT
            // 
            this.capacityT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.capacityT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.capacityT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityT.Location = new System.Drawing.Point(158, 272);
            this.capacityT.Multiline = true;
            this.capacityT.Name = "capacityT";
            this.capacityT.Size = new System.Drawing.Size(200, 30);
            this.capacityT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.title);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 139);
            this.panel2.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(175, 89);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(114, 26);
            this.title.TabIndex = 0;
            this.title.Text = "Add a  Train";
            // 
            // AddTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 517);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTrain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTrain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox idT;
        private System.Windows.Forms.Button saveT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox capacityT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.RadioButton notAvailable;
        private System.Windows.Forms.RadioButton available;
    }
}