using Dungeon;
using UnityEngine;
using UnityEngine.UI;

public class DungeonTest : MonoBehaviour
{
    public DungeonFactory a_Dungeon;
    public DungeonFactory s_Dungeon;

    public Button a_Bt;
    public Button s_Bt;

    private void Start()
    {
        a_Bt.onClick.AddListener(() =>
        {
            BaseOrc orc = a_Dungeon.CreateOrc();
            orc.Attack(orc.atk);
            orc.Aggression(orc.def);

            BaseGoblin goblin = a_Dungeon.CreateGoblin();
            goblin.Attack(goblin.atk);
            goblin.Dodge(goblin.dex);
        });

        s_Bt.onClick.AddListener(() =>
        {
            BaseOrc orc = s_Dungeon.CreateOrc();
            orc.Attack(orc.atk);
            orc.Aggression(orc.def);

            BaseGoblin goblin = s_Dungeon.CreateGoblin();
            goblin.Attack(goblin.atk);
            goblin.Dodge(goblin.dex);
        });
    }
}
