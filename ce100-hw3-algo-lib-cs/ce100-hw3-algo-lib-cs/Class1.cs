using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce100_hw3_algo_lib_cs
{
    public class Class1
    {

        public static int rmc(int[] dims, int i, int j)
        {
            // base case: one matrix
            if (j <= i + 1)
            {
                return 0;
            }

            // stores the minimum number of scalar multiplications (i.e., cost)
            // needed to compute matrix `M[i+1] … M[j] = M[i…j]`

            int min = int.MaxValue;

            // take the minimum over each possible position at which the
            // sequence of matrices can be split

            /*
                (M[i+1]) × (M[i+2]………………M[j])
                (M[i+1]M[i+2]) × (M[i+3…………M[j])
                …
                …
                (M[i+1]M[i+2]…………M[j-1]) × (M[j])
            */

            for (int k = i + 1; k <= j - 1; k++)
            {
                // recur for `M[i+1]…M[k]` to get an `i × k` matrix
                int cost = rmc(dims, i, k) + rmc(dims, k, j) + dims[i] * dims[k] * dims[j];

                // recur for `M[k+1]…M[j]` to get an `k × j` matrix
                //cost += rmc(dims, k + 1, j);

                // cost to multiply two `i × k` and `k × j` matrix
                //cost += dims[i - 1] * dims[k] * dims[j];

                if (cost < min)
                {
                    min = cost;
                }
            }

            // return the minimum cost to multiply `M[j+1]…M[j]`
            return min;
        }




        // Returns length of LCS for X[0..m-1], Y[0..n-1]
        public static string lcs(string X, string Y, int m, int n)
        {
            int[,] L = new int[m + 1, n + 1];

            // Following steps build L[m+1][n+1] in
            // bottom up fashion. Note that L[i][j]
            // contains length of LCS of X[0..i-1]
            // and Y[0..j-1]
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (X[i - 1] == Y[j - 1])
                        L[i, j] = L[i - 1, j - 1] + 1;
                    else
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                }
            }

            // Following code is used to print LCS
            int index = L[m, n];

            // Create a character array
            // to store the lcs string
            string lcs = string.Empty;

            // Start from the right-most-bottom-most corner
            // and one by one store characters in lcs[]
            int k = m, l = n;
            while (k > 0 && l > 0)
            {
                // If current character in X[] and Y
                // are same, then current character
                // is part of LCS
                if (X[k - 1] == Y[l - 1])
                {
                    // Put current character in result
                    lcs = X[k - 1] + lcs;

                    // reduce values of i, j and index
                    k--;
                    l--;
                    index--;
                }

                // If not same, then find the larger of two and
                // go in the direction of larger value
                else if (L[k - 1, l] > L[k, l - 1])
                    k--;
                else
                    l--;
            }

            return lcs;
        }

    }
}