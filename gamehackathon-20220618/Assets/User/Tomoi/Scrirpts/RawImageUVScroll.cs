using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class RawImageUVScroll : MonoBehaviour
{
    private RawImage _rawImage;
    [SerializeField] private float _scrollSpeed = 1f;
    void Start()
    {
        _rawImage = GetComponent<RawImage>();
    }

    void Update()
    {
        var uv = _rawImage.uvRect;
        uv.y += Time.deltaTime *_scrollSpeed;
        _rawImage.uvRect = uv;
    }
}
