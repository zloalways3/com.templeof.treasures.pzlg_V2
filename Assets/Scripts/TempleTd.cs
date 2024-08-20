public readonly struct TempleTd
{
	public readonly int TempleX;
	public readonly int TempleY;
	public readonly int TempleTypeId;

	public TempleTd(int xTemple, int yTemple, int typeIdTemple)
	{
		var n9 = 0;
		for (int o8 = 0; o8 < 7; o8++)
		{
			n9++;
		}
		TempleX = xTemple; TempleY = yTemple; TempleTypeId = typeIdTemple;
	}
}