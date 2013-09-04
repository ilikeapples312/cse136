﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using POCO;
using BL;

namespace BLTest
{
    class BLStaffTest
    {
        private TestContext testContextInstance;

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

        [TestMethod]
        public void BLStaffErrorTest()
        {
            List<string> er = new List<string>();

            BLStaff.GetStaffDetails(null, ref er);
            Assert.AreEqual(1, er.Count);
        }

        [TestMethod]
        public void BLStaffCRUDTest()
        {
            Staff s = new Staff();
            s.id = Guid.NewGuid().ToString().Substring(0, 20);
            s.email = "pooplord@spiderman.com";
            s.password = "password";

            List<string> errors = new List<string>();

            BLStaff.InsertStaff(s, ref errors);

            Assert.AreEqual(0, errors.Count);

            Staff fetchedStaff = BLStaff.GetStaffDetails(s.email, ref errors);

            Assert.AreEqual(0, errors.Count);

            Assert.AreEqual(s.id, fetchedStaff.id);
            Assert.AreEqual(s.email, fetchedStaff.email);
            Assert.AreEqual(s.password, fetchedStaff.password);

            s.password = "banana";

            BLStaff.UpdateStaff(s, ref errors);

            Assert.AreEqual(0, errors.Count);

            fetchedStaff = BLStaff.GetStaffDetails(s.email, ref errors);

            Assert.AreEqual(s.id, fetchedStaff.id);
            Assert.AreEqual(s.email, fetchedStaff.email);
            Assert.AreEqual(s.password, fetchedStaff.password);

            BLStaff.DeleteStaff(s.id, ref errors);
            Assert.AreEqual(0, errors.Count);

            Staff nullStaff = BLStaff.GetStaffDetails(s.email, ref errors);
            Assert.AreEqual(0, errors.Count);

            Assert.AreEqual(null, nullStaff);
        }
    }
}
