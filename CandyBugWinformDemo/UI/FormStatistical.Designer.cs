﻿
namespace CandyBugWinformDemo.NewFolder1
{
    partial class FormStatistical
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btPageNumber = new System.Windows.Forms.Button();
            this.btnPreviours = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.panelHienThiThongTIn = new System.Windows.Forms.Panel();
            this.labelTimKiem = new System.Windows.Forms.Label();
            this.labelTongSoOrder = new System.Windows.Forms.Label();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.textBoxTongOrder = new System.Windows.Forms.TextBox();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.dataGridViewStatistical = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelHienThiThongTIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistical)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerTo);
            this.panel1.Controls.Add(this.dateTimePickerFrom);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 68);
            this.panel1.TabIndex = 2;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarForeColor = System.Drawing.Color.Brown;
            this.dateTimePickerTo.CalendarTitleBackColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(201, 28);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(104, 20);
            this.dateTimePickerTo.TabIndex = 4;
            this.dateTimePickerTo.Value = new System.DateTime(2021, 10, 29, 21, 54, 57, 0);
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarTitleBackColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(46, 28);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(104, 20);
            this.dateTimePickerFrom.TabIndex = 4;
            this.dateTimePickerFrom.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.SpringGreen;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Location = new System.Drawing.Point(541, 21);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(78, 32);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(449, 21);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 32);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnLast);
            this.panel3.Controls.Add(this.btPageNumber);
            this.panel3.Controls.Add(this.btnPreviours);
            this.panel3.Controls.Add(this.btnFirst);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 470);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(637, 52);
            this.panel3.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Moccasin;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(472, 10);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(78, 32);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.BackColor = System.Drawing.Color.Moccasin;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.Black;
            this.btnLast.Location = new System.Drawing.Point(554, 10);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(78, 32);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // btPageNumber
            // 
            this.btPageNumber.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btPageNumber.BackColor = System.Drawing.Color.Moccasin;
            this.btPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPageNumber.ForeColor = System.Drawing.Color.Black;
            this.btPageNumber.Location = new System.Drawing.Point(278, 10);
            this.btPageNumber.Margin = new System.Windows.Forms.Padding(2);
            this.btPageNumber.Name = "btPageNumber";
            this.btPageNumber.Size = new System.Drawing.Size(78, 32);
            this.btPageNumber.TabIndex = 3;
            this.btPageNumber.Text = "1";
            this.btPageNumber.UseVisualStyleBackColor = false;
            // 
            // btnPreviours
            // 
            this.btnPreviours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreviours.BackColor = System.Drawing.Color.Moccasin;
            this.btnPreviours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviours.ForeColor = System.Drawing.Color.Black;
            this.btnPreviours.Location = new System.Drawing.Point(92, 10);
            this.btnPreviours.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreviours.Name = "btnPreviours";
            this.btnPreviours.Size = new System.Drawing.Size(78, 32);
            this.btnPreviours.TabIndex = 3;
            this.btnPreviours.Text = "Previours";
            this.btnPreviours.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.BackColor = System.Drawing.Color.Moccasin;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.Black;
            this.btnFirst.Location = new System.Drawing.Point(9, 10);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(78, 32);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = false;
            // 
            // panelHienThiThongTIn
            // 
            this.panelHienThiThongTIn.Controls.Add(this.labelTimKiem);
            this.panelHienThiThongTIn.Controls.Add(this.labelTongSoOrder);
            this.panelHienThiThongTIn.Controls.Add(this.labelTongTien);
            this.panelHienThiThongTIn.Controls.Add(this.textBoxTongOrder);
            this.panelHienThiThongTIn.Controls.Add(this.textBoxTongTien);
            this.panelHienThiThongTIn.Controls.Add(this.textBoxTimKiem);
            this.panelHienThiThongTIn.Location = new System.Drawing.Point(0, 73);
            this.panelHienThiThongTIn.Name = "panelHienThiThongTIn";
            this.panelHienThiThongTIn.Size = new System.Drawing.Size(637, 138);
            this.panelHienThiThongTIn.TabIndex = 6;
            this.panelHienThiThongTIn.Click += new System.EventHandler(this.panelHienThiThongTIn_Click);
            // 
            // labelTimKiem
            // 
            this.labelTimKiem.AutoSize = true;
            this.labelTimKiem.Location = new System.Drawing.Point(63, 100);
            this.labelTimKiem.Name = "labelTimKiem";
            this.labelTimKiem.Size = new System.Drawing.Size(52, 13);
            this.labelTimKiem.TabIndex = 6;
            this.labelTimKiem.Text = "Tìm kiếm:";
            // 
            // labelTongSoOrder
            // 
            this.labelTongSoOrder.AutoSize = true;
            this.labelTongSoOrder.Location = new System.Drawing.Point(371, 25);
            this.labelTongSoOrder.Name = "labelTongSoOrder";
            this.labelTongSoOrder.Size = new System.Drawing.Size(76, 13);
            this.labelTongSoOrder.TabIndex = 4;
            this.labelTongSoOrder.Text = "Tổng số order:";
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Location = new System.Drawing.Point(16, 25);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(102, 13);
            this.labelTongTien.TabIndex = 3;
            this.labelTongTien.Text = " Tổng tiền Payment:";
            // 
            // textBoxTongOrder
            // 
            this.textBoxTongOrder.Location = new System.Drawing.Point(450, 22);
            this.textBoxTongOrder.Name = "textBoxTongOrder";
            this.textBoxTongOrder.Size = new System.Drawing.Size(100, 20);
            this.textBoxTongOrder.TabIndex = 2;
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Location = new System.Drawing.Point(124, 22);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(100, 20);
            this.textBoxTongTien.TabIndex = 1;
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxTimKiem.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxTimKiem.Location = new System.Drawing.Point(124, 97);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(357, 20);
            this.textBoxTimKiem.TabIndex = 0;
            this.textBoxTimKiem.Text = "Tìm kiếm theo id của item, name của item";
            this.textBoxTimKiem.Click += new System.EventHandler(this.textBox1_Click);
            this.textBoxTimKiem.TextChanged += new System.EventHandler(this.textBoxTimKiem_TextChanged);
            this.textBoxTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTimKiem_KeyPress);
            // 
            // dataGridViewStatistical
            // 
            this.dataGridViewStatistical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistical.Location = new System.Drawing.Point(0, 217);
            this.dataGridViewStatistical.Name = "dataGridViewStatistical";
            this.dataGridViewStatistical.Size = new System.Drawing.Size(637, 248);
            this.dataGridViewStatistical.TabIndex = 7;
            // 
            // FormStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 522);
            this.Controls.Add(this.dataGridViewStatistical);
            this.Controls.Add(this.panelHienThiThongTIn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormStatistical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormStatistical_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelHienThiThongTIn.ResumeLayout(false);
            this.panelHienThiThongTIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btPageNumber;
        private System.Windows.Forms.Button btnPreviours;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Panel panelHienThiThongTIn;
        private System.Windows.Forms.Label labelTongSoOrder;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.TextBox textBoxTongOrder;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Label labelTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewStatistical;
    }
}