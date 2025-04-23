
    public class Q8StringLengthComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

           
            int lengthComparison = x.Length.CompareTo(y.Length);
            if (lengthComparison != 0) return lengthComparison;

           
            return string.Compare(x, y, StringComparison.Ordinal);
        }
    }

    public class Q8ComparableString : IComparable<Q8ComparableString>, IEquatable<Q8ComparableString>
    {
        public string Value { get; }

        public Q8ComparableString(string value)
        {
            Value = value;
        }

        public int CompareTo(Q8ComparableString other)
        {
            if (other == null) return 1;
            if (Value == null && other.Value == null) return 0;
            if (Value == null) return -1;
            if (other.Value == null) return 1;

            int lengthComparison = Value.Length.CompareTo(other.Value.Length);
            if (lengthComparison != 0) return lengthComparison;

            return string.Compare(Value, other.Value, StringComparison.Ordinal);
        }

        public bool Equals(Q8ComparableString other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Q8ComparableString)obj);
        }

        public override int GetHashCode()
        {
            return Value != null ? Value.GetHashCode() : 0;
        }

        public static bool operator ==(Q8ComparableString left, Q8ComparableString right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Q8ComparableString left, Q8ComparableString right)
        {
            return !Equals(left, right);
        }

        public static bool operator <(Q8ComparableString left, Q8ComparableString right)
        {
            return Comparer<Q8ComparableString>.Default.Compare(left, right) < 0;
        }

        public static bool operator >(Q8ComparableString left, Q8ComparableString right)
        {
            return Comparer<Q8ComparableString>.Default.Compare(left, right) > 0;
        }
    }
   