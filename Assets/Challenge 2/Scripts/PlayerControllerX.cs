using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float dogCooldown = 0.5f;
    private bool dogLocked = false;

    void FixedUpdate() {
        if (!dogLocked && Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogLocked = true;
            Invoke("unlockDog", dogCooldown);
        }
    }

    private void unlockDog() {
        dogLocked = false;
    }
}
