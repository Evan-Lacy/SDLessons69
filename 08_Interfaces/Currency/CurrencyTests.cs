using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Interfaces.Currency
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void DollarTests()
        {
            ICurrency dollar = new Dollar();

            Assert.AreEqual(1m, dollar.Value);
            Assert.AreEqual("Dollar", dollar.Name);
        }

        [DataTestMethod] //to actually test it with a value
        [DataRow(26.2)]//actual value being passed in
        public void EPaymentTest(double value)
        {
            decimal convertedValue = Convert.ToDecimal(value);

            ElectronicPayment ePayment = new ElectronicPayment(convertedValue);

            Assert.AreEqual(convertedValue, ePayment.Value);
            Assert.AreEqual("Electronic Payment", ePayment.Name);
        }
    }
}
