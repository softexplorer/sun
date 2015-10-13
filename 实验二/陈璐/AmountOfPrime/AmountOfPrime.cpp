#include "stdio.h"
#include "math.h"

//�ж��Ƿ�Ϊ����
bool IsPrime( _int64 digit )
{
	_int64 temp = floor( sqrt( digit ) );   //��ʱ�������ڴ洢�������ֵ�ƽ����������
	if( digit == 2 )
		return true;
	for( _int64 i = 2 ; i <= temp ;i ++ )
		if( digit % i == 0 )
			return false;
	return true;
}

//������������
long AmountOfPrime( _int64 min , _int64 max )
{
	_int64 amount = 0;    //��¼��������
	for( _int64 i = min ; i < max ; i ++ )
		if( IsPrime( i ) == true )
			amount ++;
	return amount;
}

int main()
{
	_int64 min , max;  //�������С�������
	puts( "105032013097 ��� ����������" );
	while( 1 )
	{
		puts( "������Ҫ����������������������С��:" );
		while( 1 )
		{
			printf( "��С��:" );
			scanf( "%I64d" , &min );
			if( min >= 0 )
				break;
			else
				printf( "����Ƿ�������������\n" );
		}
	    while( 1 )
		{
			printf( "�����:" );
		    scanf( "%I64d" , &max );
		    if( max >= 0 )
				break;
		    else
				printf( "����Ƿ�������������\n" );
		}
		printf( "��%d������\n" , AmountOfPrime( min , max ) ); 
	}
	return 0;
}