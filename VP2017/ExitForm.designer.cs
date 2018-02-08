namespace VP2017
{
    partial class ExitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.tbTocenOdgovor = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 4;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial Narrow", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(111, 127);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 46);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Затвори";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnNe_Click);
            // 
            // tbTocenOdgovor
            // 
            this.tbTocenOdgovor.AutoSize = true;
            this.tbTocenOdgovor.BackColor = System.Drawing.Color.White;
            this.tbTocenOdgovor.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTocenOdgovor.Location = new System.Drawing.Point(12, 61);
            this.tbTocenOdgovor.MaximumSize = new System.Drawing.Size(356, 40);
            this.tbTocenOdgovor.MinimumSize = new System.Drawing.Size(356, 40);
            this.tbTocenOdgovor.Name = "tbTocenOdgovor";
            this.tbTocenOdgovor.Size = new System.Drawing.Size(356, 40);
            this.tbTocenOdgovor.TabIndex = 9;
            this.tbTocenOdgovor.Text = "label1";
            this.tbTocenOdgovor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb
            // 
            this.tb.AutoSize = true;
            this.tb.BackColor = System.Drawing.Color.White;
            this.tb.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb.Location = new System.Drawing.Point(12, 21);
            this.tb.MaximumSize = new System.Drawing.Size(356, 40);
            this.tb.MinimumSize = new System.Drawing.Size(356, 40);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(356, 40);
            this.tb.TabIndex = 10;
            this.tb.Text = "Точниот одговор е:";
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(380, 185);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.tbTocenOdgovor);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(396, 224);
            this.MinimumSize = new System.Drawing.Size(396, 224);
            this.Name = "ExitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Се откажавте!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFinalAnswer_FormClosed);
            this.Load += new System.EventHandler(this.FormFinalAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label tbTocenOdgovor;
        private System.Windows.Forms.Label tb;

    }
}