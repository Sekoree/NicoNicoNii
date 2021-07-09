using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NicoNicoNii.Entities.JSON.Video
{
    //POST
    public class SessionCreate
    {
        [JsonPropertyName("session")]
        public SessionClass Session { get; set; } = new();

        public partial class SessionClass
        {
            [JsonPropertyName("recipe_id")]
            public string RecipeId { get; set; }

            [JsonPropertyName("content_id")]
            public string ContentId { get; set; }

            [JsonPropertyName("content_type")]
            public string ContentType { get; set; }

            [JsonPropertyName("content_src_id_sets")]
            public List<ContentSrcIdSet> ContentSrcIdSets { get; set; } = new();

            [JsonPropertyName("timing_constraint")]
            public string TimingConstraint { get; set; }

            [JsonPropertyName("keep_method")]
            public KeepMethod KeepMethod { get; set; } = new();

            [JsonPropertyName("protocol")]
            public Protocol Protocol { get; set; } = new();

            [JsonPropertyName("content_uri")]
            public string ContentUri { get; set; }

            [JsonPropertyName("session_operation_auth")]
            public SessionOperationAuth SessionOperationAuth { get; set; } = new();

            [JsonPropertyName("content_auth")]
            public ContentAuth ContentAuth { get; set; } = new();

            [JsonPropertyName("client_info")]
            public ClientInfo ClientInfo { get; set; } = new();

            [JsonPropertyName("priority")]
            public double? Priority { get; set; }
        }

        public partial class ClientInfo
        {
            [JsonPropertyName("player_id")]
            public string PlayerId { get; set; }
        }

        public partial class ContentAuth
        {
            [JsonPropertyName("auth_type")]
            public string AuthType { get; set; }

            [JsonPropertyName("content_key_timeout")]
            public long? ContentKeyTimeout { get; set; }

            [JsonPropertyName("service_id")]
            public string ServiceId { get; set; }

            [JsonPropertyName("service_user_id")]
            public string ServiceUserId { get; set; }
        }

        public partial class ContentSrcIdSet
        {
            [JsonPropertyName("content_src_ids")]
            public List<ContentSrcId> ContentSrcIds { get; set; } = new();
        }

        public partial class ContentSrcId
        {
            [JsonPropertyName("src_id_to_mux")]
            public SrcIdToMux SrcIdToMux { get; set; } = new();
        }

        public partial class SrcIdToMux
        {
            [JsonPropertyName("video_src_ids")]
            public List<string> VideoSrcIds { get; set; } = new();

            [JsonPropertyName("audio_src_ids")]
            public List<string> AudioSrcIds { get; set; } = new();
        }

        public partial class KeepMethod
        {
            [JsonPropertyName("heartbeat")]
            public Heartbeat Heartbeat { get; set; } = new();
        }

        public partial class Heartbeat
        {
            [JsonPropertyName("lifetime")]
            public long? Lifetime { get; set; }
        }

        public partial class Protocol
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("parameters")]
            public ProtocolParameters Parameters { get; set; } = new();
        }

        public partial class ProtocolParameters
        {
            [JsonPropertyName("http_parameters")]
            public HttpParameters HttpParameters { get; set; } = new();
        }

        public partial class HttpParameters
        {
            [JsonPropertyName("parameters")]
            public HttpParametersParameters Parameters { get; set; } = new();
        }

        public partial class HttpParametersParameters
        {
            [JsonPropertyName("http_output_download_parameters")]
            public HttpOutputDownloadParameters HttpOutputDownloadParameters { get; set; } = new();
        }

        public partial class HttpOutputDownloadParameters
        {
            [JsonPropertyName("use_well_known_port")]
            public string UseWellKnownPort { get; set; }

            [JsonPropertyName("use_ssl")]
            public string UseSsl { get; set; }

            [JsonPropertyName("transfer_preset")]
            public string TransferPreset { get; set; }
        }

        public partial class SessionOperationAuth
        {
            [JsonPropertyName("session_operation_auth_by_signature")]
            public SessionOperationAuthBySignature SessionOperationAuthBySignature { get; set; } = new();
        }

        public partial class SessionOperationAuthBySignature
        {
            [JsonPropertyName("token")]
            public string Token { get; set; }

            [JsonPropertyName("signature")]
            public string Signature { get; set; }
        }
    }
}
