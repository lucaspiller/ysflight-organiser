using System;
using System.IO;
using NUnit.Framework;
using Ysfo.Core.Collections;

namespace Ysfo.Tests.Core.Collections
{
    [TestFixture]
    class GroundCollectionFixture
    {
        readonly String _validYsPath = AppDomain.CurrentDomain.BaseDirectory;
        const String _validLstPath = "aircraft.lst";

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

            Assert.AreEqual(@"ground\ground.lst", ground.LstPath);

            ground = new GroundCollection(_validYsPath, "ground.lst");

            Assert.AreEqual("ground.lst", ground.LstPath);
        }

        [Test]
        public void ConstructorMustAssignDefaultLstPathWhenPassedNull()
        {
            var ground = new GroundCollection(_validYsPath, null);

            Assert.AreEqual(@"ground\ground.lst", ground.LstPath);
        }

        [Test]
        public void LoadMustLoadGround()
        {
            var ground = new GroundCollection(_validYsPath, _validLstPath);

            Assert.AreEqual(0, ground.Count);

            ground.Load();

            Assert.AreEqual(1, ground.Count);
        }

        [Test]
        public void SaveMustWriteFile()
        {
            // get output file path and ensure it doesn't exist
            String outputFile = Path.Combine(_validYsPath, "test.lst");
            Assert.IsFalse(File.Exists(outputFile), "test.lst file already exists!");

            // create collection
            var addons = new GroundCollection(_validYsPath, "test.lst");

            // add test addon
            addons.Add(new Ysfo.Core.GroundAddon { LstEntry = "TEST.DAT TEST.SRF" });

            // save
            addons.Save();

            // make sure file created
            Assert.IsTrue(File.Exists(outputFile));

            // cleanup
            File.Delete(outputFile);
        }
    }
}