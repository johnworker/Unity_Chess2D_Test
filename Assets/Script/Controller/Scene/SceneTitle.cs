using UnityEngine;
using UnityEngine.UI;

public class SceneTitle : MonoBehaviour
{
	public Image LogoUp;

	public Image LogoDown;

	public GameObject OverPanel;

	public Text SaveInfo;

	public InputField SaveData;

	public Button LoadBtn;

	private bool m_LogoShow;

	private int m_ShowLogoSpeed = Define.WindowWidth / 30;

	public GameObject ThanksBtn;

	public GameObject TrophyBtn;

	public GameObject SaveInfoPanel;

	public GameObject TextPanel;

	public InputField TextLevel;

	public InputField TextPower;

	public InputField TextExp;

	public void Derive()
	{
		SaveData.text = PlayerPrefs.GetString("Save");
	}

	public void Import()
	{
		string text = SaveData.text;
		if (!(text == string.Empty))
		{
			PlayerPrefs.SetString("Save", text);
			LoadBtn.interactable = true;
		}
	}

	public void OnClickText()
	{
		GameDataBase.Instance.ResetGameData(text: true, int.Parse((!(TextLevel.text == string.Empty)) ? TextLevel.text : "0"), int.Parse((!(TextPower.text == string.Empty)) ? TextPower.text : "0"), int.Parse((!(TextExp.text == string.Empty)) ? TextExp.text : "0"));
		MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_LoadLevel(GameDataBase.Instance.NowLevel));
		base.gameObject.SetActive(value: false);
	}

	public void EnterTitle()
	{
		TextPanel.SetActive(DataManager.Instance.IsText);
		LoadBtn.interactable = PlayerPrefs.HasKey("Save");
		if (PlayerPrefs.HasKey("SaveInfo"))
		{
			SaveInfo.text = PlayerPrefs.GetString("SaveInfo");
		}
		else
		{
			SaveInfo.text = "无存档";
		}
		LogoUp.rectTransform.anchoredPosition = new Vector3((float)Define.WindowWidth + LogoUp.flexibleWidth, LogoUp.rectTransform.anchoredPosition.y, 0f);
		LogoDown.rectTransform.anchoredPosition = new Vector3(0f - ((float)Define.WindowWidth + LogoDown.flexibleWidth), LogoDown.rectTransform.anchoredPosition.y, 0f);
		m_LogoShow = false;
		ThanksBtn.SetActive(value: true);
		TrophyBtn.SetActive(value: true);
		SaveInfoPanel.SetActive(value: true);
		base.gameObject.SetActive(value: true);
	}

	private void Start()
	{
		Screen.SetResolution(1920, 1080, fullscreen: true);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_GameOver, GameOver);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_BackTitle, BackTitle);
		EnterTitle();
		OverPanel.SetActive(value: false);
	}

	private void GameOver(object prame)
	{
		base.gameObject.SetActive(value: true);
		OverPanel.SetActive(value: true);
		TextPanel.SetActive(value: false);
		ThanksBtn.SetActive(value: false);
		TrophyBtn.SetActive(value: false);
		SaveInfoPanel.SetActive(value: false);
		TimeManager.Instance.SetTimer(AudioManager.Instance.GetLengthME(2) + 1f, delegate
		{
			EnterTitle();
			OverPanel.SetActive(value: false);
		});
	}

	private void BackTitle(object prame)
	{
		EnterTitle();
		OverPanel.SetActive(value: false);
	}

	public void OnClickStart()
	{
		GameDataBase.Instance.ResetGameData();
		MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_LoadLevel(GameDataBase.Instance.NowLevel));
		base.gameObject.SetActive(value: false);
	}

	public void OnClickTrophy()
	{
		MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_OpenSuccess));
	}

	public void OnClickLoad()
	{
		GameDataBase.Instance.ResetGameData();
		GameDataBase.Instance.Load(PlayerPrefs.GetString("Save"));
		MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_LoadLevel(GameDataBase.Instance.NowLevel));
		base.gameObject.SetActive(value: false);
	}

	private void Update()
	{
		if (!m_LogoShow)
		{
			if (LogoUp.rectTransform.anchoredPosition.x - LogoDown.rectTransform.anchoredPosition.x <= (float)m_ShowLogoSpeed)
			{
				LogoUp.rectTransform.anchoredPosition = new Vector3(0f, LogoUp.rectTransform.anchoredPosition.y, 0f);
				LogoDown.rectTransform.anchoredPosition = new Vector3(0f, LogoDown.rectTransform.anchoredPosition.y, 0f);
				AudioManager.Instance.PlayBGM(2);
				m_LogoShow = true;
			}
			else
			{
				LogoUp.rectTransform.anchoredPosition = new Vector3(LogoUp.rectTransform.anchoredPosition.x - (float)m_ShowLogoSpeed, LogoUp.rectTransform.anchoredPosition.y, 0f);
				LogoDown.rectTransform.anchoredPosition = new Vector3(LogoDown.rectTransform.anchoredPosition.x + (float)m_ShowLogoSpeed, LogoDown.rectTransform.anchoredPosition.y, 0f);
			}
		}
	}
}
