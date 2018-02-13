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
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrasanje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F);
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.MaximumSize = new System.Drawing.Size(345, 133);
            this.label2.MinimumSize = new System.Drawing.Size(345, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 133);
            this.label2.TabIndex = 10;
            this.label2.Text = "Точно го одговоривте";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrasanje
            // 
            this.lblPrasanje.AutoSize = true;
            this.lblPrasanje.Font = new System.Drawing.Font("Arial Narrow", 36F);
            this.lblPrasanje.Location = new System.Drawing.Point(12, 145);
            this.lblPrasanje.MaximumSize = new System.Drawing.Size(345, 73);
            this.lblPrasanje.MinimumSize = new System.Drawing.Size(345, 73);
            this.lblPrasanje.Name = "lblPrasanje";
            this.lblPrasanje.Size = new System.Drawing.Size(345, 73);
            this.lblPrasanje.TabIndex = 11;
            this.lblPrasanje.Text = "label1";
            this.lblPrasanje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(369, 218);
            this.Controls.Add(this.lblPrasanje);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrasanje;

    }
}