using System;
using System.Collections.Generic;
using System.Linq;

using Functions.EntityModels;
using Functions.Mappers;
using Functions.Models;

namespace Functions.Services
{
    /// <summary>
    /// This represents the service entity for users.
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IMapperFactory _factory;

        private bool _disposed;

        /// <summary>
        /// Initialises a new instance of the <see cref="UserService"/> class.
        /// </summary>
        /// <param name="factory"><see cref="IMapperFactory"/> instance.</param>
        /// <exception cref="ArgumentNullException"><paramref name="factory"/> is <see langword="null" />.</exception>
        public UserService(IMapperFactory factory)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            this._factory = factory;
        }

        /// <summary>
        /// Gets the list of users.
        /// </summary>
        /// <param name="results">Result from data store.</param>
        /// <returns>Returns the list of users.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="results"/> is <see langword="null" />.</exception>
        public List<UserModel> GetUsers(IList<User> results)
        {
            if (results == null || !results.Any())
            {
                throw new ArgumentNullException(nameof(results));
            }

            using (var mapper = this._factory.Get<UserToUserModelMapper>())
            {
                var users = mapper.Map<List<UserModel>>(results);
                return users;
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (this._disposed)
            {
                return;
            }

            this._disposed = true;
        }
    }
}
