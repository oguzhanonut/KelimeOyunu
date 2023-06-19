namespace kelimeOyunuOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 60;
        int harf;
        string kelime;
        int puan = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            backgroundWorker1.RunWorkerAsync();
            label1.Text = "60 sn";
            timer1.Start();
            sayac = 60;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            kelime =  textBox1.Text.ToLower();
            if(harf ==1 & kelime.Substring(0,1).ToLower()=="y")
            {
                listBox1.Items.Add(kelime);
                puan += 1;
                label2.Text = puan.ToString();
            }
            else if (harf == 2 & kelime.Substring(0, 1).ToLower() == "z")
            {
                listBox1.Items.Add(kelime);
                puan += 1;
                label2.Text = puan.ToString();
            }
            else if (harf == 3 & kelime.Substring(0, 1).ToLower() == "t")
            {
                listBox1.Items.Add(kelime);
                puan += 1;
                label2.Text = puan.ToString();
            }
            else if (harf == 4 & kelime.Substring(0, 1).ToLower() == "u")
            {
                listBox1.Items.Add(kelime);
                puan += 1;
                label2.Text = puan.ToString();
            }
            else if (harf == 5 & kelime.Substring(0, 1).ToLower() == "f")
            {
                listBox1.Items.Add(kelime);
                puan += 1;
                label2.Text = puan.ToString();
            }
            else if (harf == 6 & kelime.Substring(0, 1).ToLower() == "m")
            {
                listBox1.Items.Add(kelime);
                puan += 1;
                label2.Text = puan.ToString();
            }
            else
            {
                MessageBox.Show("hatalý isim");
                puan -= 1;
                label2.Text = puan.ToString();
            }
            textBox1.Text = "";

            for (int b =0 ; b<listBox1.Items.Count-1 ;b++)
            {
                if (kelime == listBox1.Items[b].ToString())
                {
                    listBox1.Items.RemoveAt(b);
                    puan -= 1;
                    label2.Text = puan.ToString();
                    MessageBox.Show("Bu Ýsmi Eklemiþtiniz Oyun Bitti.");
                    button1.Enabled = false;
                    button2.Enabled = false;
                }

            }
            textBox1.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            label1.Text = sayac.ToString() + "" + "sn";
            if(label1.Text== "0sn")
            {
                timer1.Stop();
                puan = puan - 1;
                label2.Text = puan.ToString();
                MessageBox.Show("Süreniz Doldu.");
                button1.Enabled = false;
                button2.Enabled = false;

            }

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Random r = new Random();
            harf = r.Next(1, 6);
            pictureBox1.BackgroundImage = Image.FromFile("Harfler\\" + harf.ToString() + ".jpg");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}