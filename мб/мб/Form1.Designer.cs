namespace мб
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblCount = new Label();
            pnlHeader = new Panel();
            lblHeaderPlan = new Label();
            dgvObjects = new DataGridView();
            colNumber = new DataGridViewTextBoxColumn();
            colObject = new DataGridViewTextBoxColumn();
            lblInstruction = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSort = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvObjects).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Космический журнал";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.LightGray;
            lblSubtitle.Location = new Point(20, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(500, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Список объектов для наблюдения";
            // 
            // lblCount
            // 
            lblCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCount.ForeColor = Color.Cyan;
            lblCount.Location = new Point(600, 35);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(180, 30);
            lblCount.TabIndex = 2;
            lblCount.Text = "Объектов: 0";
            lblCount.TextAlign = ContentAlignment.TopRight;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(20, 35, 50);
            pnlHeader.Controls.Add(lblHeaderPlan);
            pnlHeader.Location = new Point(20, 100);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(760, 30);
            pnlHeader.TabIndex = 3;
            // 
            // lblHeaderPlan
            // 
            lblHeaderPlan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHeaderPlan.ForeColor = Color.White;
            lblHeaderPlan.Location = new Point(10, 5);
            lblHeaderPlan.Name = "lblHeaderPlan";
            lblHeaderPlan.Size = new Size(200, 20);
            lblHeaderPlan.TabIndex = 0;
            lblHeaderPlan.Text = "План наблюдений";
            // 
            // dgvObjects
            // 
            dgvObjects.AllowUserToAddRows = false;
            dgvObjects.AllowUserToDeleteRows = false;
            dgvObjects.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 245, 250);
            dgvObjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvObjects.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 35, 50);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvObjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvObjects.ColumnHeadersHeight = 30;
            dgvObjects.Columns.AddRange(new DataGridViewColumn[] { colNumber, colObject });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(100, 180, 200);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvObjects.DefaultCellStyle = dataGridViewCellStyle3;
            dgvObjects.Location = new Point(20, 130);
            dgvObjects.MultiSelect = false;
            dgvObjects.Name = "dgvObjects";
            dgvObjects.RowHeadersVisible = false;
            dgvObjects.RowHeadersWidth = 51;
            dgvObjects.ScrollBars = ScrollBars.Vertical;
            dgvObjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvObjects.Size = new Size(760, 250);
            dgvObjects.TabIndex = 4;
            // 
            // colNumber
            // 
            colNumber.HeaderText = "№";
            colNumber.MinimumWidth = 6;
            colNumber.Name = "colNumber";
            colNumber.ReadOnly = true;
            colNumber.Width = 50;
            // 
            // colObject
            // 
            colObject.HeaderText = "Объект";
            colObject.MinimumWidth = 6;
            colObject.Name = "colObject";
            colObject.ReadOnly = true;
            colObject.Width = 700;
            // 
            // lblInstruction
            // 
            lblInstruction.Font = new Font("Segoe UI", 9F);
            lblInstruction.ForeColor = Color.LightGray;
            lblInstruction.Location = new Point(20, 390);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(400, 20);
            lblInstruction.TabIndex = 5;
            lblInstruction.Text = "Выберите строку и нажмите «Удалить».";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(50, 180, 160);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(20, 420);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 40);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(60, 75, 100);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(190, 420);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 40);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.FromArgb(60, 75, 100);
            btnSort.Cursor = Cursors.Hand;
            btnSort.FlatAppearance.BorderSize = 0;
            btnSort.FlatStyle = FlatStyle.Flat;
            btnSort.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSort.ForeColor = Color.White;
            btnSort.Location = new Point(630, 420);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(150, 40);
            btnSort.TabIndex = 8;
            btnSort.Text = "По алфавиту";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += BtnSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 45, 65);
            ClientSize = new Size(800, 500);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(lblCount);
            Controls.Add(pnlHeader);
            Controls.Add(dgvObjects);
            Controls.Add(lblInstruction);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnSort);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Космический журнал";
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvObjects).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblCount;
        private Panel pnlHeader;
        private Label lblHeaderPlan;
        private DataGridView dgvObjects;
        private Label lblInstruction;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSort;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colObject;
    }
}
