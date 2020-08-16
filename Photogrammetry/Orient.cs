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
    public partial class Orient : Form
    {
        public Calculate cal;
        public Orient(ref Calculate cal)
        {
            InitializeComponent();
            this.cal = cal;
        }

        private void Init()
        {
            this.AbsOrient.Enabled = false;
            this.CalGroundXYZ.Enabled = false;
        }

        private void Orient_Load(object sender, EventArgs e)
        {
            this.Text = "相对/绝对定向";
            Init();
        }

        private void Relative(object sender,EventArgs e)
        {
            this.cal.RelativeOrientation();
            MessageBox.Show("连续像对对相对定向成功", "系统信息", MessageBoxButtons.OK);
            
            this.textBox1.Text = this.cal.Ro.Phi.ToString();
            this.textBox2.Text = this.cal.Ro.Omega.ToString();
            this.textBox3.Text = this.cal.Ro.Kappa.ToString();
            this.textBox4.Text = this.cal.Ro.Mju.ToString();
            this.textBox5.Text = this.cal.Ro.Nju.ToString();
            this.textBox6.Text = this.cal.Ro.DiffPhi.ToString();
            this.textBox7.Text = this.cal.Ro.DiffKappa.ToString();
            this.textBox8.Text = this.cal.Ro.Kappa.ToString();
            this.textBox9.Text = this.cal.Ro.Mju.ToString();
            this.textBox10.Text = this.cal.Ro.DiffNju.ToString();
            this.textBox11.Text = this.cal.Ro.IterCount.ToString();
            this.textBox12.Text = this.cal.Ro.MidErr.ToString();

            this.AbsOrient.Enabled = true;
        }

        private void Absolute(object sender,EventArgs e)
        {
            this.cal.AbsoluteOrientation();
            MessageBox.Show("绝对定向成功", "系统信息", MessageBoxButtons.OK);


            this.textBox13.Text = this.cal.Ao.DeltaX.ToString();
            this.textBox14.Text = this.cal.Ao.DeltaY.ToString();
            this.textBox15.Text = this.cal.Ao.DeltaZ.ToString();
            this.textBox16.Text = this.cal.Ao.Lambda.ToString();
            this.textBox17.Text = this.cal.Ao.Phi.ToString();
            this.textBox18.Text = this.cal.Ao.Omega.ToString();
            this.textBox19.Text = this.cal.Ao.Kappa.ToString();

            this.textBox20.Text = this.cal.Ao.DiffDeltaX.ToString();
            this.textBox21.Text = this.cal.Ao.DiffDeltaY.ToString();
            this.textBox22.Text = this.cal.Ao.DiffDeltaZ.ToString();
            this.textBox23.Text = this.cal.Ao.DiffLambda.ToString();
            this.textBox24.Text = this.cal.Ao.DiffPhi.ToString();
            this.textBox25.Text = this.cal.Ao.DiffOmega.ToString();
            this.textBox26.Text = this.cal.Ao.DiffKappa.ToString();

            this.textBox27.Text = this.cal.Ao.IterCount.ToString();
            this.textBox28.Text = this.cal.Ao.MidErr.ToString();
            this.CalGroundXYZ.Enabled = true;

        }

        private void CalXYZ(object sender,EventArgs e)
        {
            this.cal.CalXyzAfterAO();
            MessageBox.Show("计算成功", "系统信息", MessageBoxButtons.OK);

            

            int num = (int)this.cal.Ao.Zb.GetUpperBound(0) + 1;
            this.GroundData.ColumnCount = 4;
            
            for (int i = 0; i < num; i++)
            {
                this.GroundData.Rows.Add();
                for (int j = 0; j < 4; j++)
                    this.GroundData.Rows[i].Cells[j].Value = (double)this.cal.Ao.Zb.GetValue(i, j);
            }
        }

    }
}
