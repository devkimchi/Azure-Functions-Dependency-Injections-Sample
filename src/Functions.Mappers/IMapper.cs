using System;

namespace Functions.Mappers
{
    /// <summary>
    /// This provides interfaces to the mapper classes.
    /// </summary>
    public interface IMapper : IDisposable
    {
        /// <summary>
        /// Converts the source object to the destination object.
        /// </summary>
        /// <typeparam name="TDestination">Type of destination object.</typeparam>
        /// <param name="source">Source object to convert.</param>
        /// <returns>Return the destination object converted.</returns>
        TDestination Map<TDestination>(object source);
    }
}