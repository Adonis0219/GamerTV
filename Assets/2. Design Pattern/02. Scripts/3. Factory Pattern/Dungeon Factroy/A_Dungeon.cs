using Dungeon;
using UnityEngine;

public class A_Dungeon : DungeonFactory
{
    public BaseOrc a_Orc;
    public BaseGoblin a_Goblin;

    public override BaseGoblin CreateGoblin()
    {
        a_Goblin= new A_Goblin(10, 20, 60);
        return a_Goblin;
    }

    public override BaseOrc CreateOrc()
    {
        a_Orc = new A_Orc(20, 10, 50);
        return a_Orc;
    }
}
