using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private Image itemImage;
    private Transform _parentAfterDrag;
    private Vector3 _positionAfterDrag;
    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemImage.raycastTarget = false;

        _parentAfterDrag = transform.parent;
        _positionAfterDrag = _transform.localPosition;
        //transform.parent.parent.SetAsLastSibling(); // this line of code does the trick for rendering dragged image in front of other panels
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        ResetItem();
    }

    public void ResetItem()
    {
        itemImage.raycastTarget = true;
        _transform.SetParent(_parentAfterDrag);
        _transform.localPosition = _positionAfterDrag;
    }

    public void UpdateParent(Transform newParent)
    {
        _parentAfterDrag = newParent;
        _positionAfterDrag = Vector3.zero;
    }
}
