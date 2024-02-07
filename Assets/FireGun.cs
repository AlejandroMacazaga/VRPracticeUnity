using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class FireGun : MonoBehaviour
{
    
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private Transform bulletSpawn;
    [SerializeField]
    private float bulletSpeed = 30.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable interactable = GetComponent<XRGrabInteractable>();
        interactable.activated.AddListener(FireBullet);
    }
    
    void FireBullet(ActivateEventArgs arg)
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponentInChildren<ProjectileBehaviour>().SetSpeed(bulletSpeed * bulletSpawn.forward);
        Destroy(bullet, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
