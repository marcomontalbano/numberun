unit A2;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Spin;

type
  TForm2 = class(TForm)
    Memo_RGB_COMPILATO: TMemo;
    procedure FormCreate(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form2: TForm2;

implementation

uses A1;

{$R *.dfm}

procedure TForm2.FormCreate(Sender: TObject);
begin
    Form2.Top := Form1.Top;
    Form2.Left := Form1.Left + Form1.Width + 1;
end;

end.
