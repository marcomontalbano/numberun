unit A1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, StdCtrls, Spin, Menus;

type
  TForm1 = class(TForm)
    Bevel1: TBevel;
    Image_Map: TImage;
    Edit_Path: TEdit;
    MainMenu1: TMainMenu;
    FileInvisibile1: TMenuItem;
    ools1: TMenuItem;
    Image_MIRINO: TImage;
    PopupMenu1: TPopupMenu;
    Strada1: TMenuItem;
    Mura1: TMenuItem;
    Protagonista1: TMenuItem;
    Mostri1: TMenuItem;
    esori1: TMenuItem;
    Ostacoli1: TMenuItem;
    FineGioco1: TMenuItem;
    Edit_Bitmap: TEdit;
    Palettadeicolori1: TMenuItem;
    N1: TMenuItem;
    ModalitTesto1: TMenuItem;
    sfondomappa1: TMenuItem;
    Strada2: TMenuItem;
    Muro1: TMenuItem;
    Protagonista2: TMenuItem;
    Mostro1: TMenuItem;
    esoro1: TMenuItem;
    Ostacolo1: TMenuItem;
    FineGioco2: TMenuItem;
    CrystalPotion1: TMenuItem;
    Bianco1: TMenuItem;
    HELP1: TMenuItem;
    TOOLPALETTE1: TMenuItem;
    BMP2PIX1: TMenuItem;
    MONSTERH1: TMenuItem;
    procedure Image1Click(Sender: TObject);
    procedure Image2Click(Sender: TObject);
    procedure Image3Click(Sender: TObject);
    procedure Image4Click(Sender: TObject);
    procedure Image5Click(Sender: TObject);
    procedure Image6Click(Sender: TObject);
    procedure FormKeyPress(Sender: TObject; var Key: Char);
    procedure FormCreate(Sender: TObject);
    procedure ools1Click(Sender: TObject);
    procedure Image_MapMouseMove(Sender: TObject; Shift: TShiftState; X,
      Y: Integer);
    procedure Image_MIRINOClick(Sender: TObject);
    procedure Image_MIRINOContextPopup(Sender: TObject; MousePos: TPoint;
      var Handled: Boolean);
    procedure Strada1Click(Sender: TObject);
    procedure Mura1Click(Sender: TObject);
    procedure Protagonista1Click(Sender: TObject);
    procedure Mostri1Click(Sender: TObject);
    procedure esori1Click(Sender: TObject);
    procedure Ostacoli1Click(Sender: TObject);
    procedure FineGioco1Click(Sender: TObject);
    procedure FormActivate(Sender: TObject);
    procedure Strada2Click(Sender: TObject);
    procedure Muro1Click(Sender: TObject);
    procedure Protagonista2Click(Sender: TObject);
    procedure Mostro1Click(Sender: TObject);
    procedure esoro1Click(Sender: TObject);
    procedure Ostacolo1Click(Sender: TObject);
    procedure FineGioco2Click(Sender: TObject);
    procedure CrystalPotion1Click(Sender: TObject);
    procedure Bianco1Click(Sender: TObject);
    procedure HELP1Click(Sender: TObject);
    procedure TOOLPALETTE1Click(Sender: TObject);
    procedure BMP2PIX1Click(Sender: TObject);
    procedure MONSTERH1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  A, B : integer;
  SpinEdit_X_MAX : integer;
  SpinEdit_Y_MAX : integer;
  INVISIBLE_MENU : bool;

implementation

uses A2, A4, A5, A6, A7, A8;

{$R *.dfm}

//Procedura per la path del programma
procedure ProgramPath;
var
        i, j: integer;
        path: string;
begin
        Form1.Edit_Path.Text := '';
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

procedure SCRITTE_Colora_Sfondo;
var
  i, I2, j, J2: integer;  //Contatori

begin
    Form2.SpinEdit_X.Value := 1;
    Form2.SpinEdit_Y.Value := 1;
    I2 := 0;
    j2 := 0;
    repeat
          repeat
            //Colora un quadretto
            i := 1;
            j := 1;
            repeat
              repeat
                Form1.Image_Map.Canvas.Pixels[I2+i,J2+j]:= Form2.Image_Selection.Canvas.Pixels[1,1];
                i := i + 1;
              until (i = 7);
              i := 1;
              j := j + 1;
            until (j = 7);

            I2 := I2 + 8;
            Form2.SpinEdit_X.Value := Form2.SpinEdit_X.Value + 1;
          until (Form2.SpinEdit_X.Value = SpinEdit_X_MAX + 1);
          I2 := 0;
          Form2.SpinEdit_X.Value := 1;
          Form2.SpinEdit_Y.Value := Form2.SpinEdit_Y.Value + 1;
          J2 := J2 + 8;
    until (Form2.SpinEdit_Y.Value = SpinEdit_Y_MAX + 1);
end;

procedure TForm1.Image1Click(Sender: TObject);
begin
  Form2.Image_Selection.Picture := Form2.Image1.Picture;
end;

procedure TForm1.Image2Click(Sender: TObject);
begin
  Form2.Image_Selection.Picture := Form2.Image2.Picture;
end;

procedure TForm1.Image3Click(Sender: TObject);
begin
  Form2.Image_Selection.Picture := Form2.Image3.Picture;
end;

procedure TForm1.Image4Click(Sender: TObject);
begin
  Form2.Image_Selection.Picture := Form2.Image4.Picture;
end;

procedure TForm1.Image5Click(Sender: TObject);
begin
  Form2.Image_Selection.Picture := Form2.Image5.Picture;
end;

procedure TForm1.Image6Click(Sender: TObject);
begin
  Form2.Image_Selection.Picture := Form2.Image6.Picture;
end;

procedure TForm1.FormKeyPress(Sender: TObject; var Key: Char);
var
  X,Y: integer;   //Coordinate cursore
  i, j: integer;  //Contatori
begin
    //Cursore DOWN
    If not(Form1.Image_MIRINO.Top + Form1.Image_MIRINO.Height = Form1.Bevel1.Top + Form1.Bevel1.Height) then
      If ((key = 'h') or (key = 'H')) then
      begin
        Form1.Image_MIRINO.Top := form1.Image_MIRINO.Top + 8;
        Form2.SpinEdit_Y.Value := Form2.SpinEdit_Y.Value + 1;
      end;
    //Cursore UP
    If not(Form1.Image_MIRINO.Top = Form1.Bevel1.Top) then
      If ((key = 'y') or (key = 'Y')) then
      begin
        Form1.Image_MIRINO.Top := form1.Image_MIRINO.Top - 8;
        Form2.SpinEdit_Y.Value := Form2.SpinEdit_Y.Value - 1;
      end;
    //Cursore RIGHT
    If not(Form1.Image_MIRINO.Left + Form1.Image_MIRINO.Width = Form1.Bevel1.Left + Form1.Bevel1.Width) then
      If ((key = 'j') or (key = 'J')) then
      begin
        Form1.Image_MIRINO.Left := form1.Image_MIRINO.Left + 8;
        Form2.SpinEdit_X.Value := Form2.SpinEdit_X.Value + 1;
      end;
    //Cursore LEFT
    If not(Form1.Image_MIRINO.Left = Form1.Bevel1.Left) then
      If ((key = 'g') or (key = 'G')) then
      begin
        Form1.Image_MIRINO.Left := form1.Image_MIRINO.Left - 8;
        Form2.SpinEdit_X.Value := Form2.SpinEdit_X.Value - 1;
      end;
    //Carica posizione cursore
    X := (Form2.SpinEdit_X.Value * 8) - 8;
    Y := (Form2.SpinEdit_Y.Value * 8) - 8;
    //Press SPACEBAR
    If (key = ' ') then
    begin
      i := 1;
      j := 1;
      repeat
        repeat
          Form1.Image_Map.Canvas.Pixels[X+i,Y+j]:= Form2.Image_Selection.Canvas.Pixels[1,1];
          i := i + 1;
        until (i = 7);
        i := 1;
        j := j + 1;
      until (j = 7);
    end;
    //Press 1
    If (key = '1') then
    begin
        Form2.SpeedButton1.Click;
    end;
    //Press 2
    If (key = '2') then
    begin
        Form2.SpeedButton2.Click;
    end;
    //Press 3
    If (key = '3') then
    begin
        Form2.SpeedButton3.Click;
    end;
    //Press 4
    If (key = '4') then
    begin
        Form2.SpeedButton4.Click;
    end;
    //Press 5
    If (key = '5') then
    begin
        Form2.SpeedButton5.Click;
    end;
    //Press 6
    If (key = '6') then
    begin
        Form2.SpeedButton6.Click;
    end;
    //Press 7
    If (key = '7') then
    begin
        Form2.SpeedButton12.Click;
    end;
    //Press 8
    If (key = '8') then
    begin
        Form2.SpeedButton13.Click;
    end;
    If (key = '\') then
    begin
        Form2.Show;
    end;
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
  //Grandezza della mappa
  SpinEdit_X_MAX := 78;
  SpinEdit_Y_MAX := 20;
  //Path del programma
  ProgramPath;
  //Posizione della form
  Form1.Top := (trunc(Screen.Height / 2) - trunc(Form1.Height / 2)) - 100;
  Form1.Left := (trunc(Screen.Width / 2) - trunc(Form1.Width / 2));
  INVISIBLE_MENU := false;
end;

procedure TForm1.ools1Click(Sender: TObject);
begin
  //Posizione della Form
  Form2.Top := Form1.Top + Form1.Height + 1;
  Form2.Left := Form1.Left;
  //Grandezza della form
  Form2.Width := Form1.Width;
  //Visualizza FORM
  Form2.Show;
  Form1.Show;
end;

procedure TForm1.Image_MapMouseMove(Sender: TObject; Shift: TShiftState; X,
  Y: Integer);
begin
    //Spostamento del cursore 'BEVEL11'
    A := (trunc(X / 8) * 8);
    B := (trunc(Y / 8) * 8);
    Form1.Image_MIRINO.Left := A;
    Form1.Image_MIRINO.Top := B;
    Form2.SpinEdit_X.Value := trunc(X / 8) + 1;
    Form2.SpinEdit_Y.Value := trunc(Y / 8) + 1;
end;

procedure TForm1.Image_MIRINOClick(Sender: TObject);
var
  i, j: integer;  //Contatori
begin
    //se il selettore è disattivato
    if (form2.CheckBox_Selettore.Checked = false) then
    begin
      i := 1;
      j := 1;
      repeat
        repeat
          Form1.Image_Map.Canvas.Pixels[A+i,B+j]:= Form2.Image_Selection.Canvas.Pixels[1,1];
          i := i + 1;
        until (i = 7);
        i := 1;
        j := j + 1;
      until (j = 7);
    end;

    //se il selettore è attivo
    if (form2.CheckBox_Selettore.Checked = true) then
    begin
      i := 1;
      j := 1;
      repeat
        repeat
          Form2.Image_Selection.Canvas.Pixels[i,j] := Form1.Image_Map.Canvas.Pixels[A+1,B+1];
          i := i + 1;
        until (i = 22);
        i := 1;
        j := j + 1;
      until (j = 22);
      Form2.CheckBox_Selettore.Checked := false;
    end;
end;

procedure TForm1.Image_MIRINOContextPopup(Sender: TObject;
  MousePos: TPoint; var Handled: Boolean);
begin

  Form1.PopupMenu1.Popup(Mouse.CursorPos.X,Mouse.CursorPos.Y);
end;

procedure TForm1.Strada1Click(Sender: TObject);
begin
  Form2.SpeedButton1.Click;
end;

procedure TForm1.Mura1Click(Sender: TObject);
begin
  Form2.SpeedButton2.Click;
end;

procedure TForm1.Protagonista1Click(Sender: TObject);
begin
  Form2.SpeedButton3.Click;
end;

procedure TForm1.Mostri1Click(Sender: TObject);
begin
  Form2.SpeedButton4.Click;
end;

procedure TForm1.esori1Click(Sender: TObject);
begin
  Form2.SpeedButton5.Click;
end;

procedure TForm1.Ostacoli1Click(Sender: TObject);
begin
  Form2.SpeedButton6.Click;
end;

procedure TForm1.FineGioco1Click(Sender: TObject);
begin
  Form2.SpeedButton12.Click;
end;

procedure TForm1.FormActivate(Sender: TObject);
begin
  Forms.Screen.Cursors[0] := Windows.LoadCursor(Hinstance, 'PEN');
  Form1.Image_Map.Cursor := Forms.Screen.Cursors[0];
  Form1.Image_MIRINO.Cursor := Forms.Screen.Cursors[0];

  // disabilita Memo_CSharpSharp
  Form2.Memo_Cplusplus.Enabled := false;
end;

procedure TForm1.Strada2Click(Sender: TObject);
begin
  //Imposta colore Viola
  Form2.SpeedButton1.Click;
  //Colora lo sfondo
  SCRITTE_Colora_Sfondo;
end;

procedure TForm1.Muro1Click(Sender: TObject);
begin
  //Imposta colore Viola
  Form2.SpeedButton2.Click;
  //Colora lo sfondo
  SCRITTE_Colora_Sfondo;
  //Ripristina colore
  Form2.SpeedButton1.Click;
end;

procedure TForm1.Protagonista2Click(Sender: TObject);
begin
  //Imposta colore Viola
  Form2.SpeedButton3.Click;
  //Colora lo sfondo
  SCRITTE_Colora_Sfondo;
  //Ripristina colore
  Form2.SpeedButton1.Click;
end;

procedure TForm1.Mostro1Click(Sender: TObject);
begin
  //Imposta colore Viola
  Form2.SpeedButton4.Click;
  //Colora lo sfondo
  SCRITTE_Colora_Sfondo;
  //Ripristina colore
  Form2.SpeedButton1.Click;
end;

procedure TForm1.esoro1Click(Sender: TObject);
begin
  //Imposta colore Viola
  Form2.SpeedButton5.Click;
  //Colora lo sfondo
  SCRITTE_Colora_Sfondo;
  //Ripristina colore
  Form2.SpeedButton1.Click;
end;

procedure TForm1.Ostacolo1Click(Sender: TObject);
begin
  //Imposta colore Viola
  Form2.SpeedButton6.Click;
  //Colora lo sfondo
  SCRITTE_Colora_Sfondo;
  //Ripristina colore
  Form2.SpeedButton1.Click;
end;

procedure TForm1.FineGioco2Click(Sender: TObject);
begin
  //Imposta colore Viola
  Form2.SpeedButton12.Click;
  //Colora lo sfondo
  SCRITTE_Colora_Sfondo;
  //Ripristina colore
  Form2.SpeedButton1.Click;
end;

procedure TForm1.CrystalPotion1Click(Sender: TObject);
begin
  Form2.SpeedButton13.Click;
end;

procedure TForm1.Bianco1Click(Sender: TObject);
begin
  //Imposta colore Viola
  Form2.SpeedButton13.Click;
  //Colora lo sfondo
  SCRITTE_Colora_Sfondo;
  //Ripristina colore
  Form2.SpeedButton1.Click;
end;

procedure TForm1.HELP1Click(Sender: TObject);
begin
    Form5.Show;
end;

procedure TForm1.TOOLPALETTE1Click(Sender: TObject);
begin
    Form8.Show;
end;

procedure TForm1.BMP2PIX1Click(Sender: TObject);
begin

  if (INVISIBLE_MENU = true) Then
  begin
    Form6.Show;
    Form7.Show;
    Form6.Show;
  end;
end;

procedure TForm1.MONSTERH1Click(Sender: TObject);
begin
  if (INVISIBLE_MENU = true) Then
  begin
    Form4.Show;
  end;
end;

end.
