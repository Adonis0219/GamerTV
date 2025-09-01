using UnityEngine;

public abstract class Worker : MonoBehaviour
{
    // 템플릿 메서드
    // 알고리즘의 각 단계를 나타내는 여러 메서드를 순서대로 호출
    void PrepareForWork()
    {
        WakeUp();
        Wash();
        
        GetDressed();   // 구체적인 내용은 하위 클래스에 위임
        
        if (ShouldEatBreakfast()) EatBreakfast();   // Hook

        Commute();      // 구체적인 내용은 하위 클래스에 위임
    }
    
    // 공통 로직 -> 일반 메서드
    private void WakeUp() { Debug.Log("기상"); }
    private void Wash() { Debug.Log("세안"); }
    
    // 하위 클래스에서 반드시 구현해야 하는 부분 (추상 메서드)
    protected abstract void GetDressed();
    protected abstract void Commute();

    // 하위 클래스에서 선택적으로 바꿀 수 있는 부분 (훅(가상) 메서드)
    protected virtual bool ShouldEatBreakfast() => true;
    protected virtual void EatBreakfast() { Debug.Log("아침밥 차리기"); }
}
