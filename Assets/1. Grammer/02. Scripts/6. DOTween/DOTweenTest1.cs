using System;
using DG.Tweening;
using UnityEngine;

public class DOTweenTest1 : MonoBehaviour
{
    private Vector3 targetPos = new Vector3(0, 5, 0);
    private Vector3 targetScale = new Vector3(2, 2, 2);

    private Sequence sequence;
    
    private void Start()
    {
        /* Init
        recycleAllByDefault : �� �� ����� Dotween�� �ٽ� �������� ����
        useSafeMode : �ణ�� �������� ����Ǵ� ���� ���� ����� �ı��� ���� ���� ���� ��Ȳ�� �ڵ����� ó������
        logBehavior : ���� �޼��� ��� ����
        
         SetCapacity(Tweener ����, Sequence ����)
        Tweener�� Sequence�� ����� �뷮�� ����
        �뷮�� ������ �� �ڵ����� �߰�, �۰� �����ϸ� ���� ������ ���� �� ����*/
        DOTween.Init(false, true, LogBehaviour.Verbose).SetCapacity(200, 50);
        
        Tweener tr = transform.DOMove(targetPos, 1.0f)
                        .SetLoops(3, LoopType.Restart)
                        .OnComplete(() => transform.DOScale(targetScale, 2.0f));

        tr.Play();
    }
}
