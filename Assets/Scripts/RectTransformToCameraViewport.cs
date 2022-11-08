using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(RectTransform)), ExecuteAlways]
public class RectTransformToCameraViewport : UIBehaviour
{
    [SerializeField] private Camera _camera;

    public Camera Camera
    {
        get => _camera;
        set
        {
            _camera = value;
            Refresh();
        }
    }

    private Canvas _canvas;
    private Vector3[] _worldCorners = new Vector3[4];

    public void Refresh()
    {
        if (Camera && _canvas)
        {
            Camera.pixelRect = GetPixelRect();
        }
    }

    private void Update()
    {
        if (transform.hasChanged)
        {
            Refresh();
        }
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        _canvas = GetComponentInParent<Canvas>();
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        _canvas = null;
    }

    protected override void OnRectTransformDimensionsChange()
    {
        base.OnRectTransformDimensionsChange();
        Refresh();
    }

    protected override void OnValidate()
    {
        base.OnValidate();
        Refresh();
    }

    protected Rect GetPixelRect()
    {
        ((RectTransform) transform).GetWorldCorners(_worldCorners);

        Vector3 bottomLeft = _worldCorners[0];
        Vector3 topRight = _worldCorners[2];
        if (_canvas.renderMode == RenderMode.ScreenSpaceCamera && _canvas.worldCamera != null)
        {
            Camera camera = _canvas.worldCamera;
            bottomLeft = camera.WorldToScreenPoint(bottomLeft);
            topRight = camera.WorldToScreenPoint(topRight);
        }
        return Rect.MinMaxRect(bottomLeft.x, bottomLeft.y, topRight.x, topRight.y);
    }
}
