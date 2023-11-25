$puzzleInput =
"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000"

$result = ($puzzleInput -split "`r`n") -join "\r\n"

Write-Host $result