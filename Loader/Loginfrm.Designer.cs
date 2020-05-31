namespace Loader
{
    partial class Loginfrm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.exchangecode_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Burbank Big Cd Bk", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert the code here";
            // 
            // exchangecode_textbox
            // 
            this.exchangecode_textbox.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.exchangecode_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exchangecode_textbox.Font = new System.Drawing.Font("Franklin Gothic Medium", 17.75F);
            this.exchangecode_textbox.ForeColor = System.Drawing.Color.White;
            this.exchangecode_textbox.Location = new System.Drawing.Point(40, 145);
            this.exchangecode_textbox.MaxLength = 32;
            this.exchangecode_textbox.Name = "exchangecode_textbox";
            this.exchangecode_textbox.Size = new System.Drawing.Size(467, 27);
            this.exchangecode_textbox.TabIndex = 1;
            this.exchangecode_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Burbank Big Cd Bk", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(191, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // statos
            // 
            this.statos.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statos.Location = new System.Drawing.Point(0, 195);
            this.statos.Name = "statos";
            this.statos.Size = new System.Drawing.Size(548, 23);
            this.statos.TabIndex = 3;
            this.statos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Loginfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.statos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exchangecode_textbox);
            this.Controls.Add(this.label1);
            this.Name = "Loginfrm";
            this.Size = new System.Drawing.Size(548, 406);
            this.Load += new System.EventHandler(this.Loginfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox exchangecode_textbox;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label statos;
    }
}
