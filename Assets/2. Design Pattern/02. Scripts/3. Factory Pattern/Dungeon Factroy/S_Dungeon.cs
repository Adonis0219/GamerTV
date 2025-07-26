using Dungeon;
using UnityEngine;

public class S_Dungeon : DungeonFactory
{
    public BaseOrc s_Orc;
    public BaseGoblin s_Goblin;

    public override BaseGoblin CreateGoblin()
    {
        s_Goblin = new S_Goblin(20, 40, 80);
        return s_Goblin;
    }

    public override BaseOrc CreateOrc()
    {
        s_Orc = new S_Orc(40, 20, 100);
        return s_Orc;
    }
}
