using System.Collections;
using UnityEngine;

public class Coroutine9 : MonoBehaviour
{
    IEnumerator Start()
    {
        // Dictionary�� Ű�� 1.0f�� �ش��ϴ� ���� ������ ��ü ���� �� ����
        yield return CoroutineUtil.GetWaitForSeconds(1.0f);
        Debug.Log("1");
        // Dictionary�� Ű�� 1.0f�� �ش��ϴ� ���� ������ ĳ�õ� ��ü ��ȯ
        yield return CoroutineUtil.GetWaitForSeconds(1.0f);
        Debug.Log("2");
        // Dictionary�� Ű�� 1.0f�� �ش��ϴ� ���� ������ ĳ�õ� ��ü ��ȯ
        yield return CoroutineUtil.GetWaitForSeconds(1.0f);
        Debug.Log("3");
    }
}
