#include "stdio.h"
#include"malloc.h"
typedef struct cpu
{
	char name;    //进程名
	int stime;    //服务时间
	int atime;    //到达时间
	int time;     //优先数
}pcb;
typedef pcb DataType;
typedef struct LNode
{
	DataType data;
	struct LNode *next;
}LNode,*LinkList;
  void InitLinkList(LinkList &L)  //初始化链表
  {
    	L->next=NULL;
  }
  LinkList InsertLinkNode(DataType a[])  //将给的数值加入链表
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
void DeleteLinkNode(LinkList &q)//删除结点
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
	 printf("时间片轮转法：\n");
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
		printf("t=%d,%c执行;\n",k,p->data.name);
		p->data.stime-=2;
		}
	   else
		 if(p->data.stime>0&&p->data.stime<2)
		{
          printf("t=%d,%c执行;\n",k+1,p->data.name);
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
for(j=0;j<4;j++)   //先把优先数序列按从小到大排好
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
   printf("优先数调度算法：\n");
   printf("进程名 到达时间 服务时间 开始时间 完成时间 周转时间\n");
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