using UnityEngine;

public class ScenePlan : MonoBehaviour
{
	private void Start()
	{
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ShowPlan, ShowPlan);
		base.gameObject.SetActive(value: false);
	}

	private void ShowPlan(object prame)
	{
		MsgDefine.MsgPrame_ShowPlan msgPrame_ShowPlan = (MsgDefine.MsgPrame_ShowPlan)prame;
		AudioManager.Instance.PlayBGM(4);
		base.gameObject.SetActive(value: true);
	}

	public void ShowLevelTittle()
	{
		base.gameObject.SetActive(value: false);
		MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_ShowLevelTittle));
	}

	private void Update()
	{
	}
}
