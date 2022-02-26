namespace WinFormsApp1    
{
    public partial class TextProcessForm : Form
    {
        public TextProcessForm()
        {
            InitializeComponent();
        }
        string[] textArray;
        bool active = false;

        public void textProcess()
        {
            while (active)
            {

               Random Rand = new Random();
               int kuda = Rand.Next(0, textArray.Length);
               textArray[kuda] = textArray[kuda].Insert(new Random().Next(0, textArray[kuda].Length), textBox.Text);
               if (listBox1.InvokeRequired)
               {
                listBox1.Invoke(new Action(() => listBox1.Items.Clear()));
                listBox1.Invoke(new Action(() => listBox1.Items.AddRange(textArray)));
               }
               Thread.Sleep(5000);
            }

        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fd = new OpenFileDialog();
            Fd.Title = "Выберете файл";
            Fd.InitialDirectory = @"C:\";
            Fd.Filter = "текстовые файлы (*.txt)|*.txt;|Все файлы|*.*";
            if (Fd.ShowDialog() == DialogResult.OK)
            {
                textArray = File.ReadAllLines(Fd.FileName);
                listBox1.Items.Clear();
                listBox1.Items.AddRange(textArray);
            }

        }


        private void bSwitch_Click(object sender, EventArgs e)
        {
            if (!active)
            {
               if ((listBox1.Items.Count == 0)||(String.IsNullOrEmpty(textBox.Text)))
                  MessageBox.Show("Невозможно запустить программу пока не будет загружен не пустой TXT файл и не заполненно поле ввода");
               else
               {
                    bSwitch.Text = "Стоп";
                    bLoad.Enabled = false;
                    textBox.Enabled = false;
                    active = true;
                    Thread textProcessThread = new Thread(textProcess);
                    textProcessThread.IsBackground = true;
                    textProcessThread.Start();
               }
            }
            else
            {
                bSwitch.Text = "Старт";
                active = false;
                bLoad.Enabled = true;
                textBox.Enabled = true;

            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            active = false;

        }

    }
}