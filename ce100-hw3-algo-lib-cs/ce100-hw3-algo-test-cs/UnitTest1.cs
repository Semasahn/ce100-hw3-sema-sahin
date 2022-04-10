using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw3_algo_lib_cs;

namespace ce100_hw3_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void rmc_unit_test_1()
        {
            //Matrix `M[i]` has dimension `dims[i - 1] × dims[i]` for `i = 1…n`
            //input is 10 × 30 matrix, 30 × 5 matrix, 5 × 60 matrix

            int[] dims = { 10, 30, 5, 60 };
            int n = dims.Length;
            int exp = 4500;
            int res = Class1.rmc(dims, 0, n - 1);

            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void rmc_unit_test_2()
        {
            //Matrix `M[i]` has dimension `dims[i - 1] × dims[i]` for `i = 1…n`
            //input is 10 × 30 matrix, 30 × 5 matrix, 5 × 60 matrix

            int[] dims = { 5, 20, 10, 40 };
            int n = dims.Length;
            int exp = 3000;
            int res = Class1.rmc(dims, 0, n - 1);

            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void rmc_unit_test_3()
        {
            //Matrix `M[i]` has dimension `dims[i - 1] × dims[i]` for `i = 1…n`
            //input is 10 × 30 matrix, 30 × 5 matrix, 5 × 60 matrix

            int[] dims = { 5, 15, 35, 25 };
            int n = dims.Length;
            int exp = 7000;
            int res = Class1.rmc(dims, 0, n - 1);

            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void lcs_unit_test_1()
        {
            string X = "AGGTAB";
            string Y = "GXTXAYB";
            int m = X.Length;
            int n = Y.Length;

            string exp = "GTAB";
            string res = Class1.lcs(X, Y, m, n);
            Assert.AreEqual(res, exp);
        }

        [TestMethod]
        public void lcs_unit_test_2()
        {
            string X = "DBCCADBA";
            string Y = "UEWRKPLKABD";
            int m = X.Length;
            int n = Y.Length;

            string exp = "AB";
            string res = Class1.lcs(X, Y, m, n);
            Assert.AreEqual(res, exp);
        }

        [TestMethod]
        public void lcs_unit_test_3()
        {
            string X = "DCDBDDB";
            string Y = "CACDBAC";
            int m = X.Length;
            int n = Y.Length;

            string exp = "CDB";
            string res = Class1.lcs(X, Y, m, n);
            Assert.AreEqual(res, exp);
        }

    }
}
