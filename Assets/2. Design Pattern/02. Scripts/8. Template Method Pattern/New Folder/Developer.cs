using UnityEngine;

public class Developer : Worker
{
    protected override void GetDressed()
    {
        Debug.Log("개성 있게 입기");;
    }

    protected override void Commute()
    {
        Debug.Log("자전거로 출근");
    }
}
