using System.Collections.Generic;
using UnityEngine;

public class ObjectOrientedProgramming : MonoBehaviour
{
    private List<Alien> _monsters;
    private Alien _alien;
    private void Start()
    {
        var dinosaur = new Dinosaur("Dinosaur Jack");
        var human = new Human();
        var bird = new Bird();

        ExecutePolymorhipsm(dinosaur, human, bird);
    }

    private void ExecutePolymorhipsm(Dinosaur dinosaur, Human human, Bird bird)
    {
        _monsters = new List<Alien>();
        _monsters.Add(dinosaur);
        _monsters.Add(human);
        _monsters.Add(bird);

        foreach (var monster in _monsters)
        {
            monster.PlaySound();
        }
    }
}

public abstract class Alien
{
    protected bool isBoy;
    private string identifier;
    public string Identifier => identifier;

    public Alien(string identifier, bool isBoy)
    {
        this.isBoy = isBoy;
        this.identifier = identifier;
    }

    public Alien(string identifier)
    {
        this.identifier = identifier;
        isBoy = false;
    }

    public Alien()
    {
        identifier = "Bla bla bla...";
        isBoy = true;
    }

    public virtual void PlaySound()
    {
        Debug.Log("Just a voice!");
    }

    public override string ToString()
    {
        var gender = isBoy ? "Boy" : "Woman";
        return "Identifier: " + identifier + ", Gender: " + gender;
    }
}
    
public class Dinosaur : Alien
{
    public Dinosaur(string identifier, bool isBoy) : base(identifier, isBoy) { }
    public Dinosaur(string identifier) : base(identifier) { }
    public Dinosaur() { }

    public override void PlaySound() { Debug.Log("Dinasour Sound!"); }
}

public class Bird : Alien
{
    public override void PlaySound() { Debug.Log("Bird Sound!"); }
}

public class Human : Alien { }
