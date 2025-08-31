using UnityEngine;

namespace Deco0
{
    public abstract class Decorator : IComponent
    {
        public IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        // 인터페이스로 상속받은 메서드(규칙)를 나 대신 나를 상속받은 하위 클래스(구상 클래스)가
        // 이 메서드를 반드시 구현(필수)하게 함
        // 추상 메서드로 재선언 (규칙 -> 필수)
        public abstract void Operation();
    }
}
