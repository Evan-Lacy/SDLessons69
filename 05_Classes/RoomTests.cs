using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void RoomFootage()
        {
            Room room = new Room();
            room.Length = 25.54f;
            room.Length = 64;

            Console.WriteLine(room.Length);
        }
    }
}
