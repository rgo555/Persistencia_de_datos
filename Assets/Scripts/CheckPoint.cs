using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    CheckPoint_Manager cpManager;

    void Awake()
    {
        cpManager = GameObject.Find("CheckPoint_Manager").GetComponent<CheckPoint_Manager>();
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        cpManager.CheckPointData(new Vector3(transform.position.x, transform.position.y, transform.position.z));
        cpManager.LoadDataCP();
    }
}
