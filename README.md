# Klassen-HighScore

## Komplex övning där du får äva på flera moment samtidigt. 

Det här är en större övning än de som du tidigare gjort. Du kommer nu använda dig av flera saker om du lärt dig. Du ska skapa en klass som kan användas i flera tänkbara spel där man kan använda sig av en highscore. Tanken är att vilken användare som helst ska kunna använda sig av din klass, genom att importera din .cs-fil i sitt projekt.

Klassen ska innehålla vissa metoder som är specificerade nedan. Det är upp till dig att konstruera klassen och innehållet.

Läs igenom allt noga innan du börjar!

## Två klasser

Egentligen behöver du konstruera två klasser.

1. En mycket liten klass som innehåller egenskaperna namn och poäng. Klassen ska också innehålla en konstruktor som tar emot indata för name och points. Klassen ska heta HSItem (High Score item). Börja med följande kodstycke:

class HSItem
{
  string name;
  int points;
 } 
 
Du ska konstruera egenskaper för name och points.

2. Själva klassen HighScore. Detta är en mycket stor klass som innehåller många metoder. Beskrivningen för klassen finner du nedan.

## Klassen HighScore

Klassen HighScore ska innehålla följande synliga (public) metoder:
* HighScore()
* Add() -ska överlagras
* Print() -testfunktion

Klassen ska också innehålla följande osynliga (private) metod:
* Sort()

### Detaljerad beskrivning av de olika metoderna

***HighSCore()***

**Beskrivning:** Konstruktor för klassen. Tar emot helhetsvärde för hur många som får finnas i highscore-listan åt gången.

**Indata:** int maxInList 

**utdata:** - 

***Add()***

**Beskrivning:** Lägger till element i listan. Tänk på att det aldrig ska finnas fler element än vad maxInList anger. Dock ska en person med mer poäng peta ut en person med mindre poäng om listan är full.

**Indata:** string name, int points

**utdata:** - 

***Print()***

**Beskrivning:** Detta är en testmetod för att testa om koden fungerar. Denna skriver ut hela listan, med nummer (1a, 2a osv), namn och poäng till konsolen. 

**Indata:** -

**utdata:** -

***Sort***

**Beskrivning:** Detta är en osynlig (private) metod som sorterar listan. Programmeraren som använder klassen i sitt spela ska själv aldrig behöva kalla på sorteringsmetoden. Det gör du lämpligtvis när du lägger till ett element. I denna metod använder du dig av valfri sorteringsalgoritm. Googla t.ex. bubblesort C#.

**Indata:** -

**utdata:** -

Med följande kodstycke kan du testa din klass:

```class Program
{
  static void Main(string[] args)
  {
  
    // Skapa highscoreklassen, max 5 i listan
    HighScore hs = new HighScore();
    
    // Fyll på med element
    hs.Add("BobbaFett", 132);
    hs.Add("ViktorAwsome", 120);
    hs.Add("HelenaMaster", 155);
    hs.Add("CodeCodeson", 40);
    hs.Add("CaptainMorgan", 110);
    
    // Gör testutskrift
    hs.Print();
    
    // Fyll på med mer element
    hs.Add("BobTabor", 35);
    hs.Add("BullTerrier", 112);
    
    // Ny testutskrift
    hs.Print();
    
   }
   
 }```

Lycka till! Kom ihåg att den här uppgiften är mer komplex än tidigare men bra träning på många moment samtidigt :)
