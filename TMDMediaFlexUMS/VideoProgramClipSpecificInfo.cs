﻿namespace Skyline.DataMiner.ConnectorAPI.TMDMediaFlexUMS
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents specific details about a video program or clip within a Media Asset Management (MAM) system.
    /// This information is critical for technical validation, categorization, and distribution of media assets.
    /// </summary>
    public class VideoProgramClipSpecificInfo
    {
        /// <summary>
        /// The type of video (e.g., program, clip, advertisement) for classification and processing purposes.
        /// </summary>
        [JsonProperty("VideoType")]
        public string VideoType { get; set; }

        /// <summary>
        /// A textual description of the video, providing additional context or summary for cataloging.
        /// </summary>
        [JsonProperty("Description")]
        public string Description { get; set; }

        /// <summary>
        /// Unique identifier for the video in the Plasma database or system.
        /// </summary>
        [JsonProperty("PlasmaID")]
        public string PlasmaID { get; set; }

        /// <summary>
        /// Unique identifier for the video in the Yle database or system.
        /// </summary>
        [JsonProperty("YleID")]
        public string YleID { get; set; }

        /// <summary>
        /// The MD5 hash of the video file, used for integrity verification.
        /// </summary>
        [JsonProperty("MD5")]
        public string MD5 { get; set; }

        /// <summary>
        /// Timecode indicating the start of the video file, useful for editing and playback synchronization.
        /// </summary>
        [JsonProperty("StartOfFile")]
        public string StartOfFile { get; set; }

        /// <summary>
        /// Timecode indicating the end of the video file, essential for determining the duration.
        /// </summary>
        [JsonProperty("EndOfFile")]
        public string EndOfFile { get; set; }

        /// <summary>
        /// Timecode marking the start of the actual media content (excluding black or slate frames).
        /// </summary>
        [JsonProperty("StartOfMedia")]
        public string StartOfMedia { get; set; }

        /// <summary>
        /// Timecode marking the end of the actual media content.
        /// </summary>
        [JsonProperty("EndOfMedia")]
        public string EndOfMedia { get; set; }

        /// <summary>
        /// Specifies the type of timecode used (e.g., drop-frame, non-drop-frame).
        /// </summary>
        [JsonProperty("timeCodeType")]
        public string TimeCodeType { get; set; }

        /// <summary>
        /// The resolution of the video (e.g., 1920x1080), crucial for quality assurance and distribution requirements.
        /// </summary>
        [JsonProperty("resolution")]
        public string Resolution { get; set; }

        /// <summary>
        /// The codec used for encoding the video, determining its compression and compatibility.
        /// </summary>
        [JsonProperty("codec")]
        public string Codec { get; set; }

        /// <summary>
        /// The bitrate of the video, typically measured in kbps, indicating its quality and size.
        /// </summary>
        [JsonProperty("bitrate")]
        public string Bitrate { get; set; }

        /// <summary>
        /// Additional picture information (e.g., chroma subsampling) for technical validation.
        /// </summary>
        [JsonProperty("pi")]
        public string Pi { get; set; }

        /// <summary>
        /// The aspect ratio of the video (e.g., 16:9), important for display compatibility.
        /// </summary>
        [JsonProperty("aspectRatio")]
        public string AspectRatio { get; set; }

        /// <summary>
        /// The frame rate of the video, indicating the number of frames displayed per second.
        /// </summary>
        [JsonProperty("frameRate")]
        public int FrameRate { get; set; }

        /// <summary>
        /// Indicates whether the video is ready for transmission (e.g., broadcast or streaming).
        /// </summary>
        [JsonProperty("TransmissionReady")]
        public bool TransmissionReady { get; set; }

        /// <summary>
        /// Contains detailed information about the audio assets associated with the video.
        /// </summary>
        [JsonProperty("AudioAssetInfo")]
        public AudioAssetInfo AudioAssetInfo { get; set; }

        /// <summary>
        /// The bitrate of the audio track, affecting its quality and size.
        /// </summary>
        [JsonProperty("audioBitRate")]
        public string AudioBitRate { get; set; }

        /// <summary>
        /// The codec used for encoding the audio track, determining its format and compatibility.
        /// </summary>
        [JsonProperty("audioCodec")]
        public string AudioCodec { get; set; }

        /// <summary>
        /// Any additional information or metadata about the video program or clip.
        /// </summary>
        [JsonProperty("additionalinfo")]
        public string AdditionalInfo { get; set; }
    }

}
