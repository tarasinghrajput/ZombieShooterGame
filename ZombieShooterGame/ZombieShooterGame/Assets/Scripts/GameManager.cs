using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _Instance = null;
    public static GameManager Instance
    { get; private set; }

    public Health healthScript;

    private void Awake() 
    {
       DontDestroyOnLoad(gameObject);
       health = GetComponent<Health>();
       // If there is an instance, and it's not me, delete myself.
    
    if (Instance != null && Instance != this) 
    { 
        Destroy(this); 
    } 
    else 
    { 
        Instance = this; 
    } 
    }
}
