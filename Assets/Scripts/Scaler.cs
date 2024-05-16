using DG.Tweening;

public class Scaler : Transformer<UnityEngine.Vector3>
{
    private void Start()
    {
        transform.DOScale(Transformation, Duration).SetLoops(Repeats, LoopType).SetEase(Ease.Linear);
    }
}
