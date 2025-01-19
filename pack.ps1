Write-Host "Incrementing version..."

$projectPath = ".\LealThemes\LealThemes.csproj"
$fileContent = Get-Content $projectPath
$versionLine = $fileContent | Select-String -Pattern "<Version>(.+?)</Version>"

# Backup .csproj file
$backupPath = "$projectPath.bak"
Copy-Item $projectPath $backupPath -Force

if ($null -ne $versionLine) {
    $currentVersion = $versionLine.Matches.Groups[1].Value
    $versionParts = $currentVersion -split '\.'

    # increment version
    $versionParts[-1] = [int]$versionParts[-1] + 1
    $newVersion = ($versionParts -join ".")

    # update in .csproj file
    $updatedContent = $fileContent -replace "<Version>.+?</Version>", "<Version>$newVersion</Version>"
    Set-Content $projectPath -Value $updatedContent

    Write-Host "Version updated to $newVersion"
} else {
    Write-Host "No <Version> tag found. Adding a default version (1.0.0)."
    $defaultVersion = "1.0.0"
    $updatedContent = $fileContent -replace "(<PropertyGroup>)", "`$1`n        <Version>$defaultVersion</Version>"
    Set-Content $projectPath -Value $updatedContent
    Write-Host "Default version added: $defaultVersion"
}

Write-Host "Do you want to publish the project with the updated version? (Y/n)"
$confirmation = Read-Host

if ($confirmation -eq "n") {
    Write-Host "Reverting the .csproj file to the original version..."
    Move-Item $backupPath $projectPath -Force
    Write-Host "Reversion completed. No package generated."
    exit 0
}

Set-Location -Path ".\LealThemes"
Write-Host "Packing the project..."

dotnet pack -c Release

Set-Location -Path "..\"
Remove-Item $backupPath -Force

Write-Host "Pack completed successfully!"