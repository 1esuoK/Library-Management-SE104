namespace QuanLiThuVienGUI
{
    partial class frmNhapMaThe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapMaThe));
            this.lbMaTheBanDoc = new System.Windows.Forms.Label();
            this.cbNhapMaTheBanDoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbMaTheBanDoc
            // 
            this.lbMaTheBanDoc.AutoSize = true;
            this.lbMaTheBanDoc.Location = new System.Drawing.Point(13, 29);
            this.lbMaTheBanDoc.Name = "lbMaTheBanDoc";
            this.lbMaTheBanDoc.Size = new System.Drawing.Size(114, 13);
            this.lbMaTheBanDoc.TabIndex = 0;
            this.lbMaTheBanDoc.Text = "Nhập mã thẻ bạn đọc:";
            // 
            // cbNhapMaTheBanDoc
            // 
            this.cbNhapMaTheBanDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNhapMaTheBanDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNhapMaTheBanDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.cbNhapMaTheBanDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNhapMaTheBanDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.cbNhapMaTheBanDoc.FormattingEnabled = true;
            this.cbNhapMaTheBanDoc.Location = new System.Drawing.Point(133, 26);
            this.cbNhapMaTheBanDoc.Name = "cbNhapMaTheBanDoc";
            this.cbNhapMaTheBanDoc.Size = new System.Drawing.Size(268, 21);
            this.cbNhapMaTheBanDoc.TabIndex = 2;
            this.cbNhapMaTheBanDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbNhapMaTheBanDoc_KeyDown);
            // 
            // frmNhapMaThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(413, 76);
            this.Controls.Add(this.cbNhapMaTheBanDoc);
            this.Controls.Add(this.lbMaTheBanDoc);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhapMaThe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập mã thẻ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaTheBanDoc;
        private System.Windows.Forms.ComboBox cbNhapMaTheBanDoc;
    }
}