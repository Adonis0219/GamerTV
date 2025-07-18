using System.Collections;
using UnityEngine;

public class Coroutine6 : MonoBehaviour
{
    float time;

    void Start()
    {
        StartCoroutine(CoroutineTest());
    }

    IEnumerator CoroutineTest()
    {
        // 다음 Update 호출 시까지 대기 후 실행 -> 1프레임 기다리기
        yield return null;

        // 다음 FixedUpdate 호출 시까지 대기 후 실행
        yield return new WaitForFixedUpdate();

        // float time만큼 시간이 지난 후 첫 프레임까지 대기 후 실행
        yield return new WaitForSeconds(time);

        // float time만큼 시간이 지난 후 다음 프레임까지 대기 후 실행
        // TimeScale의 영향을 받지 않음
        yield return new WaitForSecondsRealtime(time);

        // 모든 렌더링 작업이 완료되는 프레임이 끝날 때까지 대기 후 실행
        yield return new WaitForEndOfFrame();

        // 해당 조건이 참이 될 때까지 대기 후 실행
        yield return new WaitUntil(() => time > 10);
    }
}
