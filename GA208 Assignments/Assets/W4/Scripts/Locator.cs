using UnityEngine;

public class Locator : MonoBehaviour
{
public static Locator Instance { get; private set; }
public W4Pigeon _w4Pigeon { get; private set; }
public W4Seagull[] _w4Seagull { get; private set; }
    private void Awake() 
    {
        if (Instance != null && Instance != this)
        {
        Destroy(this);
        return;
        }
    
        Instance = this;
        GameObject pigeonObj = GameObject.FindWithTag("pigeon");
        _w4Pigeon = pigeonObj.GetComponent<W4Pigeon>();
        _w4Seagull = FindObjectsByType<W4Seagull>();
    }
   
}
