using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

internal class MsgManager
{
	private static MsgManager m_Instance;

	private Dictionary<MsgDefine.MsgID, UnityAction<MsgBase>> m_Listener = new Dictionary<MsgDefine.MsgID, UnityAction<MsgBase>>();

	public static MsgManager Instance
	{
		get
		{
			if (m_Instance == null)
			{
				m_Instance = new MsgManager();
			}
			return m_Instance;
		}
	}

	private MsgManager()
	{
	}

	public void Listen(MsgDefine.MsgID id, UnityAction<MsgBase> listener)
	{
		if (listener == null)
		{
			Debug.Log("监听失败 !");
		}
		else if (m_Listener.ContainsKey(id))
		{
			Dictionary<MsgDefine.MsgID, UnityAction<MsgBase>> listener2;
			MsgDefine.MsgID key;
			(listener2 = m_Listener)[key = id] = (UnityAction<MsgBase>)Delegate.Combine(listener2[key], listener);
		}
		else
		{
			m_Listener.Add(id, listener);
		}
	}

	public void Remove(MsgDefine.MsgID id, UnityAction<MsgBase> listener)
	{
		if (m_Listener.ContainsKey(id))
		{
			Dictionary<MsgDefine.MsgID, UnityAction<MsgBase>> listener2;
			MsgDefine.MsgID key;
			(listener2 = m_Listener)[key = id] = (UnityAction<MsgBase>)Delegate.Remove(listener2[key], listener);
		}
	}

	public void PostMsg(MsgBase msg)
	{
		if (m_Listener.ContainsKey(msg.MsgID))
		{
			m_Listener[msg.MsgID](msg);
		}
		else
		{
			Debug.Log("接受到未知消息!" + msg.MsgID);
		}
	}
}
