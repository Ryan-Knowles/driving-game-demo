using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Ready, Steady, Goooo!!!!!!");
    }
}
