unit A3;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Spin;

type
  TForm3 = class(TForm)
    SpinEdit1: TSpinEdit;
    SpinEdit2: TSpinEdit;
    SpinEdit3: TSpinEdit;
    SpinEdit4: TSpinEdit;
    SpinEdit5: TSpinEdit;
    SpinEdit6: TSpinEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    SpinEdit7: TSpinEdit;
    Label8: TLabel;
    SpinEdit8: TSpinEdit;
    procedure FormCreate(Sender: TObject);
    procedure FormKeyPress(Sender: TObject; var Key: Char);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form3: TForm3;

implementation

uses A1;

{$R *.dfm}

procedure TForm3.FormCreate(Sender: TObject);
begin
  Form3.Top := 0;
  Form3.Left := 0;
end;

procedure TForm3.FormKeyPress(Sender: TObject; var Key: Char);
begin
    If (key = '\') then
    begin
        Form1.Show;
    end;
end;

end.
