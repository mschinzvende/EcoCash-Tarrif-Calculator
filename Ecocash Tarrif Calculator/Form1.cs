using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecocash_Tarrif_Calculator
{
    public partial class Form1 : Form
    {

        public double send_money(double available_amnt, double extra_charge, double dest_charge = 0.0)
        {
            double total_required = available_amnt + extra_charge+ dest_charge;

            return total_required;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioregister.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double wallet_balance = 0.0;
                double valid_cash_out = 0.0;
                int actual_cash_out = 0;

                wallet_balance = double.Parse(textcashout.Text);

                if ((wallet_balance >= 1.00) && (wallet_balance <= 1.99))
                {

                    valid_cash_out = 0.0;
                    actual_cash_out = 0;


                }

                if ((wallet_balance >= 2.00) && (wallet_balance <= 5.00))
                {

                    valid_cash_out = wallet_balance - 0.20;
                    actual_cash_out = (int)valid_cash_out;


                }

                if ((wallet_balance >= 5.01) && (wallet_balance <= 10.00))
                {

                    valid_cash_out = wallet_balance - 0.30;
                    actual_cash_out = (int)valid_cash_out;


                }

                if ((wallet_balance >= 10.01) && (wallet_balance <= 20.00))
                {

                    valid_cash_out = wallet_balance - 0.60;
                    actual_cash_out = (int)valid_cash_out;


                }

                if ((wallet_balance >= 20.01) && (wallet_balance <= 30.00))
                {

                    valid_cash_out = wallet_balance - 0.90;
                    actual_cash_out = (int)valid_cash_out;


                }

                if ((wallet_balance >= 30.01) && (wallet_balance <= 40.00))
                {

                    valid_cash_out = wallet_balance - 1.20;
                    actual_cash_out = (int)valid_cash_out;


                }

                if ((wallet_balance >= 40.01) && (wallet_balance <= 50.00))
                {

                    valid_cash_out = wallet_balance - 1.50;
                    actual_cash_out = (int)valid_cash_out;


                }

                if ((wallet_balance >= 50.01) && (wallet_balance <= 60.00))
                {

                    valid_cash_out = wallet_balance - 2.00;
                    actual_cash_out = (int)valid_cash_out;


                }

                if ((wallet_balance >= 60.01) && (wallet_balance <= 75.00))
                {

                    valid_cash_out = wallet_balance - 2.30;
                    actual_cash_out = (int)valid_cash_out;


                }


                if ((wallet_balance >= 75.01) && (wallet_balance <= 100.00))
                {

                    valid_cash_out = wallet_balance - 3.00;
                    actual_cash_out = (int)valid_cash_out;


                }


                if ((wallet_balance >= 100.01) && (wallet_balance <= 150.00))
                {

                    valid_cash_out = wallet_balance - 3.50;
                    actual_cash_out = (int)valid_cash_out;


                }

                if ((wallet_balance >= 150.01) && (wallet_balance <= 200.00))
                {

                    valid_cash_out = wallet_balance - 3.90;
                    actual_cash_out = (int)valid_cash_out;


                }

                if ((wallet_balance >= 200.01) && (wallet_balance <= 300.00))
                {

                    valid_cash_out = wallet_balance - 4.85;
                    actual_cash_out = (int)valid_cash_out;


                }


                if ((wallet_balance >= 300.01) && (wallet_balance <= 400.00))
                {

                    valid_cash_out = wallet_balance - 4.90;
                    actual_cash_out = (int)valid_cash_out;


                }


                if ((wallet_balance >= 400.01) && (wallet_balance <= 500.00))
                {

                    valid_cash_out = wallet_balance - 4.95;
                    actual_cash_out = (int)valid_cash_out;


                }

                if ((wallet_balance > 500) || (wallet_balance < 1.00))
                {
                    MessageBox.Show("Invalid Transaction Amount", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                labelactualcashout.Text = "" + actual_cash_out;
                labelvalidcashout.Text = "" + valid_cash_out;
            }
            catch (Exception all){
                MessageBox.Show("Invalid Input parameters","Invalid Amount",MessageBoxButtons.OK,MessageBoxIcon.Error );
            }


        }

        private void radiounregister_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radiounregister.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double amount_to_send = 0.0;
                double newamount_to_send = 0.0;
                double required_cash_in = 0.0;
                double yousend = 0.0;

                amount_to_send = double.Parse(textreceiveramount.Text);

                if (checkBox1.Checked == true)
                {

                    if ((amount_to_send >= 1.00) && (amount_to_send <= 1.99))
                    {
                        newamount_to_send = amount_to_send;

                    }

                    if ((amount_to_send >= 2.00) && (amount_to_send <= 5.00))
                    {
                        newamount_to_send = amount_to_send + 0.20;

                    }

                    if ((amount_to_send >= 5.01) && (amount_to_send <= 10.00))
                    {
                        newamount_to_send = amount_to_send + 0.30;

                    }
                    if ((amount_to_send >= 10.01) && (amount_to_send <= 20.00))
                    {
                        newamount_to_send = amount_to_send + 0.60;

                    }

                    if ((amount_to_send >= 20.01) && (amount_to_send <= 30.00))
                    {
                        newamount_to_send = amount_to_send + 0.90;

                    }
                    if ((amount_to_send >= 30.01) && (amount_to_send <= 40.00))
                    {
                        newamount_to_send = amount_to_send + 1.20;

                    }

                    if ((amount_to_send >= 40.01) && (amount_to_send <= 50.00))
                    {
                        newamount_to_send = amount_to_send + 1.50;

                    }
                    if ((amount_to_send >= 50.01) && (amount_to_send <= 60.00))
                    {
                        newamount_to_send = amount_to_send + 2.00;

                    }

                    if ((amount_to_send >= 60.01) && (amount_to_send <= 75.00))
                    {
                        newamount_to_send = amount_to_send + 2.30;

                    }

                    if ((amount_to_send >= 75.01) && (amount_to_send <= 100.00))
                    {
                        newamount_to_send = amount_to_send + 3.00;

                    }
                    if ((amount_to_send >= 100.01) && (amount_to_send <= 150.00))
                    {
                        newamount_to_send = amount_to_send + 3.50;

                    }

                    if ((amount_to_send >= 150.01) && (amount_to_send <= 200.00))
                    {
                        newamount_to_send = amount_to_send + 3.90;

                    }

                    if ((amount_to_send >= 200.01) && (amount_to_send <= 300.00))
                    {
                        newamount_to_send = amount_to_send + 4.85;

                    }

                    if ((amount_to_send >= 300.01) && (amount_to_send <= 400.00))
                    {
                        newamount_to_send = amount_to_send + 4.90;

                    }

                    if ((amount_to_send >= 400.01) && (amount_to_send <= 500.00))
                    {
                        newamount_to_send = amount_to_send + 4.95;

                    }
                    if ((amount_to_send > 500) || (amount_to_send < 1.00))
                    {
                        MessageBox.Show("Invalid Transaction Amount", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                else if (checkBox1.Checked == false)
                {
                    newamount_to_send = amount_to_send;
                }




                if ((newamount_to_send >= 1.00) && (newamount_to_send <= 1.99))
                {
                    if (radioregister.Checked == true)
                    {

                        required_cash_in = send_money(newamount_to_send, 0.14);
                        yousend = newamount_to_send;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelcashrequired.Text = "" + required_cash_in;
                        labelyousend.Text = "" + yousend;
                    }

                    else if (radiounregister.Checked == true)
                    {
                        MessageBox.Show("Can not send less than $2 to unregistered subscriber", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                if ((newamount_to_send >= 2.00) && (newamount_to_send <= 5.00))
                {
                    if (radioregister.Checked == true)
                    {
                        if (checkBox1.Checked == true)
                        {
                            required_cash_in = send_money(amount_to_send, 0.14, 0.20);
                            yousend = amount_to_send + 0.20;
                        }
                        else if (checkBox1.Checked == false)
                        {
                            required_cash_in = send_money(amount_to_send, 0.14);
                            yousend = amount_to_send;
                        }

                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;
                    }
                    else if (radiounregister.Checked == true)
                    {
                        required_cash_in = send_money(newamount_to_send, 0.54);
                        yousend = newamount_to_send;
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;

                    }

                }

                if ((newamount_to_send >= 5.01) && (newamount_to_send <= 10.00))
                {
                    if (radioregister.Checked == true)
                    {
                        if (checkBox1.Checked == true)
                        {
                            required_cash_in = send_money(amount_to_send, 0.24, 0.30);
                            yousend = amount_to_send + 0.30;
                        }
                        else if (checkBox1.Checked == false)
                        {
                            required_cash_in = send_money(amount_to_send, 0.24);
                            yousend = amount_to_send;
                        }
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;
                    }
                    else if (radiounregister.Checked == true)
                    {
                        required_cash_in = send_money(newamount_to_send, 0.74);
                        yousend = newamount_to_send;
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;

                    }

                }

                if ((newamount_to_send >= 10.01) && (newamount_to_send <= 20.00))
                {
                    if (radioregister.Checked == true)
                    {
                        if (checkBox1.Checked == true)
                        {
                            required_cash_in = send_money(amount_to_send, 0.44, 0.60);
                            yousend = amount_to_send + 0.60;
                        }
                        else if (checkBox1.Checked == false)
                        {
                            required_cash_in = send_money(amount_to_send, 0.44);
                            yousend = amount_to_send;
                        }
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;
                    }
                    else if (radiounregister.Checked == true)
                    {
                        required_cash_in = send_money(newamount_to_send, 1.34);
                        yousend = newamount_to_send;
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;

                    }

                }

                if ((newamount_to_send >= 20.01) && (newamount_to_send <= 30.00))
                {
                    if (radioregister.Checked == true)
                    {
                        if (checkBox1.Checked == true)
                        {
                            required_cash_in = send_money(amount_to_send, 0.62, 0.90);
                            yousend = amount_to_send + 0.90;
                        }
                        else if (checkBox1.Checked == false)
                        {
                            required_cash_in = send_money(amount_to_send, 0.62);
                            yousend = amount_to_send;
                        }
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;
                    }
                    else if (radiounregister.Checked == true)
                    {
                        required_cash_in = send_money(newamount_to_send, 1.84);
                        yousend = newamount_to_send;
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;

                    }

                }
                if ((newamount_to_send >= 30.01) && (newamount_to_send <= 40.00))
                {
                    if (radioregister.Checked == true)
                    {
                        if (checkBox1.Checked == true)
                        {
                            required_cash_in = send_money(amount_to_send, 0.82, 1.20);
                            yousend = amount_to_send + 1.20;
                        }
                        else if (checkBox1.Checked == false)
                        {
                            required_cash_in = send_money(amount_to_send, 0.82);
                            yousend = amount_to_send;
                        }
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;
                    }
                    else if (radiounregister.Checked == true)
                    {
                        required_cash_in = send_money(newamount_to_send, 2.34);
                        yousend = newamount_to_send;
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;

                    }

                }

                if ((newamount_to_send >= 40.01) && (newamount_to_send <= 50.00))
                {
                    if (radioregister.Checked == true)
                    {
                        if (checkBox1.Checked == true)
                        {
                            required_cash_in = send_money(amount_to_send, 1.03, 1.50);
                            yousend = amount_to_send + 1.50;
                        }
                        else if (checkBox1.Checked == false)
                        {
                            required_cash_in = send_money(amount_to_send, 1.03);
                            yousend = amount_to_send;
                        }
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;
                    }
                    else if (radiounregister.Checked == true)
                    {
                        required_cash_in = send_money(newamount_to_send, 3.54);
                        yousend = newamount_to_send;
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;

                    }

                }

                if ((newamount_to_send >= 50.01) && (newamount_to_send <= 60.00))
                {
                    if (radioregister.Checked == true)
                    {
                        if (checkBox1.Checked == true)
                        {
                            required_cash_in = send_money(amount_to_send, 1.45, 2.00);
                            yousend = amount_to_send + 2.00;
                        }
                        else if (checkBox1.Checked == false)
                        {
                            required_cash_in = send_money(amount_to_send, 1.45);
                            yousend = amount_to_send;
                        }
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;
                    }
                    else if (radiounregister.Checked == true)
                    {
                        required_cash_in = send_money(newamount_to_send, 4.54);
                        yousend = newamount_to_send;
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;

                    }

                }

                if ((newamount_to_send >= 60.01) && (newamount_to_send <= 75.00))
                {
                    if (radioregister.Checked == true)
                    {
                        if (checkBox1.Checked == true)
                        {
                            required_cash_in = send_money(amount_to_send, 1.52, 2.30);
                            yousend = amount_to_send + 2.30;
                        }
                        else if (checkBox1.Checked == false)
                        {
                            required_cash_in = send_money(amount_to_send, 1.52);
                            yousend = amount_to_send;
                        }
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;
                    }
                    else if (radiounregister.Checked == true)
                    {
                        required_cash_in = send_money(newamount_to_send, 5.04);
                        yousend = newamount_to_send;
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;

                    }

                }

                if ((newamount_to_send >= 75.01) && (newamount_to_send <= 100.00))
                {
                    if (radioregister.Checked == true)
                    {
                        if (checkBox1.Checked == true)
                        {
                            required_cash_in = send_money(amount_to_send, 1.98, 3.00);
                            yousend = amount_to_send + 3.00;
                        }
                        else if (checkBox1.Checked == false)
                        {
                            required_cash_in = send_money(amount_to_send, 1.98);
                            yousend = amount_to_send;
                        }
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;
                    }
                    else if (radiounregister.Checked == true)
                    {
                        required_cash_in = send_money(newamount_to_send, 7.00);
                        yousend = newamount_to_send;
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;

                    }

                }

                if ((newamount_to_send >= 100.01) && (newamount_to_send <= 150.00))
                {
                    if (radioregister.Checked == true)
                    {
                        if (checkBox1.Checked == true)
                        {
                            required_cash_in = send_money(amount_to_send, 2.48, 3.50);
                            yousend = amount_to_send + 3.50;
                        }
                        else if (checkBox1.Checked == false)
                        {
                            required_cash_in = send_money(amount_to_send, 2.48);
                            yousend = amount_to_send;
                        }
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;
                    }
                    else if (radiounregister.Checked == true)
                    {
                        required_cash_in = send_money(newamount_to_send, 8.50);
                        yousend = newamount_to_send;
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;

                    }

                }

                if ((newamount_to_send >= 150.01) && (newamount_to_send <= 200.00))
                {
                    if (radioregister.Checked == true)
                    {
                        if (checkBox1.Checked == true)
                        {
                            required_cash_in = send_money(amount_to_send, 2.98, 3.90);
                            yousend = amount_to_send + 3.90;
                        }
                        else if (checkBox1.Checked == false)
                        {
                            required_cash_in = send_money(amount_to_send, 2.98);
                            yousend = amount_to_send;
                        }
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;
                    }
                    else if (radiounregister.Checked == true)
                    {
                        required_cash_in = send_money(newamount_to_send, 9.60);
                        yousend = newamount_to_send;
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;

                    }

                }

                if ((newamount_to_send >= 200.01) && (newamount_to_send <= 300.00))
                {
                    if (radioregister.Checked == true)
                    {
                        if (checkBox1.Checked == true)
                        {
                            required_cash_in = send_money(amount_to_send, 3.79, 4.85);
                            yousend = amount_to_send + 4.85;
                        }
                        else if (checkBox1.Checked == false)
                        {
                            required_cash_in = send_money(amount_to_send, 3.79);
                            yousend = amount_to_send;
                        }
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;
                    }
                    else if (radiounregister.Checked == true)
                    {
                        required_cash_in = send_money(newamount_to_send, 11.00);
                        yousend = newamount_to_send;
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;

                    }

                }

                if ((newamount_to_send >= 300.01) && (newamount_to_send <= 400.00))
                {
                    if (radioregister.Checked == true)
                    {
                        if (checkBox1.Checked == true)
                        {
                            required_cash_in = send_money(amount_to_send, 3.95, 4.90);
                            yousend = amount_to_send + 4.90;
                        }
                        else if (checkBox1.Checked == false)
                        {
                            required_cash_in = send_money(amount_to_send, 3.95);
                            yousend = amount_to_send;
                        }
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;
                    }
                    else if (radiounregister.Checked == true)
                    {
                        required_cash_in = send_money(newamount_to_send, 13.05);
                        yousend = newamount_to_send;
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;

                    }

                }

                if ((newamount_to_send >= 400.01) && (newamount_to_send <= 500.00))
                {
                    if (radioregister.Checked == true)
                    {
                        if (checkBox1.Checked == true)
                        {
                            required_cash_in = send_money(amount_to_send, 3.98, 4.95);
                            yousend = amount_to_send + 4.95;
                        }
                        else if (checkBox1.Checked == false)
                        {
                            required_cash_in = send_money(amount_to_send, 3.98);
                            yousend = amount_to_send;
                        }
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;
                    }
                    else if (radiounregister.Checked == true)
                    {
                        required_cash_in = send_money(newamount_to_send, 14.04);
                        yousend = newamount_to_send;
                        labelcashrequired.Text = "" + required_cash_in;
                        labelrealcashin.Text = "" + Math.Ceiling(required_cash_in);
                        labelyousend.Text = "" + yousend;

                    }

                }

                if ((amount_to_send > 500) || (amount_to_send < 1.00))
                {
                    MessageBox.Show("Invalid Transaction Amount", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception all)
            {
                MessageBox.Show("Invalid Input parameters", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void radioregister_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioregister.Checked == true)
            {
                checkBox1.Enabled = true;
            }
        }

        private void aboutTariffCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutTariffCalculatorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutBox1 showabout = new AboutBox1();

            showabout.ShowDialog();

        }

        private void generalHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help not available in this version","Help",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        }
    }
