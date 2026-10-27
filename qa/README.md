# Offline Windows console exercise test

Run the existing `Exercisse_01/Program.cs` entrypoint **as a compiled executable**
against three sets of real console input. Verify arithmetic, carpet area,
formatted price and minutes-to-hours behavior (12 assertions total).

```powershell
powershell.exe -NoProfile -NonInteractive -ExecutionPolicy Bypass -File qa/run-console-contract.ps1
```

Uses the already-installed Windows .NET Framework C# compiler if present.
No NuGet restore, Docker, network, new dependency, website, or GUI interaction.
Only this specific console exercise is in scope, not the whole solution.
The script reports a failure when the compiler is not available instead of
installing a replacement. **Draft PR: Windows test execution not yet verified.**
