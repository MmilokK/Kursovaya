using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable tableC1 = new DataTable();
            DataTable tableC3 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            String type = typeField.Text;
            String Pr = PrField.Text;
            float N = Convert.ToSingle(NFeild.Text);
            float v = Convert.ToSingle(vFeild.Text);
            FFeild.Text = Convert.ToString(1000*N*v);
        
            int angle = Convert.ToInt32(angleFeild.Text);
            MySqlCommand command = new MySqlCommand("SELECT * FROM `c1` WHERE `angle` = angle", db.getConnection());
        
            adapter.SelectCommand = command;
            adapter.Fill(tableC1);
            foreach(DataRow row in tableC1.Rows)
            {
                if (Convert.ToInt32(row["angle"]) == angle)
                    C1Field.Text = Convert.ToString(row["c1"]);
            }
            //C1Field.Text = tableC1.Rows[0]["c1"].ToString();
            

            String h = hField.SelectedItem.ToString();
            //MessageBox.Show(h);
            String Tm = TmField.SelectedItem.ToString();
            //MessageBox.Show(Tm);
            String Te;
            //Te = TeIField.Checked ? TeIField.Text:TeIIField.Text;
            if (TeIField.Checked)
                Te = TeIField.Text;
            else
                Te = TeIIField.Text;
            //MessageBox.Show(Te);
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `c3` WHERE `h` = h  AND `Tm` = Tm AND `Te` = Te", db.getConnection());
            adapter.SelectCommand = command2;
            adapter.Fill(tableC3);
            foreach (DataRow row in tableC3.Rows)
            {
                if (Convert.ToString(row["h"]) == h&& Convert.ToString(row["Tm"]) == Tm&& Convert.ToString(row["Te"]) == Te)
                    C3Field.Text = Convert.ToString(row["c3"]);
            }
            //C3Field.Text = tableC3.Rows[0]["c3"].ToString();



        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (typeField.SelectedItem.ToString() == "Нормальный")
            {
                ForNormal forNormal = new ForNormal(PrField.SelectedItem.ToString(), FFeild.Text, C1Field.Text, C3Field.Text);
                forNormal.Show();
            }
            else
            {
                ForYP foryp = new ForYP(PrField.SelectedItem.ToString(), FFeild.Text, C1Field.Text, C3Field.Text);
                foryp.Show();
            }
        }
    }
}
