using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasBehaviour : MonoBehaviour
{
    public PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        HealthBarHandler.SetHealthBarValue(player.health/100);
    }

    // Update is called once per frame
    void Update()
    {
        HealthBarHandler.SetHealthBarValue(player.health / 100);
    }
}
