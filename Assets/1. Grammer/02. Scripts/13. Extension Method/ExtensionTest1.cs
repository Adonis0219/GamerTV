using UnityEngine;

// Ȯ�� �޼���
// �������� Ŭ���� ����� Ȯ���ϱ� ���ؼ��� ����� �̿�
public class ExtensionTest1 : MonoBehaviour 
{ 
    public class Player
    {
        public void Move() { Debug.Log("�÷��̾� ������"); }
    }

    public class AdvancedPlayer : Player
    {
        public void Jump() { Debug.Log("�÷��̾� ����"); }
    }

    private void Start()
    {
        // ���� �޼���� Player Ŭ������ ���
        Player p = new Player();
        p.Move();

        // ���ο� ����� Jump�� ����Ϸ��� AdvancedPlayer�� �ڵ� ������ �ʿ�
        AdvancedPlayer p2 = new AdvancedPlayer();
        p2.Move();
        p2.Jump();
    }
}
