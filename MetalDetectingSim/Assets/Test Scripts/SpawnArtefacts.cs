using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArtefacts : MonoBehaviour
{
    public int num = 12;
    public GameObject cube;
    public List<string> metal = new List<string>();
    public List<string> shape = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < num; i++)
        {
            Debug.Log("HERE");
            var newObject = (GameObject) Instantiate(cube, new Vector3(1, 0, 1+i*2), Quaternion.identity);
            newObject.name = metal[Random.Range(0, metal.Count)] + ' ' + shape[Random.Range(0, shape.Count)];
        }
    }

}
