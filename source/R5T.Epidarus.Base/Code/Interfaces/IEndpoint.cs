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
        void Send(string message);

        /// <summary>
        /// Used in debugging, or to exactly specify the message to send to an endpoint.
        /// Asynchronous.
        /// </summary>
        Task SendAsync(string message);

        /// <summary>
        /// Sends an anomaly to the endpoint, allowing the endpoint to determine the message sent to the anomaly.
        /// </summary>
        void Send(AnomalyIdentity anomalyIdentity);

        /// <summary>
        /// Sends an anomaly to the endpoint, allowing the endpoint to determine the message sent to the anomaly.
        /// Asynchronous.
        /// </summary>
        Task SendAsync(AnomalyIdentity anomalyIdentity, string hostString);
    }
}
