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
        public void Add()
        {
            Assert.That(2+2, Is.EqualTo(4));
        }

        [Test]
        public void Add2()
        {
            Assert.That(2 + 2, Is.EqualTo(4));
        }
    }
}
