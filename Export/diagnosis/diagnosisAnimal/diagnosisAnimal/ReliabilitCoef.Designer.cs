
namespace diagnosisAnimal
{
    partial class ReliabilitCoef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReliabilitCoef));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.txtHeSoTinCay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ số tin cậy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xin mời nhập hệ số tin cậy!";
            // 
            // btnYes
            // 
            this.btnYes.Image = ((System.Drawing.Image)(resources.GetObject("btnYes.Image")));
            this.btnYes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYes.Location = new System.Drawing.Point(100, 104);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(91, 27);
            this.btnYes.TabIndex = 3;
            this.btnYes.Text = "Đồng ý";
            this.btnYes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.Image")));
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Location = new System.Drawing.Point(198, 104);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(91, 27);
            this.btnHuyBo.TabIndex = 4;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // txtHeSoTinCay
            // 
            this.txtHeSoTinCay.Location = new System.Drawing.Point(131, 53);
            this.txtHeSoTinCay.Name = "txtHeSoTinCay";
            this.txtHeSoTinCay.Size = new System.Drawing.Size(158, 22);
            this.txtHeSoTinCay.TabIndex = 1;
            // 
            // ReliabilitCoef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(301, 154);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHeSoTinCay);
            this.Controls.Add(this.label1);
            this.Name = "ReliabilitCoef";
            this.Text = "ReliabilitCoef";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReliabilitCoef_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.TextBox txtHeSoTinCay;
    }
}