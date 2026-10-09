using UnityEngine;
using System.Collections;

public class W4Seagull : MonoBehaviour
{
        //This is a "branch" of the object tree. Use the Locator as the "trunk".
    [SerializeField] AudioSource _audio;
    [SerializeField] Animator _animator;
    [SerializeField] float _minWaitSeconds = 0.0f;
    [SerializeField] float _maxWaitSeconds = 0.5f;

    // add a new method here
    // use the Locator to find the Pigeon
    // then, subscribe the HandlePigeonCoo method to the Pigeon coo event

   public void CallCoo()
    {
            Locator.Instance.CallCoo();
    }

    void Start()
    {
        Locator.Instance.PigeonCooEvent += HandlePigeonCoo;
    }

    // don't change the code in this method!
    public void HandlePigeonCoo ()
    {
        Debug.Log("AAAHH!! " + gameObject.name);
        
        // waits a random amount of time to react, so that all seagulls don't react at the exact same time
        StartCoroutine(WaitAndSquack());
    }

    // don't change the code in this method!
    IEnumerator WaitAndSquack()
    {
        yield return new WaitForSeconds(Random.Range(_minWaitSeconds, _maxWaitSeconds));
        _audio.Play();
        _animator.SetTrigger("flap");
    }
}
