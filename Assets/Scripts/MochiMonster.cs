using UnityEngine;
using DG.Tweening;

public enum MochiMonsterState
{
    Idle,
    Moving,
    Attack,
    Hurt
}

public class MochiMonster : MonoBehaviour
{
    [SerializeField]
    private Transform modelTf;

    private Sequence idleSequence;
    private Sequence movingSequence;
    private Sequence attackSequence;
    private Sequence hurtSequence;

    private MochiMonsterState m_State;
    public MochiMonsterState state
    {
        get
        {
            return m_State;
        }
        set
        {
            m_State = value;

            if (m_State == MochiMonsterState.Idle)
            {

            }
            else if (m_State == MochiMonsterState.Moving)
            {
            }
            else if (m_State == MochiMonsterState.Attack)
            {
            }
            else if (m_State == MochiMonsterState.Hurt)
            {
            }
        }
    }

    void Start()
    {
        m_State = MochiMonsterState.Idle;
    }

    void Update()
    {

    }

    private void CreateIdleSequence()
    {
        idleSequence = DOTween.Sequence();
        idleSequence.Append(modelTf.DOScaleY(0.2f, 1f))
                    .Append(modelTf.DOScaleY(1f, 0.5f));
    }

    private void CreateAttackSequence()
    {
    }
}
