#include "stdio.h"
#include"malloc.h"
typedef struct cpu
{
	char name;    //������
	int stime;    //����ʱ��
	int atime;    //����ʱ��
	int time;     //������
}pcb;
typedef pcb DataType;
typedef struct LNode
{
	DataType data;
	struct LNode *next;
}LNode,*LinkList;
  void InitLinkList(LinkList &L)  //��ʼ������
  {
    	L->next=NULL;
  }
  LinkList InsertLinkNode(DataType a[])  //��������ֵ��������
  {  
    LinkList L,r,p;  
    L = (LinkList)malloc(sizeof(LNode));  
    L->next = L;  
    r = L;                             
    for(int i=0;i<4;i++) 
    {  
        p = (LinkList)malloc(sizeof(LNode)); 
        p->data = a[i];  
        p->next = r->next;  
        r->next = p;  
        r = p;  
    }  
    r->next = L;  
	return L;
}  
void DeleteLinkNode(LinkList &q)//ɾ�����
{
	
	LinkList s;
	s=(LinkList)malloc(sizeof(LNode));
	s=q->next;
	q->next=s->next;
	delete s;
}
void main()
{
     pcb a[4]={{'A',3,0	,12},{'B',5,1,31},{'C',2,2,21},{'D',4,3,10}};
	 pcb b;
     LinkList L=InsertLinkNode(a);
	 printf("ʱ��Ƭ��ת����\n");
     int i,sum,k,j,s,x,ftime,ztime,ytime;
	 ytime=0;
	 sum=0;
	 k=0;
	 j=0;
	 s=0;
     LinkList p;
     p=L->next ;  
 		for(i=0;i<4;i++)
		{
		   if(a[i].stime%2==0)
           s=a[i].stime /2;
		   else
		   s=a[i].stime /2+1;
		   sum+=s;
		}
	for(i=0;i<sum;i++)
	{   
        if(p->data .stime >=2)
		{
		printf("t=%d,%cִ��;\n",k,p->data.name);
		p->data.stime-=2;
		}
	   else
		 if(p->data.stime>0&&p->data.stime<2)
		{
          printf("t=%d,%cִ��;\n",k+1,p->data.name);
		  p->data.stime -=1;
		
		}
		if(p->next->data.stime<=0)
		DeleteLinkNode(p);
		p=p->next;
		if(p->data.stime>=2)
		k+=2;
		if(p->data.stime>0&&p->data.stime<2)
		k=k+p->data .stime ;
		  
	}
	char y;
for(j=0;j<4;j++)   //�Ȱ����������а���С�����ź�
{
	for(i=0;i<4-j;i++)
	{
		if(a[i].time >a[i+1].time )
		{
			b=a[i];
			a[i]=a[i+1];
			a[i+1]=b;
		}
	}
}
for(i=0;i<4;i++)
{
    if(a[i].atime ==0)
{
   y=a[i].name ;
   x=a[i].stime ;
   ftime=a[i].stime ;
   ztime=ftime-a[i].atime ;
   printf("�����������㷨��\n");
   printf("������ ����ʱ�� ����ʱ�� ��ʼʱ�� ���ʱ�� ��תʱ��\n");
   printf("%5c%8d%8d%8d%10d%10d\n",a[i].name ,a[i].atime ,a[i] .stime ,ytime ,ftime,ztime);
}
}
for(i=0;i<4;i++)
{
	if(a[i].name ==y)
	{	
		i++; 
	}
if(a[i].atime <=x)
{
   ftime=a[i].stime+ftime; 
   ztime=ftime-a[i].atime ;
   ytime=ftime-a[i].stime ;
   printf("%5c%8d%8d%8d%10d%10d\n",a[i].name ,a[i].atime ,a[i] .stime ,ytime,ftime,ztime);
   x=x+a[i].stime ;

}
else
{
            b=a[i];
			a[i]=a[i+1];
			a[i+1]=b;
			i--;

}
}
}