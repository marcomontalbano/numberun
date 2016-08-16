object Form4: TForm4
  Left = 367
  Top = 48
  BorderIcons = [biMinimize, biMaximize]
  BorderStyle = bsToolWindow
  Caption = 'Crea oggetto'
  ClientHeight = 257
  ClientWidth = 481
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poDesktopCenter
  PixelsPerInch = 96
  TextHeight = 13
  object Bevel1: TBevel
    Left = 0
    Top = 0
    Width = 185
    Height = 257
    Shape = bsFrame
    Style = bsRaised
  end
  object Label1: TLabel
    Left = 8
    Top = 8
    Width = 73
    Height = 15
    Caption = 'Nome oggetto:'
    Font.Charset = ANSI_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label2: TLabel
    Left = 8
    Top = 56
    Width = 128
    Height = 15
    Caption = 'Descrizione dell'#39'oggetto:'
    Font.Charset = ANSI_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label3: TLabel
    Left = 8
    Top = 104
    Width = 99
    Height = 15
    Caption = 'Matrice di disegno:'
    Font.Charset = ANSI_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label4: TLabel
    Left = 8
    Top = 152
    Width = 91
    Height = 15
    Caption = 'Tipo di collisione:'
    Font.Charset = ANSI_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label5: TLabel
    Left = 8
    Top = 200
    Width = 153
    Height = 15
    Caption = 'Numero dell'#39'evento associato:'
    Font.Charset = ANSI_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Bevel2: TBevel
    Left = 184
    Top = 0
    Width = 249
    Height = 257
    Shape = bsFrame
    Style = bsRaised
  end
  object Label6: TLabel
    Left = 184
    Top = 8
    Width = 249
    Height = 15
    Alignment = taCenter
    AutoSize = False
    Caption = 'LEGENDA'
    Font.Charset = ANSI_CHARSET
    Font.Color = clGreen
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label7: TLabel
    Left = 192
    Top = 24
    Width = 77
    Height = 15
    Caption = '< Nome oggetto'
    Font.Charset = ANSI_CHARSET
    Font.Color = clMaroon
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label10: TLabel
    Left = 192
    Top = 56
    Width = 132
    Height = 15
    Caption = '< Descrizione dell'#39'oggetto'
    Font.Charset = ANSI_CHARSET
    Font.Color = clMaroon
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label11: TLabel
    Left = 200
    Top = 72
    Width = 194
    Height = 15
    Caption = 'deve essere di massimo 200 caratteri.'
    Font.Charset = ANSI_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label9: TLabel
    Left = 192
    Top = 88
    Width = 103
    Height = 15
    Caption = '< Matrice di disegno'
    Font.Charset = ANSI_CHARSET
    Font.Color = clMaroon
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label12: TLabel
    Left = 200
    Top = 104
    Width = 213
    Height = 15
    Caption = 'rappresenta il numero della matrice su cui'
    Font.Charset = ANSI_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label13: TLabel
    Left = 200
    Top = 120
    Width = 131
    Height = 15
    Caption = 'verr'#224' disegnato l'#39'oggetto.'
    Font.Charset = ANSI_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label14: TLabel
    Left = 200
    Top = 136
    Width = 221
    Height = 15
    Caption = '1 = BackGround  2 = 1a livello  3 = 2a livello'
    Font.Charset = ANSI_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label15: TLabel
    Left = 192
    Top = 152
    Width = 95
    Height = 15
    Caption = '< Tipo di collisione'
    Font.Charset = ANSI_CHARSET
    Font.Color = clMaroon
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label16: TLabel
    Left = 200
    Top = 168
    Width = 222
    Height = 15
    Caption = 'rappresenta il tipo di collisione dell'#39'oggetto'
    Font.Charset = ANSI_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label17: TLabel
    Left = 200
    Top = 184
    Width = 180
    Height = 15
    Caption = '0=dietro  1=invaricabile  2=davanti'
    Font.Charset = ANSI_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label19: TLabel
    Left = 192
    Top = 200
    Width = 95
    Height = 15
    Caption = '< Tipo di collisione'
    Font.Charset = ANSI_CHARSET
    Font.Color = clMaroon
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label20: TLabel
    Left = 200
    Top = 216
    Width = 221
    Height = 15
    Caption = 'rappresenta il numero dell'#39'evento associato'
    Font.Charset = ANSI_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label18: TLabel
    Left = 200
    Top = 232
    Width = 57
    Height = 15
    Caption = 'all'#39'oggetto.'
    Font.Charset = ANSI_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Bevel3: TBevel
    Left = 432
    Top = 0
    Width = 49
    Height = 201
    Shape = bsFrame
    Style = bsRaised
  end
  object Bevel4: TBevel
    Left = 432
    Top = 200
    Width = 49
    Height = 57
    Shape = bsFrame
    Style = bsRaised
  end
  object SpeedButton1: TSpeedButton
    Left = 440
    Top = 208
    Width = 33
    Height = 46
    Flat = True
    Glyph.Data = {
      36090000424D3609000000000000360000002800000018000000200000000100
      1800000000000009000000000000000000000000000000000000939300939300
      9393009393009393009393009393009393009393009393009393009393009393
      0093930093930093930093930093930093930093930093930093930093930093
      930093930093930093930093930000000000000010528B10528B10528B10528B
      00000000000000000010528B10528B10528B10528B0000000000009393009393
      0093930093930093930093930093930093930000000000000000000010528B62
      A4D57BBDF67BBDF610528B00000010528B7BBDF67BBDF662A4D510528B000000
      0000000000009393009393009393009393009393009393009393009393009393
      0000000000000010528B62A4D518087B18087B00000018087B18087B62A4D510
      528B000000000000939300939300939300939300939300939300939300939300
      93930093930093930018087B18087B18087B2018A42018A418087B18087B1808
      7B2018A42018A418087B18087B18087B93930093930093930093930093930093
      930093930093930093930093930018087B2018A42018A42018A42018A42920C5
      2920C518087B2018A42920C52018A42018A42018A42018A418087B9393009393
      0093930093930093930093930093930093930093930010528B18087B2018A431
      29E65A52FF3129E62920C518087B2920C53129E63129E63129E62018A418087B
      10528B93930093930093930093930093930093930093930093930010528B7BBD
      F618087B3129E63129E62920C52018A43129E618087B18087B2920C52920C531
      29E62018A418087B7BBDF610528B939300939300939300939300939300939300
      18087B10528B18087B18087B18087B2920C53129E62920C52018A418087B2018
      A43129E62920C52018A418087B18087B18087B10528B18087B93930093930093
      930093930052525218087B18087B2018A42018A42018A418087B2920C52018A4
      18087B18087B18087B2018A42920C518087B2018A42018A42018A418087B1808
      7B52525293930093930093930052525218087B2018A42018A42920C52018A418
      087B2018A418087B2018A418087B2018A418087B2018A418087B2018A42920C5
      2018A42018A418087B5252529393009393009393005252529C9C9C18087B2920
      C52920C52920C52018A418087B18087B2920C518087B2920C518087B18087B20
      18A42920C52920C52920C518087B9C9C9C525252939300939300525252D5D5D5
      9C9C9C9C9C9C18087B3129E62018A42018A452525220202018087B18087B1808
      7B2020205252522018A42018A43129E618087B9C9C9C9C9C9CD5D5D552525293
      9300525252D5D5D5F6F6F69C9C9C18087BC5F6FF94C5CD7B7B7B525252202020
      2020202020202020202020205252527B7B7B94C5CDC5F6FF18087B9C9C9CFFFF
      F6D5D5D5525252939300525252D5D5D5F6F6F6F6F6F69C9C9C3129E67B7B7BFF
      FFF65252522920C50000005A52FF3129E62018A4525252FFFFF67B7B7B3129E6
      9C9C9CFFFFF6FFFFF6D5D5D5525252939300939300525252F6F6F6D5D5D59C9C
      9C7B7B7BFFFFF69C9C9C5252520000003129E6317BB418087B2920C55252529C
      9C9CFFFFF67B7B7BD5D5D5D5D5D5FFFFF65252529393009393009393007B7B7B
      F6F6F69C9C9C7B7B7BFFFFF6D5D5D55252522018A4202020317BB462A4D51052
      8B18087B2018A4525252D5D5D5FFFFF67B7B7B9C9C9CD5D5D57B7B7B93930093
      93009393007B7B7BD5D5D59C9C9C7B7B7BFFFFF6D5D5D55252522920C5317BB4
      317BB4317BB410528B10528B2920C5525252D5D5D5FFFFF67B7B7B9C9C9CD5D5
      D57B7B7B9393009393009393007B7B7BD5D5D5F6F6F65252529C9C9CD5D5D552
      5252317BB462A4D57BBDF67BBDF662A4D5317BB410528B525252D5D5D59C9C9C
      525252FFFFF6D5D5D57B7B7B9393009393009393009393007B7B7BD5D5D5D5D5
      D57B7B7BD5D5D552525262A4D5F6F6F6007B837BBDF6007B83F6F6F6317BB452
      5252D5D5D57B7B7BFFFFF6D5D5D57B7B7B939300939300939300939300939300
      5252529C9C9CD5D5D55252529C9C9C7B7B7B000000F6F6F618BDBD62A4D518BD
      BDF6F6F60000007B7B7B9C9C9C525252D5D5D59C9C9C52525293930093930093
      93009393009393005252529C9C9CD5D5D59C9C9C5252527B7B7B000000FFD5AC
      000000525252000000FFD5AC0000007B7B7B525252525252D5D5D59C9C9C5252
      529393009393009393009393009393005252529C9C9CD5D5D5525252525252D5
      D5D552525220202052525252525262A4D5202020317BB4525252D5D5D5525252
      D5D5D59C9C9C5252529393009393009393009393009393005252529C9C9C5252
      525252529C9C9C000000000000D5D5D59C9C9C5252525252529C9C9C00000000
      00007B7B7B9C9C9C5252529C9C9C525252939300939300939300939300939300
      9393007B7B7B5252527B7B7B9C9C9C9C9C9CD5D5D59C9C9C9C9C9C525252D5D5
      D59C9C9C9C9C9C5252529C9C9CD5D5D55252527B7B7B93930093930093930093
      93009393009393009393009C9C9C9C9C9C525252D5D5D59C9C9CFFFFF69C9C9C
      FFFFF6D5D5D5FFFFF6D5D5D59C9C9CFFFFF6D5D5D5D5D5D59C9C9C5252529393
      009393009393009393009393009393009393005252529C9C9C525252D5D5D5FF
      FFF6D5D5D5D5D5D5FFFFF6FFFFF6FFFFF6D5D5D5D5D5D5D5D5D5D5D5D59C9C9C
      9C9C9C5252529393009393009393009393009393009393009393009393005252
      525252527B7B7B7B7B7BD5D5D5FFFFF6D5D5D5D5D5D5FFFFF6D5D5D5D5D5D59C
      9C9C9C9C9C7B7B7B525252939300939300939300939300939300939300939300
      9393009393009393002020207B7B7B317BB49C9C9CD5D5D5D5D5D59C9C9C7B7B
      7B9C9C9C9C9C9C9C9C9C7B7B7B317BB420202093930093930093930093930093
      930093930093930093930093930093930020202052525262A4D5317BB49C9C9C
      9C9C9C7B7B7B5252527B7B7B9C9C9C7B7B7B317BB462A4D52020209393009393
      00939300939300939300939300939300939300939300939300202020525252D5
      D5D57B7B7B5252527B7B7BD5D5D5D5D5D5D5D5D57B7B7B5252527B7B7BD5D5D5
      2020209393009393009393009393009393009393009393009393009393009393
      009393002020202020209393007B7B7B9C9C9C9C9C9C9C9C9C9C9C9C7B7B7B93
      9300202020202020939300939300939300939300939300939300}
    OnClick = SpeedButton1Click
  end
  object Label8: TLabel
    Left = 200
    Top = 40
    Width = 187
    Height = 15
    Caption = 'deve essere di massimo 50 caratteri.'
    Font.Charset = ANSI_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Edit1: TEdit
    Left = 8
    Top = 24
    Width = 169
    Height = 21
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clTeal
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    MaxLength = 50
    ParentFont = False
    TabOrder = 0
  end
  object Edit2: TEdit
    Left = 8
    Top = 72
    Width = 169
    Height = 21
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clTeal
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    MaxLength = 200
    ParentFont = False
    TabOrder = 1
  end
  object SpinEdit1: TSpinEdit
    Left = 8
    Top = 120
    Width = 169
    Height = 24
    Font.Charset = ANSI_CHARSET
    Font.Color = clTeal
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    MaxValue = 3
    MinValue = 1
    ParentFont = False
    TabOrder = 2
    Value = 1
  end
  object SpinEdit2: TSpinEdit
    Left = 8
    Top = 168
    Width = 169
    Height = 24
    Font.Charset = ANSI_CHARSET
    Font.Color = clTeal
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    MaxValue = 2
    MinValue = 0
    ParentFont = False
    TabOrder = 3
    Value = 0
  end
  object SpinEdit3: TSpinEdit
    Left = 8
    Top = 216
    Width = 169
    Height = 24
    Font.Charset = ANSI_CHARSET
    Font.Color = clTeal
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    MaxValue = 2147483647
    MinValue = 0
    ParentFont = False
    TabOrder = 4
    Value = 0
  end
end
