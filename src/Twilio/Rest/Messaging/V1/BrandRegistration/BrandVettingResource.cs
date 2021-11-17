/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// BrandVettingResource
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

namespace Twilio.Rest.Messaging.V1.BrandRegistration
{

    public class BrandVettingResource : Resource
    {
        public sealed class VettingProviderEnum : StringEnum
        {
            private VettingProviderEnum(string value) : base(value) {}
            public VettingProviderEnum() {}
            public static implicit operator VettingProviderEnum(string value)
            {
                return new VettingProviderEnum(value);
            }

            public static readonly VettingProviderEnum CampaignVerify = new VettingProviderEnum("campaign-verify");
        }

        private static Request BuildCreateRequest(CreateBrandVettingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Messaging,
                "/v1/a2p/BrandRegistrations/" + options.PathBrandSid + "/Vettings",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create BrandVetting parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandVetting </returns>
        public static BrandVettingResource Create(CreateBrandVettingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create BrandVetting parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandVetting </returns>
        public static async System.Threading.Tasks.Task<BrandVettingResource> CreateAsync(CreateBrandVettingOptions options,
                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathBrandSid"> A2P BrandRegistration Sid </param>
        /// <param name="vettingProvider"> Third-party provider of the vettings to create </param>
        /// <param name="vettingId"> The unique ID of the vetting </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandVetting </returns>
        public static BrandVettingResource Create(string pathBrandSid,
                                                  BrandVettingResource.VettingProviderEnum vettingProvider,
                                                  string vettingId = null,
                                                  ITwilioRestClient client = null)
        {
            var options = new CreateBrandVettingOptions(pathBrandSid, vettingProvider){VettingId = vettingId};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathBrandSid"> A2P BrandRegistration Sid </param>
        /// <param name="vettingProvider"> Third-party provider of the vettings to create </param>
        /// <param name="vettingId"> The unique ID of the vetting </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandVetting </returns>
        public static async System.Threading.Tasks.Task<BrandVettingResource> CreateAsync(string pathBrandSid,
                                                                                          BrandVettingResource.VettingProviderEnum vettingProvider,
                                                                                          string vettingId = null,
                                                                                          ITwilioRestClient client = null)
        {
            var options = new CreateBrandVettingOptions(pathBrandSid, vettingProvider){VettingId = vettingId};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadBrandVettingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                "/v1/a2p/BrandRegistrations/" + options.PathBrandSid + "/Vettings",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read BrandVetting parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandVetting </returns>
        public static ResourceSet<BrandVettingResource> Read(ReadBrandVettingOptions options,
                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<BrandVettingResource>.FromJson("data", response.Content);
            return new ResourceSet<BrandVettingResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read BrandVetting parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandVetting </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<BrandVettingResource>> ReadAsync(ReadBrandVettingOptions options,
                                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<BrandVettingResource>.FromJson("data", response.Content);
            return new ResourceSet<BrandVettingResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathBrandSid"> A2P BrandRegistration Sid </param>
        /// <param name="vettingProvider"> Third-party provider of the vettings to create </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandVetting </returns>
        public static ResourceSet<BrandVettingResource> Read(string pathBrandSid,
                                                             BrandVettingResource.VettingProviderEnum vettingProvider = null,
                                                             int? pageSize = null,
                                                             long? limit = null,
                                                             ITwilioRestClient client = null)
        {
            var options = new ReadBrandVettingOptions(pathBrandSid){VettingProvider = vettingProvider, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathBrandSid"> A2P BrandRegistration Sid </param>
        /// <param name="vettingProvider"> Third-party provider of the vettings to create </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandVetting </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<BrandVettingResource>> ReadAsync(string pathBrandSid,
                                                                                                     BrandVettingResource.VettingProviderEnum vettingProvider = null,
                                                                                                     int? pageSize = null,
                                                                                                     long? limit = null,
                                                                                                     ITwilioRestClient client = null)
        {
            var options = new ReadBrandVettingOptions(pathBrandSid){VettingProvider = vettingProvider, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<BrandVettingResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<BrandVettingResource>.FromJson("data", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<BrandVettingResource> NextPage(Page<BrandVettingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Messaging)
            );

            var response = client.Request(request);
            return Page<BrandVettingResource>.FromJson("data", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<BrandVettingResource> PreviousPage(Page<BrandVettingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Messaging)
            );

            var response = client.Request(request);
            return Page<BrandVettingResource>.FromJson("data", response.Content);
        }

        private static Request BuildFetchRequest(FetchBrandVettingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                "/v1/a2p/BrandRegistrations/" + options.PathBrandSid + "/Vettings/" + options.PathBrandVettingSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch BrandVetting parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandVetting </returns>
        public static BrandVettingResource Fetch(FetchBrandVettingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch BrandVetting parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandVetting </returns>
        public static async System.Threading.Tasks.Task<BrandVettingResource> FetchAsync(FetchBrandVettingOptions options,
                                                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathBrandSid"> A2P BrandRegistration Sid </param>
        /// <param name="pathBrandVettingSid"> SID for third-party vetting record </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandVetting </returns>
        public static BrandVettingResource Fetch(string pathBrandSid,
                                                 string pathBrandVettingSid,
                                                 ITwilioRestClient client = null)
        {
            var options = new FetchBrandVettingOptions(pathBrandSid, pathBrandVettingSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathBrandSid"> A2P BrandRegistration Sid </param>
        /// <param name="pathBrandVettingSid"> SID for third-party vetting record </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandVetting </returns>
        public static async System.Threading.Tasks.Task<BrandVettingResource> FetchAsync(string pathBrandSid,
                                                                                         string pathBrandVettingSid,
                                                                                         ITwilioRestClient client = null)
        {
            var options = new FetchBrandVettingOptions(pathBrandSid, pathBrandVettingSid);
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a BrandVettingResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BrandVettingResource object represented by the provided JSON </returns>
        public static BrandVettingResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<BrandVettingResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the vetting
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// A2P BrandRegistration Sid
        /// </summary>
        [JsonProperty("brand_sid")]
        public string BrandSid { get; private set; }
        /// <summary>
        /// SID for third-party vetting record
        /// </summary>
        [JsonProperty("brand_vetting_sid")]
        public string BrandVettingSid { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The unique ID of the vetting
        /// </summary>
        [JsonProperty("vetting_id")]
        public string VettingId { get; private set; }
        /// <summary>
        /// The type of vetting
        /// </summary>
        [JsonProperty("vetting_class")]
        public string VettingClass { get; private set; }
        /// <summary>
        /// Status of vetting attempt
        /// </summary>
        [JsonProperty("vetting_status")]
        public string VettingStatus { get; private set; }
        /// <summary>
        /// Third-party provider that has conducted the vetting
        /// </summary>
        [JsonProperty("vetting_provider")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BrandVettingResource.VettingProviderEnum VettingProvider { get; private set; }
        /// <summary>
        /// The absolute URL of the Brand Vetting
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private BrandVettingResource()
        {

        }
    }

}