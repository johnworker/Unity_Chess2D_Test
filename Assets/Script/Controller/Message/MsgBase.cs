public class MsgBase
{
	private MsgDefine.MsgID m_MsgID;

	public MsgDefine.MsgID MsgID => m_MsgID;

	public MsgBase(MsgDefine.MsgID id)
	{
		m_MsgID = id;
	}

	public T Prame<T>() where T : MsgBase
	{
		return (T)this;
	}
}
