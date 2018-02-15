using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECS.Legacy.Unit.Test
{
    [TestFixture]
    public class MainTest
    {
        [Test]
        public void Main_CanRun_NoThrow()
        {
            var uut = new Application();

            Application.Main();
        }
    }
}
