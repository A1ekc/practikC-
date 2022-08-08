double dist = 1000,
        Time = 0;
int firstFriendSpeed = 1,
    secondFriendSpeed = 2,
    dogSpeed = 10,
    //friend = 2,
    Count = 0;
bool directionFirstFriend = true;

while (dist > 10)
{
    if (directionFirstFriend)//friend ==1
    {
        Time = dist / (firstFriendSpeed + dogSpeed);
        directionFirstFriend = false;//friend = 2
    }
    else
    {
        Time = dist / (secondFriendSpeed + dogSpeed);
        directionFirstFriend = true;
    }
    dist -= (firstFriendSpeed + secondFriendSpeed)* Time;
    Count++;
}
Console.Write("собака пробежит " + Count + " раз");