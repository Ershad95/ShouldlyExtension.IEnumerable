using System.Collections.Generic;
using ShouldlyExtension.Aggregates;
using Xunit;

namespace UnitTests
{
    public class CustomerTests
    {
        [Fact]
        public void LastItemInCustomerList_ShouldBeEquivalentToExpectedLastCustomer_Id_DescendingOrder()
        {
            // Arrange
            var customerList = new List<TestModel>()
            {
                new TestModel()
                {
                    Id = 1
                },
                new TestModel()
                {
                    Id = 2
                }
            };
            var expectedLastCustomer = new TestModel()
            {
                Id = 1
            };
            
            // Act & Assert
            customerList.ShouldBeEquivalentToLastItem(x => x.Id, expectedLastCustomer, OrderType.Descending);
        }
        
        [Fact]
        public void LastItemInCustomerList_ShouldBeEquivalentToExpectedLastCustomer_Id_AscendingOrder()
        {
            // Arrange
            var customerList = new List<TestModel>()
            {
                new TestModel()
                {
                    Id = 1
                },
                new TestModel()
                {
                    Id = 2
                }
            };
            var expectedLastCustomer = new TestModel()
            {
                Id = 2
            };
            
            // Act & Assert
            customerList.ShouldBeEquivalentToLastItem(x => x.Id, expectedLastCustomer, OrderType.Ascending);
        }
        
        [Fact]
        public void LastItemInCustomerList_ShouldBeEquivalentToExpectedFirstCustomer()
        {
            // Arrange
            var customerList = new List<TestModel>()
            {
                new TestModel()
                {
                    Id = 1
                },
                new TestModel()
                {
                    Id = 2
                }
            };
            var expectedFirstCustomer = new TestModel()
            {
                Id = 1
            };
            
            // Act & Assert
            customerList.ShouldBeEquivalentToFirstItem(expectedFirstCustomer);
        }
        
        [Fact]
        public void FirstItemInCustomerList_ShouldBeEquivalentToExpectedFirstCustomer_Id_DescendingOrder()
        {
            // Arrange
            var customerList = new List<TestModel>()
            {
                new TestModel()
                {
                    Id = 1
                },
                new TestModel()
                {
                    Id = 2
                }
            };
            var expectedFirstCustomer = new TestModel()
            {
                Id = 2
            };
            
            // Act & Assert
            customerList.ShouldBeEquivalentToFirstItem(x => x.Id, expectedFirstCustomer, OrderType.Descending);
        }
        
        [Fact]
        public void FirstItemInCustomerList_ShouldBeEquivalentToExpectedFirstCustomer_Id_AscendingOrder()
        {
            // Arrange
            var customerList = new List<TestModel>()
            {
                new TestModel()
                {
                    Id = 1
                },
                new TestModel()
                {
                    Id = 2
                }
            };
            var expectedFirstCustomer = new TestModel()
            {
                Id= 1
            };
            
            // Act & Assert
            customerList.ShouldBeEquivalentToFirstItem(x => x.Id, expectedFirstCustomer, OrderType.Ascending);
        }
        
        [Fact]
        public void FirstItemInCustomerList_ShouldBeEquivalentToExpectedFirstCustomer()
        {
            // Arrange
            var customerList = new List<TestModel>()
            {
                new TestModel()
                {
                    Id = 1
                },
                new TestModel()
                {
                    Id = 2
                }
            };
            var expectedFirstCustomer = new TestModel()
            {
                Id = 1
            };
            
            // Act & Assert
            customerList.ShouldBeEquivalentToFirstItem(expectedFirstCustomer);
        }
    }
    public class TestModel
    {
        public int Id { get; set; }
    }
}