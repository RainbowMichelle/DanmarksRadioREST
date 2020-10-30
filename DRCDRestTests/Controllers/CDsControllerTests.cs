using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRCDRest.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DRCDRest.Controllers.Tests
{
    [TestClass()]
    public class CDsControllerTests
    {

        private CDsController cntr = null;
        private static List<CD> cder = new List<CD>();

        [TestInitialize]
        public void Init()
        {
            cntr = new CDsController();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            cder = new List<CD>(cntr.GetAll());
            Assert.AreEqual(5, cder.Count);
            Assert.AreNotEqual(6, cder.Count);
        }

        [TestMethod()]
        public void GetArtistSubTest()
        {
            //arrange
            string _substring = "Eva";
            cder = new List<CD>(cntr.GetAll());
            //act
            var result = cntr.GetArtistSub(_substring);
            //assert
            Assert.AreEqual(cder[2], result);
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
