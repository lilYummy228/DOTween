using DG.Tweening;

public class Mover : Transformer<UnityEngine.Vector3>
{
    private void Start()
    {
        transform.DOMove(Transformation, Duration).SetLoops(Repeats, LoopType).SetEase(Ease.Linear);
    }
}
