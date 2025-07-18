using System.Collections;
using UnityEngine;

public class Coroutine9 : MonoBehaviour
{
    IEnumerator Start()
    {
        // Dictionary에 키값 1.0f에 해당하는 값이 없으니 객체 생성 후 저장
        yield return CoroutineUtil.GetWaitForSeconds(1.0f);
        Debug.Log("1");
        // Dictionary에 키값 1.0f에 해당하는 값이 있으니 캐시된 객체 반환
        yield return CoroutineUtil.GetWaitForSeconds(1.0f);
        Debug.Log("2");
        // Dictionary에 키값 1.0f에 해당하는 값이 있으니 캐시된 객체 반환
        yield return CoroutineUtil.GetWaitForSeconds(1.0f);
        Debug.Log("3");
    }
}
