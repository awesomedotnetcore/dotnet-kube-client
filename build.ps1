$ErrorActionPreference = 'Stop'

$versionInfo = .\tools\GitVersion\GitVersion.exe | ConvertFrom-Json

$versionPrefix = $versionInfo.MajorMinorPatch
$versionSuffix = $versionInfo.NuGetPreReleaseTagV2
$informationalVersion = $versionInfo.InformationalVersion

$dotnet = Get-Command dotnet
& $dotnet restore /p:VersionPrefix="$versionPrefix" /p:VersionSuffix="$versionSuffix" /p:AssemblyInformationalVersion="$informationalVersion"
& $dotnet build /p:VersionPrefix="$versionPrefix" /p:VersionSuffix="$versionSuffix" /p:AssemblyInformationalVersion="$informationalVersion"
& $dotnet pack /p:VersionPrefix="$versionPrefix" /p:VersionSuffix="$versionSuffix" /p:AssemblyInformationalVersion="$informationalVersion" --include-symbols -o "$PWD\out"