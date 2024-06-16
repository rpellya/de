using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodLogin()
        {
            SqlClass database = new SqlClass();

            LoginForm loginForm = new LoginForm();
            try
            {
                var res = loginForm.CheckAuth("login4", "pass4");

                Assert.IsTrue(res >= 1 && res <= 4, "Результат не находится между 1 и 4");
            }
            catch(Exception ex)
            {
                Assert.Fail();
            }
            
        }


        [TestMethod]
        public void TestMethodCreate()
        {
            SqlClass database = new SqlClass();

            AddRequestForm addRequestForm = new AddRequestForm();
            try
            {
                var res = addRequestForm.CreateRequest(1, "Test2", 1, "Test3");

                Assert.AreEqual(res, 1);
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }

        }
    }
}
