$currentDirectory = $PSScriptRoot

cd $currentDirectory

"Pushing new version of the SignalRClient to the Public folder"

$destinationPath = "C:\Public\SignalRClient"
$sourcePath = ".\SignalRClient\bin\Release"
$sourceFiles = "$sourcePath\*"

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

if (-not (Test-Path -LiteralPath $sourcePath))
{
     Write-Error -Message "SourcePath: '$sourcePath' does not exist.  Aborting"
	 Exit
}

Copy-Item -Path $sourceFiles -Destination  $destinationPath