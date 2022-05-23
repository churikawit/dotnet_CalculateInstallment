using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateInstallment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decimal principle, intrate, term_year, term_month, installment, term;
            try
            {
                if (textBox_pv.Text == "")
                    textBox_pv.Text = "0";
                principle = Decimal.Parse(textBox_pv.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("เงินต้น ผิดพลาด");
                return;
            }
            try
            {
                if (textBox_intrate.Text == "")
                    textBox_intrate.Text = "0";
                intrate = Decimal.Parse(textBox_intrate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("อัตราดอกเบี้ย ผิดพลาด");
                return;
            }
            try
            {
                if (textBox_term_year.Text == "")
                    textBox_term_year.Text = "0";
                term_year = Decimal.Parse(textBox_term_year.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ระยะเวลาผ่อนชำระ ผิดพลาด");
                return;
            }
            try
            {
                if (textBox_term_month.Text == "")
                    textBox_term_month.Text = "0";
                term_month = Decimal.Parse(textBox_term_month.Text);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("ระยะเวลาผ่อนชำระ ผิดพลาด");
                return;
            }
            try
            {
                if (textBox_installment.Text == "")
                    textBox_installment.Text = "0";
                installment = Decimal.Parse(textBox_installment.Text);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("เงินงวดผ่อนชำระ ผิดพลาด");
                return;
            }

            term = term_year * 12 + term_month;

            if (principle > 0 && intrate > 0 && term > 0 && installment == 0)
            {
                installment = find_installment(principle, intrate, term);
                textBox_installment.Text = String.Format("{0}", installment);
            }
            else if (principle > 0 && intrate > 0 && term == 0 && installment > 0)
            {
                term = find_term(principle, intrate, installment);
                if (term > 0)
                {
                    textBox_term_year.Text = String.Format("{0}", Decimal.ToInt32(term) / 12);
                    int m = Decimal.ToInt32(term) % 12;
                    textBox_term_month.Text = String.Format("{0}", m);
                }
                else 
                {
                    MessageBox.Show("การคำนวณไม่สำเร็จ");
                    return;
                }
            }
            else if (principle > 0 && intrate == 0 && term > 0 && installment > 0)
            {
                intrate = find_intrate(principle, term, installment);
                if (intrate > 0) 
                {
                    textBox_intrate.Text = String.Format("{0}", intrate);
                }
                else
                {
                    MessageBox.Show("การคำนวณไม่สำเร็จ");
                    return;
                }
            }
            else if (principle == 0 && intrate > 0 && term > 0 && installment > 0)
            {
                principle = find_principle(intrate, term, installment);
                textBox_pv.Text = String.Format("{0}", principle);
            }
            else
            {
                MessageBox.Show("เงื่อนไขการคำนวณไม่ถูกต้อง");
                return;
            }
        }

        public static Decimal Decimal_Pow(Decimal x, Decimal y)
        {
            return new Decimal(System.Math.Pow(Decimal.ToDouble(x), Decimal.ToDouble(y)));
        }
        public static Decimal Decimal_RoundUp(Decimal d, int decimals)
        {
            Decimal output = d;
            bool minus_flag = false;
            if (output < 0)
            {
                output = -output;
                minus_flag = true;
            }

            if (decimals <= 0)
            {
                decimals = decimals * -1;
                Decimal devider = 1;
                for (int i = 0; i < decimals; i++)
                {
                    devider = devider * 10;
                }
                // ปัดค่าเงินงวด
                Decimal temp = output / devider;
                if (output > Decimal.ToInt32(temp) * devider)
                {
                    output = (Decimal.ToInt32(temp) + 1) * devider;
                }
            }
            else
            {
                Decimal multiplier = 1;
                for (int i = 0; i < decimals; i++)
                {
                    multiplier = multiplier * 10;
                }
                // ปัดค่าเงินงวด
                Decimal temp = output * multiplier;
                if (output > Decimal.ToInt32(temp) / multiplier)
                {
                    output = (Decimal.ToInt32(temp) + 1) / multiplier;
                }
            }

            if (minus_flag == true) output = -output;
            return output;
        }
        public static Decimal Decimal_RoundDown(Decimal d, int decimals)
        {
            Decimal output = d;
            bool minus_flag = false;
            if (output < 0)
            {
                output = -output;
                minus_flag = true;
            }

            if (decimals <= 0)
            {
                decimals = decimals * -1;
                Decimal devider = 1;
                for (int i = 0; i < decimals; i++)
                {
                    devider = devider * 10;
                }
                // ปัดค่าเงินงวด
                Decimal temp = output / devider;
                output = Decimal.ToInt32(temp) * devider;
            }
            else
            {
                Decimal multiplier = 1;
                for (int i = 0; i < decimals; i++)
                {
                    multiplier = multiplier * 10;
                }
                // ปัดค่าเงินงวด
                Decimal temp = output * multiplier;
                output = Decimal.ToInt32(temp) / multiplier;
            }

            if (minus_flag == true) output = -output;
            return output;
        }

        private Decimal find_installment(Decimal principle, Decimal intrate, Decimal term) {
            Decimal emi = 0;
            Decimal dummy1;
            Decimal dummy2;
            try
            {
                dummy1 = intrate / new Decimal(12.0) / new Decimal(100.0);
            }
            catch (System.OverflowException e)
            {
                throw e;
            }
            try
            {
                dummy2 = Decimal_Pow(dummy1 + 1, term);
            }
            catch (System.OverflowException e)
            {
                throw e;
            }
            try
            {
                emi = principle * (dummy1 / (1 - 1 / dummy2));
            }
            catch (System.OverflowException e)
            {
                throw e;
            }

            // ปัดค่าเงินงวด ให้เต็มร้อย
            emi = Decimal_RoundUp(emi, -2);

            return emi;
        }

        private Decimal find_term(Decimal principle, Decimal intrate, Decimal installment)
        {
            Decimal term = 0;
            Decimal test_principle, test_term = 0;
            int i = 0;
            const int MAX_TERM_YEAR = 41;

            for (i = 1; i <= MAX_TERM_YEAR; i++) 
            {
                test_term = i * 12;
                test_principle = find_principle(intrate, test_term, installment);

                if (test_principle >= principle) {
                    break;
                }
            }
            if (i > MAX_TERM_YEAR)
            {
                // out of range
                return 0;
            }

            int test_term_start = Decimal.ToInt32(test_term) - 12;
            if (test_term_start <= 0)
                test_term_start = 1;
            for (i = test_term_start; i <= test_term; i++) {
                test_principle = find_principle(intrate, i, installment);
                if (test_principle >= principle) {
                    term = i;
                    break;
                }
            }

            return term;
        }

        private Decimal find_intrate(Decimal principle, Decimal term, Decimal installment)
        {
            Decimal intrate = 0, test_intrate = 0, test_principle = 0;
            const int MAX_INTRATE = 15;
            int i = 0;
            for (i = 1; i <= MAX_INTRATE; i++)
            {
                test_intrate = i;
                test_principle = find_principle(test_intrate, term, installment);

                if (test_principle < principle) 
                {
                    break;
                }
            }
            if (i > MAX_INTRATE)
            {
                // out of range
                return 0;
            }

            test_intrate = test_intrate - 1;
            for (i = 1; i <= 100; i++) {
                test_intrate = test_intrate + new decimal(0.01);
                test_principle = find_principle(test_intrate, term, installment);
                if (test_principle < principle)
                {
                    break;
                }
            }

            test_intrate = test_intrate - new decimal(0.01);
            for (i = 1; i <= 100; i++)
            {
                test_intrate = test_intrate + new decimal(0.0001);
                test_principle = find_principle(test_intrate, term, installment);
                if (test_principle < principle)
                {
                    break;
                }
            }
            intrate = test_intrate - new decimal(0.0001);

            return intrate;
        }

        private Decimal find_principle(Decimal intrate, Decimal term, Decimal installment)
        {
            Decimal principle = 0;
            Decimal dummy1, dummy2;

            try
            {
                dummy1 = intrate / new Decimal(1200.0);
            }
            catch (System.OverflowException e)
            {
                throw e;
            }
            try
            {
                dummy2 = Decimal_Pow(dummy1 + 1, term);
            }
            catch (System.OverflowException e)
            {
                throw e;
            }
            try
            {
                principle = installment * ( (1 - 1 / dummy2) / dummy1);
            }
            catch (System.OverflowException e)
            {
                throw e;
            }

            // ปัดลงหลักพัน
            principle = Decimal_RoundDown(principle, -3);

            return principle;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
