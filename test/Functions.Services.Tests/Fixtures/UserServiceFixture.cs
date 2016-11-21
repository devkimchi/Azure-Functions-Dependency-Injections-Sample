using System;

using Functions.Mappers;

namespace Functions.Services.Tests.Fixtures
{
    /// <summary>
    /// This represents the fixture entity for the <see cref="UserServiceTest"/> class.
    /// </summary>
    public class UserServiceFixture : IDisposable
    {
        private bool _disposed;

        /// <summary>
        /// Initialises a new instance of the <see cref="UserServiceFixture"/> class.
        /// </summary>
        public UserServiceFixture()
        {
            this.MapperFactory = new MapperFactory();

            this.UserService = new UserService(this.MapperFactory);
        }

        /// <summary>
        /// Gets the <see cref="IMapperFactory"/> instance.
        /// </summary>
        public IMapperFactory MapperFactory { get; }

        /// <summary>
        /// Gets the <see cref="IUserService"/> instance.
        /// </summary>
        public IUserService UserService { get; }

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
