using System.Collections;
using UnityEngine;

public class Coroutine4 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Count());
    }

    IEnumerator Count()
    {
        Debug.Log("1");
        yield return new WaitForSeconds(1f);
        // yield return을 만나면 멈췄다가
        // 특정 조건 WaitForSeconds가 충족되면
        // 아래줄부터 다시 실행된다.
        Debug.Log("2");
        yield return new WaitForSeconds(1f);
        // yield return을 만나면 멈췄다가
        // 특정 조건 WaitForSeconds가 충족되면
        // 아래줄부터 다시 실행된다.
        Debug.Log("3");
    }
}
