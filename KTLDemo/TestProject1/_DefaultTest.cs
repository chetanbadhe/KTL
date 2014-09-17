using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KTLDemo;
using System.Web;
using System.Web.UI;
using KTLDemo.Model;

namespace TestProject1
{
    /// <summary>
    /// Summary description for _DefaultTest
    /// </summary>
    [TestClass]
    public class _DefaultTest
    {
        public _DefaultTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestGetData()
        {
            _Default target = new _Default(); // TODO: Initialize to an appropriate value
            string custid = "305"; // TODO: Initialize to an appropriate value
            Assert.IsNotNull(target.GetData(custid));
        }

        [TestMethod]
        public void CreateDataContext_ConnectionString_ReturnsDataContextObject()
        {
            DCOrdersDataContext dc = new DCOrdersDataContext(@"Data Source=CHETANBADHE-PC\SQLEXPRESS;Initial Catalog=KTL;Persist Security Info=True;User ID=sa;Password=sa@123");
            Assert.IsNotNull(dc);
            Assert.IsNotNull(dc.Connection);
        }
    }
}
