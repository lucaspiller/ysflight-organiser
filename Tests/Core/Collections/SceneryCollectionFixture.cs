using System;
using System.IO;
using NUnit.Framework;
using Ysfo.Core.Collections;

namespace Ysfo.Tests.Core.Collections
{
    [TestFixture]
    class SceneryCollectionFixture
    {
        readonly String _validYsPath = AppDomain.CurrentDomain.BaseDirectory;
        const String _validLstPath = "aircraft.lst";

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

        [Test]
        public void SaveMustWriteFile()
        {
            // get output file path and ensure it doesn't exist
            String outputFile = Path.Combine(_validYsPath, "test.lst");
            Assert.IsFalse(File.Exists(outputFile), "test.lst file already exists!");

            // create collection
            var addons = new SceneryCollection(_validYsPath, "test.lst");

            // add test addon
            addons.Add(new Ysfo.Core.SceneryAddon { LstEntry = "TEST TEST.SRF" });

            // save
            addons.Save();

            // make sure file created
            Assert.IsTrue(File.Exists(outputFile));

            // cleanup
            File.Delete(outputFile);
        }
    }
}