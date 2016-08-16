; -- NumbeRun.iss --
; Same as Example1.iss, but creates some registry entries too.

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!

#define AppName "NumbeRun"
#define EditorName "Editor Maps"
#define AppPublisher "RPGames"
#define Version "2.0"
#define VersionInfo "2.0.0.0"
#define OutputDir "Setup NumbeRun noS"

#define comment "Lancia il gioco di NumbeRun"
#define commentEditor "Diventa realizzatore di nuove mappe per NumbeRun con l'Editor Maps"

#define Path "bin\x86\Debug\"

[Setup]
; scelta delle immagini
WizardImageFile={#OutputDir}\WizModernImage.bmp
WizardSmallImageFile={#OutputDir}\WizModernSmallImage.bmp

PrivilegesRequired=none
AppCopyright=Copyright (C) 2004-2007 RPGames, Inc.
AppPublisher={#AppPublisher}
AppPublisherURL=marco.monta88@libero.it
AppVersion={#Version}
AppSupportURL=marco.monta88@libero.it
AppUpdatesURL=http://mmorpggameonline.altervista.org/
AppComments=Game
AppName={#AppName}
AppVerName=NumbeRun version {#Version}
DefaultDirName={pf}\{#AppPublisher}\{#AppName}
DefaultGroupName={#AppPublisher}\{#AppName}
; File uninstall
UninstallDisplayName=Disinstalla NumbeRun
UninstallDisplayIcon={app}\NumbeRun.exe

OutputDir={#OutputDir}
OutputBaseFilename={#AppName} v{#Version} noS
SetupIconFile={#OutputDir}\setup.ico
Compression=lzma/max
CreateAppDir=yes
AllowNoIcons=yes
SolidCompression=yes
VersionInfoVersion={#VersionInfo}
;LicenseFile=License.txt



[Files]
; file eseguibile principale
Source: "{#Path}NumbeRun.exe"; DestDir: "{app}"
; file eseguibile (Launcher del gioco)
Source: "{#Path}LaunchNumbeRun.exe"; DestDir: "{app}"
; dll per l'esecuzione del filmato
Source: "{#Path}AxInterop.WMPLib.dll"; DestDir: "{app}"
Source: "{#Path}Interop.WMPLib.dll"; DestDir: "{app}"
; dll per l'esecuzione del filmato
Source: "{#Path}RPGames Intro.wmv"; DestDir: "{app}"
; file eseguibile Editor Maps
Source: "{#Path}EditorMaps.exe"; DestDir: "{app}"
; manuale del gioco
Source: "{#Path}NumbeRun - Manuale del giocatore.pdf"; DestDir: "{app}"; Flags: isreadme;
; manuale dell'editor
Source: "{#Path}Editor Maps - Manuale del giocatore.pdf"; DestDir: "{app}"; Flags: isreadme;
; dll da utilizzare (poi da installare a parte)
Source: "{#Path}Npgsql.dll"; DestDir: "{app}"
Source: "{#Path}Mono.Security.dll"; DestDir: "{app}"
Source: "{#Path}d3dx9_31.dll"; DestDir: "{app}"
Source: "{#Path}Microsoft.Xna.Framework.dll"; DestDir: "{app}"
Source: "{#Path}Microsoft.Xna.Framework.Game.dll"; DestDir: "{app}"
Source: "{#Path}x3daudio1_1.dll"; DestDir: "{app}"
Source: "{#Path}xactengine2_4.dll"; DestDir: "{app}"
Source: "{#Path}xinput1_3.dll"; DestDir: "{app}"
Source: "{#Path}XnaNative1.dll"; DestDir: "{app}"
; texture delle immagini
Source: "{#Path}textures\crediti.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\faceset.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\femmina.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\fulltileset.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\fulltileset_other.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\gamescreen.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\gamescreen_intro.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\guida.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\maps.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\maschio.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\menu_background.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\menu_text.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\mostro1.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\mostro2.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\mostro3.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\mostro4.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\mostro5.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\TextSet.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\TextSet_Word.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\player_online.xnb"; DestDir: "{app}\textures"
Source: "{#Path}textures\highscore_tab.xnb"; DestDir: "{app}\textures"
; file leggimi
;Source: "Readme.txt"; DestDir: "{app}"; Flags: isreadme

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked

[Icons]
Name: {userdesktop}\{#AppName}; Filename: {app}\LaunchNumbeRun.exe; WorkingDir: "{app}"; Comment: {#comment}; Tasks: desktopicon
Name: {userdesktop}\{#EditorName}; Filename: {app}\EditorMaps.exe; WorkingDir: "{app}"; Comment: {#commentEditor}; Tasks: desktopicon

Name: "{group}\{#AppName}"; Filename: "{app}\LaunchNumbeRun.exe"; WorkingDir: "{app}"; Comment: {#comment};
Name: "{group}\{#EditorName}"; Filename: "{app}\EditorMaps.exe"; WorkingDir: "{app}"; Comment: {#commentEditor};

Name: {group}\{cm:UninstallProgram,{#AppName}}; Filename: {uninstallexe}

; NOTE: Most apps do not need registry entries to be pre-created. If you
; don't know what the registry is or if you need to use it, then chances are
; you don't need a [Registry] section.

[Registry]
; Start "Software\My Company\My Program" keys under HKEY_CURRENT_USER
; and HKEY_LOCAL_MACHINE. The flags tell it to always delete the
; "My Program" keys upon uninstall, and delete the "My Company" keys
; if there is nothing left in them.
Root: HKCU; Subkey: "Software\RPGames"; Flags: uninsdeletekeyifempty
Root: HKCU; Subkey: "Software\RPGames\NumbeRun"; Flags: uninsdeletekey
Root: HKLM; Subkey: "Software\RPGames"; Flags: uninsdeletekeyifempty
Root: HKLM; Subkey: "Software\RPGames\NumbeRun"; Flags: uninsdeletekey
Root: HKLM; Subkey: "Software\RPGames\NumbeRun\Settings"; ValueType: string; ValueName: "Path"; ValueData: "{app}"

[Code]
procedure AboutButtonOnClick(Sender: TObject);
begin
  MsgBox('NumbeRun {#Version}' #13#13 'per informazioni e consigli -->' #13 'e-mail: marco.monta88@libero.it', mbInformation, mb_Ok);
end;

procedure InitializeWizard();
var
  AboutButton, CancelButton: TButton;
  BackgroundBitmapImage: TBitmapImage;
  BackgroundBitmapText: TNewStaticText;
begin
  { Other custom controls }

  CancelButton := WizardForm.CancelButton;

  AboutButton := TButton.Create(WizardForm);
  AboutButton.Left := WizardForm.ClientWidth - CancelButton.Left - CancelButton.Width;
  AboutButton.Top := CancelButton.Top;
  AboutButton.Width := CancelButton.Width;
  AboutButton.Height := CancelButton.Height;
  AboutButton.Caption := '&About...';
  AboutButton.OnClick := @AboutButtonOnClick;
  AboutButton.Parent := WizardForm;

  BackgroundBitmapImage := TBitmapImage.Create(MainForm);
  BackgroundBitmapImage.Left := 50;
  BackgroundBitmapImage.Top := 100;
  BackgroundBitmapImage.AutoSize := True;
  BackgroundBitmapImage.Bitmap := WizardForm.WizardBitmapImage.Bitmap;
  BackgroundBitmapImage.Parent := MainForm;

  BackgroundBitmapText := TNewStaticText.Create(MainForm);
  BackgroundBitmapText.Left := BackgroundBitmapImage.Left;
  BackgroundBitmapText.Top := BackgroundBitmapImage.Top + BackgroundBitmapImage.Height + ScaleY(8);
  BackgroundBitmapText.Caption := 'TBitmapImage';
  BackgroundBitmapText.Parent := MainForm;
end;
