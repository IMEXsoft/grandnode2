﻿//Source https://github.com/OrchardCMS/OrchardCore/tree/dev/src/OrchardCore

using Grand.Business.Core.Interfaces.Storage;
using Microsoft.Extensions.FileProviders;

namespace Grand.Business.Storage.Services;

public class FileSystemStoreEntry : IFileStoreEntry
{
    private readonly IFileInfo _fileInfo;

    internal FileSystemStoreEntry(string path, IFileInfo fileInfo)
    {
        _fileInfo = fileInfo ?? throw new ArgumentNullException(nameof(fileInfo));
        Path = path ?? throw new ArgumentNullException(nameof(path));
    }

    public string Path { get; }

    public string Name => _fileInfo.Name;
    public string DirectoryPath => Path[..^Name.Length].TrimEnd('/');
    public string PhysicalPath => _fileInfo.PhysicalPath;
    public DateTime LastModifiedUtc => _fileInfo.LastModified.UtcDateTime;
    public long Length => _fileInfo.Length;
    public bool IsDirectory => _fileInfo.IsDirectory;
}