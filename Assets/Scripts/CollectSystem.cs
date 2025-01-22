using UnityEngine;

public class CollectSystem : MonoBehaviour
{
    [SerializeField] private Camera characterCamera;
    [SerializeField] private Transform hand;

    [SerializeField] private CollectableItem _itemInHand;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_itemInHand)
            {
                DropItem(_itemInHand);
            }

            else
            {
               var ray = characterCamera.ViewportPointToRay(Vector3.one * 0.5f);
               RaycastHit hit;
               
               if (Physics.Raycast(ray, out hit, 2f))
               {
                   print("if");
                   
                   var collectableItem = hit.transform.GetComponent<CollectableItem>();

                   if (collectableItem)
                   {
                       CollectItem(collectableItem);
                   }
               }
            }
        }
    }

    private void CollectItem(CollectableItem item)
    {
        _itemInHand = item;
        item.RbItem.isKinematic = true;
        item.transform.parent = hand;
    }

    private void DropItem(CollectableItem item)
    {
        _itemInHand = null;
        item.transform.parent = null;
        item.RbItem.isKinematic = false;
        item.RbItem.AddForce(item.transform.forward * 2, ForceMode.VelocityChange);
    }
}