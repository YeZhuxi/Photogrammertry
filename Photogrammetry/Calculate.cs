using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Photogrammetry
{
    public class Calculate
    {
        private double[,] frameDistance = new double[2, 2]; //框标距
        public double[,] FrameDistance
        {
            get { return frameDistance; }
            set { frameDistance = value; }
        }

        private Array controlPoint; //控制点
        public Array ControlPoint
        {
            get { return controlPoint; }
            set { controlPoint = value; }
        }

        private Array photoPoint; //相片点
        public Array PhotoPoint
        {
            get { return photoPoint; }
            set { photoPoint = value; }
        }

        private Array correctedPhotoPoint; //纠正后的相片点
        public Array CorrectedPhotoPoint
        {
            get { return correctedPhotoPoint; }
            set { correctedPhotoPoint = value; }
        }

        private double[] scale = new double[2]; //比例尺
        public double[] Scale
        {
            get { return scale; }
            set { scale = value; }
        }

        private BackwardRendezvousResult br; //后方交会结果
        public BackwardRendezvousResult Br
        {
            get { return br; }
            set { br = value; }
        }

        private Array fr; //前方交会ForwardRendezvousResult结果
        public Array Fr
        {
            get { return fr; }
            set { fr = value; }
        }

        private RelativeOrientationResult ro; //相对定向结果
        public RelativeOrientationResult Ro
        {
            get { return ro; }
            set { ro = value; }
        }

        private BeamOrientationResult bo; //光束法定向结果
        public BeamOrientationResult Bo
        {
            get { return bo; }
            set { bo = value; }
        }

        private AbsoluteOrientationResult ao; //绝对定向结果
        public AbsoluteOrientationResult Ao
        {
            get { return ao; }
            set { ao = value; }
        }


        /// <summary>
        /// 构造函数
        /// </summary>
        public Calculate()
        {
            this.br = new BackwardRendezvousResult();
            this.ro = new RelativeOrientationResult();
            this.bo = new BeamOrientationResult();
            this.ao = new AbsoluteOrientationResult();
        }

        /// <summary>
        /// 读取框标距
        /// </summary>
        /// <param name="filename"></param>
        public void GetFrameDistance(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs, System.Text.Encoding.Default);
            string s = "";
            string[] substr = new string[3];
            for (int i = 0; i < 2; i++)
            {
                s = reader.ReadLine(); //跳过一行
                s = reader.ReadLine();
                substr = s.Split(' '); //拆分
                for (int l = 0, m = 0; l < substr.Length; l++)
                {
                    if (substr[l].Trim() != "")
                    {
                        if (substr[l].Trim() != ",")
                        {
                            substr[m] = substr[l].Trim();
                            m++;
                        }
                    }
                }
                this.frameDistance[i, 0] = Convert.ToDouble(substr[0].Trim());
                this.frameDistance[i, 1] = Convert.ToDouble(substr[1].Trim());
            }
        }

        /// <summary>
        /// 读取一般相片数据
        /// </summary>
        /// <param name="filename"></param>
        public void ReadPhotoData(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            int num = 0;
            double f = 0;
            string s = "";
            s = reader.ReadLine(); //读取点个数
            num = Convert.ToInt32(s.Trim());
            this.photoPoint = Array.CreateInstance(typeof(Double), num + 1, 5);
            s = reader.ReadLine(); //读取f
            f = Convert.ToDouble(s.Trim());
            this.photoPoint.SetValue(f, 0, 0); //保存f
            for (int i = 1; i < num + 1; i++) //保存数据
            {
                string[] substr = new string[5];
                s = reader.ReadLine();
                substr = s.Split(' ');
                for (int l = 0, m = 0; l < substr.Length; l++)
                {
                    if (substr[l].Trim() != "")
                    {
                        substr[m] = substr[l].Trim();
                        m++;
                    }
                }
                this.photoPoint.SetValue(Convert.ToDouble(substr[0].Trim()), i, 0);
                this.photoPoint.SetValue(Convert.ToDouble(substr[1].Trim()), i, 1);
                this.photoPoint.SetValue(Convert.ToDouble(substr[2].Trim()), i, 2);
                this.photoPoint.SetValue(Convert.ToDouble(substr[3].Trim()), i, 3);
                this.photoPoint.SetValue(Convert.ToDouble(substr[4].Trim()), i, 4);
            }
            reader.Close();
        }


        /// <summary>
        /// 读取VirtuoZo相片数据
        /// </summary>
        /// <param name="filename"></param>
        public void ReadPhotoVZ(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            int num = 0;
            double f = 0;
            string s = "";
            s = reader.ReadLine(); //读取点个数
            num = Convert.ToInt32(s.Trim());
            this.photoPoint = Array.CreateInstance(typeof(Double), num + 1, 5);
            f = 152.720000;
            this.photoPoint.SetValue(f, 0, 0); //保存f
            for (int i = 1; i < num + 1; i++) //保存数据
            {
                string[] substr = new string[5];
                s = reader.ReadLine();
                substr = s.Split(' ');
                for (int l = 0, m = 0; l < substr.Length; l++)
                {
                    if (substr[l].Trim() != "")
                    {
                        substr[m] = substr[l].Trim();
                        m++;
                    }
                }
                this.photoPoint.SetValue(Convert.ToDouble(substr[0].Trim()), i, 0);
                this.photoPoint.SetValue(Convert.ToDouble(substr[1].Trim()), i, 1);
                this.photoPoint.SetValue(Convert.ToDouble(substr[2].Trim()), i, 2);
                this.photoPoint.SetValue(Convert.ToDouble(substr[3].Trim()), i, 3);
                this.photoPoint.SetValue(Convert.ToDouble(substr[4].Trim()), i, 4);
            }
            reader.Close();
        }

        /// <summary>
        /// 读取控制点数据
        /// </summary>
        /// <param name="filename"></param>
        public void ReadControlPoint(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            int num = 0;
            string s = "";
            s = reader.ReadLine(); //读取点个数
            num = Convert.ToInt32(s.Trim());
            this.controlPoint = Array.CreateInstance(typeof(Double), num, 4);
            for (int i = 0; i < num; i++) //保存数据
            {
                string[] substr = new string[4];
                s = reader.ReadLine();
                substr = s.Split(' ');
                for (int l = 0, m = 0; l < substr.Length; l++)
                {
                    if (substr[l].Trim() != "")
                    {
                        substr[m] = substr[l].Trim();
                        m++;
                    }
                }
                this.controlPoint.SetValue(Convert.ToDouble(substr[0].Trim()), i, 0);
                this.controlPoint.SetValue(Convert.ToDouble(substr[1].Trim()), i, 2);
                this.controlPoint.SetValue(Convert.ToDouble(substr[2].Trim()), i, 1);
                this.controlPoint.SetValue(Convert.ToDouble(substr[3].Trim()), i, 3);
            }
            reader.Close();
        }

        /// <summary>
        /// 读取VirtuoZo控制点数据
        /// </summary>
        /// <param name="filename"></param>
        public void ReadControlPointVZ(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            int num = 0;
            string s = "";
            s = reader.ReadLine(); //读取点个数
            num = Convert.ToInt32(s.Trim());
            this.controlPoint = Array.CreateInstance(typeof(Double), num, 4);
            for (int i = 0; i < num; i++) //保存数据
            {
                string[] substr = new string[4];
                s = reader.ReadLine();
                substr = s.Split(' ');
                for (int l = 0, m = 0; l < substr.Length; l++)
                {
                    if (substr[l].Trim() != "")
                    {
                        substr[m] = substr[l].Trim();
                        m++;
                    }
                }
                this.controlPoint.SetValue(Convert.ToDouble(substr[0].Trim()), i, 0);
                this.controlPoint.SetValue(Convert.ToDouble(substr[2].Trim()), i, 2);
                this.controlPoint.SetValue(Convert.ToDouble(substr[1].Trim()), i, 1);
                this.controlPoint.SetValue(Convert.ToDouble(substr[3].Trim()), i, 3);
            }
            reader.Close();
        }

        /// <summary>
        /// 一般数据相片纠正
        /// </summary>
        public void CorrectPhoto()
        {
            int num = this.photoPoint.GetUpperBound(0);
            this.correctedPhotoPoint = Array.CreateInstance(typeof(Double), num + 1, 5); //存储纠正后的相片数据的Array对象
            double x = frameDistance[0, 0] / frameDistance[1, 0]; //计算x向比例
            double y = frameDistance[0, 1] / frameDistance[1, 1]; //计算y向比例
            double Vx = 0, Vy = 0, Vp = 0, Vq = 0, x1, x2, y1, y2;
            this.correctedPhotoPoint.SetValue((double)this.photoPoint.GetValue(0, 0) / 1000, 0, 0); //f单位换算 mm → m
            for (int i = 1; i <= num; i++)
            {
                Vx = (double)this.photoPoint.GetValue(i, 1);
                Vy = (double)this.photoPoint.GetValue(i, 2);
                Vp = (double)this.photoPoint.GetValue(i, 3);
                Vq = (double)this.photoPoint.GetValue(i, 4);
                x1 = Vx - 100;        //？？？
                y1 = 100 - Vy;        //？？？
                x2 = x1 - Vp;         //？？？
                y2 = y1 + 10 - Vq;    //？？？
                this.correctedPhotoPoint.SetValue((double)this.photoPoint.GetValue(i, 0), i, 0);
                this.correctedPhotoPoint.SetValue(x1 * x / 1000.0, i, 1);
                this.correctedPhotoPoint.SetValue(y1 * y / 1000.0, i, 2);
                this.correctedPhotoPoint.SetValue(x2 * x / 1000.0, i, 3);
                this.correctedPhotoPoint.SetValue(y2 * y / 1000.0, i, 4);
            }
        }

        /// <summary>
        /// VirtuoZo数据相片纠正
        /// </summary>
        public void CorrectPhotoVZ()
        {
            int num = this.photoPoint.GetUpperBound(0);
            this.correctedPhotoPoint = Array.CreateInstance(typeof(Double), num + 1, 5);
            double x1, x2, y1, y2;
            this.correctedPhotoPoint.SetValue((double)this.photoPoint.GetValue(0, 0) / 1000, 0, 0);
            for (int i = 1; i <= num; i++)
            {
                x1 = (double)this.photoPoint.GetValue(i, 1);
                y1 = (double)this.photoPoint.GetValue(i, 2);
                x2 = (double)this.photoPoint.GetValue(i, 3);
                y2 = (double)this.photoPoint.GetValue(i, 4);
                this.correctedPhotoPoint.SetValue((double)this.photoPoint.GetValue(i, 0), i, 0);
                this.correctedPhotoPoint.SetValue(x1 / 1000.0, i, 1);
                this.correctedPhotoPoint.SetValue(y1 / 1000.0, i, 2);
                this.correctedPhotoPoint.SetValue(x2 / 1000.0, i, 3);
                this.correctedPhotoPoint.SetValue(y2 / 1000.0, i, 4);
            }
        }

        /// <summary>
        /// 空间后方交会
        /// </summary>
        public void SpaceResection()
        {
            int num = 0;

            double Xsum = 0, Ysum = 0, Zsum = 0;
            double f = (double)this.correctedPhotoPoint.GetValue(0, 0), Xs, Ys, Zs, Xavg, Yavg, Zavg;
            int[,] Link = MatchPoint(ref num);

            this.CalScale();

            for (int i = 0; i < num; i++)
            {
                Xsum += (double)this.controlPoint.GetValue(Link[i, 0], 1);
                Ysum += (double)this.controlPoint.GetValue(Link[i, 0], 2);
                Zsum += (double)this.controlPoint.GetValue(Link[i, 0], 3);
            }
            for (int numPhoto = 0; numPhoto < 2; numPhoto++)
            {
                double[,] R = new double[3, 3];
                int numIter = 0;
                double phi = 0, omega = 0, kappa = 0;
                Xavg = Xs = Xsum / num;
                Yavg = Ys = Ysum / num;
                Zavg = Zs = Zsum / num + f * scale[numPhoto];
                Matrix A = new Matrix(2 * num, 6);
                Matrix L = new Matrix(2 * num, 1);
                Matrix X = new Matrix(6, 1);
                while (true)
                {
                    R = CalRotMatrix(phi, omega, kappa);
                    for (int i = 0; i < num; i++)
                    {
                        double[] XYZ = CalXYZ(R, Xs, Ys, Zs, (double)this.controlPoint.GetValue(Link[i, 0], 1), (double)this.controlPoint.GetValue(Link[i, 0], 2), (double)this.controlPoint.GetValue(Link[i, 0], 3));
                        double x = (double)this.correctedPhotoPoint.GetValue(Link[i, 1], 1 + numPhoto * 2);
                        double y = (double)this.correctedPhotoPoint.GetValue(Link[i, 1], 2 + numPhoto * 2);
                        double[,] CoeA = CalCoeA(XYZ, R, f, x, y, phi, omega, kappa);
                        double[] ErrMatrix = CalErrMatrix(R, f, XYZ, x, y);
                        for (int t = 0; t < 2; t++)
                        {
                            L.Data.SetValue(ErrMatrix[t], t + i * 2, 0);
                            for (int o = 0; o < 6; o++)
                                A.Data.SetValue(CoeA[t, o], t + i * 2, o);
                        }
                    }
                    X = (!(~A * A)) * (~A) * L;
                    Xs += (double)X.Data.GetValue(0, 0);
                    Ys += (double)X.Data.GetValue(1, 0);
                    Zs += (double)X.Data.GetValue(2, 0);
                    phi += (double)X.Data.GetValue(3, 0);
                    omega += (double)X.Data.GetValue(4, 0);
                    kappa += (double)X.Data.GetValue(5, 0);
                    double tolerance = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        tolerance = Math.Abs(Math.Max(Math.Abs((double)X.Data.GetValue(3 + i, 0)), tolerance));
                    }
                    if (tolerance < 0.1 * Math.PI / 60 / 180) 
                    {
                        numIter++;
                        break;
                    }
                    else numIter++;
                }
                Matrix V = A * X - L;
                Matrix temp = !(~A * A);
                if (numPhoto == 0) //左相片
                {
                    this.br.Xs1 = Xs; this.br.Ys1 = Ys; this.br.Zs1 = Zs;
                    this.br.Phi1 = phi; this.br.Omega1 = omega; this.br.Kappa1 = kappa;
                    this.br.IterCount1 = numIter;
                    this.br.MidErr1 = Math.Sqrt((double)((~V * V).Data.GetValue(0, 0)) / (2 * num - 6));
                    this.br.DiffX1 = this.br.MidErr1 * Math.Sqrt((double)temp.Data.GetValue(0, 0));
                    this.br.DiffY1 = this.br.MidErr1 * Math.Sqrt((double)temp.Data.GetValue(1, 1));
                    this.br.DiffZ1 = this.br.MidErr1 * Math.Sqrt((double)temp.Data.GetValue(2, 2));
                    this.br.DiffPhi1 = this.br.MidErr1 * Math.Sqrt((double)temp.Data.GetValue(3, 3));
                    this.br.DiffOmega1 = this.br.MidErr1 * Math.Sqrt((double)temp.Data.GetValue(4, 4));
                    this.br.DiffKappa1 = this.br.MidErr1 * Math.Sqrt((double)temp.Data.GetValue(5, 5));
                }
                else if (numPhoto == 1) //右相片
                {
                    this.br.Xs2 = Xs; this.br.Ys2 = Ys; this.br.Zs2 = Zs;
                    this.br.Phi2 = phi; this.br.Omega2 = omega; this.bo.Kappa2 = kappa;
                    this.br.IterCount2 = numIter;
                    this.br.MidErr2 = Math.Sqrt((double)((~V * V).Data.GetValue(0, 0)) / (2 * num - 6));
                    this.br.DiffX2 = this.br.MidErr2 * Math.Sqrt((double)temp.Data.GetValue(0, 0));
                    this.br.DiffY2 = this.br.MidErr2 * Math.Sqrt((double)temp.Data.GetValue(1, 1));
                    this.br.DiffZ2 = this.br.MidErr2 * Math.Sqrt((double)temp.Data.GetValue(2, 2));
                    this.br.DiffPhi2 = this.br.MidErr2 * Math.Sqrt((double)temp.Data.GetValue(3, 3));
                    this.br.DiffOmega2 = this.br.MidErr2 * Math.Sqrt((double)temp.Data.GetValue(4, 4));
                    this.br.DiffKappa2 = this.br.MidErr2 * Math.Sqrt((double)temp.Data.GetValue(5, 5));
                }
            }
        }

        /// <summary>
        /// 空间前方交会
        /// </summary>
        public void SpaceIntersection()
        {
            int num = this.correctedPhotoPoint.GetUpperBound(0);
            this.fr = Array.CreateInstance(typeof(Double), num + 1, 4);
            double Xs1 = this.br.Xs1;
            double Ys1 = this.br.Ys1;
            double Zs1 = this.br.Zs1;
            double phi1 = this.br.Phi1;
            double omega1 = this.br.Omega1;
            double kappa1 = this.br.Kappa1;
            double Xs2 = this.br.Xs2;
            double Ys2 = this.br.Ys2;
            double Zs2 = this.br.Zs2;
            double phi2 = this.br.Phi2;
            double omega2 = this.br.Omega2;
            double kappa2 = this.br.Kappa2;
            double Bx = Xs2 - Xs1;
            double By = Ys2 - Ys1;
            double Bz = Zs2 - Zs1;
            double f = (double)this.correctedPhotoPoint.GetValue(0, 0);
            for (int i = 0; i < num; i++)
            {
                double[,] temp = new double[3, 1];
                Matrix P1 = new Matrix(3, 1);
                Matrix P2 = new Matrix(3, 1);
                temp[0, 0] = (double)this.correctedPhotoPoint.GetValue(i + 1, 1);
                temp[1, 0] = (double)this.correctedPhotoPoint.GetValue(i + 1, 2);
                temp[2, 0] = -f;
                Matrix leftPhoto = new Matrix(temp, 3, 1);
                temp[0, 0] = (double)this.correctedPhotoPoint.GetValue(i + 1, 3);
                temp[1, 0] = (double)this.correctedPhotoPoint.GetValue(i + 1, 4);
                temp[2, 0] = -f;
                Matrix rightPhoto = new Matrix(temp, 3, 1);
                Matrix R1 = new Matrix(CalRotMatrix(phi1, omega1, kappa1), 3, 3);
                Matrix R2 = new Matrix(CalRotMatrix(phi2, omega2, kappa2), 3, 3);
                P1 = R1 * leftPhoto;
                P2 = R2 * rightPhoto;
                double[] N = new double[2];
                N = CalPrjCoe(Bx, Bz, (double)P1.Data.GetValue(0, 0), (double)P2.Data.GetValue(0, 0), (double)P1.Data.GetValue(2, 0), (double)P2.Data.GetValue(2, 0));

                this.fr.SetValue((double)this.correctedPhotoPoint.GetValue(i + 1, 0), i, 0);
                this.fr.SetValue(Xs1 + N[0] * (double)P1.Data.GetValue(0, 0), i, 1);
                this.fr.SetValue(Ys1 + N[0] * (double)P1.Data.GetValue(1, 0), i, 2);
                this.fr.SetValue(Zs1 + N[0] * (double)P1.Data.GetValue(2, 0), i, 3);
            }
        }

        /// <summary>
        /// 相对定向
        /// </summary>
        public void RelativeOrientation()
        {
            int num = this.correctedPhotoPoint.GetUpperBound(0);//相片像点个数

            double bx = (double)this.correctedPhotoPoint.GetValue(1, 1) - (double)this.correctedPhotoPoint.GetValue(1, 3);//x方向的摄影基线

            double phi, omega, kappa, mju, nju;
            phi = omega = kappa = mju = nju = 0;
            double f = (double)this.correctedPhotoPoint.GetValue(0, 0);
            Matrix R1 = new Matrix(CalRotMatrix(0.0, 0.0, 0.0), 3, 3);
            int numIter = 0;
            Matrix A = new Matrix(num, 5);
            Matrix L = new Matrix(num, 1);
            Matrix V = new Matrix(num, 1);
            Matrix X = new Matrix(num, 1);
            while (true)
            {
                Matrix R2 = new Matrix(CalRotMatrix(phi, omega, kappa), 3, 3);
                double by = bx * Math.Tan(mju);
                double bz = bx / Math.Cos(mju) * Math.Tan(nju);
                for (int i = 0; i < num; i++)
                {
                    double[,] temp = new double[3, 1];
                    Matrix P1 = new Matrix(3, 1);
                    temp[0, 0] = (double)this.correctedPhotoPoint.GetValue(i + 1, 1);
                    temp[1, 0] = (double)this.correctedPhotoPoint.GetValue(i + 1, 2);
                    temp[2, 0] = -f;
                    Matrix leftPhoto = new Matrix(temp, 3, 1);
                    Matrix P2 = new Matrix(3, 1);
                    temp[0, 0] = (double)this.correctedPhotoPoint.GetValue(i + 1, 3);
                    temp[1, 0] = (double)this.correctedPhotoPoint.GetValue(i + 1, 4);
                    temp[2, 0] = -f;
                    Matrix rightPhoto = new Matrix(temp, 3, 1);
                    P1 = R1 * leftPhoto;
                    P2 = R2 * rightPhoto;
                    double[] N = CalPrjCoe(bx, bz, (double)P1.Data.GetValue(0, 0), (double)P2.Data.GetValue(0, 0), (double)P1.Data.GetValue(2, 0), (double)P2.Data.GetValue(2, 0));
                    double Q = N[0] * (double)P1.Data.GetValue(1, 0) - N[1] * (double)P2.Data.GetValue(1, 0) - by;
                    double a = bx;
                    double b = -(double)P2.Data.GetValue(1, 0) / (double)P2.Data.GetValue(2, 0) * bx;
                    double c = -(double)P2.Data.GetValue(0, 0) * (double)P2.Data.GetValue(1, 0) / (double)P2.Data.GetValue(2, 0) * N[1];
                    double d = -((double)P2.Data.GetValue(2, 0) + (double)P2.Data.GetValue(1, 0) * (double)P2.Data.GetValue(1, 0) / (double)P2.Data.GetValue(2, 0)) * N[1];
                    double e = (double)P2.Data.GetValue(0, 0) * N[1];
                    L.Data.SetValue(Q, i, 0);
                    A.Data.SetValue(a, i, 0);
                    A.Data.SetValue(b, i, 1);
                    A.Data.SetValue(c, i, 2);
                    A.Data.SetValue(d, i, 3);
                    A.Data.SetValue(e, i, 4);
                }
                X = !((~A) * A) * (~A) * L;
                mju += (double)X.Data.GetValue(0, 0);
                nju += (double)X.Data.GetValue(1, 0);
                phi += (double)X.Data.GetValue(2, 0);
                omega += (double)X.Data.GetValue(3, 0);
                kappa += (double)X.Data.GetValue(4, 0);
                numIter++;
                bool tolerance = (Math.Abs((double)X.Data.GetValue(0, 0)) < 0.3 * 10e-4) && (Math.Abs((double)X.Data.GetValue(1, 0)) < 0.3 * 10e-4) && (Math.Abs((double)X.Data.GetValue(2, 0)) < 0.3 * 10e-4) && (Math.Abs((double)X.Data.GetValue(3, 0)) < 0.3 * 10e-4) && (Math.Abs((double)X.Data.GetValue(4, 0)) < 0.3 * 10e-4);
                if (tolerance) break;
            }
            V = A * X - L;
            this.ro.MidErr = Math.Sqrt((double)((~V * V).Data.GetValue(0, 0)) / (num - 5));
            Matrix tmp = !(~A * A);
            this.ro.IterCount = numIter;
            this.ro.DiffMju = this.ro.MidErr * Math.Sqrt((double)tmp.Data.GetValue(0, 0));
            this.ro.DiffNju = this.ro.MidErr * Math.Sqrt((double)tmp.Data.GetValue(1, 1));
            this.ro.DiffPhi = this.ro.MidErr * Math.Sqrt((double)tmp.Data.GetValue(2, 2));
            this.ro.DiffOmega = this.ro.MidErr * Math.Sqrt((double)tmp.Data.GetValue(3, 3));
            this.ro.DiffKappa = this.ro.MidErr * Math.Sqrt((double)tmp.Data.GetValue(4, 4));
            this.ro.Mju = mju;
            this.ro.Nju = nju;
            this.ro.Bx = bx;
            this.ro.By = bx * mju;
            this.ro.Bz = bx * nju;
            this.ro.Phi = phi;
            this.ro.Omega = omega;
            this.ro.Kappa = kappa;
        }

        /// <summary>
        /// 绝对定向
        /// </summary>
        public void AbsoluteOrientation()
        {
            double deltaX, deltaY, deltaZ, lambda, phi, omega, kappa; //绝对定向的初始值
            deltaX = deltaY = deltaZ = phi = omega = kappa = 0; lambda = 1;
            
            int num = 0; //像对控制点个数
            int numIter = 0; //迭代次数

            double f = (double)this.correctedPhotoPoint.GetValue(0, 0); //获得相机的焦距

            double Xgroundgravity, Ygroundgravity, Zgroundgravity; //地面摄影测量坐标的重心
            double Xgravity,Ygravity, Zgravity; //摄影测量坐标的重心
            Xgroundgravity = Ygroundgravity = Zgroundgravity = Xgravity = Ygravity = Zgravity = 0;

            int[,] Link = MatchPoint(ref num); //获得控制点与像点的匹配数据

            this.CalScale(); //计算相片的比例尺

            Matrix R1 = new Matrix(CalRotMatrix(0.0, 0.0, 0.0), 3, 3); //获得左相片的旋转矩阵
            Matrix R2 = new Matrix(CalRotMatrix(ro.Phi, ro.Omega, ro.Kappa), 3, 3); //获得右相片的旋转矩阵

            double[,] Pg = new double[3, num]; //以列为方式存储计算所得的各控制点所对应的像点的摄影测量坐标：第一行为Xp,第二行为Yp,第三行为Zp
            double[,] Pgg = new double[3, num]; //以列为方式存储计算所得的各控制点所对应的像点的地面摄影测量坐标：第一行为Xgp,第二行为Ytp,第三行为Ztp

            for (int i = 0; i < num; i++)
            {
                double Xp, Yp, Zp; //控制点摄影测量坐标
                Xp = Yp = Zp = 0;
                Pgg[0, i] = (double)this.controlPoint.GetValue(Link[i, 0], 1);
                Pgg[1, i] = (double)this.controlPoint.GetValue(Link[i, 0], 2);
                Pgg[2, i] = (double)this.controlPoint.GetValue(Link[i, 0], 3);
                Xgroundgravity += Pgg[0, i];
                Ygroundgravity += Pgg[1, i];
                Zgroundgravity += Pgg[2, i]; //地面摄影测量坐标累计求和

                double[,] temp = new double[3, 1];
                Matrix P1 = new Matrix(3, 1);
                temp[0, 0] = (double)this.correctedPhotoPoint.GetValue(Link[i, 1], 1);
                temp[1, 0] = (double)this.correctedPhotoPoint.GetValue(Link[i, 1], 2);
                temp[2, 0] = -f;
                Matrix Pghoto1 = new Matrix(temp, 3, 1);
                Matrix P2 = new Matrix(3, 1);
                temp[0, 0] = (double)this.correctedPhotoPoint.GetValue(Link[i, 1], 3);
                temp[1, 0] = (double)this.correctedPhotoPoint.GetValue(Link[i, 1], 4);
                temp[2, 0] = -f;
                Matrix Pghoto2 = new Matrix(temp, 3, 1);
                P1 = R1 * Pghoto1;
                P2 = R2 * Pghoto2;
                double[] N = CalPrjCoe(ro.Bx, ro.Bz, (double)P1.Data.GetValue(0, 0), (double)P2.Data.GetValue(0, 0), (double)P1.Data.GetValue(2, 0), (double)P2.Data.GetValue(2, 0));
                Xp = Pg[0, i] = scale[0] * N[0] * (double)P1.Data.GetValue(0, 0); //计算各控制点的摄影测量坐标
                Yp = Pg[1, i] = (N[0] * (double)P1.Data.GetValue(1, 0) + N[1] * (double)P2.Data.GetValue(1, 0) + ro.By) * scale[0] / 2;
                Zp = Pg[2, i] = scale[0] * f + scale[0] * N[0] * (double)P1.Data.GetValue(2, 0);

                Xgravity += Xp; Ygravity += Yp; Zgravity += Zp; //计算控制点对应像点的摄影测量坐标的累计值
            }
            Xgroundgravity /= num; Ygroundgravity /= num; Zgroundgravity /= num; //计算地面摄影测量坐标的重心坐标
            Xgravity /= num; Ygravity /= num; Zgravity /= num; //计算摄影测量坐标的重心坐标

            for (int i = 0; i < num; i++)
            {
                Pgg[0, i] -= Xgroundgravity; Pgg[1, i] -= Ygroundgravity; Pgg[2, i] -= Zgroundgravity; //逐点计算重心化后的地面摄影测量坐标
                Pg[0, i] -= Xgravity; Pg[1, i] -= Ygravity; Pg[2, i] -= Zgravity; //逐点计算中心化后的摄影测量坐标
            }
            Matrix A = new Matrix(3 * num, 7);
            Matrix L = new Matrix(3 * num, 1);
            Matrix X = new Matrix(7, 1);
            while (true)
            {
                double[,] Rtemp = CalRotMatrix(phi, omega, kappa);
                Matrix R = new Matrix(Rtemp, 3, 3); //旋转矩阵

                double[,] temp = new double[3, 1];

                temp[0, 0] = deltaX; temp[1, 0] = deltaY; temp[2, 0] = deltaZ;
                Matrix delta = new Matrix(temp, 3, 1); //改正数

                for (int i = 0; i < num; i++)
                {
                    A.Data.SetValue(1, 3 * i, 0);
                    A.Data.SetValue(Pg[0, i], 3 * i, 3);
                    A.Data.SetValue(-Pg[2, i], 3 * i, 4);
                    A.Data.SetValue(-Pg[1, i], 3 * i, 6);
                    A.Data.SetValue(1, 1 + 3 * i, 1);
                    A.Data.SetValue(Pg[1, i], 1 + 3 * i, 3);
                    A.Data.SetValue(-Pg[2, i], 1 + 3 * i, 5);
                    A.Data.SetValue(Pg[0, i], 1 + 3 * i, 6);
                    A.Data.SetValue(1, 2 + 3 * i, 2);
                    A.Data.SetValue(Pg[2, i], 2 + 3 * i, 3);
                    A.Data.SetValue(Pg[0, i], 2 + 3 * i, 4);
                    A.Data.SetValue(Pg[1, i], 2 + 3 * i, 5);

                    temp[0, 0] = Pg[0, i]; temp[1, 0] = Pg[1, i]; temp[2, 0] = Pg[2, i];
                    Matrix Xp = new Matrix(temp, 3, 1); 

                    temp[0, 0] = Pgg[0, i]; temp[1, 0] = Pgg[1, i]; temp[2, 0] = Pgg[2, i];
                    Matrix Xgp = new Matrix(temp, 3, 1);  

                    Matrix Ltemp = Xgp - lambda * R * Xp;
                    L.Data.SetValue((double)Ltemp.Data.GetValue(0, 0), i * 3, 0);
                    L.Data.SetValue((double)Ltemp.Data.GetValue(1, 0), 1 + i * 3, 0);
                    L.Data.SetValue((double)Ltemp.Data.GetValue(2, 0), 2 + i * 3, 0);
                }

                X = !(~A * A) * ~A * L; //计算改正结果矩阵X

                //绝对定向结果修正
                deltaX += (double)X.Data.GetValue(0, 0);
                deltaY += (double)X.Data.GetValue(1, 0);
                deltaZ += (double)X.Data.GetValue(2, 0);
                lambda += (double)X.Data.GetValue(3, 0);
                phi += (double)X.Data.GetValue(4, 0);
                omega += (double)X.Data.GetValue(5, 0);
                kappa += (double)X.Data.GetValue(6, 0);

                numIter++; //迭代次数自加一

                bool Tolerance = (Math.Abs((double)X.Data.GetValue(4, 0)) < 1.0 * Math.PI / 180 / 60) && (Math.Abs((double)X.Data.GetValue(5, 0)) < 1.0 * Math.PI / 180 / 60) && (Math.Abs((double)X.Data.GetValue(6, 0)) < 1.0 * Math.PI / 180 / 60);
                if (Tolerance)
                    break;
            }
            Matrix V = A * X - L;

            this.ao.MidErr = Math.Sqrt((double)((~V * V).Data.GetValue(0, 0)) / (3 * num - 7)); //计算中误差

            Matrix tmp = !(~A * A);

            this.ao.IterCount = numIter;
            this.ao.DiffDeltaX = this.ao.MidErr * Math.Sqrt((double)tmp.Data.GetValue(0, 0));
            this.ao.DiffDeltaY = this.ao.MidErr * Math.Sqrt((double)tmp.Data.GetValue(1, 1));
            this.ao.DiffDeltaZ = this.ao.MidErr * Math.Sqrt((double)tmp.Data.GetValue(2, 2));
            this.ao.DiffLambda = this.ao.MidErr * Math.Sqrt((double)tmp.Data.GetValue(3, 3));
            this.ao.DiffPhi = this.ao.MidErr * Math.Sqrt((double)tmp.Data.GetValue(4, 4));
            this.ao.DiffOmega = this.ao.MidErr * Math.Sqrt((double)tmp.Data.GetValue(5, 5));
            this.ao.DiffKappa = this.ao.MidErr * Math.Sqrt((double)tmp.Data.GetValue(6, 6));
            this.ao.DeltaX = Xgroundgravity - Xgravity + deltaX;
            this.ao.DeltaY = Ygroundgravity - Ygravity + deltaY;
            this.ao.DeltaZ = Zgroundgravity - Zgravity + deltaZ;
            this.ao.Lambda = lambda;
            this.ao.Phi = phi;
            this.ao.Omega = omega;
            this.ao.Kappa = kappa;
            this.CalXyzAfterAO();
        }

        /// <summary>
        /// 计算绝对定向后的模型点坐标
        /// </summary>
        public void CalXyzAfterAO() 
        {
            int num = this.correctedPhotoPoint.GetUpperBound(0);
            double[,] temp = new double[3, 1];
            double f = (double)this.correctedPhotoPoint.GetValue(0, 0); //获得相机的焦距
            Matrix R1 = new Matrix(CalRotMatrix(0.0, 0.0, 0.0), 3, 3); //获得左相片的旋转矩阵
            Matrix R2 = new Matrix(CalRotMatrix(this.ro.Phi, this.ro.Omega, this.ro.Kappa), 3, 3);  //获得右相片的旋转矩阵
            double[,] Pg = new double[4, num];
            Matrix R = new Matrix(CalRotMatrix(this.ao.Phi, this.ao.Omega, this.ao.Kappa), 3, 3);
            double lambda = this.ao.Lambda;
            Matrix tP = new Matrix(3, 1);
            temp[0, 0] = ao.DeltaX; temp[1, 0] = ao.DeltaY; temp[2, 0] = ao.DeltaZ;
            Matrix delta = new Matrix(temp, 3, 1);
            this.ao.Zb = Array.CreateInstance(typeof(Double), num, 4);
            for (int i = 1; i <= num; i++)
            {
                Matrix P1 = new Matrix(3, 1);
                temp[0, 0] = (double)this.correctedPhotoPoint.GetValue(i, 1);
                temp[1, 0] = (double)this.correctedPhotoPoint.GetValue(i, 2);
                temp[2, 0] = -f;
                Matrix Pghoto1 = new Matrix(temp, 3, 1);
                Matrix P2 = new Matrix(3, 1);
                temp[0, 0] = (double)this.correctedPhotoPoint.GetValue(i, 3);
                temp[1, 0] = (double)this.correctedPhotoPoint.GetValue(i, 4);
                temp[2, 0] = -f;
                Matrix Pghoto2 = new Matrix(temp, 3, 1);
                P1 = R1 * Pghoto1;
                P2 = R2 * Pghoto2;
                double[] N = CalPrjCoe(ro.Bx, ro.Bz, (double)P1.Data.GetValue(0, 0), (double)P2.Data.GetValue(0, 0), (double)P1.Data.GetValue(2, 0), (double)P2.Data.GetValue(2, 0));
                Pg[0, i - 1] = (double)PhotoPoint.GetValue(i, 0);
                Pg[1, i - 1] = this.scale[0] * N[0] * (double)P1.Data.GetValue(0, 0);
                Pg[2, i - 1] = (N[0] * (double)P1.Data.GetValue(1, 0) + N[1] * (double)P2.Data.GetValue(1, 0) + ro.By) * this.scale[0] / 2;
                Pg[3, i - 1] = this.scale[0] * f + this.scale[0] * N[0] * (double)P1.Data.GetValue(2, 0);
                Matrix P = new Matrix(Pg, 3, 1, 1, i - 1);
                tP = lambda * R * P + delta;
                this.ao.Zb.SetValue((double)this.correctedPhotoPoint.GetValue(i, 0), i - 1, 0);
                this.ao.Zb.SetValue((double)tP.Data.GetValue(0, 0), i - 1, 1);
                this.ao.Zb.SetValue((double)tP.Data.GetValue(1, 0), i - 1, 2);
                this.ao.Zb.SetValue((double)tP.Data.GetValue(2, 0), i - 1, 3);
            }
        }

        /// <summary>
        /// 光束法一步定向
        /// </summary>
        public void BeamOrientation()
        {
            int numIter = 0;
            int num = 0; //匹配点个数
            int numPhoto = this.correctedPhotoPoint.GetUpperBound(0); //像点个数
            double Xsum = 0, Ysum = 0, Zsum = 0, Xavg = 0, Yavg = 0, Zavg = 0;
            double f = (double)this.correctedPhotoPoint.GetValue(0, 0);
            double Xs1 = 0, Ys1 = 0, Zs1 = 0;
            double Xs2 = 0, Ys2 = 0, Zs2 = 0;
            double phi1 = 0, omega1 = 0, kappa1 = 0;
            double phi2 = 0, omega2 = 0, kappa2 = 0;
            int[,] Link = MatchPoint(ref num);
            this.CalScale();
            for (int i = 0; i < num; i++)
            {
                Xsum += (double)this.controlPoint.GetValue(Link[i, 0], 1);
                Ysum += (double)this.controlPoint.GetValue(Link[i, 0], 2);
                Zsum += (double)this.controlPoint.GetValue(Link[i, 0], 3);
            }
            Xavg = Xs1 = Xs2 = Xsum / num;
            Yavg = Ys1 = Ys2 = Ysum / num;
            Zavg = Zsum / num;
            Zs1 = Zsum / num + f * this.scale[0];
            Zs2 = Zsum / num + f * this.scale[1];

            double[,] OrientResult = new double[9, numPhoto]; //OrientResult[4,i]==1.0为控制点
            for (int i = 1; i <= numPhoto; i++)
            {
                bool mark = true;
                OrientResult[0, i - 1] = (double)PhotoPoint.GetValue(i, 0);
                for (int j = 0; j < num; j++)
                    if (Link[j, 1] == i)
                    {
                        OrientResult[1, i - 1] = (double)this.controlPoint.GetValue(Link[j, 0], 1);
                        OrientResult[2, i - 1] = (double)this.controlPoint.GetValue(Link[j, 0], 2);
                        OrientResult[3, i - 1] = (double)this.controlPoint.GetValue(Link[j, 0], 3);
                        OrientResult[4, i - 1] = 1;
                        OrientResult[5, i - 1] = (double)this.correctedPhotoPoint.GetValue(Link[j, 1], 1);
                        OrientResult[6, i - 1] = (double)this.correctedPhotoPoint.GetValue(Link[j, 1], 2);
                        OrientResult[7, i - 1] = (double)this.correctedPhotoPoint.GetValue(Link[j, 1], 3);
                        OrientResult[8, i - 1] = (double)this.correctedPhotoPoint.GetValue(Link[j, 1], 4);
                        mark = false;
                    }
                if (mark)
                {
                    OrientResult[1, i - 1] = Xavg;
                    OrientResult[2, i - 1] = Yavg;
                    OrientResult[3, i - 1] = Zavg;
                    OrientResult[5, i - 1] = (double)this.correctedPhotoPoint.GetValue(i, 1);
                    OrientResult[6, i - 1] = (double)this.correctedPhotoPoint.GetValue(i, 2);
                    OrientResult[7, i - 1] = (double)this.correctedPhotoPoint.GetValue(i, 3);
                    OrientResult[8, i - 1] = (double)this.correctedPhotoPoint.GetValue(i, 4);
                }
            }
            Matrix A = new Matrix(4 * numPhoto, 12);
            Matrix B = new Matrix(4 * numPhoto, 3 * (numPhoto - num));
            Matrix L = new Matrix(4 * numPhoto, 1);
            Matrix X = new Matrix(12, 1);
            Matrix t = new Matrix(3 * (numPhoto - num), 1);
            Matrix V = new Matrix(12 + 3 * (numPhoto - num), 1);
            while (true)
            {
                double[,] R1 = CalRotMatrix(phi1, omega1, kappa1);
                double[,] R2 = CalRotMatrix(phi2, omega2, kappa2);
                int c = 0;
                for (int i = 0; i < numPhoto; i++) 
                {

                    double Xt = 0, Yt = 0, Zt = 0;
                    Xt = OrientResult[1, i]; Yt = OrientResult[2, i]; Zt = OrientResult[3, i];
                    double[] XYZ1 = CalXYZ(R1, Xs1, Ys1, Zs1, Xt, Yt, Zt);
                    double[] XYZ2 = CalXYZ(R2, Xs2, Ys2, Zs2, Xt, Yt, Zt);
                    double x1 = OrientResult[5, i];
                    double y1 = OrientResult[6, i];
                    double x2 = OrientResult[7, i];
                    double y2 = OrientResult[8, i];
                    double[,] Atemp1 = CalCoeA(XYZ1, R1, f, x1, y1, phi1, omega1, kappa1);
                    double[,] Atemp2 = CalCoeA(XYZ2, R2, f, x2, y2, phi2, omega2, kappa2);
                    double[,] Btemp1 = CalCoeB(XYZ1, R1, f, x1, y1, phi1, omega1, kappa1);
                    double[,] Btemp2 = CalCoeB(XYZ2, R2, f, x2, y2, phi2, omega2, kappa2);
                    double[] Ltemp1 = CalErrMatrix(R1, f, XYZ1, x1, y1);
                    double[] Ltemp2 = CalErrMatrix(R2, f, XYZ2, x2, y2);
                    for (int j = 0; j < 2; j++)
                    {
                        for (int k = 0; k < 6; k++)
                        {
                            int rol = 0, col = 0;
                            rol = j + i * 4;
                            col = k;
                            A.Data.SetValue(Atemp1[j, k], rol, col);
                            rol = j + i * 4 + 2;
                            col = k + 6;
                            A.Data.SetValue(Atemp2[j, k], rol, col);
                            if (k < 3)
                            {
                                if (OrientResult[4, i] == 0)
                                {
                                    rol = j + i * 4;
                                    col = 3 * c + k;
                                    B.Data.SetValue(Btemp1[j, k], rol, col);
                                    rol = j + i * 4 + 2;
                                    col = 3 * c + k;
                                    B.Data.SetValue(Btemp2[j, k], rol, col);
                                }
                            }
                            if (k < 1)
                            {
                                rol = j + i * 4;
                                col = 0;
                                L.Data.SetValue(Ltemp1[j], rol, col);
                                rol = j + i * 4 + 2;
                                col = 0;
                                L.Data.SetValue(Ltemp2[j], rol, col);
                            }
                        }
                    }
                    if (OrientResult[4, i] == 0) c++;
                }
                Matrix N11 = ~A * A;
                Matrix N12 = ~A * B;
                Matrix N22 = ~B * B;
                Matrix l1 = ~A * L;
                Matrix l2 = ~B * L;
                X = !(N11 - N12 * !N22 * ~N12) * (l1 - N12 * !N22 * l2);
                t = !(N22 - ~N12 * !N11 * N12) * (l2 - ~N12 * !N11 * l1);
                Xs1 += (double)X.Data.GetValue(0, 0);
                Ys1 += (double)X.Data.GetValue(1, 0);
                Zs1 += (double)X.Data.GetValue(2, 0);
                phi1 += (double)X.Data.GetValue(3, 0);
                omega1 += (double)X.Data.GetValue(4, 0);
                kappa1 += (double)X.Data.GetValue(5, 0);
                Xs2 += (double)X.Data.GetValue(6, 0);
                Ys2 += (double)X.Data.GetValue(7, 0);
                Zs2 += (double)X.Data.GetValue(8, 0);
                phi2 += (double)X.Data.GetValue(9, 0);
                omega2 += (double)X.Data.GetValue(10, 0);
                kappa2 += (double)X.Data.GetValue(11, 0);
                c = 0;
                for (int i = 0; i < numPhoto; i++)
                {
                    if (OrientResult[4, i] == 0)
                    {
                        int rol = c * 3;
                        OrientResult[1, i] += (double)t.Data.GetValue(rol, 0);
                        OrientResult[2, i] += (double)t.Data.GetValue(rol + 1, 0);
                        OrientResult[3, i] += (double)t.Data.GetValue(rol + 2, 0);
                        c++;
                    }
                }
                numIter++;
                bool tolerance = (Math.Abs((double)X.Data.GetValue(3, 0)) < 1.0 * Math.PI / 180 / 60) && (Math.Abs((double)X.Data.GetValue(4, 0)) < 1.0 * Math.PI / 180 / 60) &&
                               (Math.Abs((double)X.Data.GetValue(5, 0)) < 1.0 * Math.PI / 180 / 60) && (Math.Abs((double)X.Data.GetValue(9, 0)) < 1.0 * Math.PI / 180 / 60) &&
                               (Math.Abs((double)X.Data.GetValue(10, 0)) < 1.0 * Math.PI / 180 / 60) && (Math.Abs((double)X.Data.GetValue(11, 0)) < 1.0 * Math.PI / 180 / 60);
                if (tolerance) break;
            }
            V = A * X + B * t - L;
            Matrix tmp = !(~A * A);

            this.bo.MidErr = Math.Sqrt((double)(~V * V).Data.GetValue(0, 0)) / (4 * numPhoto - 12 - 3 * (numPhoto - num));

            this.bo.IterCount = numIter;
            this.bo.DiffX1 = this.bo.MidErr * Math.Sqrt((double)tmp.Data.GetValue(0, 0));
            this.bo.DiffY1 = this.bo.MidErr * Math.Sqrt((double)tmp.Data.GetValue(1, 1));
            this.bo.DiffZ1 = this.bo.MidErr * Math.Sqrt((double)tmp.Data.GetValue(2, 2));
            this.bo.DiffPhi1 = this.bo.MidErr * Math.Sqrt((double)tmp.Data.GetValue(3, 3));
            this.bo.DiffOmega1 = this.bo.MidErr * Math.Sqrt((double)tmp.Data.GetValue(4, 4));
            this.bo.DiffKappa1 = this.bo.MidErr * Math.Sqrt((double)tmp.Data.GetValue(5, 5));
            this.bo.DiffX2 = this.bo.MidErr * Math.Sqrt((double)tmp.Data.GetValue(6, 6));
            this.bo.DiffY2 = this.bo.MidErr * Math.Sqrt((double)tmp.Data.GetValue(7, 7));
            this.bo.DiffZ2 = this.bo.MidErr * Math.Sqrt((double)tmp.Data.GetValue(8, 8));
            this.bo.DiffPhi2 = this.bo.MidErr * Math.Sqrt((double)tmp.Data.GetValue(9, 9));
            this.bo.DiffOmega2 = this.bo.MidErr * Math.Sqrt((double)tmp.Data.GetValue(10, 10));
            this.bo.DiffKappa2 = this.bo.MidErr * Math.Sqrt((double)tmp.Data.GetValue(11, 11));

            this.bo.Xs1 = Xs1; this.bo.Ys1 = Ys1; this.bo.Zs1 = Zs1;
            this.bo.Xs2 = Xs2; this.bo.Ys2 = Ys2; this.bo.Zs2 = Zs2;
            this.bo.Kappa1 = kappa1; this.bo.Phi1 = phi1; this.bo.Omega1 = omega1;
            this.bo.Kappa2 = kappa2; this.bo.Phi2 = phi2; this.bo.Omega2 = omega2;
            this.bo.Zb = Array.CreateInstance(typeof(Double), numPhoto, 4);
            for (int i = 0; i < numPhoto; i++)
            {
                this.bo.Zb.SetValue(OrientResult[0, i], i, 0);
                this.bo.Zb.SetValue(OrientResult[1, i], i, 1);
                this.bo.Zb.SetValue(OrientResult[2, i], i, 2);
                this.bo.Zb.SetValue(OrientResult[3, i], i, 3);
            }
        }

        /// <summary>
        /// 计算相片比例尺
        /// </summary>
        public void CalScale()
        {
            int num = 0;
            int[,] Link = this.MatchPoint(ref num);
            this.scale[0] = 0;
            this.scale[1] = 0;
            for (int i = 0; i < num; i++)
            {
                for (int j = i + 1; j < num; j++)
                {
                    this.scale[0] += Math.Sqrt(Math.Pow((double)this.controlPoint.GetValue(Link[i, 0], 1) - (double)this.controlPoint.GetValue(Link[j, 0], 1), 2) + Math.Pow((double)this.controlPoint.GetValue(Link[i, 0], 2) - (double)this.controlPoint.GetValue(Link[j, 0], 2), 2)) / Math.Sqrt(Math.Pow((double)this.correctedPhotoPoint.GetValue(Link[i, 1], 1) - (double)this.correctedPhotoPoint.GetValue(Link[j, 1], 1), 2) + Math.Pow((double)this.correctedPhotoPoint.GetValue(Link[i, 1], 2) - (double)this.correctedPhotoPoint.GetValue(Link[j, 1], 2), 2));
                    this.scale[1] += Math.Sqrt(Math.Pow((double)this.controlPoint.GetValue(Link[i, 0], 1) - (double)this.controlPoint.GetValue(Link[j, 0], 1), 2) + Math.Pow((double)this.controlPoint.GetValue(Link[i, 0], 2) - (double)this.controlPoint.GetValue(Link[j, 0], 2), 2)) / Math.Sqrt(Math.Pow((double)this.correctedPhotoPoint.GetValue(Link[i, 1], 3) - (double)this.correctedPhotoPoint.GetValue(Link[j, 1], 3), 2) + Math.Pow((double)this.correctedPhotoPoint.GetValue(Link[i, 1], 4) - (double)this.correctedPhotoPoint.GetValue(Link[j, 1], 4), 2));
                }
            }
            this.scale[0] = this.scale[0] / num / (num - 1) * 2;
            this.scale[1] = this.scale[1] / num / (num - 1) * 2;
        }

        /// <summary>
        /// 进行控制点与像点的匹配
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int[,] MatchPoint(ref int num)
        {
            num = 0;
            int numControlPoint = this.controlPoint.GetUpperBound(0);
            int numPhoto = this.correctedPhotoPoint.GetUpperBound(0);
            int[,] Link = new int[numControlPoint + 1, 2];
            for (int i = 0; i <= numControlPoint; i++)
            {
                for (int j = 1; j <= numPhoto; j++)
                    if ((double)this.controlPoint.GetValue(i, 0) == (double)this.correctedPhotoPoint.GetValue(j, 0))
                    {
                        Link[num, 0] = i; Link[num, 1] = j;
                        num++;
                    }
            }
            return Link;
        }

        /// <summary>
        /// 计算左右相片的投影系数
        /// </summary>
        /// <param name="Bx"></param>
        /// <param name="Bz"></param>
        /// <param name="X1"></param>
        /// <param name="X2"></param>
        /// <param name="Z1"></param>
        /// <param name="Z2"></param>
        /// <returns></returns>
        public double[] CalPrjCoe(double Bx, double Bz, double X1, double X2, double Z1, double Z2)
        {
            double[] N = new double[2];
            N[0] = (Bx * Z2 - Bz * X2) / (X1 * Z2 - X2 * Z1);
            N[1] = (Bx * Z1 - Bz * X1) / (X1 * Z2 - X2 * Z1);
            return N;
        }

        /// <summary>
        /// 计算误差矩阵
        /// </summary>
        /// <param name="R"></param>
        /// <param name="f"></param>
        /// <param name="XYZ"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double[] CalErrMatrix(double[,] R, double f, double[] XYZ, double x, double y)
        {
            double[] L = new double[2];
            L[0] = x + f * XYZ[0] / XYZ[2];
            L[1] = y + f * XYZ[1] / XYZ[2];
            return L;
        }

        /// <summary>
        /// 计算旋转矩阵
        /// </summary>
        /// <param name="phi"></param>
        /// <param name="omega"></param>
        /// <param name="kappa"></param>
        /// <returns></returns>
        public double[,] CalRotMatrix(double phi, double omega, double kappa)
        {
            double[,] R = new double[3, 3];
            R[0, 0] = Math.Cos(phi) * Math.Cos(kappa) - Math.Sin(phi) * Math.Sin(omega) * Math.Sin(kappa);
            R[0, 1] = -Math.Cos(phi) * Math.Sin(kappa) - Math.Sin(phi) * Math.Sin(omega) * Math.Cos(kappa);
            R[0, 2] = -Math.Sin(phi) * Math.Cos(omega);
            R[1, 0] = Math.Cos(omega) * Math.Sin(kappa);
            R[1, 1] = Math.Cos(omega) * Math.Cos(kappa);
            R[1, 2] = -Math.Sin(omega);
            R[2, 0] = Math.Sin(phi) * Math.Cos(kappa) + Math.Cos(phi) * Math.Sin(omega) * Math.Sin(kappa);
            R[2, 1] = -Math.Sin(phi) * Math.Sin(kappa) + Math.Cos(phi) * Math.Sin(omega) * Math.Cos(kappa);
            R[2, 2] = Math.Cos(phi) * Math.Cos(omega);
            return R;
        }

        /// <summary>
        /// 计算原始XYZ
        /// </summary>
        /// <param name="R"></param>
        /// <param name="Xs"></param>
        /// <param name="Ys"></param>
        /// <param name="Zs"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Z"></param>
        /// <returns></returns>
        public double[] CalXYZ(double[,] R, double Xs, double Ys, double Zs, double X, double Y, double Z)
        {
            double[] XYZ = new double[3];
            XYZ[0] = R[0, 0] * (X - Xs) + R[1, 0] * (Y - Ys) + R[2, 0] * (Z - Zs);
            XYZ[1] = R[0, 1] * (X - Xs) + R[1, 1] * (Y - Ys) + R[2, 1] * (Z - Zs);
            XYZ[2] = R[0, 2] * (X - Xs) + R[1, 2] * (Y - Ys) + R[2, 2] * (Z - Zs);
            return XYZ;
        }

        /// <summary>
        /// 计算系数A矩阵
        /// </summary>
        /// <param name="XYZ"></param>
        /// <param name="R"></param>
        /// <param name="f"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="phi"></param>
        /// <param name="omega"></param>
        /// <param name="kappa"></param>
        /// <returns></returns>
        public double[,] CalCoeA(double[] XYZ, double[,] R, double f, double x, double y, double phi, double omega, double kappa)
        {
            double[,] A = new double[2, 6];
            A[0, 0] = (R[0, 0] * f + R[0, 2] * x) / XYZ[2];
            A[0, 1] = (R[1, 0] * f + R[1, 2] * x) / XYZ[2];
            A[0, 2] = (R[2, 0] * f + R[2, 2] * x) / XYZ[2];
            A[0, 3] = y * Math.Sin(omega) - (x / f * (x * Math.Cos(kappa) - y * Math.Sin(kappa)) + f * Math.Cos(kappa)) * Math.Cos(omega);
            A[0, 4] = -f * Math.Sin(kappa) - x / f * (x * Math.Sin(kappa) + y * Math.Cos(kappa));
            A[0, 5] = y;
            A[1, 0] = (R[0, 1] * f + R[0, 2] * y) / XYZ[2];
            A[1, 1] = (R[1, 1] * f + R[1, 2] * y) / XYZ[2];
            A[1, 2] = (R[2, 1] * f + R[2, 2] * y) / XYZ[2];
            A[1, 3] = -x * Math.Sin(omega) - (y / f * (x * Math.Cos(kappa) - y * Math.Sin(kappa)) - f * Math.Sin(kappa)) * Math.Cos(omega);
            A[1, 4] = -f * Math.Cos(kappa) - y / f * (x * Math.Sin(kappa) + y * Math.Cos(kappa));
            A[1, 5] = -x;
            return A;
        }

        /// <summary>
        /// 计算系数B矩阵
        /// </summary>
        /// <param name="XYZ"></param>
        /// <param name="R"></param>
        /// <param name="f"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="phi"></param>
        /// <param name="omega"></param>
        /// <param name="kappa"></param>
        /// <returns></returns>
        public double[,] CalCoeB(double[] XYZ, double[,] R, double f, double x, double y, double phi, double omega, double kappa)
        {
            double[,] A = new double[2, 3];
            A[0, 0] = -(R[0, 0] * f + R[0, 2] * x) / XYZ[2];
            A[0, 1] = -(R[1, 0] * f + R[1, 2] * x) / XYZ[2];
            A[0, 2] = -(R[2, 0] * f + R[2, 2] * x) / XYZ[2];
            A[1, 0] = -(R[0, 1] * f + R[0, 2] * y) / XYZ[2];
            A[1, 1] = -(R[1, 1] * f + R[1, 2] * y) / XYZ[2];
            A[1, 2] = -(R[2, 1] * f + R[2, 2] * y) / XYZ[2];
            return A;
        }

        /// <summary>
        /// 前方交会结果写入文件
        /// </summary>
        /// <param name="filename"></param>
        public void WriteForwardRendezvousResult(string filename)
        {
            StreamWriter writer = new StreamWriter(filename, false, System.Text.Encoding.Default);
            writer.WriteLine("后方交会、前方交会法算得地面点坐标为:");
            writer.WriteLine();
            writer.WriteLine("点号,X,Y,Z");
            string str = "";
            int num = this.fr.GetLength(0);
            for (int i = 0; i < num - 1; i++) 
            {
                str = this.fr.GetValue(i, 0).ToString() + "," + this.fr.GetValue(i, 1).ToString() + "," + this.fr.GetValue(i, 2).ToString() + "," + this.fr.GetValue(i, 3).ToString();
                writer.WriteLine(str);
            }
            writer.Close();
        }
    }
}
