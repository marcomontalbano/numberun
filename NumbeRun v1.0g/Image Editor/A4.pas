unit A4;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Spin, ExtCtrls, Buttons;

type
  TForm4 = class(TForm)
    Bevel1: TBevel;
    Label1: TLabel;
    Edit1: TEdit;
    Label2: TLabel;
    Edit2: TEdit;
    SpinEdit1: TSpinEdit;
    Label3: TLabel;
    SpinEdit2: TSpinEdit;
    Label4: TLabel;
    SpinEdit3: TSpinEdit;
    Label5: TLabel;
    Bevel2: TBevel;
    Label6: TLabel;
    Label7: TLabel;
    Label10: TLabel;
    Label11: TLabel;
    Label9: TLabel;
    Label12: TLabel;
    Label13: TLabel;
    Label14: TLabel;
    Label15: TLabel;
    Label16: TLabel;
    Label17: TLabel;
    Label19: TLabel;
    Label20: TLabel;
    Label18: TLabel;
    Bevel3: TBevel;
    Bevel4: TBevel;
    SpeedButton1: TSpeedButton;
    Label8: TLabel;
    procedure SpeedButton1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form4: TForm4;

implementation

uses A1, A3;

{$R *.dfm}

procedure TForm4.SpeedButton1Click(Sender: TObject);
begin
  If (((Form4.Edit1.Text = '') or (Form4.Edit1.Text = ' ')) and ((Form4.Edit2.Text = '') or (Form4.Edit2.Text = ' '))) Then
  Begin
      ShowMessage('Errore: compilare gli spazi vuoti');
  End else
  Begin
      //Abilita compilazione
        Form1.Compila1.Enabled := True;
      //Seleziona modalità
        Form3.RadioButton2.Checked := True;
      //Chiudi Form4
        Form4.Close;
  End;
end;

end.
