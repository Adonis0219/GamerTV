using UnityEngine;

public class Player
{
    public void Move() { Debug.Log("�÷��̾� ������"); }
}

public static class AdvancedPlayer
{
    public static void Jump(this Player player) { Debug.Log("�÷��̾� ����"); }
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

