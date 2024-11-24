namespace bank_manegement_System
{
    partial class CustomAlertForm
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
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.alertpic = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.alertpic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // alertpic
            // 
            this.alertpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alertpic.Image = global::bank_manegement_System.Properties.Resources.verified;
            this.alertpic.ImageRotate = 0F;
            this.alertpic.Location = new System.Drawing.Point(0, 0);
            this.alertpic.Name = "alertpic";
            this.alertpic.Size = new System.Drawing.Size(400, 322);
            this.alertpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alertpic.TabIndex = 0;
            this.alertpic.TabStop = false;
            this.alertpic.Click += new System.EventHandler(this.alertpic_Click);
            // 
            // CustomAlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 322);
            this.Controls.Add(this.alertpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomAlertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomAlertForm";
            ((System.ComponentModel.ISupportInitialize)(this.alertpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2PictureBox alertpic;
    }
}