param
(
    [Parameter(Mandatory = $true)]
    [string]$Session
)

Import-Module (Join-Path $PSCommandPath ".." "Modules" FilesCreation.psm1)

$urlBase = "https://adventofcode.com/2022/day/"

$repositoryRoot = Join-Path $PSCommandPath ".." ".."
$adventOfCodeFolder = Join-Path $repositoryRoot "AdventOfCode2022"

function GetAndSaveInput([string]$Number)
{
    $url = $urlBase + ([int]$Number) + "/input"

    $cookie = "session=$Session"
    $response = Invoke-WebRequest -Uri $url -Headers @{ "Cookie" = $cookie }

    $content = $response.Content
    $content = $content -replace "\s+$", ""
    $content = $content -split "`n"

    $folder = Join-Path $adventOfCodeFolder "Day$Number"
    $file = Join-Path $folder "Input.txt"
    CreateFile -Path $file -Content $content
}

for ($i = 1; $i -le 9; $i++)
{
    GetAndSaveInput -Number "0$i"
}

for ($i = 10; $i -le 25; $i++)
{
    GetAndSaveInput -Number $i
}