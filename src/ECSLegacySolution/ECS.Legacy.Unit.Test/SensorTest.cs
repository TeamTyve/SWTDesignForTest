using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECS.Legacy.Unit.Test
{
    [TestFixture]
    public class SensorTest
    {
        public ITempSensor Uut { get; set; }

        [SetUp]
        public void Init()
        {
            Uut = new TempSensor();
        }

        [Test]
        public void TempSensor_GetTemp_Returns25()
        {
            Assert.That(Uut.GetTemp(), Is.EqualTo(25));
        }

        [Test]
        public void TempSensor_RunSelfTest_ReturnsTrue()
        {
            Assert.That(Uut.RunSelfTest, Is.True);
        }
    }
}
