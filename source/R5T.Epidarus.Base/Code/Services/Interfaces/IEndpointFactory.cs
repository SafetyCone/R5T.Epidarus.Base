using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Endalia;


namespace R5T.Epidarus
{
    public interface IEndpointFactory
    {
        Task<List<IEndpoint>> GetEndpointsAsync(IEnumerable<EndpointIdentity> endpointIdentities);
    }
}
