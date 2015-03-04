$version = "3.6.0.0"

(Get-Content TradePlatform.MT4.Demo.Console\Properties\AssemblyInfo.cs) | 
Foreach-Object {$_ -replace "[0-9]+\.[0-9]+\.[0-9]+\.[0-9]+", $version} | 
Set-Content TradePlatform.MT4.Demo.Console\Properties\AssemblyInfo.cs -encoding UTF8

(Get-Content TradePlatform.MT4.Demo.Library\Properties\AssemblyInfo.cs) | 
Foreach-Object {$_ -replace "[0-9]+\.[0-9]+\.[0-9]+\.[0-9]+", $version} | 
Set-Content TradePlatform.MT4.Demo.Library\Properties\AssemblyInfo.cs -encoding UTF8

(Get-Content TradePlatform.MT4.Demo.Web\Properties\AssemblyInfo.cs) | 
Foreach-Object {$_ -replace "[0-9]+\.[0-9]+\.[0-9]+\.[0-9]+", $version} | 
Set-Content TradePlatform.MT4.Demo.Web\Properties\AssemblyInfo.cs -encoding UTF8

(Get-Content TradePlatform.MT4.Demo.Win\Properties\AssemblyInfo.cs) | 
Foreach-Object {$_ -replace "[0-9]+\.[0-9]+\.[0-9]+\.[0-9]+", $version} | 
Set-Content TradePlatform.MT4.Demo.Win\Properties\AssemblyInfo.cs -encoding UTF8

(Get-Content TradePlatform.MT4.Demo.WindowsService\Properties\AssemblyInfo.cs) | 
Foreach-Object {$_ -replace "[0-9]+\.[0-9]+\.[0-9]+\.[0-9]+", $version} | 
Set-Content TradePlatform.MT4.Demo.WindowsService\Properties\AssemblyInfo.cs -encoding UTF8

(Get-Content TradePlatform.MT4.Demo.WPF\Properties\AssemblyInfo.cs) | 
Foreach-Object {$_ -replace "[0-9]+\.[0-9]+\.[0-9]+\.[0-9]+", $version} | 
Set-Content TradePlatform.MT4.Demo.WPF\Properties\AssemblyInfo.cs -encoding UTF8

C:\Windows\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe "TradePlatform.MT4.Demo.sln" /t:build /p:Configuration=Release

del TradePlatform.MT4.Demo.Terminal\experts\*.ex4
del TradePlatform.MT4.Demo.Terminal\experts\indicators\*.ex4
del TradePlatform.MT4.Demo.Terminal\experts\scripts\*.ex4

del TradePlatform.MT4.Demo.Terminal\experts\*.log
del TradePlatform.MT4.Demo.Terminal\experts\indicators\*.log
del TradePlatform.MT4.Demo.Terminal\experts\scripts\*.log

$files = get-childitem -path TradePlatform.MT4.Demo.Terminal\experts -filter *.mq4
foreach ($file in $files)
{
	TradePlatform.MT4.Demo.Terminal\metalang "TradePlatform.MT4.Demo.Terminal\experts\$($file.BaseName).mq4" "TradePlatform.MT4.Demo.Terminal\experts\$($file.BaseName).ex4"
}

$files = get-childitem -path TradePlatform.MT4.Demo.Terminal\experts\indicators -filter *.mq4
foreach ($file in $files)
{
	TradePlatform.MT4.Demo.Terminal\metalang "TradePlatform.MT4.Demo.Terminal\experts\indicators\$($file.BaseName).mq4" "TradePlatform.MT4.Demo.Terminal\experts\indicators\$($file.BaseName).ex4"
}

$files = get-childitem -path TradePlatform.MT4.Demo.Terminal\experts\scripts -filter *.mq4
foreach ($file in $files)
{
	TradePlatform.MT4.Demo.Terminal\metalang "TradePlatform.MT4.Demo.Terminal\experts\scripts\$($file.BaseName).mq4" "TradePlatform.MT4.Demo.Terminal\experts\scripts\$($file.BaseName).ex4"
}

del C:\Dropbox\Warehouse\TradePlatform.MT4\Sample\$version\*.*

xcopy /y TradePlatform.MT4.Demo.Console\bin\Release\TradePlatform.MT4.Demo.Console.exe C:\Dropbox\Warehouse\TradePlatform.MT4\Sample\$version\Console\*.*
xcopy /y TradePlatform.MT4.Demo.Console\bin\Release\TradePlatform.MT4.Demo.Console.exe.config C:\Dropbox\Warehouse\TradePlatform.MT4\Sample\$version\Console\*.*
xcopy /y TradePlatform.MT4.Demo.Console\bin\Release\*.dll C:\Dropbox\Warehouse\TradePlatform.MT4\Sample\$version\Console\*.*

xcopy /y TradePlatform.MT4.Demo.Terminal\experts\Expert_*.ex4 C:\Dropbox\Warehouse\TradePlatform.MT4\Sample\$version\Terminal\experts\*.*
xcopy /y TradePlatform.MT4.Demo.Terminal\experts\indicators\Indicator_*.ex4 C:\Dropbox\Warehouse\TradePlatform.MT4\Sample\$version\Terminal\experts\indicators\*.*
xcopy /y TradePlatform.MT4.Demo.Terminal\experts\scripts\Script_*.ex4 C:\Dropbox\Warehouse\TradePlatform.MT4\Sample\$version\Terminal\experts\scripts\*.*