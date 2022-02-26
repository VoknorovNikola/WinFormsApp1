namespace WinFormsApp1
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
            this.bSwitch = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSwitch
            // 
            this.bSwitch.Location = new System.Drawing.Point(558, 235);
            this.bSwitch.Name = "bSwitch";
            this.bSwitch.Size = new System.Drawing.Size(214, 23);
            this.bSwitch.TabIndex = 0;
            this.bSwitch.Text = "Старт";
            this.bSwitch.UseVisualStyleBackColor = true;
            this.bSwitch.Click += new System.EventHandler(this.bSwitch_Click);
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(558, 12);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(214, 23);
            this.bLoad.TabIndex = 1;
            this.bLoad.Text = "Открыть *.TXT";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(558, 206);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(214, 23);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(532, 439);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 104);
            this.label1.MaximumSize = new System.Drawing.Size(200, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Для запуска необходимо загрузить не пустой текстовый файл и ввести текст в поле в" +
    "вода";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.bSwitch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Тестовая задача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bSwitch;
        private Button bLoad;
        private TextBox textBox;
        private ListBox listBox1;
        private Label label1;
    }
}