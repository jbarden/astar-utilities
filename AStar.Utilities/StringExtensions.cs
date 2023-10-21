namespace AStar.Utilities;

/// <summary>
/// The <see cref="StringExtensions" /> class contains some useful methods to enable checks to be
/// performed in a more fluid, English sentence, style.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// The IsNull method, as you would expect, checks whether the string is, in fact, null.
    /// </summary>
    /// <param name="value">The string to check for being null.</param>
    /// <returns>True if the string is null, False otherwise.</returns>
    public static bool IsNull(this string? value) => value is null;

    /// <summary>
    /// The IsNotNull method, as you would expect, checks whether the string is not null.
    /// </summary>
    /// <param name="value">The string to check for being not null.</param>
    /// <returns>True if the string is not null, False otherwise.</returns>
    public static bool IsNotNull(this string? value) => !value.IsNull();

    /// <summary>
    /// The ToJson method, as you would expect, converts the object to the appropriate JSON representation.
    /// </summary>
    /// <param name="object">The object to convert to JSON.</param>
    /// <returns>The JSON string of the object supplied.</returns>
    public static string ToJson<T>(this T @object) => System.Text.Json.JsonSerializer.Serialize(@object);
}
