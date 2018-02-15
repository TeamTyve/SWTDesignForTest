using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECS.Legacy.Unit.Test
{
    [TestFixture]
    public class EcsLegacyTest
    {
        [Test]
        public void Heater_RunSelfTest_NoThrow()
        {
            var uut = new Heater();

            Assert.That(uut.RunSelfTest(), Is.True);
        }
    }
}
