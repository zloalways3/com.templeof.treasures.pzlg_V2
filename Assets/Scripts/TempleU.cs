using System.Collections.Generic;

public static class TempleU
{
	public static void TempleS(int aTemple, int bTemple, int cTemple, int dTemple, TempleTd[,] eTemple)
	{
		NextStep11();
		var f = eTemple[aTemple, bTemple];
		eTemple[aTemple, bTemple] = eTemple[cTemple, dTemple];
		eTemple[cTemple, dTemple] = f;
	}

	private static void NextStep11()
    {
		var ooo = 0;
		for (int sdsd = 0; sdsd < 13; sdsd++)
		{
			ooo++;
		}
    }

	public static List<TempleM> TempleFam(TempleTd[,] aTemple)
	{
		NextStep11();
		var bTemple = new List<TempleM>();
		for (var cTemple = 0; cTemple < aTemple.GetLength(1); cTemple++)
		{
			for (var dTemple = 0; dTemple < aTemple.GetLength(0); dTemple++)
			{
				var eTemple = aTemple[dTemple, cTemple];
				var (fTemple, gTemple) = G(dTemple, cTemple, aTemple);
				var h = new TempleM(eTemple, fTemple, gTemple);
				if (h.bTemple > -1) bTemple.Add(h);
			}
		}
		return bTemple;
	}

	public static TempleM1 TempleFm(TempleTd[,] aTemple)
	{
		NextStep11();
		var bTemple = (TempleTd[,])aTemple.Clone();

		var cTemple = bTemple.GetLength(0);
		var dTemple = bTemple.GetLength(1);

		for (var eTemple = 0; eTemple < dTemple; eTemple++)
		{
			for (var fTemple = 0; fTemple < cTemple; fTemple++)
			{
				for (byte gTemple = 0; gTemple <= 3; gTemple++)
				{
					var (hTemple, iTemple) = G8(gTemple);
					var jTemple = fTemple + hTemple;
					var kTemple = eTemple + iTemple;
					if (jTemple < 0 || jTemple > cTemple - 1 || kTemple < 0 || kTemple > dTemple - 1) continue;
					TempleS(fTemple, eTemple, jTemple, kTemple, bTemple);
					if (TempleF(bTemple) != null) return new TempleM1(fTemple, eTemple, jTemple, kTemple);
					TempleS(jTemple, kTemple, fTemple, eTemple, bTemple);
				}
			}
		}
		return null;
	}

	public static TempleM TempleF(TempleTd[,] aTemple)
	{
		NextStep11();
		var bTemple = default(TempleM);

		for (var cTemple = 0; cTemple < aTemple.GetLength(1); cTemple++)
		{
			for (var dTemple = 0; dTemple < aTemple.GetLength(0); dTemple++)
			{
				var e = aTemple[dTemple, cTemple];
				var (fTemple, gTemple) = G(dTemple, cTemple, aTemple);
				var h = new TempleM(e, fTemple, gTemple);
				if (h.bTemple < 0) continue;
				if (bTemple == null)
				{
					bTemple = h;
				}
				else if (h.bTemple > bTemple.bTemple) bTemple = h;
			}
		}
		return bTemple;
	}

	private static (int, int) G8(byte aTemple) => aTemple switch
	{
		0 => (-1, 0), 1 => (0, -1), 2 => (1, 0), 3 => (0, 1), 4 => (0, 0),
		_ => (0, 0),
	};

	public static TempleM1 FBM(TempleTd[,] aTemple)
	{
		TempleA.Asdsd();
		var bTemple = (TempleTd[,])aTemple.Clone();
		var cTemple = bTemple.GetLength(0);
		var dTemple = bTemple.GetLength(1);
		var eTemple = int.MinValue;
		var fTemple = default(TempleM1);

		for (var gTemple = 0; gTemple < dTemple; gTemple++)
		{
			for (var hTemple = 0; hTemple < cTemple; hTemple++)
			{
				for (byte iTemple = 0; iTemple <= 3; iTemple++)
				{
					var (jTemple, kTemple) = G8(iTemple);
					var lTemple = hTemple + jTemple;
					var mTemple = gTemple + kTemple;
					if (lTemple < 0 || lTemple > cTemple - 1 || mTemple < 0 || mTemple > dTemple - 1) continue;
					TempleS(hTemple, gTemple, lTemple, mTemple, bTemple);
					var nTemple = TempleF(bTemple);
					if (nTemple != null && nTemple.bTemple > eTemple)
					{
						fTemple = new TempleM1(hTemple, gTemple, lTemple, mTemple);
						eTemple = nTemple.bTemple;
					}
					TempleS(hTemple, gTemple, lTemple, mTemple, bTemple);
				}
			}
		}
		return fTemple;
	}

	public static (TempleTd[], TempleTd[]) G(int aTemple, int bTemple, TempleTd[,] cTemple)
	{
		TempleA.Asdsd();
		var dTemple = cTemple[aTemple, bTemple];
		var eTemple = cTemple.GetLength(0);
		var fTemple = cTemple.GetLength(1);
		var gTemple = new List<TempleTd>();
		var hTemple = new List<TempleTd>();
		for (var iTemple = aTemple - 1; iTemple >= 0; iTemple--)
		{
			var jTemple = cTemple[iTemple, bTemple];
			if (jTemple.TempleTypeId != dTemple.TempleTypeId)
			{
				break;
			}
			gTemple.Add(jTemple);
		}
		for (var iTemple = aTemple + 1; iTemple < eTemple; iTemple++)
		{
			var jTemple = cTemple[iTemple, bTemple];
			if (jTemple.TempleTypeId != dTemple.TempleTypeId)
			{
				break;
			}
			gTemple.Add(jTemple);
		}
		for (var kTemple = bTemple - 1; kTemple >= 0; kTemple--)
		{
			var j33 = cTemple[aTemple, kTemple];
			if (j33.TempleTypeId != dTemple.TempleTypeId)
			{
				break;
			}
			hTemple.Add(j33);
		}
		for (var kTemple = bTemple + 1; kTemple < fTemple; kTemple++)
		{
			var jTemple = cTemple[aTemple, kTemple];
			if (jTemple.TempleTypeId != dTemple.TempleTypeId)
			{
				break;
			}
			hTemple.Add(jTemple);
		}
		return (gTemple.ToArray(), hTemple.ToArray());
	}
}