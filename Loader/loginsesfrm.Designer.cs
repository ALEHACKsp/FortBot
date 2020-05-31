namespace Loader
{
    partial class loginsesfrm
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalExtent = 2;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.ItemHeight = 28;
            this.listBox.Location = new System.Drawing.Point(9, 7);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(490, 364);
            this.listBox.TabIndex = 0;
            // 
            // loginsesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.listBox);
            this.Name = "loginsesfrm";
            this.Size = new System.Drawing.Size(508, 406);
            this.Load += new System.EventHandler(this.loginsesfrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listBox;
    }
}
