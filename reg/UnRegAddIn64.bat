@ECHO OFF
REM The following directory is for .NET 4.0
set DOTNETFX4=%SystemRoot%\Microsoft.NET\Framework64\v4.0.30319
set PATH=%PATH%;%DOTNETFX4%
echo ---------------------------------------------------
regasm.exe "%~dp0AddIn.ScannerBarcode.dll" /unregister
echo ---------------------------------------------------
pause