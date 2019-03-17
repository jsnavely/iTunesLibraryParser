using System;

namespace ITunesLibraryParser.Tests.TestObjects {
    public static class TrackMother {
        public static Track Create() {
            return new Track {
                TrackId = 456,
                Name = "Witch Hunt",
                Artist = "Wayne Shorter",
                AlbumArtist = "Wayne Shorter",
                Composer = "Wayne Shorter",
                Album = "Speak No Evil",
                Genre = "Jazz",
                Kind = "AAC Audio File",
                Size = 5768594,
                PlayingTime = "4:35",
                TrackNumber = 1,
                TrackCount = 6,
                DiscNumber = 1,
                DiscCount = 1,
                ArtworkCount = 1,
                Year = 1964,
                DateModified = DateTime.Today,
                DateAdded = DateTime.Today,
                BitRate = 330,
                SampleRate = 44100,
                PlayCount = 55,
                PlayDate = DateTime.Today,
                ReleaseDate = new DateTime(1964, 12, 24),
                PartOfCompilation = false,
                IsPodcast = false,
                IsPurchased = true,
                Location = "file://localhost/C:/Users/anthony/Music/iTunes/iTunes%20Music/Wayne%20Shorter/Speak%20No%20Evil/01%20Witch%20Hunt.m4a",
                Rating = 50,
                RatingComputed = true,
                AlbumRatingComputed = true,
                AlbumRating = 60,
                Comments = "Recorded at the Rudy Van Gelder Studio, Englewood Cliffs, New Jersey."
            };
        }
    }
}
