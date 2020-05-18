using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_Form
{
    public partial class Form1 : Form
    {
        string uname = "", result = "";
        SqlConnection sc = new SqlConnection(Login_Form.Properties.Settings.Default.UserData);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label15.BackColor = Color.Transparent;
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            label14.Visible = false;
            label16.Visible = false;
            button4.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            rectangleShape1.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
        }

        public void ChangeSize(int width, int height)
        {
            this.Size = new Size(width, height);
        }

        private void Form1_Load1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Location = new Point(120, 120);
            button2.Location = new Point(300, 120);
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;

            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            label3.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            
            button6.Visible = true;
            button4.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox5.Focus();
            textBox6.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;

            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }



        private void button5_Click(object sender, EventArgs e)
        {
            logic();
            rectangleShape1.Visible = true;
        }

        public void logic()
        {
            string a = "", b = "", c = "", z = "";
            a = textBox7.Text.ToLower();
            b = textBox8.Text.ToLower();
            if (a == "")
            {
                MessageBox.Show("Field is empty.");
                textBox1.Focus();
                return;
            }
            if (b == "")
            {
                MessageBox.Show("Field is empty.");
                textBox2.Focus();
                return;
            }
            c = a + "and" + b + "arefriends";
            char[] d;
            int[] l = new int[50];
            int[] m = new int[50];

            d = c.ToCharArray();

            char[] f = new char[100];

            int i = 0, j = 0, k = 0, count = 1, x, temp = 0, s = 0;
            for (i = 0; i < d.Length; i++)
            {
                for (j = 0; j < f.Length; j++)
                {

                    if (d[i] == f[j])
                    {
                        goto last;
                    }
                }
                f[i] = d[i];
                char h = d[i];
                for (k = d.Length - 1; k > i; k--)
                {
                    if (h == d[k])
                    {
                        count++;
                    }
                }
                l[i] = count;
                count = 1;
            last:
                if (i == d.Length - 1)
                {
                    for (x = 0; x < l.Length; x++)
                    {
                        if (l[x] != 0)
                        {
                            m[s] = l[x];
                            s++;
                        }
                    }

                Start:

                    temp = 0;
                    for (x = 0; x < m.Length; x++)
                    {
                        if (m[x] != 0)
                        {
                            temp++;
                        }

                    }
                    j = temp - 1;
                    if (temp != 2)
                    {
                        for (x = 0; x < temp; x++)
                        {
                            if (j > x)
                            {
                                m[x] = m[x] + m[j];
                                m[j] = 0;
                                j--;
                            }
                            else if (j == x)
                            {
                                m[j] = m[x];
                            }
                            else { }
                        }
                        goto Start;
                    }
                    else if (temp == 2)
                    {

                        for (x = 0; x < temp; x++)
                        {
                            z += m[x];

                        again:
                            if (z.Length > 2)
                            {
                                for (x = 0; x < z.Length; x++)
                                {
                                    int o = Convert.ToInt32(z[x]) - 48;
                                    m[x] = o;
                                }
                                j = z.Length - 1;
                                for (x = 0; x < temp; x++)
                                {
                                    if (j > x)
                                    {
                                        m[x] = m[x] + m[j];
                                        m[j] = 0;
                                        j--;
                                    }
                                    else if (j == x)
                                    {
                                        m[j] = m[x];
                                    }
                                    else { }
                                }
                                z = "";
                                for (x = 0; x < temp; x++)
                                {
                                    z += m[x];
                                }
                            }
                            if (z.Length > 2)
                            {
                                goto again;
                            }
                        }
                    }
                    //groupBox1.Text = "Result";
                    label15.Visible = true;
                    label15.Text = " " + z + "%";
                    result = z;
                    sc.Open();

                    string str2 = "insert into User_Activity values('" + uname + "','" + textBox7.Text + "','" + textBox8.Text + "','" + result + "')";
                    SqlCommand scmd = new SqlCommand(str2, sc);
        
                        scmd.ExecuteNonQuery();
                    
                    sc.Close();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string st = "";
            if (textBox5.Text == "")
            {
                MessageBox.Show("Enter your Name!");
                textBox5.Focus();
                return;
            }
            
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Enter a Username!");
                textBox4.Focus();
                return;
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Enter a Password!");
                textBox3.Focus();
                return;
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("Enter a confirm Password!");
                textBox6.Focus();
                return;
            }
            if (radioButton1.Checked == true)
            {
                st = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                st = radioButton2.Text;
            }

            sc.Open();
            string str = "select * from users";
            SqlCommand scm = new SqlCommand(str, sc);
            SqlDataReader sdr = scm.ExecuteReader();
            while (sdr.Read())
            {
                if (sdr.GetValue(1).Equals(textBox4.Text))
                {
                    MessageBox.Show("UserName not available! Try again!");
                    textBox4.Clear();
                    textBox3.Clear();
                    textBox6.Clear();
                    textBox4.Focus();
                    sc.Close();
                    return;
                }
            }
            if (textBox3.Text != textBox6.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match!");
                textBox6.Clear();
                textBox6.Focus();
                sc.Close();
                return;
            }
            sc.Close();
            sc.Open();
            string str1 = "insert into Users values('" + textBox5.Text.ToUpper() + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + st + "')";
            SqlCommand scm1 = new SqlCommand(str1, sc);
            if (scm1.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("Registration Successful. Now go and log inside!");
            }
            sc.Close();

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            button4.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label13.Visible = false;
            button6.Visible = false;

            button1.Visible = true;
            button2.Visible = true;
            label3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter a username!");
                textBox1.Focus();
                return;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter your password!");
                textBox2.Focus();
                return;
            }
            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "gnuit10")
                {
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Password Incorrect");
                    textBox2.Clear();
                    textBox2.Focus();
                }
                return;
            }
            sc.Open();
            string str = "select * from users where Username='" + textBox1.Text + "'";
            SqlCommand scm = new SqlCommand(str, sc);
            SqlDataReader sdr = scm.ExecuteReader();
            if (sdr.Read())
            {
                if (sdr.GetValue(2).ToString() != textBox2.Text)
                {
                    MessageBox.Show("Password Incorrect!");
                    textBox2.Clear();
                    textBox2.Focus();
                    sc.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("No user found! First you need to Sign Up!");
                textBox1.Clear();
                textBox2.Clear();
                button2.Focus();
                sc.Close();
                return;
            }
            MessageBox.Show("Welcome " + sdr.GetValue(0));

            uname = sdr.GetValue(0).ToString();
            sc.Close();
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;

            button6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox7.Clear();
            textBox8.Clear();
            button5.Visible = true;
            label14.Visible = true;
            label16.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            label14.Visible = false;
            label16.Visible = false;
            button4.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            rectangleShape1.Visible = false;

            label3.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
        }
    }
}
