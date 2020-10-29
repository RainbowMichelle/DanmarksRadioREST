using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRCDRest.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DRCDRest.Controllers.Tests
{
    [TestClass()]
    public class CDsControllerTests
    {

        private CDsController cntr = null;

        [TestInitialize]
        public void Init()
        {
            cntr = new CDsController();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            List<CD> cder = new List<CD>(cntr.GetAll());
            Assert.AreEqual(5, cder.Count);
            Assert.AreNotEqual(6, cder.Count);
        }

        [TestMethod()]
        public void GetArtistSubTest()
        {
            string _substring = "jon";
            List <CD> _cder = new List<CD>((IEnumerable<CD>)cntr.GetArtistSub(_substring));
            Assert.AreEqual(2, _cder.Count);
            Assert.AreNotEqual(4, _cder.Count);
        }
        //[TestMethod()]
        //public void GetTest1()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void PostTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void PutTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void DeleteTest()
        //{
        //    Assert.Fail();
        //}
    }
}

//namespace DRCDRestTests.Controllers
//{
//    class CDsControllerTests
//    {
//    }
//}
