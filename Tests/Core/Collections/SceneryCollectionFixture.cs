using System;
using NUnit.Framework;
using Ysfo.Core.Collections;

namespace Ysfo.Tests.Core.Collections
{
    [TestFixture]
    class SceneryCollectionFixture
    {
        String _validYsPath;
        String _validLstPath;

        [SetUp]
        public void Setup()
        {
            _validYsPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            _validLstPath = "scenery.lst";
        }

        [Test]
        public void ItMustAcceptYsPathInConstructor()
        {
            new SceneryCollection(_validYsPath);
        }

        [Test]
        public void ItMustAcceptLstPathInConstructor()
        {
            new SceneryCollection(_validYsPath, "scenery.lst");
        }

        [Test]
        public void ConstructorMustAssignYsPath()
        {
            var scenery = new SceneryCollection(_validYsPath);

            Assert.AreEqual(_validYsPath, scenery.YsPath);

            scenery = new SceneryCollection(_validYsPath, "scenery.lst");

            Assert.AreEqual(_validYsPath, scenery.YsPath);
        }

        [Test]
        public void ConstructorMustAssignLstPath()
        {
            var scenery = new SceneryCollection(_validYsPath);

            Assert.AreEqual("scenery/scenery.lst", scenery.LstPath);

            scenery = new SceneryCollection(_validYsPath, "scenery.lst");

            Assert.AreEqual("scenery.lst", scenery.LstPath);
        }

        [Test]
        public void ConstructorMustAssignDefaultLstPathWhenPassedNull()
        {
            var scenery = new SceneryCollection(_validYsPath, null);

            Assert.AreEqual("scenery/scenery.lst", scenery.LstPath);
        }

        [Test]
        public void LoadMustLoadscenery()
        {
            var scenery = new SceneryCollection(_validYsPath, _validLstPath);

            Assert.AreEqual(0, scenery.Count);

            scenery.Load();

            Assert.AreEqual(1, scenery.Count);
        }
    }
}