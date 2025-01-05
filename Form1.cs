using System.Drawing;
using System.Security.Policy;

namespace SHME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputCFP = cf_p.Text;
            string inputCFQ = cf_q.Text;
            string inputGTP = gt_p.Text;
            string inputGTQ = gt_q.Text;

            double cfp = 0;
            double cfq = 0;
            double gtp = 0;
            double gtq = 0;

            try
            {
                if (cb_coffee.Checked)
                {
                    cfp = double.Parse(inputCFP);
                    cfq = double.Parse(inputCFQ);
                }
                if (cb_gt.Checked)
                {
                    gtp = double.Parse(inputGTP);
                    gtq = double.Parse(inputGTQ);

                }

            }
            catch (FormatException )
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบตามที่เลือก");
             
            }
            double sum1 = cfp * cfq;
            double sum2 = gtp * gtq;
            double sum = sum1 + sum2;
            tb_t.Text = sum.ToString();

        }

        private void cb_gt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string total = tb_t.Text;
            string cash = tb_cash.Text;
            double totalfill = double.Parse(total);
            double cashfill = double.Parse(cash);
            double sum = cashfill - totalfill ;
            tb_change.Text = sum.ToString();

            double onet = 0;
            double fiveh = 0;
            double oneh = 0;
            double fivet = 0;
            double twot = 0;
            double ten = 0;
            double five = 0;
            double one = 0;
            while (sum > 0)
            {
                if (sum >= 1000)
                {
                    sum -= 1000;
                    onet++;
                }
                else if (sum >= 500)
                {
                    sum -= 500;
                    fiveh++;
                }
                else if (sum >= 100)
                {
                    sum -= 100;
                    oneh++;
                }
                else if (sum >= 50)
                {
                    sum -= 50;
                    fivet++;
                }
                else if (sum >= 20)
                {
                    sum -= 20;
                    twot++;
                }
                else if (sum >= 10)
                {
                    sum -= 10;
                    ten++;
                }
                else if (sum >= 5)
                {
                    sum -= 5;
                    five++;
                }
                else if (sum >= 1)
                {
                    sum -= 1;
                    one++;
                }
            }
            oneT.Text = onet.ToString();
            fiveH.Text = fiveh.ToString();
            oneH.Text = oneh.ToString();
            fiveT.Text = fivet.ToString();
            twoT.Text = twot.ToString();
            Ten.Text = ten.ToString();
            fivE.Text = five.ToString();
            onE.Text = one.ToString();

        }
    }
}
            
        