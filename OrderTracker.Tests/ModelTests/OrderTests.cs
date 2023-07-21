using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("Test Title", "Test Description", 1, "Test Date");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetTitleAndDescription_ReturnsTitleAndDescription_String()
        {
            string title = "Test Order Title";
            string description = "Test Order Description";
            int price = 1;
            string date = "Test Order Date";
            Order newOrder = new Order(title, description, price, date);
            string resultTitle = newOrder.Title;
            string resultDescription = newOrder.Description;
            Assert.AreEqual(title, resultTitle);
            Assert.AreEqual(description, resultDescription);
        }
    }
}