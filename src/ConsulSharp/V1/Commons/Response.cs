﻿namespace ConsulSharp.V1.Commons
{
    /// <summary>
    /// Represents a Consul response.
    /// </summary>
    /// <typeparam name="TResponseData">The type of the data contained in the response.</typeparam>
    public class Response<TResponseData>
    {
        /// <summary>
        /// Gets or sets the time in milliseconds that a server was last contacted by the leader node.
        /// </summary>
        public string Index { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier representing the current state of the requested resource for blocking queries.
        /// </summary>
        public long LastContactMilliseconds { get; set; }

        /// <summary>
        /// Gets or sets the known leader.
        /// </summary>
        public string KnownLeader { get; set; }

        /// <summary>
        /// Gets or sets the response data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public TResponseData ResponseData { get; set; }
    }
}