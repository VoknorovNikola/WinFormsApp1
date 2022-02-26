namespace WinFormsApp1
    
{
    using System.Threading;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] DB_Path;
        bool deystv = false;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textProcess()
        {
            while (deystv)
            {

               string vvod;
               vvod = textBox.Text;
               Random Rand = new Random();
               int kuda = Rand.Next(0, DB_Path.Length);
               DB_Path[kuda] = DB_Path[kuda].Insert(new Random().Next(0, DB_Path[kuda].Length), vvod);
               if (listBox1.InvokeRequired)
               {
                listBox1.Invoke(new Action(() => listBox1.Items.Clear()));
                listBox1.Invoke(new Action(() => listBox1.Items.AddRange(DB_Path)));
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
                DB_Path = File.ReadAllLines(Fd.FileName);
                listBox1.Items.Clear();
                listBox1.Items.AddRange(DB_Path);
            }

        }


        private void bSwitch_Click(object sender, EventArgs e)
        {
            if (!deystv)
            {
               if ((listBox1.Items.Count == 0)||(String.IsNullOrEmpty(textBox.Text)))
                  MessageBox.Show("Невозможно запустить программу пока не будет загружен не пустой TXT файл и не заполненно поле ввода");
               else
               {
                    bSwitch.Text = "Стоп";
                    bLoad.Enabled = false;
                    textBox.Enabled = false;
                    deystv = true;
                    Thread textProcessThraed = new Thread(textProcess);
                    textProcessThraed.IsBackground = true;
                    textProcessThraed.Start();
               }
            }
            else
            {
                bSwitch.Text = "Старт";
                deystv = false;
                bLoad.Enabled = true;
                textBox.Enabled = true;

            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            deystv = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            deystv = false;
        }


    }
}