using System;
using UnityEngine;

// 서브젝트(Subject) : 상태변화를 관리하고 옵저버들에게 알리는 대상
public class Subject : MonoBehaviour
{
    public Action action;
}
