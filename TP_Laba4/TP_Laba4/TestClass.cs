using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Laba4
{
    [TestFixture]
    public class TestClass
    {
        [Test] // ТЕСТ 1
        public void TestNumbersDelta()
        {
            LogicClass lC = new();
            Assert.AreEqual(17710, lC.NumbersDelta(1290, 19000));
        }

        [Test] // ТЕСТ 2
        public void TestListLength()
        {
            LogicClass lC = new();
            Assert.AreEqual(3, lC.ListLength(new List<string> { "фыв", "qwerty", "asdasdasd" }));
        }

        [Test] // ТЕСТ 3
        public void YearOfWar()
        {
            LogicClass lC = new();
            Assert.IsTrue(lC.YearOfWar(1939));
            Assert.IsFalse(lC.YearOfWar(1941));
            Assert.IsFalse(lC.YearOfWar(1945));
            Assert.IsFalse(lC.YearOfWar(2088));
        }

        [Test] // ТЕСТ 4
        public void TestSeasons()
        {
            LogicClass lC = new();
            Assert.AreEqual("Зима", lC.Seasons(1));
            Assert.AreEqual("Осень", lC.Seasons(10));
            Assert.AreEqual("Лето", lC.Seasons(7));
            Assert.AreEqual("Весна", lC.Seasons(5));
        }

        [Test] // ТЕСТ 5
        public void TestCountMinutes()
        {
            LogicClass lC = new();
            Assert.AreEqual(7380, lC.CountMinutes(123));
            Assert.AreEqual(32280, lC.CountMinutes(538));
            Assert.AreEqual(1159380, lC.CountMinutes(19323));
        }

        [Test] // ТЕСТ 6
        public void TestEditTopic()
        {
            LogicClass lC = new();
            Assert.AreEqual("Текущая тема: ДИАГРАММЫ ПРЕЦЕДЕНТОВ, КЛАССОВ, СОСТОЯНИЙ И ВИДОВ ДЕЯТЕЛЬНОСТИ",
                lC.EditTopic("Диаграммы прецедентов, классов, состояний и видов деятельности"));
            Assert.AreEqual("Текущая тема: РАЗРАБОТКА МИКРОСЕРВИСОВ",
                lC.EditTopic("Разработка микросервисов"));
            Assert.AreEqual("Текущая тема: UNIT-ТЕСТЫ",
                lC.EditTopic("unit-тесты"));
            Assert.AreEqual("Текущая тема: GIT",
                lC.EditTopic("Git"));
        }

        [Test] // ТЕСТ 7
        public void TestArrayTrippledSumm()
        {
            LogicClass lC = new();
            Assert.AreEqual(300, lC.ArrayTrippledSumm(new List<int> { 10, 20, 30, 40 }));
            Assert.AreEqual(3000, lC.ArrayTrippledSumm(new List<int> { 100, 200, 300, 400 }));
            Assert.AreEqual(447, lC.ArrayTrippledSumm(new List<int> { 31, 24, 67, 27 }));
        }
    }
}
