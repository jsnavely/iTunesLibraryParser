using System;

namespace ITunesLibraryParser {
    public class Track : IEquatable<Track> {
        public int TrackId { get; set; }
        public string TrackType { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string AlbumArtist { get; set; }
        public string Composer { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public string Grouping { get; set; }
        public string Kind { get; set; }
        public long? Size { get; set; }
        public string PlayingTime { get; set; }
        public int? TrackNumber { get; set; }
        public int? TrackCount { get; set; }
        public int? DiscNumber { get; set; }
        public int? DiscCount { get; set; }
        public int? ArtworkCount { get; set; }
        public int? Year { get; set; }
        public int? Season { get; set; }
        public int? EpisodeOrder { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateAdded { get; set; }
        public int? BitRate { get; set; }
        public int? SampleRate { get; set; }
        public int? VolumeAdjustment { get; set; }
        public int? BPM { get; set; }
        public int? PlayCount { get; set; }
        public DateTime? PlayDate { get; set; }
        public int? SkipCount { get; set; }
        public DateTime? SkipDate { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public bool PartOfCompilation { get; set; }
        public string Location { get; set; }
        public int? Rating { get; set; }
        public bool RatingComputed { get; set; }
        public int? AlbumRating { get; set; }
        public bool AlbumRatingComputed { get; set; }
        public bool IsPodcast { get; set; }
        public bool IsPurchased { get; set; }
        public bool IsUnplayed { get; set; }
        public bool IsExplicit { get; set; }
        public bool IsClean { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsMovie { get; set; }
        public bool IsTVShow { get; set; }
        public bool IsMusicVideo { get; set; }
        public bool IsLoved { get; set; }
        public bool IsAlbumLoved { get; set; }
        public bool IsDisliked { get; set; }
        public bool IsAlbumDisliked { get; set; }
        public bool HasVideo { get; set; }
        public string Comments { get; set; }
        public string Series { get; set; }
        public string Episode { get; set; }
        public string ContentRating { get; set; }
        public string SortName { get; set; }
        public string SortAlbum { get; set; }
        public string SortArtist { get; set; }
        public string SortAlbumArtist { get; set; }
        public string SortComposer { get; set; }
        public string SortSeries { get; set; }
        public string PersistentId { get; set; }

        public override string ToString() {
            return $"Artist: {Artist} - Track: {Name} - Album: {Album}";
        }

        public Track Copy() {
            return MemberwiseClone() as Track;
        }

        public bool Equals(Track other) {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return TrackId == other.TrackId && string.Equals(TrackType, other.TrackType) && string.Equals(Name, other.Name) && 
                   string.Equals(Artist, other.Artist) && string.Equals(AlbumArtist, other.AlbumArtist) 
                   && string.Equals(Composer, other.Composer) && string.Equals(Album, other.Album) && 
                   string.Equals(Genre, other.Genre) && string.Equals(Grouping, other.Grouping) &&
                   string.Equals(Kind, other.Kind) && Size == other.Size && string.Equals(PlayingTime, other.PlayingTime) &&
                   TrackNumber == other.TrackNumber && TrackCount == other.TrackCount && DiscNumber == other.DiscNumber &&
                   DiscCount == other.DiscCount && Season == other.Season && EpisodeOrder == other.EpisodeOrder && ArtworkCount == other.ArtworkCount &&
                   Year == other.Year && DateModified.Equals(other.DateModified) && DateAdded.Equals(other.DateAdded) && 
                   BitRate == other.BitRate && SampleRate == other.SampleRate && VolumeAdjustment == other.VolumeAdjustment && BPM == other.BPM &&
                   PlayCount == other.PlayCount && 
                   PlayDate.Equals(other.PlayDate) && SkipCount.Equals(other.SkipCount) && SkipDate.Equals(other.SkipDate) &&
                   ReleaseDate.Equals(other.ReleaseDate) && PartOfCompilation == other.PartOfCompilation && Location == other.Location &&
                   Rating == other.Rating && RatingComputed == other.RatingComputed && AlbumRating == other.AlbumRating &&
                   AlbumRatingComputed == other.AlbumRatingComputed && IsPodcast == other.IsPodcast && IsPurchased == other.IsPurchased &&
                   IsUnplayed == other.IsUnplayed && IsExplicit == other.IsExplicit && IsClean == other.IsClean && IsDisabled == other.IsDisabled &&
                   IsMovie == other.IsMovie && IsTVShow == other.IsTVShow && IsMusicVideo == other.IsMusicVideo && IsLoved == other.IsLoved &&
                   IsAlbumLoved == other.IsAlbumLoved && IsDisliked == other.IsDisliked && IsAlbumDisliked == other.IsAlbumDisliked && HasVideo == other.HasVideo &&
                   Comments == other.Comments && Series == other.Series && Episode == other.Episode && ContentRating == other.ContentRating &&
                   SortName == other.SortName && SortAlbum == other.SortAlbum && SortArtist == other.SortArtist && SortAlbumArtist == other.SortAlbumArtist &&
                   SortComposer == other.SortComposer && SortSeries == other.SortSeries && PersistentId == other.PersistentId;
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Track)obj);
        }

        public override int GetHashCode() {
            unchecked {
                var hashCode = TrackId;
                hashCode = (hashCode * 397) ^ (TrackType != null ? TrackType.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Artist != null ? Artist.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (AlbumArtist != null ? AlbumArtist.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Composer != null ? Composer.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Album != null ? Album.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Genre != null ? Genre.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Grouping != null ? Grouping.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Kind != null ? Kind.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Size.GetHashCode();
                hashCode = (hashCode * 397) ^ (PlayingTime != null ? PlayingTime.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ TrackNumber.GetHashCode();
                hashCode = (hashCode * 397) ^ TrackCount.GetHashCode();
                hashCode = (hashCode * 397) ^ DiscNumber.GetHashCode();
                hashCode = (hashCode * 397) ^ DiscCount.GetHashCode();
                hashCode = (hashCode * 397) ^ Season.GetHashCode();
                hashCode = (hashCode * 397) ^ EpisodeOrder.GetHashCode();
                hashCode = (hashCode * 397) ^ ArtworkCount.GetHashCode();
                hashCode = (hashCode * 397) ^ Year.GetHashCode();
                hashCode = (hashCode * 397) ^ DateModified.GetHashCode();
                hashCode = (hashCode * 397) ^ DateAdded.GetHashCode();
                hashCode = (hashCode * 397) ^ BitRate.GetHashCode();
                hashCode = (hashCode * 397) ^ SampleRate.GetHashCode();
                hashCode = (hashCode * 397) ^ VolumeAdjustment.GetHashCode();
                hashCode = (hashCode * 397) ^ BPM.GetHashCode();
                hashCode = (hashCode * 397) ^ PlayCount.GetHashCode();
                hashCode = (hashCode * 397) ^ PlayDate.GetHashCode();
                hashCode = (hashCode * 397) ^ SkipCount.GetHashCode();
                hashCode = (hashCode * 397) ^ SkipDate.GetHashCode();
                hashCode = (hashCode * 397) ^ ReleaseDate.GetHashCode();
                hashCode = (hashCode * 397) ^ PartOfCompilation.GetHashCode();
                hashCode = (hashCode * 397) ^ (Location != null ? Location.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Rating.GetHashCode();
                hashCode = (hashCode * 397) ^ RatingComputed.GetHashCode();
                hashCode = (hashCode * 397) ^ AlbumRating.GetHashCode();
                hashCode = (hashCode * 397) ^ AlbumRatingComputed.GetHashCode();
                hashCode = (hashCode * 397) ^ IsPodcast.GetHashCode();
                hashCode = (hashCode * 397) ^ IsPurchased.GetHashCode();
                hashCode = (hashCode * 397) ^ IsUnplayed.GetHashCode();
                hashCode = (hashCode * 397) ^ IsExplicit.GetHashCode();
                hashCode = (hashCode * 397) ^ IsClean.GetHashCode();
                hashCode = (hashCode * 397) ^ IsDisabled.GetHashCode();
                hashCode = (hashCode * 397) ^ IsMovie.GetHashCode();
                hashCode = (hashCode * 397) ^ IsTVShow.GetHashCode();
                hashCode = (hashCode * 397) ^ IsMusicVideo.GetHashCode();
                hashCode = (hashCode * 397) ^ HasVideo.GetHashCode();
                hashCode = (hashCode * 397) ^ IsLoved.GetHashCode();
                hashCode = (hashCode * 397) ^ IsAlbumLoved.GetHashCode();
                hashCode = (hashCode * 397) ^ IsDisliked.GetHashCode();
                hashCode = (hashCode * 397) ^ IsAlbumDisliked.GetHashCode();
                hashCode = (hashCode * 397) ^ (Comments != null ? Comments.GetHashCode(): 0);
                hashCode = (hashCode * 397) ^ (Series != null ? Series.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Episode != null ? Episode.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ContentRating != null ? ContentRating.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (SortName != null ? SortName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (SortAlbum != null ? SortAlbum.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (SortArtist != null ? SortArtist.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (SortAlbumArtist != null ? SortAlbumArtist.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (SortComposer != null ? SortComposer.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (SortSeries != null ? SortSeries.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PersistentId != null ? PersistentId.GetHashCode(): 0);
                return hashCode;
            }
        }
    }
}
