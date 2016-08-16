program EditMap_Csharp;

uses
  Forms,
  A1 in 'A1.pas' {Form1},
  A2 in 'A2.pas' {Form2},
  A3 in 'A3.pas' {Form3},
  A4 in 'A4.pas' {Form4},
  A5 in 'A5.pas' {Form5},
  A6 in 'A6.pas' {Form6},
  A7 in 'A7.pas' {Form7},
  A8 in 'A8.pas' {Form8},
  A9 in 'A9.pas' {Form9};

{$R *.res}

begin
  Application.Initialize;
  Application.Title := 'EditMap NumbeRun';
  Application.CreateForm(TForm1, Form1);
  Application.CreateForm(TForm2, Form2);
  Application.CreateForm(TForm3, Form3);
  Application.CreateForm(TForm4, Form4);
  Application.CreateForm(TForm5, Form5);
  Application.CreateForm(TForm6, Form6);
  Application.CreateForm(TForm7, Form7);
  Application.CreateForm(TForm8, Form8);
  Application.CreateForm(TForm9, Form9);
  Application.Run;
end.
