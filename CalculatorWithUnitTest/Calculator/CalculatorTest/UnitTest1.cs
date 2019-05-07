using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            Calculator.Form1 form1 = new Calculator.Form1();
            Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject testobj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(form1);
            TextBox result = testobj.GetFieldOrProperty("textBox_Result") as TextBox;
            result.Text = "200";
            object[] args = new object[2] { new Button(), new EventArgs() };
            testobj.Invoke("operator_Click", args);
            result.Text = "300";
            testobj.Invoke("button23_Click", args);
            Assert.AreEqual("500", result.Text.ToString());
        }
        [TestMethod]
        public void TestMethodSubtract()
        {
            Calculator.Form1 form1 = new Calculator.Form1();
            Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject testobj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(form1);
            TextBox result = testobj.GetFieldOrProperty("textBox_Result") as TextBox;
            result.Text = "200";
            object[] args = new object[2] { new Button(), new EventArgs() };
            testobj.Invoke("button17_Click", args);
            result.Text = "300";
            testobj.Invoke("button23_Click", args);
            Assert.AreEqual("-100", result.Text.ToString());
        }
        [TestMethod]
        public void TestMethodMultiply()
        {
            Calculator.Form1 form1 = new Calculator.Form1();
            Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject testobj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(form1);
            TextBox result = testobj.GetFieldOrProperty("textBox_Result") as TextBox;
            result.Text = "200";
            object[] args = new object[2] { new Button(), new EventArgs() };
            testobj.Invoke("button7_Click", args);
            result.Text = "300";
            testobj.Invoke("button23_Click", args);
            Assert.AreEqual("60000", result.Text.ToString());
        }
        [TestMethod]
        public void TestMethodDivide()
        {
            Calculator.Form1 form1 = new Calculator.Form1();
            Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject testobj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(form1);
            TextBox result = testobj.GetFieldOrProperty("textBox_Result") as TextBox;
            result.Text = "200";
            object[] args = new object[2] { new Button(), new EventArgs() };
            testobj.Invoke("button2_Click", args);
            result.Text = "300";
            testobj.Invoke("button23_Click", args);
            Assert.AreEqual("0.666666666666667", result.Text.ToString());
        }
    }
}
