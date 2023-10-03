using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantitateManager : MonoBehaviour
{
    [SerializeField] GameObject managerPrefab;
    private void Awake()
    {
        var managers = FindObjectOfType<GameManager>();
        if (managers == null)
        {
            Instantiate(managerPrefab); 
        }
        Destroy(gameObject);
    }
    
}
