using System;

using AutoMapper;

namespace Functions.Mappers
{
    /// <summary>
    /// This represents the base mapper entity.
    /// </summary>
    public abstract class BaseMapper : IMapper
    {
        private readonly MapperConfiguration _configuration;
        private readonly AutoMapper.IMapper _mapper;

        private bool _disposed;

        /// <summary>
        /// Initialises a new instance of the <see cref="BaseMapper"/> class.
        /// </summary>
        protected BaseMapper()
        {
            this._configuration = this.Initialise();
            this._mapper = this.CreateMapper();
        }

        /// <summary>
        /// Converts the source object to the destination object.
        /// </summary>
        /// <typeparam name="TDestination">Type of destination object.</typeparam>
        /// <param name="source">Source object to convert.</param>
        /// <returns>Return the destination object converted.</returns>
        public TDestination Map<TDestination>(object source)
        {
            var mapped = this._mapper.Map<TDestination>(source);
            return mapped;
        }

        /// <summary>
        /// Configures the mapping information between source and destination.
        /// </summary>
        /// <param name="config"><see cref="IMapperConfigurationExpression"/> instance.</param>
        protected abstract void ConfigureMap(IMapperConfigurationExpression config);

        private MapperConfiguration Initialise()
        {
            var config = new MapperConfiguration(ConfigureMap);
            return config;
        }

        private AutoMapper.IMapper CreateMapper()
        {
            var mapper = this._configuration.CreateMapper();
            return mapper;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <param name="disposing">Value that specifies whether to be disposing manages resources or not.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (this._disposed)
            {
                return;
            }

            if (disposing)
            {
                // Dispose managed/disposable resources.
            }

            // Dispose unmanaged resources.

            this._disposed = true;
        }
    }
}
