using System.Text.Json.Serialization;

namespace NicoNicoNii.Entities.JSON.Video;

//POST
//https://api.dmc.nico/api/sessions?_format=json
//HTTP Protocol
public class SessionCreateHTTP
{
	public SessionCreateHTTP(WatchPageData watchPage, string[] audioQuality, string[] videoQuality, bool loggedIn)
	{
		this.Session.RecipeId = watchPage.Media.Delivery.RecipeId;
		this.Session.ContentId = watchPage.Media.Delivery.Movie.ContentId;
		this.Session.ContentType = "movie";

		this.Session.ContentSrcIdSets = new[]
		{
			new ContentSrcIdSet
			{
				ContentSrcIds = new[]
				{
					new ContentSrcId()
					{
						SrcIdToMux = new SrcIdToMux
						{
							AudioSrcIds = audioQuality,
							VideoSrcIds = videoQuality
						}
					}
				}
			}
		};

		this.Session.TimingConstraint = "unlimited";

		this.Session.KeepMethod.Heartbeat.Lifetime = watchPage.Media.Delivery.Movie.Session.HeartbeatLifetime;

		this.Session.Protocol.Name = watchPage.Media.Delivery.Movie.Session.Protocols[0];
		this.Session.Protocol.Parameters.HttpParameters.Parameters.HttpOutputDownloadParameters.UseWellKnownPort =
			watchPage.Media.Delivery.Movie.Session.Urls[0].IsWellKnownPort == true ? "yes" : "no";

		this.Session.Protocol.Parameters.HttpParameters.Parameters.HttpOutputDownloadParameters.UseSsl =
			watchPage.Media.Delivery.Movie.Session.Urls[0].IsSsl == true ? "yes" : "no";

		this.Session.Protocol.Parameters.HttpParameters.Parameters.HttpOutputDownloadParameters.TransferPreset =
			"";

		this.Session.ContentUri = "";

		this.Session.SessionOperationAuth.SessionOperationAuthBySignature.Token = watchPage.Media.Delivery.Movie.Session.Token;
		this.Session.SessionOperationAuth.SessionOperationAuthBySignature.Signature = watchPage.Media.Delivery.Movie.Session.Signature;

		this.Session.ContentAuth.AuthType = "ht2";
		this.Session.ContentAuth.ContentKeyTimeout = watchPage.Media.Delivery.Movie.Session.ContentKeyTimeout;
		this.Session.ContentAuth.ServiceId = "nicovideo";
		this.Session.ContentAuth.ServiceUserId = watchPage.Media.Delivery.Movie.Session.ServiceUserId;

		this.Session.ClientInfo.PlayerId = watchPage.Media.Delivery.Movie.Session.PlayerId;
		this.Session.Priority = loggedIn ? 0.8 : 0;
	}

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
		public ContentSrcIdSet[] ContentSrcIdSets { get; set; }

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
		public ContentSrcId[] ContentSrcIds { get; set; }
	}

	public partial class ContentSrcId
	{
		[JsonPropertyName("src_id_to_mux")]
		public SrcIdToMux SrcIdToMux { get; set; } = new();
	}

	public partial class SrcIdToMux
	{
		[JsonPropertyName("video_src_ids")]
		public IEnumerable<string> VideoSrcIds { get; set; }

		[JsonPropertyName("audio_src_ids")]
		public IEnumerable<string> AudioSrcIds { get; set; }
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
