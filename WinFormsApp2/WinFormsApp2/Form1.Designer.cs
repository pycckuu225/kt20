namespace WinFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            сохраниьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            вставкаToolStripMenuItem = new ToolStripMenuItem();
            копироватьToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            вырезатьToolStripMenuItem = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            фонToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            surname = new Label();
            add = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, вставкаToolStripMenuItem, шрифтToolStripMenuItem, фонToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохраниьToolStripMenuItem, открытьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(69, 29);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // сохраниьToolStripMenuItem
            // 
            сохраниьToolStripMenuItem.Name = "сохраниьToolStripMenuItem";
            сохраниьToolStripMenuItem.Size = new Size(193, 34);
            сохраниьToolStripMenuItem.Text = "Сохраниь";
            сохраниьToolStripMenuItem.Click += сохраниьToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(193, 34);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // вставкаToolStripMenuItem
            // 
            вставкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { копироватьToolStripMenuItem, вставитьToolStripMenuItem, вырезатьToolStripMenuItem });
            вставкаToolStripMenuItem.Name = "вставкаToolStripMenuItem";
            вставкаToolStripMenuItem.Size = new Size(90, 29);
            вставкаToolStripMenuItem.Text = "Вставка";
            // 
            // копироватьToolStripMenuItem
            // 
            копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            копироватьToolStripMenuItem.Size = new Size(211, 34);
            копироватьToolStripMenuItem.Text = "копировать";
            копироватьToolStripMenuItem.Click += копироватьToolStripMenuItem_Click;
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.Size = new Size(211, 34);
            вставитьToolStripMenuItem.Text = "вставить";
            вставитьToolStripMenuItem.Click += вставитьToolStripMenuItem_Click;
            // 
            // вырезатьToolStripMenuItem
            // 
            вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            вырезатьToolStripMenuItem.Size = new Size(211, 34);
            вырезатьToolStripMenuItem.Text = "вырезать";
            вырезатьToolStripMenuItem.Click += вырезатьToolStripMenuItem_Click;
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new Size(85, 29);
            шрифтToolStripMenuItem.Text = "Шрифт";
            шрифтToolStripMenuItem.Click += шрифтToolStripMenuItem_Click;
            // 
            // фонToolStripMenuItem
            // 
            фонToolStripMenuItem.Name = "фонToolStripMenuItem";
            фонToolStripMenuItem.Size = new Size(62, 29);
            фонToolStripMenuItem.Text = "Фон";
            фонToolStripMenuItem.Click += фонToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(10, 64);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(356, 359);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(403, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // surname
            // 
            surname.AutoSize = true;
            surname.Location = new Point(403, 48);
            surname.Name = "surname";
            surname.Size = new Size(85, 25);
            surname.TabIndex = 3;
            surname.Text = "Фамилия";
            // 
            // add
            // 
            add.Location = new Point(402, 113);
            add.Name = "add";
            add.Size = new Size(181, 89);
            add.TabIndex = 4;
            add.Text = "Добавить";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(add);
            Controls.Add(surname);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem вставкаToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem фонToolStripMenuItem;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label surname;
        private Button add;
        private ToolStripMenuItem сохраниьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
    }
}
