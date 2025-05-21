
using Unity.VisualScripting;
using UnityEngine;

public class Fish
{
    private int _length;
    public int Length
    {
        get
        {
            return _length;
        }
        set
        {
            if (value <= 0)
            {
                Debug.Log("Must have positive lengh value");
            }
            else
            {
                _length = value;
            }
        }
    }
    private int _weight;
    public int Weight
    {
        get
        {
            return _weight;
        }
        set
        {
            if (value <= 0)
            {
                Debug.Log("Must have positive weight value");
            }
            else
            {
                _weight = value;
            }
        }
    }
    private int _agression;
    public int Agression
    {
        get
        {
            return _agression;
        }
        set
        {
            if (value <= 0)
            {
                Debug.Log("Must have positive agression value");
            }
            else if (value > 5)
            {
                Debug.Log("Must have a agression between 1 and 5");
            }
            else
            {
                _agression = value;
            }
        }
    }

    public string Archetype
    {
        get //Returning string values for archetype to be computed at generation
        {
             if (Length <= 25)
            {
                return "Small";
            }
            else if (Length > 25 && Length <= 75)
            {
               return "Medium";
            }
            else if (Length > 75 && Length <= 180)
            {
                return "Large";
            }
            else
            {
                return "Extra Large";
            }
        }
    }

    public string GetArticle(string Archetype) //Special code for including "AN" for the Extra Large fish!
    {
        return Archetype == "Extra Large" ? "an" : "a";
    }
    // public void ConsoleNotes()
    // {
    //     Debug.Log("$You snagged {GetArticle(this.Archetype)} {this.Archetype} fish! \n With a length of {this.Length} M \n a weight of {this.Weight} Oz \n and an agression of {this.Agression}");
    // }
    public string Valuation()
    {
        return $"You snagged {GetArticle(this.Archetype)} {this.Archetype} fish! \n With a length of {this.Length} M \n a weight of {this.Weight} Oz \n and an agression of {this.Agression}";
    }
}