using System.Text.Json.Serialization;

namespace NicoNicoNii.Entities.JSON;

public class SessionKeepAlive
{
	[JsonPropertyName("niconico_response")]
	public NiconicoResponseClass NiconicoResponse { get; set; }

	public class NiconicoResponseClass
	{
		[JsonPropertyName("@status")]
		public string Status { get; set; }
		[JsonPropertyName("error")]
		public ErrorClass Error { get; set; }
	}

	public class ErrorClass
	{
		[JsonPropertyName("code")]
		public string Code { get; set; }
		[JsonPropertyName("description")]
		public string Description { get; set; }
	}

}
