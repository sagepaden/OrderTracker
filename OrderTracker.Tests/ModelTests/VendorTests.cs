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
            string vendorName = "Test Name";
            string vendorDescription = "Test Description";
            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            int result = newVendor.Id;
            Assert.AreEqual(1, result);
        }
    }
}