#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>

int main()
{
	int		i;
	int		j;
	int		cnt;
	int		tmp;
	int		order;
	int		number;
	int*	array;
	int*	result;
	char*	str;

	
	i = 0;
	cnt = 0;
	tmp = 0;
	str = (char *)malloc(sizeof(char) * 10);
	scanf("%d", &number);
	array = (int *)malloc(sizeof(int) * number);
	result = (int *)malloc(sizeof(int) * number);
	while (i < number)
	{
		j = 0;
		order = 0;
		scanf("%s", str);
		while (j < 9)
		{
			order += str[j];
			j++;
		}
		switch (order)
		{
			if (cnt < 0)
			{
				write(2, "ERROR : Count number is minus\n", 31);
				return (0);
			}
			case 448 :
			{
				// this is push
				scanf("%d", &array[cnt]);
				cnt++;
				break;
			}
			case 335 :
			{
				// this is pop
				if(cnt == 0)
				{
					result[tmp] = -1;
					break;
				}
				cnt--;
				result[tmp] = array[cnt];
				tmp++;
				break;
			}
			case 443 :
			{
				// this is size
				result[tmp] = cnt;
				tmp++;
				break;
			}
			case 559 :
			{
				// this is empty
				if (cnt == 0)
					result[tmp] = 1;
				else if (cnt < 0)
				{
					write(2, "ERROR : Count number is minus\n", 31);
					return (0);
				}
				else
					result[tmp] = 0;
				tmp++;
				break;
			}
			case 339 :
			{
				// this is top
				if (cnt == 0)
				{
					result[tmp] = -1;
					break;
				}
				result[tmp] = array[cnt - 1];
				tmp++;
				break;
			}
		}
		i++;
	}
	i = 0;
	while (i <= tmp)
	{
		printf("%d\n", result[i]);
		i++;
	}
	return (0);
}
