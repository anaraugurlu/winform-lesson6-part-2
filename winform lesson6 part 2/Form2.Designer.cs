
namespace winform_lesson6_part_2
{
    partial class Form2
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTxtb = new System.Windows.Forms.TextBox();
            this.CountryLbl = new System.Windows.Forms.Label();
            this.CountryTxtb = new System.Windows.Forms.TextBox();
            this.CostLbl = new System.Windows.Forms.Label();
            this.CostTxtb = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLbl.Location = new System.Drawing.Point(239, 101);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(106, 16);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Product Name";
            // 
            // NameTxtb
            // 
            this.NameTxtb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.NameTxtb.Location = new System.Drawing.Point(242, 120);
            this.NameTxtb.Name = "NameTxtb";
            this.NameTxtb.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.NameTxtb.Size = new System.Drawing.Size(244, 20);
            this.NameTxtb.TabIndex = 1;
            // 
            // CountryLbl
            // 
            this.CountryLbl.AutoSize = true;
            this.CountryLbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CountryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryLbl.Location = new System.Drawing.Point(239, 143);
            this.CountryLbl.Name = "CountryLbl";
            this.CountryLbl.Size = new System.Drawing.Size(105, 16);
            this.CountryLbl.TabIndex = 2;
            this.CountryLbl.Text = "Origin Country";
            // 
            // CountryTxtb
            // 
            this.CountryTxtb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CountryTxtb.Location = new System.Drawing.Point(242, 162);
            this.CountryTxtb.Name = "CountryTxtb";
            this.CountryTxtb.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CountryTxtb.Size = new System.Drawing.Size(244, 20);
            this.CountryTxtb.TabIndex = 3;
            // 
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLbl.Location = new System.Drawing.Point(239, 185);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(96, 16);
            this.CostLbl.TabIndex = 4;
            this.CostLbl.Text = "Product Cost";
            // 
            // CostTxtb
            // 
            this.CostTxtb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CostTxtb.Location = new System.Drawing.Point(242, 204);
            this.CostTxtb.Name = "CostTxtb";
            this.CostTxtb.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CostTxtb.Size = new System.Drawing.Size(244, 20);
            this.CostTxtb.TabIndex = 5;
            // 
            // OkBtn
            // 
            this.OkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBtn.Location = new System.Drawing.Point(100, 257);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 6;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.Location = new System.Drawing.Point(551, 257);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancl";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.CostTxtb);
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.CountryTxtb);
            this.Controls.Add(this.CountryLbl);
            this.Controls.Add(this.NameTxtb);
            this.Controls.Add(this.NameLbl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTxtb;
        private System.Windows.Forms.Label CountryLbl;
        private System.Windows.Forms.TextBox CountryTxtb;
        private System.Windows.Forms.Label CostLbl;
        private System.Windows.Forms.TextBox CostTxtb;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}