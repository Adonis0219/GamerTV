using System.Collections;
using UnityEngine;

public class Coroutine8 : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return null;
    }

    private IEnumerator OnCollisionEnter(Collision collision)   // 물리 충돌
    {
        yield return null;
    }
    
    private IEnumerator OnMouseDown()   // 입력
    {
        yield return null;
    }

    private IEnumerator OnBecameInvisible() // 랜더링
    {
        yield return null;
    }
}
