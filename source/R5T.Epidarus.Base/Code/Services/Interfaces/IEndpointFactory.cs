using System;

using R5T.Endalia;


namespace R5T.Epidarus
{
    public interface IEndpointFactory
    {
        IEndpoint GetEndpoint(EndpointIdentity endpointIdentity);
    }
}
