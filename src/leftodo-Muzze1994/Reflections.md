Kort beskrivning av kodens funktioner och struktur:


Mitt projekt innehåller en klass för varje uppgift som ska skapas samt en klass med meny och en listoftasks som innehåller metoder för att visa och lägga till uppgifter. Uppgift med en deadline ärver från klassen med den vanliga uppgiften och det var även tanken till uppgiften med en checklista för att inte skriva onödig kod. Alla uppgifter man skapar hamnar i samma lista med tasks.
Alla uppgifter tilldelas med en boolean isComplete som är false. Varje uppgift som skapas tilldelas ett id som sedan matchas med det man skriver in själv i konsollen för att välja att slutföra en uppgift. Skriver man nummer 1 så blir isComplete true för uppgiften med id 1 t.ex. Alla uppgifter tilldelas också en isArchived boolean som är false som blir true om man väljer att arkivera uppgifter. Den väljer uppgifter som har isComplete som true för att sedna göra isArchived till true. När isArchived är true så visas den uppgiften inte längre med alla uppgifter utan visas bara med andra arkiverade uppgifter.
I min klass med meny så har jag allt som visas i konsollen när man startar programmet. I klassen program ligger min statiska main-metod som innehåller en switch-sats för att välja att lägga till, visa och arkivera uppgifter. En try-catch används när man ska slutföra uppgifter och lägga till antalet dagar för att fånga om man skriver i fel format. 
Jag använder mig av virutal/override i min bas och subklass för att skriva ut allt i en print-metod för att lättare och snyggare skriva ut uppgifterna beroende på om de är slutförda/arkiverade eller inte slutförda.

Använda principer: 


Jag använder polymorfism då jag använder kod som redan finns i klassen Task vilket jag använder som en basklass och använder TaskWithDeadline som en subklass. Uppgiften med en checklista var också tänkt att användas på detta sätt så att så lite kod som möjligt behöver skrivas. Jag ärver från både Task och TaskWithDeadline till min klass ListOfTasks där jag skapar mina objekt. Enkapsulation är något jag fortfarande har väldigt svårt för och har väldigt mycket som public. Min lista är private för att den bara används i klassen ListOfTasks. Enkapsulation är bra att använda för att inte råka ''korrumpera'' kod och hålla den mer skyddad.


Tester för klasser:


Jag har använt mig av fyra tester för att kolla så att programmet fungerar som det är tänkt. 
Enhetstest 1 är för att lägga till en helt vanlig uppgift i listan, sedan gjorde jag en metod för att kolla antalet objekt i listan. En assert.equal skapades för att kolla om det fanns ett objekt i listan efter att jag använde mig av min AddTask-metod. 
Enhetstest 2 kollar om objektet man lagt in är satt som slutförd med min skapta metod CompleteTask. Jag skapade en metod för att hämta min isComplete boolean för att kolla om den ändrades till true när jag använde metoden CompleteTask.
Enhetstest 3 är i princip samma sak som enhetstest 2 för att kolla om min skapade variabel isArchived blir till true när jag använder min metod för att arkivera uppgifter efter att de blivit slutförda. 
Enhetstest 4 testar så att min uppgift med en deadline hamnar i listan på samma sätt som i enhetstest 1 fast med en annan metod som också skapar en int variabel.
