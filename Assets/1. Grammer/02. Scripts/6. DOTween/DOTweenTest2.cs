using UnityEngine;
using DG.Tweening;

public class DOTweenTest2 : MonoBehaviour
{
    private Sequence sequence;
    
    void Start()
    {
        sequence = DOTween.Sequence();
        
        // .Append : 트윈 마지막에 추가
        sequence.Append(transform.DOMove(new Vector3(0, 5, 0), 2.0f));
        // .Join : 앞에 추가된 트윈과 동시 시작
        sequence.Join(transform.DORotate(new Vector3(0, -180, 0), 2.0f));
        sequence.Append(transform.DORotate(new Vector3(0, 360, 0), 2.0f));
        // .Insert : 일정 시간에 시작
        sequence.Insert(4.0f, transform.DOScale(new Vector3(2, 2, 2), 1.0f));
        // .Prepend : 맨 처음에 추가
        sequence.Prepend(transform.DOScale(new Vector3(.5f, .5f, .5f), 2.0f));
    }
}
