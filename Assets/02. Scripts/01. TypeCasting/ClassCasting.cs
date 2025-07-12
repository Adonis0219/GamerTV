using System;
using UnityEngine;

public class ClassCasting : MonoBehaviour
{
    class Monster // ��� Ŭ���� (�θ� Ŭ����)
    {
        public void Grr()
        {
            Debug.Log("Grr...");
        }
    }
    
    class Orc : Monster {}      // �Ļ� Ŭ���� (�ڽ� 1)
    
    class Troll : Monster {}    // �Ļ� Ŭ���� (�ڽ� 2)

    // is, as
    
    private void Start()
    {
        
    }

    // is : ����ȯ ���� ���θ� bool ������ ��ȯ
    void IsKeyword()
    {
        Monster mon = new Monster();
        Orc orc = new Orc();

        if (orc is Monster)
        {
            mon = (Monster)orc;
            mon.Grr();
        }
    }

    // as : ����ȯ �����ϸ� ����ȯ ����, �Ұ����ϴٸ� null ��ȯ
    void AsKeyword()
    {
        Monster mon = new Monster();
        Orc orc = new Orc();
        
        mon = orc as Monster;
        // mon = (Monster)orc �� ���� ����

        if (mon != null)
        {
            mon.Grr();
        }
    }
}
