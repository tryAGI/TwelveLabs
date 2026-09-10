#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace TwelveLabs
{
    /// <summary>
    /// A single metadata value: a string, a number, a boolean, or an array of strings. The platform stores the value with the type you send. It rejects a nested object and an array that contains anything but strings. Send an integer wider than 53 bits (-9007199254740991 to 9007199254740991) and any identifier you want preserved verbatim as a string.
    /// </summary>
    public readonly partial struct UserMetadataValue : global::System.IEquatable<UserMetadataValue>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? UserMetadataValueVariant1 { get; init; }
#else
        public string? UserMetadataValueVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserMetadataValueVariant1))]
#endif
        public bool IsUserMetadataValueVariant1 => UserMetadataValueVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserMetadataValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = UserMetadataValueVariant1;
            return IsUserMetadataValueVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickUserMetadataValueVariant1() => IsUserMetadataValueVariant1
            ? UserMetadataValueVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserMetadataValueVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public int? UserMetadataValueVariant2 { get; init; }
#else
        public int? UserMetadataValueVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserMetadataValueVariant2))]
#endif
        public bool IsUserMetadataValueVariant2 => UserMetadataValueVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserMetadataValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = UserMetadataValueVariant2;
            return IsUserMetadataValueVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public int PickUserMetadataValueVariant2() => IsUserMetadataValueVariant2
            ? UserMetadataValueVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserMetadataValueVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public double? UserMetadataValueVariant3 { get; init; }
#else
        public double? UserMetadataValueVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserMetadataValueVariant3))]
#endif
        public bool IsUserMetadataValueVariant3 => UserMetadataValueVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserMetadataValueVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = UserMetadataValueVariant3;
            return IsUserMetadataValueVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public double PickUserMetadataValueVariant3() => IsUserMetadataValueVariant3
            ? UserMetadataValueVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserMetadataValueVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? UserMetadataValueVariant4 { get; init; }
#else
        public bool? UserMetadataValueVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserMetadataValueVariant4))]
#endif
        public bool IsUserMetadataValueVariant4 => UserMetadataValueVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserMetadataValueVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = UserMetadataValueVariant4;
            return IsUserMetadataValueVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public bool PickUserMetadataValueVariant4() => IsUserMetadataValueVariant4
            ? UserMetadataValueVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserMetadataValueVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? UserMetadataValueVariant5 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? UserMetadataValueVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserMetadataValueVariant5))]
#endif
        public bool IsUserMetadataValueVariant5 => UserMetadataValueVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserMetadataValueVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = UserMetadataValueVariant5;
            return IsUserMetadataValueVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickUserMetadataValueVariant5() => IsUserMetadataValueVariant5
            ? UserMetadataValueVariant5!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserMetadataValueVariant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UserMetadataValue(string value) => new UserMetadataValue((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(UserMetadataValue @this) => @this.UserMetadataValueVariant1;

        /// <summary>
        ///
        /// </summary>
        public UserMetadataValue(string? value)
        {
            UserMetadataValueVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UserMetadataValue FromUserMetadataValueVariant1(string? value) => new UserMetadataValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UserMetadataValue(int value) => new UserMetadataValue((int?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator int?(UserMetadataValue @this) => @this.UserMetadataValueVariant2;

        /// <summary>
        ///
        /// </summary>
        public UserMetadataValue(int? value)
        {
            UserMetadataValueVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UserMetadataValue FromUserMetadataValueVariant2(int? value) => new UserMetadataValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UserMetadataValue(double value) => new UserMetadataValue((double?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator double?(UserMetadataValue @this) => @this.UserMetadataValueVariant3;

        /// <summary>
        ///
        /// </summary>
        public UserMetadataValue(double? value)
        {
            UserMetadataValueVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UserMetadataValue FromUserMetadataValueVariant3(double? value) => new UserMetadataValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UserMetadataValue(bool value) => new UserMetadataValue((bool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator bool?(UserMetadataValue @this) => @this.UserMetadataValueVariant4;

        /// <summary>
        ///
        /// </summary>
        public UserMetadataValue(bool? value)
        {
            UserMetadataValueVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UserMetadataValue FromUserMetadataValueVariant4(bool? value) => new UserMetadataValue(value);

        /// <summary>
        ///
        /// </summary>
        public UserMetadataValue(
            string? userMetadataValueVariant1,
            int? userMetadataValueVariant2,
            double? userMetadataValueVariant3,
            bool? userMetadataValueVariant4,
            global::System.Collections.Generic.IList<string>? userMetadataValueVariant5
            )
        {
            UserMetadataValueVariant1 = userMetadataValueVariant1;
            UserMetadataValueVariant2 = userMetadataValueVariant2;
            UserMetadataValueVariant3 = userMetadataValueVariant3;
            UserMetadataValueVariant4 = userMetadataValueVariant4;
            UserMetadataValueVariant5 = userMetadataValueVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            UserMetadataValueVariant5 as object ??
            UserMetadataValueVariant4 as object ??
            UserMetadataValueVariant3 as object ??
            UserMetadataValueVariant2 as object ??
            UserMetadataValueVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UserMetadataValueVariant1?.ToString() ??
            UserMetadataValueVariant2?.ToString() ??
            UserMetadataValueVariant3?.ToString() ??
            UserMetadataValueVariant4?.ToString().ToLowerInvariant() ??
            UserMetadataValueVariant5?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUserMetadataValueVariant1 && !IsUserMetadataValueVariant2 && !IsUserMetadataValueVariant3 && !IsUserMetadataValueVariant4 && !IsUserMetadataValueVariant5 || !IsUserMetadataValueVariant1 && IsUserMetadataValueVariant2 && !IsUserMetadataValueVariant3 && !IsUserMetadataValueVariant4 && !IsUserMetadataValueVariant5 || !IsUserMetadataValueVariant1 && !IsUserMetadataValueVariant2 && IsUserMetadataValueVariant3 && !IsUserMetadataValueVariant4 && !IsUserMetadataValueVariant5 || !IsUserMetadataValueVariant1 && !IsUserMetadataValueVariant2 && !IsUserMetadataValueVariant3 && IsUserMetadataValueVariant4 && !IsUserMetadataValueVariant5 || !IsUserMetadataValueVariant1 && !IsUserMetadataValueVariant2 && !IsUserMetadataValueVariant3 && !IsUserMetadataValueVariant4 && IsUserMetadataValueVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? userMetadataValueVariant1 = null,
            global::System.Func<int?, TResult>? userMetadataValueVariant2 = null,
            global::System.Func<double?, TResult>? userMetadataValueVariant3 = null,
            global::System.Func<bool?, TResult>? userMetadataValueVariant4 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? userMetadataValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserMetadataValueVariant1 && userMetadataValueVariant1 != null)
            {
                return userMetadataValueVariant1(UserMetadataValueVariant1!);
            }
            else if (IsUserMetadataValueVariant2 && userMetadataValueVariant2 != null)
            {
                return userMetadataValueVariant2(UserMetadataValueVariant2!);
            }
            else if (IsUserMetadataValueVariant3 && userMetadataValueVariant3 != null)
            {
                return userMetadataValueVariant3(UserMetadataValueVariant3!);
            }
            else if (IsUserMetadataValueVariant4 && userMetadataValueVariant4 != null)
            {
                return userMetadataValueVariant4(UserMetadataValueVariant4!);
            }
            else if (IsUserMetadataValueVariant5 && userMetadataValueVariant5 != null)
            {
                return userMetadataValueVariant5(UserMetadataValueVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? userMetadataValueVariant1 = null,

            global::System.Action<int?>? userMetadataValueVariant2 = null,

            global::System.Action<double?>? userMetadataValueVariant3 = null,

            global::System.Action<bool?>? userMetadataValueVariant4 = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? userMetadataValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserMetadataValueVariant1)
            {
                userMetadataValueVariant1?.Invoke(UserMetadataValueVariant1!);
            }
            else if (IsUserMetadataValueVariant2)
            {
                userMetadataValueVariant2?.Invoke(UserMetadataValueVariant2!);
            }
            else if (IsUserMetadataValueVariant3)
            {
                userMetadataValueVariant3?.Invoke(UserMetadataValueVariant3!);
            }
            else if (IsUserMetadataValueVariant4)
            {
                userMetadataValueVariant4?.Invoke(UserMetadataValueVariant4!);
            }
            else if (IsUserMetadataValueVariant5)
            {
                userMetadataValueVariant5?.Invoke(UserMetadataValueVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? userMetadataValueVariant1 = null,
            global::System.Action<int?>? userMetadataValueVariant2 = null,
            global::System.Action<double?>? userMetadataValueVariant3 = null,
            global::System.Action<bool?>? userMetadataValueVariant4 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? userMetadataValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserMetadataValueVariant1)
            {
                userMetadataValueVariant1?.Invoke(UserMetadataValueVariant1!);
            }
            else if (IsUserMetadataValueVariant2)
            {
                userMetadataValueVariant2?.Invoke(UserMetadataValueVariant2!);
            }
            else if (IsUserMetadataValueVariant3)
            {
                userMetadataValueVariant3?.Invoke(UserMetadataValueVariant3!);
            }
            else if (IsUserMetadataValueVariant4)
            {
                userMetadataValueVariant4?.Invoke(UserMetadataValueVariant4!);
            }
            else if (IsUserMetadataValueVariant5)
            {
                userMetadataValueVariant5?.Invoke(UserMetadataValueVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UserMetadataValueVariant1,
                typeof(string),
                UserMetadataValueVariant2,
                typeof(int),
                UserMetadataValueVariant3,
                typeof(double),
                UserMetadataValueVariant4,
                typeof(bool),
                UserMetadataValueVariant5,
                typeof(global::System.Collections.Generic.IList<string>),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(UserMetadataValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(UserMetadataValueVariant1, other.UserMetadataValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(UserMetadataValueVariant2, other.UserMetadataValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(UserMetadataValueVariant3, other.UserMetadataValueVariant3) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(UserMetadataValueVariant4, other.UserMetadataValueVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(UserMetadataValueVariant5, other.UserMetadataValueVariant5)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UserMetadataValue obj1, UserMetadataValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UserMetadataValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UserMetadataValue obj1, UserMetadataValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UserMetadataValue o && Equals(o);
        }
    }
}
