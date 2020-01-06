using System;
using System.Threading.Tasks;

using R5T.Endalia;


namespace R5T.Epidarus
{
    public interface IEndpointFactory
    {
        IEndpoint GetEndpoint(EndpointIdentity endpointIdentity);

        Task<IEndpoint> GetEndpointAsync(EndpointIdentity endpointIdentity);
    }
}
