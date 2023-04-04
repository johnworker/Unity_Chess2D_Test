using UnityEngine;

public class SceneEnd : MonoBehaviour
{
	public GameObject Curtain;

	private bool m_EndFlag;

	private void Start()
	{
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_GameEnd, OnGameEnd);
		base.gameObject.SetActive(value: false);
	}

	private void OnGameEnd(object prame)
	{
		m_EndFlag = false;
		AudioManager.Instance.PlayBGM(7);
		Curtain.transform.localPosition = new Vector3(0f, -600f, 0f);
		base.gameObject.SetActive(value: true);
	}

	private void Update()
	{
		if (Curtain.transform.localPosition.y < 21250f)
		{
			Curtain.transform.localPosition = new Vector3(0f, Curtain.transform.localPosition.y + 4f, 0f);
		}
		else if (!m_EndFlag)
		{
			m_EndFlag = true;
			TimeManager.Instance.SetTimer(5f, delegate
			{
				base.gameObject.SetActive(value: false);
				MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_BackTitle));
			});
		}
	}
}
