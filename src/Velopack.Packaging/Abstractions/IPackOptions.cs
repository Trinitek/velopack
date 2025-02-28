﻿namespace Velopack.Packaging.Abstractions;

public interface IPackOptions : INugetPackCommand, IPlatformOptions
{
    string Channel { get; }
    DeltaMode DeltaMode { get; }
    string EntryExecutableName { get; }
    string Icon { get; }
    string Exclude { get; }
    bool NoPortable { get; }
    bool NoInst { get; }
}
