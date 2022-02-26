namespace WinFormsApp1
{
    partial class TextProcessForm
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
            this.StartStopButton = new System.Windows.Forms.Button();
            this.LoadTextFileButton = new System.Windows.Forms.Button();
            this.InsertTextInput = new System.Windows.Forms.TextBox();
            this.textViewer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSwitch
            // 
            this.StartStopButton.Location = new System.Drawing.Point(558, 235);
            this.StartStopButton.Name = "bSwitch";
            this.StartStopButton.Size = new System.Drawing.Size(214, 23);
            this.StartStopButton.TabIndex = 0;
            this.StartStopButton.Text = "Старт";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // bLoad
            // 
            this.LoadTextFileButton.Location = new System.Drawing.Point(558, 12);
            this.LoadTextFileButton.Name = "bLoad";
            this.LoadTextFileButton.Size = new System.Drawing.Size(214, 23);
            this.LoadTextFileButton.TabIndex = 1;
            this.LoadTextFileButton.Text = "Открыть *.TXT";
            this.LoadTextFileButton.UseVisualStyleBackColor = true;
            this.LoadTextFileButton.Click += new System.EventHandler(this.LoadTextFileButton_Click);
            // 
            // textBox
            // 
            this.InsertTextInput.Location = new System.Drawing.Point(558, 206);
            this.InsertTextInput.Name = "textBox";
            this.InsertTextInput.Size = new System.Drawing.Size(214, 23);
            this.InsertTextInput.TabIndex = 2;
            // 
            // listBox1
            // 
            this.textViewer.FormattingEnabled = true;
            this.textViewer.HorizontalScrollbar = true;
            this.textViewer.ItemHeight = 15;
            this.textViewer.Location = new System.Drawing.Point(12, 12);
            this.textViewer.Name = "listBox1";
            this.textViewer.ScrollAlwaysVisible = true;
            this.textViewer.Size = new System.Drawing.Size(532, 439);
            this.textViewer.TabIndex = 3;
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
            this.Controls.Add(this.textViewer);
            this.Controls.Add(this.InsertTextInput);
            this.Controls.Add(this.LoadTextFileButton);
            this.Controls.Add(this.StartStopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Тестовая задача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartStopButton;
        private Button LoadTextFileButton;
        private TextBox InsertTextInput;
        private ListBox textViewer;
        private Label label1;
    }
}