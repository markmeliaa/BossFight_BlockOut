using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArena : MonoBehaviour
{
    [SerializeField] GameObject octogonalFloor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (octogonalFloor.activeSelf)
                StartCoroutine(DestroyFloor());
        }
    }

    IEnumerator DestroyFloor()
    {
        yield return new WaitForSeconds(2.0f);
        octogonalFloor.SetActive(false);
    }
}