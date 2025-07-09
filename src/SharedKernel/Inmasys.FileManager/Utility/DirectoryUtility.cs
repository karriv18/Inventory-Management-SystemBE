namespace Inmasys.FileManager.Utility;

public static class DirectoryUtility
{
    private static string GetCurrentDirectory => Directory.GetCurrentDirectory();

    /// <summary>
    /// Generate Module path composed of Default Upload Directory and supplied specific Module Directory Name
    /// </summary>
    /// <param name="baseUploadDirectoryName"></param>
    /// <param name="moduleDirectoryName"></param>
    /// <returns>Generated Module Path</returns>
    private static string GenerateModulePath(string baseUploadDirectoryName, string moduleDirectoryName)
    {
        var filePath = string.Concat(GetCurrentDirectory, '/', baseUploadDirectoryName, '/', moduleDirectoryName);

        if (!Directory.Exists(filePath)) Directory.CreateDirectory(filePath);

        return filePath;
    }

    /// <summary>
    /// Generate Complete File Directory 
    /// </summary>
    /// <param name="baseUploadDirectoryName">Base Upload Directory</param>
    /// <param name="moduleDirectoryName">Specific Module Directory Name</param>
    /// <param name="fileName">Generated File Name of the file being uploaded</param>
    /// <returns>Complete File Directory composed of the supplied Base Upload Directory Path, Module Directory Path and File Name</returns>
    public static string GenerateCompleteFilePath(string baseUploadDirectoryName, string moduleDirectoryName, string fileName) => 
        Path.Combine(GenerateModulePath(baseUploadDirectoryName, moduleDirectoryName), fileName);

}
