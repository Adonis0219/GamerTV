using UnityEngine;

namespace Deco1
{
    public abstract class Decorator : DecoComponent
    {
        protected DecoComponent _decoCom;

        // Operation을 구현하지 않아도 되는 이유
        // Operation()도 이 클래스 내부에서 추상 메서드로 선언돼있다
        
        public Decorator Set(DecoComponent decoCom)
        {
            _decoCom = decoCom;
            return this;
        }
    }
}