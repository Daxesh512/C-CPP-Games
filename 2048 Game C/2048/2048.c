#include <stdio.h>
#include <time.h>
#include <stdlib.h>
#include <conio.h>
#include<time.h>
#include<ctype.h>
#include <time.h>
#include <windows.h>
#include <process.h>

#define UP 72
#define DOWN 80
#define LEFT 75
#define RIGHT 77

#define SIZE 4
#define BORDER 219
#define ESC 57
#define PR 2

int Matrix[SIZE+1][SIZE+1]={0};
int score=2048,last=0;

void starting();
void wait();
void waitL();
void vname();
void Display();
void print_ever();
void Action(int);
void Random_creator();
void Starting_Random();
int Temp_counter();
void ending();
void record();
void Down();
void Up();
void Left();
void Right();





void starting()
{
    int i;
    char s1[]="\xdb\xdb WEL - COME \xdb\xdb";
    char s2[]="PRESS ANY KEY TO CONTINUE";
    char s3[]="Single-player sliding block puzzle game";
    
    char s5[]="WEL-COME TO 2048 GAME IN 'C'";

    char t[]="BROUGHT TO YOU BY CODE-PROJECTS";
    char t1[]="For more projects";
    char t2[]="visit";
    char t3[]="code-projects.org";


    waitL();
    waitL();

    printf("\n\n\n\n\n\n\n\t\t\t\t");
    printer(s1);
    waitL();
    waitL();
    printf("\n\n\n\n\n\n\n\n\t\t\t\t\t\t");
    printer(s2);
    while(!kbhit());

    vname();

    printf("\n\n\n\n\t");
    printer(s5);
    waitL();
    printf("\n\n\n\n\t\t");
    waitL();
    printer(s3);
    waitL();
    waitL();
    waitL();
    waitL();
    waitL();
    waitL();
    system("cls");

    printf("\n\n\t\t\t\t\t");
    printer(t);
    waitL();
    printf("\n\n\n\n\t");
    printer(t1);
    printf("\n\n\t");
    printer(t2);
    printf("\n\n\t");
    printer(t3);
    printf("\n\n\t");
    for(i=0;i<10;i++)
    {
        waitL();
    }
    system("cls");
    printf("\n\n\n\t\t\tINSTRUCTION\n\n\n");
    printf(" ->  Enter arrow key to move\n\n");
    printf(" ->  For wining this game any one box have value 2048\n\n");
    printf(" -> You have maximum 2048 try to win the game\n\n\n\n");
    printf("\t\t\t\t\t\tPRESS ANY KEY TO PLAY\n");
    while(!kbhit());
}

void wait()
{
    int i;
    for(i=0;i<4500000;i++);
}
void waitL()
{
    int i;
    for(i=0;i<25;i++)
    {
        wait();
    }
}

void vname()
{
    int i=1;
    system("cls");
    system("color F");
    printf("\n\n\n\n\n\n   %c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();
    printf("\n");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();
    printf("\n");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();
    printf("\n");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();
    printf("\n");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();
    printf("\n");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf(" ");wait();printf(" ");wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c",PR);wait();printf("%c\n\n");wait();
    getch();
    waitL();
    printf("\n\t\t\t\t\t\tWAIT ");
    while(i<2)
    {
        system("color 9");
        waitL();
        system("color 1");
        waitL();
        system("color 9");
        waitL();
        system("color A");
        waitL();
        system("color 2");
        waitL();
        system("color A");
        waitL();
        system("color B");
        waitL();
        system("color 3");
        waitL();
        system("color B");
        waitL();
        system("color C");
        waitL();
        system("color 4");
        waitL();
        system("color C");
        waitL();
        system("color D");
        waitL();
        system("color 5");
        waitL();
        system("color D");
        waitL();
        system("color E");
        waitL();
        system("color 6");
        waitL();
        system("color E");
        waitL();
        system("color F");
        i++;
    }


}

printer(char s[])
{
    int i=0;
    while(s[i]!='\0')
    {
        printf("%c",s[i]);
        wait();
        wait();
        i++;
    }
}

void Action(int Arrow)
{

    switch(Arrow)
    {
        case UP:
            {
                Up();
                break;
            }
        case DOWN:
            {
                /* logic here */
                Down();
                break;
            }
        case LEFT:
            {
                Left();
                break;
            }
        case RIGHT:
            {
                Right();
                break;
            }
        default:
            {
                /*DO NOTHING */
                return;
            }
    }
    score--;
    Random_creater();
    Display();
}

void Random_creater()
{
    int temp1,temp2,add,i,j;
    srand(time(NULL));
    temp1=rand()%SIZE;  // i

    srand(time(NULL));
    temp2=rand()%SIZE;  // j

    if((temp1+temp2)%2==0)
        add=2;
    else
        add=4;

    for(i=0;i<temp1;i++)
    {
        for(j=temp2;j<SIZE;j++)
        {
            if(Matrix[i][j]==0)
            {
                Matrix[i][j]=add;
                return;
            }
        }
    }
}

void Display()
{
    /*  DONT DISPLAY 0
        CONSIDER 0 AS SINGLE SPACE
        DISPLAY
    */
    int i,j;
    system("cls");
    print_ever();
    for(i=0;i<SIZE;i++)
    {
        printf("\t\t\t %c",BORDER);
        for(j=0;j<SIZE;j++)
        {
            if(Matrix[i][j]==0)
            {
                printf("      ");
            }
            else
                printf(" %4d ",Matrix[i][j]);
        }
        printf("%c\n\t\t\t %c                        %c\n",BORDER,BORDER,BORDER);
    }
    printf("\t\t\t %c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c\n\n",BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER);
}
void print_ever()
{
    printf("\n\n\n\t\t\tTWO-ZERO-FOUR-EIGHT\n");
    printf("\t\t\t\t\t\t\t\t SCORE  : %d\n\n\n\n",score);
    printf("\t\t\t %c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c\n",BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER,BORDER);

}

void ending()
{
    /*here print prev high score and current score from file */
    printf("\n\n\t\t\t\tYOUR SCORE is  : %d",score);
    record();
}
void record(){
   char plname[20],nplname[20],cha,c;
   int i,j;
   FILE *info;
   info=fopen("record.txt","a+");
   getch();
   system("cls");
   printf("Enter your name\n");
   scanf("%[^\n]",plname);
   //************************
   for(j=0;plname[j]!='\0';j++){ //to convert the first letter after space to capital
   nplname[0]=toupper(plname[0]);
   if(plname[j-1]==' '){
   nplname[j]=toupper(plname[j]);
   nplname[j-1]=plname[j-1];}
   else nplname[j]=plname[j];
   }
   nplname[j]='\0';
   //*****************************
   //sdfprintf(info,"\t\t\tPlayers List\n");
   fprintf(info,"Player Name :%s\n",nplname);
    //for date and time

   time_t mytime;
  mytime = time(NULL);
  fprintf(info,"Played Date:%s",ctime(&mytime));
     //**************************
     fprintf(info,"Score:%d\n",score);//call score to display score
     //fprintf(info,"\nLevel:%d\n",10);//call level to display level
   for(i=0;i<=50;i++)
   fprintf(info,"%c",'_');
   fprintf(info,"\n");
   fclose(info);
   printf("wanna see past records press 'y'\n");
   cha=getch();
   system("cls");
   if(cha=='y'){
   info=fopen("record.txt","r");
   do{
       putchar(c=getc(info));
       }while(c!=EOF);}
     fclose(info);
     printf("\n\n\n\t\t\t\tPRESS ANY KEY TO EXIT\n");
     while(!kbhit());
    system("attrib +h +s record.txt");
}

void Starting_Random()
{
    Matrix[3][1]=8;
    Matrix[3][2]=32;
    Matrix[3][3]=16;
    Matrix[2][2]=8;
    Matrix[2][3]=8;
    Matrix[1][2]=8;

    Display();
}

int Temp_counter()
{
    /* IT SHOULD FIND MAX VALUE FROM WHOLE MATRIX  */
    int temp=0,i,j;

    for(i=0;i<SIZE;i++)
    {
        for(j=0;j<SIZE;j++)
        {
            if(Matrix[i][j]==2048)
                return(1);
            if(Matrix[i][j]==0)
                temp=1;
        }
    }
    if(temp==1)
    {
        last=0;
        return(-99);
    }
    else
    {
        if(last==1)
        {
            return(0);
        }
        last=1;
        return(-99);
    }
}

void Down()
{
    int i,j;
    for(j=0;j<SIZE;j++)
    {
        i=2;
        while(1)
        {
            while(Matrix[i][j]==0)
            {
                if(i==-1)
                    break;
                i--;
            }
            if(i==-1)
                break;
            while(i<SIZE-1 && (Matrix[i+1][j]==0 || Matrix[i][j]==Matrix[i+1][j]))
            {
                Matrix[i+1][j]+=Matrix[i][j];
                Matrix[i][j]=0;
                i++;
            }
            i--;
        }
    }
}
void Up()
{
    int i,j;
    for(j=0;j<SIZE;j++)
    {
        i=1;
        while(1)
        {
            while(Matrix[i][j]==0)
            {
                if(i==SIZE)
                    break;
                i++;
            }
            if(i==SIZE)
                break;
            while(i>0 && (Matrix[i-1][j]==0 || Matrix[i][j]==Matrix[i-1][j]))
            {
                Matrix[i-1][j]+=Matrix[i][j];
                Matrix[i][j]=0;
                i--;
            }
            i++;
        }
    }
}
void Right()
{
    int i,j;
    for(i=0;i<SIZE;i++)
    {
        j=2;
        while(1)
        {
            while(Matrix[i][j]==0)
            {
                if(j==-1)
                    break;
                j--;
            }
            if(j==-1)
                break;
            while(j<SIZE-1 && (Matrix[i][j+1]==0 || Matrix[i][j]==Matrix[i][j+1]))
            {
                Matrix[i][j+1]+=Matrix[i][j];
                Matrix[i][j]=0;
                j++;
            }
            j--;
        }
    }
}
void Left()
{
    int i,j;
    for(i=0;i<SIZE;i++)
    {
        j=1;
        while(1)
        {
            while(Matrix[i][j]==0)
            {
                if(j==SIZE)
                    break;
                j++;
            }
            if(j==SIZE)
                break;
            while(j>0 && (Matrix[i][j-1]==0 || Matrix[i][j]==Matrix[i][j-1]))
            {
                Matrix[i][j-1]+=Matrix[i][j];
                Matrix[i][j]=0;
                j--;
            }
            j++;
        }
    }
}






main()
{
    int aro;
    char Arrow;
    char s[]="THANKS FOR PLAYING, GOOD LUCK FOR NEXT TIME ";
    int temp;
    starting();
    Starting_Random();
    Arrow=DOWN;
    while(Arrow!=ESC)  //  HERE IF USER WANT TO EXIT THEN PRESS ESC KEY
    {
        Arrow=getch();
        aro=Arrow;
        Action(Arrow);
        temp=Temp_counter();
        if(temp==1)
        {
            printf("\n\t\t\tYOU WON");
            ending();
            break;
        }
        if(temp==0 || score<0)
        {
            printf("\n\t\t\tSORRY !  GAME OVER\n");
            break;
        }
    }

    system("cls");
    printf("\n\n\n\t");
    printer(s);
    waitL();
    waitL();
    waitL();
    waitL();
}
