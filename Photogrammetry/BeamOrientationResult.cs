using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Photogrammetry
{
    public class BeamOrientationResult //光束定向结果
    {
        private double xs1, ys1, zs1;
        public double Xs1
        {
            get { return xs1; }
            set { xs1 = value; }
        }
        public double Ys1
        {
            get { return ys1; }
            set { ys1 = value; }
        }
        public double Zs1
        {
            get { return zs1; }
            set { zs1 = value; }
        }

        private double xs2, ys2, zs2;
        public double Xs2
        {
            get { return xs2; }
            set { xs2 = value; }
        }
        public double Ys2
        {
            get { return ys2; }
            set { ys2 = value; }
        }
        public double Zs2
        {
            get { return zs2; }
            set { zs2 = value; }
        }

        private double phi1, omega1, kappa1;
        public double Phi1
        {
            get { return phi1; }
            set { phi1 = value; }
        }
        public double Omega1
        {
            get { return omega1; }
            set { omega1 = value; }
        }
        public double Kappa1
        {
            get { return kappa1; }
            set { kappa1 = value; }
        }

        private double phi2, omega2, kappa2;
        public double Phi2
        {
            get { return phi2; }
            set { phi2 = value; }
        }
        public double Omega2
        {
            get { return omega2; }
            set { omega2 = value; }
        }
        public double Kappa2
        {
            get { return kappa2; }
            set { kappa2 = value; }
        }

        private Array zb;
        public Array Zb
        {
            get { return zb; }
            set { zb = value; }
        }
        private double diffX1, diffY1, diffZ1;
        public double DiffX1
        {
            get { return diffX1; }
            set { diffX1 = value; }
        }
        public double DiffY1
        {
            get { return diffY1; }
            set { diffY1 = value; }
        }
        public double DiffZ1
        {
            get { return diffZ1; }
            set { diffZ1 = value; }
        }

        private double diffX2, diffY2, diffZ2;
        public double DiffX2
        {
            get { return diffX2; }
            set { diffX2 = value; }
        }
        public double DiffY2
        {
            get { return diffY2; }
            set { diffY2 = value; }
        }
        public double DiffZ2
        {
            get { return diffZ2; }
            set { diffZ2 = value; }
        }

        private double diffPhi1, diffOmega1, diffKappa1;
        public double DiffPhi1
        {
            get { return diffPhi1; }
            set { diffPhi1 = value; }
        }
        public double DiffOmega1
        {
            get { return diffOmega1; }
            set { diffOmega1 = value; }
        }
        public double DiffKappa1
        {
            get { return diffKappa1; }
            set { diffKappa1 = value; }
        }

        private double diffPhi2, diffOmega2, diffKappa2;
        public double DiffPhi2
        {
            get { return diffPhi2; }
            set { diffPhi2 = value; }
        }
        public double DiffOmega2
        {
            get { return diffOmega2; }
            set { diffOmega2 = value; }
        }
        public double DiffKappa2
        {
            get { return diffKappa2; }
            set { diffKappa2 = value; }
        }

        private double midErr;
        public double MidErr
        {
            get { return midErr; }
            set { midErr = value; }
        }

        private int iterCount;
        public int IterCount
        {
            get { return iterCount; }
            set { iterCount = value; }
        }

        /// <summary>
        /// 光束法定向结果写入文件
        /// </summary>
        /// <param name="filename"></param>
        public void WriteBeamOrientationResult(string filename)
        {
            string str = "";
            StreamWriter writer = new StreamWriter(filename, false, System.Text.Encoding.Default);
            writer.WriteLine("光束法定向:");
            writer.WriteLine();
            writer.WriteLine("  左相片外方位元素:");
            writer.WriteLine("      Xs：" + xs1.ToString());
            writer.WriteLine("      Ys：" + ys1.ToString());
            writer.WriteLine("      Zs：" + zs1.ToString());
            writer.WriteLine("      φ：" + phi1.ToString());
            writer.WriteLine("      ω：" + omega1.ToString());
            writer.WriteLine("      κ：" + kappa1.ToString());
            writer.WriteLine("  右相片外方位元素：");
            writer.WriteLine("      φ：" + phi2.ToString());
            writer.WriteLine("      ω：" + omega2.ToString());
            writer.WriteLine("      κ：" + kappa2.ToString());
            writer.WriteLine();
            writer.WriteLine("  中误差：" + midErr.ToString());
            writer.WriteLine();

            int num = zb.GetLength(0);
            writer.WriteLine("  光束法算得地面点坐标为:");
            writer.WriteLine("      点号,X,Y,Z");
            for (int i = 0; i < num; i++) 
            {
                str = "     "+zb.GetValue(i, 0).ToString() + "," + zb.GetValue(i, 1).ToString() + "," + zb.GetValue(i, 2).ToString() + "," + zb.GetValue(i, 3).ToString();
                writer.WriteLine(str);
            }
            writer.Close();
        }
    }
}
