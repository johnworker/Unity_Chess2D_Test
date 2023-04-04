using UnityEngine;
using UnityEngine.UI;

public class SceneLine : MonoBehaviour
{
	public RectTransform BaseTransform;

	public Image HandImage;

	public Text NameText;

	public Text LineText;

	public Image HandObj;

	public Image NameObj;

	public Image LinObj;

	public void ShowLine(object prame)
	{
		MsgDefine.MsgPrame_Dialogue msgPrame_Dialogue = (MsgDefine.MsgPrame_Dialogue)prame;
		if (msgPrame_Dialogue.Hand == -1)
		{
			HandImage.color = new Color(0f, 0f, 0f, 0f);
			HandImage.sprite = null;
		}
		else
		{
			HandImage.color = new Color(1f, 1f, 1f, 1f);
			HandImage.sprite = DataManager.Instance.HandSprite[msgPrame_Dialogue.Hand];
		}
		NameText.text = msgPrame_Dialogue.Name;
		LineText.text = msgPrame_Dialogue.Line;
		BaseTransform.localPosition = msgPrame_Dialogue.Pos;
		base.gameObject.SetActive(value: true);
	}

	public void Close(object prame)
	{
		base.gameObject.SetActive(value: false);
	}

	private void Start()
	{
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_Dialogue, ShowLine);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_NextDialogue, Close);
		base.gameObject.SetActive(value: false);
	}

	private void Update()
	{
	}
}
