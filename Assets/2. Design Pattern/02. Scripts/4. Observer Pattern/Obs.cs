using UnityEngine;

public class Obs : MonoBehaviour
{
    public void UpdateObs()
    {
        Debug.Log($"Update {gameObject.name}");
    }
}
// ������(Observer) : ���� ��ȭ�� �����ϰ� �̿� ���� �����ϴ� ��ü,
// ���� ���� Ư�� �̺�Ʈ�� ���� ��ȭ�� �ڵ����� �뺸 �޾� �����ϴ� ���
