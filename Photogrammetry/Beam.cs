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
    public partial class Beam : Form
    {
        public Calculate cal;
        public Beam(ref Calculate cal)
        {
            InitializeComponent();
            this.cal = cal;
        }

        private void Beam_Load(object sender,EventArgs e)
        {
            this.Text = "光束法定向";

            this.cal.BeamOrientation();
            MessageBox.Show("光束法一步定向成功", "系统信息", MessageBoxButtons.OK);

            this.textBox1.Text = cal.Bo.Xs1.ToString();
            this.textBox2.Text = cal.Bo.Ys1.ToString();
            this.textBox3.Text = cal.Bo.Zs1.ToString();
            this.textBox4.Text = cal.Bo.Phi1.ToString();
            this.textBox5.Text = cal.Bo.Omega1.ToString();
            this.textBox6.Text = cal.Bo.Kappa1.ToString();
            this.textBox7.Text = cal.Bo.DiffX1.ToString();
            this.textBox8.Text = cal.Bo.DiffY1.ToString();
            this.textBox9.Text = cal.Bo.DiffZ1.ToString();
            this.textBox10.Text = cal.Bo.DiffPhi1.ToString();
            this.textBox11.Text = cal.Bo.DiffOmega1.ToString();
            this.textBox12.Text = cal.Bo.DiffKappa1.ToString();

            this.textBox15.Text = cal.Bo.Xs2.ToString();
            this.textBox16.Text = cal.Bo.Ys2.ToString();
            this.textBox17.Text = cal.Bo.Zs2.ToString();
            this.textBox18.Text = cal.Bo.Phi2.ToString();
            this.textBox19.Text = cal.Bo.Omega2.ToString();
            this.textBox20.Text = cal.Bo.Kappa2.ToString();
            this.textBox21.Text = cal.Bo.DiffX2.ToString();
            this.textBox22.Text = cal.Bo.DiffY2.ToString();
            this.textBox23.Text = cal.Bo.DiffZ2.ToString();
            this.textBox24.Text = cal.Bo.DiffPhi2.ToString();
            this.textBox25.Text = cal.Bo.DiffOmega2.ToString();
            this.textBox26.Text = cal.Bo.DiffKappa2.ToString();
            this.textBox27.Text = cal.Bo.IterCount.ToString();
            this.textBox28.Text = cal.Bo.MidErr.ToString();

            int num = (int)this.cal.Bo.Zb.GetUpperBound(0) + 1;
            this.GroundData.ColumnCount = 4;
            
            for (int i = 0; i < num; i++)
            {
                this.GroundData.Rows.Add();
                for (int j = 0; j < 4; j++)
                    this.GroundData.Rows[i].Cells[j].Value = (double)this.cal.Bo.Zb.GetValue(i, j);
            }
        }

        
    }
}
