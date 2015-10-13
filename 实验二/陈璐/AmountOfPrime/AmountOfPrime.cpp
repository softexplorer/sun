#include "stdio.h"
#include "math.h"

//判断是否为素数
bool IsPrime( _int64 digit )
{
	_int64 temp = floor( sqrt( digit ) );   //临时变量用于存储输入数字的平方根的整数
	if( digit == 2 )
		return true;
	for( _int64 i = 2 ; i <= temp ;i ++ )
		if( digit % i == 0 )
			return false;
	return true;
}

//计算素数个数
long AmountOfPrime( _int64 min , _int64 max )
{
	_int64 amount = 0;    //记录素数个数
	for( _int64 i = min ; i < max ; i ++ )
		if( IsPrime( i ) == true )
			amount ++;
	return amount;
}

int main()
{
	_int64 min , max;  //输入的最小和最大数
	puts( "105032013097 陈璐 素数计数器" );
	while( 1 )
	{
		puts( "请输入要求的素数个数的最大数和最小数:" );
		while( 1 )
		{
			printf( "最小数:" );
			scanf( "%I64d" , &min );
			if( min >= 0 )
				break;
			else
				printf( "输入非法，请重新输入\n" );
		}
	    while( 1 )
		{
			printf( "最大数:" );
		    scanf( "%I64d" , &max );
		    if( max >= 0 )
				break;
		    else
				printf( "输入非法，请重新输入\n" );
		}
		printf( "有%d个素数\n" , AmountOfPrime( min , max ) ); 
	}
	return 0;
}