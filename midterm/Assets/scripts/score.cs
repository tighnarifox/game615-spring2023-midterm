using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{   public TMP_Text scoreText;
    [SerializeField] GameObject beer;
    [SerializeField] GameObject salad;
    [SerializeField] GameObject spawnpoint;
    
    
    // Start is called before the first frame update
    public void Start()
    {
        GameObject go = GameObject.Find("scoreText");
        if (go) {
            Debug.Log(go.name);
        } else {
            Debug.Log("No game object called scoreText found");
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "Start by finding your way home. Press space, WASD and go to your friends for salad and beer to get energy to find your way back.";
    }
    }

void Update()
    {
        if (Input.GetKeyDown("space"))
        {
    
            scoreText.text = "you dropped your lyre king";
        }

        if (Input.GetKeyDown("w"))
        {
    
            scoreText.text = "watch where you're heading";
        }
          if (Input.GetKeyDown("a"))
        {
    
            scoreText.text = "go find xinyan for beer";
        }

          if (Input.GetKeyDown("s"))
        {
    
            scoreText.text = "go find albedo for salad";
        }

          if (Input.GetKeyDown("d"))
        {
    
            scoreText.text = "you aren't home yet? it's getting late";
        }
        
    }
       public void OnTriggerEnter(Collider other)
     {
        if (other.CompareTag("xinyan"))
        {
            Destroy(other.gameObject);
            Instantiate(beer,spawnpoint.transform.position, Quaternion.identity);


        }
    
       if (other.CompareTag("albedo"))
       {    
            Destroy(other.gameObject);
            Instantiate(salad,spawnpoint.transform.position, Quaternion.identity);
            
       }

       if (other.CompareTag("house"))
         {  
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         
         }
        
     }

}


 