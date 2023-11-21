using System.Data;


namespace Calculator
{
    public partial class Form1 : Form
    {
        public string s;

        public string func(string s)
        {
            string s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ',')
                    s1 += '.';
                else
                    s1 += s[i];
            }
            return s1;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            textBox1.PlaceholderText = "";
            textBox1.Text += "8";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text += "%";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            if (textBox1.Text.Contains('\n'))
            {
                try
                {
                    DataTable dt = new DataTable();
                    var natija = dt.Compute(textBox1.Text, "");
                    textBox1.Text = natija.ToString();
                    s = textBox1.Text;
                    if (s.Contains(','))
                        s = func(s);
                    textBox1.Text = s;
                    textBox1.SelectionStart = s.Length;
                }
                catch
                {
                    textBox1.Text = "";
                    textBox1.PlaceholderText = "Error!!!";
                }

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text += "1";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text += "3";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text += "2";
        }

        private void button_4_Click(object sender, EventArgs e)
        {

            textBox1.PlaceholderText = "";
            textBox1.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text += "7";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text += "9";

        }

        private void button_C_Click(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text += "(";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text += ")";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text += ".";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "(")
            {
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                else if (textBox1.Text[0] != '-')
                    textBox1.Text = "-" + textBox1.Text;
            }
            else if (textBox1.Text != "" && textBox1.Text[0] == '(')
            {
                textBox1.Text = "";
            }
            else
                textBox1.Text = "(-";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text += "/";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text += "*";
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text += "-";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text += "+";
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            char c;
            string s = textBox1.Text;
            if (s != null)
            {

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = new DataTable();
                var natija = dt.Compute(textBox1.Text, "");
                textBox1.Text = natija.ToString();
                s = textBox1.Text;
                if (s.Contains(','))
                    s = func(s);
                textBox1.Text = s;

            }
            catch
            {
                textBox1.Text = "";
                textBox1.PlaceholderText = "Error!!!";
            }

        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "";
            textBox1.Text += "0";
        }
    }
}