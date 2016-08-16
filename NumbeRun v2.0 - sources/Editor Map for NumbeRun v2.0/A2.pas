unit A2;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Spin, ExtCtrls, Buttons, ExtDlgs;

type
  TForm2 = class(TForm)
    Bevel9: TBevel;
    Bevel10: TBevel;
    Bevel8: TBevel;
    Image_Selection: TImage;
    SpeedButton1: TSpeedButton;
    SpeedButton2: TSpeedButton;
    SpeedButton3: TSpeedButton;
    SpeedButton4: TSpeedButton;
    SpeedButton5: TSpeedButton;
    SpeedButton6: TSpeedButton;
    Label1: TLabel;
    Bevel1: TBevel;
    Label2: TLabel;
    Label3: TLabel;
    SpinEdit_X: TSpinEdit;
    SpinEdit_Y: TSpinEdit;
    Label4: TLabel;
    Bevel11: TBevel;
    Bevel2: TBevel;
    Image1: TImage;
    Bevel3: TBevel;
    Image2: TImage;
    Bevel4: TBevel;
    Image4: TImage;
    Bevel5: TBevel;
    Image3: TImage;
    Bevel6: TBevel;
    Image5: TImage;
    Bevel7: TBevel;
    Image6: TImage;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    Label10: TLabel;
    Label11: TLabel;
    Memo_Cplusplus: TMemo;
    Label12: TLabel;
    SpeedButton8: TSpeedButton;
    SpeedButton9: TSpeedButton;
    SpeedButton10: TSpeedButton;
    Label13: TLabel;
    Label14: TLabel;
    OpenPictureDialog1: TOpenPictureDialog;
    SavePictureDialog1: TSavePictureDialog;
    Bevel12: TBevel;
    SpeedButton7: TSpeedButton;
    SpeedButton11: TSpeedButton;
    Bevel13: TBevel;
    Label15: TLabel;
    Label16: TLabel;
    Label17: TLabel;
    Label18: TLabel;
    Label19: TLabel;
    Label20: TLabel;
    SpeedButton12: TSpeedButton;
    SpinEdit_Mostri: TSpinEdit;
    Label21: TLabel;
    SpeedButton13: TSpeedButton;
    Label22: TLabel;
    Label23: TLabel;
    Bevel14: TBevel;
    Bevel15: TBevel;
    Image7: TImage;
    Image8: TImage;
    Image9: TImage;
    SpeedButton14: TSpeedButton;
    CheckBox_Selettore: TCheckBox;
    SpinEdit_NumLivello: TSpinEdit;
    procedure SpeedButton1Click(Sender: TObject);
    procedure SpeedButton2Click(Sender: TObject);
    procedure SpeedButton3Click(Sender: TObject);
    procedure SpeedButton4Click(Sender: TObject);
    procedure SpeedButton5Click(Sender: TObject);
    procedure SpeedButton6Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure SpeedButton7Click(Sender: TObject);
    procedure SpeedButton8Click(Sender: TObject);
    procedure SpeedButton10Click(Sender: TObject);
    procedure SpeedButton9Click(Sender: TObject);
    procedure SpeedButton11Click(Sender: TObject);
    procedure SpeedButton12Click(Sender: TObject);
    procedure Memo_CplusplusKeyPress(Sender: TObject; var Key: Char);
    procedure ComboBox1KeyPress(Sender: TObject; var Key: Char);
    procedure SpeedButton13Click(Sender: TObject);
    procedure SpeedButton14Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form2: TForm2;
  Title_Form1: string;

  iNumeroMostri: integer;
  iCoordinateMostri: array [0..10] of array [0..2] of integer;
  iXpersonaggio, iYpersonaggio: integer;

implementation

uses A1, A3;

{$R *.dfm}

//Procedura il file *.bmp aperto
procedure Bitmap_Name(tipo: string);
var
        i, j: integer;
        path: string;
begin
        Form1.Edit_Bitmap.Text := '';
        If (tipo = 'O') Then
          path := Form2.OpenPictureDialog1.FileName;
        If (tipo = 'S') Then
          path := Form2.SavePictureDialog1.FileName;
        path := path + '?';
        i := 0;
        repeat
                i := i + 1;
        until (path[i] = '?');
        j := i;
        repeat
                i := i - 1;
        until (path[i] = '\');
        i := i + 1;
        repeat
                Form1.Edit_Bitmap.Text := Form1.Edit_Bitmap.Text + path[i];
                i := i + 1;
        until (j = i);
end;

procedure TForm2.SpeedButton1Click(Sender: TObject);
begin
  Form2.Image_Selection.Picture.Bitmap := Form2.SpeedButton1.Glyph;
  Form1.Show;
end;

procedure TForm2.SpeedButton2Click(Sender: TObject);
begin
  Form2.Image_Selection.Picture.Bitmap := Form2.SpeedButton2.Glyph;
  Form1.Show;
end;

procedure TForm2.SpeedButton3Click(Sender: TObject);
begin
  Form2.Image_Selection.Picture.Bitmap := Form2.SpeedButton3.Glyph;
  Form1.Show;
end;

procedure TForm2.SpeedButton4Click(Sender: TObject);
begin
  Form2.Image_Selection.Picture.Bitmap := Form2.SpeedButton4.Glyph;
  Form1.Show;
end;

procedure TForm2.SpeedButton5Click(Sender: TObject);
begin
  Form2.Image_Selection.Picture.Bitmap := Form2.SpeedButton5.Glyph;
  Form1.Show;
end;

procedure TForm2.SpeedButton6Click(Sender: TObject);
begin
  Form2.Image_Selection.Picture.Bitmap := Form2.SpeedButton6.Glyph;
  Form1.Show;
end;

procedure TForm2.FormCreate(Sender: TObject);
begin
  //Impostazioni del ComboBox1
  Form2.SpinEdit_NumLivello.Value := 1;
  //Titolo della form1
  Title_Form1 := 'Editor Map for C#';
  //Posizione della Form
  Form2.Top := Form1.Top + Form1.Height + 1;
  Form2.Left := Form1.Left;
  //Grandezza della form
  Form2.Width := Form1.Width;
  //Setta 'DIALOGS'
  Form2.OpenPictureDialog1.InitialDir := Form1.Edit_Path.Text + '\';
  Form2.SavePictureDialog1.InitialDir := Form1.Edit_Path.Text + '\';
end;

function sControllaOggetto: string;
var
  sValoreDaScrivere: string;
begin
  //Strada '0'
  if ((Form1.Image_Map.Canvas.Pixels[((Form2.SpinEdit_X.Value * 8) - 7),((Form2.SpinEdit_Y.Value * 8) - 7)]) = Form2.SpeedButton1.Glyph.Canvas.Pixels[2,2]) then
  begin
    sValoreDaScrivere := '000';
    Form3.SpinEdit1.Value := Form3.SpinEdit1.Value + 1;
  end;
  //Mura '7'
  if ((Form1.Image_Map.Canvas.Pixels[((Form2.SpinEdit_X.Value * 8) - 7),((Form2.SpinEdit_Y.Value * 8) - 7)]) = Form2.SpeedButton2.Glyph.Canvas.Pixels[2,2]) then
  begin
    sValoreDaScrivere := '012';
    Form3.SpinEdit2.Value := Form3.SpinEdit2.Value + 1;
  end;
  //Protagonista '5'
  if ((Form1.Image_Map.Canvas.Pixels[((Form2.SpinEdit_X.Value * 8) - 7),((Form2.SpinEdit_Y.Value * 8) - 7)]) = Form2.SpeedButton3.Glyph.Canvas.Pixels[2,2]) then
  begin
    sValoreDaScrivere := '000';
    Form3.SpinEdit3.Value := Form3.SpinEdit3.Value + 1;
  end;
  //Mostri '8'
  if ((Form1.Image_Map.Canvas.Pixels[((Form2.SpinEdit_X.Value * 8) - 7),((Form2.SpinEdit_Y.Value * 8) - 7)]) = Form2.SpeedButton4.Glyph.Canvas.Pixels[2,2]) then
  begin
    sValoreDaScrivere := '000';
    Form3.SpinEdit4.Value := Form3.SpinEdit4.Value + 1;
  end;
  //Tesori '2'
  if ((Form1.Image_Map.Canvas.Pixels[((Form2.SpinEdit_X.Value * 8) - 7),((Form2.SpinEdit_Y.Value * 8) - 7)]) = Form2.SpeedButton5.Glyph.Canvas.Pixels[2,2]) then
  begin
    sValoreDaScrivere := '013';
    Form3.SpinEdit5.Value := Form3.SpinEdit5.Value + 1;
  end;
  //Ostacoli '1'
  if (IntToStr(Form1.Image_Map.Canvas.Pixels[((Form2.SpinEdit_X.Value * 8) - 7),((Form2.SpinEdit_Y.Value * 8) - 7)]) = '15780518') then
  begin
    sValoreDaScrivere := '024';
    Form3.SpinEdit6.Value := Form3.SpinEdit6.Value + 1;
  end;
  //Fine Gioco '9'
  if ((Form1.Image_Map.Canvas.Pixels[((Form2.SpinEdit_X.Value * 8) - 7),((Form2.SpinEdit_Y.Value * 8) - 7)]) = Form2.SpeedButton12.Glyph.Canvas.Pixels[2,2]) then
  begin
    sValoreDaScrivere := '016';
    Form3.SpinEdit7.Value := Form3.SpinEdit7.Value + 1;
  end;
  //Crystal Potion '9'
  if ((Form1.Image_Map.Canvas.Pixels[((Form2.SpinEdit_X.Value * 8) - 7),((Form2.SpinEdit_Y.Value * 8) - 7)]) = Form2.SpeedButton13.Glyph.Canvas.Pixels[2,2]) then
  begin
    sValoreDaScrivere := '015';
    Form3.SpinEdit8.Value := Form3.SpinEdit8.Value + 1;
  end;

  result := sValoreDaScrivere;

end;

function sControllaCollisione: string;
var
  sValoreDaScrivere: string;
begin
  //Strada '0'
  if ((Form1.Image_Map.Canvas.Pixels[((Form2.SpinEdit_X.Value * 8) - 7),((Form2.SpinEdit_Y.Value * 8) - 7)]) = Form2.SpeedButton1.Glyph.Canvas.Pixels[2,2]) then
  begin
    sValoreDaScrivere := '''a''';
  end;
  //Mura '7'
  if ((Form1.Image_Map.Canvas.Pixels[((Form2.SpinEdit_X.Value * 8) - 7),((Form2.SpinEdit_Y.Value * 8) - 7)]) = Form2.SpeedButton2.Glyph.Canvas.Pixels[2,2]) then
  begin
    sValoreDaScrivere := '''p''';
  end;
  //Protagonista '5'
  if ((Form1.Image_Map.Canvas.Pixels[((Form2.SpinEdit_X.Value * 8) - 7),((Form2.SpinEdit_Y.Value * 8) - 7)]) = Form2.SpeedButton3.Glyph.Canvas.Pixels[2,2]) then
  begin
    sValoreDaScrivere := '''a''';

    iXpersonaggio := Form2.SpinEdit_X.Value-1;
    iYpersonaggio := Form2.SpinEdit_Y.Value-1;
  end;
  //Mostri '8'
  if ((Form1.Image_Map.Canvas.Pixels[((Form2.SpinEdit_X.Value * 8) - 7),((Form2.SpinEdit_Y.Value * 8) - 7)]) = Form2.SpeedButton4.Glyph.Canvas.Pixels[2,2]) then
  begin
    sValoreDaScrivere := '''a''';

    iCoordinateMostri[iNumeroMostri][0] := Form2.SpinEdit_X.Value-1;
    iCoordinateMostri[iNumeroMostri][1] := Form2.SpinEdit_Y.Value-1;
    iNumeroMostri := iNumeroMostri + 1;

  end;
  //Tesori '2'
  if ((Form1.Image_Map.Canvas.Pixels[((Form2.SpinEdit_X.Value * 8) - 7),((Form2.SpinEdit_Y.Value * 8) - 7)]) = Form2.SpeedButton5.Glyph.Canvas.Pixels[2,2]) then
  begin
    sValoreDaScrivere := '''a''';
  end;
  //Ostacoli '1'
  if (IntToStr(Form1.Image_Map.Canvas.Pixels[((Form2.SpinEdit_X.Value * 8) - 7),((Form2.SpinEdit_Y.Value * 8) - 7)]) = '15780518') then
  begin
    sValoreDaScrivere := '''a''';
  end;
  //Fine Gioco '9'
  if ((Form1.Image_Map.Canvas.Pixels[((Form2.SpinEdit_X.Value * 8) - 7),((Form2.SpinEdit_Y.Value * 8) - 7)]) = Form2.SpeedButton12.Glyph.Canvas.Pixels[2,2]) then
  begin
    sValoreDaScrivere := '''a''';
  end;
  //Crystal Potion '9'
  if ((Form1.Image_Map.Canvas.Pixels[((Form2.SpinEdit_X.Value * 8) - 7),((Form2.SpinEdit_Y.Value * 8) - 7)]) = Form2.SpeedButton13.Glyph.Canvas.Pixels[2,2]) then
  begin
    sValoreDaScrivere := '''a''';
  end;

  result := sValoreDaScrivere;

end;

procedure TForm2.SpeedButton7Click(Sender: TObject);
var
  h: integer;
  str: string;  // stringa completa
  str1: string; // prima parte della stringa
  str2: string; // ultima parte della stringa
begin
        //Cancellazione MEMO
        Form2.Memo_Cplusplus.Clear;
          //Form2.Memo_Cplusplus.Lines.Append('');
        //Impostazioni del cursore (bevel11)
        Form1.Image_MIRINO.Left := 0;
        Form1.Image_MIRINO.Top := 0;
        //Reset degli indici COORDINATE
        Form2.SpinEdit_X.Value := 1;
        Form2.SpinEdit_Y.Value := 1;
        //Impostazioni form3
        Form3.SpinEdit1.Value := 0;
        Form3.SpinEdit2.Value := 0;
        Form3.SpinEdit3.Value := 0;
        Form3.SpinEdit4.Value := 0;
        Form3.SpinEdit5.Value := 0;
        Form3.SpinEdit6.Value := 0;
        Form3.SpinEdit7.Value := 0;
        Form3.SpinEdit8.Value := 0;
        Form3.Close;

        //Imposta variabili globali
        iNumeroMostri := 0;
        iXpersonaggio := 0;
        iYpersonaggio := 0;

      //Scansione della mappa per il generamento codice C#
        {
        h := 0;
        repeat
          h := h + 1;
          Form2.Memo_Cplusplus.Lines.Append('o' + IntToStr(h) + ' = 0;');
          Form2.Memo_Cplusplus.Lines.Append('k' + IntToStr(h) + ' = 0;');
        until (h = Form2.SpinEdit_Mostri.Value);
        }

        // INSERT:  #region
          Form2.Memo_Cplusplus.Lines.Append('    #region Level ' + inttostr(Form2.SpinEdit_NumLivello.Value));
          Form2.Memo_Cplusplus.Lines.Append('    ');


        // INSERT:  map ->  Ln_iMap
          Form2.Memo_Cplusplus.Lines.Append('    /// <summary>');
          Form2.Memo_Cplusplus.Lines.Append('    /// Matrice "L' + inttostr(Form2.SpinEdit_NumLivello.Value) + '_iMap"');
          Form2.Memo_Cplusplus.Lines.Append('    /// </summary>');
          Form2.Memo_Cplusplus.Lines.Append('    public int[,] L' + inttostr(Form2.SpinEdit_NumLivello.Value) + '_iMap =');
          Form2.Memo_Cplusplus.Lines.Append('        {');
          // Scritta delle 33 righe
          h := 1;
          str1 := '            {000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,';
          str2 := '000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000},';
          repeat
            Form2.Memo_Cplusplus.Lines.Append(str1 + str2);
            h := h + 1;
          until (h > 33);
          Form2.Memo_Cplusplus.Lines.Append('        };');
          Form2.Memo_Cplusplus.Lines.Append('    ');


        // INSERT:  map ->  Ln_iMapTrans
          Form2.Memo_Cplusplus.Lines.Append('    /// <summary>');
          Form2.Memo_Cplusplus.Lines.Append('    /// Matrice "L' + inttostr(Form2.SpinEdit_NumLivello.Value) + '_iMapTrans"');
          Form2.Memo_Cplusplus.Lines.Append('    /// </summary>');
          Form2.Memo_Cplusplus.Lines.Append('    public int[,] L' + inttostr(Form2.SpinEdit_NumLivello.Value) + '_iMapTrans =');
          Form2.Memo_Cplusplus.Lines.Append('        {');
          // Scritta delle prime 4 righe
          h := 1;
          str1 := '            {000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,';
          str2 := '000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000},';
          repeat
            Form2.Memo_Cplusplus.Lines.Append(str1 + str2);
            h := h + 1;
          until (h > 4);
          // Scritta staccionata nord
          str1 := '            {000,000,000,000,000,000,000,000,000,028,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,';
          str2 := '032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,029,000,000,000,000,000,000,000,000,000},';
          Form2.Memo_Cplusplus.Lines.Append(str1 + str2);
          // Scritta della parte centrale (20 righe)
          h := 1;
          str1 := '            {000,000,000,000,000,000,000,000,000,033,';
          str2 := '033,000,000,000,000,000,000,000,000,000},';
          repeat
            str := str1;
            repeat
              str := str + sControllaOggetto() + ',';
              Form2.SpinEdit_X.Value := Form2.SpinEdit_X.Value + 1;
            until (Form2.SpinEdit_X.Value = A1.SpinEdit_X_MAX + 1);
            str := str + str2;
            Form2.Memo_Cplusplus.Lines.Append(str);
            Form2.SpinEdit_X.Value := 1;
            Form2.SpinEdit_Y.Value := Form2.SpinEdit_Y.Value + 1;
          until (Form2.SpinEdit_Y.Value = A1.SpinEdit_Y_MAX + 1);
          // Scritta staccionata sud
          str1 := '            {000,000,000,000,000,000,000,000,000,030,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,';
          str2 := '032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,032,031,000,000,000,000,000,000,000,000,000},';
          Form2.Memo_Cplusplus.Lines.Append(str1 + str2);
          // Scritta delle ultime 7 righe
          h := 1;
          str1 := '            {000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,';
          str2 := '000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000},';
          repeat
            Form2.Memo_Cplusplus.Lines.Append(str1 + str2);
            h := h + 1;
          until (h > 7);
          Form2.Memo_Cplusplus.Lines.Append('        };');
          Form2.Memo_Cplusplus.Lines.Append('    ');


        // INSERT:  map ->  Ln_iMapObjects
          Form2.Memo_Cplusplus.Lines.Append('    /// <summary>');
          Form2.Memo_Cplusplus.Lines.Append('    /// Matrice "L' + inttostr(Form2.SpinEdit_NumLivello.Value) + '_iMapObjects"');
          Form2.Memo_Cplusplus.Lines.Append('    /// </summary>');
          Form2.Memo_Cplusplus.Lines.Append('    public int[,] L' + inttostr(Form2.SpinEdit_NumLivello.Value) + '_iMapObjects =');
          Form2.Memo_Cplusplus.Lines.Append('        {');
          // Scritta delle 33 righe
          h := 1;
          str1 := '            {000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,';
          str2 := '000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000,000},';
          repeat
            Form2.Memo_Cplusplus.Lines.Append(str1 + str2);
            h := h + 1;
          until (h > 33);
          Form2.Memo_Cplusplus.Lines.Append('        };');
          Form2.Memo_Cplusplus.Lines.Append('    ');


          //** Reset degli indici COORDINATE **
          Form2.SpinEdit_X.Value := 1;
          Form2.SpinEdit_Y.Value := 1;
        // INSERT:  map ->  Ln_cMapWalkable
          Form2.Memo_Cplusplus.Lines.Append('    /// <summary>');
          Form2.Memo_Cplusplus.Lines.Append('    /// Matrice "L' + inttostr(Form2.SpinEdit_NumLivello.Value) + '_cMapWalkable"');
          Form2.Memo_Cplusplus.Lines.Append('    /// </summary>');
          Form2.Memo_Cplusplus.Lines.Append('    public char[,] L' + inttostr(Form2.SpinEdit_NumLivello.Value) + '_cMapWalkable =');
          Form2.Memo_Cplusplus.Lines.Append('        {');
          // Scritta delle prime 5 righe
          h := 1;
          str1 := '            {''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',';
          str2 := '''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p''},';
          repeat
            Form2.Memo_Cplusplus.Lines.Append(str1 + str2);
            h := h + 1;
          until (h > 5);
          // Scritta della parte centrale (20 righe)
          h := 1;
          str1 := '            {''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',';
          str2 := '''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p''},';
          repeat
            str := str1;
            repeat
              str := str + sControllaCollisione() + ',';
              Form2.SpinEdit_X.Value := Form2.SpinEdit_X.Value + 1;
            until (Form2.SpinEdit_X.Value = A1.SpinEdit_X_MAX + 1);
            str := str + str2;
            Form2.Memo_Cplusplus.Lines.Append(str);
            Form2.SpinEdit_X.Value := 1;
            Form2.SpinEdit_Y.Value := Form2.SpinEdit_Y.Value + 1;
          until (Form2.SpinEdit_Y.Value = A1.SpinEdit_Y_MAX + 1);
          // Scritta delle ultime 8 righe
          h := 1;
          str1 := '            {''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',';
          str2 := '''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p'',''p''},';
          repeat
            Form2.Memo_Cplusplus.Lines.Append(str1 + str2);
            h := h + 1;
          until (h > 8);
          Form2.Memo_Cplusplus.Lines.Append('        };');
          Form2.Memo_Cplusplus.Lines.Append('    ');


        // INSERT:  funzione livello
          Form2.Memo_Cplusplus.Lines.Append('    /// <summary>');
          Form2.Memo_Cplusplus.Lines.Append('    /// Carica il livello ' + inttostr(Form2.SpinEdit_NumLivello.Value));
          Form2.Memo_Cplusplus.Lines.Append('    /// </summary>');
          Form2.Memo_Cplusplus.Lines.Append('    public void vLoadLevel' + inttostr(Form2.SpinEdit_NumLivello.Value) + '()');
          Form2.Memo_Cplusplus.Lines.Append('    {');
          Form2.Memo_Cplusplus.Lines.Append('        // Carica la mappa');
          Form2.Memo_Cplusplus.Lines.Append('        for (int i = 0; i < VariabiliGlobali.Globals.myMaps.MapHeight; i++)');
          Form2.Memo_Cplusplus.Lines.Append('        {');
          Form2.Memo_Cplusplus.Lines.Append('            for (int j = 0; j < VariabiliGlobali.Globals.myMaps.MapWidth; j++)');
          Form2.Memo_Cplusplus.Lines.Append('            {');
          Form2.Memo_Cplusplus.Lines.Append('                VariabiliGlobali.Globals.myMaps.iMapTrans[i, j] = this.L' + inttostr(Form2.SpinEdit_NumLivello.Value) + '_iMapTrans[i, j];');
          Form2.Memo_Cplusplus.Lines.Append('                VariabiliGlobali.Globals.myMaps.iMap[i, j] = this.L' + inttostr(Form2.SpinEdit_NumLivello.Value) + '_iMap[i, j];');
          Form2.Memo_Cplusplus.Lines.Append('                VariabiliGlobali.Globals.myMaps.iMapObjects[i, j] = this.L' + inttostr(Form2.SpinEdit_NumLivello.Value) + '_iMapObjects[i, j];');
          Form2.Memo_Cplusplus.Lines.Append('                VariabiliGlobali.Globals.myMaps.cMapWalkable[i, j] = this.L' + inttostr(Form2.SpinEdit_NumLivello.Value) + '_cMapWalkable[i, j];');
          Form2.Memo_Cplusplus.Lines.Append('            }');
          Form2.Memo_Cplusplus.Lines.Append('        }');
          Form2.Memo_Cplusplus.Lines.Append('        ');
          Form2.Memo_Cplusplus.Lines.Append('        //Coordinate del Personaggio');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMaps.iMapX = ' + inttostr(iXpersonaggio) + ';');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMaps.iMapY = ' + inttostr(iYpersonaggio) + ';');
          Form2.Memo_Cplusplus.Lines.Append('        ');
          Form2.Memo_Cplusplus.Lines.Append('        // Numero dei mostri contenuti nella mappa');
          Form2.Memo_Cplusplus.Lines.Append('        iNumeroMostriNellaMappa = ' + inttostr(iNumeroMostri) + ';');
          Form2.Memo_Cplusplus.Lines.Append('        ');
          Form2.Memo_Cplusplus.Lines.Append('        //Coordinate del Mostro1');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[0].MlaRun_.bSelezionato = true;');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[0].iPlayerAvatarX = ' + inttostr(iCoordinateMostri[0][0]) + ';');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[0].iPlayerAvatarY = ' + inttostr(iCoordinateMostri[0][1]) + ';');
          //Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMaps.iMapTrans[');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[0].iPlayerAvatarY,');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[0].iPlayerAvatarX] = 002 + 000;');
          Form2.Memo_Cplusplus.Lines.Append('        ');
          Form2.Memo_Cplusplus.Lines.Append('        //Coordinate del Mostro2');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[1].MlaRun_.bSelezionato = true;');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[1].iPlayerAvatarX = ' + inttostr(iCoordinateMostri[1][0]) + ';');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[1].iPlayerAvatarY = ' + inttostr(iCoordinateMostri[1][1]) + ';');
          //Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMaps.iMapTrans[');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[1].iPlayerAvatarY,');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[1].iPlayerAvatarX] = 002 + 001;');
          Form2.Memo_Cplusplus.Lines.Append('        ');
          Form2.Memo_Cplusplus.Lines.Append('        //Coordinate del Mostro3');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[2].MlaRun_.bSelezionato = true;');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[2].iPlayerAvatarX = ' + inttostr(iCoordinateMostri[2][0]) + ';');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[2].iPlayerAvatarY = ' + inttostr(iCoordinateMostri[2][1]) + ';');
          //Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMaps.iMapTrans[');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[2].iPlayerAvatarY,');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[2].iPlayerAvatarX] = 002 + 002;');
          Form2.Memo_Cplusplus.Lines.Append('        ');
          Form2.Memo_Cplusplus.Lines.Append('        //Coordinate del Mostro4');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[3].MlaRun_.bSelezionato = true;');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[3].iPlayerAvatarX = ' + inttostr(iCoordinateMostri[3][0]) + ';');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[3].iPlayerAvatarY = ' + inttostr(iCoordinateMostri[3][1]) + ';');
          //Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMaps.iMapTrans[');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[3].iPlayerAvatarY,');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[3].iPlayerAvatarX] = 002 + 003;');
          Form2.Memo_Cplusplus.Lines.Append('        ');
          Form2.Memo_Cplusplus.Lines.Append('        //Coordinate del Mostro5');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[4].MlaRun_.bSelezionato = true;');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[4].iPlayerAvatarX = ' + inttostr(iCoordinateMostri[4][0]) + ';');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[4].iPlayerAvatarY = ' + inttostr(iCoordinateMostri[4][1]) + ';');
          //Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMaps.iMapTrans[');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[4].iPlayerAvatarY,');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[4].iPlayerAvatarX] = 002 + 004;');
          Form2.Memo_Cplusplus.Lines.Append('        ');
          Form2.Memo_Cplusplus.Lines.Append('        //Coordinate del Mostro6');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[5].MlaRun_.bSelezionato = true;');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[5].iPlayerAvatarX = ' + inttostr(iCoordinateMostri[5][0]) + ';');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[5].iPlayerAvatarY = ' + inttostr(iCoordinateMostri[5][1]) + ';');
          //Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMaps.iMapTrans[');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[5].iPlayerAvatarY,');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[5].iPlayerAvatarX] = 002 + 005;');
          Form2.Memo_Cplusplus.Lines.Append('        ');
          Form2.Memo_Cplusplus.Lines.Append('        //Coordinate del Mostro7');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[6].MlaRun_.bSelezionato = true;');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[6].iPlayerAvatarX = ' + inttostr(iCoordinateMostri[6][0]) + ';');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[6].iPlayerAvatarY = ' + inttostr(iCoordinateMostri[6][1]) + ';');
          //Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMaps.iMapTrans[');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[6].iPlayerAvatarY,');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[6].iPlayerAvatarX] = 002 + 006;');
          Form2.Memo_Cplusplus.Lines.Append('        ');
          Form2.Memo_Cplusplus.Lines.Append('        //Coordinate del Mostro8');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[7].MlaRun_.bSelezionato = true;');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[7].iPlayerAvatarX = ' + inttostr(iCoordinateMostri[7][0]) + ';');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[7].iPlayerAvatarY = ' + inttostr(iCoordinateMostri[7][1]) + ';');
          //Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMaps.iMapTrans[');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[7].iPlayerAvatarY,');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[7].iPlayerAvatarX] = 002 + 007;');
          Form2.Memo_Cplusplus.Lines.Append('        ');
          Form2.Memo_Cplusplus.Lines.Append('        //Coordinate del Mostro9');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[8].MlaRun_.bSelezionato = true;');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[8].iPlayerAvatarX = ' + inttostr(iCoordinateMostri[8][0]) + ';');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[8].iPlayerAvatarY = ' + inttostr(iCoordinateMostri[8][1]) + ';');
          //Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMaps.iMapTrans[');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[8].iPlayerAvatarY,');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[8].iPlayerAvatarX] = 002 + 008;');
          Form2.Memo_Cplusplus.Lines.Append('        ');
          Form2.Memo_Cplusplus.Lines.Append('        //Coordinate del Mostro10');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[9].MlaRun_.bSelezionato = true;');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[9].iPlayerAvatarX = ' + inttostr(iCoordinateMostri[9][0]) + ';');
          Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMonster[9].iPlayerAvatarY = ' + inttostr(iCoordinateMostri[9][1]) + ';');
          //Form2.Memo_Cplusplus.Lines.Append('        VariabiliGlobali.Globals.myMaps.iMapTrans[');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[9].iPlayerAvatarY,');
          //Form2.Memo_Cplusplus.Lines.Append('            VariabiliGlobali.Globals.myMonster[9].iPlayerAvatarX] = 002 + 009;');
          Form2.Memo_Cplusplus.Lines.Append('        ');
          Form2.Memo_Cplusplus.Lines.Append('    }');
          Form2.Memo_Cplusplus.Lines.Append('    ');
          Form2.Memo_Cplusplus.Lines.Append('    #endregion');

          
        //Impostazioni del cursore (bevel11)
        Form1.Image_MIRINO.Left := 0;
        Form1.Image_MIRINO.Top := 0;
        //Reset degli indici COORDINATE
        Form2.SpinEdit_X.Value := 1;
        Form2.SpinEdit_Y.Value := 1;

  //Controllo di errori
      If ((Form3.SpinEdit3.Value <> 1) or (Form3.SpinEdit4.Value > Form2.SpinEdit_Mostri.Value) or (Form3.SpinEdit7.Value <> 1) or (Form3.SpinEdit5.Value < 1)) Then
      Begin
        //Protagonista
        If (Form3.SpinEdit3.Value <> 1) Then
        begin
            Form2.Memo_Cplusplus.Clear;
            Form3.Close;
            Application.MessageBox('Posizionare 1 ''protagonista'' sulla mappa', pchar(Form1.Caption), Windows.MB_ICONERROR);
        end;
        //Fine Gioco
        If (Form3.SpinEdit7.Value <> 1) Then
        begin
            Form2.Memo_Cplusplus.Clear;
            Form3.Close;
            Application.MessageBox('Posizionare 1 ''fine gioco'' sulla mappa', pchar(Form1.Caption), Windows.MB_ICONERROR);
        end;
        //Tesori
        If (Form3.SpinEdit7.Value < 1) Then
        begin
            Form2.Memo_Cplusplus.Clear;
            Form3.Close;
            Application.MessageBox('Posizionare almeno 1 ''tesori'' sulla mappa', pchar(Form1.Caption), Windows.MB_ICONERROR);
        end;
        //Mostri
        If (Form3.SpinEdit4.Value > Form2.SpinEdit_Mostri.Value) Then
        begin
            Form2.Memo_Cplusplus.Clear;
            Form3.Close;
            Application.MessageBox(pchar('Posizionare massimo ' + inttostr(Form2.SpinEdit_Mostri.Value) + ' ''mostri'' sulla mappa'), pchar(Form1.Caption), Windows.MB_ICONERROR);
        end;
      End else
      Begin
        //Copia il codice generato negli appunti
        Form2.Memo_Cplusplus.SelectAll;
        Form2.Memo_Cplusplus.CopyToClipboard;
        Form2.Memo_Cplusplus.SelectAll;
        //Impostazioni finali
        Form3.Show;
        Application.MessageBox('Codice generato correttamente', pchar(Form1.Caption), Windows.MB_ICONASTERISK);
      End;
end;

procedure TForm2.SpeedButton8Click(Sender: TObject);
begin
  Form2.Memo_Cplusplus.Lines.Text := SysUtils.IntToStr(Form1.Image_Map.Canvas.Pixels[1,1]);
end;

procedure TForm2.SpeedButton10Click(Sender: TObject);
begin
  //Setta impostazioni per il salvataggio
  If not(Form2.OpenPictureDialog1.FileName = '') Then
    Form2.SavePictureDialog1.FileName := Form2.OpenPictureDialog1.FileName;

  //Salvataggio intelligente
  If Form2.SavePictureDialog1.Execute Then
    If ((SysUtils.FileExists(Form2.SavePictureDialog1.FileName)) or (SysUtils.FileExists(Form2.SavePictureDialog1.FileName + '.bmp'))) Then
    begin
      If Application.MessageBox('Il file esiste già, sovrascrivere?', 'Salva playlist', Windows.MB_YESNO) = Windows.ID_YES Then
      begin
        If (SysUtils.FileExists(Form2.SavePictureDialog1.FileName + '.bmp')) Then
          Form1.Image_Map.Picture.SaveToFile(Form2.SavePictureDialog1.FileName + '.bmp') else
            Form1.Image_Map.Picture.SaveToFile(Form2.SavePictureDialog1.FileName);
        //Nome della form1
        Bitmap_Name('S');
        Form1.Caption := Title_Form1 + ' - ' + Form1.Edit_Bitmap.Text;
      End else
        Form2.SpeedButton10.Click;
    end else
    begin
      Form1.Image_Map.Picture.SaveToFile(Form2.SavePictureDialog1.FileName + '.bmp');
      //Nome della form1
      Bitmap_Name('S');
      Form1.Caption := Title_Form1 + ' - ' + Form1.Edit_Bitmap.Text;
    end;
end;

procedure TForm2.SpeedButton9Click(Sender: TObject);
begin
  If Form2.OpenPictureDialog1.Execute Then
  begin
    Form1.Image_Map.Picture.LoadFromFile(Form2.OpenPictureDialog1.FileName);
    Form2.Memo_Cplusplus.Clear;
    Form3.SpinEdit1.Value := 0;
    Form3.SpinEdit2.Value := 0;
    Form3.SpinEdit3.Value := 0;
    Form3.SpinEdit4.Value := 0;
    Form3.SpinEdit5.Value := 0;
    Form3.SpinEdit6.Value := 0;
    Form3.SpinEdit7.Value := 0;
    Form3.SpinEdit8.Value := 0;
    Form3.Close;
    //Nome della form1
    Bitmap_Name('O');
    Form1.Caption := Title_Form1 + ' - ' + Form1.Edit_Bitmap.Text;
  end;
end;

procedure TForm2.SpeedButton11Click(Sender: TObject);
begin
  //Impostazioni del salvataggio
  Form2.SavePictureDialog1.FileName := '';
  //Caricamento immagine di Default
  Form1.Image_Map.Picture.Bitmap.LoadFromResourceName(HInstance, 'DEFAULT');
  //Cancellazione MEMO
  Form2.Memo_Cplusplus.Clear;
  //Impostazioni del cursore (bevel11)
  Form1.Image_MIRINO.Left := 0;
  Form1.Image_MIRINO.Top := 0;
  //Reset degli indici COORDINATE
  Form2.SpinEdit_X.Value := 1;
  Form2.SpinEdit_Y.Value := 1;
  //Mostra form1
  Form1.Show;
  //Impostazioni form3
  Form3.SpinEdit1.Value := 0;
  Form3.SpinEdit2.Value := 0;
  Form3.SpinEdit3.Value := 0;
  Form3.SpinEdit4.Value := 0;
  Form3.SpinEdit5.Value := 0;
  Form3.SpinEdit6.Value := 0;
  Form3.SpinEdit7.Value := 0;
  Form3.SpinEdit8.Value := 0;
  Form3.Close;
  //Impostazioni form1
  Form1.Caption := Title_Form1;
end;

procedure TForm2.SpeedButton12Click(Sender: TObject);
begin
  Form2.Image_Selection.Picture.Bitmap := Form2.SpeedButton12.Glyph;
  Form1.Show;
end;

procedure TForm2.Memo_CplusplusKeyPress(Sender: TObject; var Key: Char);
begin
    If (key = '\') then
    begin
        Form1.Show;
    end;
end;

procedure TForm2.ComboBox1KeyPress(Sender: TObject; var Key: Char);
begin
    If (key = '\') then
    begin
        Form1.Show;
    end;
end;

procedure TForm2.SpeedButton13Click(Sender: TObject);
begin
  Form2.Image_Selection.Picture.Bitmap := Form2.SpeedButton13.Glyph;
  Form1.Show;
end;

procedure TForm2.SpeedButton14Click(Sender: TObject);
begin
  if (Form2.CheckBox_Selettore.Checked = false) then
  begin
    Form2.CheckBox_Selettore.Checked := true;
  end else
  begin
    Form2.CheckBox_Selettore.Checked := false;
  end;
end;

end.
