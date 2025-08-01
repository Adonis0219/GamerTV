using UnityEngine;

public class AttributeTest2 : MonoBehaviour
{
    public Rigidbody rb;
    public BoxCollider bc;
    public AudioSource audi;
    
    private void Start()
    {
        Transform tr1 = Utils.FindChild("Target1", transform);
        rb = tr1.GetComponent<Rigidbody>();
        bc = tr1.GetComponent<BoxCollider>();

        Transform tr2 = Utils.FindChild("Target2", transform);
        audi = tr2.GetComponent<AudioSource>();
    }
}
