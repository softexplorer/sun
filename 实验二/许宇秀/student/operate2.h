#include"operate.h"	

struct date
{
    int num;//学号
	float score;//成绩
};//学生信息结构

char show()//显示界面
{   
    char c;
	printf("save to file(s)\n");
	printf("insert to list(i)\n");
	printf("delete from list(d)\n");
	printf("clear list(c)\n");
	printf("print list(p)\n");
	printf("exit system(e)\n");
	scanf("%c",&c);
	return c;
}

void savefile(LinkList<date> &L)//存到文件
{
	date stu;
	int i;
	FILE *f=fopen("stuI.text","w");
	for(i=0;i<L.length;i++)
	{
		getElem(L,i,stu);
		fprintf(f,"%d %f",stu.num,stu.score);
	}
    fclose(f);
}

void insertlist(LinkList<date> &L)//添加学生信息
{
	date stu;
	printf("please enter student information:\n");
	scanf("%d%f",&stu.num,&stu.score);
	int c=L.length;
	c++;
	if(!(ListInsert(L,c,stu)))
		printf("error");
	char sh[5];
	gets(sh);
}

void printlist(LinkList<date> &L)//打印学生的成绩
{

  int i;
  LinkNode<date> *p;
  p=L.head;
  date stu;
  for(i=0;i<L.length;i++)
  {	  stu=p->data;
	  printf("学号：%d 成绩：%f\n",stu.num,stu.score);
	  p=p->next;
  }
}

void deletelist(LinkList<date>  &L)//删除学生成绩
{
	int index;
	printf("please enter a number(>=0 and <%d):\n",L.length);
	scanf("%d",&index);
	char sh[5];
	gets(sh);	
	deleteElem(L,index);
}
void clearlist(LinkList<date>  &L)//查找学生成绩
{
	date stu;
	int index;
	printf("please enter an number(>0 &&<%d):\n",L.length);
    scanf("%d",&index);
	getElem(L,index,stu);
	printf("学号：%d 成绩：%f\n",stu.num,stu.score);
	char sh[5];
	gets(sh);
}

void exitsystem(char &c)//退出界面
{
  c=0;
}

void showanddeal()
{   
	char ch;
	LinkList<date>  StuIn;
    InitLinkList(StuIn);
	do
	{	
	    ch=show();
		getchar();
        switch(ch)
		{
	     case 's': savefile(StuIn);break;
         case 'i': insertlist(StuIn);break;
	     case 'd': deletelist(StuIn);break;
	     case 'c': clearlist(StuIn);break;
	     case 'p': printlist(StuIn);break;
	     case 'e': exitsystem(ch);break;
		 default:printf("error\n");
		}
	}while(ch);

}
