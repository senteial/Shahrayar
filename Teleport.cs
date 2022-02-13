using UnityEngine;
using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
   
    public GameObject objToTP;
  //  public Transform tpLoc;

    void OnTriggerStay(Collider other)
    {
       
        if ((other.gameObject.tag == "Player"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
  
}