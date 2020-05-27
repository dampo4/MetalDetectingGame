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
    public Canvas inventory;
    private Vector3 moundPos;
    public List<Item> items;
    public List<Item> possibleItems;
    // Start is called before the first frame update
    void Start()
    {
        possibleItems = items;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) & items.Count != 0)
        {
            Debug.Log("clicked");
            RaycastHit[] hits;
            hits = Physics.RaycastAll(cam.transform.position, cam.transform.forward, range);
            RaycastHit artefact = new RaycastHit();
            RaycastHit ground = new RaycastHit();
            RaycastHit pickup = new RaycastHit();
            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].transform.gameObject.tag == "Artefact")
                {
                    artefact = hits[i];
                }
                if (hits[i].transform.gameObject.tag == "Ground")
                {
                    ground = hits[i];
                }
                if (hits[i].transform.gameObject.tag == "Pickup")
                {
                    pickup = hits[i];
                }
            }
            if (artefact.collider != null && ground.collider != null)
            {
                moundPos = ground.point;
                Debug.Log("digging");
                if (artefact.transform.name.Contains("gold"))
                {
                    Debug.Log("gold");
                    Instantiate(goldMound, moundPos, transform.rotation * Quaternion.Euler(-90f, 0f, 0f));
                }
                if (artefact.transform.name.Contains("silver"))
                {
                    Instantiate(silverMound, moundPos, transform.rotation * Quaternion.Euler(-90f, 0f, 0f));
                }
                if (artefact.transform.name.Contains("iron"))
                {
                    Instantiate(silverMound, moundPos, transform.rotation * Quaternion.Euler(-90f, 0f, 0f));
                }
                if (artefact.transform.name.Contains("copper"))
                {
                    Instantiate(copperMound, moundPos, transform.rotation * Quaternion.Euler(-90f, 0f, 0f));
                }
                Destroy(artefact.transform.gameObject);
            }
            if (pickup.collider != null)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Picked Up");
                   /* foreach (Item item in items)
                    {
                        possibleItems.Add(item);
                        /*if (item.name.Contains("Gold Coin") && pickup.transform.name.Contains("Gold"))
                        {
                            possibleItems.Add(item);
                        }
                        if (item.name.Contains("Silver Coin") && pickup.transform.name.Contains("Silver"))
                        {
                            possibleItems.Add(item);
                        }
                        if (item.name.Contains("Copper Coin") && pickup.transform.name.Contains("Copper"))
                        {
                            possibleItems.Add(item);
                        }
                    }*/
                    int toRemove = Random.Range(0, possibleItems.Count);
                    //Debug.Log(possibleItems[0].name);
                    inventory.GetComponent<PlayerInventory>().UpdateUI(possibleItems[toRemove]);
                    possibleItems.Remove(possibleItems[toRemove]);
                    //possibleItems.Clear();
                    Destroy(pickup.transform.gameObject);
                    //Instantiate(mound, hit.transform.position, transform.rotation * Quaternion.Euler(-90f, 0f, 0f));
                }
            }
        }
        /*RaycastHit[] hits;
        hits = Physics.RaycastAll(cam.transform.position, cam.transform.forward, range);
        //RaycastHit artefact;
        //RaycastHit ground;
        for (int i = 0; i < hits.Length; i++)
        {
            if(hits[i].transform.gameObject.tag == "Artefact")
            {
                artefact = hits[i];
                moundPos = ;
                moundPos.y = 0.043f;
                if (Input.GetMouseButtonDown(0))
                {

                    Debug.Log("digging");
                    if (artefact.transform.name.Contains("gold"))
                    {
                        Instantiate(goldMound, moundPos, transform.rotation * Quaternion.Euler(-90f, 0f, 0f));
                    }
                    if (artefact.transform.name.Contains("silver"))
                    {
                        Instantiate(silverMound, moundPos, transform.rotation * Quaternion.Euler(-90f, 0f, 0f));
                    }
                    if (artefact.transform.name.Contains("copper"))
                    {
                        Instantiate(copperMound, moundPos, transform.rotation * Quaternion.Euler(-90f, 0f, 0f));
                    }
                    Destroy(artefact.transform.gameObject);
                }
            }
            if (hits[i].transform.gameObject.tag == "Ground")
            {
                ground = hits[i];
            }
        }
        if (hits[0].)
            {
                moundPos = hit.transform.position;
                moundPos.y = 0.043f;
                if (Input.GetMouseButtonDown(0))
                {
                    
                    Debug.Log("digging");
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
                    foreach(Item item in items)
                    {
                        if (item.name.Contains("Gold Coin") && hit.transform.name.Contains("Gold"))
                        {
                            possibleItems.Add(item);
                        }
                        if (item.name.Contains("Silver Coin") && hit.transform.name.Contains("Silver"))
                        {
                            possibleItems.Add(item);
                        }
                        if (item.name.Contains("Copper Coin") && hit.transform.name.Contains("Copper"))
                        {
                            possibleItems.Add(item);
                        }
                    }
                    inventory.GetComponent<PlayerInventory>().UpdateUI(possibleItems[0]);
                    possibleItems.Clear();
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
        }*/
    }
    }

