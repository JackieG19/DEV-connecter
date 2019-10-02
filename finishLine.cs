using System;
using System.Collections.Generic;

// possible object:
// deck of cards
// cards
// die
// player
// board or game class
// marker

public class Die
{
	public bool isRed;
	public int val;
	public int sides;
	public Random rand;
	
	public Die(int sides, bool isRed)
	{
		this.sides = sides;
		this.isRed = isRed;
		this.val = 1;
	}
	
	public Die(bool isRed)
	{
		this.sides = 6;
		this.isRed = isRed;
		this.val = 1;
	}
	
	public void Roll(Random rand)
	{
		this.val = rand.Next(1, this.sides + 1);
	}
}

public class Card
{
 	public int suit;
 	public int val;
 	private Dictionary<int, string> SUIT_MAP = new Dictionary<int, string> {
 		{0, "\u2663"},
 		{1, "\u2660"},
 		{2, "\u2665"},
 		{3, "\u2666"}
 	};
 	private Dictionary<int, string> VAL_MAP = new Dictionary<int, string> {
 		{1, "Ac"},
 		{10, "10"},
 		{11, "Ja"},
 		{12, "Qu"},
 		{13, "Ki"}
 	};

 	public Card(int val, int suit)
 	{
 		this.val = val;
 		this.suit = suit;
 	}

 	public string Display()
 	{
 		if (this.val == 0)
 		{
 			return "Jkr";
 		}

 		if (this.VAL_MAP.ContainsKey(this.val))
 		{
 			return this.SUIT_MAP[this.suit] + this.VAL_MAP[this.val];
 		}

 		return this.SUIT_MAP[this.suit] + "0" + this.val;

 	}


public class Marker
{
 	public int position;
 	public string name;


 	public Marker(string name)
 	{
 		this.position = -1;
 		this.name = name;
 	}

 	public virtual void Move(int spaces) {
 		this.position += spaces;
 	}
 }

public class FLMarker : Marker
{
 	public bool stopped;
 	public FLMarker(string name) : base(name)
 	{
 		this.stopped = false;	
 	}

 	public void Move(int spaces, int stopValue)
 	{
 		// preprocessing
 		this.Move(spaces);
 		// postprocess
 	}
 }

public class Card
{
	public string suits;
	public int val;
	private dict<int, string>;
}

public class Program
{
	public static void Main()
	{
		var redDie = new Die(6, true);
		Die blackDie = new Die();
		var bigDie = new Die(100, true)
		var rand = new Random();
		Console.WriteLine("Hello World");
	}
}
