using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photogrammetry
{
    public partial class Rendezvous : Form
    {

        public Calculate cal;
        public Rendezvous(ref Calculate cal)
        {
            InitializeComponent();
            this.cal = cal;
        }

        private void Init()
        {
            this.Forward.Enabled = false;
        }

        private void Rendezvous_Load(object sender,EventArgs e)
        {
            this.Text = "空间交会";
            Init();
        }
        
        private void Resection(object sender,EventArgs e)
        {
            this.cal.SpaceResection();

            MessageBox.Show("空间后方交会解算成功", "系统信息", MessageBoxButtons.OK);
            
            this.textBox1.Text = cal.Br.Xs1.ToString();
            this.textBox2.Text = cal.Br.Ys1.ToString();
            this.textBox3.Text = cal.Br.Zs1.ToString();
            this.textBox4.Text = cal.Br.Phi1.ToString();
            this.textBox5.Text = cal.Br.Omega1.ToString();
            this.textBox6.Text = cal.Br.Kappa1.ToString();
            this.textBox7.Text = cal.Br.DiffX1.ToString();
            this.textBox8.Text = cal.Br.DiffY1.ToString();
            this.textBox9.Text = cal.Br.DiffZ1.ToString();
            this.textBox10.Text = cal.Br.DiffPhi1.ToString();
            this.textBox11.Text = cal.Br.DiffOmega1.ToString();
            this.textBox12.Text = cal.Br.DiffKappa1.ToString();
            this.textBox13.Text = cal.Br.IterCount1.ToString();
            this.textBox14.Text = cal.Br.MidErr1.ToString();

            this.textBox15.Text = cal.Br.Xs2.ToString();
            this.textBox16.Text = cal.Br.Ys2.ToString();
            this.textBox17.Text = cal.Br.Zs2.ToString();
            this.textBox18.Text = cal.Br.Phi2.ToString();
            this.textBox19.Text = cal.Br.Omega2.ToString();
            this.textBox20.Text = cal.Br.Kappa2.ToString();
            this.textBox21.Text = cal.Br.DiffX2.ToString();
            this.textBox22.Text = cal.Br.DiffY2.ToString();
            this.textBox23.Text = cal.Br.DiffZ2.ToString();
            this.textBox24.Text = cal.Br.DiffPhi2.ToString();
            this.textBox25.Text = cal.Br.DiffOmega2.ToString();
            this.textBox26.Text = cal.Br.DiffKappa2.ToString();
            this.textBox27.Text = cal.Br.IterCount2.ToString();
            this.textBox28.Text = cal.Br.MidErr2.ToString();

            this.Forward.Enabled = true;
        }


        private void Insection(object sender,EventArgs e)
        {
            this.cal.SpaceIntersection();
            MessageBox.Show("空间前方交会解算成功", "系统信息", MessageBoxButtons.OK);

            

            int num = (int)this.cal.Fr.GetUpperBound(0) + 1;
            this.GroundXYZ.ColumnCount = 4;

            for (int i = 0; i < num - 1; i++) 
            {
                this.GroundXYZ.Rows.Add();
                for (int j = 0; j < 4; j++)
                    this.GroundXYZ.Rows[i].Cells[j].Value = (double)this.cal.Fr.GetValue(i, j);
            }
        }
        
    }
}
