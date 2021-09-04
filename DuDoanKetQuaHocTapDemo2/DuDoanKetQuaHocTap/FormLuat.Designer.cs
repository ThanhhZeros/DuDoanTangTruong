namespace DuDoanKetQuaHocTap
{
    partial class FormLuat
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
            this.grbox_tapluat = new System.Windows.Forms.GroupBox();
            this.dgv_display = new System.Windows.Forms.DataGridView();
            this.groupBox_ThongTinChiTIet = new System.Windows.Forms.GroupBox();
            this.textBox_MaLuat = new System.Windows.Forms.TextBox();
            this.label_Luat = new System.Windows.Forms.Label();
            this.comboBox_Ktn = new System.Windows.Forms.ComboBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Insert = new System.Windows.Forms.Button();
            this.comboBox_ChamChi = new System.Windows.Forms.ComboBox();
            this.comboBox_DoKho = new System.Windows.Forms.ComboBox();
            this.comboBox_KetQua = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbox_tapluat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_display)).BeginInit();
            this.groupBox_ThongTinChiTIet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbox_tapluat
            // 
            this.grbox_tapluat.Controls.Add(this.dgv_display);
            this.grbox_tapluat.Location = new System.Drawing.Point(11, 10);
            this.grbox_tapluat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbox_tapluat.Name = "grbox_tapluat";
            this.grbox_tapluat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbox_tapluat.Size = new System.Drawing.Size(737, 254);
            this.grbox_tapluat.TabIndex = 0;
            this.grbox_tapluat.TabStop = false;
            this.grbox_tapluat.Text = "Tập luật";
            // 
            // dgv_display
            // 
            this.dgv_display.AllowUserToAddRows = false;
            this.dgv_display.AllowUserToDeleteRows = false;
            this.dgv_display.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_display.Location = new System.Drawing.Point(56, 44);
            this.dgv_display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_display.Name = "dgv_display";
            this.dgv_display.ReadOnly = true;
            this.dgv_display.RowHeadersWidth = 51;
            this.dgv_display.RowTemplate.Height = 28;
            this.dgv_display.Size = new System.Drawing.Size(662, 193);
            this.dgv_display.TabIndex = 0;
            this.dgv_display.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_display_CellMouseClick);
            // 
            // groupBox_ThongTinChiTIet
            // 
            this.groupBox_ThongTinChiTIet.Controls.Add(this.textBox_MaLuat);
            this.groupBox_ThongTinChiTIet.Controls.Add(this.label_Luat);
            this.groupBox_ThongTinChiTIet.Controls.Add(this.comboBox_Ktn);
            this.groupBox_ThongTinChiTIet.Controls.Add(this.button_Delete);
            this.groupBox_ThongTinChiTIet.Controls.Add(this.button_Insert);
            this.groupBox_ThongTinChiTIet.Controls.Add(this.comboBox_ChamChi);
            this.groupBox_ThongTinChiTIet.Controls.Add(this.comboBox_DoKho);
            this.groupBox_ThongTinChiTIet.Controls.Add(this.comboBox_KetQua);
            this.groupBox_ThongTinChiTIet.Controls.Add(this.label4);
            this.groupBox_ThongTinChiTIet.Controls.Add(this.label3);
            this.groupBox_ThongTinChiTIet.Controls.Add(this.label2);
            this.groupBox_ThongTinChiTIet.Controls.Add(this.label1);
            this.groupBox_ThongTinChiTIet.Location = new System.Drawing.Point(33, 274);
            this.groupBox_ThongTinChiTIet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_ThongTinChiTIet.Name = "groupBox_ThongTinChiTIet";
            this.groupBox_ThongTinChiTIet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_ThongTinChiTIet.Size = new System.Drawing.Size(715, 166);
            this.groupBox_ThongTinChiTIet.TabIndex = 1;
            this.groupBox_ThongTinChiTIet.TabStop = false;
            this.groupBox_ThongTinChiTIet.Text = "Thông tin chi tiết:";
            // 
            // textBox_MaLuat
            // 
            this.textBox_MaLuat.Location = new System.Drawing.Point(132, 32);
            this.textBox_MaLuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MaLuat.Name = "textBox_MaLuat";
            this.textBox_MaLuat.Size = new System.Drawing.Size(108, 22);
            this.textBox_MaLuat.TabIndex = 14;
            // 
            // label_Luat
            // 
            this.label_Luat.AutoSize = true;
            this.label_Luat.Location = new System.Drawing.Point(27, 34);
            this.label_Luat.Name = "label_Luat";
            this.label_Luat.Size = new System.Drawing.Size(40, 17);
            this.label_Luat.TabIndex = 13;
            this.label_Luat.Text = "Luật:";
            // 
            // comboBox_Ktn
            // 
            this.comboBox_Ktn.FormattingEnabled = true;
            this.comboBox_Ktn.Items.AddRange(new object[] {
            "Tốt",
            "TB",
            "Kém"});
            this.comboBox_Ktn.Location = new System.Drawing.Point(132, 114);
            this.comboBox_Ktn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Ktn.Name = "comboBox_Ktn";
            this.comboBox_Ktn.Size = new System.Drawing.Size(108, 24);
            this.comboBox_Ktn.TabIndex = 12;
            this.comboBox_Ktn.Text = "Nhập giá trị";
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Delete.Location = new System.Drawing.Point(449, 117);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(67, 28);
            this.button_Delete.TabIndex = 10;
            this.button_Delete.Text = "Xóa";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Insert
            // 
            this.button_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_Insert.Location = new System.Drawing.Point(323, 117);
            this.button_Insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(67, 28);
            this.button_Insert.TabIndex = 8;
            this.button_Insert.Text = "Thêm";
            this.button_Insert.UseVisualStyleBackColor = false;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // comboBox_ChamChi
            // 
            this.comboBox_ChamChi.FormattingEnabled = true;
            this.comboBox_ChamChi.Items.AddRange(new object[] {
            "Cao",
            "TB",
            "Thấp"});
            this.comboBox_ChamChi.Location = new System.Drawing.Point(132, 70);
            this.comboBox_ChamChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_ChamChi.Name = "comboBox_ChamChi";
            this.comboBox_ChamChi.Size = new System.Drawing.Size(108, 24);
            this.comboBox_ChamChi.TabIndex = 7;
            this.comboBox_ChamChi.Text = "Nhập giá trị";
            this.comboBox_ChamChi.SelectedIndexChanged += new System.EventHandler(this.comboBox_ChamChi_SelectedIndexChanged);
            // 
            // comboBox_DoKho
            // 
            this.comboBox_DoKho.FormattingEnabled = true;
            this.comboBox_DoKho.Items.AddRange(new object[] {
            "Khó",
            "Vừa",
            "Dễ"});
            this.comboBox_DoKho.Location = new System.Drawing.Point(419, 34);
            this.comboBox_DoKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_DoKho.Name = "comboBox_DoKho";
            this.comboBox_DoKho.Size = new System.Drawing.Size(108, 24);
            this.comboBox_DoKho.TabIndex = 5;
            this.comboBox_DoKho.Text = "Nhập giá trị";
            // 
            // comboBox_KetQua
            // 
            this.comboBox_KetQua.FormattingEnabled = true;
            this.comboBox_KetQua.Items.AddRange(new object[] {
            "Tốt",
            "TB",
            "Kém"});
            this.comboBox_KetQua.Location = new System.Drawing.Point(419, 76);
            this.comboBox_KetQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_KetQua.Name = "comboBox_KetQua";
            this.comboBox_KetQua.Size = new System.Drawing.Size(108, 24);
            this.comboBox_KetQua.TabIndex = 4;
            this.comboBox_KetQua.Text = "Nhập giá trị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Độ khó:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kiến thức nền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chăm chỉ:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_ThongTinChiTIet);
            this.Controls.Add(this.grbox_tapluat);
            this.Name = "FormLuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLuat";
            this.Load += new System.EventHandler(this.FormLuat_Load);
            this.grbox_tapluat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_display)).EndInit();
            this.groupBox_ThongTinChiTIet.ResumeLayout(false);
            this.groupBox_ThongTinChiTIet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbox_tapluat;
        private System.Windows.Forms.GroupBox groupBox_ThongTinChiTIet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ChamChi;
        private System.Windows.Forms.ComboBox comboBox_DoKho;
        private System.Windows.Forms.ComboBox comboBox_KetQua;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.DataGridView dgv_display;
        private System.Windows.Forms.ComboBox comboBox_Ktn;
        private System.Windows.Forms.Label label_Luat;
        private System.Windows.Forms.TextBox textBox_MaLuat;
    }
}