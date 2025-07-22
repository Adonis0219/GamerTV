using UnityEngine;

public class Player
{
    public void Move() { Debug.Log("플레이어 움직임"); }
}

public static class AdvancedPlayer
{
    public static void Jump(this Player player) { Debug.Log("플레이어 점프"); }
}

public class ExtensionTest1_1 : MonoBehaviour 
{
    private void Start()
    {
        Player p = new Player();
        p.Move();
        p.Jump();
    }
}

