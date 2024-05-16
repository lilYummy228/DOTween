using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(MeshRenderer))]
public class ColorSwitch : Transformer<Color>
{
    private MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();

        _meshRenderer.material.DOColor(Transformation, Duration).SetLoops(Repeats, LoopType).SetEase(Ease.Linear);
    }
}
