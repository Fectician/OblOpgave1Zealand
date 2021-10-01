using Microsoft.VisualStudio.TestTools.UnitTesting;
using OBL_Opgave_1_Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBL_Opgave_1_Class_Library.Tests
{
    //Kode af Nicolas Lauridsen, Datamatiker 3b Zealand Erhvervsakademi.
    [TestClass()]
    public class FootballPlayerTests
    {
        public FootballPlayer player1;
        public FootballPlayer player2;
        [TestInitialize]
        public void startup()
        {
            player1 = new FootballPlayer();
            player2 = new FootballPlayer(2, 68.70, "Josef", 50);
        }

        

        [TestMethod()]
        public void FootballPlayerTest()
        {
            Assert.AreEqual(2, player2.Id);
            Assert.AreEqual(68.7, player2.Price);
            Assert.AreEqual("Josef", player2.Name);
            Assert.AreEqual(50, player2.ShirtNumber);

        }

        [TestMethod()]
        public void FootballPlayerTest2()
        {
            player1.Id = 1;
            Assert.AreEqual(1, player1.Id);
            Assert.AreNotEqual(player1.Id, player2.Id);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player1.Price = -16);
            Assert.ThrowsException<ArgumentException>(() => player1.Name = "Bob");

            
        }

        [TestMethod()]
        public void FootballPlayerTest3()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player2.ShirtNumber = -1);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player2.ShirtNumber = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => player2.ShirtNumber = 600);
        }
    }
}