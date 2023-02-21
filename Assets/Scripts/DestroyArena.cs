using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArena : MonoBehaviour
{
    [SerializeField] GameObject fallingConveyorBelt;

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
            if (fallingConveyorBelt.activeSelf)
                StartCoroutine(DestroyFloor());
        }
    }

    IEnumerator DestroyFloor()
    {
        yield return new WaitForSeconds(2.0f);
        fallingConveyorBelt.SetActive(false);
    }
}