namespace WinFormsApp1    
{
    public partial class TextProcessForm : Form
    {
        public TextProcessForm()
        {
            InitializeComponent();
        }
        string[] textData;
        bool active = false;

        public void textProcess()
        {
            while (active)
            {

               Random Rand = new Random();
               int stringNumber = Rand.Next(0, textData.Length);
               textData[stringNumber] = textData[stringNumber].Insert(new Random().Next(0, textData[stringNumber].Length), textImput.Text);
               if (textViewer.InvokeRequired)
               {
                textViewer.Invoke(new Action(() => textViewer.Items.Clear()));
                textViewer.Invoke(new Action(() => textViewer.Items.AddRange(textData)));
               }
               Thread.Sleep(5000);
            }

        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openTXTfileDialog = new OpenFileDialog();
            openTXTfileDialog.Title = "Выберете файл";
            openTXTfileDialog.InitialDirectory = @"C:\";
            openTXTfileDialog.Filter = "текстовые файлы (*.txt)|*.txt;|Все файлы|*.*";
            if (openTXTfileDialog.ShowDialog() == DialogResult.OK)
            {
                textData = File.ReadAllLines(openTXTfileDialog.FileName);
                textViewer.Items.Clear();
                textViewer.Items.AddRange(textData);
            }

        }


        private void bSwitch_Click(object sender, EventArgs e)
        {
            if (!active)
            {
               if ((textViewer.Items.Count == 0)||(String.IsNullOrEmpty(textImput.Text)))
                  MessageBox.Show("Невозможно запустить программу пока не будет загружен не пустой TXT файл и не заполненно поле ввода");
               else
               {
                    StartStopButton.Text = "Стоп";
                    LoadDataButton.Enabled = false;
                    textImput.Enabled = false;
                    active = true;
                    Thread textProcessThread = new Thread(textProcess);
                    textProcessThread.IsBackground = true;
                    textProcessThread.Start();
               }
            }
            else
            {
                StartStopButton.Text = "Старт";
                active = false;
                LoadDataButton.Enabled = true;
                textImput.Enabled = true;

            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            active = false;

        }

    }
}
