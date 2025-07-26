using Factory;
using UnityEngine;
using UnityEngine.UI;

public class FactoryTest1 : MonoBehaviour
{
    [SerializeField] BaseFactory slimeFac;
    [SerializeField] BaseFactory turtleFac;

    [SerializeField] Button bt1;
    [SerializeField] Button bt2;

    void Start()
    {
        bt1.onClick.AddListener(() =>
        {
            BaseMonster slime = slimeFac.CreateMonster();
            slime.Attack();
        });
        bt2.onClick.AddListener(() =>
        {
            BaseMonster turtle = turtleFac.CreateMonster();
            turtle.Attack();
        });
    }
}
