using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lyrescript : MonoBehaviour
{
    [SerializeField] GameObject lyre;
    [SerializeField] GameObject spawnpoint;
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("pressed");
            Instantiate(lyre, spawnpoint.transform.position, Quaternion.identity);
        }
        
    }
    
}
