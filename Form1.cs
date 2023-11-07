namespace basit_hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string? islem1, islem2, operator1;
        private int int_islem1, int_islem2, sonuc;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            label1.Text += "00";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }


        private void btn_2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }
        private void btn_q_Click(object sender, EventArgs e)
        {
            label1.Text += ",";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            islem1 = label1.Text;
            label1.Text = "";
            operator1 = "+";

        }

        private void btn_nega_Click(object sender, EventArgs e)
        {
            islem1 = label1.Text;
            label1.Text = "";
            operator1 = "-";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            islem1 = label1.Text;
            label1.Text = "";
            operator1 = "/";
        }
        private void btn_product_Click(object sender, EventArgs e)
        {
            islem1 = label1.Text;
            label1.Text = "";
            operator1 = "*";
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
                return;
            string eski = label1.Text;
            string yeni = eski.Substring(0, eski.Length - 1);
            label1.Text = yeni;

        }
        private void btn_equals_Click(object sender, EventArgs e)
        {
            if (operator1 == null)
            {
                MessageBox.Show("Ýþlem yapmadan eþittire mi basýyon enai ::DD", "ENAYÝ ALERT");
                return;
            }

            islem2 = label1.Text;
            label1.Text = "";
            int_islem1 = Convert.ToInt32(islem1);
            int_islem2 = Convert.ToInt32(islem2);
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            switch (operator1)
            {
                case "+":
                    sonuc = int_islem1 + int_islem2;
                    break;
                case "-":
                    sonuc = int_islem2 - int_islem1;
                    break;
                case "*":
                    sonuc = int_islem2 * int_islem1;
                    break;
                case "/":
                    if (int_islem2 == 0)
                    {
                        MessageBox.Show("SIFIRA BÖLME HATASI");
                        return;
                    }
                    sonuc = int_islem1 / int_islem2;
                    break;
            }
            progressBar1.Value = 100;
            label1.Text = Convert.ToString(sonuc);
            MessageBox.Show("OMAYGAT ÝÞLEMÝNÝZ TAMAMLANDI ÝÞTE SONUÇ: " + sonuc, "HELAL LAN");
            progressBar1.Value = 0;
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}