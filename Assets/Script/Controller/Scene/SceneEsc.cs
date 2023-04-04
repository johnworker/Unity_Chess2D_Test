using UnityEngine;

public class SceneEsc : MonoBehaviour
{
	public GameObject Shield;

	private void Start()
	{
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_EscKeyDown, OnClickEsc);
		Shield.SetActive(value: false);
	}

	public void ExitGame()
	{
		Application.Quit();
	}

	public void ClickReset()
	{
		AudioManager.Instance.PlayBGM();
		AudioManager.Instance.PlaySE(0);
		MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
		MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_ResetMenu));
		MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_BackTitle));
		Shield.SetActive(value: false);
	}

	private void OnClickEsc(object prame)
	{
		Shield.SetActive(!Shield.activeSelf);
	}

	private void Update()
	{
	}
}
