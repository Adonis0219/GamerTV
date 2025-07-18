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
    
    // 메소드(함수) 오버로드
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

    // T : 형식 매개변수
    public void Copy<T>(T[] source, T[] target)
    {
        for (int i = 0; i < source.Length; i++)
        {
            target[i] = source[i];
        }
    }
    
    // 제네릭 (일반화) -> 특수한 개념에서 공통된 개념을 찾아 묶는 것
    
    // 고래, 고양이, 사람 >> 동물
}
