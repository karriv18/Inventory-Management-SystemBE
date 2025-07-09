namespace Inmasys.FileManager.Configuration;
/// <summary>
/// File Upload / Download Configuration Options.
/// </summary>
public class FileManagerConfigurationOption
{
    public const string SectionName = "FileManager";

    /// <summary>
    /// Base Directory Name where all uploaded files will be stored.
    /// </summary>
    public required string DirectoryName { get; set; } = default!;

    /// <summary>
    /// List of Accepted Filed Extensions
    /// </summary>
    public required IEnumerable<string> AcceptedExtensions { get; set; } = [];

    /// <summary>
    /// List of Accepted Image Extensions
    /// </summary>
    public required IEnumerable<string> AcceptedImageExtensions { get; set; } = [];

    /// <summary>
    /// Max File Size that will be accepted by the system in Megabytes.
    /// </summary>
    public required int MaxFileSize { get; set; }
}
