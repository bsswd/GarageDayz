//Attach this class to make item collectable

using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class CollectableItem : MonoBehaviour
{ 
    private Rigidbody _rigidbodyItem;
    public Rigidbody RbItem => _rigidbodyItem;

    private void Awake()
    {
        _rigidbodyItem = GetComponent<Rigidbody>();
    }
}