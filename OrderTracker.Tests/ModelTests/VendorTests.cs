using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
    [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("Test Vendor", "Test Description");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetVendorNameAndDescription_ReturnsVendorNameAndDescription_String()
        {
            string vendorName = "Test Vendor";
            string vendorDescription = "Test Description";
            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            string resultVendorName = newVendor.VendorName;
            string resultVendorDescription = newVendor.VendorDescription;
            Assert.AreEqual(vendorName, resultVendorName);
            Assert.AreEqual(vendorDescription, resultVendorDescription);
        }

        [TestMethod]
        public void GetId_ReturnVendorId_Int()
        {
            string vendorName = "Test Vendor Name";
            string vendorDescription = "Test Vendor Description";
            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            int result = newVendor.Id;
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetAll_ReturnsAllVendorObjects_VendorList()
        {
            string vendorName1 = "Test Vendor Name 1";
            string vendorName2 = "Test Vendor Name 2";
            string vendorDescription1 = "Test Vendor Description 1";
            string vendorDescription2 = "Test Vendor Description 2";
            Vendor newVendor1 = new Vendor(vendorName1, vendorDescription1);
            Vendor newVendor2 = new Vendor(vendorName2, vendorDescription2);
            List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
            List<Vendor> result = Vendor.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }
    }
}