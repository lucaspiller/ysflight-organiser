using System;
using NUnit.Framework;

namespace Ysfo.Tests.Core.Loader
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
            new Ysfo.Core.SceneryCollection(_validYsPath);
        }

        [Test]
        public void ItMustAcceptLstPathInConstructor()
        {
            new Ysfo.Core.SceneryCollection(_validYsPath, "scenery.lst");
        }

        [Test]
        public void ConstructorMustAssignYsPath()
        {
            var scenery = new Ysfo.Core.SceneryCollection(_validYsPath);

            Assert.AreEqual(_validYsPath, scenery.YsPath);

            scenery = new Ysfo.Core.SceneryCollection(_validYsPath, "scenery.lst");

            Assert.AreEqual(_validYsPath, scenery.YsPath);
        }

        [Test]
        public void ConstructorMustAssignLstPath()
        {
            var scenery = new Ysfo.Core.SceneryCollection(_validYsPath);

            Assert.AreEqual("scenery/scenery.lst", scenery.LstPath);

            scenery = new Ysfo.Core.SceneryCollection(_validYsPath, "scenery.lst");

            Assert.AreEqual("scenery.lst", scenery.LstPath);
        }

        [Test]
        public void ConstructorMustAssignDefaultLstPathWhenPassedNull()
        {
            var scenery = new Ysfo.Core.SceneryCollection(_validYsPath, null);

            Assert.AreEqual("scenery/scenery.lst", scenery.LstPath);
        }

        [Test]
        public void LoadMustLoadscenery()
        {
            var scenery = new Ysfo.Core.SceneryCollection(_validYsPath, _validLstPath);

            Assert.AreEqual(0, scenery.Count);

            scenery.Load();

            Assert.AreEqual(1, scenery.Count);
        }
    }
}
