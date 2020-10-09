$currentDirectory = $PSScriptRoot

cd $currentDirectory

"Pushing new version of the SignalRServerHub to the Public folder"

$destinationPath = "C:\Public\SignalRServerHub"

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
 
$sourcePath = ".\SignalRServerHub\bin\Release\*"

Copy-Item -Path $sourcePath -Destination  $destinationPath