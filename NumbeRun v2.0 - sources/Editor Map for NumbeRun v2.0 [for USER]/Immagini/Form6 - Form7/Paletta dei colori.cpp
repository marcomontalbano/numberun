
		/*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*
		*																	*
		*							*** EDITBIN ***							*
		*																	*
		*	Nome:			EditBin.cpp										*
		*	Programmato da: Montalbano Marco								*
		*	Genere:			Software - EditBin								*
		*	Piattaforma:	Windows											*
		*	Copyright:		2006 / 2007										*
		*																	*
		*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*/


//Per la compilazione del progetto:
/*
*
*	aggiungere nelle proprieta' del progetto,
*	nel tab del link, moduli oggetto/librerie
*	la libreria:		winmm.lib
*	(INIZIALIZZA PER L'AUDIO)
*
*/

//#include <graphics.h> 
#include <stdlib.h> 
#include <stdio.h> 
#include <conio.h> 
#include <gl/glut.h>



float dimensione_pixel = 1.0;
int a =5;
int b =5;

int WinWidth = dimensione_pixel * 150 + 1;           /* Width of the main window */
int WinHeight = dimensione_pixel * 70 + 1;          /* Height of the main window */
int RotationPoint[2];         /* Rotate around this point */
GLdouble GlobalMatrix[16];    /* Matrix to hold transformations */


void DrawPoints(int, int, float, float, float);


void SetCameraPosition(void)
{
  /* Set the viewing transformation */
  glMatrixMode(GL_PROJECTION);
  glLoadIdentity();
  gluOrtho2D(0.0,(GLdouble)WinWidth+1.0,(GLdouble)WinHeight+1.0,0.0);
  glMatrixMode(GL_MODELVIEW);
}

void ClearMatrix(GLdouble Matrix[])
{
  int i;

  for (i = 0; i < 16; i++)
    Matrix[i] = 0.0;
}

void IdentityMatrix(GLdouble Matrix[])
{
  int i;

  ClearMatrix(Matrix);      /* First, clear all matrix entries */
  for (i = 0; i < 16; i+=5) /* Then, set the diagonal entries to 1.0 */
    Matrix[i] = 1.0;
}

void disegna()
{
	float R1 = 0.0;
	float G1 = 0.0;
	float B1 = 0.0;
	int inc = 0;

	glClear(GL_COLOR_BUFFER_BIT);   //Clear the main windows

	for(R1 = 0.0; R1<1.1; R1 = R1 + 0.1)
	{
		for(G1 = 0.0; G1<1.1; G1 = G1 + 0.1)
		{
			for(B1 = 0.0; B1<1.1; B1 = B1 + 0.1)
			{
				DrawPoints(22 + (dimensione_pixel*b), 22 + (dimensione_pixel*a), R1, G1, B1);
				b++;
				if (b == 121)
				{
					b = 0;
					a++;
				}
				inc++;
				
				printf("%f - %f - %f\n", R1, G1, B1); 
			}	
		}
	}
	printf("totale: %d\n", inc); 
	
//glClear(GL_COLOR_BUFFER_BIT);   //Clear the main windows


	
}

void Initialize(void)
{
  /* Initialize the window and color mode */
  glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);
  glutInitWindowSize(WinWidth,WinHeight);
  glutCreateWindow("NumbeRun v1.0");

  glClearColor(0.0,0.0,0.0,0.0);   /* Background is black */
 
  SetCameraPosition();

  IdentityMatrix(GlobalMatrix);  /* Initialize global transformation matrix */
}

void DrawPoints(int X, int Y, float R, float G, float B)
{
	/* Set the Rotation point */
    RotationPoint[0] = X;
    RotationPoint[1] = Y;




	glLoadIdentity();    /* Load the identity matrix - fresh start */

	glPointSize(dimensione_pixel);
	glBegin(GL_POINTS);
	{
		glColor3f(R,G,B);        /* Color is magenta */
		glVertex2iv(RotationPoint);    /* Draw Rotation Point */
	} 
	glEnd();

	glFlush();           /* Flush all output to the main window */
}

void ReshapeWindow(int Width, int Height)
{
  WinWidth = Width;     /* Update the global WinWidth/WinHeight variables */
  WinHeight = Height;
  SetCameraPosition();  /* Update the camera view to be full screen */
  
  glViewport(0,0,WinWidth,WinHeight);
}
/*
void KeyPressed(unsigned char Key, int A, int B)
{
  switch (toupper(Key))
    {
		case 'D' :
			{
				system("cls");
				printf("%d",X);

				break;
			}
		case 'A' :
			{
				X-=dimensione_pixel;
				system("cls");
				printf("%d",X);

				break;
			}
		case 'W' :
			{
				Y-=dimensione_pixel;
				system("cls");
				printf("%d",X);

				break;
			}
		case 'S' :
			{
				Y+=dimensione_pixel;
				system("cls");
				printf("%d",X);

				break;
			}
    }
  glutPostRedisplay();
}
*/
int main(int argc, char** argv) 
{ 
	glutInit(&argc,argv);

	printf("programmed by: Montalbano Marco");

	Initialize();    /* Set up main window and variables */

	/* Set the Mouse / Keyboard / Reshape / Display callbacks */

	//glutKeyboardFunc(KeyPressed);
	//glutMouseFunc(MouseButtonPressed);
	
	
	glutReshapeFunc(ReshapeWindow);

	glutDisplayFunc(disegna);

	

	glutMainLoop();

	return 0; 
}
