## Die abstrakte Fabrik (englisch abstract factory, kit) 
definiert eine Schnittstelle zur Erzeugung einer Familie von Objekten, 
wobei die konkreten Klassen der zu instanziierenden Objekte nicht näher festgelegt werden.

### Verwendung

Die abstrakte Fabrik wird angewendet, wenn:

* ein System unabhängig von der Art der Erzeugung seiner Produkte arbeiten soll,
* ein System mit einer oder mehreren Produktfamilien konfiguriert werden soll,
* eine Gruppe von Produkten erzeugt und gemeinsam genutzt werden soll oder
* wenn in einer Klassenbibliothek die Schnittstellen von Produkten ohne deren Implementierung bereitgestellt werden sollen.



1. Betrachten wir den folgenden Code, hier zwei Schnittstellen mit je einer Methode, nämlich DisplayBase() und DisplayTop()

```csharp

interface INormal
   {
        string DisplayBase();
   }

   interface IAboveNormal
   {
       string DisplayTop();
   }
```


2. Hier sind einige konkrete Klassen, die die Methoden der obigen Interfaces implementieren. 


```csharp
public class clsWagonR : INormal
   {
       public string DisplayBase()
       {
           return "WagonR";
       }

   }

   public class clsSwift : IAboveNormal
   {
       public string DisplayTop()
       {
           return "Swift";
       }

   }
   public class clsAudiA4 : INormal
   {
       public string DisplayBase()
       {
           return "Audi A4";
       }

   }

   public class clsAudiQ7 : IAboveNormal
   {
       public string DisplayTop()
       {
           return "Audi Q7";
       }

   }
   ```
   
   3. Nun erstellen wir das abstrakte Fabrikmuster. Im folgenden Code gibt es eine Schnittstelle, 
   die die obige Schnittstelle verbindet, d.h. INormal und IAboveNormal. Siehe auch die Klassen, die dieses Interface implementieren. 
  
  
  ```csharp
   interface Icar
{
    INormal GetNormal();
    IAboveNormal GetAboveNormal();
}

class clsMaruti : Icar
{
    public INormal GetNormal()
    {
        return new clsWagonR();
    }

    public IAboveNormal GetAboveNormal()
    {
        return new clsSwift();
    }
}

class clsAudi : Icar
{
    public INormal GetNormal()
    {
        return new clsAudiA4();
    }

    public IAboveNormal GetAboveNormal()
    {
        return new clsAudiQ7();
    }
}
  ```
   
   4. Als nächstes enthält die Klasse, die Sie unten sehen können, die Methode, 
   die entscheidet, wessen Objekt jetzt angelegt werden soll.
 
 ```csharp
class clsDecider
    {
        public string GetCarDetails(int iCarType)
        {
            Icar ObjClient=null;
            switch (iCarType)
            {
                case 1:
                    ObjClient = new clsMaruti();
                    break;
                case 2:
                     ObjClient = new clsAudi();
                    break;
                default:
                    ObjClient = new clsMaruti();
                    break;
            }

            string sOutput = "Normal Car is: "+ ObjClient.GetNormal().DisplayBase()+", Above Normal car is: "+ ObjClient.GetAboveNormal().DisplayTop();
            return sOutput;
        }
    }
 ```
 
 5. Der client code: 
    
 ```csharp   
clsDecider ObjDecider = new clsDecider();
string sResult= ObjDecider.GetCarDetails(2);
  ```
