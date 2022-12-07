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
    public partial class ForYP : Form
    {
        String Pr, F, C1, C3;

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int Dp1 = Convert.ToInt32(Dp1Field.Text);
            int v = Convert.ToInt32(vField.Text);
            float F0 = 0;
            float PFi = 0;
            float PF0 = 0;
            float nnF;
            float CL = 0;
            int s = 1;
            float L = Convert.ToSingle(LField.Text);
            float f = Convert.ToSingle(F);

            DB db = new DB();
            DataTable tableF0 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `f0yp`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(tableF0);

            //Ввод F0
            foreach(DataRow row in tableF0.Rows)
            {
                if(row["Pr"].ToString() ==Pr && Convert.ToInt32(row["Dp1"])==Dp1&& Convert.ToInt32(row["v"]) == v)
                {
                    F0 = Convert.ToSingle(row["F0"]);
                    F0Field.Text=F0.ToString();
                }
            }

            DataTable tablePFi = new DataTable();
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `fi`", db.getConnection());
            adapter.SelectCommand = command2;
            adapter.Fill(tablePFi);

            //Ввод Fи
            foreach(DataRow row in tablePFi.Rows)
            {
                if (row["Pr"].ToString()==Pr && Convert.ToSingle(row["u"]) == Convert.ToSingle(uField.Text))
                {
                    PFi = Convert.ToSingle(row["Fi"]);
                    PFiField.Text=PFi.ToString();
                }
                
            }
            PF0 = 100 * PFi / Dp1;
            PF0Field.Text=PF0.ToString();

            DataTable tableCL = new DataTable();
            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `cl`", db.getConnection());
            adapter.SelectCommand = command3;
            adapter.Fill(tableCL);


            //Ввод CL и L0
            foreach(DataRow row in tableCL.Rows)
            {
                if (row["Pr"].ToString()==Pr && L/Convert.ToInt32(row["L0"])==Convert.ToSingle(row["L_L0"]))
                {
                    CL = Convert.ToSingle(row["CL"]);
                    CLField.Text=CL.ToString();
                    L0Field.Text = row["L0"].ToString();

                }
            }

            float c1 = Convert.ToSingle(C1);
            float c3 = Convert.ToSingle(C3);
            nnF = (F0+PF0)*c1*c3*CL;
            nnFField.Text=nnF.ToString();

            DataTable tableS = new DataTable();
            MySqlCommand command4 = new MySqlCommand("SELECT * FROM `s`", db.getConnection());
            adapter.SelectCommand = command4;
            adapter.Fill(tableS);

            foreach(DataRow row in tableS.Rows)
            {
                if(row["Pr"].ToString() == Pr)
                {
                    s = Convert.ToInt32(row["S"]);
                }
            }

            if(Pr == "К"|| Pr == "Л")
            {
                S10Field.Text=s.ToString();
                Z10Field.Text=Convert.ToString(10*f/(s*nnF));
            }
            else
            {
                S1Field.Text = s.ToString();
                Z1Field.Text = Convert.ToString(f / (s * nnF));
            }

        }

        public ForYP(String Pr, String F, String C1, String C3)
        {
            InitializeComponent();
            this.Pr = Pr;
            this.F = F;
            this.C1 = C1;
            this.C3 = C3;
        }

        private void ForYP_Load(object sender, EventArgs e)
        {

        }
    }
}
