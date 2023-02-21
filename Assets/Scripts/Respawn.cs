using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform playerRespawn;

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
            player.transform.position = playerRespawn.transform.position;
            player.transform.rotation = playerRespawn.transform.rotation;
            Physics.SyncTransforms();

            if (!fallingConveyorBelt.activeSelf)
                fallingConveyorBelt.SetActive(true);
        }
    }
}
