using System;
using System.Collections.Generic;
using System.Text;

namespace Photogrammetry
{
    class Matrix
    {
        private Array data; //存储矩阵数据
        private int row, col; //矩阵行列数

        /// <summary>
        /// 存取器
        /// </summary>
        public Array Data 
        {
            get { return data; }
        }
        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        public int Col
        {
            get { return col; }
            set { col = value; }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
            data = Array.CreateInstance(typeof(Double), row, col);
        }

        /// <summary>
        /// 构造函数：使用二维数组构造矩阵
        /// </summary>
        /// <param name="data"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public Matrix(double[,] data, int row, int col)
        {
            this.row = row;
            this.col = col;
            this.data = Array.CreateInstance(typeof(Double), row, col);
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    this.data.SetValue(data[i, j], i, j);

        }

        /// <summary>
        /// 构造函数：从二维数组中的指定位置起生成指定大小的Matrix对象，从data[r,c]开始
        /// </summary>
        /// <param name="data"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="r"></param>
        /// <param name="c"></param>
        public Matrix(double[,] data, int row, int col, int r, int c)
        {
            this.row = row;
            this.col = col;
            this.data = Array.CreateInstance(typeof(Double), row, col);
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    this.data.SetValue(data[r + i, c + j], i, j);
        }

        /// <summary>
        /// 构造函数：使用Array对象
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public Matrix(Array arr, int row, int col)
        {
            this.row = row;
            this.col = col;
            this.data = Array.CreateInstance(typeof(Double), row, col);
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    data.SetValue(arr.GetValue(i, j), i, j);
        }

        /// <summary>
        /// 构造函数：使用Matrix
        /// </summary>
        /// <param name="mat"></param>
        public Matrix(Matrix mat)
        {
            this.row = mat.Row;
            this.col = mat.Col;
            this.data = Array.CreateInstance(typeof(Double), this.row, this.col);
            for (int i = 0; i < this.row; i++)
                for (int j = 0; j < this.col; j++)
                    data.SetValue(mat.Data.GetValue(i, j), i, j);
        }

        /// <summary>
        /// 矩阵转置
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static Matrix operator ~(Matrix mat)
        {
            Matrix T = new Matrix(mat.Col, mat.Row);
            for (int i = 0; i < T.row; i++)
                for (int j = 0; j < T.col; j++)
                {
                    T.data.SetValue(mat.Data.GetValue(j, i), i, j);
                }
            return T;
        }

        /// <summary>
        /// 矩阵求逆
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static Matrix operator !(Matrix mat)
        {
            int i, j, k, row = mat.Row, col = mat.Col;
            Matrix Inv = new Matrix(mat);
            double max, tmp;
            int[] maxRowIndex = new int[row]; //最大值行号
            int[] maxColIndex = new int[col]; //最大值列号
            for (k = 0; k < row; k++)
            {
                max = 0.0;
                for (i = k; i < row; i++)
                    for (j = k; j < col; j++)
                    {
                        tmp = Math.Abs((double)Inv.Data.GetValue(i, j));
                        if (tmp > max)
                        {
                            max = tmp;
                            maxRowIndex[k] = i;
                            maxColIndex[k] = j;
                        }
                    }
                if (max + 1.0 == 1.0)
                {
                    return mat;
                }
                if (maxRowIndex[k] != k)
                    for (j = 0; j < col; j++)
                    {
                        tmp = (double)Inv.Data.GetValue(k, j);
                        Inv.Data.SetValue((double)Inv.Data.GetValue(maxRowIndex[k], j), k, j);
                        Inv.Data.SetValue(tmp, maxRowIndex[k], j);
                    }
                if (maxColIndex[k] != k)
                    for (i = 0; i < row; i++)
                    {
                        tmp = (double)Inv.Data.GetValue(i, k);
                        Inv.Data.SetValue((double)Inv.Data.GetValue(i, maxColIndex[k]), i, k);
                        Inv.Data.SetValue(tmp, i, maxColIndex[k]);
                    }
                Inv.Data.SetValue(1.0 / (double)Inv.Data.GetValue(k, k), k, k);
                for (j = 0; j < col; j++)
                    if (j != k)
                    {
                        Inv.Data.SetValue((double)Inv.Data.GetValue(k, j) * (double)Inv.Data.GetValue(k, k), k, j);
                    }
                for (i = 0; i < row; i++)
                    if (i != k)
                        for (j = 0; j < col; j++)
                            if (j != k)
                            {
                                Inv.Data.SetValue((double)Inv.Data.GetValue(i, j) - (double)Inv.Data.GetValue(i, k) * (double)Inv.Data.GetValue(k, j), i, j);
                            }
                for (i = 0; i < row; i++)
                    if (i != k)
                    {

                        Inv.Data.SetValue(-(double)Inv.Data.GetValue(i, k) * (double)Inv.Data.GetValue(k, k), i, k);
                    }
            }
            for (k = col - 1; k >= 0; k--)
            {
                if (maxColIndex[k] != k)
                    for (j = 0; j < col; j++)
                    {
                        tmp = (double)Inv.Data.GetValue(k, j);
                        Inv.Data.SetValue((double)Inv.Data.GetValue(maxColIndex[k], j), k, j);
                        Inv.Data.SetValue(tmp, maxColIndex[k], j);
                    }
                if (maxRowIndex[k] != k)
                    for (i = 0; i < col; i++)
                    {
                        tmp = (double)Inv.Data.GetValue(i, k);
                        Inv.Data.SetValue((double)Inv.Data.GetValue(i, maxRowIndex[k]), i, k);
                        Inv.Data.SetValue(tmp, i, maxRowIndex[k]);
                    }
            }
            return Inv;
        }

        /// <summary>
        /// 矩阵乘
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Matrix operator *(Matrix A, Matrix B)
        {
            Matrix C = new Matrix(A.Row, B.Col);
            for (int i = 0; i < A.Row; i++)
                for (int j = 0; j < B.Col; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < A.Col; k++)
                    {
                        temp = temp + (double)A.Data.GetValue(i, k) * (double)B.Data.GetValue(k, j);
                    }
                    C.Data.SetValue(temp, i, j);
                }
            return C;
        }

        /// <summary>
        /// 矩阵数乘
        /// </summary>
        /// <param name="A"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static Matrix operator *(Matrix A, double num)
        {
            Matrix C = new Matrix(A.Row, A.Col);
            for (int i = 0; i < A.Row; i++)
                for (int j = 0; j < A.Col; j++)
                    C.Data.SetValue((double)A.Data.GetValue(i, j) * num, i, j);
            return C;
        }

        /// <summary>
        /// 矩阵数乘
        /// </summary>
        /// <param name="num"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public static Matrix operator *(double num, Matrix A)
        {
            Matrix C = new Matrix(A.Row, A.Col);
            for (int i = 0; i < A.Row; i++)
                for (int j = 0; j < A.Col; j++)
                    C.Data.SetValue((double)A.Data.GetValue(i, j) * num, i, j);
            return C;
        }

        /// <summary>
        /// 矩阵加
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Matrix operator +(Matrix A, Matrix B)
        {
            int row = A.Row, col = A.Col;
            Matrix C = new Matrix(row, col);
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    C.Data.SetValue((double)A.Data.GetValue(i, j) + (double)B.Data.GetValue(i, j), i, j);
            return C;
        }

        /// <summary>
        /// 矩阵减
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static Matrix operator -(Matrix A, Matrix B)
        {
            int row = A.Row, col = A.Col;
            Matrix C = new Matrix(row, col);
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    C.Data.SetValue((double)A.Data.GetValue(i, j) - (double)B.Data.GetValue(i, j), i, j);
            return C;
        }
    }
}
