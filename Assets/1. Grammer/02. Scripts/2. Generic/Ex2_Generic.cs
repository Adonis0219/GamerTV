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

        string[] sourceArr2 = { "하나", "둘", "셋", "넷" };
        string[] targetArr2 = new string[sourceArr2.Length];
        // int형은 값형식이기에 문제없이 작동하지만
        // string은 참조형식이라서 오류가 발생한다
        Copy<string>(sourceArr2, targetArr2);
    }
}
