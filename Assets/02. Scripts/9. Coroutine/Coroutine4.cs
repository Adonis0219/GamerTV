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
        // yield return�� ������ ����ٰ�
        // Ư�� ���� WaitForSeconds�� �����Ǹ�
        // �Ʒ��ٺ��� �ٽ� ����ȴ�.
        Debug.Log("2");
        yield return new WaitForSeconds(1f);
        // yield return�� ������ ����ٰ�
        // Ư�� ���� WaitForSeconds�� �����Ǹ�
        // �Ʒ��ٺ��� �ٽ� ����ȴ�.
        Debug.Log("3");
    }
}
