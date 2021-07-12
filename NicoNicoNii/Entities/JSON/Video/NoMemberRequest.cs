using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NicoNicoNii.Entities.JSON.Video
{
    public class NoMemberRequest
    {
        public NoMemberRequest(WatchPageData watchPageData)
        {
            this.EventType = "start";
            this.EventOccurredAt = DateTimeOffset.UtcNow;

            //Todo: Probably in WatchData
            this.WatchTrackId = watchPageData.Client.WatchTrackId;
            this.ContentId = watchPageData.Client.WatchId;
            this.ContentType = "video";
            this.WatchMilliseconds = 0;
            this.EndCount = 0;

            this.AdditionalParameters.PlayerType = "html5";
            this.AdditionalParameters.StartReason = "transition";
            //Todo: WatchData PlayerID maybe
            this.AdditionalParameters.Nicosid = watchPageData.Client.Nicosid;
            this.AdditionalParameters.LoadFailed = false;

            this.AdditionalParameters.Performance.WatchAccessStart = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            this.AdditionalParameters.Performance.CommentLoadingStart = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

            this.AdditionalParameters.Performance.EndContext.AdPlaying = false;
            this.AdditionalParameters.Performance.EndContext.VideoPlaying = false;
            this.AdditionalParameters.Performance.EndContext.IsSuspending = false;

            this.AdditionalParameters.IsAutoPlay = false;
            this.AdditionalParameters.IsAdBlock = false;
            this.AdditionalParameters.IsDmcPlay = false;
            this.AdditionalParameters.IsDmcContent = false;
            this.AdditionalParameters.PauseCount = 0;
            this.AdditionalParameters.LoopCount = 0;
            this.AdditionalParameters.PlaybackRate = "1.0";
            this.AdditionalParameters.SuspendCount = 0;
            this.AdditionalParameters.AutoQualitychangeCount = 0;
            this.AdditionalParameters.UseFlip = false;
            this.AdditionalParameters.PerformanceSetting = "normal";
            this.AdditionalParameters.EventTimeMs = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            this.AdditionalParameters.ViewingSource = "";
        }

        [JsonPropertyName("eventType")]
        public string EventType { get; set; }

        [JsonPropertyName("eventOccurredAt")]
        public DateTimeOffset? EventOccurredAt { get; set; }

        [JsonPropertyName("watchTrackId")]
        public string WatchTrackId { get; set; }

        [JsonPropertyName("contentId")]
        public string ContentId { get; set; }

        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("watchMilliseconds")]
        public long? WatchMilliseconds { get; set; }

        [JsonPropertyName("endCount")]
        public long? EndCount { get; set; }

        [JsonPropertyName("additionalParameters")]
        public AdditionalParametersClass AdditionalParameters { get; set; } = new();

        public partial class AdditionalParametersClass
        {
            [JsonPropertyName("player_type")]
            public string PlayerType { get; set; }

            [JsonPropertyName("start_reason")]
            public string StartReason { get; set; }

            [JsonPropertyName("end_reason")]
            public object EndReason { get; set; }

            [JsonPropertyName("nicosid")]
            public string Nicosid { get; set; }

            [JsonPropertyName("referer")]
            public object Referer { get; set; }

            [JsonPropertyName("load_time")]
            public object LoadTime { get; set; }

            [JsonPropertyName("load_failed")]
            public bool? LoadFailed { get; set; }

            [JsonPropertyName("performance")]
            public Performance Performance { get; set; } = new();

            [JsonPropertyName("is_auto_play")]
            public bool? IsAutoPlay { get; set; }

            [JsonPropertyName("is_ad_block")]
            public bool? IsAdBlock { get; set; }

            [JsonPropertyName("is_dmc_play")]
            public bool? IsDmcPlay { get; set; }

            [JsonPropertyName("is_dmc_content")]
            public bool? IsDmcContent { get; set; }

            [JsonPropertyName("pause_count")]
            public long? PauseCount { get; set; }

            [JsonPropertyName("loop_count")]
            public long? LoopCount { get; set; }

            [JsonPropertyName("playback_rate")]
            public string PlaybackRate { get; set; }

            [JsonPropertyName("protocol")]
            public List<object> Protocol { get; set; } = new();

            [JsonPropertyName("suspend_count")]
            public long? SuspendCount { get; set; }

            [JsonPropertyName("quality")]
            public List<object> Quality { get; set; } = new();

            [JsonPropertyName("auto_quality")]
            public List<object> AutoQuality { get; set; } = new();

            [JsonPropertyName("auto_start_quality")]
            public object AutoStartQuality { get; set; }

            [JsonPropertyName("auto_qualitychange_count")]
            public long? AutoQualitychangeCount { get; set; }

            [JsonPropertyName("highest_quality")]
            public object HighestQuality { get; set; }

            [JsonPropertyName("transfer_rate_kbps")]
            public object TransferRateKbps { get; set; }

            [JsonPropertyName("error_description")]
            public object ErrorDescription { get; set; }

            [JsonPropertyName("use_flip")]
            public bool? UseFlip { get; set; }

            [JsonPropertyName("suspend_timing")]
            public List<object> SuspendTiming { get; set; } = new();

            [JsonPropertyName("performance_setting")]
            public string PerformanceSetting { get; set; }

            [JsonPropertyName("end_position_milliseconds")]
            public object EndPositionMilliseconds { get; set; }

            [JsonPropertyName("event_time_ms")]
            public long? EventTimeMs { get; set; }

            [JsonPropertyName("query_parameters")]
            public QueryParameters QueryParameters { get; set; } = new();

            [JsonPropertyName("viewing_source")]
            public string ViewingSource { get; set; }

            [JsonPropertyName("viewing_source_detail")]
            public QueryParameters ViewingSourceDetail { get; set; } = new();
        }

        public partial class Performance
        {
            [JsonPropertyName("watch_access_start")]
            public long? WatchAccessStart { get; set; }

            [JsonPropertyName("watch_access_finish")]
            public object WatchAccessFinish { get; set; }

            [JsonPropertyName("overlay_thumbnail_finish")]
            public object OverlayThumbnailFinish { get; set; }

            [JsonPropertyName("comment_loading_start")]
            public long? CommentLoadingStart { get; set; }

            [JsonPropertyName("comment_loading_finish")]
            public object CommentLoadingFinish { get; set; }

            [JsonPropertyName("comment_load_failed_reason")]
            public object CommentLoadFailedReason { get; set; }

            [JsonPropertyName("video_loading_start")]
            public object VideoLoadingStart { get; set; }

            [JsonPropertyName("video_loading_finish")]
            public object VideoLoadingFinish { get; set; }

            [JsonPropertyName("video_load_failed_reason")]
            public object VideoLoadFailedReason { get; set; }

            [JsonPropertyName("video_play_start")]
            public object VideoPlayStart { get; set; }

            [JsonPropertyName("end_context")]
            public EndContext EndContext { get; set; } = new();
        }

        public partial class EndContext
        {
            [JsonPropertyName("ad_playing")]
            public bool? AdPlaying { get; set; }

            [JsonPropertyName("video_playing")]
            public bool? VideoPlaying { get; set; }

            [JsonPropertyName("is_suspending")]
            public bool? IsSuspending { get; set; }
        }

        public partial class QueryParameters
        {
        }
    }
}

