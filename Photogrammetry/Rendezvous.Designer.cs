namespace Photogrammetry
{
    partial class Rendezvous
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.Backward = new System.Windows.Forms.ToolStripMenuItem();
            this.Forward = new System.Windows.Forms.ToolStripMenuItem();
            this.Left = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Right = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.Ground = new System.Windows.Forms.GroupBox();
            this.GroundXYZ = new System.Windows.Forms.DataGridView();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.Left.SuspendLayout();
            this.Right.SuspendLayout();
            this.Ground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroundXYZ)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Backward,
            this.Forward});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1600, 32);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // Backward
            // 
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(117, 28);
            this.Backward.Text = "后方交会(&B)";
            this.Backward.Click += new System.EventHandler(this.Resection);
            // 
            // Forward
            // 
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(116, 28);
            this.Forward.Text = "前方交会(&F)";
            this.Forward.Click += new System.EventHandler(this.Insection);
            // 
            // Left
            // 
            this.Left.Controls.Add(this.label14);
            this.Left.Controls.Add(this.label13);
            this.Left.Controls.Add(this.label12);
            this.Left.Controls.Add(this.label11);
            this.Left.Controls.Add(this.label10);
            this.Left.Controls.Add(this.label9);
            this.Left.Controls.Add(this.label8);
            this.Left.Controls.Add(this.label7);
            this.Left.Controls.Add(this.label6);
            this.Left.Controls.Add(this.label5);
            this.Left.Controls.Add(this.label4);
            this.Left.Controls.Add(this.label3);
            this.Left.Controls.Add(this.label2);
            this.Left.Controls.Add(this.label1);
            this.Left.Controls.Add(this.textBox14);
            this.Left.Controls.Add(this.textBox13);
            this.Left.Controls.Add(this.textBox12);
            this.Left.Controls.Add(this.textBox11);
            this.Left.Controls.Add(this.textBox10);
            this.Left.Controls.Add(this.textBox9);
            this.Left.Controls.Add(this.textBox8);
            this.Left.Controls.Add(this.textBox7);
            this.Left.Controls.Add(this.textBox6);
            this.Left.Controls.Add(this.textBox5);
            this.Left.Controls.Add(this.textBox4);
            this.Left.Controls.Add(this.textBox3);
            this.Left.Controls.Add(this.textBox2);
            this.Left.Controls.Add(this.textBox1);
            this.Left.Location = new System.Drawing.Point(24, 64);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(331, 360);
            this.Left.TabIndex = 1;
            this.Left.TabStop = false;
            this.Left.Text = "左相片";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(71, 313);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 18);
            this.label14.TabIndex = 27;
            this.label14.Text = "中误差";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "迭代次数";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(165, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "dκ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "dω";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "dφ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "dZ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "dY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "dX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "κ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "ω";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "φ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Zs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ys";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Xs";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(204, 308);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 28);
            this.textBox14.TabIndex = 13;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(204, 274);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 28);
            this.textBox13.TabIndex = 12;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(204, 215);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 28);
            this.textBox12.TabIndex = 11;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(204, 179);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 28);
            this.textBox11.TabIndex = 10;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(204, 145);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 28);
            this.textBox10.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(204, 111);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 28);
            this.textBox9.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(204, 77);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 28);
            this.textBox8.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(204, 43);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 28);
            this.textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(52, 213);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 28);
            this.textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(52, 179);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 28);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(52, 145);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 28);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(52, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 28);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 28);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 0;
            // 
            // Right
            // 
            this.Right.Controls.Add(this.label28);
            this.Right.Controls.Add(this.label27);
            this.Right.Controls.Add(this.label26);
            this.Right.Controls.Add(this.label25);
            this.Right.Controls.Add(this.label24);
            this.Right.Controls.Add(this.label23);
            this.Right.Controls.Add(this.label22);
            this.Right.Controls.Add(this.label21);
            this.Right.Controls.Add(this.label20);
            this.Right.Controls.Add(this.label19);
            this.Right.Controls.Add(this.label18);
            this.Right.Controls.Add(this.label17);
            this.Right.Controls.Add(this.label16);
            this.Right.Controls.Add(this.label15);
            this.Right.Controls.Add(this.textBox28);
            this.Right.Controls.Add(this.textBox27);
            this.Right.Controls.Add(this.textBox26);
            this.Right.Controls.Add(this.textBox25);
            this.Right.Controls.Add(this.textBox24);
            this.Right.Controls.Add(this.textBox23);
            this.Right.Controls.Add(this.textBox22);
            this.Right.Controls.Add(this.textBox21);
            this.Right.Controls.Add(this.textBox20);
            this.Right.Controls.Add(this.textBox19);
            this.Right.Controls.Add(this.textBox18);
            this.Right.Controls.Add(this.textBox17);
            this.Right.Controls.Add(this.textBox16);
            this.Right.Controls.Add(this.textBox15);
            this.Right.Location = new System.Drawing.Point(24, 446);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(331, 360);
            this.Right.TabIndex = 2;
            this.Right.TabStop = false;
            this.Right.Text = "右相片";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(73, 314);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(62, 18);
            this.label28.TabIndex = 27;
            this.label28.Text = "中误差";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(60, 280);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(80, 18);
            this.label27.TabIndex = 26;
            this.label27.Text = "迭代次数";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(165, 215);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 18);
            this.label26.TabIndex = 25;
            this.label26.Text = "dκ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(165, 181);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 18);
            this.label25.TabIndex = 24;
            this.label25.Text = "dω";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(165, 145);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 18);
            this.label24.TabIndex = 23;
            this.label24.Text = "dφ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(174, 111);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 18);
            this.label23.TabIndex = 22;
            this.label23.Text = "dZ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(174, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 18);
            this.label22.TabIndex = 21;
            this.label22.Text = "dY";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(174, 43);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 18);
            this.label21.TabIndex = 20;
            this.label21.Text = "dX";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 213);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 18);
            this.label20.TabIndex = 19;
            this.label20.Text = "κ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 179);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 18);
            this.label19.TabIndex = 18;
            this.label19.Text = "ω";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 145);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 18);
            this.label18.TabIndex = 17;
            this.label18.Text = "φ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 18);
            this.label17.TabIndex = 16;
            this.label17.Text = "Zs";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 18);
            this.label16.TabIndex = 15;
            this.label16.Text = "Ys";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 18);
            this.label15.TabIndex = 14;
            this.label15.Text = "Xs";
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(204, 309);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(100, 28);
            this.textBox28.TabIndex = 13;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(204, 275);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(100, 28);
            this.textBox27.TabIndex = 12;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(204, 210);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(100, 28);
            this.textBox26.TabIndex = 11;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(204, 176);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(100, 28);
            this.textBox25.TabIndex = 10;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(204, 140);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(100, 28);
            this.textBox24.TabIndex = 9;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(204, 106);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(100, 28);
            this.textBox23.TabIndex = 8;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(204, 72);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(100, 28);
            this.textBox22.TabIndex = 7;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(204, 38);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 28);
            this.textBox21.TabIndex = 6;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(52, 208);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 28);
            this.textBox20.TabIndex = 5;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(52, 174);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 28);
            this.textBox19.TabIndex = 4;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(52, 140);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 28);
            this.textBox18.TabIndex = 3;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(52, 106);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 28);
            this.textBox17.TabIndex = 2;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(52, 72);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 28);
            this.textBox16.TabIndex = 1;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(52, 38);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 28);
            this.textBox15.TabIndex = 0;
            // 
            // Ground
            // 
            this.Ground.Controls.Add(this.GroundXYZ);
            this.Ground.Controls.Add(this.label32);
            this.Ground.Controls.Add(this.label31);
            this.Ground.Controls.Add(this.label30);
            this.Ground.Controls.Add(this.label29);
            this.Ground.Location = new System.Drawing.Point(404, 64);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1169, 742);
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            this.Ground.Text = "相点地面坐标";
            // 
            // GroundXYZ
            // 
            this.GroundXYZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroundXYZ.Location = new System.Drawing.Point(41, 101);
            this.GroundXYZ.Name = "GroundXYZ";
            this.GroundXYZ.Size = new System.Drawing.Size(1101, 613);
            this.GroundXYZ.TabIndex = 4;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(426, 43);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(17, 18);
            this.label32.TabIndex = 3;
            this.label32.Text = "Z";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(299, 43);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(17, 18);
            this.label31.TabIndex = 2;
            this.label31.Text = "X";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(164, 43);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(17, 18);
            this.label30.TabIndex = 1;
            this.label30.Text = "Y";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(38, 43);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(44, 18);
            this.label29.TabIndex = 0;
            this.label29.Text = "点号";
            // 
            // Rendezvous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Rendezvous";
            this.Text = "Rendezvous";
            this.Load += new System.EventHandler(this.Rendezvous_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.Left.ResumeLayout(false);
            this.Left.PerformLayout();
            this.Right.ResumeLayout(false);
            this.Right.PerformLayout();
            this.Ground.ResumeLayout(false);
            this.Ground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroundXYZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Backward;
        private System.Windows.Forms.ToolStripMenuItem Forward;
        private System.Windows.Forms.GroupBox Left;
        private System.Windows.Forms.GroupBox Right;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox Ground;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridView GroundXYZ;
    }
}