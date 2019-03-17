using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITunesLibraryParser {
    internal class PodcastParser {
        internal IEnumerable<Podcast> ParsePodcasts(IEnumerable<Track> tracks) {
            var feedList = tracks.Where(t => t.IsPodcast && string.Equals(t.TrackType,"URL"));
            var feeds = new List<Podcast>();
            foreach (var feed in feedList) {
                var episodes = tracks.Where(t => t.IsPodcast && string.Equals(t.TrackType, "File") && string.Equals(t.Album, feed.Album));
                feeds.Add(CreatePodcast(feed, episodes));
            }
            return feeds;
        }

        private static Podcast CreatePodcast(Track feed, IEnumerable<Track> episodes) {
            return new Podcast {
                Feed = feed,
                Episodes = episodes.ToList()
            };
        }
    }
}
