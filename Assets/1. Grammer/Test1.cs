using Unity.VisualScripting;
using UnityEngine;

public static class TransformExtension
{
    public static void ResetTransform(this Transform transform, int a)
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.identity;
        transform.localScale = Vector3.one;
    }
}

public class Test1 : MonoBehaviour
{
    public GameObject go;

    private void Start()
    {
        go.transform.ResetTransform(1);
    }
}