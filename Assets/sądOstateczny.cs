using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sądOstateczny : MonoBehaviour
{
    public Animator animPrzycisk;
    public Animator animLampkaWina;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("trigger"))
        {
            animPrzycisk.SetTrigger("ButtonTrigger");
            animLampkaWina.SetTrigger("New Trigger");
        }
    }
}
