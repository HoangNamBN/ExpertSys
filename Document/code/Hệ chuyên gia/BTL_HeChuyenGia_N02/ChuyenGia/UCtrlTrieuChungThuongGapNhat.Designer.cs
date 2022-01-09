namespace BTL_HeChuyenGia_N02.ChuyenGia
{
    partial class UCtrlTrieuChungThuongGapNhat
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
            this.cboTrieuChungThuongGapNhat = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Triệu chứng gà thường gặp nhất là:";
            // 
            // cboTrieuChungThuongGapNhat
            // 
            this.cboTrieuChungThuongGapNhat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTrieuChungThuongGapNhat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTrieuChungThuongGapNhat.FormattingEnabled = true;
            this.cboTrieuChungThuongGapNhat.Location = new System.Drawing.Point(20, 53);
            this.cboTrieuChungThuongGapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.cboTrieuChungThuongGapNhat.Name = "cboTrieuChungThuongGapNhat";
            this.cboTrieuChungThuongGapNhat.Size = new System.Drawing.Size(232, 24);
            this.cboTrieuChungThuongGapNhat.TabIndex = 1;
            // 
            // UCtrlTrieuChungThuongGapNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboTrieuChungThuongGapNhat);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCtrlTrieuChungThuongGapNhat";
            this.Size = new System.Drawing.Size(340, 164);
            this.Load += new System.EventHandler(this.UCtrlTrieuChungThuongGapNhat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTrieuChungThuongGapNhat;
    }
}
