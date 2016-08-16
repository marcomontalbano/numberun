object Form4: TForm4
  Left = 204
  Top = 233
  BorderIcons = [biSystemMenu]
  BorderStyle = bsToolWindow
  Caption = 'MONSTER.H'
  ClientHeight = 446
  ClientWidth = 469
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poDesktopCenter
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Label21: TLabel
    Left = 8
    Top = 8
    Width = 124
    Height = 15
    Caption = 'numero mostri del gioco:'
    Font.Charset = ANSI_CHARSET
    Font.Color = clGreen
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object SpeedButton1: TSpeedButton
    Left = 168
    Top = 8
    Width = 297
    Height = 33
    Caption = 'Compila'
    OnClick = SpeedButton1Click
  end
  object ComboBox1: TComboBox
    Left = 8
    Top = 24
    Width = 145
    Height = 21
    Style = csDropDownList
    ItemHeight = 13
    TabOrder = 0
  end
  object Memo1: TMemo
    Left = 8
    Top = 48
    Width = 457
    Height = 393
    ReadOnly = True
    ScrollBars = ssBoth
    TabOrder = 1
    WordWrap = False
  end
  object Memo_Intestazione: TMemo
    Left = 488
    Top = 8
    Width = 185
    Height = 89
    Lines.Strings = (
      ''
      #9#9'/*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'
      #9#9'*'#9#9#9#9#9#9#9#9#9#9#9#9#9#9#9#9#9'*'
      #9#9'*'#9#9#9#9#9#9#9'*** MONSTER ***'#9#9#9#9#9#9#9'*'
      #9#9'*'#9#9#9#9#9#9#9#9#9#9#9#9#9#9#9#9#9'*'
      #9#9'*'#9'Nome:'#9#9#9'MONSTER.H'#9#9#9#9#9#9#9#9#9#9'*'
      #9#9'*'#9'Programmato da: Montalbano Marco & Brambilla Giacomo'#9#9#9'*'
      #9#9'*'#9'Genere:'#9#9#9'Libreria del gioco (gestione eventi dei mostri)'#9'*'
      #9#9'*'#9'Piattaforma:'#9'Windows'#9#9#9#9#9#9#9#9#9#9#9'*'
      #9#9'*'#9'Copyright:'#9#9'2005 / 2006'#9#9#9#9#9#9#9#9#9#9'*'
      #9#9'*'#9#9#9#9#9#9#9#9#9#9#9#9#9#9#9#9#9'*'
      #9#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*'#9'*/'
      ''
      ''
      ''
      '//Elenco funzioni contenute'
      'void controllo_mostri_nel_gioco();'
      'void controllo_collisione_con_mostro();'
      'void controlla_punteggio_mostri();')
    ReadOnly = True
    TabOrder = 2
    WordWrap = False
  end
end
