using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECS.Legacy.Unit.Test
{
    [TestFixture]
    public class HeaterTest
    {
        public IHeater Uut { get; set; }
        [SetUp]
        public void Init()
        {
            Uut = new Heater();
        }

        [Test]
        public void Heater_CanTurnOn_NoThrow()
        {
            Assert.DoesNotThrow(Uut.TurnOn);
        }

        [Test]
        public void Heater_CanTurnOff_NoThrow()
        {
            Assert.DoesNotThrow(Uut.TurnOff);
        }

        [Test]
        public void Heater_RunSelfTest_ReturnsTrue()
        {
            Assert.That(Uut.RunSelfTest, Is.True);
        }
    }
}
