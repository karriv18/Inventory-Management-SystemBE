﻿using Microsoft.Extensions.DependencyInjection;

namespace Inmasys.FileManager.Builder;

public class FileManagerBuilder(IServiceCollection services) : IFileManagerBuilder
{
    public IServiceCollection Services { get; } = services;
}
