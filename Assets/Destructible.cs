using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    // Start is called before the first frame update
    public static event System.Action<GameObject> OnDestructibleDestroyed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Bullet")) {
            Destroy(gameObject);
            OnDestructibleDestroyed?.Invoke(gameObject);
        }
    }
}
