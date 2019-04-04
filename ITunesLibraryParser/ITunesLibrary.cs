using System.Collections.Generic;
using System.Linq;

namespace ITunesLibraryParser {
    public class ITunesLibrary {

        private readonly string xmlLibraryFileLocation;
        private readonly IFileSystem fileSystem;
        private readonly TrackParser trackParser;
        private readonly AlbumParser albumParser;
        private readonly PodcastParser podcastParser;
        private IEnumerable<Track> tracks;
        private IEnumerable<Playlist> playlists;
        private IEnumerable<Album> albums;
        private IEnumerable<Podcast> podcasts;

        public ITunesLibrary(string xmlLibraryFileLocation) : this(xmlLibraryFileLocation, new FileSystemWrapper()) { }

        public ITunesLibrary(string xmlLibraryFileLocation, IFileSystem fileSystem) {
            this.xmlLibraryFileLocation = xmlLibraryFileLocation;
            this.fileSystem = fileSystem;
            this.trackParser = new TrackParser();
            this.albumParser = new AlbumParser();
            this.podcastParser = new PodcastParser();
        }

        public IEnumerable<Track> Tracks => tracks ?? (tracks = trackParser.ParseTracks(ReadTextFromLibraryFile()));

        private string ReadTextFromLibraryFile() {
            return fileSystem.ReadTextFromFile(xmlLibraryFileLocation);
        }

        public IEnumerable<Playlist> Playlists => playlists ?? (playlists = new PlaylistParser(Tracks).ParsePlaylists(ReadTextFromLibraryFile()));

        public IEnumerable<Track> Music => Playlists.Where(p => p.Name == "Music").FirstOrDefault()?.Tracks ?? Tracks;

        public IEnumerable<Album> Albums => albums ?? (albums = albumParser.ParseAlbums(Music));

        public IEnumerable<Podcast> Podcasts => podcasts ?? (podcasts = podcastParser.ParsePodcasts(Tracks));
    }
}
