unit A7;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;
           
type
  TForm7 = class(TForm)
    Memo1: TMemo;
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form7: TForm7;

implementation

uses A6;

{$R *.dfm}

procedure TForm7.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
  If (Form6.Active = false) then
    Form6.Close;
end;

end.
