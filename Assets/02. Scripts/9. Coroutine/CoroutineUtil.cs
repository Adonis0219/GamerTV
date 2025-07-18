using System.Collections.Generic;
using UnityEngine;

public class CoroutineUtil : MonoBehaviour
{
    // �Ϲ������� ĳ�õ� ��ü���� Ȱ���Ͽ� ���� ���
    public static readonly WaitForFixedUpdate m_WaitForFixedUpdate = new WaitForFixedUpdate();
    public static readonly WaitForEndOfFrame m_WaitForEndOfFrame = new WaitForEndOfFrame();

    // ĳ�̵� WaitForSeconds ��ü�� �����ϴ� ��ųʸ�
    // float ���� Ű�� ����Ͽ� �ߺ� ��ü ������ �����մϴ�.
    // WaitForSeconds ��ü�� ���� ����� ũ�Ƿ�, ������ ���� ������ ����ŵ�ϴ�.
    // WaitForSeconds�� float ���� ������� �����ǹǷ� �ʹ� �پ��ϴ�.
    // ���� Dictionary�� ����Ͽ� ĳ���մϴ�.
    static readonly Dictionary<float, WaitForSeconds> m_WaitForSecondsCache = new Dictionary<float, WaitForSeconds>();

    public static WaitForSeconds GetWaitForSeconds(float waitTime)
    {
        WaitForSeconds wfs;

        // ĳ�ÿ��� �ش� waitTime�� ���� WaitForSeconds ��ü�� ã���ϴ�.
        if (m_WaitForSecondsCache.TryGetValue(waitTime, out wfs))
        {
            // ĳ�ÿ��� ã�� ��ü�� ��ȯ�մϴ�.
            return wfs;
        }
        // ĳ�ÿ� ���� ��� ���� �����ϰ� ĳ�ÿ� �߰��մϴ�.
        else
        {
            // WaitForSeconds ��ü ����
            wfs = new WaitForSeconds(waitTime);
            // ĳ�ÿ� �߰�
            m_WaitForSecondsCache.Add(waitTime, wfs);
            // ���� ������ ��ü ��ȯ
            return wfs;
        }
    }
}
