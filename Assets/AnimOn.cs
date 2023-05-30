using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimOn : MonoBehaviour
{
    public Animator animator;
    public ConstantForce force;
    public Vector3 WiktorZapotoczny;
    public Rigidbody TajemniczaMonika;
    // Start is called before the first frame update
    void Start()
    {
        WiktorZapotoczny = new Vector3(0.0f, 0.0f, 9999);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("trigger"))
        {
            TajemniczaMonika.isKinematic = false;
            force.relativeForce = WiktorZapotoczny;
            animator.SetTrigger("ButtonTrigger");
        }
    }
}
