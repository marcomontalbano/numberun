program Image_Editor;

uses
  Forms,
  A1 in 'A1.pas' {Form1},
  A2 in 'A2.pas' {Form2},
  A3 in 'A3.pas' {Form3},
  A4 in 'A4.pas' {Form4},
  A5 in 'A5.pas' {Form5};

{$R *.res}

begin
  Application.Initialize;
  Application.Title := 'Image Editor for NumbeRun';
  Application.CreateForm(TForm1, Form1);
  Application.CreateForm(TForm2, Form2);
  Application.CreateForm(TForm3, Form3);
  Application.CreateForm(TForm4, Form4);
  Application.CreateForm(TForm5, Form5);
  Application.Run;
end.
