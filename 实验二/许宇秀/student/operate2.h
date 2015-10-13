#include"operate.h"	

struct date
{
    int num;//ѧ��
	float score;//�ɼ�
};//ѧ����Ϣ�ṹ

char show()//��ʾ����
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

void savefile(LinkList<date> &L)//�浽�ļ�
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

void insertlist(LinkList<date> &L)//���ѧ����Ϣ
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

void printlist(LinkList<date> &L)//��ӡѧ���ĳɼ�
{

  int i;
  LinkNode<date> *p;
  p=L.head;
  date stu;
  for(i=0;i<L.length;i++)
  {	  stu=p->data;
	  printf("ѧ�ţ�%d �ɼ���%f\n",stu.num,stu.score);
	  p=p->next;
  }
}

void deletelist(LinkList<date>  &L)//ɾ��ѧ���ɼ�
{
	int index;
	printf("please enter a number(>=0 and <%d):\n",L.length);
	scanf("%d",&index);
	char sh[5];
	gets(sh);	
	deleteElem(L,index);
}
void clearlist(LinkList<date>  &L)//����ѧ���ɼ�
{
	date stu;
	int index;
	printf("please enter an number(>0 &&<%d):\n",L.length);
    scanf("%d",&index);
	getElem(L,index,stu);
	printf("ѧ�ţ�%d �ɼ���%f\n",stu.num,stu.score);
	char sh[5];
	gets(sh);
}

void exitsystem(char &c)//�˳�����
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
