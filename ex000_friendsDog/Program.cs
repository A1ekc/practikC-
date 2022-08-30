double dist = 1000;
double time = 0;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int dogSpeed = 10;
int Friend = 2;
int count = 0;

while (dist > 10)
{
    if (Friend==1)
    {
        time = dist / (FirstFriendSpeed + dogSpeed);
        Friend = 2;
    }
    else
    {
        time = dist /(SecondFriendSpeed + dogSpeed);
        Friend = 1;
    }
    dist -= (FirstFriendSpeed + SecondFriendSpeed) * time;
    count++;
}
Console.Write("Собака пробежит " + count + " раз");
