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
        // ���� Update ȣ�� �ñ��� ��� �� ���� -> 1������ ��ٸ���
        yield return null;

        // ���� FixedUpdate ȣ�� �ñ��� ��� �� ����
        yield return new WaitForFixedUpdate();

        // float time��ŭ �ð��� ���� �� ù �����ӱ��� ��� �� ����
        yield return new WaitForSeconds(time);

        // float time��ŭ �ð��� ���� �� ���� �����ӱ��� ��� �� ����
        // TimeScale�� ������ ���� ����
        yield return new WaitForSecondsRealtime(time);

        // ��� ������ �۾��� �Ϸ�Ǵ� �������� ���� ������ ��� �� ����
        yield return new WaitForEndOfFrame();

        // �ش� ������ ���� �� ������ ��� �� ����
        yield return new WaitUntil(() => time > 10);
    }
}
