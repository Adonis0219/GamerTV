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

        // �������̽��� ��ӹ��� �޼���(��Ģ)�� �� ��� ���� ��ӹ��� ���� Ŭ����(���� Ŭ����)��
        // �� �޼��带 �ݵ�� ����(�ʼ�)�ϰ� ��
        // �߻� �޼���� �缱�� (��Ģ -> �ʼ�)
        public abstract void Operation();
    }
}
