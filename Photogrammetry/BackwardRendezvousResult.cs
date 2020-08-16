using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Photogrammetry
{
    public class BackwardRendezvousResult  //后方交会结果
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

        private double midErr1, midErr2;
        public double MidErr1
        {
            get { return midErr1; }
            set { midErr1 = value; }
        }
        public double MidErr2
        {
            get { return midErr2; }
            set { midErr2 = value; }
        }

        private int iterCount1, iterCount2;
        public int IterCount1
        {
            get { return iterCount1; }
            set { iterCount1 = value; }
        }
        public int IterCount2
        {
            get { return iterCount2; }
            set { iterCount2 = value; }
        }

        /// <summary>
        /// 后方交会结果写入文件
        /// </summary>
        /// <param name="filename"></param>
        public void WriteBackwardRendezvousResult(string filename)
        {
            //string str = "";
            StreamWriter writer = new StreamWriter(filename, false, System.Text.Encoding.Default);
            writer.WriteLine("后方交会结果:");
            writer.WriteLine();
            writer.WriteLine("  左相片：");
            writer.WriteLine("      外方位元素：");
            writer.WriteLine("          Xs：" + xs1.ToString());
            writer.WriteLine("          Ys：" + ys1.ToString());
            writer.WriteLine("          Zs：" + zs1.ToString());
            writer.WriteLine("          φ：" + phi1.ToString());
            writer.WriteLine("          ω：" + omega1.ToString());
            writer.WriteLine("          κ：" + kappa1.ToString());
            writer.WriteLine("          dx：" + diffX1.ToString());
            writer.WriteLine("          dy：" + diffY1.ToString());
            writer.WriteLine("          dz：" + diffZ1.ToString());
            writer.WriteLine("          dφ：" + diffPhi1.ToString());
            writer.WriteLine("          dω：" + diffOmega1.ToString());
            writer.WriteLine("          dκ：" + diffKappa1.ToString());
            //writer.WriteLine("      迭代次数：" + IterCount1.ToString());
            writer.WriteLine("      中误差：" + midErr1.ToString());
            writer.WriteLine();
            writer.WriteLine("  右相片：");
            writer.WriteLine("      外方位元素：");
            writer.WriteLine("          Xs：" + xs2.ToString());
            writer.WriteLine("          Ys：" + ys2.ToString());
            writer.WriteLine("          Zs：" + zs2.ToString());
            writer.WriteLine("          φ：" + phi2.ToString());
            writer.WriteLine("          ω：" + omega2.ToString());
            writer.WriteLine("          κ：" + kappa2.ToString());
            writer.WriteLine("          dx：" + diffX2.ToString());
            writer.WriteLine("          dy：" + diffY2.ToString());
            writer.WriteLine("          dz：" + diffZ2.ToString());
            writer.WriteLine("          dφ：" + diffPhi2.ToString());
            writer.WriteLine("          dω：" + diffOmega2.ToString());
            writer.WriteLine("          dκ：" + diffKappa2.ToString());
            //writer.WriteLine("      迭代次数：" + IterCount2.ToString());
            writer.WriteLine("      中误差：" + midErr2.ToString());
            writer.Close();
        }
    }
}
