using UnityEngine;

public static class TransformExtensions
{
    public static void ResetTransform(this Transform transform)
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.identity;
        transform.localScale = Vector3.one;
    }
}


public class ExtensionTest2 : MonoBehaviour
{
    private void Start()
    {
        Transform tf = gameObject.transform;

        tf.ResetTransform();
    }
}
