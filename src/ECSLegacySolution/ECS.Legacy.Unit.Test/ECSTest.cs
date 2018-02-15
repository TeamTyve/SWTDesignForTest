using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECS.Legacy.Unit.Test
{
    [TestFixture]
    public class EcsTest
    {
        [Test]
        public void ECS_Ctor_Inject_NoThrow()
        {
            var uut = new ECS(10, new FakeTempSensor(), new FakeHeater());
        }

        [Test]
        public void ECS_CanRegulateThr26AboveT25_HeaterTurnedOn()
        {
            // Arrange
            var fakeHeater = new FakeHeater();
            var uut = new ECS(26, new FakeTempSensor(), fakeHeater);

            //Act
            uut.Regulate();

            Assert.That(fakeHeater.TurnedOn, Is.True);
        }

        [Test]
        public void ECS_CanRegulateThr24BelowT25_HeaterTurnedOff()
        {
            // Arrange
            var fakeHeater = new FakeHeater();
            var uut = new ECS(24, new FakeTempSensor(), fakeHeater);

            //Act
            uut.Regulate();

            Assert.That(fakeHeater.TurnedOn, Is.False);
        }

        [TestCase(0,0)]
        [TestCase(1, 1)]
        [TestCase(-1, -1)]
        public void ECS_SetAndGetThreshold_Simplecases(int a, int expected)
        {
            var uut = new ECS(0, new FakeTempSensor(), new FakeHeater());

            uut.SetThreshold(a);

            Assert.That(uut.GetThreshold(), Is.EqualTo(expected));
        }

        [Test]
        public void ECS_GetCurTemp_Returns0()
        {
            var uut = new ECS(0, new FakeTempSensor(), new FakeHeater());

            Assert.That(uut.GetCurTemp(), Is.EqualTo(0));
        }

        [Test]
        public void ECS_RunSelfTest_ReturnsTrue()
        {
            var uut = new ECS(0, new FakeTempSensor(), new FakeHeater());

            Assert.That(uut.RunSelfTest, Is.True);
        }
    }
}
