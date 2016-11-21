using AutoMapper;

using Functions.EntityModels;
using Functions.Models;

namespace Functions.Mappers
{
    /// <summary>
    /// This represents the mapper entity between <see cref="User"/> and <see cref="UserModel"/>.
    /// </summary>
    public class UserToUserModelMapper : BaseMapper
    {
        /// <summary>
        /// Configures the mapping information between source and destination.
        /// </summary>
        /// <param name="config"><see cref="IMapperConfigurationExpression"/> instance.</param>
        protected override void ConfigureMap(IMapperConfigurationExpression config)
        {
            config.CreateMap<User, UserModel>()
                  ;
        }
    }
}
