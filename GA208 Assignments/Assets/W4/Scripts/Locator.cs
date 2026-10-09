using UnityEngine;

public class Locator : MonoBehaviour
{
//this is what you go to to locate things, it's basically the "trunk" of the object tree

public static Locator Instance { get; private set; }
public delegate void PigeonCooDelegate();
public event PigeonCooDelegate PigeonCooEvent;

    private void Awake() 
    {
        if (Instance != null && Instance != this)
        {
        Destroy(this);
        return;
        }
    
        Instance = this;
    }
   
        public void CallCoo()
    {
            PigeonCooEvent?.Invoke();
    }

}
