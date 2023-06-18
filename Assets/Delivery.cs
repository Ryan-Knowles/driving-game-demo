using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.tag == "Customer")
        {
            //RequestedItem i = this.GetComponent<RequestedItem>();
            Debug.Log($"Talking to customer: {this.name}");
            Inventory myInventory = collision.gameObject.GetComponent<Inventory>();
            string itemName = $"{this.name.Split('_')[0]}_Package";
            if (myInventory.hasItem(itemName))
            {
                myInventory.RemoveItem(itemName);
            }
            myInventory.AddItem(new Item(this.name));
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.tag == "Package")
        {
            Debug.Log($"Package picked up: {this.name}");
            this.gameObject.SetActive(false);
            Inventory myInventory = collision.GetComponent<Inventory>();
            myInventory.AddItem(new Item(this.name));
        }
    }
}
