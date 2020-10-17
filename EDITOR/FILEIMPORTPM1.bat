@Echo off & Setlocal EnableDelayedExpansion
rem preparation command
set pwshcmd=powershell -NoP -C "[System.Reflection.Assembly]::LoadWithPartialName('System.windows.forms')|Out-Null;$OFD = New-Object System.Windows.Forms.OpenFileDialog;$OFD.Multiselect = $True;$OFD.Filter = 'PM1 (*.pm1)| *.pm1';$OFD.InitialDirectory = [Environment]::GetFolderPath('Desktop');$OFD.ShowDialog()|out-null;$OFD.FileNames"

rem exec commands powershell and get result in FileName variable
Set i=0
for /f "delims=" %%I in ('%pwshcmd%') do (
    Set /A i+=1
    set "FileName[!i!]=%%I"
PersonaEditorCMD.exe "%%I" -impptp /sub -save
    echo;
if exist "%%I.PTP" del "%%I.PTP"
)
