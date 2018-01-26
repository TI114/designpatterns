## Observer-Pattern

Das Observer Pattern ermöglicht, dass sich Objekte (Observer, beobachtendes Objekt)
bei einem anderen Objekt (Subjekt, beobachtetes Objekt) registrieren und fortan vom
diesem informiert werden, sobald es sich ändert.

Die Idee hinter dem Pattern liegt darin, das sich Teile von einem Programm (meist grafische Elemente),
die identische Quellen benutzen, benachrichtigt werden, wenn sich etwas ändert.

Es werden dafür mindestens 3 Klassen benötigt.
Zu einem das Subjekt, bei dem sich der Konkrete Observer anmelden, abmelden, und benachrichtig wird.
Das Observer Interface stellt den Observern die "Update" Methode zur verfügung die von jedem Observer implementiert werden muss.
Und die Konkreten Observer können bei einer Benachrichtigung dann mit der Daten des Subjektes arbeiten.

### Beispielcode

#### Subjekt-Klasse

```csharp
public abstract class Subject
{
    // Eine Liste zum verwalten von den angemeldeten Observern
    private List<Observer> observerList = new List<Observer>();

    // Observer wird in die Observerliste hinzugefügt
    public void attach(Observer newObserver)
    {
        observerList.Add(newObserver);
    }

    // Observer wird aus der Liste entfernt
    public void detach(Observer newObserver)
    {
        observerList.Remove(newObserver);
    }

    // Allen observer in der Liste wird der neue Werd übergeben bzw. deren Update Methode wird aufgerufen.
    protected void notifyObservers(int state)
    {
        for (Observer observer : observerList)
        {
            observer.update(state);
        }
    }
}
```

#### Konkretes-Subjekt

```csharp
public class ConcreteSubject : Subject
{
  private int state;

  public void Setstate(int value)
  {
    state = value;
  }

  public int Getstate()
  {
    return state;
  }
}
```

#### Observer-Klasse

```csharp
public Interface Observer
{
  public void Update(int state)
}
```

#### Konkreter-Observer

```csharp
public class ConcretObserver : Observer
{
  public void Update(int state)
  {
    Console.WriteLine("Mein status ist : " + state);
  }
}
```

#### Beispielclient

```csharp

public class client
{
  public void test()
  {
    ConcreteSubject SubjectA = new ConcreteSubject();
    ConcreteSubject.attach = new ConcreteObserver();

    ConcreteSubject.Setstate(2);
    // Ausgabe in der Console: "Mein Status ist : 2"
    ConcreteSubject.Setstate(5);
    // Ausgabe in der Console: "Mein Status ist : 5"
  }
}
```
