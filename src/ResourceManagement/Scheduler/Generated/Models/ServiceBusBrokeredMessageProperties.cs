// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Scheduler.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Scheduler;
    using Microsoft.Azure.Management.Scheduler.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ServiceBusBrokeredMessageProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ServiceBusBrokeredMessageProperties class.
        /// </summary>
        public ServiceBusBrokeredMessageProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ServiceBusBrokeredMessageProperties class.
        /// </summary>
        /// <param name="contentType">Gets or sets the content type.</param>
        /// <param name="correlationId">Gets or sets the correlation
        /// ID.</param>
        /// <param name="forcePersistence">Gets or sets the force
        /// persistence.</param>
        /// <param name="label">Gets or sets the label.</param>
        /// <param name="messageId">Gets or sets the message ID.</param>
        /// <param name="partitionKey">Gets or sets the partition key.</param>
        /// <param name="replyTo">Gets or sets the reply to.</param>
        /// <param name="replyToSessionId">Gets or sets the reply to session
        /// ID.</param>
        /// <param name="scheduledEnqueueTimeUtc">Gets or sets the scheduled
        /// enqueue time UTC.</param>
        /// <param name="sessionId">Gets or sets the session ID.</param>
        /// <param name="timeToLive">Gets or sets the time to live.</param>
        /// <param name="to">Gets or sets the to.</param>
        /// <param name="viaPartitionKey">Gets or sets the via partition
        /// key.</param>
        public ServiceBusBrokeredMessageProperties(string contentType = default(string), string correlationId = default(string), bool? forcePersistence = default(bool?), string label = default(string), string messageId = default(string), string partitionKey = default(string), string replyTo = default(string), string replyToSessionId = default(string), System.DateTime? scheduledEnqueueTimeUtc = default(System.DateTime?), string sessionId = default(string), System.TimeSpan? timeToLive = default(System.TimeSpan?), string to = default(string), string viaPartitionKey = default(string))
        {
            ContentType = contentType;
            CorrelationId = correlationId;
            ForcePersistence = forcePersistence;
            Label = label;
            MessageId = messageId;
            PartitionKey = partitionKey;
            ReplyTo = replyTo;
            ReplyToSessionId = replyToSessionId;
            ScheduledEnqueueTimeUtc = scheduledEnqueueTimeUtc;
            SessionId = sessionId;
            TimeToLive = timeToLive;
            To = to;
            ViaPartitionKey = viaPartitionKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the content type.
        /// </summary>
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the correlation ID.
        /// </summary>
        [JsonProperty(PropertyName = "correlationId")]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets the force persistence.
        /// </summary>
        [JsonProperty(PropertyName = "forcePersistence")]
        public bool? ForcePersistence { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the message ID.
        /// </summary>
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets the partition key.
        /// </summary>
        [JsonProperty(PropertyName = "partitionKey")]
        public string PartitionKey { get; set; }

        /// <summary>
        /// Gets or sets the reply to.
        /// </summary>
        [JsonProperty(PropertyName = "replyTo")]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Gets or sets the reply to session ID.
        /// </summary>
        [JsonProperty(PropertyName = "replyToSessionId")]
        public string ReplyToSessionId { get; set; }

        /// <summary>
        /// Gets or sets the scheduled enqueue time UTC.
        /// </summary>
        [JsonProperty(PropertyName = "scheduledEnqueueTimeUtc")]
        public System.DateTime? ScheduledEnqueueTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets the session ID.
        /// </summary>
        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// Gets or sets the time to live.
        /// </summary>
        [JsonProperty(PropertyName = "timeToLive")]
        public System.TimeSpan? TimeToLive { get; set; }

        /// <summary>
        /// Gets or sets the to.
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        public string To { get; set; }

        /// <summary>
        /// Gets or sets the via partition key.
        /// </summary>
        [JsonProperty(PropertyName = "viaPartitionKey")]
        public string ViaPartitionKey { get; set; }

    }
}
