$version = "3.5.3.1"

(Get-Content TradePlatform.MT4.SDK.API\Properties\AssemblyInfo.cs) | 
Foreach-Object {$_ -replace "[0-9]+\.[0-9]+\.[0-9]+\.[0-9]+", $version} | 
Set-Content TradePlatform.MT4.SDK.API\Properties\AssemblyInfo.cs -encoding UTF8

(Get-Content TradePlatform.MT4.SDK.Library\Properties\AssemblyInfo.cs) | 
Foreach-Object {$_ -replace "[0-9]+\.[0-9]+\.[0-9]+\.[0-9]+", $version} | 
Set-Content TradePlatform.MT4.SDK.Library\Properties\AssemblyInfo.cs -encoding UTF8

(Get-Content TradePlatform.MT4.SDK_Release_Internal.nuspec) | 
Foreach-Object {$_ -replace "<version>[0-9]+\.[0-9]+\.[0-9]+\.[0-9]+", "<version>$version"} | 
Set-Content TradePlatform.MT4.SDK_Release_Internal.nuspec -encoding UTF8

C:\Windows\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe "TradePlatform.MT4.SDK.sln" /t:build /p:Configuration=Debug

.nuget\nuget pack TradePlatform.MT4.SDK_Release_Internal.nuspec
copy *.nupkg C:\Dropbox\Nugets\
del *.nupkg
