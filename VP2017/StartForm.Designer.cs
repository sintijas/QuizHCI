namespace VP2017
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlay.FlatAppearance.BorderSize = 3;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.Color.Black;
            this.btnPlay.Location = new System.Drawing.Point(4, 134);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(334, 194);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Нова игра";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackColor = System.Drawing.Color.White;
            this.btnZoomOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomOut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnZoomOut.FlatAppearance.BorderSize = 3;
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.btnZoomOut.ForeColor = System.Drawing.Color.Black;
            this.btnZoomOut.Location = new System.Drawing.Point(384, 24);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(79, 69);
            this.btnZoomOut.TabIndex = 3;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.White;
            this.btnInstructions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstructions.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInstructions.FlatAppearance.BorderSize = 3;
            this.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructions.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.btnInstructions.ForeColor = System.Drawing.Color.Black;
            this.btnInstructions.Location = new System.Drawing.Point(384, 134);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(334, 194);
            this.btnInstructions.TabIndex = 4;
            this.btnInstructions.Text = "Упатство";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInstructions);
            this.panel1.Controls.Add(this.btnZoomOut);
            this.panel1.Controls.Add(this.btnZoomIn);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Location = new System.Drawing.Point(247, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 335);
            this.panel1.TabIndex = 5;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.BackColor = System.Drawing.Color.White;
            this.btnZoomIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnZoomIn.FlatAppearance.BorderSize = 3;
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.btnZoomIn.ForeColor = System.Drawing.Color.Black;
            this.btnZoomIn.Location = new System.Drawing.Point(257, 24);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(79, 69);
            this.btnZoomIn.TabIndex = 2;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.White;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.quitButton.FlatAppearance.BorderSize = 3;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.quitButton.ForeColor = System.Drawing.Color.Black;
            this.quitButton.Location = new System.Drawing.Point(607, 1);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(196, 69);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Исклучи";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::VP2017.Properties.Resources.logo4;
            this.logoPictureBox.Location = new System.Drawing.Point(251, -35);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(300, 300);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 6;
            this.logoPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(815, 448);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Квиз";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}