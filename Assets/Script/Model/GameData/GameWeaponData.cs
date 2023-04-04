using System.Collections.Generic;

public class GameWeaponData
{
	private List<Weapon> m_WeaponData = new List<Weapon>();

	public Weapon this[int id]
	{
		get
		{
			if (id >= m_WeaponData.Count || id < 0)
			{
				return null;
			}
			return m_WeaponData[id];
		}
	}

	public GameWeaponData()
	{
		m_WeaponData.Add(new Weapon("三指叉", 110, 1, 0, 40, 40));
		m_WeaponData.Add(new Weapon("连发枪", 100, 1, 50, 50, 50));
		m_WeaponData.Add(new Weapon("离子剑", 105, 1, 40, 40, 80));
		m_WeaponData.Add(new Weapon("冷冻光线", 112, 1, 40, 80, 0));
		m_WeaponData.Add(new Weapon("激光", 90, 1, 0, 30, 60));
		m_WeaponData.Add(new Weapon("高压电", 95, 1, 0, 80, 20));
		m_WeaponData.Add(new Weapon("光刀", 90, 1, 50, 60, 50));
		m_WeaponData.Add(new Weapon("导弹", 80, 4, 50, 60, 50));
		m_WeaponData.Add(new Weapon("远程导弹", 100, 4, 0, 0, 110));
		m_WeaponData.Add(new Weapon("粒子炮", 95, 4, 0, 70, 70));
		m_WeaponData.Add(new Weapon("20机枪", 120, 1, 10, 10, 10));
		m_WeaponData.Add(new Weapon("萨斯剑", 100, 1, 45, 45, 0));
		m_WeaponData.Add(new Weapon("左轮手枪", 80, 1, 60, 60, 60));
		m_WeaponData.Add(new Weapon("导弹", 90, 4, 50, 50, 50));
		m_WeaponData.Add(new Weapon("修理装置", 100, 1, 0, 0, 0, 1));
		m_WeaponData.Add(new Weapon("穿甲弹", 84, 1, 30, 70, 50));
		m_WeaponData.Add(new Weapon("光子射线", 115, 1, 0, 30, 30));
		m_WeaponData.Add(new Weapon("光剑", 110, 1, 40, 50, 50));
		m_WeaponData.Add(new Weapon("光束枪", 85, 1, 0, 60, 70));
		m_WeaponData.Add(new Weapon("盖塔战斧", 110, 1, 0, 20, 50));
		m_WeaponData.Add(new Weapon("盖塔射线", 80, 1, 0, 65, 70));
		m_WeaponData.Add(new Weapon("回旋钻", 108, 1, 50, 60, 0));
		m_WeaponData.Add(new Weapon("神风钻", 82, 1, 0, 80, 0));
		m_WeaponData.Add(new Weapon("冷冻液", 80, 1, 75, 55, 0));
		m_WeaponData.Add(new Weapon("盖塔导弹", 98, 3, 70, 0, 0));
		m_WeaponData.Add(new Weapon("光剑", 110, 1, 55, 65, 65));
		m_WeaponData.Add(new Weapon("光束枪", 85, 1, 0, 75, 85));
		m_WeaponData.Add(new Weapon("75高射炮", 110, 1, 50, 55, 55));
		m_WeaponData.Add(new Weapon("红外线枪", 90, 1, 0, 90, 0));
		m_WeaponData.Add(new Weapon("火箭弹", 120, 1, 0, 50, 50));
		m_WeaponData.Add(new Weapon("矛", 90, 1, 100, 100, 0));
		m_WeaponData.Add(new Weapon("破坏光线", 65, 1, 0, 70, 70));
		m_WeaponData.Add(new Weapon("蝶型光枪", 120, 1, 40, 40, 40));
		m_WeaponData.Add(new Weapon("离子剑", 105, 1, 40, 40, 80));
		m_WeaponData.Add(new Weapon("粒子炮", 100, 1, 0, 40, 40));
		m_WeaponData.Add(new Weapon("高能光炮", 120, 6, 50, 60, 60, 4));
		m_WeaponData.Add(new Weapon("角", 75, 1, 80, 90, 0));
		m_WeaponData.Add(new Weapon("热能剑", 110, 1, 60, 65, 65));
		m_WeaponData.Add(new Weapon("反坦克炮", 80, 1, 50, 80, 65));
		m_WeaponData.Add(new Weapon("机械爪", 120, 1, 40, 40, 40));
		m_WeaponData.Add(new Weapon("激光枪", 120, 1, 70, 40, 0));
		m_WeaponData.Add(new Weapon("扩散光炮", 120, 1, 0, 40, 40));
		m_WeaponData.Add(new Weapon("粒子炮", 95, 5, 0, 100, 100));
		m_WeaponData.Add(new Weapon("20机枪", 120, 1, 30, 30, 30));
		m_WeaponData.Add(new Weapon("激光枪", 120, 1, 40, 40, 40));
		m_WeaponData.Add(new Weapon("三栖导弹", 130, 1, 0, 100, 100));
		m_WeaponData.Add(new Weapon("防空粒子炮", 120, 1, 0, 90, 90));
		m_WeaponData.Add(new Weapon("远程粒子炮", 90, 6, 0, 150, 150));
		m_WeaponData.Add(new Weapon("20机枪", 120, 1, 70, 70, 70));
		m_WeaponData.Add(new Weapon("破坏光线", 65, 1, 0, 140, 140));
		m_WeaponData.Add(new Weapon("大炮", 80, 6, 60, 100, 50));
		m_WeaponData.Add(new Weapon("回旋镖", 120, 1, 0, 70, 70));
		m_WeaponData.Add(new Weapon("回旋镖", 100, 1, 40, 80, 80));
		m_WeaponData.Add(new Weapon("脉冲波", 120, 6, 0, 120, 120, 2));
		m_WeaponData.Add(new Weapon("步枪", 120, 7, 90, 90, 90));
		m_WeaponData.Add(new Weapon("手枪", 100, 1, 0, 70, 70));
		m_WeaponData.Add(new Weapon("鞭", 98, 1, 80, 80, 80));
		m_WeaponData.Add(new Weapon("撞击器", 98, 1, 70, 70, 70));
		m_WeaponData.Add(new Weapon("喷火器", 100, 1, 0, 80, 60));
		m_WeaponData.Add(new Weapon("机械刀", 98, 1, 50, 85, 65));
		m_WeaponData.Add(new Weapon("火焰喷射器", 80, 1, 0, 120, 0));
		m_WeaponData.Add(new Weapon("手持光束枪", 110, 1, 0, 90, 90));
		m_WeaponData.Add(new Weapon("螺旋粉碎机", 98, 1, 80, 95, 95));
		m_WeaponData.Add(new Weapon("红外线", 90, 1, 0, 50, 50));
		m_WeaponData.Add(new Weapon("激光", 90, 1, 0, 70, 100));
		m_WeaponData.Add(new Weapon("光剑", 120, 1, 105, 120, 120));
		m_WeaponData.Add(new Weapon("导弹", 80, 5, 90, 100, 90));
		m_WeaponData.Add(new Weapon("回转光束枪", 120, 4, 0, 80, 90));
		m_WeaponData.Add(new Weapon("热能炮", 90, 1, 0, 95, 105));
		m_WeaponData.Add(new Weapon("光剑", 110, 1, 70, 80, 80));
		m_WeaponData.Add(new Weapon("高能光束枪", 100, 1, 0, 110, 110));
		m_WeaponData.Add(new Weapon("光束枪", 85, 1, 0, 90, 100));
		m_WeaponData.Add(new Weapon("激光剑", 120, 5, 0, 80, 80));
		m_WeaponData.Add(new Weapon("激光战斧", 120, 1, 70, 80, 80));
		m_WeaponData.Add(new Weapon("20机枪", 120, 1, 50, 50, 50));
		m_WeaponData.Add(new Weapon("溶解液", 80, 1, 0, 110, 100));
		m_WeaponData.Add(new Weapon("粒子加农炮", 200, 1, 200, 200, 200));
		m_WeaponData.Add(new Weapon("十字捣碎机", 200, 9, 255, 255, 255));
		m_WeaponData.Add(new Weapon("组合刀", 100, 1, 40, 40, 40));
		m_WeaponData.Add(new Weapon("高压电", 95, 1, 0, 90, 50));
		m_WeaponData.Add(new Weapon("激光子母炮", 110, 5, 98, 98, 98, 4));
		m_WeaponData.Add(new Weapon("双刃战斧", 110, 1, 0, 90, 95));
		m_WeaponData.Add(new Weapon("盖塔射线", 80, 1, 0, 115, 120));
		m_WeaponData.Add(new Weapon("子母弹", 95, 7, 0, 170, 170));
		m_WeaponData.Add(new Weapon("中子刀", 110, 1, 90, 90, 90));
		m_WeaponData.Add(new Weapon("原子钻", 102, 1, 50, 130, 120));
		m_WeaponData.Add(new Weapon("链子炮", 100, 1, 75, 105, 0));
		m_WeaponData.Add(new Weapon("雷格导弹", 100, 3, 0, 95, 0));
		m_WeaponData.Add(new Weapon("气旋炮", 90, 1, 135, 80, 0));
		m_WeaponData.Add(new Weapon("鱼雷", 100, 3, 100, 0, 0));
		m_WeaponData.Add(new Weapon("气旋光束", 100, 4, 0, 90, 90));
		m_WeaponData.Add(new Weapon("双刃刀", 95, 1, 0, 120, 120));
		m_WeaponData.Add(new Weapon("反重力暴风", 110, 1, 0, 110, 110));
		m_WeaponData.Add(new Weapon("十字镖", 100, 1, 120, 120, 80));
		m_WeaponData.Add(new Weapon("激光剑", 160, 7, 120, 120, 120, 4));
		m_WeaponData.Add(new Weapon("光束枪", 95, 1, 0, 130, 140));
		m_WeaponData.Add(new Weapon("毒液", 95, 1, 0, 90, 70));
		m_WeaponData.Add(new Weapon("三栖导弹", 140, 1, 0, 120, 120));
		m_WeaponData.Add(new Weapon("激光炮", 120, 6, 150, 150, 150));
		m_WeaponData.Add(new Weapon("三栖导弹", 120, 1, 0, 80, 80));
		m_WeaponData.Add(new Weapon("激光剑", 120, 7, 0, 180, 180));
		m_WeaponData.Add(new Weapon("激光剑", 120, 6, 0, 130, 130));
		m_WeaponData.Add(new Weapon("光束枪", 90, 1, 0, 105, 115));
		m_WeaponData.Add(new Weapon("光剑", 120, 1, 85, 95, 95));
		m_WeaponData.Add(new Weapon("激光剑", 160, 9, 120, 120, 120));
		m_WeaponData.Add(new Weapon("子母弹", 95, 6, 0, 130, 130));
		m_WeaponData.Add(new Weapon("尾巴", 120, 1, 80, 80, 0));
		m_WeaponData.Add(new Weapon("激光剑", 95, 1, 0, 90, 90));
		m_WeaponData.Add(new Weapon("激光剑", 160, 7, 130, 130, 130, 4));
		m_WeaponData.Add(new Weapon("扩散光炮", 120, 1, 0, 100, 100));
		m_WeaponData.Add(new Weapon("战斧", 80, 1, 95, 100, 0));
		m_WeaponData.Add(new Weapon("近距导弹", 120, 5, 100, 100, 100));
		m_WeaponData.Add(new Weapon("超级粒子炮", 105, 1, 0, 120, 120));
		m_WeaponData.Add(new Weapon("激光子母炮", 110, 6, 118, 118, 118, 4));
		m_WeaponData.Add(new Weapon("双刃战斧", 110, 1, 0, 105, 110));
		m_WeaponData.Add(new Weapon("冲击波", 85, 1, 0, 180, 180));
		m_WeaponData.Add(new Weapon("闪电", 88, 1, 0, 160, 100));
		m_WeaponData.Add(new Weapon("光回旋镖", 102, 1, 100, 100, 100));
		m_WeaponData.Add(new Weapon("远程激光炮", 95, 6, 0, 150, 150));
		m_WeaponData.Add(new Weapon("中子炮", 100, 1, 0, 120, 120));
		m_WeaponData.Add(new Weapon("宇宙闪电", 100, 1, 0, 145, 145));
		m_WeaponData.Add(new Weapon("双面钩", 100, 1, 150, 150, 50));
		m_WeaponData.Add(new Weapon("神风导弹", 120, 5, 0, 120, 0));
		m_WeaponData.Add(new Weapon("紫外线枪", 120, 1, 0, 150, 0));
		m_WeaponData.Add(new Weapon("马林导弹", 120, 5, 120, 0, 0));
		m_WeaponData.Add(new Weapon("离子刀", 120, 1, 150, 0, 0));
		m_WeaponData.Add(new Weapon("链子炮", 100, 1, 90, 120, 0));
		m_WeaponData.Add(new Weapon("雷格导弹", 100, 4, 0, 115, 0));
		m_WeaponData.Add(new Weapon("气旋炮", 90, 1, 150, 90, 0));
		m_WeaponData.Add(new Weapon("鱼雷", 100, 4, 115, 0, 0));
		m_WeaponData.Add(new Weapon("气旋光束", 100, 5, 0, 110, 110));
		m_WeaponData.Add(new Weapon("双刃刀", 95, 1, 0, 150, 150));
		m_WeaponData.Add(new Weapon("激光剑", 160, 1, 230, 230, 230));
		m_WeaponData.Add(new Weapon("能量球", 160, 8, 220, 220, 220));
		m_WeaponData.Add(new Weapon("扩散粒子炮", 120, 1, 150, 150, 150));
		m_WeaponData.Add(new Weapon("激光子母炮", 95, 1, 0, 160, 160));
		m_WeaponData.Add(new Weapon("高能光剑", 120, 1, 110, 110, 110));
		m_WeaponData.Add(new Weapon("粒子加农炮", 85, 4, 0, 180, 180));
		m_WeaponData.Add(new Weapon("质子炮", 90, 1, 0, 180, 0));
		m_WeaponData.Add(new Weapon("压力钻", 102, 1, 110, 110, 110));
		m_WeaponData.Add(new Weapon("组合刀", 100, 1, 60, 60, 60));
		m_WeaponData.Add(new Weapon("远程激光炮", 98, 7, 0, 170, 170));
		m_WeaponData.Add(new Weapon("双刃战斧", 110, 1, 0, 120, 125));
		m_WeaponData.Add(new Weapon("冲击波", 85, 1, 0, 200, 200));
		m_WeaponData.Add(new Weapon("链子炮", 100, 1, 105, 135, 0));
		m_WeaponData.Add(new Weapon("雷格导弹", 100, 5, 0, 135, 0));
		m_WeaponData.Add(new Weapon("射线枪", 90, 1, 165, 100, 0));
		m_WeaponData.Add(new Weapon("射线枪", 100, 5, 135, 0, 0));
		m_WeaponData.Add(new Weapon("激光子母炮", 120, 7, 138, 138, 138, 4));
		m_WeaponData.Add(new Weapon("中子炮", 100, 1, 0, 150, 150));
		m_WeaponData.Add(new Weapon("锯齿刀", 100, 1, 70, 70, 70));
		m_WeaponData.Add(new Weapon("激光剑", 160, 1, 100, 100, 100));
		m_WeaponData.Add(new Weapon("离子波", 160, 7, 190, 190, 190));
		m_WeaponData.Add(new Weapon("三栖导弹", 150, 1, 0, 140, 140));
		m_WeaponData.Add(new Weapon("激光剑", 160, 7, 150, 150, 150, 4));
		m_WeaponData.Add(new Weapon("激光剑", 160, 8, 160, 160, 160, 4));
		m_WeaponData.Add(new Weapon("脉冲波", 140, 6, 0, 140, 140, 2));
	}
}
