using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] public List<Item> items;

    // Start is called before the first frame update
    void Start()
    {
        // Init the inventory
        items = new List<Item>();

        // Load inventory from save data??

    }

    // Update is called once per frame
    void Update()
    {
        // Do Nthing...

    }

    public void AddItem(Item i)
    {
        items.Add(i);
        Debug.Log($"Adding {i.name} to inventory");
    }

    public void RemoveItem(Item i)
    {
        items.Remove(i);
        Debug.Log($"Removing {i.name} to inventory");
    }

    public void RemoveItem(string itemName)
    {
        Item item = items.Find((Item i) => { return (i.name == itemName); });
        if (item is not null)
        {
            this.RemoveItem(item);
        }
        else
        {
            Debug.Log($"No item called {itemName} found!!!!!!!!");
        }
    }

    public bool hasItem(string name)
    {
        return items.Find((Item i) => { return (i.name == name); }) is not null;
    }

}
