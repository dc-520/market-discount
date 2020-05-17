using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 商场打折
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox_discount.SelectedIndex = 0;
        }

        double total = 0d;

        private void button_sure_Click(object sender, EventArgs e)
        {
            //Cashsuper csuper = CashFactory.createCashAccept(comboBox_discount.SelectedItem.ToString());
            CashContext csuper = new CashContext(comboBox_discount.SelectedItem.ToString());
            double prices = 0d;
            prices = csuper.getResult(Convert.ToDouble(textBox_danjia.Text)) 
                * Convert.ToDouble(textBox_amount.Text);
            total = total + prices;
            listBox_msg.Items.Add("单价:" + textBox_danjia.Text + " 数量:" + textBox_amount.Text + " " +
                comboBox_discount.SelectedItem + " " + "合计：" + prices.ToString());
            label_total.Text = total.ToString();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_danjia.Text = "";
            textBox_amount.Text = "";
        }


    }
}
