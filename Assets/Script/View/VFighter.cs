using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VFighter : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IEventSystemHandler
{
	private enum MoveState
	{
		UnMove,
		Fly,
		Moving,
		Landing
	}

	private Fighter m_Fighter;

	private List<Fighter> m_CarryFighter = new List<Fighter>();

	private Fighter m_ThisCarry;

	private GameObject m_Main;

	private GameObject m_Sub;

	private GameObject m_Effect;

	private Image m_MainImage;

	private Image m_SubImage;

	private Image m_EffectImage;

	private Canvas m_Canvas;

	private VDamage m_Damage;

	private Define.Point m_SavePoint = new Define.Point(-1, -1);

	private int m_ID;

	private int[] m_DieIndex = new int[5] { 0, 1, 2, 3, 4 };

	private int[] m_DamageIndex = new int[4] { 5, 6, 7, 8 };

	private List<int> m_CanAttackTraget = new List<int>();

	private int m_UseWeaponID = -1;

	private int m_UseSpiritID = -1;

	private List<Define.Point> m_MovePath;

	private MoveState m_MoveState;

	private float m_MoveSpeed = Define.MapElementWidth / 5f;

	private int m_Height;

	private Define.Point m_DistancePoint = new Define.Point(0, 0);

	public int X
	{
		get
		{
			return m_Fighter.X;
		}
		set
		{
			m_Fighter.X = value;
		}
	}

	public int Y
	{
		get
		{
			return m_Fighter.Y;
		}
		set
		{
			m_Fighter.Y = value;
		}
	}

	public bool IsAction
	{
		get
		{
			return m_Fighter.IsAction;
		}
		set
		{
			m_Fighter.IsAction = value;
		}
	}

	public Robot.EngineType EngineType => m_Fighter.EngineType;

	public List<int> Weapon => m_Fighter.Weapon;

	public Define.AIType AIType
	{
		get
		{
			return m_Fighter.AIType;
		}
		set
		{
			m_Fighter.AIType = value;
		}
	}

	public bool IsSelf => m_Fighter.IsSelf;

	public int ID => m_ID;

	public int HP => m_Fighter.HP;

	public int NHP => m_Fighter.NHP;

	public int SP => m_Fighter.SP;

	public int NSP => m_Fighter.NSP;

	public List<Fighter> CarryFighter => m_CarryFighter;

	public Fighter Fighter => m_Fighter;

	public Fighter ThisCarry
	{
		get
		{
			return m_ThisCarry;
		}
		set
		{
			m_ThisCarry = value;
		}
	}

	public int UseWeaponID
	{
		get
		{
			return m_UseWeaponID;
		}
		set
		{
			m_UseWeaponID = value;
		}
	}

	public int UseSpiritID
	{
		get
		{
			return m_UseSpiritID;
		}
		set
		{
			m_UseSpiritID = value;
		}
	}

	public List<int> CanAttackTraget
	{
		set
		{
			m_CanAttackTraget.Clear();
			if (value != null)
			{
				m_CanAttackTraget.AddRange(value);
			}
		}
	}

	public void Init(Fighter fighter, int id)
	{
		m_Fighter = fighter;
		m_ID = id;
		m_Sub = new GameObject("Shade");
		m_Sub.transform.SetParent(base.transform);
		m_SubImage = m_Sub.AddComponent<Image>();
		m_SubImage.color = new Color(0f, 0f, 0f, 0.7f);
		m_SubImage.rectTransform.sizeDelta = new Vector2(Define.MapElementWidth, Define.MapElementWidth);
		m_SubImage.rectTransform.localScale = new Vector3(1f, 1f, 1f);
		m_SubImage.rectTransform.pivot = new Vector2(0.5f, 0.5f);
		m_SubImage.rectTransform.localPosition = Vector2.zero;
		m_Main = new GameObject("Icon");
		m_Main.transform.SetParent(base.transform);
		m_Canvas = m_Main.AddComponent<Canvas>();
		m_Canvas.sortingOrder = 1;
		m_Main.AddComponent<GraphicRaycaster>();
		m_MainImage = m_Main.AddComponent<Image>();
		m_MainImage.rectTransform.sizeDelta = new Vector2(Define.MapElementWidth, Define.MapElementWidth);
		m_MainImage.rectTransform.pivot = new Vector2(0.5f, 0.5f);
		m_MainImage.rectTransform.localScale = new Vector3(1f, 1f, 1f);
		m_MainImage.rectTransform.localPosition = Vector2.zero;
		m_MainImage.sprite = DataManager.Instance.IconSprite[m_Fighter.Icon];
		m_Effect = new GameObject("Effect");
		m_Effect.transform.SetParent(m_Main.transform);
		m_EffectImage = m_Effect.AddComponent<Image>();
		m_EffectImage.rectTransform.sizeDelta = new Vector2(Define.MapElementWidth, Define.MapElementWidth);
		m_EffectImage.rectTransform.pivot = new Vector2(0.5f, 0.5f);
		m_EffectImage.rectTransform.localScale = new Vector3(1f, 1f, 1f);
		m_EffectImage.rectTransform.localPosition = new Vector2(0f, 0f);
		m_EffectImage.sprite = null;
		m_EffectImage.color = new Color(0f, 0f, 0f, 0f);
		m_Damage = m_Main.AddComponent<VDamage>();
		SetPosition(new Vector2((float)(m_Fighter.X + 1) * Define.MapElementWidth, (float)(m_Fighter.Y + 1) * (0f - Define.MapElementWidth)));
	}

	public void SetIcon(int index)
	{
		m_MainImage.sprite = DataManager.Instance.IconSprite[index];
	}

	public void Carry(Fighter fighter)
	{
		m_CarryFighter.Add(fighter);
	}

	public void TakeOff(Fighter fighter)
	{
		m_CarryFighter.Remove(fighter);
	}

	public void SavePoint()
	{
		m_SavePoint.X = m_Fighter.X;
		m_SavePoint.Y = m_Fighter.Y;
	}

	public void LoadPoint()
	{
		if (m_SavePoint.X != -1 && m_SavePoint.Y != -1)
		{
			m_Fighter.X = m_SavePoint.X;
			m_Fighter.Y = m_SavePoint.Y;
			m_SavePoint.X = -1;
			m_SavePoint.Y = -1;
		}
	}

	public void SetPosition(Vector3 pos)
	{
		base.transform.localPosition = pos;
	}

	public Vector3 GetPosition()
	{
		return base.transform.localPosition;
	}

	public void SetBlack(bool black)
	{
		if (black)
		{
			m_MainImage.material = DataManager.Instance.BlackAndWrite;
		}
		else
		{
			m_MainImage.material = null;
		}
	}

	public bool GetBlack()
	{
		return m_MainImage.material == DataManager.Instance.BlackAndWrite;
	}

	private void Start()
	{
	}

	public void Die(int frame = 0)
	{
		if (frame == 0)
		{
			AudioManager.Instance.PlaySE(2);
		}
		if (frame >= m_DieIndex.Length)
		{
			m_EffectImage.sprite = null;
			m_EffectImage.color = new Color(0f, 0f, 0f, 0f);
			base.gameObject.SetActive(value: false);
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_Effect));
		}
		else
		{
			m_EffectImage.sprite = DataManager.Instance.EffectSprite[m_DieIndex[frame]];
			m_EffectImage.color = new Color(1f, 1f, 1f, 1f);
			TimeManager.Instance.SetTimer(0.125f, delegate
			{
				Die(frame + 1);
			});
		}
	}

	public void Damage(int damage, int frame = 0)
	{
		if (damage >= 0)
		{
			if (frame == 0)
			{
				AudioManager.Instance.PlaySE(1);
			}
			if (frame >= m_DamageIndex.Length)
			{
				m_EffectImage.sprite = null;
				m_EffectImage.color = new Color(0f, 0f, 0f, 0f);
				m_Damage.Show((damage <= m_Fighter.NHP) ? damage : m_Fighter.NHP);
				m_Fighter.NHP -= damage;
				AudioManager.Instance.PlaySE(3);
				TimeManager.Instance.SetTimer(1.5f, delegate
				{
					m_Damage.Close();
					MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_Effect));
				});
			}
			else
			{
				m_EffectImage.sprite = DataManager.Instance.EffectSprite[m_DamageIndex[frame]];
				m_EffectImage.color = new Color(1f, 1f, 1f, 1f);
				TimeManager.Instance.SetTimer(0.125f, delegate
				{
					Damage(damage, frame + 1);
				});
			}
		}
		else if (frame >= m_DamageIndex.Length)
		{
			m_EffectImage.sprite = null;
			m_EffectImage.color = new Color(0f, 0f, 0f, 0f);
			m_Damage.Show((-damage <= m_Fighter.HP - m_Fighter.NHP) ? (-damage) : (m_Fighter.HP - m_Fighter.NHP));
			m_Fighter.NHP -= damage;
			TimeManager.Instance.SetTimer(1.5f, delegate
			{
				m_Damage.Close();
				MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_Effect));
			});
		}
		else
		{
			m_EffectImage.sprite = DataManager.Instance.EffectSprite[m_DamageIndex[frame]];
			m_EffectImage.color = new Color(1f, 1f, 1f, 1f);
			TimeManager.Instance.SetTimer(0.125f, delegate
			{
				Damage(damage, frame + 1);
			});
		}
	}

	public void ShowEffect(int id, int frame = 0, int startSE = -1, float overTime = 0f)
	{
		int[] array = m_DamageIndex;
		if (id != 0)
		{
			if (id == 1)
			{
				array = m_DieIndex;
			}
		}
		else
		{
			array = m_DamageIndex;
		}
		if (frame == 0 && startSE >= 0)
		{
			AudioManager.Instance.PlaySE(startSE);
		}
		if (frame >= array.Length)
		{
			m_EffectImage.sprite = null;
			m_EffectImage.color = new Color(0f, 0f, 0f, 0f);
			TimeManager.Instance.SetTimer(overTime, delegate
			{
				MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_Effect));
			});
		}
		else
		{
			m_EffectImage.sprite = DataManager.Instance.EffectSprite[array[frame]];
			m_EffectImage.color = new Color(1f, 1f, 1f, 1f);
			TimeManager.Instance.SetTimer(0.125f, delegate
			{
				ShowEffect(id, frame + 1, startSE, overTime);
			});
		}
	}

	public bool CanDoAttack(int tragetid)
	{
		foreach (int item in m_CanAttackTraget)
		{
			if (item == tragetid)
			{
				return true;
			}
		}
		return false;
	}

	public void DoMovePath(List<Define.Point> path)
	{
		m_MovePath = path;
		m_Canvas.overrideSorting = true;
		m_Canvas.sortingOrder++;
		m_MoveState = MoveState.Fly;
	}

	private void Fly()
	{
		m_MainImage.rectTransform.localPosition = new Vector2(m_MainImage.rectTransform.localPosition.x, m_MainImage.rectTransform.localPosition.y + m_MoveSpeed / 10f);
		m_Height++;
		if (m_Height >= 20)
		{
			m_MoveState = MoveState.Moving;
			m_DistancePoint.X = (int)((float)(m_Fighter.X - m_MovePath[0].X) * (0f - Define.MapElementWidth) * 100f);
			m_DistancePoint.Y = (int)((float)(m_Fighter.Y - m_MovePath[0].Y) * (0f - Define.MapElementWidth) * 100f);
		}
	}

	private void Moving()
	{
		if (m_DistancePoint.X == 0 && m_DistancePoint.Y == 0)
		{
			m_Fighter.X = m_MovePath[0].X;
			m_Fighter.Y = m_MovePath[0].Y;
			m_MovePath.RemoveAt(0);
			if (m_MovePath.Count == 0)
			{
				m_MovePath = null;
			}
			if (m_MovePath == null)
			{
				m_MoveState = MoveState.Landing;
			}
			else
			{
				m_DistancePoint.X = (int)((float)(m_Fighter.X - m_MovePath[0].X) * (0f - Define.MapElementWidth) * 100f);
				m_DistancePoint.Y = (int)((float)(m_Fighter.Y - m_MovePath[0].Y) * (0f - Define.MapElementWidth) * 100f);
			}
		}
		if (m_DistancePoint.X > 0)
		{
			base.transform.localPosition = new Vector2(base.transform.localPosition.x + m_MoveSpeed, base.transform.localPosition.y);
			if (m_DistancePoint.X < (int)(m_MoveSpeed * 100f))
			{
				m_DistancePoint.X = 0;
			}
			else
			{
				m_DistancePoint.X -= (int)(m_MoveSpeed * 100f);
			}
		}
		else if (m_DistancePoint.X < 0)
		{
			base.transform.localPosition = new Vector2(base.transform.localPosition.x - m_MoveSpeed, base.transform.localPosition.y);
			if (-m_DistancePoint.X < (int)(m_MoveSpeed * 100f))
			{
				m_DistancePoint.X = 0;
			}
			else
			{
				m_DistancePoint.X += (int)(m_MoveSpeed * 100f);
			}
		}
		else
		{
			if (m_DistancePoint.X != 0)
			{
				return;
			}
			if (m_DistancePoint.Y > 0)
			{
				base.transform.localPosition = new Vector2(base.transform.localPosition.x, base.transform.localPosition.y - m_MoveSpeed);
				if (m_DistancePoint.Y < (int)(m_MoveSpeed * 100f))
				{
					m_DistancePoint.Y = 0;
				}
				else
				{
					m_DistancePoint.Y -= (int)(m_MoveSpeed * 100f);
				}
			}
			else if (m_DistancePoint.Y < 0)
			{
				base.transform.localPosition = new Vector2(base.transform.localPosition.x, base.transform.localPosition.y + m_MoveSpeed);
				if (-m_DistancePoint.Y < (int)(m_MoveSpeed * 100f))
				{
					m_DistancePoint.Y = 0;
				}
				else
				{
					m_DistancePoint.Y += (int)(m_MoveSpeed * 100f);
				}
			}
		}
	}

	public void ChooseActor(Actor.ActorData[] actorData)
	{
		m_Fighter.ChooseActor(actorData);
		SetIcon(m_Fighter.Icon);
	}

	private void Landing()
	{
		m_MainImage.rectTransform.localPosition = new Vector2(m_MainImage.rectTransform.localPosition.x, m_MainImage.rectTransform.localPosition.y - m_MoveSpeed / 10f);
		m_Height--;
		if (m_Height <= 0)
		{
			m_MoveState = MoveState.UnMove;
			m_Canvas.overrideSorting = false;
			m_Canvas.sortingOrder--;
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_OnMoveOver));
		}
	}

	private void Update()
	{
		switch (m_MoveState)
		{
		case MoveState.Fly:
			Fly();
			break;
		case MoveState.Moving:
			Moving();
			break;
		case MoveState.Landing:
			Landing();
			break;
		}
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		if (m_Fighter != null)
		{
			MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ClickFighter(m_Fighter));
		}
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		if (m_Fighter != null)
		{
			MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_EnterFighter(m_Fighter));
		}
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_ExitFighter));
	}
}
