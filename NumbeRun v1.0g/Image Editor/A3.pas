unit A3;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ExtCtrls;

type
  TForm3 = class(TForm)
    Bevel2: TBevel;
    Image_Trasparenza: TImage;
    Label1: TLabel;
    Bevel1: TBevel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label_R: TLabel;
    Label_G: TLabel;
    Label_B: TLabel;
    Label5: TLabel;
    Bevel3: TBevel;
    RadioButton1: TRadioButton;
    RadioButton2: TRadioButton;
    Label6: TLabel;
    RadioButton3: TRadioButton;
    procedure FormCreate(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form3: TForm3;

implementation

uses A1, A2;

{$R *.dfm}

procedure TForm3.FormCreate(Sender: TObject);
begin
    Form3.Top := Form1.Top - Form3.Height - 1;
    Form3.Left := Form1.Left;
    Form3.Width := Form1.Width + 1 + Form2.Width;
end;

end.
