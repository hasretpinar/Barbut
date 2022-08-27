namespace Barbut
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbZar1 = new System.Windows.Forms.Label();
            this.bZarAt = new System.Windows.Forms.Button();
            this.lbZar2 = new System.Windows.Forms.Label();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.pbZar1 = new System.Windows.Forms.PictureBox();
            this.pbZar2 = new System.Windows.Forms.PictureBox();
            this.bSonucgoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbZar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZar2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbZar1
            // 
            this.lbZar1.AutoSize = true;
            this.lbZar1.Location = new System.Drawing.Point(95, 109);
            this.lbZar1.Name = "lbZar1";
            this.lbZar1.Size = new System.Drawing.Size(101, 41);
            this.lbZar1.TabIndex = 0;
            this.lbZar1.Text = "lbZar1";
            this.lbZar1.Visible = false;
            // 
            // bZarAt
            // 
            this.bZarAt.Location = new System.Drawing.Point(235, 283);
            this.bZarAt.Name = "bZarAt";
            this.bZarAt.Size = new System.Drawing.Size(188, 58);
            this.bZarAt.TabIndex = 1;
            this.bZarAt.Text = "Zarları At";
            this.bZarAt.UseVisualStyleBackColor = true;
            this.bZarAt.Click += new System.EventHandler(this.bZarAt_Click);
            // 
            // lbZar2
            // 
            this.lbZar2.AutoSize = true;
            this.lbZar2.Location = new System.Drawing.Point(304, 109);
            this.lbZar2.Name = "lbZar2";
            this.lbZar2.Size = new System.Drawing.Size(101, 41);
            this.lbZar2.TabIndex = 0;
            this.lbZar2.Text = "lbZar2";
            this.lbZar2.Visible = false;
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.ItemHeight = 41;
            this.lbSonuc.Location = new System.Drawing.Point(95, 657);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(431, 332);
            this.lbSonuc.TabIndex = 2;
            this.lbSonuc.SelectedIndexChanged += new System.EventHandler(this.lbSonuc_SelectedIndexChanged);
            // 
            // pbZar1
            // 
            this.pbZar1.Location = new System.Drawing.Point(501, 77);
            this.pbZar1.Name = "pbZar1";
            this.pbZar1.Size = new System.Drawing.Size(500, 500);
            this.pbZar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbZar1.TabIndex = 3;
            this.pbZar1.TabStop = false;
            this.pbZar1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbZar2
            // 
            this.pbZar2.Location = new System.Drawing.Point(1178, 77);
            this.pbZar2.Name = "pbZar2";
            this.pbZar2.Size = new System.Drawing.Size(500, 500);
            this.pbZar2.TabIndex = 3;
            this.pbZar2.TabStop = false;
            this.pbZar2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bSonucgoster
            // 
            this.bSonucgoster.Location = new System.Drawing.Point(953, 687);
            this.bSonucgoster.Name = "bSonucgoster";
            this.bSonucgoster.Size = new System.Drawing.Size(305, 58);
            this.bSonucgoster.TabIndex = 4;
            this.bSonucgoster.Text = "Kim kazandı?";
            this.bSonucgoster.UseVisualStyleBackColor = true;
            this.bSonucgoster.Click += new System.EventHandler(this.bSonucgoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2139, 1034);
            this.Controls.Add(this.bSonucgoster);
            this.Controls.Add(this.pbZar2);
            this.Controls.Add(this.pbZar1);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.bZarAt);
            this.Controls.Add(this.lbZar2);
            this.Controls.Add(this.lbZar1);
            this.Name = "Form1";
            this.Text = "Barbut";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbZar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbZar1;
        private Button bZarAt;
        private Label lbZar2;
        private ListBox lbSonuc;
        private PictureBox pbZar1;
        private PictureBox pbZar2;
        private Button bSonucgoster;
    }
}