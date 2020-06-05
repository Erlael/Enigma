using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Enigma;
using Microsoft.Win32;

namespace EnigmaTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [DataRow(0, 0, 5, 11, "Э")]
        [DataRow(0, 4, 0, 9, "К")]
        [DataRow(7, 0, 0, 13, "Ч")]
        public void DecodingTest(int r1, int r2, int r3, int a, string expected)
        {
            // Arrange
            int r11 = Enigma.Program.GetRot(1, r1);
            int r22 = Enigma.Program.GetRot(2, r2);
            int r33 = Enigma.Program.GetRot(3, r3);
            int shift = r11 + r22 + r33;

            // Act
            string actual = Enigma.Program.Decoding(a, shift);

            // Assert
            Assert.AreEqual(expected, actual, actual, "Decoding done incorrectly");
        }
        [TestMethod]
        [DataRow(0, 0, 5, 11, "Ш")]
        [DataRow(0, 4, 0, 9, "Ж")]
        [DataRow(7, 0, 0, 13, "В")]
        public void CodingTest(int r1, int r2, int r3, int a, string expected)
        {
            // Arrange
            int r11 = Enigma.Program.GetRot(1, r1);
            int r22 = Enigma.Program.GetRot(2, r2);
            int r33 = Enigma.Program.GetRot(3, r3);
            int shift = r11 + r22 + r33;

            // Act
            string actual = Enigma.Program.Coding(a, shift);

            // Assert
            Assert.AreEqual(expected, actual, actual, "Сoding done incorrectly");

        }

        [TestMethod]
        [DataRow(9, 0)]
        [DataRow(2, 3)]
        [DataRow(0, 1)]
        public void Roters3Test(int r3, int expected)
        {
            r3 = Enigma.Program.Roters3(r3);

            Assert.AreEqual(expected, r3, "Roter turned", "Roter didn't turned");
        }

        [TestMethod]
        [DataRow(9, 0, 0)]
        [DataRow(2, 0, 3)]
        [DataRow(0, 0, 1)]
        public void Roters2Test(int r2, int r3, int expected)
        {
            r2 = Enigma.Program.Roters2(r2, r3);

            Assert.AreEqual(expected, r2, "Roter turned", "Roter didn't turned");
        }

        [TestMethod]
        [DataRow(9, 0, 0, 0)]
        [DataRow(2, 0, 0, 3)]
        [DataRow(0, 0, 0, 1)]
        public void Roters1Test(int r1, int r2, int r3, int expected)
        {

            r1 = Enigma.Program.Roters1(r1, r2, r3);

            Assert.AreEqual(expected, r1, "Roter turned", "Roter didn't turned");
        }

        [TestMethod]
        [DataRow(1, 4, 9)]
        [DataRow(2, 5, 0)]
        [DataRow(3, 7, 5)]
        public void GetRotTest(int r, int number, int expected)
        {

            r = Enigma.Program.GetRot(r, number);
            Assert.AreEqual(expected, r, "Equally", "Error");

        }

    }
}
