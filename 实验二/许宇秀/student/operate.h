#ifndef _LINKLIST_H 
#define _LINKLIST_H
#define ERROR 0
#define ok 1
#include <stdio.h>
typedef int Status;

template<typename DataType>
struct LinkNode
{
	DataType data;//数据域
	LinkNode<DataType> *next;//指针域
};//定义链表结点

template<typename DataType>
struct LinkList
{
	LinkNode<DataType> *head;//头指针
	int length;//链表长度
};//定义链表

template<typename DataType>
void InitLinkList(LinkList<DataType> &L)
{
	L.head = NULL;
	L.length = 0;
}//线性表初始化

template<typename DataType>
void InitLinkNode(LinkNode<DataType> *LN,DataType data)
{
	LN->next = NULL;
	LN->data = data;
}//结点初始化

template<typename DataType>//添加链表结点
Status ListInsert(LinkList<DataType> &L,int index,DataType data)
{
	if(index<1||index>L.length+1)
		return ERROR;
	L.length++;
	int i;
	LinkNode<DataType> *p,*q;
	p=new LinkNode<DataType>;
	InitLinkNode(p,data);
	if(index==1)
	{
		p->next=L.head;
		L.head=p;
	}
	else 
	{   
		q=L.head;
		for(i=1;i<index-1;i++)
		{
			q=q->next;
		}
		p->next=q->next;
		q->next=p;
	}
	return ok;
}


//查找指定位置的元素

template<typename DataType>
Status getElem(LinkList<DataType> L,int index,DataType &e)
{
	if(index<1||index>L.length)
		return ERROR;
	int i;
    LinkNode<DataType> *p=L.head;
	for(i=1;i<index;i++)
    {
		p=p->next;
	}
    e=p->data;
	return ok;
}

//删除指定位置的元素

template<typename DataType>
Status deleteElem(LinkList<DataType> &L,int index)
{
	if(index<1||index>L.length)
		return ERROR;
	L.length--;
    int i;
    LinkNode<DataType> *p,*q;
	p=L.head;
	if(index==1)
	{
		L.head=p->next;
		delete(p);
	}
	else
	{
	for(i=1;i<index-1;i++)
		p=p->next;
	q=p->next;
    p->next=q->next; 
	delete(q);
	}
	return ok;
}

#endif