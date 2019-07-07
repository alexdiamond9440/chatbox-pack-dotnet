# This artifact captures all variables defined in the ..\variables folder.
# It "snaps" the values of these variables where we can compute them during the build,
# and otherwise captures the scripts to run later during an Azure Pipelines environment release.

$RepoRoot = [System.IO.Path]::GetFullPath("$PSScriptRoot\..\..")
$ArtifactBasePath = "$RepoRoot\obj\_artifacts"
$VariablesArtifactPath = "$ArtifactBasePath\variables"
if (-not (Test-Path $VariablesArtifactPath)) { New-Item -ItemType Directory -Path $VariablesArtifactPath | Out-Null }

# Copy variables, either by value if the value is calculable now, or by script
Get-ChildItem -Path "$PSScriptRoot\..\variables" |% {
    $value = $null
    if (-not $_.BaseName.StartsWith('_')) { # Skip trying to interpret special scripts
        # First check the environment variables in case the variable was set in a queued build
        if (Test-Path env:$($_.BaseName)) {
            $value = Get-Content "env:$($_.BaseName)"
        }

        # If that didn't give us anything, try executing the script right now from its original position
        if (-not $value) {
            $value = & $_.FullName
        }

        if ($value) {
            # We got something, so wrap it with quotes so it's treated like a literal value.
            $value = "'$value'"
        }
    }

    # If that didn't get us anything, just copy the script itself
    if (-not $value) {
        $value = Get-Content -Path $_.FullName
    }

    Set-Content -Path "$VariablesArtifactPath\$($_.Name)" -Value $value
}

@{
    "$VariablesArtifactPath" = (Get-ChildItem $VariablesArtifactPath -Recurse);
}
