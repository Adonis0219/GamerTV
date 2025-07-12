using UnityEngine;

public class Ex2_Generic : MonoBehaviour
{
    public void Copy(int[] source, int[] target)
    {
        for (int i = 0; i < source.Length; i++)
        {
            target[i] = source[i];
        }
    }
    
    public void Copy<T>(T[] source, T[] target) // where T : struct
    {
        for (int i = 0; i < source.Length; i++)
        {
            target[i] = source[i];
        }
    }
    
    void Start()
    {
        int[] sourceArr = { 1, 2, 3, 4, 5 };
        int[] targetArr = new int[sourceArr.Length];
        Copy(sourceArr, targetArr);
        Copy<int>(sourceArr, targetArr);

        string[] sourceArr2 = { "�ϳ�", "��", "��", "��" };
        string[] targetArr2 = new string[sourceArr2.Length];
        // int���� �������̱⿡ �������� �۵�������
        // string�� ���������̶� ������ �߻��Ѵ�
        Copy<string>(sourceArr2, targetArr2);
    }
}
