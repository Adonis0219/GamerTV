using UnityEngine;

public class Designer : Worker
{
    protected override void GetDressed()
    {
        Debug.Log("üũ ���� �Ա�");
    }

    protected override void Commute()
    {
        Debug.Log("����ö�� ���");
    }
    
    protected override void EatBreakfast()
    {
        base.EatBreakfast();
        
        Debug.Log("������ �Ա�");
    }
}
