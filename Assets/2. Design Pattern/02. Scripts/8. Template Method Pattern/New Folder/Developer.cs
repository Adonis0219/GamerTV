using UnityEngine;

public class Developer : Worker
{
    protected override void GetDressed()
    {
        Debug.Log("���� �ְ� �Ա�");;
    }

    protected override void Commute()
    {
        Debug.Log("�����ŷ� ���");
    }
}
