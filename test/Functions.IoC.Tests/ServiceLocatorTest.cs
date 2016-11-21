using System;
using System.Collections.Generic;
using System.Linq;

using FluentAssertions;

using Functions.EntityModels;
using Functions.Services;

using Xunit;

namespace Functions.IoC.Tests
{
    /// <summary>
    /// This represents the test entity for the <see cref="ServiceLocator"/> class.
    /// </summary>
    public class ServiceLocatorTest
    {
        /// <summary>
        /// Tests whether the property should return result or not.
        /// </summary>
        [Fact]
        public void Given_Dependencies_Instance_ShouldReturn_Result()
        {
            var locator = new ServiceLocator();
            var instance = locator.Instance;

            var service = instance.GetInstance<IUserService>();

            var entities = new List<User>
                           {
                               new User() { UserId = Guid.NewGuid(), FirstName = "Jane", LastName = "Doe" },
                               new User() { UserId = Guid.NewGuid(), FirstName = "Joe", LastName = "Bloggs" }
                           };

            var users = service.GetUsers(entities);

            users.Count.Should().Be(entities.Count);
            users.First().FirstName.Should().Be(entities.First().FirstName);
        }
    }
}
