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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection scn = new SqlConnection(Login_Form.Properties.Settings.Default.UserData);
            scn.Open();
            string s = "select * from User_Activity";
            SqlCommand scmd = new SqlCommand(s, scn);
            SqlDataReader sdr = scmd.ExecuteReader();
            while (sdr.Read())
            {
                ListViewItem lv = new ListViewItem(sdr.GetValue(0).ToString());
                lv.SubItems.Add(sdr.GetValue(1).ToString());
                lv.SubItems.Add(sdr.GetValue(2).ToString());
                lv.SubItems.Add(sdr.GetValue(3).ToString());
                lv.SubItems.Add(sdr.GetValue(4).ToString());
                listView1.Items.Add(lv);
            }
            scn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
