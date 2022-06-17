using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TargetShooter : MonoBehaviour
{
    [SerializeField] Camera cam;
    public AudioSource GunShotSource;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GunShotSource.Play();
            
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Target target = hit.collider.gameObject.GetComponent<Target>();
                if (target != null)
                {
                    target.Hit();
                    Player.Instance.AddScore();
                }
            }
        }
    }
}
