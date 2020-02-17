using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorReading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (other.gameObject.tag == "Artefact")
        {
            if (other.gameObject.name.Contains("gold"))
            {
                Debug.Log("70");
            }
        }
    }
}
