using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
	private static DataManager m_Instance;

	public bool IsText;

	public Sprite[] MapElementSprite;

	public Sprite[] IconSprite;

	public Sprite[] HandSprite;

	public Sprite[] BattleSprite;

	public Sprite[] EffectSprite;

	public Sprite DamageBase;

	public Sprite[] DamageList;

	public AudioClip[] BGMAudio;

	public AudioClip[] SEAudio;

	public AudioClip[] MEAudio;

	public Material BlackAndWrite;

	public Font Font;

	private GameSuccessData m_SuccessData = new GameSuccessData();

	public static DataManager Instance => m_Instance;

	public GameSuccessData SuccessData => m_SuccessData;

	private void Awake()
	{
		if (m_Instance == null)
		{
			m_Instance = this;
		}
	}

	public int GetSchedule(int id)
	{
		if (m_SuccessData[id] == null)
		{
			return 0;
		}
		return m_SuccessData[id].Schedule;
	}

	public void SetSuccess(int id, int schedule)
	{
		if (m_SuccessData[id] == null)
		{
			return;
		}
		if (m_SuccessData[id].Schedule >= m_SuccessData[id].Target)
		{
			m_SuccessData[id].Schedule = schedule;
		}
		else
		{
			m_SuccessData[id].Schedule = schedule;
			if (m_SuccessData[id].Schedule >= m_SuccessData[id].Target)
			{
				MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ReachSuccess(id));
			}
		}
		PlayerPrefs.SetString("SuccessData", m_SuccessData.SaveData());
	}

	public List<Success> GetSuccessList()
	{
		return m_SuccessData.SuccessData;
	}

	private void Start()
	{
		if (PlayerPrefs.HasKey("SuccessData"))
		{
			m_SuccessData.LoadData(PlayerPrefs.GetString("SuccessData"));
		}
	}

	private void Update()
	{
	}
}
