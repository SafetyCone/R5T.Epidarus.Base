using System;
using System.Linq;
using System.Threading.Tasks;

using R5T.Endalia;
using R5T.Magyar;


namespace R5T.Epidarus
{
    public static class IEndpointFactoryExtensions
    {
        public static async Task<IEndpoint> GetEndpoint(this IEndpointFactory endpointFactory,
            EndpointIdentity endpointIdentity)
        {
            var endpoints = await endpointFactory.GetEndpointsAsync(EnumerableHelper.From(endpointIdentity));

            var endpoint = endpoints.Single();
            return endpoint;
        }
    }
}
