#include <stdio.h>

int main()
{
	int		cnt;
	int		i;
	int		chk;
	char	str[1000000];

	cnt = 0;
	chk = 1;
	i = 1;
	scanf("%[^\n]s", str);
	if ((str[0] == ' ' && str[1] == '\0') || str[0] == '\0')
	{
		printf("%d",0);
		return 0;
	}
	while (str[i] != '\0')
	{
		if (str[i + 1] == '\0')
			break;
		else if (str[i] == ' ' && chk == 1)
		{
			cnt++;
			chk = 0;
		}
		else if(str[i] != ' ' && chk == 0)
			chk = 1;
		i++;
	}
	cnt++;
	if (str[0] != ' ' && str[0] != '\0' && cnt == 0)
		cnt++;
	printf("%d", cnt);
	return 0;
}
