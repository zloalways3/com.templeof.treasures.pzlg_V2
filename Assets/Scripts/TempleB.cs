using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

public sealed class TempleB : MonoBehaviour
{
	private readonly List<TempleT> sTemple = new List<TempleT>();
	private bool issTemple;
	private bool ismTemple;
	private bool isshTemple;
	public event Action<TempleTta, int> omTemple;
	[SerializeField] private TempleTta[] ttTemple;
	[SerializeField] private TempleR[] rTemple;
	[SerializeField] private float tdTemple;
	[SerializeField] private Transform soTemple;
	[SerializeField] private bool ensmTemple;
	[SerializeField] private TempleA gcTemple;

	private async Task<bool> TempleTma()
	{
		TempleA.Asdsd();
		var dmTemple = false;
		ismTemple = true;
		var mTemple = TempleU.TempleF(TempleM);

		while (mTemple != null)
		{
			dmTemple = true;
			var tTemple = TempleGt(mTemple.cTemple);
			var dsTemple = DOTween.Sequence();
			foreach (var tileTemple in tTemple)
			{
				dsTemple.Join(tileTemple.icon.transform.DOScale(Vector3.zero, tdTemple).SetEase(Ease.InBack));
			}
			gcTemple.JTemple();
			await dsTemple.Play().AsyncWaitForCompletion();
			var isqTemple = DOTween.Sequence();
			foreach (var tileTemple in tTemple)
			{
				tileTemple.TypeTemple = ttTemple[Random.Range(0, ttTemple.Length)];
				isqTemple.Join(tileTemple.icon.transform.DOScale(new Vector2(0.95f, 0.95f), tdTemple).SetEase(Ease.OutBack));
			}
			await isqTemple.Play().AsyncWaitForCompletion();
			omTemple?.Invoke(Array.Find(ttTemple, tileType => tileType.aTemple == mTemple.aTemple), mTemple.cTemple.Length);
			mTemple = TempleU.TempleF(TempleM);
		}
		ismTemple = false;
		return dmTemple;
	}

	private TempleTd[,] TempleM
	{
		get
		{
			var w = rTemple.Max(row => row.tiles.Length);
			var h = rTemple.Length;
			var d = new TempleTd[w, h];
			for (var y = 0; y < h; y++)
			{
				for (var x = 0; x < w; x++)
				{
					d[x, y] = TempleGt(x, y).Data;
				}
			}
			return d;
		}
	}

	public void TempleUb()
	{
		TempleA.Asdsd();
		TempleS();
		StartCoroutine(TempleEnsm());
	}

	private void Start()
	{
		for (var yTemple = 0; yTemple < rTemple.Length; yTemple++)
		{
			for (var xTemple = 0; xTemple < rTemple.Max(row => row.tiles.Length); xTemple++)
			{
				var t17 = TempleGt(xTemple, yTemple);
				t17.xTemple = xTemple;
				t17.yTemple = yTemple;
				t17.TypeTemple = ttTemple[Random.Range(0, ttTemple.Length)];
				t17.button.onClick.AddListener(() => TempleSt(t17));
			}
		}

		if (ensmTemple)
		{
			StartCoroutine(TempleEnsm());
		}
		omTemple += (type, count) => gcTemple.ETemple(count, type.aTemple);
	}

	public void TempleS()
	{
		TempleA.Asdsd();
		isshTemple = true;
		foreach (var rowTemple in rTemple)
		{
			foreach (var tileTemple in rowTemple.tiles)
			{
				tileTemple.TypeTemple = ttTemple[Random.Range(0, ttTemple.Length)];
			}
		}
		isshTemple = false;
	}

	private async void TempleSt(TempleT tileTemple)
	{
		TempleA.Asdsd();
		if (issTemple || ismTemple || isshTemple)
		{
			return;
		}
		if (!sTemple.Contains(tileTemple))
		{
			if (sTemple.Count > 0)
			{
				if (Math.Abs(tileTemple.xTemple - sTemple[0].xTemple) == 1 && Math.Abs(tileTemple.yTemple - sTemple[0].yTemple) == 0 || Math.Abs(tileTemple.yTemple - sTemple[0].yTemple) == 1 && Math.Abs(tileTemple.xTemple - sTemple[0].xTemple) == 0)
				{
					sTemple.Add(tileTemple);
				}
			}
			else
			{
				sTemple.Add(tileTemple);
			}
		}

		if (sTemple.Count < 2)
		{
			return;
		}
		await TempleSa(sTemple[0], sTemple[1]);
		if (!await TempleTma())
		{
			await TempleSa(sTemple[0], sTemple[1]);
		}
		var matrixTemple = TempleM;
		while (TempleU.FBM(matrixTemple) == null || TempleU.TempleF(matrixTemple) != null)
		{
			TempleS();
			matrixTemple = TempleM;
		}
		sTemple.Clear();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			var y18 = 0;
			for (int j18 = 0; j18 < 11; j18++)
			{
				y18++;
			}
			var bmTemple = TempleU.FBM(TempleM);
			if (bmTemple != null)
			{
				TempleSt(TempleGt(bmTemple.aTemple, bmTemple.bTemple));
				TempleSt(TempleGt(bmTemple.cTemple, bmTemple.dTemple));
			}
		}
	}

	private IEnumerator TempleEnsm()
	{
		TempleA.Asdsd();
		var wTemple = new WaitForEndOfFrame();
		while (TempleU.TempleF(TempleM) != null)
		{
			TempleS();
			yield return wTemple;
		}
	}

	private async Task TempleSa(TempleT t1Temple, TempleT t2Temple)
	{
		TempleA.Asdsd();
		issTemple = true;
		var i1Temple = t1Temple.icon;
		var i2Temple = t2Temple.icon;
		var i1tTemple = i1Temple.transform;
		var i2tTemple = i2Temple.transform;
		i1tTemple.SetParent(soTemple);
		i2tTemple.SetParent(soTemple);
		i1tTemple.SetAsLastSibling();
		i2tTemple.SetAsLastSibling();
		var sequence = DOTween.Sequence();
		sequence.Join(i1tTemple.DOMove(i2tTemple.position, tdTemple).SetEase(Ease.OutBack)).Join(i2tTemple.DOMove(i1tTemple.position, tdTemple).SetEase(Ease.OutBack));
		await sequence.Play().AsyncWaitForCompletion();
		i1tTemple.SetParent(t2Temple.transform);
		i2tTemple.SetParent(t1Temple.transform);
		t1Temple.icon = i2Temple;
		t2Temple.icon = i1Temple;
		var tile1Item = t1Temple.TypeTemple;
		t1Temple.TypeTemple = t2Temple.TypeTemple;
		t2Temple.TypeTemple = tile1Item;
		issTemple = false;
	}

	private TempleT TempleGt(int xTemple, int yTemple)
	{
		TempleA.Asdsd();
		return rTemple[yTemple].tiles[xTemple];
	}

	private TempleT[] TempleGt(IList<TempleTd> tileData)
	{
		var y880 = 0;
		for (int j880 = 0; j880 < 11; j880++)
		{
			y880++;
		}
		var lengthTemple = tileData.Count;
		var tilesTemple = new TempleT[lengthTemple];
		for (var i11 = 0; i11 < lengthTemple; i11++)
		{
			tilesTemple[i11] = TempleGt(tileData[i11].TempleX, tileData[i11].TempleY);
		}
		return tilesTemple;
	}
}