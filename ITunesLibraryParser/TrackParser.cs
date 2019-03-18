using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ITunesLibraryParser {
    internal class TrackParser : LibraryItemParserBase {

        internal IEnumerable<Track> ParseTracks(string libraryContents) {
            return ParseElements(libraryContents).Select(CreateTrack);
        }

        protected override string GetCollectionNodeName() {
            return "dict";
        }

        private static Track CreateTrack(XElement trackElement) {
            return new Track {
                TrackId = Int32.Parse(XElementParser.ParseStringValue(trackElement, "Track ID")),
                TrackType = XElementParser.ParseStringValue(trackElement, "Track Type"),
                Name = XElementParser.ParseStringValue(trackElement, "Name"),
                Artist = XElementParser.ParseStringValue(trackElement, "Artist"),
                AlbumArtist = XElementParser.ParseStringValue(trackElement, "Album Artist"),
                Composer = XElementParser.ParseStringValue(trackElement, "Composer"),
                Album = XElementParser.ParseStringValue(trackElement, "Album"),
                Genre = XElementParser.ParseStringValue(trackElement, "Genre"),
                Grouping = XElementParser.ParseStringValue(trackElement, "Grouping"),
                Kind = XElementParser.ParseStringValue(trackElement, "Kind"),
                Size = XElementParser.ParseNullableLongValue(trackElement, "Size"),
                PlayingTime = TimeConvert.MillisecondsToFormattedMinutesAndSeconds((XElementParser.ParseNullableLongValue(trackElement, "Total Time"))),
                TrackNumber = XElementParser.ParseNullableIntValue(trackElement, "Track Number"),
                TrackCount = XElementParser.ParseNullableIntValue(trackElement, "Track Count"),
                DiscNumber = XElementParser.ParseNullableIntValue(trackElement, "Disc Number"),
                DiscCount = XElementParser.ParseNullableIntValue(trackElement, "Disc Count"),
                Season = XElementParser.ParseNullableIntValue(trackElement, "Season"),
                EpisodeOrder = XElementParser.ParseNullableIntValue(trackElement, "Episode Order"),
                ArtworkCount = XElementParser.ParseNullableIntValue(trackElement, "Artwork Count"),
                Year = XElementParser.ParseNullableIntValue(trackElement, "Year"),
                DateModified = XElementParser.ParseNullableDateValue(trackElement, "Date Modified"),
                DateAdded = XElementParser.ParseNullableDateValue(trackElement, "Date Added"),
                BitRate = XElementParser.ParseNullableIntValue(trackElement, "Bit Rate"),
                SampleRate = XElementParser.ParseNullableIntValue(trackElement, "Sample Rate"),
                BPM = XElementParser.ParseNullableIntValue(trackElement, "BPM"),
                PlayDate = XElementParser.ParseNullableDateValue(trackElement, "Play Date UTC"),
                PlayCount = XElementParser.ParseNullableIntValue(trackElement, "Play Count"),
                SkipDate = XElementParser.ParseNullableDateValue(trackElement, "Skip Date"),
                SkipCount = XElementParser.ParseNullableIntValue(trackElement, "Skip Count"),
                ReleaseDate = XElementParser.ParseNullableDateValue(trackElement, "Release Date"),
                PartOfCompilation = XElementParser.ParseBoolean(trackElement, "Compilation"),
                Location = XElementParser.ParseStringValue(trackElement, "Location"),
                Rating = XElementParser.ParseNullableIntValue(trackElement, "Rating"),
                RatingComputed = XElementParser.ParseBoolean(trackElement, "Rating Computed"),
                AlbumRating = XElementParser.ParseNullableIntValue(trackElement, "Album Rating"),
                AlbumRatingComputed = XElementParser.ParseBoolean(trackElement, "Album Rating Computed"),
                IsPodcast = XElementParser.ParseBoolean(trackElement, "Podcast"),
                IsPurchased = XElementParser.ParseBoolean(trackElement, "Purchased"),
                IsUnplayed = XElementParser.ParseBoolean(trackElement, "Unplayed"),
                IsExplicit = XElementParser.ParseBoolean(trackElement, "Explicit"),
                IsClean = XElementParser.ParseBoolean(trackElement, "Clean"),
                IsDisabled = XElementParser.ParseBoolean(trackElement, "Disabled"),
                IsMovie = XElementParser.ParseBoolean(trackElement, "Movie"),
                IsTVShow = XElementParser.ParseBoolean(trackElement, "TV Show"),
                HasVideo = XElementParser.ParseBoolean(trackElement, "Has Video"),
                Comments = XElementParser.ParseStringValue(trackElement, "Comments"),
                Series = XElementParser.ParseStringValue(trackElement, "Series"),
                Episode = XElementParser.ParseStringValue(trackElement, "Episode"),
                ContentRating = XElementParser.ParseStringValue(trackElement, "Content Rating"),
                SortName = XElementParser.ParseStringValue(trackElement, "Sort Name"),
                SortAlbum = XElementParser.ParseStringValue(trackElement, "Sort Album"),
                SortArtist = XElementParser.ParseStringValue(trackElement, "Sort Artist"),
                SortAlbumArtist = XElementParser.ParseStringValue(trackElement, "Sort Album Artist"),
                SortComposer = XElementParser.ParseStringValue(trackElement, "Sort Composer"),
                SortSeries = XElementParser.ParseStringValue(trackElement, "Sort Series"),
                PersistentId = XElementParser.ParseStringValue(trackElement, "Persistent ID")
            };
        }
    }
}
