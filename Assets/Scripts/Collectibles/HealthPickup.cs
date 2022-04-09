﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    PlayerMovement playerScript;
    [SerializeField]
    private int healAmount;
    [SerializeField]
    private GameObject effect;

    private void Start()
    {
        playerScript = PlayerMovement.Instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerScript.Heal(healAmount);
            Destroy(gameObject);
        }
    }
}