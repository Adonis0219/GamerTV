using System.Collections.Generic;
using UnityEngine;

public class CoroutineUtil : MonoBehaviour
{
    // 일반적으로 캐시된 객체들을 활용하여 성능 향상
    public static readonly WaitForFixedUpdate m_WaitForFixedUpdate = new WaitForFixedUpdate();
    public static readonly WaitForEndOfFrame m_WaitForEndOfFrame = new WaitForEndOfFrame();

    // 캐싱된 WaitForSeconds 객체를 저장하는 딕셔너리
    // float 값을 키로 사용하여 중복 객체 생성을 방지합니다.
    // WaitForSeconds 객체는 생성 비용이 크므로, 재사용을 통해 성능을 향상시킵니다.
    // WaitForSeconds는 float 값을 기반으로 생성되므로 너무 다양하다.
    // 따라서 Dictionary를 사용하여 캐싱합니다.
    static readonly Dictionary<float, WaitForSeconds> m_WaitForSecondsCache = new Dictionary<float, WaitForSeconds>();

    public static WaitForSeconds GetWaitForSeconds(float waitTime)
    {
        WaitForSeconds wfs;

        // 캐시에서 해당 waitTime에 대한 WaitForSeconds 객체를 찾습니다.
        if (m_WaitForSecondsCache.TryGetValue(waitTime, out wfs))
        {
            // 캐시에서 찾은 객체를 반환합니다.
            return wfs;
        }
        // 캐시에 없는 경우 새로 생성하고 캐시에 추가합니다.
        else
        {
            // WaitForSeconds 객체 생성
            wfs = new WaitForSeconds(waitTime);
            // 캐시에 추가
            m_WaitForSecondsCache.Add(waitTime, wfs);
            // 새로 생성한 객체 반환
            return wfs;
        }
    }
}
