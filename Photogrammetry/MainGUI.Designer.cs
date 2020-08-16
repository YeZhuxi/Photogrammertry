using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;


namespace Photogrammetry
{
    partial class MainGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.NewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.PhotoPair = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFrmDistance = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenCtrlPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPhotoPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.Operations = new System.Windows.Forms.ToolStripMenuItem();
            this.PhotoPointCorrect = new System.Windows.Forms.ToolStripMenuItem();
            this.SpaceRendezvous = new System.Windows.Forms.ToolStripMenuItem();
            this.Rel_AbsOrient = new System.Windows.Forms.ToolStripMenuItem();
            this.BeamOrient = new System.Windows.Forms.ToolStripMenuItem();
            this.FrmDistance = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RealDistanceY = new System.Windows.Forms.TextBox();
            this.RealDistanceX = new System.Windows.Forms.TextBox();
            this.ShouldDistanceY = new System.Windows.Forms.TextBox();
            this.ShouldDistanceX = new System.Windows.Forms.TextBox();
            this.CtrlPoints = new System.Windows.Forms.GroupBox();
            this.CtrlPointData = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PhotoPoints = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PhotoPointData = new System.Windows.Forms.DataGridView();
            this.menu.SuspendLayout();
            this.FrmDistance.SuspendLayout();
            this.CtrlPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlPointData)).BeginInit();
            this.PhotoPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPointData)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Highlight;
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewProject,
            this.OpenFile,
            this.Operations});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1600, 32);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // NewProject
            // 
            this.NewProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PhotoPair});
            this.NewProject.Name = "NewProject";
            this.NewProject.Size = new System.Drawing.Size(85, 28);
            this.NewProject.Text = "新建(&N)";
            // 
            // PhotoPair
            // 
            this.PhotoPair.Name = "PhotoPair";
            this.PhotoPair.Size = new System.Drawing.Size(151, 30);
            this.PhotoPair.Text = "相对(&P)";
            this.PhotoPair.Click += new System.EventHandler(this.NewPhotoPair);
            // 
            // OpenFile
            // 
            this.OpenFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFrmDistance,
            this.OpenCtrlPoint,
            this.OpenPhotoPoint});
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(85, 28);
            this.OpenFile.Text = "打开(&O)";
            // 
            // OpenFrmDistance
            // 
            this.OpenFrmDistance.Name = "OpenFrmDistance";
            this.OpenFrmDistance.Size = new System.Drawing.Size(172, 30);
            this.OpenFrmDistance.Text = "框标距(&D)";
            this.OpenFrmDistance.Click += new System.EventHandler(this.OpenFrameDistance);
            // 
            // OpenCtrlPoint
            // 
            this.OpenCtrlPoint.Name = "OpenCtrlPoint";
            this.OpenCtrlPoint.Size = new System.Drawing.Size(172, 30);
            this.OpenCtrlPoint.Text = "控制点(&C)";
            this.OpenCtrlPoint.Click += new System.EventHandler(this.OpenCtrlPoints);
            // 
            // OpenPhotoPoint
            // 
            this.OpenPhotoPoint.Name = "OpenPhotoPoint";
            this.OpenPhotoPoint.Size = new System.Drawing.Size(172, 30);
            this.OpenPhotoPoint.Text = "相点(&P)";
            this.OpenPhotoPoint.Click += new System.EventHandler(this.OpenPhotoPair);
            // 
            // Operations
            // 
            this.Operations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PhotoPointCorrect,
            this.SpaceRendezvous,
            this.Rel_AbsOrient,
            this.BeamOrient});
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(82, 28);
            this.Operations.Text = "计算(&C)";
            // 
            // PhotoPointCorrect
            // 
            this.PhotoPointCorrect.Name = "PhotoPointCorrect";
            this.PhotoPointCorrect.Size = new System.Drawing.Size(233, 30);
            this.PhotoPointCorrect.Text = "相点纠正(&C)";
            this.PhotoPointCorrect.Click += new System.EventHandler(this.PhotoPointsCorrect);
            // 
            // SpaceRendezvous
            // 
            this.SpaceRendezvous.Name = "SpaceRendezvous";
            this.SpaceRendezvous.Size = new System.Drawing.Size(233, 30);
            this.SpaceRendezvous.Text = "空间交会(&R)";
            this.SpaceRendezvous.Click += new System.EventHandler(this.SpaceRendezvousClick);
            // 
            // Rel_AbsOrient
            // 
            this.Rel_AbsOrient.Name = "Rel_AbsOrient";
            this.Rel_AbsOrient.Size = new System.Drawing.Size(233, 30);
            this.Rel_AbsOrient.Text = "相对/绝对定向(&A)";
            this.Rel_AbsOrient.Click += new System.EventHandler(this.OrientClick);
            // 
            // BeamOrient
            // 
            this.BeamOrient.Name = "BeamOrient";
            this.BeamOrient.Size = new System.Drawing.Size(233, 30);
            this.BeamOrient.Text = "光束法定向(&B)";
            this.BeamOrient.Click += new System.EventHandler(this.BeamClick);
            // 
            // FrmDistance
            // 
            this.FrmDistance.Controls.Add(this.label15);
            this.FrmDistance.Controls.Add(this.label14);
            this.FrmDistance.Controls.Add(this.label4);
            this.FrmDistance.Controls.Add(this.label3);
            this.FrmDistance.Controls.Add(this.label2);
            this.FrmDistance.Controls.Add(this.label1);
            this.FrmDistance.Controls.Add(this.RealDistanceY);
            this.FrmDistance.Controls.Add(this.RealDistanceX);
            this.FrmDistance.Controls.Add(this.ShouldDistanceY);
            this.FrmDistance.Controls.Add(this.ShouldDistanceX);
            this.FrmDistance.Location = new System.Drawing.Point(13, 55);
            this.FrmDistance.Name = "FrmDistance";
            this.FrmDistance.Size = new System.Drawing.Size(698, 105);
            this.FrmDistance.TabIndex = 1;
            this.FrmDistance.TabStop = false;
            this.FrmDistance.Text = "框标距";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(614, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 18);
            this.label15.TabIndex = 8;
            this.label15.Text = "Y";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(491, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 18);
            this.label14.TabIndex = 7;
            this.label14.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "实际";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "理论";
            // 
            // RealDistanceY
            // 
            this.RealDistanceY.Location = new System.Drawing.Point(573, 46);
            this.RealDistanceY.Name = "RealDistanceY";
            this.RealDistanceY.ReadOnly = true;
            this.RealDistanceY.Size = new System.Drawing.Size(100, 28);
            this.RealDistanceY.TabIndex = 3;
            // 
            // RealDistanceX
            // 
            this.RealDistanceX.Location = new System.Drawing.Point(450, 46);
            this.RealDistanceX.Name = "RealDistanceX";
            this.RealDistanceX.ReadOnly = true;
            this.RealDistanceX.Size = new System.Drawing.Size(100, 28);
            this.RealDistanceX.TabIndex = 2;
            // 
            // ShouldDistanceY
            // 
            this.ShouldDistanceY.Location = new System.Drawing.Point(205, 46);
            this.ShouldDistanceY.Name = "ShouldDistanceY";
            this.ShouldDistanceY.ReadOnly = true;
            this.ShouldDistanceY.Size = new System.Drawing.Size(100, 28);
            this.ShouldDistanceY.TabIndex = 1;
            // 
            // ShouldDistanceX
            // 
            this.ShouldDistanceX.Location = new System.Drawing.Point(80, 46);
            this.ShouldDistanceX.Name = "ShouldDistanceX";
            this.ShouldDistanceX.ReadOnly = true;
            this.ShouldDistanceX.Size = new System.Drawing.Size(100, 28);
            this.ShouldDistanceX.TabIndex = 0;
            // 
            // CtrlPoints
            // 
            this.CtrlPoints.Controls.Add(this.CtrlPointData);
            this.CtrlPoints.Controls.Add(this.label8);
            this.CtrlPoints.Controls.Add(this.label7);
            this.CtrlPoints.Controls.Add(this.label6);
            this.CtrlPoints.Controls.Add(this.label5);
            this.CtrlPoints.Location = new System.Drawing.Point(13, 187);
            this.CtrlPoints.Name = "CtrlPoints";
            this.CtrlPoints.Size = new System.Drawing.Size(698, 701);
            this.CtrlPoints.TabIndex = 2;
            this.CtrlPoints.TabStop = false;
            this.CtrlPoints.Text = "控制点";
            // 
            // CtrlPointData
            // 
            this.CtrlPointData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CtrlPointData.Location = new System.Drawing.Point(22, 62);
            this.CtrlPointData.Name = "CtrlPointData";
            this.CtrlPointData.Size = new System.Drawing.Size(657, 616);
            this.CtrlPointData.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "点号";
            // 
            // PhotoPoints
            // 
            this.PhotoPoints.Controls.Add(this.label13);
            this.PhotoPoints.Controls.Add(this.label12);
            this.PhotoPoints.Controls.Add(this.label11);
            this.PhotoPoints.Controls.Add(this.label10);
            this.PhotoPoints.Controls.Add(this.label9);
            this.PhotoPoints.Controls.Add(this.PhotoPointData);
            this.PhotoPoints.Location = new System.Drawing.Point(717, 55);
            this.PhotoPoints.Name = "PhotoPoints";
            this.PhotoPoints.Size = new System.Drawing.Size(871, 833);
            this.PhotoPoints.TabIndex = 3;
            this.PhotoPoints.TabStop = false;
            this.PhotoPoints.Text = "相点";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(294, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "Vq";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "Vp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "x";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "点号";
            // 
            // PhotoPointData
            // 
            this.PhotoPointData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PhotoPointData.Location = new System.Drawing.Point(22, 79);
            this.PhotoPointData.Name = "PhotoPointData";
            this.PhotoPointData.RowTemplate.Height = 30;
            this.PhotoPointData.Size = new System.Drawing.Size(843, 731);
            this.PhotoPointData.TabIndex = 0;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.PhotoPoints);
            this.Controls.Add(this.CtrlPoints);
            this.Controls.Add(this.FrmDistance);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainGUI";
            this.Text = "MainGUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.FrmDistance.ResumeLayout(false);
            this.FrmDistance.PerformLayout();
            this.CtrlPoints.ResumeLayout(false);
            this.CtrlPoints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlPointData)).EndInit();
            this.PhotoPoints.ResumeLayout(false);
            this.PhotoPoints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPointData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem NewProject;
        private ToolStripMenuItem PhotoPair;
        private ToolStripMenuItem OpenFile;
        private ToolStripMenuItem OpenFrmDistance;
        private ToolStripMenuItem OpenCtrlPoint;
        private ToolStripMenuItem OpenPhotoPoint;
        private ToolStripMenuItem Operations;
        private ToolStripMenuItem PhotoPointCorrect;
        private ToolStripMenuItem SpaceRendezvous;
        private ToolStripMenuItem Rel_AbsOrient;
        private ToolStripMenuItem BeamOrient;
        private GroupBox FrmDistance;
        private TextBox RealDistanceY;
        private TextBox RealDistanceX;
        private TextBox ShouldDistanceY;
        private TextBox ShouldDistanceX;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox CtrlPoints;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView CtrlPointData;
        private GroupBox PhotoPoints;
        private DataGridView PhotoPointData;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label15;
        private Label label14;
    }
}