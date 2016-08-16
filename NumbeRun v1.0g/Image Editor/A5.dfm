object Form5: TForm5
  Left = 763
  Top = 61
  BorderStyle = bsToolWindow
  Caption = 'Crea persona'
  ClientHeight = 78
  ClientWidth = 152
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label8: TLabel
    Left = 12
    Top = 16
    Width = 11
    Height = 15
    Caption = 'X:'
    Font.Charset = ANSI_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object Label1: TLabel
    Left = 84
    Top = 16
    Width = 10
    Height = 15
    Caption = 'Y:'
    Font.Charset = ANSI_CHARSET
    Font.Color = clNavy
    Font.Height = -11
    Font.Name = 'Comic Sans MS'
    Font.Style = []
    ParentFont = False
    Transparent = True
  end
  object ComboBox1: TComboBox
    Left = 8
    Top = 32
    Width = 65
    Height = 21
    Style = csDropDownList
    ItemHeight = 13
    ItemIndex = 0
    TabOrder = 0
    Text = '4'
    Items.Strings = (
      '4')
  end
  object ComboBox2: TComboBox
    Left = 80
    Top = 32
    Width = 65
    Height = 21
    Style = csDropDownList
    ItemHeight = 13
    ItemIndex = 0
    TabOrder = 1
    Text = '16'
    Items.Strings = (
      '16'
      '24')
  end
end
