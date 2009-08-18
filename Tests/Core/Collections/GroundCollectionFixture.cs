using System;
using NUnit.Framework;
using Ysfo.Core.Collections;

namespace Ysfo.Tests.Core.Collections
{
    [TestFixture]
    class GroundCollectionFixture
    {
        String _validYsPath;
        String _validLstPath;

        [SetUp]
        public void Setup()
        {
            _validYsPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            _validLstPath = "ground.lst";
        }

        [Test]
        public void ItMustAcceptYsPathInConstructor()
        {
            new GroundCollection(_validYsPath);
        }

        [Test]
        public void ItMustAcceptLstPathInConstructor()
        {
            new GroundCollection(_validYsPath, "ground.lst");
        }

        [Test]
        public void ConstructorMustAssignYsPath()
        {
            var ground = new GroundCollection(_validYsPath);

            Assert.AreEqual(_validYsPath, ground.YsPath);

            ground = new GroundCollection(_validYsPath, "ground.lst");

            Assert.AreEqual(_validYsPath, ground.YsPath);
        }

        [Test]
        public void ConstructorMustAssignLstPath()
        {
            var ground = new GroundCollection(_validYsPath);

            Assert.AreEqual("ground/ground.lst", ground.LstPath);

            ground = new GroundCollection(_validYsPath, "ground.lst");

            Assert.AreEqual("ground.lst", ground.LstPath);
        }

        [Test]
        public void ConstructorMustAssignDefaultLstPathWhenPassedNull()
        {
            var ground = new GroundCollection(_validYsPath, null);

            Assert.AreEqual("ground/ground.lst", ground.LstPath);
        }

        [Test]
        public void LoadMustLoadground()
        {
            var ground = new GroundCollection(_validYsPath, _validLstPath);

            Assert.AreEqual(0, ground.Count);

            ground.Load();

            Assert.AreEqual(1, ground.Count);
        }
    }
}