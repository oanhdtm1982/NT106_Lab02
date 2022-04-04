namespace Lab02_19521982_DoThiMinhOanh
{
    partial class Lab02_Bai02
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
            this.btnDoc = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.rtbFile = new System.Windows.Forms.RichTextBox();
            this.tenFile = new System.Windows.Forms.Label();
            this.tbTenFile = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.soDong = new System.Windows.Forms.Label();
            this.soTu = new System.Windows.Forms.Label();
            this.soKyTu = new System.Windows.Forms.Label();
            this.tbDong = new System.Windows.Forms.TextBox();
            this.tbTu = new System.Windows.Forms.TextBox();
            this.tbKyTu = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoc
            // 
            this.btnDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.Location = new System.Drawing.Point(50, 73);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(270, 38);
            this.btnDoc.TabIndex = 0;
            this.btnDoc.Text = "Đọc File";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Red;
            this.title.Location = new System.Drawing.Point(239, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(287, 25);
            this.title.TabIndex = 1;
            this.title.Text = "Bài 02: Đọc thông tin một file";
            // 
            // rtbFile
            // 
            this.rtbFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFile.Location = new System.Drawing.Point(394, 73);
            this.rtbFile.Name = "rtbFile";
            this.rtbFile.Size = new System.Drawing.Size(373, 282);
            this.rtbFile.TabIndex = 2;
            this.rtbFile.Text = "";
            // 
            // tenFile
            // 
            this.tenFile.AutoSize = true;
            this.tenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenFile.Location = new System.Drawing.Point(51, 148);
            this.tenFile.Name = "tenFile";
            this.tenFile.Size = new System.Drawing.Size(65, 20);
            this.tenFile.TabIndex = 3;
            this.tenFile.Text = "Tên File";
            // 
            // tbTenFile
            // 
            this.tbTenFile.Enabled = false;
            this.tbTenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenFile.Location = new System.Drawing.Point(136, 142);
            this.tbTenFile.Name = "tbTenFile";
            this.tbTenFile.Size = new System.Drawing.Size(184, 26);
            this.tbTenFile.TabIndex = 4;
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url.Location = new System.Drawing.Point(51, 211);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(42, 20);
            this.url.TabIndex = 5;
            this.url.Text = "URL";
            // 
            // tbUrl
            // 
            this.tbUrl.Enabled = false;
            this.tbUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUrl.Location = new System.Drawing.Point(136, 194);
            this.tbUrl.Multiline = true;
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(184, 60);
            this.tbUrl.TabIndex = 6;
            // 
            // soDong
            // 
            this.soDong.AutoSize = true;
            this.soDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soDong.Location = new System.Drawing.Point(47, 282);
            this.soDong.Name = "soDong";
            this.soDong.Size = new System.Drawing.Size(69, 20);
            this.soDong.TabIndex = 7;
            this.soDong.Text = "Số dòng";
            // 
            // soTu
            // 
            this.soTu.AutoSize = true;
            this.soTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soTu.Location = new System.Drawing.Point(46, 335);
            this.soTu.Name = "soTu";
            this.soTu.Size = new System.Drawing.Size(47, 20);
            this.soTu.TabIndex = 8;
            this.soTu.Text = "Số từ";
            // 
            // soKyTu
            // 
            this.soKyTu.AutoSize = true;
            this.soKyTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soKyTu.Location = new System.Drawing.Point(46, 386);
            this.soKyTu.Name = "soKyTu";
            this.soKyTu.Size = new System.Drawing.Size(66, 20);
            this.soKyTu.TabIndex = 9;
            this.soKyTu.Text = "Số ký tự";
            // 
            // tbDong
            // 
            this.tbDong.Enabled = false;
            this.tbDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDong.Location = new System.Drawing.Point(136, 276);
            this.tbDong.Name = "tbDong";
            this.tbDong.Size = new System.Drawing.Size(184, 26);
            this.tbDong.TabIndex = 10;
            // 
            // tbTu
            // 
            this.tbTu.Enabled = false;
            this.tbTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTu.Location = new System.Drawing.Point(136, 329);
            this.tbTu.Name = "tbTu";
            this.tbTu.Size = new System.Drawing.Size(184, 26);
            this.tbTu.TabIndex = 11;
            // 
            // tbKyTu
            // 
            this.tbKyTu.Enabled = false;
            this.tbKyTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKyTu.Location = new System.Drawing.Point(136, 380);
            this.tbKyTu.Name = "tbKyTu";
            this.tbKyTu.Size = new System.Drawing.Size(184, 26);
            this.tbKyTu.TabIndex = 12;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(432, 369);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 37);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(629, 369);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 37);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Lab02_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.tbKyTu);
            this.Controls.Add(this.tbTu);
            this.Controls.Add(this.tbDong);
            this.Controls.Add(this.soKyTu);
            this.Controls.Add(this.soTu);
            this.Controls.Add(this.soDong);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.url);
            this.Controls.Add(this.tbTenFile);
            this.Controls.Add(this.tenFile);
            this.Controls.Add(this.rtbFile);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnDoc);
            this.Name = "Lab02_Bai02";
            this.Text = "Lab02_Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.RichTextBox rtbFile;
        private System.Windows.Forms.Label tenFile;
        private System.Windows.Forms.TextBox tbTenFile;
        private System.Windows.Forms.Label url;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label soDong;
        private System.Windows.Forms.Label soTu;
        private System.Windows.Forms.Label soKyTu;
        private System.Windows.Forms.TextBox tbDong;
        private System.Windows.Forms.TextBox tbTu;
        private System.Windows.Forms.TextBox tbKyTu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}