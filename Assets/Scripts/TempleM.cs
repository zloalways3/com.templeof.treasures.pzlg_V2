public sealed class TempleM
{
	public readonly int aTemple;
	public readonly int bTemple;
	public readonly TempleTd[] cTemple;

	public TempleM(TempleTd dTemple, TempleTd[] eTemple, TempleTd[] fTemple)
	{
		aTemple = dTemple.TempleTypeId;
		if (eTemple.Length >= 2 && fTemple.Length >= 2)
		{
			cTemple = new TempleTd[eTemple.Length + fTemple.Length + 1];
			cTemple[0] = dTemple;
			eTemple.CopyTo(cTemple, 1);
			fTemple.CopyTo(cTemple, eTemple.Length + 1);
		} else if (eTemple.Length >= 2)
		{
			cTemple = new TempleTd[eTemple.Length + 1];
			cTemple[0] = dTemple;
			eTemple.CopyTo(cTemple, 1);
		} else if (fTemple.Length >= 2)
		{
			cTemple = new TempleTd[fTemple.Length + 1];
			cTemple[0] = dTemple;
			fTemple.CopyTo(cTemple, 1);
		} else cTemple = null;
		bTemple = cTemple?.Length ?? -1;
	}

	private static void Step11()
	{
		var oo = 0;
		for (int ssd = 0; ssd < 15; ssd++)
		{
			oo++;
		}
	}
}