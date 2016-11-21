using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Functions.EntityModels;
using Functions.Models;

namespace Functions.Services
{
    /// <summary>
    /// This provides interfaces to the <see cref="UserService"/> class.
    /// </summary>
    public interface IUserService : IDisposable
    {
        /// <summary>
        /// Gets the list of users.
        /// </summary>
        /// <param name="results">Result from data store.</param>
        /// <returns>Returns the list of users.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="results"/> is <see langword="null" />.</exception>
        List<UserModel> GetUsers(IList<User> results);

        /// <summary>
        /// Gets the list of users.
        /// </summary>
        /// <param name="results">Result from data store.</param>
        /// <returns>Returns the list of users.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="results"/> is <see langword="null" />.</exception>
        Task<List<UserModel>> GetUsersAsync(IList<User> results);
    }
}