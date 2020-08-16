using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Photogrammetry
{
    public class AbsoluteOrientationResult //绝对定向结果
    {
        private double deltaX, deltaY, deltaZ;
        public double DeltaX
        {
            get { return deltaX; }
            set { deltaX = value; }
        }
        public double DeltaY
        {
            get { return deltaY; }
            set { deltaY = value; }
        }
        public double DeltaZ
        {
            get { return deltaZ; }
            set { deltaZ = value; }
        }

        private double lambda, phi, omega, kappa;
        public double Lambda
        {
            get { return lambda; }
            set { lambda = value; }
        }
        public double Phi
        {
            get { return phi; }
            set { phi = value; }
        }
        public double Omega
        {
            get { return omega; }
            set { omega = value; }
        }
        public double Kappa
        {
            get { return kappa; }
            set { kappa = value; }
        }

        private Array zb;
        public Array Zb
        {
            get { return zb; }
            set { zb = value; }
        }
        private double diffDeltaX, diffDeltaY, diffDeltaZ;
        public double DiffDeltaX
        {
            get { return diffDeltaX; }
            set { diffDeltaX = value; }
        }
        public double DiffDeltaY
        {
            get { return diffDeltaY; }
            set { diffDeltaY = value; }
        }
        public double DiffDeltaZ
        {
            get { return diffDeltaZ; }
            set { diffDeltaZ = value; }
        }

        private double diffLambda, diffPhi, diffOmega, diffKappa;
        public double DiffLambda
        {
            get { return diffLambda; }
            set { diffLambda = value; }
        }
        public double DiffPhi
        {
            get { return diffPhi; }
            set { diffPhi = value; }
        }
        public double DiffOmega
        {
            get { return diffOmega; }
            set { diffOmega = value; }
        }
        public double DiffKappa
        {
            get { return diffKappa; }
            set { diffKappa = value; }
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
        /// 绝对定向结果写入文件
        /// </summary>
        /// <param name="filename"></param>
        public void WriteAbsoluteOrientationResult(string filename)
        {
            StreamWriter writer = new StreamWriter(filename, false, System.Text.Encoding.Default);
            writer.WriteLine("绝对定向结果:");
            writer.WriteLine();
            writer.WriteLine("点号,X,Y,Z");
            string str = "";
            int num = this.zb.GetLength(0);
            for (int i = 0; i < num; i++) 
            {
                str = zb.GetValue(i, 0).ToString() + "," + zb.GetValue(i, 1).ToString() + "," + zb.GetValue(i, 2).ToString() + "," + zb.GetValue(i, 3).ToString();
                writer.WriteLine(str);
            }
            writer.Close();
        }
    }
}
