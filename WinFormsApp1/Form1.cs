namespace WinFormsApp1    
{
    public partial class TextProcessForm : Form
    {
        public TextProcessForm()
        {
            InitializeComponent();
        }

        string[] textData;
        bool modifyingText = false;

        public void textProcess()
        {
            while (modifyingText)
            {

               Random Rand = new Random();
               int stringNumber = Rand.Next(0, textData.Length);
               textData[stringNumber] = textData[stringNumber].Insert(Rand.Next(0, textData[stringNumber].Length), InsertTextInput.Text);
               if (textViewer.InvokeRequired)
               {
                    var refreshTextView = new Action(() =>
                    {
                         textViewer.Items.Clear();
                         textViewer.Items.AddRange(textData);
                    }
                    );

                    textViewer.Invoke(refreshTextView);

               }

               Thread.Sleep(5000);
            }
        }

        private void LoadTextFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openTextFileDialog = new OpenFileDialog();
            openTextFileDialog.Title = "Выберете файл";
            openTextFileDialog.InitialDirectory = @"C:\";
            openTextFileDialog.Filter = "текстовые файлы (*.txt)|*.txt;|Все файлы|*.*";
            if (openTextFileDialog.ShowDialog() == DialogResult.OK)
            {
                textData = File.ReadAllLines(openTextFileDialog.FileName);
                textViewer.Items.Clear();
                textViewer.Items.AddRange(textData);
            }
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (!modifyingText)
            {
               if ((textViewer.Items.Count == 0)||(String.IsNullOrEmpty(InsertTextInput.Text)))
                {
                    MessageBox.Show("Невозможно запустить программу пока не будет загружен не пустой TXT файл и не заполненно поле ввода");
                }
               else
                {
                    StartStopButton.Text = "Стоп";
                    LoadTextFileButton.Enabled = false;
                    InsertTextInput.Enabled = false;
                    modifyingText = true;
                    Thread textProcessThread = new Thread(textProcess);
                    textProcessThread.IsBackground = true;
                    textProcessThread.Start();
                }
            }
            else
            {
                StartStopButton.Text = "Старт";
                modifyingText = false;
                LoadTextFileButton.Enabled = true;
                InsertTextInput.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            modifyingText = false;

        }
    }
}
