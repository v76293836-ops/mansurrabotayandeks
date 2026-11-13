namespace мб
{
    public partial class Form1 : Form
    {
        private List<string> objects = new();

        public Form1()
        {
            InitializeComponent();
            LoadInitialData();
        }

        private void LoadInitialData()
        {
            // Загрузка данных по умолчанию
            objects.Add("Луна");
            objects.Add("Марс");
            objects.Add("Сатурн");
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvObjects.Rows.Clear();
            for (int i = 0; i < objects.Count; i++)
            {
                dgvObjects.Rows.Add((i + 1).ToString(), objects[i]);
            }
            UpdateCount();
        }

        private void UpdateCount()
        {
            lblCount.Text = $"Объектов: {objects.Count}";
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            // Диалог для ввода нового объекта
            string? input = PromptForInput("Введите название объекта:", "Добавить объект");
            if (!string.IsNullOrWhiteSpace(input))
            {
                objects.Add(input.Trim());
                RefreshGrid();
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvObjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = dgvObjects.SelectedRows[0].Index;
            if (rowIndex >= 0 && rowIndex < objects.Count)
            {
                var result = MessageBox.Show(
                    $"Уверены, что хотите удалить '{objects[rowIndex]}'?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    objects.RemoveAt(rowIndex);
                    RefreshGrid();
                }
            }
        }

        private void BtnSort_Click(object? sender, EventArgs e)
        {
            objects.Sort();
            RefreshGrid();
        }

        private string? PromptForInput(string prompt, string title)
        {
            Form promptForm = new Form();
            promptForm.Text = title;
            promptForm.Width = 400;
            promptForm.Height = 150;
            promptForm.BackColor = Color.FromArgb(30, 45, 65);
            promptForm.ForeColor = Color.White;
            promptForm.StartPosition = FormStartPosition.CenterParent;
            promptForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            promptForm.MaximizeBox = false;
            promptForm.MinimizeBox = false;

            Label label = new Label();
            label.Text = prompt;
            label.Left = 20;
            label.Top = 20;
            label.Width = 350;
            label.ForeColor = Color.White;
            promptForm.Controls.Add(label);

            TextBox textBox = new TextBox();
            textBox.Left = 20;
            textBox.Top = 50;
            textBox.Width = 350;
            promptForm.Controls.Add(textBox);

            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Left = 220;
            btnOK.Top = 90;
            btnOK.Width = 70;
            btnOK.BackColor = Color.FromArgb(50, 180, 160);
            btnOK.ForeColor = Color.White;
            btnOK.FlatStyle = FlatStyle.Flat;
            promptForm.Controls.Add(btnOK);

            Button btnCancel = new Button();
            btnCancel.Text = "Отмена";
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Left = 300;
            btnCancel.Top = 90;
            btnCancel.Width = 70;
            btnCancel.BackColor = Color.FromArgb(60, 75, 100);
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            promptForm.Controls.Add(btnCancel);

            promptForm.AcceptButton = btnOK;
            promptForm.CancelButton = btnCancel;

            return promptForm.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }
    }
}
