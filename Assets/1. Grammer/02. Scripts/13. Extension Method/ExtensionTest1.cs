using UnityEngine;

// 확장 메서드
// 기존에는 클래스 기능을 확장하기 위해서는 상속을 이용
public class ExtensionTest1 : MonoBehaviour 
{ 
    public class Player
    {
        public void Move() { Debug.Log("플레이어 움직임"); }
    }

    public class AdvancedPlayer : Player
    {
        public void Jump() { Debug.Log("플레이어 점프"); }
    }

    private void Start()
    {
        // 기존 메서드는 Player 클래스를 사용
        Player p = new Player();
        p.Move();

        // 새로운 기능인 Jump를 사용하려면 AdvancedPlayer로 코드 변경이 필요
        AdvancedPlayer p2 = new AdvancedPlayer();
        p2.Move();
        p2.Jump();
    }
}
