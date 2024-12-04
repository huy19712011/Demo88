using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8.Test
{
    [TestClass]
    public class GreeterTest
    {
        [TestMethod]
        public void TestGreet()
        {
            const string testName = "FPoly";
            Greeter greeter = new Greeter();

            StringAssert.Contains(greeter.Greet(testName), testName);
        }

        /// <summary>
        /// Checks the behavior of the method with an invalid argument (null).
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGreetNull()
        {
            Greeter greeter = new Greeter();
            greeter.Greet(null);
        }

        /// <summary>
        /// Checks the behavior of the method with an invalid argument (empty).
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGreetEmpty()
        {
            Greeter greeter = new Greeter();
            greeter.Greet(string.Empty);
        }
    }
}
