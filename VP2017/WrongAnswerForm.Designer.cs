namespace VP2017
{
    partial class WrongAnswerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WrongAnswerForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbTocenOdgovor = new System.Windows.Forms.Label();
            this.tbOtkaziSe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbTocenOdgovor
            // 
            this.tbTocenOdgovor.AutoSize = true;
            this.tbTocenOdgovor.BackColor = System.Drawing.Color.Black;
            this.tbTocenOdgovor.Font = new System.Drawing.Font("Arial Narrow", 32F, System.Drawing.FontStyle.Bold);
            this.tbTocenOdgovor.ForeColor = System.Drawing.Color.White;
            this.tbTocenOdgovor.Location = new System.Drawing.Point(-4, 61);
            this.tbTocenOdgovor.MaximumSize = new System.Drawing.Size(401, 66);
            this.tbTocenOdgovor.MinimumSize = new System.Drawing.Size(401, 66);
            this.tbTocenOdgovor.Name = "tbTocenOdgovor";
            this.tbTocenOdgovor.Size = new System.Drawing.Size(401, 66);
            this.tbTocenOdgovor.TabIndex = 11;
            this.tbTocenOdgovor.Text = "label1";
            this.tbTocenOdgovor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOtkaziSe
            // 
            this.tbOtkaziSe.AutoSize = true;
            this.tbOtkaziSe.BackColor = System.Drawing.Color.Black;
            this.tbOtkaziSe.Font = new System.Drawing.Font("Arial Narrow", 28F, System.Drawing.FontStyle.Bold);
            this.tbOtkaziSe.ForeColor = System.Drawing.Color.White;
            this.tbOtkaziSe.Location = new System.Drawing.Point(15, 4);
            this.tbOtkaziSe.MaximumSize = new System.Drawing.Size(356, 66);
            this.tbOtkaziSe.MinimumSize = new System.Drawing.Size(356, 66);
            this.tbOtkaziSe.Name = "tbOtkaziSe";
            this.tbOtkaziSe.Size = new System.Drawing.Size(356, 66);
            this.tbOtkaziSe.TabIndex = 12;
            this.tbOtkaziSe.Text = "Точниот одговор е:";
            this.tbOtkaziSe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbOtkaziSe.Click += new System.EventHandler(this.tbOtkaziSe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 127);
            this.label1.MaximumSize = new System.Drawing.Size(401, 48);
            this.label1.MinimumSize = new System.Drawing.Size(401, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 48);
            this.label1.TabIndex = 13;
            this.label1.Text = "Повеќе среќа следниот пат!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WrongAnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(382, 179);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOtkaziSe);
            this.Controls.Add(this.tbTocenOdgovor);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(388, 208);
            this.MinimumSize = new System.Drawing.Size(388, 208);
            this.Name = "WrongAnswerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WrongAnswerForm_FormClosed);
            this.Load += new System.EventHandler(this.WrongAnswerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tbTocenOdgovor;
        private System.Windows.Forms.Label tbOtkaziSe;
        private System.Windows.Forms.Label label1;
    }
}