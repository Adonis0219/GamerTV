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
        recycleAllByDefault : 한 번 사용한 Dotween을 다시 재사용할지 결정
        useSafeMode : 약간은 느리지만 실행되는 동안 실행 대상이 파괴될 경우와 같은 예외 상황을 자동으로 처리해줌
        logBehavior : 오류 메세지 기록 설정
        
         SetCapacity(Tweener 개수, Sequence 개수)
        Tweener와 Sequence의 사용할 용량을 결정
        용량이 부족할 시 자동으로 추가, 작게 설정하면 성능 이점이 있을 수 있음*/
        DOTween.Init(false, true, LogBehaviour.Verbose).SetCapacity(200, 50);
        
        Tweener tr = transform.DOMove(targetPos, 1.0f)
                        .SetLoops(3, LoopType.Restart)
                        .OnComplete(() => transform.DOScale(targetScale, 2.0f));

        tr.Play();
    }
}
