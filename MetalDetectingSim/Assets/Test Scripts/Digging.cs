using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Digging : MonoBehaviour
{
    public Camera cam;
    public float range = 5f;
    public GameObject mound;
    public GameObject silverMound;
    public GameObject goldMound;
    public GameObject copperMound;
    private Vector3 moundPos;
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
                moundPos = hit.transform.position;
                moundPos.y = 0.043f;
                if (Input.GetMouseButtonDown(0))
                {
                    if (hit.transform.name.Contains("gold"))
                    {
                        Instantiate(goldMound, moundPos, transform.rotation * Quaternion.Euler(-90f, 0f, 0f));
                    }
                    if (hit.transform.name.Contains("silver"))
                    {
                        Instantiate(silverMound, moundPos, transform.rotation * Quaternion.Euler(-90f, 0f, 0f));
                    }
                    if (hit.transform.name.Contains("copper"))
                    {
                        Instantiate(copperMound, moundPos, transform.rotation * Quaternion.Euler(-90f, 0f, 0f));
                    }
                    Destroy(hit.transform.gameObject);
                }
            }
            if (hit.transform.tag == "Pickup")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Picked Up");
                    Destroy(hit.transform.gameObject);
                    Instantiate(mound, hit.transform.position, transform.rotation * Quaternion.Euler(-90f, 0f, 0f));
                }
            }
            else if (hit.transform.tag == "Ground")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Hit Ground");
                    moundPos = hit.point;
                    moundPos.y = 0.043f;
                    Instantiate(mound, moundPos, transform.rotation * Quaternion.Euler(-90f, 0f, 0f));
                }
            }
        }
    }
}
