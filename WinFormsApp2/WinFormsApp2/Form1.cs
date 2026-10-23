namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.txt)|(*.txt)";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Кнопка "Добавить": пишем строку в конец текста
        private void add_Click(object sender, EventArgs e)
        {
            string fam = textBox1.Text.Trim();

            if (fam == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }

            string line = "\"" + fam + "\" - приглашен на вечеринку";

            // чтобы каждая запись начиналась с новой строки
            if (richTextBox1.Text.Length > 0 && !richTextBox1.Text.EndsWith("\n"))
            {
                richTextBox1.AppendText("\n");
            }

            richTextBox1.AppendText(line + "\n");

            textBox1.Clear();
            textBox1.Focus();
        }

        private void сохраниьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                string filename = saveFileDialog1.FileName;
                File.WriteAllText(filename, richTextBox1.Text);
                MessageBox.Show("Файл сохранен");
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                string filename = openFileDialog1.FileName;
                string fileText = File.ReadAllText(filename);
                richTextBox1.Text = fileText;
                MessageBox.Show("Файл открыт");
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength != 0)
            {
                richTextBox1.Copy();
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength != 0)
            {
                richTextBox1.Paste();
            }
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength != 0)
            {
                richTextBox1.Cut();
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void фонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }
    }
}
