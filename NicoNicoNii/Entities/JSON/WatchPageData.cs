using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NicoNicoNii.Entities.JSON
{
    public class WatchPageData
    {
        [JsonPropertyName("ads")]
        public object Ads { get; set; }

        [JsonPropertyName("category")]
        public object Category { get; set; }

        [JsonPropertyName("channel")]
        public object Channel { get; set; }

        [JsonPropertyName("client")]
        public ClientClass Client { get; set; }

        [JsonPropertyName("comment")]
        public TemperaturesComment Comment { get; set; }

        [JsonPropertyName("community")]
        public CommunityClass Community { get; set; }

        [JsonPropertyName("easyComment")]
        public EasyCommentClass EasyComment { get; set; }

        [JsonPropertyName("external")]
        public ExternalClass External { get; set; }

        [JsonPropertyName("genre")]
        public TemperaturesGenre Genre { get; set; }

        [JsonPropertyName("marquee")]
        public MarqueeClass Marquee { get; set; }

        [JsonPropertyName("media")]
        public MediaClass Media { get; set; }

        [JsonPropertyName("okReason")]
        public string OkReason { get; set; }

        [JsonPropertyName("owner")]
        public TemperaturesOwner Owner { get; set; }

        [JsonPropertyName("payment")]
        public PaymentClass Payment { get; set; }

        [JsonPropertyName("pcWatchPage")]
        public PcWatchPageClass PcWatchPage { get; set; }

        [JsonPropertyName("player")]
        public PlayerClass Player { get; set; }

        [JsonPropertyName("ppv")]
        public object Ppv { get; set; }

        [JsonPropertyName("ranking")]
        public RankingClass Ranking { get; set; }

        [JsonPropertyName("series")]
        public SeriesClass Series { get; set; }

        [JsonPropertyName("smartphone")]
        public object Smartphone { get; set; }

        [JsonPropertyName("system")]
        public SystemClass System { get; set; }

        [JsonPropertyName("tag")]
        public TagClass Tag { get; set; }

        [JsonPropertyName("video")]
        public TemperaturesVideo Video { get; set; }

        [JsonPropertyName("videoAds")]
        public VideoAdsClass VideoAds { get; set; }

        [JsonPropertyName("videoLive")]
        public object VideoLive { get; set; }

        [JsonPropertyName("viewer")]
        public TemperaturesViewer Viewer { get; set; }

        [JsonPropertyName("waku")]
        public WakuClass Waku { get; set; }

        public partial class ClientClass
        {
            [JsonPropertyName("nicosid")]
            public string Nicosid { get; set; }

            [JsonPropertyName("watchId")]
            public string WatchId { get; set; }

            [JsonPropertyName("watchTrackId")]
            public string WatchTrackId { get; set; }
        }

        public partial class TemperaturesComment
        {
            [JsonPropertyName("server")]
            public Server Server { get; set; }

            [JsonPropertyName("keys")]
            public Keys Keys { get; set; }

            [JsonPropertyName("layers")]
            public List<Layer> Layers { get; set; } = new();

            [JsonPropertyName("threads")]
            public List<Thread> Threads { get; set; } = new();

            [JsonPropertyName("ng")]
            public Ng Ng { get; set; }

            [JsonPropertyName("isAttentionRequired")]
            public bool? IsAttentionRequired { get; set; }
        }

        public partial class Keys
        {
            [JsonPropertyName("userKey")]
            public string UserKey { get; set; }
        }

        public partial class Layer
        {
            [JsonPropertyName("index")]
            public long? Index { get; set; }

            [JsonPropertyName("isTranslucent")]
            public bool? IsTranslucent { get; set; }

            [JsonPropertyName("threadIds")]
            public List<ThreadId> ThreadIds { get; set; } = new();
        }

        public partial class ThreadId
        {
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            [JsonPropertyName("fork")]
            public long? Fork { get; set; }
        }

        public partial class Ng
        {
            [JsonPropertyName("ngScore")]
            public NgScore NgScore { get; set; }

            [JsonPropertyName("channel")]
            public List<object> Channel { get; set; } = new();

            [JsonPropertyName("owner")]
            public List<object> Owner { get; set; } = new();

            [JsonPropertyName("viewer")]
            public NgViewer Viewer { get; set; }
        }

        public partial class NgScore
        {
            [JsonPropertyName("isDisabled")]
            public bool? IsDisabled { get; set; }
        }

        public partial class NgViewer
        {
            [JsonPropertyName("revision")]
            public long? Revision { get; set; }

            [JsonPropertyName("count")]
            public long? Count { get; set; }

            [JsonPropertyName("items")]
            public List<object> Items { get; set; } = new();
        }

        public partial class Server
        {
            [JsonPropertyName("url")]
            public Uri Url { get; set; }
        }

        public partial class Thread
        {
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            [JsonPropertyName("fork")]
            public long? Fork { get; set; }

            [JsonPropertyName("isActive")]
            public bool? IsActive { get; set; }

            [JsonPropertyName("isDefaultPostTarget")]
            public bool? IsDefaultPostTarget { get; set; }

            [JsonPropertyName("isEasyCommentPostTarget")]
            public bool? IsEasyCommentPostTarget { get; set; }

            [JsonPropertyName("isLeafRequired")]
            public bool? IsLeafRequired { get; set; }

            [JsonPropertyName("isOwnerThread")]
            public bool? IsOwnerThread { get; set; }

            [JsonPropertyName("isThreadkeyRequired")]
            public bool? IsThreadkeyRequired { get; set; }

            [JsonPropertyName("threadkey")]
            public object Threadkey { get; set; }

            [JsonPropertyName("is184Forced")]
            public bool? Is184Forced { get; set; }

            [JsonPropertyName("hasNicoscript")]
            public bool? HasNicoscript { get; set; }

            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonPropertyName("postkeyStatus")]
            public long? PostkeyStatus { get; set; }

            [JsonPropertyName("server")]
            public Uri Server { get; set; }
        }

        public partial class CommunityClass
        {
            [JsonPropertyName("main")]
            public Main Main { get; set; }

            [JsonPropertyName("belong")]
            public object Belong { get; set; }
        }

        public partial class Main
        {
            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }
        }

        public partial class EasyCommentClass
        {
            [JsonPropertyName("phrases")]
            public List<Phrase> Phrases { get; set; } = new();
        }

        public partial class Phrase
        {
            [JsonPropertyName("text")]
            public string Text { get; set; }

            [JsonPropertyName("nicodic")]
            public Nicodic Nicodic { get; set; }
        }

        public partial class Nicodic
        {
            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("viewTitle")]
            public string ViewTitle { get; set; }

            [JsonPropertyName("summary")]
            public string Summary { get; set; }

            [JsonPropertyName("link")]
            public Uri Link { get; set; }
        }

        public partial class ExternalClass
        {
            [JsonPropertyName("commons")]
            public Commons Commons { get; set; }

            [JsonPropertyName("ichiba")]
            public Ichiba Ichiba { get; set; }
        }

        public partial class Commons
        {
            [JsonPropertyName("hasContentTree")]
            public bool? HasContentTree { get; set; }
        }

        public partial class Ichiba
        {
            [JsonPropertyName("isEnabled")]
            public bool? IsEnabled { get; set; }
        }

        public partial class TemperaturesGenre
        {
            [JsonPropertyName("key")]
            public string Key { get; set; }

            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonPropertyName("isImmoral")]
            public bool? IsImmoral { get; set; }

            [JsonPropertyName("isDisabled")]
            public bool? IsDisabled { get; set; }

            [JsonPropertyName("isNotSet")]
            public bool? IsNotSet { get; set; }
        }

        public partial class MarqueeClass
        {
            [JsonPropertyName("isDisabled")]
            public bool? IsDisabled { get; set; }

            [JsonPropertyName("tagRelatedLead")]
            public object TagRelatedLead { get; set; }
        }

        public partial class MediaClass
        {
            [JsonPropertyName("delivery")]
            public Delivery Delivery { get; set; }

            [JsonPropertyName("deliveryLegacy")]
            public object DeliveryLegacy { get; set; }
        }

        public partial class Delivery
        {
            [JsonPropertyName("recipeId")]
            public string RecipeId { get; set; }

            [JsonPropertyName("encryption")]
            public object Encryption { get; set; }

            [JsonPropertyName("movie")]
            public Movie Movie { get; set; }

            [JsonPropertyName("storyboard")]
            public Storyboard Storyboard { get; set; }

            [JsonPropertyName("trackingId")]
            public string TrackingId { get; set; }
        }

        public partial class Movie
        {
            [JsonPropertyName("contentId")]
            public string ContentId { get; set; }

            [JsonPropertyName("audios")]
            public List<Audio> Audios { get; set; } = new();

            [JsonPropertyName("videos")]
            public List<VideoElement> Videos { get; set; } = new();

            [JsonPropertyName("session")]
            public MovieSession Session { get; set; }
        }

        public partial class Audio
        {
            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("isAvailable")]
            public bool? IsAvailable { get; set; }

            [JsonPropertyName("metadata")]
            public AudioMetadata Metadata { get; set; }
        }

        public partial class AudioMetadata
        {
            [JsonPropertyName("bitrate")]
            public long? Bitrate { get; set; }

            [JsonPropertyName("samplingRate")]
            public long? SamplingRate { get; set; }

            [JsonPropertyName("loudness")]
            public Loudness Loudness { get; set; }

            [JsonPropertyName("levelIndex")]
            public long? LevelIndex { get; set; }

            [JsonPropertyName("loudnessCollection")]
            public List<LoudnessCollection> LoudnessCollection { get; set; } = new();
        }

        public partial class Loudness
        {
            [JsonPropertyName("integratedLoudness")]
            public double? IntegratedLoudness { get; set; }

            [JsonPropertyName("truePeak")]
            public double? TruePeak { get; set; }
        }

        public partial class LoudnessCollection
        {
            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("value")]
            public double? Value { get; set; }
        }

        public partial class MovieSession
        {
            [JsonPropertyName("recipeId")]
            public string RecipeId { get; set; }

            [JsonPropertyName("playerId")]
            public string PlayerId { get; set; }

            [JsonPropertyName("videos")]
            public List<string> Videos { get; set; } = new();

            [JsonPropertyName("audios")]
            public List<string> Audios { get; set; } = new();

            [JsonPropertyName("movies")]
            public List<object> Movies { get; set; } = new();

            [JsonPropertyName("protocols")]
            public List<string> Protocols { get; set; } = new();

            [JsonPropertyName("authTypes")]
            public PurpleAuthTypes AuthTypes { get; set; }

            [JsonPropertyName("serviceUserId")]
            public string ServiceUserId { get; set; }

            [JsonPropertyName("token")]
            public string Token { get; set; }

            [JsonPropertyName("signature")]
            public string Signature { get; set; }

            [JsonPropertyName("contentId")]
            public string ContentId { get; set; }

            [JsonPropertyName("heartbeatLifetime")]
            public long? HeartbeatLifetime { get; set; }

            [JsonPropertyName("contentKeyTimeout")]
            public long? ContentKeyTimeout { get; set; }

            [JsonPropertyName("priority")]
            public double? Priority { get; set; }

            [JsonPropertyName("transferPresets")]
            public List<string> TransferPresets { get; set; } = new();

            [JsonPropertyName("urls")]
            public List<Url> Urls { get; set; } = new();
        }

        public partial class PurpleAuthTypes
        {
            [JsonPropertyName("http")]
            public string Http { get; set; }

            [JsonPropertyName("hls")]
            public string Hls { get; set; }
        }

        public partial class Url
        {
            [JsonPropertyName("url")]
            public Uri UrlUrl { get; set; }

            [JsonPropertyName("isWellKnownPort")]
            public bool? IsWellKnownPort { get; set; }

            [JsonPropertyName("isSsl")]
            public bool? IsSsl { get; set; }
        }

        public partial class VideoElement
        {
            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("isAvailable")]
            public bool? IsAvailable { get; set; }

            [JsonPropertyName("metadata")]
            public VideoMetadata Metadata { get; set; }
        }

        public partial class VideoMetadata
        {
            [JsonPropertyName("label")]
            public string Label { get; set; }

            [JsonPropertyName("bitrate")]
            public long? Bitrate { get; set; }

            [JsonPropertyName("resolution")]
            public Resolution Resolution { get; set; }

            [JsonPropertyName("levelIndex")]
            public long? LevelIndex { get; set; }

            [JsonPropertyName("recommendedHighestAudioLevelIndex")]
            public long? RecommendedHighestAudioLevelIndex { get; set; }
        }

        public partial class Resolution
        {
            [JsonPropertyName("width")]
            public long? Width { get; set; }

            [JsonPropertyName("height")]
            public long? Height { get; set; }
        }

        public partial class Storyboard
        {
            [JsonPropertyName("contentId")]
            public string ContentId { get; set; }

            [JsonPropertyName("images")]
            public List<Image> Images { get; set; } = new();

            [JsonPropertyName("session")]
            public StoryboardSession Session { get; set; }
        }

        public partial class Image
        {
            [JsonPropertyName("id")]
            public string Id { get; set; }
        }

        public partial class StoryboardSession
        {
            [JsonPropertyName("recipeId")]
            public string RecipeId { get; set; }

            [JsonPropertyName("playerId")]
            public string PlayerId { get; set; }

            [JsonPropertyName("videos")]
            public List<string> Videos { get; set; } = new();

            [JsonPropertyName("audios")]
            public List<object> Audios { get; set; } = new();

            [JsonPropertyName("movies")]
            public List<object> Movies { get; set; } = new();

            [JsonPropertyName("protocols")]
            public List<string> Protocols { get; set; } = new();

            [JsonPropertyName("authTypes")]
            public FluffyAuthTypes AuthTypes { get; set; }

            [JsonPropertyName("serviceUserId")]
            public string ServiceUserId { get; set; }

            [JsonPropertyName("token")]
            public string Token { get; set; }

            [JsonPropertyName("signature")]
            public string Signature { get; set; }

            [JsonPropertyName("contentId")]
            public string ContentId { get; set; }

            [JsonPropertyName("heartbeatLifetime")]
            public long? HeartbeatLifetime { get; set; }

            [JsonPropertyName("contentKeyTimeout")]
            public long? ContentKeyTimeout { get; set; }

            [JsonPropertyName("priority")]
            public double? Priority { get; set; }

            [JsonPropertyName("transferPresets")]
            public List<object> TransferPresets { get; set; } = new();

            [JsonPropertyName("urls")]
            public List<Url> Urls { get; set; } = new();
        }

        public partial class FluffyAuthTypes
        {
            [JsonPropertyName("storyboard")]
            public string Storyboard { get; set; }
        }

        public partial class TemperaturesOwner
        {
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            [JsonPropertyName("nickname")]
            public string Nickname { get; set; }

            [JsonPropertyName("iconUrl")]
            public Uri IconUrl { get; set; }

            [JsonPropertyName("channel")]
            public object Channel { get; set; }

            [JsonPropertyName("live")]
            public object Live { get; set; }

            [JsonPropertyName("isVideosPublic")]
            public bool? IsVideosPublic { get; set; }

            [JsonPropertyName("isMylistsPublic")]
            public bool? IsMylistsPublic { get; set; }

            [JsonPropertyName("videoLiveNotice")]
            public object VideoLiveNotice { get; set; }

            [JsonPropertyName("viewer")]
            public OwnerViewer Viewer { get; set; }
        }

        public partial class OwnerViewer
        {
            [JsonPropertyName("isFollowing")]
            public bool? IsFollowing { get; set; }
        }

        public partial class PaymentClass
        {
            [JsonPropertyName("video")]
            public PaymentVideo Video { get; set; }

            [JsonPropertyName("preview")]
            public Preview Preview { get; set; }
        }

        public partial class Preview
        {
            [JsonPropertyName("ppv")]
            public Ichiba Ppv { get; set; }

            [JsonPropertyName("admission")]
            public Ichiba Admission { get; set; }

            [JsonPropertyName("premium")]
            public Ichiba Premium { get; set; }
        }

        public partial class PaymentVideo
        {
            [JsonPropertyName("isPpv")]
            public bool? IsPpv { get; set; }

            [JsonPropertyName("isAdmission")]
            public bool? IsAdmission { get; set; }

            [JsonPropertyName("isPremium")]
            public bool? IsPremium { get; set; }

            [JsonPropertyName("watchableUserType")]
            public string WatchableUserType { get; set; }

            [JsonPropertyName("commentableUserType")]
            public string CommentableUserType { get; set; }
        }

        public partial class PcWatchPageClass
        {
            [JsonPropertyName("tagRelatedBanner")]
            public object TagRelatedBanner { get; set; }

            [JsonPropertyName("videoEnd")]
            public VideoEnd VideoEnd { get; set; }

            [JsonPropertyName("showOwnerMenu")]
            public bool? ShowOwnerMenu { get; set; }

            [JsonPropertyName("showOwnerThreadCoEditingLink")]
            public bool? ShowOwnerThreadCoEditingLink { get; set; }

            [JsonPropertyName("showMymemoryEditingLink")]
            public bool? ShowMymemoryEditingLink { get; set; }
        }

        public partial class VideoEnd
        {
            [JsonPropertyName("bannerIn")]
            public object BannerIn { get; set; }

            [JsonPropertyName("overlay")]
            public object Overlay { get; set; }
        }

        public partial class PlayerClass
        {
            [JsonPropertyName("initialPlayback")]
            public InitialPlayback InitialPlayback { get; set; }

            [JsonPropertyName("comment")]
            public PlayerComment Comment { get; set; }

            [JsonPropertyName("layerMode")]
            public long? LayerMode { get; set; }
        }

        public partial class PlayerComment
        {
            [JsonPropertyName("isDefaultInvisible")]
            public bool? IsDefaultInvisible { get; set; }
        }

        public partial class InitialPlayback
        {
            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("positionSec")]
            public long? PositionSec { get; set; }
        }

        public partial class RankingClass
        {
            [JsonPropertyName("genre")]
            public RankingGenre Genre { get; set; }

            [JsonPropertyName("popularTag")]
            public List<PopularTag> PopularTag { get; set; } = new();
        }

        public partial class RankingGenre
        {
            [JsonPropertyName("rank")]
            public long? Rank { get; set; }

            [JsonPropertyName("genre")]
            public string Genre { get; set; }

            [JsonPropertyName("dateTime")]
            public DateTimeOffset? DateTime { get; set; }
        }

        public partial class PopularTag
        {
            [JsonPropertyName("tag")]
            public string Tag { get; set; }

            [JsonPropertyName("regularizedTag")]
            public string RegularizedTag { get; set; }

            [JsonPropertyName("rank")]
            public long? Rank { get; set; }

            [JsonPropertyName("genre")]
            public string Genre { get; set; }

            [JsonPropertyName("dateTime")]
            public DateTimeOffset? DateTime { get; set; }
        }

        public partial class SeriesClass
        {
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("description")]
            public string Description { get; set; }

            [JsonPropertyName("thumbnailUrl")]
            public Uri ThumbnailUrl { get; set; }

            [JsonPropertyName("video")]
            public SeriesVideo Video { get; set; }
        }

        public partial class SeriesVideo
        {
            [JsonPropertyName("prev")]
            public First Prev { get; set; }

            [JsonPropertyName("next")]
            public First Next { get; set; }

            [JsonPropertyName("first")]
            public First First { get; set; }
        }

        public partial class First
        {
            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("registeredAt")]
            public DateTimeOffset? RegisteredAt { get; set; }

            [JsonPropertyName("count")]
            public Count Count { get; set; }

            [JsonPropertyName("thumbnail")]
            public FirstThumbnail Thumbnail { get; set; }

            [JsonPropertyName("duration")]
            public long? Duration { get; set; }

            [JsonPropertyName("shortDescription")]
            public string ShortDescription { get; set; }

            [JsonPropertyName("latestCommentSummary")]
            public string LatestCommentSummary { get; set; }

            [JsonPropertyName("isChannelVideo")]
            public bool? IsChannelVideo { get; set; }

            [JsonPropertyName("isPaymentRequired")]
            public bool? IsPaymentRequired { get; set; }

            [JsonPropertyName("playbackPosition")]
            public object PlaybackPosition { get; set; }

            [JsonPropertyName("owner")]
            public FirstOwner Owner { get; set; }

            [JsonPropertyName("requireSensitiveMasking")]
            public bool? RequireSensitiveMasking { get; set; }

            [JsonPropertyName("videoLive")]
            public object VideoLive { get; set; }

            [JsonPropertyName("9d091f87")]
            public bool? The9D091F87 { get; set; }

            [JsonPropertyName("acf68865")]
            public bool? Acf68865 { get; set; }
        }

        public partial class Count
        {
            [JsonPropertyName("view")]
            public long? View { get; set; }

            [JsonPropertyName("comment")]
            public long? Comment { get; set; }

            [JsonPropertyName("mylist")]
            public long? Mylist { get; set; }

            [JsonPropertyName("like")]
            public long? Like { get; set; }
        }

        public partial class FirstOwner
        {
            [JsonPropertyName("ownerType")]
            public string OwnerType { get; set; }

            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("iconUrl")]
            public Uri IconUrl { get; set; }
        }

        public partial class FirstThumbnail
        {
            [JsonPropertyName("url")]
            public Uri Url { get; set; }

            [JsonPropertyName("middleUrl")]
            public Uri MiddleUrl { get; set; }

            [JsonPropertyName("largeUrl")]
            public Uri LargeUrl { get; set; }

            [JsonPropertyName("listingUrl")]
            public Uri ListingUrl { get; set; }

            [JsonPropertyName("nHdUrl")]
            public Uri NHdUrl { get; set; }
        }

        public partial class SystemClass
        {
            [JsonPropertyName("serverTime")]
            public DateTimeOffset? ServerTime { get; set; }

            [JsonPropertyName("isPeakTime")]
            public bool? IsPeakTime { get; set; }
        }

        public partial class TagClass
        {
            [JsonPropertyName("items")]
            public List<Item> Items { get; set; } = new();

            [JsonPropertyName("hasR18Tag")]
            public bool? HasR18Tag { get; set; }

            [JsonPropertyName("isPublishedNicoscript")]
            public bool? IsPublishedNicoscript { get; set; }

            [JsonPropertyName("edit")]
            public Edit Edit { get; set; }

            [JsonPropertyName("viewer")]
            public Edit Viewer { get; set; }
        }

        public partial class Edit
        {
            [JsonPropertyName("isEditable")]
            public bool? IsEditable { get; set; }

            [JsonPropertyName("uneditableReason")]
            public object UneditableReason { get; set; }

            [JsonPropertyName("editKey")]
            public string EditKey { get; set; }
        }

        public partial class Item
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("isCategory")]
            public bool? IsCategory { get; set; }

            [JsonPropertyName("isCategoryCandidate")]
            public bool? IsCategoryCandidate { get; set; }

            [JsonPropertyName("isNicodicArticleExists")]
            public bool? IsNicodicArticleExists { get; set; }

            [JsonPropertyName("isLocked")]
            public bool? IsLocked { get; set; }
        }

        public partial class TemperaturesVideo
        {
            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("title")]
            public string Title { get; set; }

            [JsonPropertyName("description")]
            public string Description { get; set; }

            [JsonPropertyName("count")]
            public Count Count { get; set; }

            [JsonPropertyName("duration")]
            public long? Duration { get; set; }

            [JsonPropertyName("thumbnail")]
            public VideoThumbnail Thumbnail { get; set; }

            [JsonPropertyName("rating")]
            public Rating Rating { get; set; }

            [JsonPropertyName("registeredAt")]
            public DateTimeOffset? RegisteredAt { get; set; }

            [JsonPropertyName("isPrivate")]
            public bool? IsPrivate { get; set; }

            [JsonPropertyName("isDeleted")]
            public bool? IsDeleted { get; set; }

            [JsonPropertyName("isNoBanner")]
            public bool? IsNoBanner { get; set; }

            [JsonPropertyName("isAuthenticationRequired")]
            public bool? IsAuthenticationRequired { get; set; }

            [JsonPropertyName("isEmbedPlayerAllowed")]
            public bool? IsEmbedPlayerAllowed { get; set; }

            [JsonPropertyName("viewer")]
            public VideoViewer Viewer { get; set; }

            [JsonPropertyName("watchableUserTypeForPayment")]
            public string WatchableUserTypeForPayment { get; set; }

            [JsonPropertyName("commentableUserTypeForPayment")]
            public string CommentableUserTypeForPayment { get; set; }

            [JsonPropertyName("9d091f87")]
            public bool? The9D091F87 { get; set; }
        }

        public partial class Rating
        {
            [JsonPropertyName("isAdult")]
            public bool? IsAdult { get; set; }
        }

        public partial class VideoThumbnail
        {
            [JsonPropertyName("url")]
            public Uri Url { get; set; }

            [JsonPropertyName("middleUrl")]
            public Uri MiddleUrl { get; set; }

            [JsonPropertyName("largeUrl")]
            public Uri LargeUrl { get; set; }

            [JsonPropertyName("player")]
            public Uri Player { get; set; }

            [JsonPropertyName("ogp")]
            public Uri Ogp { get; set; }
        }

        public partial class VideoViewer
        {
            [JsonPropertyName("isOwner")]
            public bool? IsOwner { get; set; }

            [JsonPropertyName("like")]
            public Like Like { get; set; }
        }

        public partial class Like
        {
            [JsonPropertyName("isLiked")]
            public bool? IsLiked { get; set; }

            [JsonPropertyName("count")]
            public object Count { get; set; }
        }

        public partial class VideoAdsClass
        {
            [JsonPropertyName("additionalParams")]
            public AdditionalParams AdditionalParams { get; set; }

            [JsonPropertyName("items")]
            public List<object> Items { get; set; } = new();

            [JsonPropertyName("reason")]
            public object Reason { get; set; }
        }

        public partial class AdditionalParams
        {
            [JsonPropertyName("videoId")]
            public string VideoId { get; set; }

            [JsonPropertyName("videoDuration")]
            public long? VideoDuration { get; set; }

            [JsonPropertyName("isAdultRatingNG")]
            public bool? IsAdultRatingNg { get; set; }

            [JsonPropertyName("isAuthenticationRequired")]
            public bool? IsAuthenticationRequired { get; set; }

            [JsonPropertyName("isR18")]
            public bool? IsR18 { get; set; }

            [JsonPropertyName("nicosid")]
            public string Nicosid { get; set; }

            [JsonPropertyName("lang")]
            public string Lang { get; set; }

            [JsonPropertyName("watchTrackId")]
            public string WatchTrackId { get; set; }

            [JsonPropertyName("genre")]
            public string Genre { get; set; }

            [JsonPropertyName("gender")]
            public string Gender { get; set; }

            [JsonPropertyName("age")]
            public long? Age { get; set; }
        }

        public partial class TemperaturesViewer
        {
            [JsonPropertyName("id")]
            public long? Id { get; set; }

            [JsonPropertyName("nickname")]
            public string Nickname { get; set; }

            [JsonPropertyName("isPremium")]
            public bool? IsPremium { get; set; }

            [JsonPropertyName("existence")]
            public Existence Existence { get; set; }
        }

        public partial class Existence
        {
            [JsonPropertyName("age")]
            public long? Age { get; set; }

            [JsonPropertyName("prefecture")]
            public string Prefecture { get; set; }

            [JsonPropertyName("sex")]
            public string Sex { get; set; }
        }

        public partial class WakuClass
        {
            [JsonPropertyName("information")]
            public object Information { get; set; }

            [JsonPropertyName("bgImages")]
            public List<object> BgImages { get; set; } = new();

            [JsonPropertyName("addContents")]
            public object AddContents { get; set; }

            [JsonPropertyName("addVideo")]
            public object AddVideo { get; set; }

            [JsonPropertyName("tagRelatedBanner")]
            public object TagRelatedBanner { get; set; }

            [JsonPropertyName("tagRelatedMarquee")]
            public object TagRelatedMarquee { get; set; }
        }
    }
}
