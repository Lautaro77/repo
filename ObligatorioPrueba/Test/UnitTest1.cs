using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddUser()
        {
            User user = new User()
            {
                Name = "Victor",
            };
            Logic.AddUser(user);
            Assert.IsTrue(Logic.GetUsers().Exists(user));
        }
    }
}
