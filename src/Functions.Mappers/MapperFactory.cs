using System;

namespace Functions.Mappers
{
    /// <summary>
    /// This represents the entity for mapper factory.
    /// </summary>
    public class MapperFactory : IMapperFactory
    {
        private bool _disposed;

        /// <summary>
        /// Get a new <see cref="IMapper"/> instance.
        /// </summary>
        /// <typeparam name="TMapper">Type inheriting the <see cref="IMapper"/> instance.</typeparam>
        /// <returns>Returns the <see cref="IMapper"/> instance.</returns>
        public IMapper Get<TMapper>() where TMapper : IMapper
        {
            var mapper = Activator.CreateInstance<TMapper>();

            return mapper;
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
