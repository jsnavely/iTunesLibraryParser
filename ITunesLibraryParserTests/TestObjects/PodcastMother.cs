using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITunesLibraryParser.Tests.TestObjects {
    public static class PodcastMother {
        public static Podcast Create() {
            return new Podcast {
                Feed = new Track {
                    TrackId = 26103,
                    DateAdded = DateTime.Today,
                    Rating = 100,
                    RatingComputed = true,
                    AlbumRating = 100,
                    TrackType = "URL",
                    IsPurchased = true,
                    Name = "Coverville: The Cover Music Show (AAC Edition)",
                    Artist = "Brian Ibbott",
                    Album = "Coverville: The Cover Music Show (AAC Edition)",
                    Genre = "Music",
                    Location = "http://feeds.feedburner.com/CovervilleAAC",
                },
                Episodes = new List<Track> {
                    new Track {
                        Name = "Coverville 1073: Bluesville with cover stories for Muddy Waters and Eric Clapton!"
                    }
                },
            };
        }
    }
}
