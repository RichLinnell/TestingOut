using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Console_app_library;

namespace TestApp_tests
{
    [TestFixture]
    public class when_validating_username_and_name_has_a_number_in_it
    {
        [Test]
        public void should_say_name_is_invalid()
        {
            var name = "test_123";
            Assert.That(name.Validate(), Is.False);

            name = "1233 name";
            Assert.That(name.Validate(), Is.False);

            name = "Thomas 123'Reilly";
            Assert.That(name.Validate(), Is.False);
        }
    }

    [TestFixture]
    public class When_validating_user_name_and_name_has_no_numbers_in_it
    {
        [Test]
        public void should_say_name_is_valid()
        {
            var name = "test_name";
            Assert.That(name.Validate(), Is.True);

            name = "test name";
            Assert.That(name.Validate(), Is.True);

            name = "Thomas O'Reilly";
            Assert.That(name.Validate(), Is.True);
        }
    }
}
