
namespace diagnosisAnimal
{
    partial class AdditionInfo
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
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.AutoSize = true;
            this.lbCauHoi.Location = new System.Drawing.Point(13, 48);
            this.lbCauHoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(60, 17);
            this.lbCauHoi.TabIndex = 2;
            this.lbCauHoi.Text = "Câu hỏi:";
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Checked = true;
            this.radioYes.Location = new System.Drawing.Point(24, 81);
            this.radioYes.Margin = new System.Windows.Forms.Padding(4);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(46, 21);
            this.radioYes.TabIndex = 3;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "Có";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(100, 81);
            this.radioNo.Margin = new System.Windows.Forms.Padding(4);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(70, 21);
            this.radioNo.TabIndex = 4;
            this.radioNo.Text = "Không";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Các triệu chứng khác:";
            // 
            // AdditionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioNo);
            this.Controls.Add(this.radioYes);
            this.Controls.Add(this.lbCauHoi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdditionInfo";
            this.Text = "AdditionInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCauHoi;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.Label label1;
    }
}