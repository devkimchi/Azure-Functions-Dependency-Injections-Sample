using System;

namespace Functions.Mappers
{
    /// <summary>
    /// This provides interfaces to the <see cref="MapperFactory"/> class.
    /// </summary>
    public interface IMapperFactory : IDisposable
    {
        /// <summary>
        /// Gets a new <see cref="IMapper"/> instance.
        /// </summary>
        /// <typeparam name="TMapper">Type inheriting the <see cref="IMapper"/> instance.</typeparam>
        /// <returns>Returns the <see cref="IMapper"/> instance.</returns>
        IMapper Get<TMapper>() where TMapper : IMapper;
    }
}