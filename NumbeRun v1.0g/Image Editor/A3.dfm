object Form3: TForm3
  Left = 64
  Top = 173
  BorderIcons = [biMinimize, biMaximize]
  BorderStyle = bsToolWindow
  Caption = 'Tools'
  ClientHeight = 89
  ClientWidth = 858
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Visible = True
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Bevel2: TBevel
    Left = 0
    Top = 0
    Width = 233
    Height = 89
    Shape = bsFrame
    Style = bsRaised
  end
  object Image_Trasparenza: TImage
    Left = 16
    Top = 48
    Width = 33
    Height = 33
  end
  object Label1: TLabel
    Left = 0
    Top = 8
    Width = 233
    Height = 15
    Alignment = taCenter
    AutoSize = False
    Caption = 'Colore di Trasparenza:'
    Font.Charset = ANSI_CHARSET
    Font.Color = clTeal
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Bevel1: TBevel
    Left = 16
    Top = 48
    Width = 33
    Height = 33
    Shape = bsFrame
    Style = bsRaised
  end
  object Label2: TLabel
    Left = 80
    Top = 40
    Width = 38
    Height = 13
    Caption = 'ROSSO'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clMaroon
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label3: TLabel
    Left = 136
    Top = 40
    Width = 38
    Height = 13
    AutoSize = False
    Caption = 'VERDE'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clGreen
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label4: TLabel
    Left = 192
    Top = 40
    Width = 38
    Height = 13
    Alignment = taCenter
    AutoSize = False
    Caption = 'BLU'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label_R: TLabel
    Left = 80
    Top = 56
    Width = 38
    Height = 13
    Alignment = taCenter
    AutoSize = False
    Caption = '-'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clMaroon
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label_G: TLabel
    Left = 136
    Top = 56
    Width = 38
    Height = 13
    Alignment = taCenter
    AutoSize = False
    Caption = '-'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clGreen
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label_B: TLabel
    Left = 192
    Top = 56
    Width = 38
    Height = 13
    Alignment = taCenter
    AutoSize = False
    Caption = '-'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label5: TLabel
    Left = 16
    Top = 32
    Width = 32
    Height = 13
    Caption = 'colore:'
    Transparent = True
  end
  object Bevel3: TBevel
    Left = 232
    Top = 0
    Width = 625
    Height = 89
    Shape = bsFrame
    Style = bsRaised
  end
  object Label6: TLabel
    Left = 240
    Top = 8
    Width = 118
    Height = 13
    Caption = 'Modalit'#224' di compilazione;'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object RadioButton1: TRadioButton
    Left = 240
    Top = 24
    Width = 113
    Height = 17
    Caption = 'Compila immagine'
    Enabled = False
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clTeal
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 0
  end
  object RadioButton2: TRadioButton
    Left = 240
    Top = 40
    Width = 113
    Height = 17
    Caption = 'Crea oggetto'
    Enabled = False
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clTeal
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 1
    Visible = False
  end
  object RadioButton3: TRadioButton
    Left = 240
    Top = 56
    Width = 113
    Height = 17
    Caption = 'Crea persona'
    Enabled = False
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clTeal
    Font.Height = -11
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
    TabOrder = 2
    Visible = False
  end
end