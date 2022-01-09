
namespace diagnosisAnimal
{
    partial class Law
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Law));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.btnChooseEvent = new System.Windows.Forms.Button();
            this.txtLawName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.dgvLaw = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaw)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEvent);
            this.groupBox1.Controls.Add(this.btnChooseEvent);
            this.groupBox1.Controls.Add(this.txtLawName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(933, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin luật";
            // 
            // txtEvent
            // 
            this.txtEvent.BackColor = System.Drawing.Color.White;
            this.txtEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEvent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEvent.Location = new System.Drawing.Point(99, 78);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(4);
            this.txtEvent.Multiline = true;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.ReadOnly = true;
            this.txtEvent.Size = new System.Drawing.Size(425, 146);
            this.txtEvent.TabIndex = 4;
            // 
            // btnChooseEvent
            // 
            this.btnChooseEvent.Location = new System.Drawing.Point(532, 78);
            this.btnChooseEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseEvent.Name = "btnChooseEvent";
            this.btnChooseEvent.Size = new System.Drawing.Size(36, 33);
            this.btnChooseEvent.TabIndex = 3;
            this.btnChooseEvent.Text = "...";
            this.btnChooseEvent.UseVisualStyleBackColor = true;
            this.btnChooseEvent.Click += new System.EventHandler(this.btnChooseEvent_Click);
            // 
            // txtLawName
            // 
            this.txtLawName.Location = new System.Drawing.Point(99, 37);
            this.txtLawName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLawName.Name = "txtLawName";
            this.txtLawName.Size = new System.Drawing.Size(425, 22);
            this.txtLawName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sự kiện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên luật";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(380, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(499, 264);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 32);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(718, 264);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(97, 32);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.Image = ((System.Drawing.Image)(resources.GetObject("btnBreak.Image")));
            this.btnBreak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBreak.Location = new System.Drawing.Point(852, 264);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(97, 32);
            this.btnBreak.TabIndex = 4;
            this.btnBreak.Text = "Thoát";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // dgvLaw
            // 
            this.dgvLaw.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaw.Location = new System.Drawing.Point(18, 303);
            this.dgvLaw.Name = "dgvLaw";
            this.dgvLaw.RowHeadersWidth = 51;
            this.dgvLaw.RowTemplate.Height = 24;
            this.dgvLaw.Size = new System.Drawing.Size(931, 357);
            this.dgvLaw.TabIndex = 7;
            this.dgvLaw.SelectionChanged += new System.EventHandler(this.dgvLaw_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(602, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nhập để tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(142, 272);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(221, 22);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Law
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 669);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvLaw);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Law";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luật";
            this.Load += new System.EventHandler(this.Law_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLawName;
        private System.Windows.Forms.Button btnChooseEvent;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.DataGridView dgvLaw;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
    }
}