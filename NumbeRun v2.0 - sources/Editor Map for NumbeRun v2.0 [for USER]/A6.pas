unit A6;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, StdCtrls, Menus, ExtDlgs, Spin;

type
  TForm6 = class(TForm)
    Image1: TImage;
    PopupMenu1: TPopupMenu;
    ApriImmagine1: TMenuItem;
    Compila1: TMenuItem;
    OpenPictureDialog1: TOpenPictureDialog;
    Image_Paletta: TImage;
    Memo1: TMemo;
    Memo2: TMemo;
    Button1: TButton;
    Image_Trasparenza: TImage;
    procedure FormCloseQuery(Sender: TObject; var CanClose: Boolean);
    procedure ApriImmagine1Click(Sender: TObject);
    procedure Compila1Click(Sender: TObject);
    procedure FormShow(Sender: TObject);
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form6: TForm6;
  R1, G1, B1: integer;
  R2, G2, B2: integer;

implementation

uses A7;

{$R *.dfm}

procedure INIZIALIZZA_FORM6;
begin
    Form7.Memo1.Height := Form6.Image1.Height;
    Form7.Left := 1;
    Form7.Top := 1;
end;

procedure TForm6.FormCloseQuery(Sender: TObject; var CanClose: Boolean);
begin
  If (Form7.Active = false) then
    Form7.Close;
end;

procedure TForm6.ApriImmagine1Click(Sender: TObject);
begin
    If (Form6.OpenPictureDialog1.Execute) Then
    Begin
        Form6.Image1.Picture.LoadFromFile(Form6.OpenPictureDialog1.FileName);

    End;
end;

{
procedure RGB2BGR(RGB: Integer);
begin
  R1      := RGB div $10000;
  G1      := ((RGB mod $10000) div $100) shl 8;
  B1      := (RGB mod $100) shl 16;
end;
}


procedure BMP2RGB_TEXT(i: integer; j: integer);
var
  q, w: integer;
begin
    q := 1;
    w := 1;
    R1 := 0;
    G1 := 0;
    B1 := 0;
    R2 := 0;
    G2 := 0;
    B2 := -1;

    repeat
      repeat
          B2 := B2 + 1;
          if ((G1 = 1) and (B1 = 1) and (B2 = 1))  Then
          begin
              G2 := 0;
              G1 := 0;
              B2 := 0;
              B1 := 0;
              R2 := R2 + 1;
          end;
          if (B1 = 1) Then
          begin
              B2 := 0;
              B1 := 0;
              G2 := G2 + 1;
          end;
          if (B2 = 10) Then
          begin
              B2 := 0;
              B1 := B1 + 1;
          end;
          if (G2 = 10) Then
          begin
              G2 := 0;
              G1 := G1 + 1;
          end;
          if (R2 = 10) Then
          begin
              R2 := 0;
              R1 := R1 + 1;
          end;
          Form7.Memo1.Lines.Append(IntToStr(R1) + '.' + IntToStr(R2) + ', ' + IntToStr(G1) + '.' + IntToStr(G2) + ', ' + IntToStr(B1) + '.' + IntToStr(B2));

          q := q + 1;
      until (q > i);
      q := 1;
      w := w + 1;
    until (w > j);
end;


procedure BMP2RGB(inc: integer);
begin
    Form6.Memo2.Lines.Strings[0] := Form6.Memo1.Lines.Strings[inc];
end;

procedure TForm6.Compila1Click(Sender: TObject);
var
  x, y: integer;
  i, j: integer;
  fatto: bool;
  inc: integer;
begin
      Form7.Memo1.Clear;
      fatto := false;
      inc := 0;
      x := 0;
      y := 0;
      i := 0;
      j := 0;
      repeat
        repeat
          repeat
            repeat
                  if (Form6.Image1.Canvas.Pixels[x,y] = Form6.Image_Paletta.Canvas.Pixels[i,j]) Then
                  begin
                      BMP2RGB(inc);
                      //fatto := true;
                  end;
                  inc := inc + 1;
                  i := i + 1;
            until ((i = Form6.Image_Paletta.Width) or (fatto = true));
            i := 0;
            j := j + 1;
          until ((j = Form6.Image_Paletta.Height) or (fatto = true));
          inc := 0;
          j := 0;
          fatto := false;
          if not(Form6.Image1.Canvas.Pixels[x,y] = Form6.Image_Trasparenza.Canvas.Pixels[2,2]) Then
            Form7.Memo1.Lines.Append('DrawPoints(' + IntToStr(x) + ' + (dimensione_pixel*a), ' + IntToStr(y) + ' + (dimensione_pixel*b), ' + Form6.Memo2.Lines.Text + ');');
          x := x + 1;
        until (x = Form6.Image1.Width);
        x := 0;
        y := y + 1;
      until (y = Form6.Image1.Height);
end;

procedure TForm6.FormShow(Sender: TObject);
begin
    INIZIALIZZA_FORM6;
end;

procedure TForm6.Button1Click(Sender: TObject);
begin
    BMP2RGB_TEXT(Form6.Image_Paletta.Width,Form6.Image_Paletta.Height);
end;

end.
