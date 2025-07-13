using UnityEngine;
using DG.Tweening;

public class DOTweenTest2 : MonoBehaviour
{
    private Sequence sequence;
    
    void Start()
    {
        sequence = DOTween.Sequence();
        
        // .Append : Ʈ�� �������� �߰�
        sequence.Append(transform.DOMove(new Vector3(0, 5, 0), 2.0f));
        // .Join : �տ� �߰��� Ʈ���� ���� ����
        sequence.Join(transform.DORotate(new Vector3(0, -180, 0), 2.0f));
        sequence.Append(transform.DORotate(new Vector3(0, 360, 0), 2.0f));
        // .Insert : ���� �ð��� ����
        sequence.Insert(4.0f, transform.DOScale(new Vector3(2, 2, 2), 1.0f));
        // .Prepend : �� ó���� �߰�
        sequence.Prepend(transform.DOScale(new Vector3(.5f, .5f, .5f), 2.0f));
    }
}
