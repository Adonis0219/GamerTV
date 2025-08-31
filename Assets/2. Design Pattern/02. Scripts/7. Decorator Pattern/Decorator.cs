using UnityEngine;

namespace Deco1
{
    public abstract class Decorator : DecoComponent
    {
        protected DecoComponent _decoCom;

        // Operation�� �������� �ʾƵ� �Ǵ� ����
        // Operation()�� �� Ŭ���� ���ο��� �߻� �޼���� ������ִ�
        
        public Decorator Set(DecoComponent decoCom)
        {
            _decoCom = decoCom;
            return this;
        }
    }
}