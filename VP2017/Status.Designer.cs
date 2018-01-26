namespace VP2017
{
    partial class Status
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
            this.timerBoja = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.TextBox();
            this.lblPrasanje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 38F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Multiline = true;
            this.label1.Name = "label1";
            this.label1.ReadOnly = true;
            this.label1.Size = new System.Drawing.Size(345, 133);
            this.label1.TabIndex = 8;
            this.label1.Text = "Точно го одговоривте";
            this.label1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrasanje
            // 
            this.lblPrasanje.BackColor = System.Drawing.Color.Black;
            this.lblPrasanje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPrasanje.Enabled = false;
            this.lblPrasanje.Font = new System.Drawing.Font("Arial Narrow", 38F);
            this.lblPrasanje.ForeColor = System.Drawing.Color.White;
            this.lblPrasanje.Location = new System.Drawing.Point(12, 133);
            this.lblPrasanje.Multiline = true;
            this.lblPrasanje.Name = "lblPrasanje";
            this.lblPrasanje.ReadOnly = true;
            this.lblPrasanje.Size = new System.Drawing.Size(345, 73);
            this.lblPrasanje.TabIndex = 9;
            this.lblPrasanje.Text = "Точен одговор на:\r\n\r\n";
            this.lblPrasanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(369, 218);
            this.Controls.Add(this.lblPrasanje);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Status_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerBoja;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox label1;
        private System.Windows.Forms.TextBox lblPrasanje;

    }
}