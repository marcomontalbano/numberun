unit A5;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, StdCtrls;

type
  TForm5 = class(TForm)
    Label18: TLabel;
    Label19: TLabel;
    Image9: TImage;
    Label16: TLabel;
    Label17: TLabel;
    Label1: TLabel;
    Label2: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    Label10: TLabel;
    Label11: TLabel;
    Label12: TLabel;
    procedure FormKeyPress(Sender: TObject; var Key: Char);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form5: TForm5;

implementation

uses A1;

{$R *.dfm}

procedure TForm5.FormKeyPress(Sender: TObject; var Key: Char);
begin
    If (key = '\') then
    begin
        Form5.Close;
        Form1.Show;
    end;
end;

end.
