using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShunanovKE.Sprint4.TaskReview.V13.Lib
{
    public class DataService : ISprint4Task7V13
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[3, 3];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * 3 + j, 1));
                }
            }
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(mtrx[i,j] % 2 == 0)
                    {
                        res++;
                    }
                }
            }
            return res;
        }
    }
}
