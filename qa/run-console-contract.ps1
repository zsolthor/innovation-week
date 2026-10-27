# Real console I/O regression tests against the unmodified Exercisse_01 C# entrypoint.
# Works with pre-installed Windows .NET Framework csc.exe; no restore, network or GUI.
$ErrorActionPreference = 'Stop'
Set-StrictMode -Version Latest
$root = (Resolve-Path -LiteralPath (Join-Path $PSScriptRoot '..')).Path
$compilerCandidates = @(
    (Join-Path $env:WINDIR 'Microsoft.NET\Framework64/v4.0.30319/csc.exe'),
    (Join-Path $env:WINDIR 'Microsoft.NET/Framework/v4.0.30319/csc.exe')
)
$compiler = $compilerCandidates | Where-Object { Test-Path -LiteralPath $_ -PathType Leaf } | Select-Object -First 1
if (-not $compiler) { throw 'QA_INNOVATION_CSC_NOT_AVAILABLE: no installation or fallback' }
$program = Join-Path $root 'innovation week/Exercisse_01/Program.cs'
if (-not (Test-Path -LiteralPath $program -PathType Leaf)) { throw 'QA_INNOVATION_EXERCISE_SOURCE_MISSING' }

$folder = Join-Path ([System.IO.Path]::GetTempPath()) ('qa-innovation-' + [guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $folder -ErrorAction Stop | Out-Null
try {
    $exe = Join-Path $folder 'Exercise1.exe'
    & $compiler '/nologo' '/target:exe' '/r:System.Core.dll' ("/out:$exe") $program
    if ($LASTEXITCODE -ne 0 -or -not (Test-Path -LiteralPath $exe -PathType Leaf)) {
        throw 'QA_INNOVATION_COMPILE_FAILED'
    }
    $cases = @(
        @{ Input = @('4','7','3','4','75'); Expected = @('4 + 7 = 11', 'area: 12', '66[.,]00', '75 minutes is equal to 1 hours and 15 minutes') },
        @{ Input = @('0','0','1','1','0'); Expected = @('0 + 0 = 0', 'area: 1', '5[.,]50', '0 minutes is equal to 0 hours and 0 minutes') },
        @{ Input = @('-5','2','10','10','120'); Expected = @('-5 + 2 = -3', 'area: 100', '550[.,]00', '120 minutes is equal to 2 hours and 0 minutes') }
    )
    $assertions = 0
    foreach ($case in $cases) {
        # One input value per line, like a real console user.
        $output = @($case.Input | & $exe 2>&1)
        if ($LASTEXITCODE -ne 0) { throw 'QA_INNOVATION_PROGRAM_EXIT_NONZERO' }
        $combined = ($output | Out-String)
        foreach ($pattern in $case.Expected) {
            if ($combined -notmatch [string]$pattern) {
                throw ('QA_INNOVATION_CONSOLE_BEHAVIOR_FAILED: ' + $pattern)
            }
            $assertions++
        }
    }
    Write-Host ('QA_INNOVATION_CONSOLE_PASS: ' + $assertions + ' real behavior checks')
} finally {
    Remove-Item -LiteralPath $folder -Recurse -Force -ErrorAction SilentlyContinue
}
