using UnityEngine;

public abstract class Worker : MonoBehaviour
{
    // ���ø� �޼���
    // �˰����� �� �ܰ踦 ��Ÿ���� ���� �޼��带 ������� ȣ��
    void PrepareForWork()
    {
        WakeUp();
        Wash();
        
        GetDressed();   // ��ü���� ������ ���� Ŭ������ ����
        
        if (ShouldEatBreakfast()) EatBreakfast();   // Hook

        Commute();      // ��ü���� ������ ���� Ŭ������ ����
    }
    
    // ���� ���� -> �Ϲ� �޼���
    private void WakeUp() { Debug.Log("���"); }
    private void Wash() { Debug.Log("����"); }
    
    // ���� Ŭ�������� �ݵ�� �����ؾ� �ϴ� �κ� (�߻� �޼���)
    protected abstract void GetDressed();
    protected abstract void Commute();

    // ���� Ŭ�������� ���������� �ٲ� �� �ִ� �κ� (��(����) �޼���)
    protected virtual bool ShouldEatBreakfast() => true;
    protected virtual void EatBreakfast() { Debug.Log("��ħ�� ������"); }
}
