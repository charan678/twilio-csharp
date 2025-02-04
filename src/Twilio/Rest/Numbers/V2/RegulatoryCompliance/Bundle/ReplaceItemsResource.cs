/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// ReplaceItemsResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Numbers.V2.RegulatoryCompliance.Bundle
{

    public class ReplaceItemsResource : Resource
    {
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Draft = new StatusEnum("draft");
            public static readonly StatusEnum PendingReview = new StatusEnum("pending-review");
            public static readonly StatusEnum InReview = new StatusEnum("in-review");
            public static readonly StatusEnum TwilioRejected = new StatusEnum("twilio-rejected");
            public static readonly StatusEnum TwilioApproved = new StatusEnum("twilio-approved");
            public static readonly StatusEnum ProvisionallyApproved = new StatusEnum("provisionally-approved");
        }

        public sealed class EndUserTypeEnum : StringEnum
        {
            private EndUserTypeEnum(string value) : base(value) {}
            public EndUserTypeEnum() {}
            public static implicit operator EndUserTypeEnum(string value)
            {
                return new EndUserTypeEnum(value);
            }

            public static readonly EndUserTypeEnum Individual = new EndUserTypeEnum("individual");
            public static readonly EndUserTypeEnum Business = new EndUserTypeEnum("business");
        }

        private static Request BuildCreateRequest(CreateReplaceItemsOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Numbers,
                "/v2/RegulatoryCompliance/Bundles/" + options.PathBundleSid + "/ReplaceItems",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Replaces all bundle items in the target bundle (specified in the path) with all the bundle items of the source
        /// bundle (specified by the from_bundle_sid body param)
        /// </summary>
        /// <param name="options"> Create ReplaceItems parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ReplaceItems </returns>
        public static ReplaceItemsResource Create(CreateReplaceItemsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Replaces all bundle items in the target bundle (specified in the path) with all the bundle items of the source
        /// bundle (specified by the from_bundle_sid body param)
        /// </summary>
        /// <param name="options"> Create ReplaceItems parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ReplaceItems </returns>
        public static async System.Threading.Tasks.Task<ReplaceItemsResource> CreateAsync(CreateReplaceItemsOptions options,
                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Replaces all bundle items in the target bundle (specified in the path) with all the bundle items of the source
        /// bundle (specified by the from_bundle_sid body param)
        /// </summary>
        /// <param name="pathBundleSid"> The unique string that identifies the Bundle where the item assignments are going to
        ///                     be replaced </param>
        /// <param name="fromBundleSid"> The source bundle sid to copy the item assignments from </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ReplaceItems </returns>
        public static ReplaceItemsResource Create(string pathBundleSid,
                                                  string fromBundleSid,
                                                  ITwilioRestClient client = null)
        {
            var options = new CreateReplaceItemsOptions(pathBundleSid, fromBundleSid);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Replaces all bundle items in the target bundle (specified in the path) with all the bundle items of the source
        /// bundle (specified by the from_bundle_sid body param)
        /// </summary>
        /// <param name="pathBundleSid"> The unique string that identifies the Bundle where the item assignments are going to
        ///                     be replaced </param>
        /// <param name="fromBundleSid"> The source bundle sid to copy the item assignments from </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ReplaceItems </returns>
        public static async System.Threading.Tasks.Task<ReplaceItemsResource> CreateAsync(string pathBundleSid,
                                                                                          string fromBundleSid,
                                                                                          ITwilioRestClient client = null)
        {
            var options = new CreateReplaceItemsOptions(pathBundleSid, fromBundleSid);
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a ReplaceItemsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ReplaceItemsResource object represented by the provided JSON </returns>
        public static ReplaceItemsResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ReplaceItemsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The unique string of a regulation
        /// </summary>
        [JsonProperty("regulation_sid")]
        public string RegulationSid { get; private set; }
        /// <summary>
        /// The string that you assigned to describe the resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The verification status of the Bundle resource
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ReplaceItemsResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource will be valid until
        /// </summary>
        [JsonProperty("valid_until")]
        public DateTime? ValidUntil { get; private set; }
        /// <summary>
        /// The email address
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; private set; }
        /// <summary>
        /// The URL we call to inform your application of status changes
        /// </summary>
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        private ReplaceItemsResource()
        {

        }
    }

}