using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Ysfo.Tests.Core
{
    [TestFixture]
    class YsfoFixture
    {
        protected const string ysPath = @"C:\dev\ysflight\20090502";

        [Test]
        public void ItMustEnableThePathToBeSet()
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = ysPath;
            }
        }
    }
}
