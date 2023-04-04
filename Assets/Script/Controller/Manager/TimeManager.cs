using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class TimeManager : MonoBehaviour
{
	public class Prame
	{
		private object m_Data;

		public bool IsNull => m_Data == null;

		public Prame(object data)
		{
			m_Data = data;
		}

		public T ToData<T>()
		{
			return (T)m_Data;
		}
	}

	public class Timer
	{
		private Coroutine m_Coroutine;

		public Timer(Coroutine cor)
		{
			m_Coroutine = cor;
		}

		public void Stop()
		{
			if (m_Coroutine != null)
			{
				Instance.StopTimer(m_Coroutine);
				m_Coroutine = null;
			}
		}
	}

	private static TimeManager m_Instance;

	public static TimeManager Instance => m_Instance;

	private void Awake()
	{
		if (m_Instance == null)
		{
			m_Instance = this;
		}
	}

	private void Start()
	{
	}

	public Timer SetTimer(float time, UnityAction<Prame> call, object prame = null)
	{
		if (call == null || time < 0f)
		{
			return null;
		}
		return new Timer(StartCoroutine(Timewait(time, call, new Prame(prame))));
	}

	private void StopTimer(Coroutine timer)
	{
		if (timer != null)
		{
			StopCoroutine(timer);
		}
	}

	private void Update()
	{
	}

	private static IEnumerator Timewait(float time, UnityAction<Prame> call, Prame prame)
	{
		yield return new WaitForSeconds(time);
		call(prame);
	}
}
