using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorv1.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        [TestMethod()]
        public void getresultTest()
        { var target = new MainWindow();
            string w = "-";
            double w1 = 2;
            double w2 = 3;
            double expected = -1;

            double actual = target.getrestult(w, w1, w2);

            Assert.AreEqual(expected, actual);


        }
    }
}