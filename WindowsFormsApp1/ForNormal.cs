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
    public partial class ForNormal : Form
    {
        String Pr, F, C1, C3;

        private void button1_Click(object sender, EventArgs e)
        {
            int Dp1 = Convert.ToInt32(Dp1Field.Text);
            float nn = Convert.ToSingle(nnField.Text);
            int v = Convert.ToInt32(vField.Text);
            float F0 = 0;
            float nnF0;
            float C2 = 0;
            int s = 1;

            DB db = new DB();
            DataTable tableF0 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `f0n`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(tableF0);

            //Ввод F0
            foreach (DataRow row in tableF0.Rows)
            {
                if (Convert.ToInt32(row["Dp1"]) == Dp1 && Convert.ToSingle(row["nn"]) == nn && Convert.ToString(row["Pr"]) == Pr)
                {
                    F0Field.Text = Convert.ToString(row["F0"]);
                    F0 = Convert.ToSingle(row["F0"]);
                }
            }

            DataTable tableC2 = new DataTable();
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `c2`", db.getConnection());
            adapter.SelectCommand = command2;
            adapter.Fill(tableC2);

            //Ввод С2
            foreach (DataRow row in tableC2.Rows)
            {
                if (Convert.ToInt32(row["v"]) == v)
                {
                    C2Field.Text = Convert.ToString(row["c2"]);
                    C2 = Convert.ToSingle(row["c2"]);
                }
            }
            float c1 = Convert.ToSingle(C1);
            float c3 = Convert.ToSingle(C3);
            nnF0 = F0 * c1 * C2 * c3;
            nnFField.Text = Convert.ToString(nnF0);


            DataTable tableS = new DataTable();
            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `s`", db.getConnection());
            adapter.SelectCommand = command3;
            adapter.Fill(tableS);

            //Ввод S1
            foreach (DataRow row in tableS.Rows)
            {
                if (Convert.ToString(row["Pr"]) == Pr)
                {
                    s = Convert.ToInt32(row["S"]);
                    S1Field.Text = Convert.ToString(row["S"]);
                }
            }

            float f = Convert.ToSingle(F);
            ZField.Text = Convert.ToString(f/(nnF0*s));

        }

        public ForNormal(String Pr, String F, String C1, String C3)
        {
            InitializeComponent();
            this.Pr = Pr;
            this.F = F;
            this.C1 = C1;
            this.C3 = C3;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
