using UnityEngine;

public class Ex1_Generic : MonoBehaviour
{
    public void Copy(int[] source, int[] target)
    {
        for (int i = 0; i < source.Length; i++)
        {
            target[i] = source[i];
        }
    }
    
    // �޼ҵ�(�Լ�) �����ε�
    public void Copy(float[] source, float[] target)
    {
        for (int i = 0; i < source.Length; i++)
        {
            target[i] = source[i];
        }
    }
    
    public void Copy(string[] source, string[] target)
    {
        for (int i = 0; i < source.Length; i++)
        {
            target[i] = source[i];
        }
    }
    
    public void Copy(object[] source, object[] target)
    {
        for (int i = 0; i < source.Length; i++)
        {
            target[i] = source[i];
        }
    }

    // T : ���� �Ű�����
    public void Copy<T>(T[] source, T[] target)
    {
        for (int i = 0; i < source.Length; i++)
        {
            target[i] = source[i];
        }
    }
    
    // ���׸� (�Ϲ�ȭ) -> Ư���� ���信�� ����� ������ ã�� ���� ��
    
    // ��, �����, ��� >> ����
}
