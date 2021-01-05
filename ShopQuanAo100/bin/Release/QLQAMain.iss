; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "QLQA"
#define MyAppVersion "1.5"
#define MyAppPublisher "Nhom24, Inc."
#define MyAppURL "https://www.example.com/"
#define MyAppExeName "ShopQuanAo100.exe"
#define MyAppAssocName MyAppName + ""
#define MyAppAssocExt ".myp"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{DCB0839D-5DC3-4871-9980-030B5E5286BA}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName=C:\{#MyAppName}
ChangesAssociations=yes
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
OutputDir=C:\Users\vip\Desktop
OutputBaseFilename=QLQA
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\vip\Desktop\QuanLyCuaHangQuanAo\ShopQuanAo100\bin\Release\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\vip\Desktop\QuanLyCuaHangQuanAo\ShopQuanAo100\bin\Release\FontAwesome.Sharp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\vip\Desktop\QuanLyCuaHangQuanAo\ShopQuanAo100\bin\Release\QLQA.iss"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\vip\Desktop\QuanLyCuaHangQuanAo\ShopQuanAo100\bin\Release\QLQA_Main.mdf"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\vip\Desktop\QuanLyCuaHangQuanAo\ShopQuanAo100\bin\Release\QLQA_Main_log.ldf"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\vip\Desktop\QuanLyCuaHangQuanAo\ShopQuanAo100\bin\Release\QLQAscrip.iss"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\vip\Desktop\QuanLyCuaHangQuanAo\ShopQuanAo100\bin\Release\ShopQuanAo100.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\vip\Desktop\QuanLyCuaHangQuanAo\ShopQuanAo100\bin\Release\ShopQuanAo100.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\vip\Desktop\QuanLyCuaHangQuanAo\ShopQuanAo100\bin\Release\ShopQuanAo100.pdb"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Registry]
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocExt}\OpenWithProgids"; ValueType: string; ValueName: "{#MyAppAssocKey}"; ValueData: ""; Flags: uninsdeletevalue
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}"; ValueType: string; ValueName: ""; ValueData: "{#MyAppAssocName}"; Flags: uninsdeletekey
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{#MyAppExeName},0"
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
Root: HKA; Subkey: "Software\Classes\Applications\{#MyAppExeName}\SupportedTypes"; ValueType: string; ValueName: ".myp"; ValueData: ""

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
