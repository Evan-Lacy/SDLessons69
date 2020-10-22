using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using _08_Interfaces.Fruits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Interfaces
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FruitTest()
        {
            Orange foo = new Orange(true);
            Orange unpeeledOrange = new Orange(false);

            Console.WriteLine(foo.IsPeeled);
            Console.WriteLine(unpeeledOrange.IsPeeled);

            Console.WriteLine(foo.Peel());
            Console.WriteLine(unpeeledOrange.Peel());

            Banana banana = new Banana();

            List<IFruit> fruitBasket = new List<IFruit>();

            fruitBasket.Add(banana);
            fruitBasket.Add(foo);
            fruitBasket.ToArray();
            
        }
    }
}
