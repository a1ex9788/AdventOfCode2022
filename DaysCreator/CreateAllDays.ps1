$dayXXSolverTemplatePath = "DayXXSolver.cs"
$dayXXSolverTestsTemplatePath = "DayXXSolverTests.cs"

$repositoryRoot = Join-Path $PSCommandPath ".." ".."
$daysCreatorFolder = Join-Path $repositoryRoot "DaysCreator"
$adventOfCodeFolder = Join-Path $repositoryRoot "AdventOfCode2022"

$dayXXSolverTemplate = Get-Content (Join-Path $daysCreatorFolder $dayXXSolverTemplatePath)
$dayXXSolverTestsTemplate = Get-Content (Join-Path $daysCreatorFolder $dayXXSolverTestsTemplatePath)

function CreateFile([string]$Path, [string[]]$Content)
{
    $Content -join "`r`n" | Set-Content $Path -NoNewline -Encoding UTF-8
}

function CreateFiles([string]$Number)
{
    $folder = Join-Path $adventOfCodeFolder "Day$Number"

    if (-not (Test-Path $folder))
    {
        New-Item $folder -ItemType Directory
    }

    $file = Join-Path $folder "Day$($Number)Solver.cs"
    $content = $dayXXSolverTemplate.Replace("XX", $Number)
    CreateFile -Path $file -Content $content

    $file = Join-Path $folder "Input.txt"
    $content = "5"
    CreateFile -Path $file -Content $content

    $file = Join-Path $folder "Part1Output.txt"
    $content = "-1"
    CreateFile -Path $file -Content $content

    $file = Join-Path $folder "Part2Output.txt"
    $content = "-1"
    CreateFile -Path $file -Content $content

    $file = Join-Path $adventOfCodeFolder "Tests" "UnitTests" "Day$($Number)SolverTests.cs"
    $content = $dayXXSolverTestsTemplate.Replace("XX", $Number)
    CreateFile -Path $file -Content $content
}

for ($i = 1; $i -le 9; $i++)
{
    CreateFiles -Number "0$i"
}

for ($i = 10; $i -le 25; $i++)
{
    CreateFiles -Number $i
}