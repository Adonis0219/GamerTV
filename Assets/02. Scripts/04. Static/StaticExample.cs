using System;
using UnityEditor.ShaderGraph.Legacy;
using UnityEngine;

public class StaticExample : MonoBehaviour
{
    // static
    // ������ �ǹ̷δ� ���� �������� ����
    // ���α׷��ֿ����� Ŭ���� ��ü�� �Ҽӵǵ��� ��, �޸𸮿� ����
    // -> �ʵ峪 �޼ҵ尡 Ŭ������ �ν��Ͻ��� �ƴ� Ŭ���� ��ü�� �ҼӵǷη� ��

    class Monster
    {
        public static int score = 0;

        public void Dead()
        {
            // ���Ͱ� ������ ���ھ ������Ű��
            score++;
        }
    }

    public void Start()
    {
        // new Ű����� �����ڸ� �̿��Ͽ� �ν��Ͻ� ����
        // �ν��Ͻ��� �ּ� ����(����) = �ν��Ͻ�(��)
        Monster m1 = new Monster();
        Monster m2 = new Monster();
        
        m1.Dead();
        m2.Dead();

        Debug.Log(Monster.score);   // 2
    }

    public void Test()
    {
        // m1�� �ν��Ͻ��� ���ÿ� ������ֱ� ������
        // start �Լ��� ������ �������� -> ���� ���� �Ұ���
        //m1.Dead();
        // ����ƽ ������ ���� ����Ǳ� ������ ������� �ʰ�
        // ��𼭳� Ŭ������ ���� ���� ����
        int num = Monster.score;
    }
}
