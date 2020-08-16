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
    public partial class MainGUI : Form
    {
        public Calculate cal;
        private bool CtrlPointOpened = false;
        private bool PhotoPointOpened = false;
        private bool FrmDistanceOpened = false;

        public MainGUI()
        {
            InitializeComponent();
        }

        private void Init()
        {

            this.OpenFile.Enabled = false;
            this.Operations.Enabled = false;

            this.SpaceRendezvous.Enabled = false;
            this.Rel_AbsOrient.Enabled = false;
            this.BeamOrient.Enabled = false;

            this.CtrlPointOpened = false;
            this.PhotoPointOpened = false;
            this.FrmDistanceOpened = false;
        }
        private void GUI_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Text = "数字摄影测量-万奇峰-171830503";
            Init();
        }
        private void NewPhotoPair(object sender, EventArgs e)
        {
            cal = new Calculate();
            Init();
            this.OpenFile.Enabled = true;
            MessageBox.Show("创建成功", "系统信息", MessageBoxButtons.OK);
        }

        private void OpenFrameDistance(object sender, EventArgs e)
        {
            OpenFileDialog Frm = new OpenFileDialog();
            Frm.Filter = "所有文件（*.*）|*.*|文本文件（*.txt）|*.txt";
            Frm.FilterIndex = 2;
            Frm.Title = "打开框标距文件";
            try
            {
                if (Frm.ShowDialog() == DialogResult.OK)
                {
                    string filename = Frm.FileName;
                    this.cal.GetFrameDistance(filename);
                    
                    ShouldDistanceX.Text = this.cal.FrameDistance[0, 0].ToString();
                    ShouldDistanceY.Text = this.cal.FrameDistance[0, 1].ToString();
                    RealDistanceX.Text = this.cal.FrameDistance[1, 0].ToString();
                    RealDistanceY.Text = this.cal.FrameDistance[1, 1].ToString();
                    this.FrmDistanceOpened = true;
                }
            }
            catch
            {
                MessageBox.Show("  打开文件有误！\n  请打开正确的文件", "系统信息", MessageBoxButtons.OK);
            }
            
            if (this.FrmDistanceOpened && this.PhotoPointOpened && this.CtrlPointOpened)
            {
                this.Operations.Enabled = true;
            }
        }

        private void OpenCtrlPoints(object sender,EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "所有文件（*.*）|*.*|文本文件（*.txt）|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.Title = "打开控制点文件";
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;
                    this.cal.ReadControlPoint(filename);
                    
                    CtrlPointData.Visible = true;
                    int num = (int)this.cal.ControlPoint.GetUpperBound(0) + 1;
                    CtrlPointData.ColumnCount = 4;
                    
                    for (int i = 0; i < num; i++)
                    {
                        CtrlPointData.Rows.Add();
                        for (int j = 0; j < 4; j++)
                            CtrlPointData.Rows[i].Cells[j].Value = (double)this.cal.ControlPoint.GetValue(i, j);
                    }
                    this.CtrlPointOpened = true;
                }
            }
            catch
            {
                MessageBox.Show("  打开文件有误！\n  请打开正确的文件", "系统信息", MessageBoxButtons.OK);
            }
            if (this.FrmDistanceOpened && this.PhotoPointOpened && this.CtrlPointOpened)
            {
                this.Operations.Enabled = true;
            }
        }

        private void OpenPhotoPair(object sender,EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "所有文件（*.*）|*.*|文本文件（*.txt）|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.Title = "打开像点文件";
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;
                    this.cal.ReadPhotoData(filename);
                    
                    PhotoPointData.Visible = true;
                    int num = (int)cal.PhotoPoint.GetUpperBound(0);
                    PhotoPointData.ColumnCount = 5;
                        
                    for (int i = 1; i <= num; i++)
                    {
                        PhotoPointData.Rows.Add();
                        for (int j = 0; j < 5; j++)
                            PhotoPointData.Rows[i - 1].Cells[j].Value = (double)cal.PhotoPoint.GetValue(i, j);
                    }
                    this.PhotoPointOpened = true;
                }
            }
            catch
            {
                MessageBox.Show("  打开文件有误！\n  请打开正确的文件", "系统信息", MessageBoxButtons.OK);
            }
            if (this.FrmDistanceOpened && this.PhotoPointOpened && this.CtrlPointOpened)
            {
                this.Operations.Enabled = true;
            }
        }

        private void PhotoPointsCorrect(object sender,EventArgs e)
        {
            
            this.cal.CorrectPhoto();
            MessageBox.Show("像点纠正成功", "系统信息", MessageBoxButtons.OK);
            
            this.SpaceRendezvous.Enabled = true;
            this.Rel_AbsOrient.Enabled = true;
            this.BeamOrient.Enabled = true;
        }

        private void SpaceRendezvousClick(object sender,EventArgs e)
        {
            Rendezvous SR = new Rendezvous(ref this.cal);
            SR.ShowDialog();
        }

        private void OrientClick(object sender,EventArgs e)
        {
            Orient RAO = new Orient(ref this.cal);
            RAO.ShowDialog();
        }

        private void BeamClick(object sender,EventArgs e)
        {
            Beam BO = new Beam(ref this.cal);
            BO.ShowDialog();
        }
    }
}
