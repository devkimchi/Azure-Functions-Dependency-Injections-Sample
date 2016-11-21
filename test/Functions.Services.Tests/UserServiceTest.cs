using System;
using System.Collections.Generic;
using System.Linq;

using FluentAssertions;

using Functions.EntityModels;
using Functions.Services.Tests.Fixtures;

using Xunit;

namespace Functions.Services.Tests
{
    /// <summary>
    /// This represents the test entity for the <see cref="UserService"/> class.
    /// </summary>
    public class UserServiceTest : IClassFixture<UserServiceFixture>
    {
        private readonly IUserService _service;

        /// <summary>
        /// Initialises a new instance of the <see cref="UserServiceTest"/> class.
        /// </summary>
        /// <param name="fixture"><see cref="UserServiceFixture"/> instance.</param>
        public UserServiceTest(UserServiceFixture fixture)
        {
            this._service = fixture.UserService;
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        [Fact]
        public void GivenUser_GetUsers_ShouldReturn_Result()
        {
            var entities = new List<User>
                           {
                               new User() { UserId = Guid.NewGuid(), FirstName = "Jane", LastName = "Doe" },
                               new User() { UserId = Guid.NewGuid(), FirstName = "Joe", LastName = "Bloggs" }
                           };

            var users = this._service.GetUsers(entities);

            users.Count.Should().Be(entities.Count);
            users.First().FirstName.Should().Be(entities.First().FirstName);
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        [Fact]
        public async void GivenUser_GetUsersAsync_ShouldReturn_Result()
        {
            var entities = new List<User>
                           {
                               new User() { UserId = Guid.NewGuid(), FirstName = "Jane", LastName = "Doe" },
                               new User() { UserId = Guid.NewGuid(), FirstName = "Joe", LastName = "Bloggs" }
                           };

            var users = await this._service.GetUsersAsync(entities).ConfigureAwait(false);

            users.Count.Should().Be(entities.Count);
            users.First().FirstName.Should().Be(entities.First().FirstName);
        }
    }
}
