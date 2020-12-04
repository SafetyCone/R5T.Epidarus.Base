using System;
using System.Threading.Tasks;

using R5T.Sindia;


namespace R5T.Epidarus
{
    public interface IEndpoint
    {
        /// <summary>
        /// Used in debugging, or to exactly specify the message to send to an endpoint.
        /// </summary>
        Task Send(string message);

        /// <summary>
        /// Sends an anomaly to the endpoint, allowing the endpoint to determine the message sent to the anomaly.
        /// Returns the status that should be applied to the anomaly after sending.
        /// </summary>
        Task<string> Send(AnomalyIdentity anomalyIdentity);
    }
}
