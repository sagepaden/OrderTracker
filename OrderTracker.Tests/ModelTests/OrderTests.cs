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

        [TestMethod]
        public void SetTitleAndDescription_UpdateTitleAndDescription_String()
        {
            string title = "Test Order Title";
            string description = "Test Order Description";
            int price = 1;
            string date = "Test Order Date";
            Order newOrder =  new Order(title, description, price, date);
            string updatedTitle = "New Test Order Title";
            string updatedDescription = "New Test Order Desciption";
            newOrder.Title = updatedTitle;
            newOrder.Description = updatedDescription;
            string resultTitle = newOrder.Title;
            string resultDescription = newOrder.Description;
            Assert.AreEqual(updatedTitle, resultTitle);
            Assert.AreEqual(updatedDescription, resultDescription);
        }

        [TestMethod]
        public void GetAll_ReturnsAllOrders_OrderList()
        {
            string title1 = "Test Order Title 1";
            string title2 = "Test Order Title 2";
            string description1 = "Test Order Description 1";
            string description2 = "Test Order Description 2";
            int price1 = 1;
            int price2 = 2;
            string date1 = "Test Order Date 1";
            string date2 = "Test Order Date 2";
            Order newOrder1 = new Order(title1, description1, price1, date1);
            Order newOrder2 = new Order(title2, description2, price2, date2);
            List<Order> newList = new List<Order> { newOrder1, newOrder2 };
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }
    }
}