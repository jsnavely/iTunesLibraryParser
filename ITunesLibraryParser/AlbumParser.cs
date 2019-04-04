using System;
using System.Collections.Generic;
using System.Linq;

namespace ITunesLibraryParser {
    internal class AlbumParser {
        private static string CompilationArtistName = "Various Artists";
        private static string UnknownArtistName = "Unknown Artist";
        private static string UnknownAlbumName = "Unknown Album";

        internal IEnumerable<Album> ParseAlbums(IEnumerable<Track> tracks) {
            var albumGroups = tracks.GroupBy(t => t.GroupAlbum,
                StringComparer.InvariantCultureIgnoreCase);
            var albums = new List<Album>();
            foreach (var albumGroup in albumGroups) {
                SubGroupByAlbumArtistToCreateAlbums(albumGroup, albums);
            }
            return albums;
        }

        private static void SubGroupByAlbumArtistToCreateAlbums(IEnumerable<Track> albumGroup, List<Album> albums) {
            var groupByAlbumArtist = albumGroup.GroupBy(t => GetGroupByArtistName(t),
                StringComparer.InvariantCultureIgnoreCase);
            albums.AddRange(groupByAlbumArtist.Select(CreateAlbum));
        }

        private static string GetGroupByArtistName(Track track) {
            // Track with the same Album Artist are always grouped together.
            if (!string.IsNullOrWhiteSpace(track.GroupAlbumArtist))
                return track.GroupAlbumArtist;

            // Tracks with the compilation flag set and no Album Artist value are grouped together as a
            // "Various Artists" compilation in iTunes.
            if (track.PartOfCompilation)
                return CompilationArtistName;

            // Tracks without the compilation flag, and no Album Artist or Artist, are grouped together as
            // "Unknown Artist", but are not combined with any tracks that have "Unknown Artist" entered
            // into the Artist or Album Artist field because that's how iTunes does it.
            if (string.IsNullOrWhiteSpace(track.GroupArtist))
                return null;

            // Tracks without the compilation flag that have an Artist, but no Album Artist value, assume
            // that the Album Artist is the same as the Artist.
            return track.GroupArtist;
        }

        private static Album CreateAlbum(IEnumerable<Track> tracks) {
            // Sort the tracks in the same order than iTunes sorts them (by disc, track, and name)
            // This has an influence in what iTunes uses for some of the album-related information such as
            // the album's Genre and album art when the track do not all match.
            var orderedTracks = tracks.OrderBy(t => t.DiscNumber ?? 1).ThenBy(t => t.TrackNumber ?? int.MaxValue).ThenBy(t => t.Name);
            return new Album {
                Name = GetAlbumName(orderedTracks),
                Genre = orderedTracks.First().Genre,
                Artist = GetArtistName(orderedTracks),
                Year = tracks.Max(t => t.Year),
                IsCompilation = tracks.Any(t => t.PartOfCompilation),
                Tracks = orderedTracks.ToList()
            };
        }

        private static string GetArtistName(IEnumerable<Track> tracks) {
            if (tracks.Any(t => !string.IsNullOrWhiteSpace(t.AlbumArtist)))
                return tracks.Select(t => t.AlbumArtist).First(aa => !string.IsNullOrWhiteSpace(aa));
            if (tracks.All(t => string.IsNullOrWhiteSpace(t.Artist)))
                return UnknownArtistName;
            return tracks.Any(t => t.PartOfCompilation) ? CompilationArtistName : tracks.Select(t => t.Artist).First();
        }

        private static string GetAlbumName(IEnumerable<Track> tracks) {
            if (tracks.Any(t => !string.IsNullOrWhiteSpace(t.Album)))
                return tracks.Select(t => t.Album).First(aa => !string.IsNullOrWhiteSpace(aa));
            return UnknownAlbumName;
        }
    }
}
