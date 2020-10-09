$currentDirectory = $PSScriptRoot

cd $currentDirectory

$destinationPath = "C:\Public\SignalRListener"

if (-not (Test-Path -LiteralPath $destinationPath))
{
    try
    {
        New-Item -Path $destinationPath -ItemType Directory -ErrorAction Stop | Out-Null #-Force
	}
    catch
    {
	    Write-Error -Message "Unable to create Directory '$destinationPath'.  Error was: $_"
		Exit
	}

    "Output Directory '$destinationServer' created"
}

$signalRFiles = @(
	".\SignalRListener\bin\Release\Newtonsoft.Json.dll"
	".\SignalRListener\bin\Release\Microsoft.AspNet.SignalR.Client.dll"
	".\SignalRListener\bin\Release\VNC.Logging.CustomTraceListeners.SignalRListener.dll")
	
"Pushing new version of the SignalRListener files to the Public folder"

Foreach ($file in $signalRFiles)
{
    $file
	Copy-Item -Path $file -Destination $destinationPath
}