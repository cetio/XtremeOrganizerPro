using System.Diagnostics;

namespace XtremeOrganizerPro鱼桌子音乐
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\ext.txt"))
                textBox1.Text = File.ReadAllText(Application.StartupPath + "\\ext.txt");

            if (File.Exists(Application.StartupPath + "\\src.txt"))
                textBox2.Text = File.ReadAllText(Application.StartupPath + "\\src.txt");

            if (File.Exists(Application.StartupPath + "\\dst.txt"))
                textBox3.Text = File.ReadAllText(Application.StartupPath + "\\dst.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button3.Text = "✅";
            }
            else
            {
                timer1.Enabled = true;
                button3.Text = "❎";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dir = string.Empty;
            foreach (string _dir in textBox2.Lines)
            {
                if (!Directory.Exists(_dir) && dir == string.Empty)
                    continue;

                if (Directory.Exists(_dir))
                    dir = _dir;

                foreach (FileInfo file in new DirectoryInfo(dir).EnumerateFiles())
                {
                    foreach (string extension in textBox1.Lines)
                    {
                        if (file.Extension == extension)
                        {
                            if (Array.IndexOf(textBox1.Lines, extension) >= textBox3.Lines.Length ||
                                !Directory.Exists(textBox3.Lines[Array.IndexOf(textBox1.Lines, extension)]) ||
                                textBox3.Lines[Array.IndexOf(textBox1.Lines, extension)] == dir)
                                continue;

                            try
                            {
                                File.Move(file.FullName, textBox3.Lines[Array.IndexOf(textBox1.Lines, extension)] + "\\" + file.Name);
                            }
                            catch (IOException)
                            {
                                // Let us lag!
                            }
                        }
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 1 * 60 * 1000;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 10 * 60 * 1000;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 30 * 60 * 1000;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 60 * 60 * 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.StartupPath + "\\ext.txt", textBox1.Text);
            File.WriteAllText(Application.StartupPath + "\\src.txt", textBox2.Text);
            File.WriteAllText(Application.StartupPath + "\\dst.txt", textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.ShowDialog();
            textBox1.Text = File.ReadAllText(ofd.FileName);
            ofd.ShowDialog();
            textBox2.Text = File.ReadAllText(ofd.FileName);
            ofd.ShowDialog();
            textBox3.Text = File.ReadAllText(ofd.FileName);
        }

        private void bzzzttWRONG_Tick(object sender, EventArgs e)
        {
            foreach (string dir in textBox3.Lines)
            {
                if (!Directory.Exists(dir))
                {
                    textBox3.ForeColor = Color.Red;
                    return;
                }
            }
            textBox3.ForeColor = Color.Black;
        }
    }
}
