using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITunesLibraryParser {
    public class Podcast : IEquatable<Podcast> {
        public Track Feed { get; set; }
        public IEnumerable<Track> Episodes { get; set; }

        public override string ToString() {
            return $"{Feed.Artist} - {Feed.Name} - {Episodes.Count()} episodes";
        }

        public Podcast Copy() {
            return MemberwiseClone() as Podcast;
        }

        public bool Equals(Podcast other) {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Track.Equals(Feed, other.Feed) &&
                   Episodes.SequenceEqual(other.Episodes);
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Podcast)obj);
        }

        public override int GetHashCode() {
            unchecked {
                var hashCode = Feed.GetHashCode();
                hashCode = (hashCode * 397) ^ (Episodes != null ? Episodes.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
