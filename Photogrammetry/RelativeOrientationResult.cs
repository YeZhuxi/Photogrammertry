using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Photogrammetry
{
    public class RelativeOrientationResult //相对定向结果
    {
        private double bx, by, bz;
        public double Bx
        {
            get { return bx; }
            set { bx = value; }
        }
        public double By
        {
            get { return by; }
            set { by = value; }
        }
        public double Bz
        {
            get { return bz; }
            set { bz = value; }
        }

        private double phi, omega, kappa, mju, nju;
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
        public double Mju
        {
            get { return mju; }
            set { mju = value; }
        }
        public double Nju
        {
            get { return nju; }
            set { nju = value; }
        }

        private double diffPhi, diffOmega, diffKappa, diffMju, diffNju;
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
        public double DiffMju
        {
            get { return diffMju; }
            set { diffMju = value; }
        }
        public double DiffNju
        {
            get { return diffNju; }
            set { diffNju = value; }
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
        /// 相对定向结果写入文件
        /// </summary>
        /// <param name="filename"></param>
        public void WriteRelativeOrientationResult(string filename)
        {
            
        }
    }
}
