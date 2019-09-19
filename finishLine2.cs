using System;
using System.Collections.Generic;

// possible object:
// deck of cards*
// cards*
// die*
// player*
// board or game class
// marker*
// FLmarker*

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
	public string suits;
	public int val;
	private readonly Dictionary<int, string> FACE_MAP = new Dictionary<>();
	
}

public Card()
{
	this.suit = suit;
	this.val = val
}

public class Deck
{
	//public int size;
	public List<Card> cards;
	
	public Deck(int[] suits, string[] values, int numofJkrs)
	{
		foreach(var suit in suits)
		{
			foreach(val in values)
			{
				var newCards = new Card(suits, val);
				this.cards.Add(newCards);
			}
		}
		if (numOfJkrs > 0)
			for (int jkr = 0; jkr < numOfJkrs; jk++)
			{
				this.cards.Add(new Card("", 0))
			}
	}
}

public void Shuffle(Random rand)
{
	for (int index =- this.cards.Count-1; index > 0; index--)
	{
		int postion = rand.Next(index + 1);
		// this.cards(position), this.cards(index) = this.cards(cards), this.cards(position)
		Card temp = this.cards(index);
		this.cards(index) = this.cards(position);
		this.cards(position) = temp;
	}
}

public class Marker
{
	public int position;
	public string name;
	
	public Marker(string name)
	{
		this.position = 0;
		this.name = name;
	}
	
	public void Move(int spaces)
	{
		this.position += spaces;
	}
}

public class FLMarker : Marker
{
	public bool stopped; 
	public class FLMarker(string name) : base(name)
	{
		return;
	}
	
	public void Move(int spaces, int stopValue)
	{
		// add in Finish line logic
	}
}

public Player(string name, string[], markers)
{
	this.name = name;
	this.markers = new Marker(markers.Length);
	for (int markerName = 0; markerName < marker.Length; markerName++)
	{
		this.markers(markerName) = new Marker(markers(markerName));
	}
	
	public string hasMarkerAt(int position)
	{
		string master = "";
			foreach(var marker in this.markers)
			{
				if (marker.position == position)
				{
					master += marker.name;
				} 
				
				else {
					marker += " ";
				}
			}
		return marker;
	}
}

// gasme class
public class FinishLine
{
	public int players;
	public Die redDie;
	public Die blackDie;
	public Deck deck;
	public Player player1;
	
	private readonly int[] RESTRICTED_VALUES = new int[] {0, 1, 2, 11, 12, 13};
	private readonly int NUM_JOKERS = 2;
	private readonly string[] SUITS = new string[] {"\u2663", "\u2660", "\u2665", "\u2666"};
	private readonly int[] VALUES = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
	private readonly string[] MARKER_NAMES = new string[] {"A", "B", "C"};
	private readonly Random rand = new Random();
	
	public FinishLine(int players, string player1Name)
	{
		this.players = players;
		this.player1Name = new Player(player1Name, this.MARKER_NAMES);
		this.redDie = new Die(6, true);
		this.blackDie = new Die(6, false);
		this.deck = new Deck(this.SUITS, this.VALUES, NUM_JOKERS);
		this.rand = new Random();
		this.deck.Shuffle(this.rand);
		this.redDie.Roll(this.rand);
		this.blackDie.Roll(this.rand);
	}
	
	public void displayBoard()
	{
		string master = "";
		// how do I want to displayed??
		// [SVV] [SVV] [SVV]
		int counter = 0;
		foreach(Card card in this.deck.cards)
		{
			master += "[" + card.Display() + "]\t";
			counter++;
			if(counter == 9)
			{
				counter = 0;
				master += "\n\n";
			} 
			
			else {
				master += "\t";
			}
		}
		Console.WriteLine(master);
	}
}

public class Program
{
	public static void Main()
	{
		//var redDie = new Die(6, true);
		//Die blackDie = new Die();
		//var bigDie = new Die(100, true)
		//var rand = new Random();
		//Console.WriteLine("Hello World");
		FinishLine game = new FinishLine(1, "Player 1");
		Console.WriteLine(game.player1.name);
		Console.WriteLine("marker {0} is at {1}", game.player1.markers[1].name, game.player1.marker[1].position);
		Console.WriteLine("firstCard is at {0}", game.deck.cards[0].Display());
		Console.WriteLine("lastCard is at {0}", game.deck.cards[53].Display());
		Console.WriteLine("redDie is at {0}", game.redDie.val);
		Console.WriteLine("blackDie is at {0}", game.redDie.val);
}
