using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<ItemData> _slots = new();
    private PlayerController _controller;

    private void Awake() => Init();

    private void Init()
    {
        _controller = GetComponent<PlayerController>();
    }

    public void GetItem(ItemData itemData)
    {
        _slots.Add(itemData);
    }

    public void UseItem(int index)
    {
        _slots[index].Use(_controller);
        _slots.RemoveAt(index);
    }
}
