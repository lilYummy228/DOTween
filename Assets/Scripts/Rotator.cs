using DG.Tweening;

public class Rotator : Transformer<UnityEngine.Vector3>
{
    private void Start()
    {
        transform.DORotate(Transformation, Duration).SetLoops(Repeats, LoopType).SetEase(Ease.Linear);
    }
}
