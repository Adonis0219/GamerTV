using System.Collections;
using UnityEngine;

public class Coroutine8 : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return null;
    }

    private IEnumerator OnCollisionEnter(Collision collision)   // ���� �浹
    {
        yield return null;
    }
    
    private IEnumerator OnMouseDown()   // �Է�
    {
        yield return null;
    }

    private IEnumerator OnBecameInvisible() // ������
    {
        yield return null;
    }
}
