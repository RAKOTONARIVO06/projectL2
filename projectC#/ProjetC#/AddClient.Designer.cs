
namespace GESTION
{
    partial class AddClient
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
            this.id = new System.Windows.Forms.TextBox();
            this.saveP = new System.Windows.Forms.Button();
            this.contactP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameP = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.saveP);
            this.panel1.Controls.Add(this.contactP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nameP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 517);
            this.panel1.TabIndex = 0;
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(158, 209);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(200, 30);
            this.id.TabIndex = 2;
            // 
            // saveP
            // 
            this.saveP.BackColor = System.Drawing.Color.Blue;
            this.saveP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveP.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveP.ForeColor = System.Drawing.Color.White;
            this.saveP.Location = new System.Drawing.Point(199, 404);
            this.saveP.Name = "saveP";
            this.saveP.Size = new System.Drawing.Size(100, 41);
            this.saveP.TabIndex = 7;
            this.saveP.Text = "SAVE";
            this.saveP.UseVisualStyleBackColor = false;
            this.saveP.Click += new System.EventHandler(this.save_Click);
            // 
            // contactP
            // 
            this.contactP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.contactP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contactP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactP.Location = new System.Drawing.Point(158, 331);
            this.contactP.Multiline = true;
            this.contactP.Name = "contactP";
            this.contactP.Size = new System.Drawing.Size(200, 30);
            this.contactP.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone  : ";
            // 
            // nameP
            // 
            this.nameP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameP.Location = new System.Drawing.Point(158, 272);
            this.nameP.Multiline = true;
            this.nameP.Name = "nameP";
            this.nameP.Size = new System.Drawing.Size(200, 30);
            this.nameP.TabIndex = 4;
            this.nameP.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name  : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identity : ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.title);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 139);
            this.panel2.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(175, 89);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(139, 26);
            this.title.TabIndex = 0;
            this.title.Text = "Add Passenger";
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 517);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClient";
            this.Load += new System.EventHandler(this.AddClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button saveP;
        private System.Windows.Forms.TextBox contactP;
        private System.Windows.Forms.Label label4;
    }
}