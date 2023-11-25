function CreateFile([string]$Path, [string[]]$Content)
{
    $Content -join "`r`n" | Set-Content $Path -NoNewline -Encoding UTF-8
}