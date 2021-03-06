﻿namespace Hado.PL.Forms.Lesson
{
    partial class _DeleteLesson
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReduction = new System.Windows.Forms.Button();
            this.lblDeleteLesson = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlLessonName = new System.Windows.Forms.Panel();
            this.txtBoxLessonName = new System.Windows.Forms.TextBox();
            this.lblLessonName = new System.Windows.Forms.Label();
            this.pnlId = new System.Windows.Forms.Panel();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvLessons = new System.Windows.Forms.DataGridView();
            this.LessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.btnClose);
            this.pnl1.Controls.Add(this.btnReduction);
            this.pnl1.Controls.Add(this.lblDeleteLesson);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(403, 54);
            this.pnl1.TabIndex = 73;
            this.pnl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnClose.Location = new System.Drawing.Point(359, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 42);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnReduction
            // 
            this.btnReduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReduction.BackColor = System.Drawing.SystemColors.Control;
            this.btnReduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReduction.FlatAppearance.BorderSize = 0;
            this.btnReduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReduction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnReduction.Location = new System.Drawing.Point(312, 0);
            this.btnReduction.Name = "btnReduction";
            this.btnReduction.Size = new System.Drawing.Size(41, 42);
            this.btnReduction.TabIndex = 33;
            this.btnReduction.Text = "_";
            this.btnReduction.UseVisualStyleBackColor = false;
            this.btnReduction.Click += new System.EventHandler(this.BtnReduction_Click);
            // 
            // lblDeleteLesson
            // 
            this.lblDeleteLesson.AutoSize = true;
            this.lblDeleteLesson.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeleteLesson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblDeleteLesson.Location = new System.Drawing.Point(12, 12);
            this.lblDeleteLesson.Name = "lblDeleteLesson";
            this.lblDeleteLesson.Size = new System.Drawing.Size(95, 30);
            this.lblDeleteLesson.TabIndex = 1;
            this.lblDeleteLesson.Text = "Ders Sil";
            this.lblDeleteLesson.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblDeleteLesson_MouseDown);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(19, 586);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(363, 52);
            this.btnDelete.TabIndex = 81;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlSearch.Location = new System.Drawing.Point(19, 286);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(361, 5);
            this.pnlSearch.TabIndex = 80;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxSearch.Location = new System.Drawing.Point(19, 258);
            this.txtBoxSearch.Multiline = true;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(362, 22);
            this.txtBoxSearch.TabIndex = 78;
            this.txtBoxSearch.TabStopChanged += new System.EventHandler(this.TxtBoxSearch_TabStopChanged);
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.TxtBoxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblSearch.Location = new System.Drawing.Point(14, 234);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(43, 21);
            this.lblSearch.TabIndex = 79;
            this.lblSearch.Text = "Ara:";
            // 
            // pnlLessonName
            // 
            this.pnlLessonName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlLessonName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlLessonName.Location = new System.Drawing.Point(18, 195);
            this.pnlLessonName.Name = "pnlLessonName";
            this.pnlLessonName.Size = new System.Drawing.Size(361, 5);
            this.pnlLessonName.TabIndex = 76;
            // 
            // txtBoxLessonName
            // 
            this.txtBoxLessonName.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxLessonName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxLessonName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxLessonName.Location = new System.Drawing.Point(18, 167);
            this.txtBoxLessonName.Multiline = true;
            this.txtBoxLessonName.Name = "txtBoxLessonName";
            this.txtBoxLessonName.ReadOnly = true;
            this.txtBoxLessonName.Size = new System.Drawing.Size(362, 22);
            this.txtBoxLessonName.TabIndex = 74;
            // 
            // lblLessonName
            // 
            this.lblLessonName.AutoSize = true;
            this.lblLessonName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLessonName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblLessonName.Location = new System.Drawing.Point(13, 143);
            this.lblLessonName.Name = "lblLessonName";
            this.lblLessonName.Size = new System.Drawing.Size(78, 21);
            this.lblLessonName.TabIndex = 75;
            this.lblLessonName.Text = "Ders Adı:";
            // 
            // pnlId
            // 
            this.pnlId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.pnlId.Location = new System.Drawing.Point(18, 120);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(361, 5);
            this.pnlId.TabIndex = 84;
            // 
            // txtBoxId
            // 
            this.txtBoxId.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxId.Location = new System.Drawing.Point(18, 92);
            this.txtBoxId.Multiline = true;
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.Size = new System.Drawing.Size(362, 22);
            this.txtBoxId.TabIndex = 82;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.lblId.Location = new System.Drawing.Point(13, 68);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(67, 21);
            this.lblId.TabIndex = 83;
            this.lblId.Text = "Ders Id:";
            // 
            // dgvLessons
            // 
            this.dgvLessons.AllowUserToResizeColumns = false;
            this.dgvLessons.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvLessons.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLessons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvLessons.BackgroundColor = System.Drawing.Color.White;
            this.dgvLessons.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLessons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLessons.ColumnHeadersHeight = 35;
            this.dgvLessons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LessonName,
            this.LessonId,
            this.TeacherId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLessons.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLessons.EnableHeadersVisualStyles = false;
            this.dgvLessons.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvLessons.Location = new System.Drawing.Point(19, 297);
            this.dgvLessons.MultiSelect = false;
            this.dgvLessons.Name = "dgvLessons";
            this.dgvLessons.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLessons.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLessons.RowHeadersVisible = false;
            this.dgvLessons.RowTemplate.Height = 35;
            this.dgvLessons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLessons.Size = new System.Drawing.Size(364, 259);
            this.dgvLessons.TabIndex = 87;
            this.dgvLessons.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLessons_RowEnter);
            // 
            // LessonName
            // 
            this.LessonName.DataPropertyName = "LessonName";
            this.LessonName.HeaderText = "Ders Adı";
            this.LessonName.Name = "LessonName";
            this.LessonName.ReadOnly = true;
            this.LessonName.Width = 94;
            // 
            // LessonId
            // 
            this.LessonId.DataPropertyName = "LessonId";
            this.LessonId.HeaderText = "Ders Id";
            this.LessonId.Name = "LessonId";
            this.LessonId.ReadOnly = true;
            this.LessonId.Visible = false;
            this.LessonId.Width = 83;
            // 
            // TeacherId
            // 
            this.TeacherId.DataPropertyName = "TeacherId";
            this.TeacherId.HeaderText = "Öğretmen Id";
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.ReadOnly = true;
            this.TeacherId.Visible = false;
            this.TeacherId.Width = 126;
            // 
            // _DeleteLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 696);
            this.Controls.Add(this.dgvLessons);
            this.Controls.Add(this.pnlId);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pnlLessonName);
            this.Controls.Add(this.txtBoxLessonName);
            this.Controls.Add(this.lblLessonName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_DeleteLesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_DeleteLesson";
            this.Load += new System.EventHandler(this._DeleteLesson_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReduction;
        private System.Windows.Forms.Label lblDeleteLesson;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlLessonName;
        private System.Windows.Forms.TextBox txtBoxLessonName;
        private System.Windows.Forms.Label lblLessonName;
        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvLessons;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
    }
}