unit A1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtDlgs, StdCtrls, ExtCtrls, Spin, Menus;

type
  TForm1 = class(TForm)
    Image1: TImage;
    OpenPictureDialog1: TOpenPictureDialog;
    Memo_STR_RGB: TMemo;
    Edit_R1: TEdit;
    Edit_G1: TEdit;
    Edit_B1: TEdit;
    SpinEdit_INT_for_HEX: TSpinEdit;
    Edit_Scarto: TEdit;
    PopupMenu1: TPopupMenu;
    Apriecompila1: TMenuItem;
    Compila1: TMenuItem;
    CreaOggetto1: TMenuItem;
    N1: TMenuItem;
    Creapersona1: TMenuItem;
    Edit_Path: TEdit;
    procedure FormCreate(Sender: TObject);
    procedure Apriecompila1Click(Sender: TObject);
    procedure Compila1Click(Sender: TObject);
    procedure Image1Click(Sender: TObject);
    procedure Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
      Y: Integer);
    procedure CreaOggetto1Click(Sender: TObject);
    procedure Creapersona1Click(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  X_mouse, Y_mouse: integer;
  numero_oggetto_singolo: integer;

implementation

uses A2, A3, A4, A5;

{$R *.dfm}

//Procedura per la path del programma
procedure ProgramPath;
var
        i, j: integer;
        path: string;
begin
        Form1.Edit_Path.Clear;
        path := Application.ExeName;
        path := path + '?';
        i := 0;
        repeat
                i := i + 1;
        until (path[i] = '?');
        repeat
                i := i - 1;
        until (path[i] = '\');
        j := 0;
        repeat
                Form1.Edit_Path.Text := Form1.Edit_Path.Text + path[j];
                j := j + 1;
        until (j = i);
end;

function hex2int(str:string):longint;
CONST
  HEX : ARRAY['A'..'F'] OF INTEGER = (10,11,12,13,14,15);
var
  mInt,
  i : longint;
begin
    mInt := 0;
    for i := 1 to Length(str) do
      if str[i] < 'A' THEN
        mInt := mInt * 16 + ORD(str[i]) - 48
      else
        mInt := mInt * 16 + HEX[str[i]];

    result:=mint;

end;



//Trasforma il pixel (stringa della memo) in colore RGB
procedure Pixel_2_RGB;
Begin
    Form1.Memo_STR_RGB.SelStart := 0;
    Form1.Memo_STR_RGB.SelLength := 3;
    Form1.Edit_Scarto.Text := Form1.Memo_STR_RGB.SelText;

    If not(Form1.Edit_Scarto.Text = '$00') Then
    Begin
        Form1.Edit_Scarto.Text := SysUtils.IntToHex(Form1.SpinEdit_INT_for_HEX.Value,0);
        Form1.SpinEdit_INT_for_HEX.Value := 9 - Form1.Edit_Scarto.GetTextLen;
        Form1.Memo_STR_RGB.Clear;
        repeat
          Form1.Memo_STR_RGB.Lines.Text := Form1.Memo_STR_RGB.Lines.Text + '0';
          Form1.SpinEdit_INT_for_HEX.Value := Form1.SpinEdit_INT_for_HEX.Value - 1;
        until (Form1.SpinEdit_INT_for_HEX.Value = 0);
        Form1.Memo_STR_RGB.Lines.Text := Form1.Memo_STR_RGB.Lines.Text + Form1.Edit_Scarto.Text;
        Form1.Edit_Scarto.Text := Form1.Memo_STR_RGB.Lines.Text;
    End;

    //Trasformazione del pixel in modalità RGB
    Form1.Memo_STR_RGB.SelStart := 3;
    Form1.Memo_STR_RGB.SelLength := 2;
    Form1.Edit_B1.Text := Form1.Memo_STR_RGB.SelText;
    Form1.Edit_B1.Text := IntToStr(hex2int(Form1.Edit_B1.Text));
    Form1.Memo_STR_RGB.SelStart := 5;
    Form1.Memo_STR_RGB.SelLength := 2;
    Form1.Edit_G1.Text := Form1.Memo_STR_RGB.SelText;
    Form1.Edit_G1.Text := IntToStr(hex2int(Form1.Edit_G1.Text));
    Form1.Memo_STR_RGB.SelStart := 7;
    Form1.Memo_STR_RGB.SelLength := 2;
    Form1.Edit_R1.Text := Form1.Memo_STR_RGB.SelText;
    Form1.Edit_R1.Text := IntToStr(hex2int(Form1.Edit_R1.Text));
    Form1.Memo_STR_RGB.Lines.Text := Form1.Edit_R1.Text + ', ' + Form1.Edit_G1.Text + ', ' + Form1.Edit_B1.Text;


End;

Procedure compila_immagine();
var
  x, y: integer;
Begin
    Form2.Memo_RGB_COMPILATO.Clear;
    //Compila il codice dell'immagine
    x := 0;
    y := 0;
      repeat
        repeat
          if not(Form1.Image1.Canvas.Pixels[x,y] = Form3.Image_Trasparenza.Canvas.Pixels[1,1]) then
          begin
            Form1.Memo_STR_RGB.Lines.Text := Graphics.ColorToString(Form1.Image1.Canvas.Pixels[x,y]);
            Form1.SpinEdit_INT_for_HEX.Value := Graphics.ColorToRGB(Form1.Image1.Canvas.Pixels[x,y]);
            Pixel_2_RGB;
            Form2.Memo_RGB_COMPILATO.Lines.Append('DrawPoints(' + IntToStr(x) + ' + (dimensione_pixel*a), ' + IntToStr(y) + ' + (dimensione_pixel*b), ' + Form1.Memo_STR_RGB.Lines.Text + ');');
          end;
          x := x + 1;
        until (x = Form1.Image1.Width);
        x := 0;
        y := y + 1;
      until (y = Form1.Image1.Height);
end;

Procedure compila_crea_persona();
var
  x, y: integer;
Begin
    Form2.Memo_RGB_COMPILATO.Clear;
    //Compila il codice dell'immagine
    x := 0;
    y := 0;
      repeat
        repeat
          if not(Form1.Image1.Canvas.Pixels[x,y] = Form3.Image_Trasparenza.Canvas.Pixels[1,1]) then
          begin
            Form1.Memo_STR_RGB.Lines.Text := Graphics.ColorToString(Form1.Image1.Canvas.Pixels[x,y]);
            Form1.SpinEdit_INT_for_HEX.Value := Graphics.ColorToRGB(Form1.Image1.Canvas.Pixels[x,y]);
            Pixel_2_RGB;
            Form2.Memo_RGB_COMPILATO.Lines.Append('DrawStandardPixel(' + IntToStr(x+1) + ' + (dimensione_pixel*a+Gioco_Centrato_X) - ' + Form5.ComboBox1.Text + ', ' + IntToStr(y+1) + ' + (dimensione_pixel*b+Gioco_Centrato_Y) - ' + Form5.ComboBox2.Text + ', ' + Form1.Memo_STR_RGB.Lines.Text + ');');
          end;
          x := x + 1;
        until (x = Form1.Image1.Width);
        x := 0;
        y := y + 1;
      until (y = Form1.Image1.Height);
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
    //Caricamento della path del programma
    ProgramPath;
    //settaggio della cartella di inizio
    Form1.OpenPictureDialog1.InitialDir := Application.ExeName;

    //impostazioni di grandezza
    Form1.Top := trunc(Screen.Height / 2) - trunc(form1.Height / 2);
    Form1.Left := trunc(Screen.Width / 2) - trunc(form1.Width / 2) - trunc(Screen.Width / 4);

end;

procedure TForm1.Apriecompila1Click(Sender: TObject);
begin
  If (Form1.OpenPictureDialog1.Execute) Then
  Begin
    //Carica l'immagine
    Form1.Image1.Picture.LoadFromFile(Form1.OpenPictureDialog1.FileName);

    //Abilita compilazione
    Form1.Compila1.Enabled := True;

    //Seleziona modalità
    Form3.RadioButton1.Checked := True;
  End;

end;

procedure TForm1.Compila1Click(Sender: TObject);
begin
  If (Form3.RadioButton1.Checked = True) Then
    compila_immagine();
  If (Form3.RadioButton3.Checked = True) Then
    compila_crea_persona();
end;

procedure TForm1.Image1Click(Sender: TObject);
var
    x, y: integer;
begin
    x := 0;
    y := 0;
    //caricamento immagine
      repeat
        repeat
          Form3.Image_Trasparenza.Canvas.Pixels[x,y] := Form1.Image1.Canvas.Pixels[X_mouse,Y_mouse];
          x := x + 1;
        until(x = Form3.Image_Trasparenza.Width);
        x := 0;
        y := y + 1;
      until(y = Form3.Image_Trasparenza.Height);
    //caricamento dati RGB
      Form1.Memo_STR_RGB.Lines.Text := Graphics.ColorToString(Form3.Image_Trasparenza.Canvas.Pixels[1,1]);
      Form1.SpinEdit_INT_for_HEX.Value := Graphics.ColorToRGB(Form3.Image_Trasparenza.Canvas.Pixels[1,1]);
      Pixel_2_RGB;
      Form3.Label_R.Caption := Form1.Edit_R1.Text;
      Form3.Label_G.Caption := Form1.Edit_G1.Text;
      Form3.Label_B.Caption := Form1.Edit_B1.Text;
end;

procedure TForm1.Image1MouseMove(Sender: TObject; Shift: TShiftState; X,
  Y: Integer);
begin
    X_mouse := x;
    Y_mouse := y;
end;

procedure TForm1.CreaOggetto1Click(Sender: TObject);
begin
  If (Form1.OpenPictureDialog1.Execute) Then
  Begin
    //Carica l'immagine
    Form1.Image1.Picture.LoadFromFile(Form1.OpenPictureDialog1.FileName);

    //Reset Form4
      Form4.Edit1.Clear;
      Form4.Edit2.Clear;
      form4.SpinEdit1.Value := 1;
      Form4.SpinEdit2.Value := 0;
      Form4.SpinEdit3.Value := 0;
    //Mostra crea oggetto
    Form4.Show;
  End;

end;

procedure TForm1.Creapersona1Click(Sender: TObject);
begin
  If (Form1.OpenPictureDialog1.Execute) Then
  Begin
    //Carica l'immagine
    Form1.Image1.Picture.LoadFromFile(Form1.OpenPictureDialog1.FileName);
    Form5.Show;
    //Abilita compilazione
    Form1.Compila1.Enabled := True;

    //Seleziona modalità
    Form3.RadioButton3.Checked := True;
  End;
end;

procedure TForm1.FormClose(Sender: TObject; var Action: TCloseAction);
begin
      if (Form2.Visible = true) Then
      begin
          Form2.Close;
      end;
      if (Form3.Visible = true) Then
      begin
          Form3.Close;
      end;
end;

end.
