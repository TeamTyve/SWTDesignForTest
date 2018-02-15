using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ECS.Legacy.Unit.Test
{
    [TestFixture()]
    public class WindowTest
    {
        [Test]
        public void Window_WindowCtrlTemp7Threshold6_WindowOpenReturnsTrue()
        {
            var uut = new Window(6);

            uut.WindowCtrl(7);

            Assert.True(uut.WindowOpen);
        }

        [Test]
        public void Window_WindowCtrlTemp5Threshold6_WindowOpenReturnsFalse()
        {
            var uut = new Window(6);

            uut.WindowCtrl(5);

            Assert.False(uut.WindowOpen);
        }

        [Test]
        public void Window_GetWindowOpen_returnsTrue()
        {
            var uut = new Window();
            uut.WindowCtrl(2);

            Assert.True(uut.WindowOpen);
        }
    }
}
