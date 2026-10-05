using UnityEngine;

public class W4Pigeon : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    [SerializeField] private Animator _animator;

    // REMOVE these references to other objects!
    // we're going to alert them via EVENT instead!!
   //[SerializeField] private W4Seagull[] _seagulls; 
    [SerializeField] private W4UI _ui;
   [SerializeField] private W4VFX _vfx;
    
    
   public delegate void PigeonCooDelegate();
   public event PigeonCooDelegate PigeonCooEvent;
    

    // HERE, add an event to tell other objects that the pigeon coo'd!
    void Awake()
    {
       PigeonCooEvent += Locator.Instance._w4Pigeon.Coo;
    }

    void TestMethod()
    {
        Debug.Log("This Method Is A Test!");
    }
    // don't change the code in this method!
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PigeonCooEvent?.Invoke();
        }
    }

    private void Coo ()
    {
        Debug.Log("squack!");

        // do pigeon stuff
        _audio.Play();
        _animator.SetTrigger("wiggle");

        // HERE, you'll want to REMOVE the code to "tell seagulls", "tell UI", and "tell VFX"
        // instead, fire your coo event!
        
        // tell seagulls
     foreach(W4Seagull _w4Seagull in Locator.Instance._w4Seagull)
   {
    PigeonCooEvent?.Invoke();
   }



        // tell UI
        _ui.HandlePigeonCoo();

        // tell VFX
        _vfx.HandlePigeonCoo();
    }
}
