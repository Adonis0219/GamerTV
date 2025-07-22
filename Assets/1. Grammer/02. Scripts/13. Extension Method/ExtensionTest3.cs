using System.Collections;
using UnityEngine;

public static class GameObjectExtensions
{
    // Recursive : Àç±ÍÀû
    public static void SetActiveRecursive(this GameObject gameObject, bool isActive)
    { 
        gameObject.SetActive(isActive);

        foreach (Transform child in gameObject.transform)
        {
            child.gameObject.SetActiveRecursive(isActive);
        }
    }
}


public class ExtensionTest3 : MonoBehaviour
{
    public GameObject go;

    IEnumerator Start()
    {
        while (true)
        {
            go.SetActiveRecursive(false);
            yield return new WaitForSeconds(2.0f);
            go.SetActiveRecursive(true);
            yield return new WaitForSeconds(2.0f);
        }   
    }
}
