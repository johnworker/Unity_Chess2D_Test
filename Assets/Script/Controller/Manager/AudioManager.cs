using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	private static AudioManager m_Instance;

	private AudioSource m_BGMAudioSource;

	private AudioSource m_MEAudioSource;

	private List<AudioSource> m_SEAudioSource = new List<AudioSource>();

	public static AudioManager Instance => m_Instance;

	private void Awake()
	{
		if (m_Instance == null)
		{
			m_Instance = this;
		}
		m_BGMAudioSource = base.gameObject.AddComponent<AudioSource>();
		m_BGMAudioSource.loop = true;
		m_MEAudioSource = base.gameObject.AddComponent<AudioSource>();
		m_MEAudioSource.loop = false;
		AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
		m_SEAudioSource.Add(audioSource);
		audioSource.loop = false;
	}

	private void Start()
	{
	}

	public void PlayBGM(int index)
	{
		if (index < 0 || index >= DataManager.Instance.BGMAudio.Length)
		{
			PlayBGM();
		}
		else
		{
			PlayBGM(DataManager.Instance.BGMAudio[index]);
		}
	}

	public void PlayBGM(AudioClip audio = null)
	{
		if (audio == null)
		{
			m_BGMAudioSource.Stop();
			m_BGMAudioSource.clip = audio;
		}
		else if (m_BGMAudioSource.clip != audio)
		{
			m_BGMAudioSource.clip = audio;
		}
	}

	public void PlaySE(int index)
	{
		if (index < 0 || index >= DataManager.Instance.SEAudio.Length)
		{
			PlaySE();
		}
		else
		{
			PlaySE(DataManager.Instance.SEAudio[index]);
		}
	}

	public void PlaySE(AudioClip audio = null)
	{
		if (audio == null)
		{
			return;
		}
		foreach (AudioSource item in m_SEAudioSource)
		{
			if (item.isPlaying)
			{
				continue;
			}
			item.clip = audio;
			item.Play();
			return;
		}
		AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
		m_SEAudioSource.Add(audioSource);
		audioSource.loop = false;
		audioSource.clip = audio;
		audioSource.Play();
	}

	public float GetLengthME(int MEIndex)
	{
		if (MEIndex < 0 || MEIndex >= DataManager.Instance.MEAudio.Length)
		{
			return 0f;
		}
		return DataManager.Instance.MEAudio[MEIndex].length;
	}

	public void PlayME(int index)
	{
		if (index < 0 || index >= DataManager.Instance.MEAudio.Length)
		{
			PlayME();
		}
		else
		{
			PlayME(DataManager.Instance.MEAudio[index]);
		}
	}

	public void PlayME(AudioClip audio = null)
	{
		if (audio == null)
		{
			m_MEAudioSource.clip = audio;
			m_MEAudioSource.Stop();
		}
		else
		{
			m_BGMAudioSource.Stop();
			m_MEAudioSource.clip = audio;
			m_MEAudioSource.Play();
		}
	}

	private void Update()
	{
		if (!m_BGMAudioSource.isPlaying && m_BGMAudioSource.clip != null && !m_MEAudioSource.isPlaying)
		{
			m_BGMAudioSource.Play();
		}
	}
}
