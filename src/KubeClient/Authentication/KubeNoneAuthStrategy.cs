﻿using HTTPlease;
using System.Net.Http;

namespace KubeClient.Authentication
{
    /// <summary>
    ///     A Kubernetes API authentication strategy that makes no attempt to authenticate (i.e. anonymous access).
    /// </summary>
    public class KubeNoneAuthStrategy
        : KubeAuthStrategy
    {
        /// <summary>
        ///     The singleton instance of <see cref="KubeNoneAuthStrategy"/>.
        /// </summary>
        public static readonly KubeNoneAuthStrategy Instance = new KubeNoneAuthStrategy();

        /// <summary>
        ///     Create a new <see cref="KubeNoneAuthStrategy"/>.
        /// </summary>
        KubeNoneAuthStrategy()
        {
        }

        /// <summary>
        ///     Validate the authentication strategy's configuration.
        /// </summary>
        /// <exception cref="KubeClientException">
        ///     The authentication strategy's configuration is incomplete or invalid.
        /// </exception>
        public override void Validate()
        {
            // Nothing to do.
        }

        /// <summary>
        ///     Configure the <see cref="ClientBuilder"/> used to create <see cref="HttpClient"/>s used by the API client.
        /// </summary>
        /// <param name="clientBuilder">
        ///     The <see cref="ClientBuilder"/> to configure.
        /// </param>
        /// <returns>
        ///     The configured <see cref="ClientBuilder"/>.
        /// </returns>
        public override ClientBuilder Configure(ClientBuilder clientBuilder) => clientBuilder;

        /// <summary>
        ///     Create a deep clone of the authentication strategy.
        /// </summary>
        /// <returns>
        ///     The cloned <see cref="KubeAuthStrategy"/>.
        /// </returns>
        public override KubeAuthStrategy Clone() => KubeNoneAuthStrategy.Instance; // Singleton.
    }
}
