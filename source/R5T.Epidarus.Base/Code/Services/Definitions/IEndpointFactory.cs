using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Endalia;

using R5T.T0064;


namespace R5T.Epidarus
{
    [ServiceDefinitionMarker]
    public interface IEndpointFactory : IServiceDefinition
    {
        Task<List<IEndpoint>> GetEndpointsAsync(IEnumerable<EndpointIdentity> endpointIdentities);
    }
}
