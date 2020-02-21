using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Digging : MonoBehaviour
{
    public Camera cam;
    public float range = 5f;
    public GameObject mound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            //Debug.Log(hit.transform.name);
            //Debug.DrawRay(cam.transform.position, cam.transform.forward * range,Color.red);
            if (hit.transform.tag == "Artefact")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Dug");
                    Vector3 moundPos = hit.transform.position;
                    moundPos.y = 0.043f;
                    Instantiate(mound, moundPos, transform.rotation * Quaternion.Euler(-90f, 0f, 0f));
                }
            }
        }
    }
}
