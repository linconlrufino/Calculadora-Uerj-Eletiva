namespace CalculadoraBase
{
    public partial class Form1 : Form
    {
        double v1, v2, resp;
        bool virgula = false;
        int operacao = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Operacoes
        private void bvirgula_Click(object sender, EventArgs e)
        {
            if (!virgula)
            {
                display.Text = display.Text + ",";
                virgula = true;
            }
        }

        private void bsoma_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 1;
                    v1 = Double.Parse(display.Text);
                    display.Text = "";
                    virgula = false;
                }
                catch (System.FormatException exp)
                {
                    MessageBox.Show("Erro no formato do número!");

                }
            }
        }

        private void bsubtracao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 2;
                    v1 = Double.Parse(display.Text);
                    display.Text = "";
                    virgula = false;
                }
                catch (System.FormatException exp)
                {
                    MessageBox.Show("Erro no formato do número!");
                }
            }
        }

        private void bmultiplicacao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 3;
                    v1 = Double.Parse(display.Text);
                    display.Text = "";
                    virgula = false;
                }
                catch (System.FormatException exp)
                {
                    MessageBox.Show("Erro no formato do número!");
                }
            }
        }

        private void bdivisao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 4;
                    v1 = Double.Parse(display.Text);
                    display.Text = "";
                    virgula = false;
                }
                catch (System.FormatException exp)
                {
                    MessageBox.Show("Erro no formato do número!");
                }
            }
        }

        private void braizquadrada_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    v1 = Double.Parse(display.Text);
                    display.Text = "";
                    //virgula = false;
                    //v2 = Double.Parse(display.Text);
                    resp = Math.Sqrt(v1);
                    display.Text = resp.ToString();
                    if ((int)resp < resp)
                    {
                        virgula = true;
                    }
                    else
                    {
                        virgula = false;
                    }
                }
                catch (System.FormatException exp)
                {
                    MessageBox.Show("Erro no formato do número!");
                }
            }
        }

        private void bpotenciaDe2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    v1 = Double.Parse(display.Text);
                    display.Text = "";
                    resp = Math.Pow(v1, 2);
                    display.Text = resp.ToString();
                    if ((int)resp < resp)
                    {
                        virgula = true;
                    }
                    else
                    {
                        virgula = false;
                    }
                }
                catch (System.FormatException exp)
                {
                    MessageBox.Show("Erro no formato do número!");
                }
            }

        }

        private void bpotenciaDe3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    v1 = Double.Parse(display.Text);
                    display.Text = "";
                    resp = Math.Pow(v1, 3);
                    display.Text = resp.ToString();
                    if ((int)resp < resp)
                    {
                        virgula = true;
                    }
                    else
                    {
                        virgula = false;
                    }
                }
                catch (System.FormatException exp)
                {
                    MessageBox.Show("Erro no formato do número!");
                }
            }

        }

        private void bLog_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    v1 = Double.Parse(display.Text);
                    display.Text = "";
                    resp = Math.Log(v1, 10);
                    display.Text = resp.ToString();
                    if ((int)resp < resp)
                    {
                        virgula = true;
                    }
                    else
                    {
                        virgula = false;
                    }
                }
                catch (System.FormatException exp)
                {
                    MessageBox.Show("Erro no formato do número!");
                }
            }
        }

        private void bTan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    v1 = Double.Parse(display.Text);
                    display.Text = "";
                    resp = Math.Tan(v1);
                    display.Text = resp.ToString();
                    if ((int)resp < resp)
                    {
                        virgula = true;
                    }
                    else
                    {
                        virgula = false;
                    }
                }
                catch (System.FormatException exp)
                {
                    MessageBox.Show("Erro no formato do número!");
                }
            }
        }

        private void bCos_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    v1 = Double.Parse(display.Text);
                    display.Text = "";
                    resp = Math.Cos(v1);
                    display.Text = resp.ToString();
                    if ((int)resp < resp)
                    {
                        virgula = true;
                    }
                    else
                    {
                        virgula = false;
                    }
                }
                catch (System.FormatException exp)
                {
                    MessageBox.Show("Erro no formato do número!");
                }
            }
        }

        private void bigual_Click(object sender, EventArgs e)
        {
            if (operacao == 1)
            {
                v2 = Double.Parse(display.Text);
                resp = v1 + v2;
                display.Text = resp.ToString();
                if ((int)resp < resp)
                {
                    virgula = true;
                }
                else
                {
                    virgula = false;
                }
            }

            if (operacao == 2)
            {
                v2 = Double.Parse(display.Text);
                resp = v1 - v2;
                display.Text = resp.ToString();
                if ((int)resp < resp)
                {
                    virgula = true;
                }
                else
                {
                    virgula = false;
                }
            }

            if (operacao == 3)
            {
                v2 = Double.Parse(display.Text);
                resp = v1 * v2;
                display.Text = resp.ToString();
                if ((int)resp < resp)
                {
                    virgula = true;
                }
                else
                {
                    virgula = false;
                }
            }

            if (operacao == 4)
            {
                v2 = Double.Parse(display.Text);
                resp = v1 / v2;
                display.Text = resp.ToString();
                if ((int)resp < resp)
                {
                    virgula = true;
                }
                else
                {
                    virgula = false;
                }
            }
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            virgula = false;
            v1 = 0;
            v2 = 0;
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 0)
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
        }

        #endregion

        #region Numeros
        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "9";

        }

        private void button0_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";

        }
        #endregion

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditosForm creditos = new CreditosForm();
            creditos.ShowDialog();
        }
    }
}