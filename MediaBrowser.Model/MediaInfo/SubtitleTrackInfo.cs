#pragma warning disable CS1591
#pragma warning disable SA1600

using System;
using System.Collections.Generic;

namespace MediaBrowser.Model.MediaInfo
{
    public class SubtitleTrackInfo
    {
        public IReadOnlyList<SubtitleTrackEvent> TrackEvents { get; set; }

        public SubtitleTrackInfo()
        {
            TrackEvents = Array.Empty<SubtitleTrackEvent>();
        }
    }
}
